using System;

namespace Farenheit_to_Celcius
{
    class Program
    {
        public static string F { get; private set; }
        public static string UserInput { get; private set; }
        public static string Fehrenheit { get; private set; }

        static void Main(string[] args)
        // Convert Fehrenheit to Celsius and Celsius to Fehrenheit
        // User starts the programs
        // User enters code F or farenheit or C celsius 
        // The program calculates data
        // Program out puts data to Screen
        // user exits
    
        
        { //Start the program with Clear();
        Console.Clear();
        
        
        //End the program with blank line and instructions
        Console.ResetColor();
        Console.WriteLine();
        Console.WriteLine("Press <Enter> to quit the program");
        Console.ReadKey();
            do {
            Console.WriteLine("Convert Fehrenheit to Celsius and Celsius to Fehrenheit");
            Console.WriteLine("Please enter code F for Fehrenheit to Celsius and C for  Celsius to Fehrenheit");
            Console.WriteLine("To Convert Fehrenheit to Celsius         Code: F");
            Console.WriteLine("To converte Celsius to Fehrenheit        Code: C ");
            Console.WriteLine("To Exit                                  Code: E ");

            string Fehrenheit= "F";
            string Celsuis = "C";
            string Exit = "E";
            string UserInput = Console.ReadLine();

            if (UserInput == Fehrenheit)
            {
                Console.WriteLine("Please Enter Fehrentheit");
                Double Feh = Double.Parse(Console.ReadLine());
                Double ConvertedNumber = Math.Round(Feh - 32 * 5 / 9, 2);
                Console.WriteLine($"{ConvertedNumber} Degrees Celsius ");
            }
            else if (UserInput ==  Celsuis)
            {
                Console.WriteLine("Please Enter Celsuis");
                Double Cel = Double.Parse(Console.ReadLine());
                Double ConvertedNumber = Math.Round(Cel * 9 /5 + 32 , 2);
                Console.WriteLine($"{ConvertedNumber} Degrees Fehrentheit");
            } 

            else if ( UserInput == Exit)
            {
                Environment.Exit(1);
            }
            else{
                Console.WriteLine("Please enter Code");
            }
           
                } while (Fehrenheit == UserInput);
            Console.ReadLine();

       
       
        }
    }
}
 