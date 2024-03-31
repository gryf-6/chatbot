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
            console.WriteLine("")
            Console.WriteLine("1) rides and attractions");
            Console.WriteLine("2) refreshments info");
            
            while (true)
            {
            string choice = Console.ReadLine();
            choice = choice.ToLower();

                switch (choice)
                {  
                    case "1":
                        Console.WriteLine("14+ rides");
                        console.WriteLine("kids rides");
                        break;
                }
            }




             while (true)
            {
            string choice = Console.ReadLine();
            choice = choice.ToLower();

                switch (choice)
                {  
                    case "14+ rides":
                        Console.WriteLine("space mountains");
                        console.WriteLine("pirates of the carribaen");
                        console.WriteLine("haunted mansion")
                        break;
                }
            }


        }
        
    
    
    
    
    }
}

