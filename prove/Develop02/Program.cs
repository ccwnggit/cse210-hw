using System;




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

