////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//  Project:        Project2
//  File Name:      Paragraph.cs
//  Description:    Represents a paragraph extracted from the list of tokens in the Text Object
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
    /// A paragraph extracted from the list of tokens from the 
    /// text file. Can display the paragraph with the total number 
    /// of sentences and the average words per sentence.
    /// 
    /// </summary>
    class Paragraph
    {

        public String Text { get; private set; }        //the text which the paragraph will be taken out 
                                                        //of


        public double SentenceNum { get; private set; }        //number of sentences in a paragraph

        public double WordNum { get; private set; }        //number of words in the paragraph

        public double AverageWordsPerSentence { get; private set; } //The average words per sentence

        public int Start { get; private set; }  //first token in the list of tokens where the paragraph begins

        public int End { get; private set; }    //subscript of the final token in the paragraph



        /// <summary>
        /// Default Paragraph Constructor
        /// </summary>
        public Paragraph()
        {
            Text = "";
            SentenceNum = 0;
            WordNum = 0;
            AverageWordsPerSentence = 0;
            Start = 0;
            End = 0;

        }

        /// <summary>
        /// Paragraph constructor. Contains a single paragraph form a block of text
        /// </summary>
        /// <param name="t1">The text object which will be split up into individual paragraph.</param>
        /// <param name="startingPosition">The starting position of the paragraph in the 
        ///                                     text file.</param>
        public Paragraph(Text t1, int startingPosition)
        {
            List<String> Tokens = new List<string>();       //List which contains the tokens from the 
                                                            //text file

            List<Sentence> s1List = new List<Sentence>();             //holds lists of sentences to find
                                                                      //then number of sentences and total 
                                                                      //number of words


            List<String> SentenceTokens = new List<string>();       //holds lists of tokens in each ]
                                                                    //individual sentence

            String SentenceText;            //used to find the sentences
            int SentenceStart = 0;          //Index Where the sentence starts
            int SentenceEnd = 0;            //Index where the Sentence ends


            String delims = " \r\n\t,.;?!\r:\"“”";          //delimiters for the text file

            String punct = ".!?";                   //punctuation to find the sentences

            //converts the delimiters to a character array
            char[] charArrayPunct = punct.ToCharArray();



            Tokens = Utility.Tokenize(t1.TextFile, delims); //Tokenizes the Sentence



            for (int i = 0; i < Tokens.Count; i++)
            {
               if(Tokens[i] == "\r")
                {
                    Tokens[i] = "\n";
                }
            }
            //replace all the return keys to 



            for (int i = startingPosition; i < Tokens.Count; i++)
            {

                if (Tokens[i] == "\n" && Tokens[i - 3] == "\n" && Tokens[i - 2] == "\n" 
                    && Tokens[i - 2] == "\n")
                {
                    End = i;
                    break;
                }
                //THis if statement checks for \n\n\n\n in the text, this will single where a paragraph
                //ends or begins

                if(i == Tokens.Count -1)
                {
                    //we have went through all the paragraphs and the last paragraph ends at the 
                    //last token in the text file
                    End = i;
                }

            }//end for (int i = startingPosition; i < Tokens.Count; i++)



            for (int i = startingPosition; i <= End; i++)
            {
                Text += Tokens[i] + " ";
                SentenceTokens.Add(Tokens[i]);
            }
            //puts all the sentences in the paragraph into a list



        

            SentenceText = Text.Replace("\n", "");
            SentenceText = SentenceText.Replace("  ","");
            SentenceText = SentenceText.Replace(" ","");
            //Taking out spaces and new lines in order for
            //the sentence while loop to catch all of the sentences


            while(SentenceStart < SentenceText.Length)
            {
                SentenceEnd = Text.IndexOfAny(charArrayPunct, SentenceStart);
                SentenceStart = SentenceEnd + 1;
                SentenceNum++;
                //counts all sentences
            }


            SentenceTokens.RemoveAll(s => s.Equals("."));       //Removes all periods
            SentenceTokens.RemoveAll(s => s.Equals("!"));       //Removes all exclamation
            SentenceTokens.RemoveAll(s => s.Equals("?"));       //Removes all question marks
            SentenceTokens.RemoveAll(s => s.Equals(";"));       //Removes all semicolons
            SentenceTokens.RemoveAll(s => s.Equals(","));       //Removes all commas
            SentenceTokens.RemoveAll(s => s.Equals(":"));       //Removes all colons
            SentenceTokens.RemoveAll(s => s.Equals("@"));       //Removes all @
            SentenceTokens.RemoveAll(s => s.Equals("\""));      //Removes all parenthesis
            SentenceTokens.RemoveAll(s => s.Equals("\n"));       //Removes all newlines
            SentenceTokens.RemoveAll(s => s.Equals("\r"));       //Removes all returnlines
            SentenceTokens.RemoveAll(s => s.Equals("\t"));       //Removes all tabs
            //removes all this stuff in order to count the words in the sentences


            for(int i=0; i< SentenceTokens.Count; i++)
            {
                WordNum++;
            }





            AverageWordsPerSentence = WordNum / SentenceNum;

        }





        /// <summary>
        /// Overridden ToString method that prints out paragraph info
        /// </summary>
        /// <returns>
        /// The formated paragraph with total number of sentences and average words per sentence
        /// </returns>
        public override string ToString()
        {
            String strOutput = "";       //the outputted formated String

            strOutput += $"\n {Utility.FormatText(Text, 5, 100)}";


            strOutput += "\n";



            strOutput += "\n";
            return strOutput;
        }







        }//end Paragraph
}//end Project 1
