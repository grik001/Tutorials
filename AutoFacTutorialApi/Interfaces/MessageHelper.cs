using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoFacTutorialApi.Interfaces
{
    public interface IMessageHelper
    {
        string GetMessage();
    }

    public class MessageHelper : IMessageHelper
    {
        public string GetMessage()
        {
            return "Injected";
        }
    }
}