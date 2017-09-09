using System;
using System.Collections.Generic;

namespace Entropy
{
    public class Analyzer
    {
        private Dictionary<String, Int32> frequencies = new Dictionary<String, Int32>();
        public Double entropy { get; set; }

        public void initFrequencies(Int32 languageId)
        {
            frequencies.Clear();
            switch (languageId)
            {
                case 0:
                    for (int i = 0; i < 32; i++)
                    {
                        frequencies.Add(((Char)('а' + i)).ToString(), 0);
                    }
                    frequencies.Add("ё", 0);
                    break;
                case 1:
                    for (int i = 0; i < 26; i++)
                    {
                        frequencies.Add(((Char)('a' + i)).ToString(), 0);
                    }
                    break;
            }
            frequencies.Add(".", 0);
            frequencies.Add(",", 0);
        }

        public void analyze(TextKeeper keeper)
        {
            foreach (String line in keeper.getText())
            {
                foreach (Char sym in line.ToLower())
                {
                    if (frequencies.ContainsKey(sym.ToString()))
                    {
                        frequencies[sym.ToString()] += 1;
                    }
                }
            }
        }

        public void countEntropy(TextKeeper keeper)
        {
            Double entropy = 0;
            foreach (KeyValuePair<String, Int32> pair in this.getFrequencies())
            {
                Double p_i = ((Double)pair.Value / keeper.textLength);
                if (p_i != 0)
                {
                    entropy += p_i * Math.Log(p_i, 2);
                }
            }
            entropy *= -1;
            this.entropy = entropy;
        }

        public Dictionary<String, Int32> getFrequencies()
        {
            return frequencies;
        }
    }
}
