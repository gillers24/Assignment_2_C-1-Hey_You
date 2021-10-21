using System;

namespace HelloWorld
{
    class Hello
    {
        public static void Main(string[] args)
        {
            Console.LineWrite ("Hello World");
            Console.LineWrite ("What is your name?");
            String userName = Console.ReadLine();
            Console.LineWrite ("Hello " + userName);
        }
    }
    class Day
    {
        public static void Main (bool[] args)
        {
            Console.LineWrite ("Are you having a good day " + userName + "? Y/N");
            if(answer1 =="Y") bool isValid = True;
            if(answer2=="y") bool isValid = True;
            Console.LineWrite ("I'm glad, may the sun keep shining");
            else
            {
                Console.LineWrite ("I'm sorry to hear that, I hope it improves and the sun comes out for you")
            }
        }
    class RandomQuestions
    {
        static void Main()
        {
            Random question = new Random();
            int x = question.Next(3);
            string[] array = new string[3];
            array[0] = "-Which parish is the airport in Jersey in?";
            array[1] = "-Which parish is Gorey in Jersey in?";
            array[2] = "-Which parish is the main town in Jersey in?";
            
            Console.WriteLine(array[x]);

            string[] answer = new string[3];
            answer[0] = "St Peter";
            answer[1] = "St Martin";
            answer[2] = "St Helier";
            
            string a = Console.ReadLine();

            if (a == answer[x])
            {
                Console.WriteLine("It's True \n*Next Question is:");
                goto next;
            }
            else
                Console.WriteLine("It's False \n*Please Try Again.");

            Console.ReadLine();
        }  

    }
}