using System;

namespace Entropy
{
    static class Helper
    {
        public static Int32 getCharIndex(Char symbol, Int32 languageId)
        {
            if (symbol >= 'а' && symbol <= 'я')
            {
                return (symbol - 'а');
            }
            else if (symbol >= 'a' && symbol <= 'z')
            {
                return (symbol - 'a');
            }
            else if (symbol == 'ё')
            {
                return 32;
            }
            else if (symbol == '.')
            {
                if (languageId == 0)
                {
                    return 33;
                }
                else if (languageId == 1)
                {
                    return 26;
                }
            }
            else if (symbol == ',')
            {
                if (languageId == 0)
                {
                    return 34;
                }
                else if (languageId == 1)
                {
                    return 27;
                }
            }
            return -1;
        }

        public static Char getCharByIndex(Int32 index, Int32 languageId)
        {
            switch (languageId)
            {
                case 0:
                    if (index >= 0 && index < 32)
                    {
                        return (Char)('а' + index);
                    }
                    else if(index == 32)
                    {
                        return 'ё';
                    }
                    else if(index == 33)
                    {
                        return '.';
                    }
                    else if(index == 34)
                    {
                        return ',';
                    }
                    break;
                case 1:
                    if (index >= 0 && index < 26)
                    {
                        return (Char)('a' + index);
                    }
                    else if (index == 26)
                    {
                        return '.';
                    }
                    else if (index == 27)
                    {
                        return ',';
                    }
                    break;
            }
            return ' ';
        }
    }
}
