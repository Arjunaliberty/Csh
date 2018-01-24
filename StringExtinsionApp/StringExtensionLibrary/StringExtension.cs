using System.Text.RegularExpressions;

namespace StringExtensionLibrary
{
    /// <summary>
    /// Класс расширяющий тип string
    /// </summary>
    public static class StringExtension
    {
        /// <summary>
        /// Метод расширания для типа string считающий количество слов в строке
        /// </summary>
        /// <param name="str">Параметр типа string</param>
        /// <returns>Возвращает количество слов в строке или -1 если строка пуста</returns>
        public static int CountWordsString(this string str)
        {
            int result = -1;
            Regex regex = new Regex(@"[a-zа-я]+", RegexOptions.IgnoreCase);

            if(str != "")
            {
                result = regex.Matches(str).Count;
            }
            
            return result;
        }

        /// <summary>
        /// Метод расширания для типа string считающий количество гласных букв в строке
        /// </summary>
        /// <param name="str">Параметр типа string</param>
        /// <returns>Возвращает количество гласных букв в строке или -1 если строка пуста</returns>
        public static int CountVowelString(this string str)
        {
            int result = -1;
            Regex regex = new Regex(@"[aieuyаеёиоуыюя]", RegexOptions.IgnoreCase);

            if(str != "")
            {
                result = regex.Matches(str).Count;
            }

            return result;
        }

        /// <summary>
        /// Метод расширания для типа string инвертирующий строку
        /// </summary>
        /// <param name="str">Параметр типа string</param>
        /// <returns>Возвращает инвертированную строку или null если строка пуста</returns>
        public static string InvertString(this string str)
        {
            string result = null;
            string[] stringArray = null;
            char[] separator = new char[] { ' ', ',', '?', '!', '-' };
            
            if(str != "")
            {
                stringArray = str.Split(separator);

                for (int i = 0; i < stringArray.Length; i++)
                {
                    result += stringArray[stringArray.Length - i - 1] + " ";
                }
            }

            return result;
        }
    }
}
