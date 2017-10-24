using System;
public class intergerTest
{
    static void Main(string[] args)
    {
        int a = 10, b = 20, x = 5, y = 2 ,Ans1 , Ans2, Ans3, Ans4, Ans5, Ans6, Ans7, Ans8,Ans9, Ans10;
        Ans1 = a + b;
        Ans2 = x - b;
        Ans3 = x * b;
        Ans4 = y / a;
        Ans5 = b % y;
        Ans6 = y + 10 % x;
        Ans7 = a / 3 * 5;
        Ans8 = 9 / 2 * a;
        Ans9 = y % 8;
        Ans10 = 100 * x + y % 2 - a;
        Console.WriteLine("a={0}\nb={1}\nx={2}\ny={3}\nAns1={4}\nAns2={5}\nAns3={6}\nAns4={7}\nAns5={8}\nAns6={9}\nAns7={10}\nAns8={11}\nAns9={12}\nAns10={13}\n"
            , a, b, x, y, Ans1, Ans2, Ans3, Ans4, Ans5, Ans6, Ans7, Ans8, Ans9, Ans10);
    }
}
