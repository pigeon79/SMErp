using G.Controls;
using G.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using G.Controls.Base;
using G.Controls.Input;
using G.Core;

namespace G.APP.BaseForm
{
    public partial class BaseFilter : BasicForm
    {
        public BaseFilter()
        {
            InitializeComponent(); this.Visible = false;
        }
        private void BaseFilter_Load(object sender, EventArgs e)
        {
            InitFilter();
        }
        private Condition defaultCondition = Condition.Empty;
        public Condition DefaultCondition { get { return defaultCondition; } set { defaultCondition = value; } }
        public List<FilterInfo> FilterInfos = new List<FilterInfo>();
        public void InitFilter()
        {
            int left = 20;
            int top = 15;
            foreach (FilterInfo f in FilterInfos)
            {
                switch (f.controltype)
                {
                    case "dropdown":
                        GDropDown controldrop = new GDropDown();
                        controldrop.Caption = f.caption;
                        controldrop.Location = new Point(left, top);
                        controldrop.Name = "dropdown_" + f.fieldname;
                        controldrop.Width = 200;
                        if (f.SearchForm != null)
                        {
                            controldrop.CustomerDropDownForm = f.SearchForm;
                        }
                        G.Controls.Base.Initialize.InitDropDown(controldrop, f.controldata, f.searchLogic, true);
                        if (!f.defaultvalue.IsNullOrEmpty())
                        {
                            controldrop.SetValue(f.defaultvalue);
                        }
                        this.tabPage1.Controls.Add(controldrop);
                        top += controldrop.Height + 10;
                        f.control = controldrop.Name;
                        break;
                    case "combox":
                        GCombo2 controlcombox = new GCombo2();
                        controlcombox.Caption = f.caption;
                        controlcombox.Data = f.controldata;
                        controlcombox.Name = "combox_" + f.fieldname;
                        controlcombox.Location = new Point(left, top);
                        controlcombox.Width = 200;
                        if (!f.defaultvalue.IsNullOrEmpty())
                        {
                            controlcombox.SetValue(f.defaultvalue);
                        }
                        this.tabPage1.Controls.Add(controlcombox);
                        top += controlcombox.Height + 10;
                        f.control = controlcombox.Name;
                        break;
                    case "checkbox":
                        GCheckBox controlcheckbox = new GCheckBox();
                        controlcheckbox.Caption = f.caption;
                        controlcheckbox.Name = "checkbox_" + f.fieldname;
                        controlcheckbox.Location = new Point(left, top);
                        controlcheckbox.Width = 200;
                        if (!f.defaultvalue.IsNullOrEmpty())
                        {
                            controlcheckbox.SetValue(f.defaultvalue);
                        }
                        this.tabPage1.Controls.Add(controlcheckbox);
                        top += controlcheckbox.Height + 10;
                        f.control = controlcheckbox.Name;
                        break;
                    case "date":
                    case "datetime":
                        GDate controldate = new GDate();
                        controldate.Caption = f.caption;
                        controldate.Name = "date_" + f.fieldname;
                        DefaultDate(f);
                        controldate.Width = 200;
                        controldate.Location = new Point(left, top);
                        if (!f.defaultvalue.IsNullOrEmpty())
                        {
                            controldate.SetValue(f.defaultvalue);
                        }

                        this.tabPage1.Controls.Add(controldate);
                        f.control = controldate.Name;
                        if (f.isdouble)
                        {
                            GDate controldate2 = new GDate();
                            controldate2.Caption = "一一";
                            controldate2.Name = "date2_" + f.fieldname;
                            controldate2.Location = new Point(left + controldate.Width + 20, top);
                            if (!f.defaultvalue2.IsNullOrEmpty())
                            {
                                controldate2.SetValue(f.defaultvalue2);
                            }

                            this.tabPage1.Controls.Add(controldate2);
                            f.control2 = controldate2.Name;
                        }
                        top += controldate.Height + 10;
                        break;
                    default:
                        GText controltext = new GText();
                        controltext.Caption = f.caption;
                        controltext.Name = "text_" + f.fieldname;
                        controltext.Location = new Point(left, top);
                        controltext.Width = 200;
                        if (!f.defaultvalue.IsNullOrEmpty())
                        {
                            controltext.SetValue(f.defaultvalue);
                        }
                        this.tabPage1.Controls.Add(controltext);
                        top += controltext.Height + 10;
                        f.control = controltext.Name;
                        break;
                }
            }
        }
        public Condition GetCondition()
        {
            Condition c = DefaultCondition;
            foreach (FilterInfo f in FilterInfos)
            {
                string v = "", v2 = "";
                switch (f.controltype)
                {
                    case "dropdown":
                        GDropDown cd = this.tabPage1.Controls[f.control] as GDropDown;
                        v = G.Core.GConvert.ToString(cd.GetValue());
                        if (!v.IsNullOrEmpty())
                        {
                            if (f.islike)
                            {
                                c &= CK.K[f.fieldname].Like(v);
                            }
                            else { c &= CK.K[f.fieldname].Eq(v); }
                        }
                        break;
                    case "combox":
                        GCombo2 cc = this.tabPage1.Controls[f.control] as GCombo2;
                        v = G.Core.GConvert.ToString(cc.GetValue());
                        if (!v.IsNullOrEmpty())
                        {
                            if (f.islike)
                            {
                                c &= CK.K[f.fieldname].Like(v);
                            }
                            else { c &= CK.K[f.fieldname].Eq(v); }
                        }
                        break;
                    case "datetime":
                        GDate gdt = this.tabPage1.Controls[f.control] as GDate;
                        GDate gdt2 = this.tabPage1.Controls[f.control2] as GDate;
                        v = gdt.GetValue().ToShortDateTime();
                        if (!v.IsNullOrEmpty())
                        {
                            if (f.islike)
                            {
                                c &= CK.K[f.fieldname].Like(v);
                            }
                            else if (f.isdouble)
                            {
                                v2 = "";
                                object obj2 = gdt2.GetValue();
                                if (!obj2.Equals(DBNull.Value))
                                {
                                    v2 = obj2.ToDateTime().AddDays(1).ToShortDateString();
                                }
                                c &= CK.K[f.fieldname].Ge(v);
                                c &= CK.K[f.fieldname].Le(v2);
                            }
                            else
                            {
                                string v3 = gdt.GetValue().ToDateTime().AddDays(1).ToShortDateString();
                                c &= CK.K[f.fieldname].Ge(v);
                                c &= CK.K[f.fieldname].Le(v3);
                            }
                        }
                        break;
                    case "date":
                        GDate gd = this.tabPage1.Controls[f.control] as GDate;

                        v = gd.GetValue().ToShortDateTime();
                        GDate gd2 = this.tabPage1.Controls[f.control2] as GDate;
                        v2 = gd2.GetValue().ToShortDateTime();
                        if (!v.IsNullOrEmpty())
                        {
                            if (f.islike)
                            {
                                c &= CK.K[f.fieldname].Like(v);
                            }
                            else if (f.isdouble)
                            {
                                c &= CK.K[f.fieldname].Ge(v);
                                c &= CK.K[f.fieldname].Le(v2);
                            }
                            else { c &= CK.K[f.fieldname].Eq(v); }
                        }
                        break;
                    case "checkbox":
                        GCheckBox ccb = this.tabPage1.Controls[f.control] as GCheckBox;
                        v = G.Core.GConvert.ToString(ccb.GetValue());
                        if (!v.IsNullOrEmpty())
                        {
                            c &= CK.K[f.fieldname].Eq(v);
                        }
                        break;
                    default:
                        GText gt = this.tabPage1.Controls[f.control] as GText;
                        v = G.Core.GConvert.ToString(gt.GetValue());
                        if (!v.IsNullOrEmpty())
                        {
                            if (f.islike)
                            {
                                c &= CK.K[f.fieldname].Like(v);
                            }
                            else { c &= CK.K[f.fieldname].Eq(v); }
                        }
                        break;
                }
            }
            if (c == null) { c = Condition.Empty; }
            return c;
        }

        private void c1Button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void c1Button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void DefaultDate(FilterInfo f)
        {
            if (!f.controldata.IsNullOrEmpty())
            {
                DateTime dnow = DateTime.Now;
                switch (f.controldata)
                {
                    case "今天":
                        f.defaultvalue = dnow.ToShortDateString();
                        f.defaultvalue2 = dnow.ToShortDateString();
                        break;
                    case "本月":
                        f.defaultvalue = new DateTime(dnow.Year, dnow.Month, 1).ToShortDateString();
                        f.defaultvalue2 = new DateTime(dnow.Year, dnow.Month, 1).AddMonths(1).AddDays(-1).ToShortDateString();
                        break;
                    case "本年":
                        f.defaultvalue = new DateTime(dnow.Year, 1, 1).ToShortDateString();
                        f.defaultvalue2 = new DateTime(dnow.Year, 12, 31).ToShortDateString();
                        break;
                }
            }
        }
    }
    public class FilterInfo
    {
        /// <summary>
        /// 标题
        /// </summary>
        public string caption { get; set; }
        /// <summary>
        /// 控件类型
        /// </summary>
        public string controltype { get; set; }
        /// <summary>
        /// drop 查询对象类型
        /// combbox 查询数据
        /// </summary>
        public string controldata { get; set; }
        /// <summary>
        /// 默认值
        /// </summary>
        public string defaultvalue { get; set; }
        /// <summary>
        /// 默认值2
        /// </summary>
        public string defaultvalue2 { get; set; }
        public bool islike { get; set; }
        /// <summary>
        /// 校验类型 1-非空
        /// </summary>
        public int validtype { get; set; }
        /// <summary>
        /// 是否两个控件
        /// </summary>
        public bool isdouble { get; set; }
        public string fieldname { get; set; }
        public string fieldtype { get; set; }
        public G.Interface.BLL.ISearch searchLogic { get; set; }
        public string control { get; set; }
        public string control2 { get; set; }
        public BaseSearchForm SearchForm { get; set; }

    }
}
