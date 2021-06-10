using System;
using System.Collections.Generic;
using System.Text;

namespace Help_Jacob
{
    class Manager
    {
        /// <summary>
        /// this manager class is responsible for sending the email data to the correct type of message
        /// </summary>
       
        public enum MessageCarrier { Smtp, VMessage }

       
        //method that sends data from user
        public void SendEmail(MessageCarrier messageType, Message message,bool IsHtml)
        {
            ChekUserSettings(messageType, message, IsHtml);
        }

        //method for checking html
        void ChekUserSettings(MessageCarrier messageType, Message message, bool IsHtml)
        {
            if (IsHtml)
            {
                //convert message to HTML
                ConvertToHTML converter = new ConvertToHTML();
                message.Body = converter.Convert(message.Body);
            }

            //send the message
            SendMessage(messageType, message);
        }

        //sending the email data to processing
        void SendMessage(MessageCarrier messageType, Message message)
        {
            if (messageType == MessageCarrier.Smtp)
            {
                SendMessage_SMTP SMTP = new SendMessage_SMTP();
                //send message via SMTP
                SMTP.SendMessage(message);
            }
            else if (messageType == MessageCarrier.VMessage)
            {
                SendMessage_VMessage VMessage = new SendMessage_VMessage();
                //send message via Vmessage
                VMessage.SendMessage(message);
            }

        }

    }





}
