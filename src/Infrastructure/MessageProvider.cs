using System;
using System.Collections.Generic;
using System.Text;
using Core.Interfaces;

namespace Infrastructure
{
    public class MessageProvider:IMessageProvider
    {
        public string GetMessage()
        {
            return this.ToString();
        }
    }
}
