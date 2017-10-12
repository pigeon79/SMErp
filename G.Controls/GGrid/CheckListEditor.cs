using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.ComponentModel;

namespace G.Controls.GGrid
{
    public class CheckListEditor : UITypeEditor
    {
        // ** fields
        private IWindowsFormsEditorService _edSvc;
        private CheckedListBox _list;
        private string[] _items;
        private bool _cancel;

        // ** ctor
        public CheckListEditor(string[] items)
        {
            // store reference to items being edited
            _items = items;

            // build selector list
            _list = new CheckedListBox();
            _list.BorderStyle = BorderStyle.Fixed3D;
            _list.CheckOnClick = true;
            _list.ThreeDCheckBoxes = false;
            _list.KeyPress += new KeyPressEventHandler(_list_KeyPress);
        }

        // ** overrides
        override public UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext ctx)
        {
            return UITypeEditorEditStyle.DropDown;
        }
        override public object EditValue(ITypeDescriptorContext ctx, IServiceProvider provider, object value)
        {
            // initialize editor service
            _edSvc = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));
            if (_edSvc == null)
                return value;

            // null means no flags are checked
            if (value == null)
                value = 0;

            // populate the list
            _list.Items.Clear();
            string items = value.ToString();
            foreach (string item in _items)
            {
                // add this item with the proper check state
                CheckState check = items.Contains(item) ? CheckState.Checked : CheckState.Unchecked;
                _list.Items.Add(item, check);
            }
            _list.Height = Math.Min(300, (_list.Items.Count + 1) * _list.Font.Height);
            _list.Width = 150;

            // show the list
            _cancel = false;
            _edSvc.DropDownControl(_list);

            // build return value from checked items on the list
            if (!_cancel)
            {
                // build a comma-delimited string with the checked items
                StringBuilder sb = new StringBuilder();
                foreach (object item in _list.CheckedItems)
                {
                    if (sb.Length > 0) sb.Append(", ");
                    sb.Append(item.ToString());
                }

                // convert empty string
                return (sb.Length > 0) ? sb.ToString() : "None/Other";
            }

            // done
            return value;
        }

        // ** event handlers

        // close editor if the user presses enter or escape
        private void _list_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)27:
                    _cancel = true;
                    _edSvc.CloseDropDown();
                    break;
                case (char)13:
                    _edSvc.CloseDropDown();
                    break;
            }
        }
    }
}
