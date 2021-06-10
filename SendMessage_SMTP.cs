using System;
using System.Collections.Generic;
using System.Text;

namespace Help_Jacob
{
    class SendMessage_SMTP : ISendMessage, ISendMessageToAll
    {
        public void SendMessage(Message m)
        {
            //this method would send the data the recipient using SMTP
            Console.WriteLine("sending email using SMTP");
        }

        public void SendMessageToAll(string[] to, Message m)
        {
            //this method would send the data to all recipients using SMTP
            Console.WriteLine("sending email to all using SMTP");
        }
    }
}
