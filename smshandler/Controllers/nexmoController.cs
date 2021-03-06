﻿using System.Web.Mvc;

namespace smshandler.Controllers
{
    /// <summary>
    /// Called via the route api/nexmo
    /// 
    /// You can find the nexmo documentation here: http://nexmo.com/documentation/index.html
    /// Handling the inbound message: http://nexmo.com/documentation/index.html#mo
    /// Creating the outgoing text message: http://nexmo.com/documentation/index.html#txt
    /// </summary>
    public class NexmoController : Controller
    {
        public static string commandFile = "nexmoCommandFile.txt";
        // GET api/values
        public string ProcessText()
        {
            // Log Text Message
            // Read the command file and Create Outgoing Text Message
            SendOutgoingMessage("message");
            return "Success";
        }

        private void SendOutgoingMessage(string message)
        {
            var json = GenerateMessageUrl(message);
            // make an http request to nexmo here.
        }

        private string GenerateMessageUrl(string message)
        {
            return message;  // should return the json string as specified in the nexmo documentation
        }

        /// <summary>
        /// Use this method as an easy way to test the outgoing sms message
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public string GetMessageUrl(string message)
        {
            return GenerateMessageUrl(message);
        }
    }
}