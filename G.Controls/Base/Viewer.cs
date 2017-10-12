using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace G.Controls.Base
{
    public partial class Viewer : UserControl
    {
        public Viewer()
        {
            InitializeComponent();
        }
        private BasicForm form;
        public Form Run(string typeName, string title, int menuid)
        {
            //C1form d = null;
            try
            {
                Control.ControlCollection items = basePanel.Controls;
                Type t = Type.GetType(typeName);

                form = t.Assembly.CreateInstance(t.FullName) as BasicForm;
                form.MenuId = menuid;
                form.DisplayIn(items);
                if (!form.Visible) { this.Visible = false; }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return form;
            
        }
        public Form ShowDialogForm(string typeName, string title, int menuid)
        {
            try
            {
                Type t = Type.GetType(typeName);
                form = t.Assembly.CreateInstance(t.FullName) as BasicForm;
                form.MenuId = menuid;
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return form;
        }
    }
}
