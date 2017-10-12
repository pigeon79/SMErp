using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace G.Controls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            C1.C1Zip.C1ZipFile czip = new C1.C1Zip.C1ZipFile();
            
            czip.Entries.Extract("aaa");
        }
    }
}
