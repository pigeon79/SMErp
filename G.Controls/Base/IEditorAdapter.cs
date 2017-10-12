using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using G.Data.Definition;

namespace G.Controls.Base
{
    public interface IEditorAdapter
    {
        void SetData(IDbObject data);
        void SetReadOnly(bool isreadonly);
        IDbObject GetData();
    }
}
