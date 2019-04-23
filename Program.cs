using System;
 using System.Collections.Generic;

namespace htc_final_project_Arya_Singh
{
    class Program
    {
        static void Main(string[] args)
        {
          bool keepGoing = true;
            Console.WriteLine("This word has 6 letters");
            int tracker = 0; 
               string message = "Yes, you have letter(s)"; 
               //List<string> guesses = new List<string>();
                 string [] a = new string[6];
             while( keepGoing  == true){
            Console.WriteLine("Guess a letter");   
            string letter = Console.ReadLine(); 
              
                
                if (letter == "h" || letter == "y" || letter == "l"|| letter == "a"|| letter == "n"|| letter == "d")
                    {
                        if(letter == "h"){
                                a[0] = "h"; 
                               
                        }
                        if(letter == "y"){
                                a[1] = "y"; 
                                
                        }
                        if(letter == "l"){
                                a[2] = "l"; 
                                
                        }
                        if(letter == "a"){
                                a[3] = "a"; 
                              
                        }
                        if(letter == "n"){
                                a[4] = "n"; 
                               
                        }
                        if(letter == "d"){
                                a[5] = "d"; 
                                
                        }
                        string output = String.Empty;
                        for(int i = 0; i<6; i++ ){
                            if(a[i] != null){
                                output += a[i];
                            }
                        }

                        Console.WriteLine(message + output);
                        if(output =="hyland"){
                            Console.WriteLine("Congrats! You win!");
                            break; 
                        }
                    }
                     
                else
                    {
            Console.WriteLine("No");
             tracker = tracker + 1; 
                     }
                if(tracker ==1 ){
                    Console.WriteLine("Scaffold");
                }
                if(tracker==2){
                     Console.WriteLine("head");
                }
                if(tracker==3){
                     Console.WriteLine("face");
                }
                if(tracker==4){
                     Console.WriteLine("torso");
                }
                if(tracker==5){
                     Console.WriteLine("right leg");
                }
                if(tracker==6){
                     Console.WriteLine("left leg");
                }
                if(tracker==7){
                     Console.WriteLine("Right arm");
                }
                if(tracker==8){
                     Console.WriteLine("left arm");
                }
                if(tracker==9){
                     Console.WriteLine("dead");
                }

           
            }
            
            
        }
            
         
    }
}
