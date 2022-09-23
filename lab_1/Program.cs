using System;
using System.Linq;

namespace lab_1
{
    class Program
    {
        //4
        enum TestCaseStatus
        {
            Pass,
            Fail,
            Blocked,
            Wp,
            Unexecuted
        };
        //5
        struct RGB
        {
            public byte red;
            public byte green;
            public byte blue;

            public RGB(byte a, byte b, byte c)
            {
                red = a;
                green = b;
                blue = c;
            }

            public void Info()
            {
                Console.WriteLine($"RGB: red: {red}, green {green}, blue {blue}.");
            }
        }

        //3
        enum HTTPError
        {
            Bad_Request = 400,
            Unauthorized = 401,
            Payment_Required = 402,
            Forbidden = 403,
            Not_Found = 404,
            Method_Not_Allowed = 405,
        }
        static void Main()
        {
            //1
            int day;
            int month;
            day = Convert.ToInt32(Console.ReadLine());
            month = Convert.ToInt32(Console.ReadLine());
            string result1 = (day > 0) && (day < 31) && (month > 0) && (month < 12) ? "Значення можуть бути днем та місяцем." : "Значення не можуть бути днем та місяцем.";
            Console.WriteLine(result1);
            //2
            double num, r;
            int sum, m;
            sum = 0;
            num = Convert.ToDouble(Console.ReadLine());
            for (int i = 0; i < 2; i++)
            {
                r = num * 10;
                m = (int)(r % 10);
                sum = sum + m;
                num = num * 10;

            }
            Console.WriteLine("Сума двох перших знаків після коми : " + sum);
            //3
            int hour;
            hour = Convert.ToInt32(Console.ReadLine());
            string result3 = (hour > 4) && (hour < 12) ? "Доброго ранку!" : (hour > 12) && (hour < 17) ? "Добрий день!" : (hour > 17) && (hour < 24) ? "Добрий вечір!" : "Доброї ночі!";
            Console.WriteLine(result3);
            //4
            var test1Status = TestCaseStatus.Pass;
            Console.WriteLine(test1Status);
            //5
            RGB white = new RGB(255, 255, 255);
            RGB black = new RGB(0, 0, 0);
            white.Info();
            black.Info();


            //1
            float number1;
            float number2;
            float number3;
            number1 = Convert.ToInt32(Console.ReadLine());
            number2 = Convert.ToInt32(Console.ReadLine());
            number3 = Convert.ToInt32(Console.ReadLine());
            float[] numbers = { number1, number2, number3 };
            foreach (float x in numbers)
            {
                string result = (x >= -5) && (x <= 5) ? "Число належить [-5;5]" : "Число не належить [-5;5]";
                Console.WriteLine(result);
            }
            //2
            int number4;
            int number5;
            int number6;
            number4 = Convert.ToInt32(Console.ReadLine());
            number5 = Convert.ToInt32(Console.ReadLine());
            number6 = Convert.ToInt32(Console.ReadLine());
            int[] allnumbers = { number4, number5, number6 };
            Console.WriteLine(allnumbers.Min());
            Console.WriteLine(allnumbers.Max());
            //3
            int numError = Convert.ToInt32(Console.ReadLine());
            HTTPError nameError = (HTTPError)numError;
            Console.WriteLine(nameError);

        }
    }
}
