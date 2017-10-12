using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace G.BLL.Base
{
    public class Notice
    {
        private bool _isInited;
        private LabelType _type;
        private bool _isModified;
        private List<string> _msgList;

        private enum LabelType
        {
            Notice,
            Warning,
            Tip,
        }

        public void Reset()
        {
            Text = "";
            _isInited = false;
            _msgList = new List<string>();
        }

        public void AddWarning(string text)
        {
            CheckType(LabelType.Warning);
            _msgList.Add(text);
        }

        public void AddNotice(string text)
        {
            CheckType(LabelType.Notice);
            _msgList.Add(text);
        }

        public void AddTip(string text)
        {
            CheckType(LabelType.Tip);
            _msgList.Add(text);
        }

        private void CheckType(LabelType lt)
        {
            if (_isInited)
            {
                if (_type != lt)
                {
                    throw new Exception("You add other type text before. One process only support one type of text.");
                }
            }
            else
            {
                _isInited = true;
                _type = lt;
            }
            _isModified = true;
        }

        private string GenerateText()
        {
            return string.Join(",", _msgList.ToArray());
        }

        private void PreShowText()
        {
            if (!_isInited) return;
            if (!_isModified) return;
            Text = GenerateText();
            _isModified = false;
        }

        public string Text
        {
            get
            {
                PreShowText();
                return Text;
            }
            set
            {
                Text = value;
            }
        }

        public int Count
        {
            get
            {
                return _msgList.Count;
            }
        }
    }
}
