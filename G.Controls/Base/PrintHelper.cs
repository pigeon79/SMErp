using FastReport;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using G.Data;

namespace G.Controls.Printer
{
    public class PrintHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filepath">文件路径</param>
        /// <param name="tablename">new List<string>(){"master","detail"}</param>
        /// <param name="datatype">取数分类</param>
        /// <param name="condition">取数条件</param>
        public PrintHelper(string filepath, List<string> tablename, string datatype, string condition)
        {
            this.FilePath = filepath;
            this.TableName = tablename;
            InitData(datatype, condition);
        }
        public PrintHelper(string filepath, List<string> tablename, DataSet printdata)
        {
            this.FilePath = filepath;
            this.TableName = tablename;
            this.PrintData = printdata;
        }
        public string FilePath { get; set; }
        public DataSet PrintData { get; set; }
        public System.Collections.IEnumerable PrintEntity { get; set; }
        public List<string> TableName { get; set; }
        public string Operator { get; set; }        

        public void InitData(string datatype, string condition)
        {
            string sqlstr = "";
            condition = condition.Replace("'", "''");
            sqlstr = string.Format("EXEC Pro_PrintData '{0}','{1}'", datatype, condition);
            this.PrintData = DbEntry.Provider.ExecuteDataset(sqlstr);
        }
        public void Print(bool isprint)
        {
            try
            {
                if (PrintData != null)
                {
                    for( int i=0;i<PrintData.Tables.Count;i++){
                        PrintData.Tables[i].TableName = TableName[i];
                    }
                    Report report = new Report();
                    report.RegisterData(PrintData);
                    string filepath = "";
                    filepath = System.Windows.Forms.Application.StartupPath + @"\ReportFrx\" + FilePath;
                    report.Load(filepath);
                    report.SetParameterValue("Operator", Operator);
                    FastReport.DataBand data1 = report.FindObject("Data1") as FastReport.DataBand;
                    data1.DataSource = report.GetDataSource(TableName.Last());

                    if (isprint)
                    {
                        report.PrintSettings.ShowDialog = false;
                        report.Print();
                    }
                    else { report.Show(); }
                    report.Dispose();
                }
            }
            catch (Exception e) { throw e; }
            System.GC.Collect();
        }
        private Report FReport;
        public void RegistEntityData() { 
            FReport.RegisterData(PrintEntity, TableName[0]);
        }
        public void PrintByEntity(bool isprint)
        {
            try
            {
                FReport = new Report();
               
                string filepath = "";

                filepath = System.Windows.Forms.Application.StartupPath + @"\ReportFrx\" + FilePath;
                FReport.Load(filepath);
                RegistEntityData();
                //FastReport.DataBand data1 = FReport.FindObject("Data1") as FastReport.DataBand;
                //data1.DataSource = FReport.GetDataSource(TableName[0]);
                //FastReport.DataBand data2 = FReport.FindObject("Data2") as FastReport.DataBand;
                //data2.DataSource = FReport.GetDataSource(TableName[0]).ge;
                if (isprint)
                {
                    FReport.PrintSettings.ShowDialog = false;
                    FReport.Print();
                }
                else { FReport.Show(); }
                FReport.Dispose();
            }
            catch (Exception e) { throw e; }
            System.GC.Collect();
        }
    }
}
