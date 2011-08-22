using System;
using System.Collections.Generic;
using System.Text;

namespace Noogen.Validation
{
    public class MessageVo
    {
        private string _messageType;

        public string MessageType
        {
            get { return _messageType; }
            set { _messageType = value; }
        }
        private string _message;

        public string ResultMessage
        {
            get { return _message; }
            set { _message = value; }
        }

    }
}
