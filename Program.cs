using System;

namespace htc_final_project_Arya_Singh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This word has 6 letters");
            Console.WriteLine("Guess a letter");
             string letter = Console.ReadLine(); 
           while (letter == "h" || letter == "y" || letter == "l"|| letter == "a"|| letter == "n"|| letter == "d")
           {
               Console.WriteLine("Yes");
           }
           
            
            
            
        }
            
         
    }
}
