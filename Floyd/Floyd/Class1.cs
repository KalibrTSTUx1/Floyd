using System.Text;
using System.Text.RegularExpressions;

namespace Floyd
{
    public static class Class1
    {
        public static string[] Floyd(string[] src)
        {
            string[] res;
            //заполняем результирующий массив строками которые до пробельной
            res = Class1.FillArrWOSpaces(src);
            //превращаем строки неправильного формата в корректный
            res = Class1.FormatStrArr(res);
            //превращаем в массив строк по 30 символов
            res = Class1.ConvertToCorrectStrArr(res);
            return res;
        }
        /// <summary>
        /// Конвертирует массив строк в другой массив строк, в котором
        /// длина каждой строки не превышает 30 символов
        /// </summary>
        /// <param name="arr">Исходный массив строк</param>
        /// <returns>Массив строк, длина которых не превышает 30</returns>
        public static string[] ConvertToCorrectStrArr(string[] arr)
        {
            string substr = "";
            List<string> res = new();
            for (int i = 0; i < arr.Length; i++)
            {
                foreach (string elem in arr[i].Split(" "))
                {
                    if (substr.Length + elem.Length <= 30)
                    {
                        substr += elem;
                        substr += " ";
                    }
                    else
                    {
                        res.Add(substr);
                        substr = "";
                        substr += elem;
                        substr += " ";
                    }
                }
            }
            res.Add(substr);
            return res.ToArray();

        }
        /// <summary>
        /// Обрабатывает данный массив строк, возвращая из него только те,
        /// которые идут до строки, состоящей из пробелов
        /// </summary>
        /// <param name="srcArr">Обрабатываемый массив строк</param>
        /// <returns>Массив из тех строк исходного, которые идут до строки,
        /// полностью состоящей из пробела
        /// </returns>
        public static string[] FillArrWOSpaces(string[] srcArr)
        {
            List<string> res = new List<string>();
            for (int i = 0; i < srcArr.Length; i++)
            {
                if (!Class1.IsSpaceStr(srcArr[i]))
                {
                    res.Add(srcArr[i]);
                } else
                {
                    return res.ToArray();
                }
            }
            return res.ToArray();
        }
        /// <summary>
        /// Проверяет, состоит данная строка только из пробелов, или нет
        /// </summary>
        /// <param name="str">Проверяемая строка</param>
        /// <returns>True, если да, иначе нет</returns>
        public static bool IsSpaceStr(string str)
        {
            if (str.Length == 0)
                return false;
            int count = 0;
            for (int i = 0; i < str.Length; i++)
                if (str[i] == ' ')
                    count++;
            if (count == str.Length)
                return true;
            else
                return false;
        }
        /// <summary>
        /// Создает новый массив строк на основе исходного,
        /// в котором между словами нет лишних пробелов
        /// </summary>
        /// <param name="FileArray">Обрабатываемый массив строк</param>
        /// <returns>Массив строк, в котором между словами нет лишних пробелов</returns>
        public static string[] FormatStrArr(string[] FileArray)
        {
            string[] Array = new string[FileArray.Length];
            int N = FileArray.Length;

            for (int i = 0; i < N; ++i)
            {
                string s = FileArray[i].Trim( );
                StringBuilder s1 = new StringBuilder(s);
                for (int k = 0; k < s1.Length; ++k)
                {
                    for (int j = 0; j < s1.Length - 1; ++j)
                    {
                        if (s1[j] == ' ' && s1[j + 1] == ' ')
                            s1.Remove(j + 1, 1);
                    }
                }
                string s2 = s1.ToString();
                Array[i] = s2;
            }
            return Array;
        }
    }
}