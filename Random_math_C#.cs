using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int correct = 0;
        Console.WriteLine("Hello. You will be taking a 20 question quiz. Where you will need to answer 20 very easy math questions. Good luck (:");
        correct = Addition(correct);
        
    }
    static int Addition(int correct)
    {
        while (true)
        {
            Random random = new Random();
            int a = random.Next(15,150);
            int b = random.Next(15,150);
            int c = a+b;
            break;
        }
        return correct;
    }
}
