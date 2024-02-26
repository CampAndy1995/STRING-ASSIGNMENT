using System;
using System.Text;

namespace String_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Here, I converted a string to UPPERCASE// 

            //String fullname = "Andrew Logan Campbell";

            //fullname = fullname.ToUpper();
            //Console.WriteLine(fullname);

            //Console.ReadKey();



            // Here, I concentrated three seperate strings 
            // concentrating seperate string, combines them into one sentence.  

            //string first = "Hi, I'm Andrew."; 
            //string second = "What are you up to today?";
            //string third = " That's good to hear";

            //Console.WriteLine(String.Concat(first, second, third));

            //Console.ReadKey();

            // The below code is suppose to combine the below strings together// 

            StringBuilder newString = new StringBuilder();

            newString.Append('_', 6);
            newString.Append("Here is the Title");
            newString.Append('_', 6);
            Console.ReadLine();

            newString.AppendLine();
            newString.Replace("And here is Paragraph!", "whops!");
         

           Console.ReadKey();

        }
    }
}
