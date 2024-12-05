using System;


public class RandomMath
{
    public static void Main(string[] args)
    {   
        Console.WriteLine("Hello. You will be taking a 20 question quiz. Where you will need to answer 20 very easy math questions. Good luck (:");
        while(true)
        {
            int correct = 0;
            correct = Addition(correct);
            correct = Subtraction(correct);
            correct = Multiplication(correct);
            correct = Division(correct);
            int grade = ((correct*100)/20);
            if (grade >= 90)
            {
                Console.WriteLine("CONGRATULATIONS!!!, YOU DOMINATED THIS QUIZ WITH A "+grade+"/100. WHAT A GOOD JOB YOU HAVE DONE!!!!!! HAVE A WONDERFUL REST OF YOUR DAY!!!");
            }
            else if(grade >= 70)
            {
                Console.WriteLine("Congratulations, you passed the quiz with a "+grade+"/100. Good job and have a WONDERFUL rest of your day.");
            }
            else if(grade >= 50)
            {
                Console.WriteLine("Womp Womp, it looks like you failed the test with a "+grade+"/100. This is quite a bad score. You should try again to get a better score.");
            }
            else{
                Console.WriteLine("OH...MY...MATH... you failed with a [SWEAR]ING "+grade+"/100!!!! THAT IS ATROCIOUS!!! HOW IS THIS POSSIBLE!!! YOU SHALL LEAVE AND NEVER RETURN!!!!!!!! Idiot.");
                break;
                }
            
            Console.WriteLine("Do you want to take the quiz again?");
            string response = Console.ReadLine();
            if(response == "yes" || response =="Yes")
            {
                Console.WriteLine("Ok you shall take the quiz again.");
            }
            else
            {
                Console.WriteLine("Ok you shall not retake the quizz. Have a nice day (:");
                break;
            }
        }
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
            int c = a*b;
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
