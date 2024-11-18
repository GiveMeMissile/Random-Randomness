using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        int correct = 0;
        int totalQuestions = 0;
        while(true)
        {
            bool invalidInput = false;
            int a = random.Next(15,125);
            int b = random.Next(15,125);
            int c = a+b;
            int answer = -1;
            Console.WriteLine("What is "+a+"+"+b+"?");
            try
            {
                answer = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine("Don't input a letter or decimal.");
                answer = -1;
                invalidInput = true;
            }
            if(answer == c)
            {
                Console.WriteLine("You are correct. The answer is "+c);
                correct++;
                totalQuestions++;
            }
            else if(invalidInput)
            {
                Console.WriteLine("Please try again IDIOT.");
            }
            else
            {
                Console.WriteLine("You are Incorrect. The answer is "+c);
                totalQuestions++;
            }
            if(totalQuestions >= 5)
            {
                Console.WriteLine("You have finished the addition section.");
                break;
            }
        }
        while(true)
        {
            bool invalidInput = false;
            int c = -1;
            int a = -1;
            int b = -1;
            int answer = -1;
            while(c < 0)
            {
                a = random.Next(15,125);
                b = random.Next(15,125);
                c = a-b;
                answer = -1;
            }
            Console.WriteLine("What is "+a+"-"+b+"?");
            try
            {
                answer = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine("Don't input a letter or decimal.");
                invalidInput = true;
            }
            if(answer == c)
            {
                Console.WriteLine("You are correct. The answer is "+c);
                correct++;
                totalQuestions++;
            }
            else if(invalidInput)
            {
                Console.WriteLine("Please try again IDIOT.");
            }
            else
            {
                Console.WriteLine("You are Incorrect. The answer is "+c);
                totalQuestions++;
            }
            if(totalQuestions >= 10)
            {
                Console.WriteLine("You have finished the Subtraction section.");
                break;
            }
        }
        Console.WriteLine("You got "+correct+" questions correct out of a total of "+totalQuestions+" answered.");
    }
}
