using System;
using System.Collections.Generic;
using System.Text;

namespace Help_Jacob
{
    interface ISendMessageToAll
    {
        void SendMessageToAll(string[] to, Message m);
    }
}
