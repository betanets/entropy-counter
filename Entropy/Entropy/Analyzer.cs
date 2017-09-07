using System;
using System.Collections.Generic;

namespace Entropy
{
    public class Analyzer
    {
        private Dictionary<String, Int32> entropy = new Dictionary<String, Int32>();

        public void initEntropy()
        {
            entropy.Clear();
            for (int i = 0; i < 32; i++)
            {
                entropy.Add(((Char)('а' + i)).ToString(), 0);
            }
            entropy.Add("ё", 0);
            entropy.Add(".", 0);
            entropy.Add(",", 0);
            //entropy.Add(" ", 0);
        }

        public void analyze(TextKeeper keeper)
        {
            foreach (String line in keeper.getText())
            {
                foreach (Char sym in line.ToLower())
                {
                    if (entropy.ContainsKey(sym.ToString()))
                    {
                        entropy[sym.ToString()] += 1;
                    }
                }
            }
        }

        public Dictionary<String, Int32> getEntropy()
        {
            return entropy;
        }
    }
}
