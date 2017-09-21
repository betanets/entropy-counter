using System;
using System.Collections.Generic;

namespace Entropy
{
    public class Analyzer
    {
        private Dictionary<String, Int32> absoluteFrequencies = new Dictionary<String, Int32>();
        private Int32[ , ] conditionalFrequencies;

        public Double entropy { get; set; }
        public Double performance { get; set; }
        public Int64 textLength { get; set; }

        public void initAbsoluteFrequencies(Int32 languageId)
        {
            absoluteFrequencies.Clear();
            switch (languageId)
            {
                case 0:
                    for (int i = 0; i < 32; i++)
                    {
                        absoluteFrequencies.Add(((Char)('а' + i)).ToString(), 0);
                    }
                    absoluteFrequencies.Add("ё", 0);
                    break;
                case 1:
                    for (int i = 0; i < 26; i++)
                    {
                        absoluteFrequencies.Add(((Char)('a' + i)).ToString(), 0);
                    }
                    break;
            }
            absoluteFrequencies.Add(".", 0);
            absoluteFrequencies.Add(",", 0);
        }

        public void initConditionalFrequencies(Int32 languageId)
        {
            switch (languageId)
            {
                case 0:
                    conditionalFrequencies = new Int32[35, 35];
                    Array.Clear(conditionalFrequencies, 0, 35);
                    break;
                case 1:
                    conditionalFrequencies = new Int32[28, 28];
                    Array.Clear(conditionalFrequencies, 0, 28);
                    break;
            }
        }

        public void analyze(TextKeeper keeper)
        {
            foreach (String line in keeper.getText())
            {
                foreach (Char sym in line.ToLower())
                {
                    if (absoluteFrequencies.ContainsKey(sym.ToString()))
                    {
                        absoluteFrequencies[sym.ToString()] += 1;
                    }
                }
            }
        }

        public void analyzeConditional(TextKeeper keeper, Int32 languageId)
        {
            Char symbolFirst, symbolSecond;
            Int32 indexFirst, indexSecond;
            Int64 currentTextLength = 0;
            foreach (String line in keeper.getText())
            {
                for(int i = 0; i < line.Length; i++)
                {
                    symbolFirst = line[i];
                    indexFirst = Helper.getCharIndex(symbolFirst, languageId);

                    if (i != line.Length - 1)
                    {
                        symbolSecond = line[i + 1];
                        indexSecond = Helper.getCharIndex(symbolSecond, languageId);
                        if(indexFirst != -1 && indexSecond != -1)
                        {
                            conditionalFrequencies[indexFirst, indexSecond] += 1;
                            currentTextLength++;
                        }
                    }
                }
            }
            this.textLength = currentTextLength;
        }

        public void countEntropy(TextKeeper keeper)
        {
            Double entropy = 0;
            foreach (KeyValuePair<String, Int32> pair in this.getAbsoluteFrequencies())
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

        public void countPerformance(TextKeeper keeper)
        {
            Double performance = 0;
            Int32 arraySize = conditionalFrequencies.GetLength(0);

            // Длина текста может быть разной: 
            // Хранитель знает полную длину текста из всех символов
            // Анализатор знает длину текста значащих символов
            for (int i = 0; i < arraySize; i++)
            {
                int j = 0;
                foreach (KeyValuePair<String, Int32> pair in this.getAbsoluteFrequencies())
                {
                    Double p_j = ((Double)pair.Value / textLength);
                    Double p_i_j = ((Double)conditionalFrequencies[i, j] / textLength);
                    if (p_i_j != 0) {
                        performance += p_i_j * p_j * Math.Log(p_i_j, 2);
                    }
                    j++;
                }
            }
            performance *= -1;
            this.performance = performance;
        }

        public Dictionary<String, Int32> getAbsoluteFrequencies()
        {
            return absoluteFrequencies;
        }

        public Int32[ , ] getConditionalFrequencies()
        {
            return conditionalFrequencies;
        }
    }
}
