using System;


public class HelloWorld
{
    public static void Main(string[] args)
    {
        int correct = 0;
        Console.WriteLine("Hello. You will be taking a 20 question quiz. Where you will need to answer 20 very easy math questions. Good luck (:");
        correct = Addition(correct);
        correct = Subtraction(correct);
        correct = Multiplication(correct);
        correct = Division(correct);
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
    static int Subtraction(int correct)
    {
        int questions = 0;
        while (true)
        {
            Random random = new Random();
            int a = random.Next(25,150);
            int b = random.Next(25,100);
            while(b>=a)
            {
                int sub = random.Next(1,15);
                b = b-sub;
            }
            int c = a-b;
            int answer = -1;
            Console.WriteLine("What is "+a+ "-" +b+"?:");
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
                Console.WriteLine("That is the end of the Subtraction section.");
                break;
            }
        }
        return correct;
    }
    static int Multiplication(int correct)
    {
        int questions = 0;
        while (true)
        {
            Random random = new Random();
            int a = random.Next(5, 50);
            int b = random.Next(5, 50);
            int c = a+b;
            int answer = -1;
            Console.WriteLine("What is "+a+ "*" +b+"?:");
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
                Console.WriteLine("That is the end of the multiplication section.");
                break;
            }
        }
        return correct;
    }
    static int Division(int correct)
    {
        int questions = 0;
        while (true)
        {
            Random random = new Random();
            int a = random.Next(15,150);
            int b = random.Next(5,15);
            while(!(a%b == 0))
            {
                a = random.Next(20,250);
                b = random.Next(5,20);
            }
            int c = a/b;
            int answer = -1;
            Console.WriteLine("What is "+a+ "/" +b+"?:");
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
                Console.WriteLine("That is the end of the division section.");
                break;
            }
        }
        return correct;
    }
}
