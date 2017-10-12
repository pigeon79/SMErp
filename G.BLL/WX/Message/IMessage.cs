using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace G.BLL.WX.Message
{
    public interface IMessage
    {
        //delegate void ReceiveMessage();
        //delegate string ReturnMessage();

        string Template { get; set; }
        string ReturnXml();
        void ReceiveXml();
    }
}
