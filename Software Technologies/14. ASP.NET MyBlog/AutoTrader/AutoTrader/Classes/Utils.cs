using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoTrader.Classes
{
    public class Utils
    {
        public static string CutText(string text, int maxLenght = 100)
        {
            if (text == null || text.Length <= text.Length)
            {
                return text;
            }
            else
            {
                var shortText = text.Substring(0, maxLenght) + "...";

                return shortText;
            }
        }
    }
}