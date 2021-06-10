using System;
using System.Collections.Generic;
using System.Text;

namespace Help_Jacob
{
    class SendMessage_VMessage : ISendMessage, ISendMessageToAll
    {
        public void SendMessage(Message m)
        {
            throw new NotImplementedException();
        }

        public void SendMessageToAll(string[] to, Message m)
        {
            throw new NotImplementedException();
        }
    }
}
