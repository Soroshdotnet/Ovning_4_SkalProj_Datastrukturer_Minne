using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ovning_4_SkalProj_Datastrukturer_Minnen

/* Frågor

    1. Hur fungerar stacken och heapen? Förklara gärna med exempel eller skiss på dess
    grundläggande funktion.
    Svar: Stack är den korta minneshanteringen som spras i datorbs RAN minne medan heapen används dynamsikt och inte nödvändigtvis i RAM minnet.

    2. Vad är Value Types respektive Reference Types och vad skiljer dem åt?
    Svar: Value Types är som namnet antyder statiska värden som hanteras av stacken medans Reference Types är dynamsika object som hanteras av heapen.

    3. Följande metoder (se bild nedan) genererar olika svar. Den första returnerar 3, den
    andra returnerar, varför?
    Svar 3.1: Första metoden skapar två platser i minnet varav metoden returnerar värdet 3 från variabel x i minnet x.
    Svar 3.2: Objekt MyValue skrivs över av variabel y, därav returneras värde 4.
    
*/
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */


            /* 
             
            1.Skriv klart implementationen av ExamineList-metoden så att undersökningen blir
              genomförbar.
            - Klart
            
            2.När ökar listans kapacitet ? (Alltså den underliggande arrayens storlek)
            - Listans kapacitet ökar när man tilldelar värde
            
            3.Med hur mycket ökar kapaciteten?
            - Kapaciteten dubblas, ökar med 4 > 0, 4, 8, 16, 32, 64 osv
            
            4.Varför ökar inte listans kapacitet i samma takt som element läggs till ?
            -

            5.Minskar kapaciteten när element tas bort ur listan?
            - Ja, kapaciteten minskar (?)

            6.När är det då fördelaktigt att använda en egendefinierad array istället för en lista?
            - Det blir minneseffektivt, man sparar processor, men det kräver att man vet exakt hur många element man ska ha

            */


            List<string> theList = new List<string>();
            string input = Console.ReadLine();

            char nav = input[0];
            string value = input.Substring(1);
           
            
           

            switch (nav)
            {
                case '+':

                    theList.Add (value);
                    Console.WriteLine(theList.Capacity);
                    break;

                case '-':

                    theList.Remove (value);
                    Console.WriteLine(theList.Capacity);
                    break;

                default:
                    Console.WriteLine("use only + or -");
                    break;
            }




            //List<string> theList = new List<string>();
            //string input = Console.ReadLine();
            //char nav = input[0];
            //string value = input.substring(1);

            //switch (nav) {...}
        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */

            Queue<string> theQueue = new Queue<string>();
           
            //string theQueue = Console.ReadLine();

            char input2 = Console.ReadLine();

            do
            {
                switch (input2)
                {
                    case '+':
                     break;

                    case '-':
                        break;
                
                    default:
                        break;
                }

            } while (true);

        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */
        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

        }

    }
}

