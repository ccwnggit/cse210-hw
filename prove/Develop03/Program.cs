using System;
using System.IO;

class Program
{
    // Additional creativity: 1. A random number of words are to hide each time. Thus, I can adjust the difficulty by modifying some variables.
    //                        2. puncturations like comma and fullstop are always shown but will not be hiddened.
    //                        3. can be used to memorise Chinese scriptures

    static void Main(string[] args)
    {
        /*  This  part of the program is to be developed and tested latter. It could involve changes in the Reference class
        List <Scripture> s = new List<Scripture> ();
        List <Reference> f = new List<Reference> ();

        
        string inputfile = "scriptures.txt";
        string[] lines = System.IO.File.ReadAllLines(inputfile);
        foreach (string line in lines)
        {

            string  lineT = line.Trim(); // remove leading and trailing spaces
            string[] parts = lineT.Split("\"",2);
            if (parts.Length ==2) // Make sure the line has two expected fields
            {
                char[] delimiters = {' ',':','-'}; 
                string [] referenceParts = parts[0].Split(delimiters);

            int n;                                                       // Check if the beginning is a number
            bool isNumber = int.TryParse(referenceParts[0], out n);
            if (isNumber)
            {
                f.SetBook(referenceParts[0]+referenceParts[1]);
                f.SetChapter(Int32.Parse(referenceParts[2]));
                f.SetVerseStart(Int32.Parse(referenceParts[3]));
                if (referenceParts.Count() == 5)
                {
                    f.SetVerseEnd(Int32.Parse(referenceParts[4]));
                }
            }
            else
            {   
                f.SetBook(referenceParts[0]);
                f.SetChapter(Int32.Parse(referenceParts[1]));
                f.SetVerseStart(Int32.Parse(referenceParts[2]));
                if (referenceParts.Count() == 4)
                {
                    f.SetVerseEnd(Int32.Parse(referenceParts[3]));
                }
            }

            f.Add(parts[0])
            s.Add(parts[1]);
            }

        }
        
        */
        
        // set reference

        Reference f1 = new Reference();
        f1.SetBook("3 Nephi");
        f1.SetChapter(18);
        f1.SetVerseStart(20);
        f1.SetVerseEnd(20);

        // set the instance of verse

        Scripture scriptureToRemember = new Scripture();
        // Console.WriteLine(scriptureToRemember._hiddenCount);

        scriptureToRemember.Set("你 們 奉 我 的 名 , 無 論 向 父 求 什 麼 , 只 要 正 當 , 並 且 相 信 必 然 得 到 , 看 啊 , 你 們 求 的 就 必 賜 給 你 們.");

        // And whatsoever ye shall ask the Father in my name , which is right , believing that you shall receive , behold it shall be given unto you .

        f1.Display();                           // Display reference for the first time
        scriptureToRemember.DisplayOrg();       // Display the text for the first time
        Console.WriteLine();
        Console.WriteLine("Please hit <return> to hide words or \"quit\" to quit:");
        Console.Write(">");

        // form an index list without punctuations. The value points to the scripture words.
        List<int> listOfIndices = scriptureToRemember.GetWordPosList("-p");     

        // variables used inside the program
        
        int scopeOfRandomNums;
        int numberOfwords;                                     // The random number in choosing how much words to be blanked
        int randomLpIndex;                                     // The variable to keep the random number generation for picking the members in listOfIndices
        int inputStringWordPosition;                           // The word position in the scripture to be hidden
        int minGeneration = 4;
        int maxGeneration = 8;

        // setup random number generation
        Random rnd = new Random();

        
        do                                                      // if words hidden equal or greater than the verse length, quit
        {
            string userInput=Console.ReadLine();
            if (userInput == "quit")
            {
                break;
            }
            
            Console.Clear();                                    // clear screen
            f1.Display();                                       // display reference


            int availablePositions = listOfIndices.Count;       // count remaining no. of words in the scripture
            if (availablePositions < maxGeneration)             // check how many words that can displayed
            {
                scopeOfRandomNums = availablePositions;
            }
            else
            {
                scopeOfRandomNums = maxGeneration;
            }

            // Adjust if the remaining no. of words in the scripture is less than 4
            if (scopeOfRandomNums > minGeneration)
            {
                numberOfwords = rnd.Next(minGeneration, scopeOfRandomNums+1);
                
            }
            else
            {
                numberOfwords = rnd.Next(1,scopeOfRandomNums+1);
            }

            // ****** Set the relevant no. of words to blanks
            if (numberOfwords != 0)
            {
                
                List <int> removedList = new List<int> ();
                List <int> randomLpIndexList = new List<int>();
                for (int i =0; i<numberOfwords; i++)
                {
                    // generate the random numbers
                    randomLpIndex = rnd.Next(listOfIndices.Count());

                    // save it in a list
                    randomLpIndexList.Add(randomLpIndex);
                }
                // convert it to unique list
                List<int> uniquerandomLpIndexList = randomLpIndexList.Distinct().ToList();

                foreach (int indexvalue in uniquerandomLpIndexList)
                {
                    inputStringWordPosition = listOfIndices[indexvalue];
                    scriptureToRemember.SetWordBlank(listOfIndices[indexvalue]);
                    removedList.Add(inputStringWordPosition);
                }
                

                // convert the removed list to one with unique values
                List<int> uniqueRemovedList = removedList.Distinct().ToList();
        

                // remove the members in the removedList from listOfIndices list
                
                foreach (int iStringWordPosition in uniqueRemovedList)
                {
                    listOfIndices.Remove(iStringWordPosition);              // remove entry in listOfIndices which has the word position in uniqueNumbers
                    // int valuelistOfIndices = listOfIndices[wp];          // find the value in listOfIndices based on the value in uniqueNumbers as the index
                    // listOfIndices.Remove(valuelistOfIndices);            // remove from listOfIndices the element with the value looked up
                }
            }
            scriptureToRemember.Display();
            
            Console.WriteLine();
            Console.WriteLine("Please hit <return> to hide words or enter \"quit\" to quit");
            Console.Write(">");
            
        } while (listOfIndices.Count>0);
        
        f1.Display();
        scriptureToRemember.Display();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Thanks for using!");
        Console.WriteLine();
        Console.WriteLine();
    }
}


