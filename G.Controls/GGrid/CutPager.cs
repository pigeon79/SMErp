using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace G.Controls.GGrid
{
    public delegate void EventPagingHandler(EventPagingArg e);
    public partial class CutPager : UserControl
    { 
        public CutPager()
        {
            InitializeComponent();
        }
       
        public event EventPagingHandler EventPaging;
        private int _PageSize = 0;
        private int _PageCount = 0;
        private int _AllCount = 0;

        public int PageIndex
        {
            get
            {
                int pindex = G.Core.GConvert.ToInt(this.NUM_PAGE.Value) - 1;
                if (pindex < 0) pindex = 0;
                return pindex;

            }
        }
        public int PageSize { get { return _PageSize; } set { _PageSize = value; } }
        public int PageCount { get { return _PageCount; } }
        public int AllCount
        {
            get { return _AllCount; }
            set
            {
                _AllCount = value;
                _PageCount = _PageSize > 1 ? Convert.ToInt32(Math.Ceiling((decimal)_AllCount / _PageSize)) : 1;
                InitPageInfo();
            }
        }

        private void InitPageInfo()
        {
            //string s = "/{0}页";
            //this.LAB_PAGEINFO.Text = string.Format(s, PageCount);
            string ps = "共:{0}记录 每页显示{1}条 共{2}页";
            this.LAB_PageRowsInfo.Text = string.Format(ps, AllCount, PageSize, PageCount);
        }

        private void BTN_FIRST_Click(object sender, EventArgs e)
        {
            this.NUM_PAGE.Text = "1";  
            this.EventPaging(new EventPagingArg(this.PageIndex));
        }

        private void BTN_PRV_Click(object sender, EventArgs e)
        {
            int p = G.Core.GConvert.ToInt(NUM_PAGE.Text);
            if (p > 1)
            {
                p--;
            }
            this.NUM_PAGE.Text = p.ToString(); 
            this.EventPaging(new EventPagingArg(this.PageIndex));
        }

        private void BTN_NEXT_Click(object sender, EventArgs e)
        {
            int p = G.Core.GConvert.ToInt(NUM_PAGE.Text);
            if (p < PageCount)
            {
                p++;
            }
            this.NUM_PAGE.Text = p.ToString(); 
            this.EventPaging(new EventPagingArg(this.PageIndex));
        }

        private void BTN_LAST_Click(object sender, EventArgs e)
        {
            this.NUM_PAGE.Text = PageCount.ToString(); 
            this.EventPaging(new EventPagingArg(this.PageIndex));
        }

        private void NUM_PAGE_Formatting(object sender, C1.Win.C1Input.FormatEventArgs e)
        {
            //int p = G.Core.GConvert.ToInt(e.Text);
            //if (p > PageCount || p < 1)
            //{
            //    e.Text = "1";
            //}
        }

        private void NUM_PAGE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.EventPaging(new EventPagingArg(this.PageIndex));
            }
        }


    }
    /// <summary>
    /// 自定义事件数据基类
    /// </summary>
    public class EventPagingArg : EventArgs
    {
        private int _intPageIndex;
        public int PageIndex { get { return _intPageIndex; } }
        public EventPagingArg(int PageIndex)
        {
            _intPageIndex = PageIndex;
        }
    }
}
