internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello");
        //System.Console.ReadKey();
        //Console.Clear();
        //Console.WriteLine("Welcome to .net class ");

        //int num = 10;
        //Console.WriteLine(num);

        //sbyte a = 10;
        //byte b = 20;
        //short c = 30;
        //ushort d = 40;

        //int e = 50;
        //uint f = 70;
        //long g = 55;
        //ulong h = 60;
        //float i = 90.23F;
        //double j = 100.234234;
        //decimal k = 110.2342432M;


        //Console.WriteLine(a);
        //Console.WriteLine(b);
        //Console.WriteLine(c);
        //Console.WriteLine(d);
        //Console.WriteLine(e);
        //Console.WriteLine(f);
        //Console.WriteLine(g);
        //Console.WriteLine(h);
        //Console.WriteLine(i);
        //Console.WriteLine(j);
        //Console.WriteLine(k);

        //int min = int.MinValue;
        //int max = int.MaxValue;
        //Console.WriteLine(min);
        //Console.WriteLine(max);


        //char ch = 'A';
        //Console.WriteLine(ch);

        //string str = "Hello 123$#&";
        //Console.WriteLine(str);

        //bool isadult = true;
        //Console.WriteLine(51>18 ? isadult : false);

        //****************************** Operators *************************//
        //int num1 = 10;
        //int num2 = 20;
        //Console.WriteLine(num1+num2);
        //Console.WriteLine(num1-num2);
        //Console.WriteLine(num1/num2);
        //Console.WriteLine(num1*num2);
        //Console.WriteLine(num1%3);


        //double d1, d2;
        //d1 = 35;
        //d2 = 45;
        //Console.WriteLine(d1+d2);
        //Console.WriteLine(d1-d2);
        //Console.WriteLine(d2/d1);
        //Console.WriteLine(d1*d2);
        //Console.WriteLine(d2%d1);
        //d1 = 35;
        //d2 = 45;
        //Console.WriteLine(d1 +=d2);
        //Console.WriteLine(d1 -= d2);
        //Console.WriteLine(d2 /= d1);
        //Console.WriteLine(d1 *= d2);
        //Console.WriteLine(d2 %= d1);


        //int X = 10, Y = 20,Z=10;

        //bool result1 = (X == Y) && (Y == Z);
        //Console.WriteLine(result1);
        //bool result2 = ((X == Y) || (Y > Z));
        //Console.WriteLine(result2);

        //string str1 = "Good Morning";
        //string str2 = "Welcome to class";
        //Console.WriteLine(str1 + " " + str2);
        //int num = 10;
        //Console.WriteLine(str1 + num);

        //int num3 = 12;
        //string result = num3 % 2 == 0 ? "Even" : "Odd";
        //Console.WriteLine(result);
        //if (num3 %2 == 0)
        //{
        //    Console.WriteLine(num3 + " is even number");
        //}
        //else
        //{
        //    Console.WriteLine(num3 + " is odd number");

        //}
        //Console.WriteLine(2024 % 100);

        //int leapOrNot = 1999;
        //if (leapOrNot % 100 != 0 && leapOrNot % 4 == 0)
        //{
        //    Console.WriteLine(leapOrNot + " is leap Year");
        //}
        //else if (leapOrNot % 400 == 0)
        //{
        //    Console.WriteLine(leapOrNot + " is leap Year");

        //}
        //else
        //{
        //    Console.WriteLine(leapOrNot + " is not leap Year");
        //}



        //int marks = 76;

        //if (marks >= 75)
        //{
        //    Console.WriteLine("Distinction");
        //}
        //else if (marks>= 60 && marks < 75)
        //{
        //    Console.WriteLine("First Class");
        //}
        //else if (marks>=50 && marks < 60)
        //{
        //    Console.WriteLine("Second class");
        //}
        //else if(marks>=35 && marks< 50)
        //{
        //    Console.WriteLine("Third Class");
        //}
        //else
        //{
        //    Console.WriteLine("Fail...");
        //}

        int num1 = 10, num2 = 30, num3 = 20;
        int ans = num1>num2 ? num1 >num3 ? num1 : num3 : num2>num3 ? num2 : num3;
        Console.WriteLine(ans + " is graeatest among three..");


    }
}