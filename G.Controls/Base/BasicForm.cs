using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1Ribbon;
using C1.C1Zip;

namespace G.Controls.Base
{
    public partial class BasicForm : C1RibbonForm
    {
        protected static string TEMP_DIR = System.Environment.GetEnvironmentVariable("tmp");
        private ArrayList properties = null;
        private string description = "";

        public BasicForm()
        {
            InitializeComponent();
            properties = null;
            description = "";
        }
        public int? MenuId { get; set; }
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ArrayList Properties
        {
            get
            {
                if (properties == null)
                    properties = new ArrayList();

                return properties;
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Description
        {
            get
            {
                return description;
            }
        }

        //public enum ControlExplorerVisualStyleEnum { Office2007Blue, Office2007Silver, Office2007Black, Office2010Blue, Office2010Silver, Office2010Black, System };
        VisualStyle _controlExplorerVisualStyle;
        public VisualStyle ControlExplorerVisualStyle
        {
            get
            {
                return _controlExplorerVisualStyle;
            }
            set
            {
                _controlExplorerVisualStyle = value;
                OnRaiseControlExplorerVisualStyleChanged(new EventArgs());
            }
        }

        public delegate void ControlExplorerVisualStyleChanged(object sender, EventArgs e);
        public event EventHandler RaiseControlExplorerVisualStyleChanged;

        protected virtual void OnRaiseControlExplorerVisualStyleChanged(EventArgs e)
        {
            // Make a temporary copy of the event to avoid possibility of
            // a race condition if the last subscriber unsubscribes
            // immediately after the null check and before the event is raised.
            EventHandler handler = RaiseControlExplorerVisualStyleChanged;

            // Event will be null if there are no subscribers
            if (handler != null)
            {
                // Format the string to send inside the CustomEventArgs parameter

                //e.Message += String.Format(" at {0}", DateTime.Now.ToString());

                // Use the () operator to raise the event.
                handler(this, e);
            }
        }

        static public void ClearContainer(Control.ControlCollection controls)
        {
            while (controls.Count > 0)
            {
                Control c = controls[0];
                controls.Remove(c);
                c.Dispose();
            }
        }

        public virtual void DisplayIn(Control.ControlCollection controls)
        {
            try
            {
                ClearContainer(controls);
                TopLevel = false;
                FormBorderStyle = FormBorderStyle.None;
                Size = new Size(1, 1);
                controls.Add(this);
                //MainForm.Form.UpdateVisualStyle(); // propagate visual style from the main ribbon form to all child controls
                Dock = DockStyle.Fill;
                Visible = true;
                if (!isShow) Visible = false;
            }
            catch (Exception x)
            {
                Visible = false;
                throw new Exception(x.Message, x.GetBaseException());
            }
        }
        private bool isShow = true;
        public virtual void DisplayOut(int menuid) { }
        private void BasicForm_Load(object sender, EventArgs e)
        {
            isShow = LoadForm();
        }
        public virtual bool LoadForm()
        {
            return true;
        }
        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                base.Text = value;
            }
        }

    }
}
