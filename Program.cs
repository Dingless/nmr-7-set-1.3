class program
{
    static void Main()
    {
        string input; // variabel för att lagra det användaren har skrivit
        int number; // variabel för konvertera heltalet
        bool success = false; // håller reda om konvertering lyckades ele inte

        while (!success) // en while loop som kommer fortsätta sucess är falkst
        {
            Console.WriteLine(" Ange en siffra");
            input = Console.ReadLine();
            success = int.TryParse(input, out number); // försök konvertera inmatningen till ett heltal
            if (!success) // ifall konvertering misslyckades så skrivs det ut ett fel meddelande
            {
                Console.WriteLine("Felaktig inmatning ");

            }

        Console.WriteLine("Du angav ett heltal:" + number); // skriv ut det angivna heltalet när konvertering lyckas
        }



    }

    }













