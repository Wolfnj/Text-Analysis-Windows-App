////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//  Project:        Project2
//  File Name:      Words.cs
//  Description:    This class serves as a container for a collection of DistinctWord objects
//  Course:         CSCI 2210-201  - Data Structures
//  Author:         Nathan Wolf, wolfnj@etsu.edu
//  Created:        March 16, 2018 
//  Copyright:      Nathan Wolf, 2018
//
////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace Project1
{
    /// <summary>
    /// Container for DistinctWord objects. Displays
    /// all distinct word objects in a specified format
    /// </summary>
    class Words
    {
        public List<DistinctWord> DistinctWordList { get; private set; }       //A container for a 
                                                                               //collection of distinct word objects

        public int Count { get; set; }      //The number of items in DistinctWordList




        /// <summary>
        /// Default Constructor for the Words class
        /// </summary>
        public Words()
        {
            DistinctWordList = null;
            Count = 0;
        }//end Words()



        /// <summary>
        /// Parameterized constructor for the Words object
        /// </summary>
        /// <param name="t1">The text object t1.</param>
        public Words(Text t1 )
        {
            CountingAndSetting(t1);
            Count = DistinctWordList.Count;
        }//end Words(Text)



        /// <summary>
        /// Gets or sets the <see cref="DistinctWord"/> at the specified index.
        /// </summary>
        /// <value>
        /// The <see cref="DistinctWord"/>.
        /// </value>
        /// <param name="Index">The index.</param>
        /// <returns></returns>
        /// <exception cref="IndexOutOfRangeException">
        /// The index is out of range
        /// or
        /// The index is out of range
        /// </exception>
        public DistinctWord this[int Index]
        {
            get
            {
                if (Index < 0 || Index >= Count)
                {
                    throw new IndexOutOfRangeException("The index is out of range");
                }
                return DistinctWordList[Index];
            }
            set
            {
                {
                    if (Index < 0 || Index >= Count)
                    {
                        throw new IndexOutOfRangeException("The index is out of range");
                    }
                    DistinctWordList[Index] = value;
                }
            }
        }
















        /// <summary>
        /// Finds all the Distinct Words and Counts how many the times each individual distinct word
        /// appears in the text.
        /// </summary>
        /// <param name="t1">The Text file the user has chosen.</param>
        public void CountingAndSetting(Text t1)
        {

            List<String> OriginalTokenList = new List<string>();//stores the original tokens

            for(int i=0; i<t1.Tokens.Count; i++)
            {
                OriginalTokenList.Add(t1.Tokens[i]);
            }


            List<String> DistinctTokenList = new List<string>();         //stores the distinct tokens found in the original
            DistinctWordList = new List<DistinctWord>();        //Instantiates the DistinctWordList
                                                                //to put in all the distinct words

            OriginalTokenList.RemoveAll(s => s.Equals("."));       //Removes all periods
            OriginalTokenList.RemoveAll(s => s.Equals("!"));       //Removes all exclamation
            OriginalTokenList.RemoveAll(s => s.Equals("?"));       //Removes all question marks
            OriginalTokenList.RemoveAll(s => s.Equals(";"));       //Removes all semicolons
            OriginalTokenList.RemoveAll(s => s.Equals(","));       //Removes all commas
            OriginalTokenList.RemoveAll(s => s.Equals(":"));       //Removes all colons
            OriginalTokenList.RemoveAll(s => s.Equals("@"));       //Removes all @
            OriginalTokenList.RemoveAll(s => s.Equals("\""));       //Removes all parenthesis





            OriginalTokenList.RemoveAll(s => s.Equals("\n"));       //Removes all newlines
            OriginalTokenList.RemoveAll(s => s.Equals("\r"));       //Removes all returnlines
            OriginalTokenList.RemoveAll(s => s.Equals("\t"));       //Removes all tabs




            OriginalTokenList.RemoveAll(NoSpaces);
          

            OriginalTokenList = LowerCase(OriginalTokenList);
            

            for (int i=0; i < OriginalTokenList.Count; i++)
            {
                if(DistinctTokenList.IndexOf(OriginalTokenList[i]) < 0)
                {
                    //This will return a -1 if the token from OriginalTokenList
                    //is not in the DistinctTokenList

                    DistinctTokenList.Add(OriginalTokenList[i]);
                    //If the DistinctTokenList does not contain something in
                    //the Original, it gets added to the DistinctTokenList
                }
            }


      
            for(int i=0; i< DistinctTokenList.Count; i++)
            {
                DistinctWord w1 = new DistinctWord(DistinctTokenList[i]);
                DistinctWordList.Add(w1);
            }
            //Puts all the strings in DistinctTokenList into the class
            //property, DistinctWordList, as DistinctWord objects


            for(int i=0; i < DistinctWordList.Count ; i++)
            {
                for(int j=0; j < OriginalTokenList.Count; j++)
                {
                    if(DistinctWordList[i].Word.ToLower().Equals(OriginalTokenList[j].ToLower()))
                    {
                        DistinctWordList[i].Count += 1;
                    }

                    //The outer loop loops through all elements of the DistinctWord List. The inner
                    //Loop compares each element of the DistinctWordList to all of the OriginalTokenList
                    //THe if statement compares the string from both lists and sees if they are equal. 
                    //In order for this equality to work properly, both strings must be lower cased.
                    //If there is a match for the DistinctWord, Its Counter gets bumped up by 1
                }
            }

        }//end CountingAndSetting(Text)



          
        /// <summary>
        /// Search predicate returns true if a string ends is a punctuation.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <returns>true is the string is punctuation, false if not</returns>
        private static bool Punctuation(String s)
        {
            return s.Equals("!");
        }//end Punctuation(String)


        /// <summary>
        /// Search predicate returns true if a string has a space character
        /// </summary>
        /// <param name="s">The s.</param>
        /// <returns>true is the string is a space character, false if not</returns>
        private static bool NoSpaces(String s)
        {
            if (s == @"/n" | s == @"/r" )
                return true;
            else
                return false;

        }//end NoSpaces(String)


        /// <summary>
        /// Displays all distinct word objects
        /// </summary>
        public void Display()
        {

            DistinctWordList.Sort();
            for (int i=0; i < DistinctWordList.Count; i++)
            {


                if (i == 0)
                {
                    Console.Write("\n\nThe Distinct Words of the File \n\n");

                    Console.Write($"    {"Word".PadRight(50, ' ')}Count");
                    Console.Write($"\n    {"----".PadRight(50, ' ')}-----");
                }

                if (i % 20 == 0 && i != 0)
                {
                    Utility.PressAnyKey();
                    Console.Clear();
                    Console.Write("\n\nThe Distinct Words of the File \n\n");

                    Console.Write($"    {"Word".PadRight(50, ' ')}Count");
                    Console.Write($"\n    {"----".PadRight(50, ' ')}-----");

                }


                if (i == (DistinctWordList.Count - 1))
                {


                    Console.Write($"\n{(i + 1).ToString().PadRight(4, ' ')}{DistinctWordList[i].ToString()}");
                    Utility.PressAnyKey();
                    Console.Clear();

                }



                Console.Write($"\n{(i + 1).ToString().PadRight(4, ' ')}{DistinctWordList[i].ToString()}");
               

            }

            

        }//end Display()





        /// <summary>
        /// Lower cases all elements in a sting list
        /// </summary>
        /// <param name="list">The String list you wish to lower case</param>
        public List<String> LowerCase(List<String> list)
        {
            List<String> newList = new List<string>();
            for(int i=0; i < list.Count; i++)
            {
                newList.Add(list[i].ToLower());
            }
            
            return newList;
        }//end LowerCase(List<String>)


    }//end Words
}//end Project1
