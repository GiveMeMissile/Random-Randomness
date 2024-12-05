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
        int questions = 0;
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
                if(answer == -1)
                {
                    answer++;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("You did not input an int");
            }
            if(answer == c)
            {
                Console.WriteLine("You are correct. The answer is "+c+".");
                correct++;
                questions++;
            }
            else if(answer == -1)
            {}
            else
            {
                Console.WriteLine("You are incorrect. The answer is "+c+".");
                questions++;
            }
            if(questions >= 5)
            {
                Console.WriteLine("That is the end of the addition section.");
                break;
            }
        }
        return correct;
    }
    static int Subtraction(correct)
    {
        
    }
}
