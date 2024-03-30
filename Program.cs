using System;
using System.ComponentModel;

namespace chatbot_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to legend park chatbot how may i help you today");
            Console.WriteLine("our most frequently asked questions");
            Console.WriteLine("1) rides and attractions");
            Console.WriteLine("2) refreshments info");
            
            while (true)
            {
            string choice = Console.ReadLine();
            choice = choice.ToLower();

                switch (choice)
                {  
                    case "1":
                        Console.WriteLine("hgasdasd");
                        break;
                }
            }
        }
        
      
        
    
    
    }
}

