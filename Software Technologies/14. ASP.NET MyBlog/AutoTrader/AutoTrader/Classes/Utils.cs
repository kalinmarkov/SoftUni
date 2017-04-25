using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoTrader.Classes
{
    public class Utils
    {
        public static string CutText(string text, int maxLengh = 20)
        {
            if (text == null || text.Length <= maxLengh)
            {
                return text;
            }
            else
            {
                var shortText = text.Substring(0, maxLengh) + "...";

                return shortText;
            }
        }
    }
}