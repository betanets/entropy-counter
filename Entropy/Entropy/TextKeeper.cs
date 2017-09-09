using System;
using System.Collections.Generic;

namespace Entropy
{
    public class TextKeeper
    {
        private List<String> text = new List<String>();
        public Int64 textLength { get; set; }

        public List<String> getText()
        {
            return text;
        }

        public void addLine(String str)
        {
            text.Add(str);
        }

        public void clearText()
        {
            this.text.Clear();
        }
    }
}
