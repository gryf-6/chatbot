using System;
using System.ComponentModel;
using System.Transactions;

namespace chatbot_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to legend park chatbot how may i help you today");
            Console.WriteLine("our most frequently asked questions");
            Console.WriteLine("");
            Console.WriteLine("1) rides and attractions");
            Console.WriteLine("2) refreshments info");
            
            while (true)
            {
            string choice = Console.ReadLine();
            choice = choice.ToLower();

                switch (choice)
                {  
                    case "1":
                        Console.WriteLine("14+ rides:");
                        Console.WriteLine("space mountain");
                        Console.WriteLine("pirates of the caribean");
                        Console.WriteLine("haunted mansion");
                        Console.WriteLine("");
                        Console.WriteLine("kids rides");
                        Console.WriteLine("lemon twist");
                        Console.WriteLine("busy bees");
                        Console.WriteLine("amazing flying elephants");
                        break;

                        case "2":
                            Console.WriteLine("food options");
                            Console.WriteLine("allegies to consider when visiting");
                        break;
                        
                        case "food options":
                        Console.WriteLine("veggie options:");
                        Console.WriteLine("veggie burger");
                        Console.WriteLine("creeamy vegan pantry pasta");
                        Console.WriteLine("speedy lentil coconut curry");
                        Console.WriteLine("teriyaki tofu");
                        break;
                        case "allegies":
                        Console.WriteLine("allergies:");
                        Console.WriteLine("peanuts");
                        Console.WriteLine("gluten");
                        break;
                        case "":
                        break;
                }
            }

                



        }
        
    
    
    
    
    }
}

