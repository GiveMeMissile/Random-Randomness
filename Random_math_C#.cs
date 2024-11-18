using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        int thing = random.Next(0, 20);
        Console.WriteLine(thing);
        int correct = 0;
        int totalQuestions = 0;
        while(true)
        {
            int a = random.Next(15,125);
            int b = random.Next(15,125);
            int c = a+b;
            Console.WriteLine("What is "+a+"+"+b+"?");
            try
            {
                int answer = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine("Don't input a letter or decimal.");
                answer = -1;
            }
            if(answer == c)
            {
                Console.WriteLine("You are correct. The answer is "+c);
                correct++;
            }
            else
            {
                Console.WriteLine("You are Incorrect. The answer is "+c);
            }
            totalQuestions++;
            if(totalQuestions >= 5)
            {
                break;
            }
        }
    }
}
