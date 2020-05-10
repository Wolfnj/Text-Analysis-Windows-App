////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//  Project:        Project2
//  File Name:      SentenceList.cs
//  Description:    This class represents a generic list of sentence objects
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
    /// A generic list for sentence objects. Organizes and displays
    /// all the sentences in a formatted output
    /// </summary>
    class SentenceList
    {
        public List<Sentence> List { get; private set; }        //holds the list of sentences

        public int NumberOfSentences { get; private set; }      //holds number of sentences

        public double AverageLength { get; private set; }      //The average length of all the sentences




        /// <summary>
        /// Gets or sets the <see cref="Sentence"/> at the specified index.
        /// </summary>
        /// <value>
        /// The <see cref="Sentence"/>.
        /// </value>
        /// <param name="Index">The index.</param>
        /// <returns></returns>
        /// <exception cref="IndexOutOfRangeException">
        /// The index is out of range
        /// or
        /// The index is out of range
        /// </exception>
        public Sentence this[int Index]
        {
            get
            {
                if (Index < 0 || Index >= NumberOfSentences)
                {
                    throw new IndexOutOfRangeException("The index is out of range");
                }
                return List[Index];
            }
            set
            {
                {
                    if (Index < 0 || Index >= NumberOfSentences)
                    {
                        throw new IndexOutOfRangeException("The index is out of range");
                    }
                    List[Index] = value;
                }
            }
        }






        /// <summary>
        /// Default constructor for the sentence List
        /// </summary>
        public SentenceList()
        {
            List = null;
            NumberOfSentences = 0;
            AverageLength = 0;
        }//end SentenceList()


        /// <summary>
        /// Takes a text object to find all of the sentences in it
        /// </summary>
        /// <param name="t1">The input text object.</param>
        public SentenceList(Text t1)
        {
            GettingSentences(t1);
            double dTotalWordLength= 0;       //the total length of all the word in all sentences
            int iWordsCount=0;                //total number of words

            NumberOfSentences = List.Count;
            //The number of sentences will just be the amount the list contains

            for (int i = 0; i < List.Count; i++)
            {
                dTotalWordLength += List[i].WordsLength;
                iWordsCount += List[i].WordCount;
            }

            AverageLength = dTotalWordLength / iWordsCount;

        }//end SentenceList(Text)


        /// <summary>
        /// Getting the sentences and putting them into the list
        /// </summary>
        /// <param name="t1">The input text object.</param>
        private void GettingSentences(Text t1)
        {
            List = new List<Sentence>();    //Sets the List to an instance

            List<String> words = new List<String>();  //The words that will make up the sentence

            Predicate<String> punctuation = (String s) => { return s == "." || s=="!" || s=="?"; };
            //For the FindIndex method checks for punctuation in each token


            Sentence s1;                //holds new sentence objects

            int Start = 0;          //Index Where the sentence starts
            int End = 0;            //Index where the Sentence ends

            words = t1.Tokens;  //gets all the tokens from the text file

            while(Start < words.Count)
            {
                
                End = words.FindIndex(Start, punctuation);
                //finds where the sentence ends

                s1 = new Sentence(t1, Start);
                //creates the sentences
                List.Add(s1);
                //stores this sentence to the sentence list
               


                Start = End + 1;
                //The start will be the very next thing in the list after where the last sentence ends
                    
            }


        }//end GettingSentences(Text)

        /// <summary>
        /// Displays  all of the sentences.
        /// </summary>
        public void Display()
        {

            for (int i=0; i < List.Count; i++)
            {
                if (i == 0)
                {
                    Console.Write("Sentences found in the text: \n");
                    Console.Write($"\nSentence {i + 1}");
                    Console.Write(List[i].ToString());

                }

                else if (i % 3 == 0 && i != 0)
                {

                    Utility.PressAnyKey();
                    Console.Clear();
                    Console.Write("Sentences found in the text: \n");

                    Console.Write($"\nSentence {i + 1}");
                    Console.Write(List[i].ToString());


                }


                else if (i == (List.Count - 1))
                {
                    Utility.PressAnyKey();
                    Console.Clear();
                    Console.Write("Sentences found in the text: \n");
                    Console.Write($"\nSentence {i + 1}");
                    Console.Write(List[i].ToString());


                }
                else
                {
                    Console.Write($"\nSentence {i + 1}");
                    Console.Write(List[i].ToString());
                }

            }

            Console.Write($"\n\n There are {NumberOfSentences} sentences, with an average length of {Math.Round(AverageLength, 3)} words  \n\n");
            Utility.PressAnyKey();

           
        }
    }//end SentenceList
}//end Project1
