using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int correct = 0;
        int totalQuestions = 0;
        Console.WriteLine("Hello. You will be taking a 20 question quiz. Where you will need to answer 20 very easy math questions. Good luck (:");
        correct = Addition(correct, totalQuestions);
        
    }
    static int Addition(int correct, int totalQuestions)
    {
        while (true)
        {
            Random random = new Random();
            int a = random.Next(15,150);
            int b = random.Next(15,150);
            int c = a+b;
            int answer = -1;
            Console.WriteLine("What is "+a+ "+" +b+"?:");
            try
            {
                answer = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("You did not input an int, Please try aagin");
            }
            if(answer == c)
            {
                
            }
        }
        return correct;
    }
}
