using Floyd;
namespace test
{
    class FloydTest
    {
        static void Main()
        {
            Console.WriteLine("Общий тест главной функции\n");
            string[] src = { "   123456789012345678901234567890    ", 
                             "123456789012345678901234567890  ",
                             " " };
            foreach (string s in Class1.Floyd(src))
                Console.WriteLine($"{s}");

            Console.WriteLine("\nТест главной функции на основе строки, которую нам предоставил преподаватель");
            Console.WriteLine("next test\n");

            string[] x1 = { "He   was lying  face down on the   ground again.   The  smell of   the ",
                             "Forest filled his  nostrils. He could feel  the cold hard ground  ",
                             "beneath his cheek, and the hinge of his glasses, which had been ",
                             "knocked sideways by the fall, cutting into his temple.",
                             "   ",
                             "                    end!!!"};
            foreach (string s in Class1.Floyd(x1))
                Console.WriteLine($"{s}");

            Console.WriteLine("\nТест функции HasSpace");
            Console.WriteLine("next test\n");

            string x2 = "     ";
            Console.WriteLine(Class1.IsSpaceStr(x2));
            string x3 = "    ds ";
            Console.WriteLine(Class1.IsSpaceStr(x3));

            Console.WriteLine("\nТест функции FormatStrArr");
            Console.WriteLine("next test\n");

            string[] x4 = { "as     jdjj assn", "jdakj skjdaj", " jdjd    jdj" };
            foreach (string s in Class1.FormatStrArr(x4))
                Console.WriteLine($"{s}");

            Console.WriteLine("\nТест функции FillArrWOSpaces");
            Console.WriteLine("next test\n");

            string[] x5 = { "as     jdjj assn", "jdakj skjdaj", " " ," jdjd    jdj" };
            foreach (string s in Class1.FillArrWOSpaces(x5))
                Console.WriteLine($"{s}");

            Console.WriteLine("\nТест функции ConvertToCorrectStrArr");
            Console.WriteLine("next test\n");
            string[] x6 = { "12345678901234567890 12345678901", "123", "456", "789", "123456789012345" };
            foreach (string s in Class1.ConvertToCorrectStrArr(x6))
                Console.WriteLine($"{s}");

        }
    }
}