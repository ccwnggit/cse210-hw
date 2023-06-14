using System;

    // Additional creativity:
    // 1) Clear journal entries before loading from journal files
    // 2) Presume one single journal file to be loaded from or saved to be "myjournal.txt" unless specified otherwise
    // 3) If user input option number other than 1-5, an error reminder to the user is issued.



    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello Develop02 World!");

            Journal myJournal = new Journal();

            int optionNum = 0;

            do
            {

            
            myJournal.MenuOptions();

            Console.Write("Option: ");
            string option= Console.ReadLine();
            optionNum = int.Parse(option);


            if (optionNum ==1)
            {
                myJournal.NewEntry();
                
            }
            else if (optionNum == 2)
            {
                myJournal.Display();
            }
            else if (optionNum == 3)
            {
                myJournal.Save();
            }
            else if (optionNum == 4)
            {
                myJournal.Load();
            }
            else if (optionNum == 5)
            {
                Console.WriteLine("Thank you for using!");
            }
            else
            {
                Console.WriteLine("Please input a right number (1-5) ");
            }

            } while (optionNum != 5);
            
        }
    }

