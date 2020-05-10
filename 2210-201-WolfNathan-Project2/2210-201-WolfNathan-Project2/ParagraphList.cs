////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//  Project:        Project2
//  File Name:      ParagraphList.cs
//  Description:    This class is a container for a generic List of all Paragraph objects
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
    /// A container for a generic List of all paragraph objects. Display each 
    /// paragraph object and shows the total number of paragraphs and the 
    /// average number of words in the paragraphs
    /// </summary>
    class ParagraphList
    {

        public List<Paragraph> List { get; private set; }   //The list of all paragraphs

        public int NumberOfParagraphs { get; private set; } //Number of Paragraphs in the text

        public double AverageNumberOfWords { get; private set; } //average number of words
                                                                 //per paragraph

        public double TotalNumberOfWords { get; private set; }     //the total number of words in the 
                                                                   //entire text




        /// <summary>
        /// Gets or sets the <see cref="Paragraph"/> at the specified index.
        /// </summary>
        /// <value>
        /// The <see cref="Paragraph"/>.
        /// </value>
        /// <param name="Index">The index.</param>
        /// <returns></returns>
        /// <exception cref="IndexOutOfRangeException">
        /// The index is out of range
        /// or
        /// The index is out of range
        /// </exception>
        public Paragraph this[int Index]
        {
            get
            {
                if (Index < 0 || Index >= NumberOfParagraphs)
                {
                    throw new IndexOutOfRangeException("The index is out of range");
                }
                return List[Index];
            }
            set
            {
                {
                    if (Index < 0 || Index >= NumberOfParagraphs)
                    {
                        throw new IndexOutOfRangeException("The index is out of range");
                    }
                    List[Index] = value;
                }
            }
        }







        /// <summary>
        /// Default constructor for the Paragraph List
        /// </summary>
        public ParagraphList()
        {
            List = null;
            NumberOfParagraphs = 0;
            AverageNumberOfWords = 0;
        }//end ParagraphList()




        /// <summary>
        /// Takes a text object to find all of the paragraphs in it
        /// </summary>
        /// <param name="t1">The input text object.</param>
        public ParagraphList(Text t1)
        {
            GettingParagraphs(t1);
            NumberOfParagraphs = List.Count;
            for(int i=0; i< List.Count; i++)
            {
                TotalNumberOfWords += List[i].WordNum;
                //gets the total number of words
            }


            AverageNumberOfWords = TotalNumberOfWords / NumberOfParagraphs;

        }//end ParagraphList

        /// <summary>
        /// Getting the sentences and putting them into the list
        /// </summary>
        /// <param name="t1">The input text object.</param>
        private void GettingParagraphs(Text t1)
        {
            List = new List<Paragraph>();    //Sets the List to an instance

            List<String> words = new List<String>();  //The words that will make up the Paragraph

            Paragraph p1;                //holds new paragraph objects

            int Start = 0;          //Index Where the sentence starts
            int End = 0;            //Index where the Sentence ends

            words = t1.Tokens;  //gets all the tokens from the text file


            for (int i = 0; i < words.Count; i++)
            {
                if (words[i] == "\r")
                {
                    words[i] = "\n";
                }
            }//turns all \r into \n


            while (Start < words.Count)
            {
                p1 = new Paragraph(t1, Start);
                //Creates paragraph object

                End = p1.End;
                //Gets the end of the paragraph

                List.Add(p1);
                //stores paragraph into paragraph list

                Start = End + 1;
                //The start will be the very next thing in the list after where the last paragraph ends

                //loop until you go through all the words
            }


        }//end GettingParagraphs(Text)


        /// <summary>
        /// Displays all of the paragraphs
        /// </summary>
        public void Display()
        {

  

            for (int i = 0; i < List.Count; i++)
            {
                if (i != 0)
                {
                    Utility.PressAnyKey();
                    Console.Clear();
                }
                Console.WriteLine("Paragraphs found in the text: \n");
                Console.WriteLine($"\nParagraph {i + 1}");
                Console.WriteLine(List[i].ToString());

                //displays each paragraph object
            }


            Console.WriteLine( $"\n\n There are {NumberOfParagraphs} paragraphs." +
                $" The average number of words in the paragraphs is {Math.Round(AverageNumberOfWords, 3)}   \n\n");

            Utility.PressAnyKey();
            Console.Clear();


    

        }//end Display()






    }//end ParagraphList



}//end Project1
