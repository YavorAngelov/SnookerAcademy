using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SnookerAcadWebApp.Helpers
{
    public class ShortText
    {
        public static string CutText(string text, int maxLength = 200)
        {
            if (text.Length <= maxLength)
            {
                return text;
            }

            text = text.Substring(0, maxLength);
            return text;
        }
    }
}