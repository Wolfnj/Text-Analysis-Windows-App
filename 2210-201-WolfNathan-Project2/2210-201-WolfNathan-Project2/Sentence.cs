////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//  Project:        Project2
//  File Name:      Sentence.cs
//  Description:    This class represents a single sentence
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
    /// Represents a single sentence object. Counts the total number of words
    /// and calculates the average word length of the sentence
    /// </summary>
    class Sentence
    {
        public String Text { get; private set; }        //the text which the sentence will be taken out 
                                                        //of

        public int WordCount { get; private set; }      //The number of words in the sentence

        public double AverageWordLength { get; private set; }   //The average length of all the words

        public int WordsLength { get; private set; }     //gets length of all words in the sentence   

        public int Start { get; private set; }  //first token in the list of tokens where the sentence begins

        public int End { get; private set; }    //subscript of the final token in the sentence

        /// <summary>
        /// Default Sentence Constructor 
        /// </summary>
        public Sentence()
        {
            Text = "";
            WordCount = 0;
            AverageWordLength = 0;
            Start = 0;
            End = 0;
        }//end Sentence()


        /// <summary>
        /// Sentence constructor. Contains a single sentence form a block of text
        /// </summary>
        /// <param name="t1">The text object which will be split up into individual sentences.</param>
        /// <param name="startingPosition">The starting position of the sentence in the 
        ///                                     text file.</param>
        public Sentence(Text t1, int startingPosition)
        {
            List<String> Tokens = new List<string>();       //List which contains the tokens from the 
                                                            //text file

            List<String> Words = new List<string>();        //List which contains only the words of the
                                                            // text file

            String OnlyWords = "";                      //String that holds only the words
                                                        // for finding total word length





            Predicate<String> punctuation = (String s) => { return s == "." || s == "!" || s == "?"; };
            //finds any index of these tokens in a list of tokens



            String delims = " \r\n\t,.;?!\r:\"“”";          //delimiters for the text file


            Tokens = Utility.Tokenize(t1.TextFile, delims); //Tokenizes the Sentence







            End = Tokens.FindIndex(startingPosition, punctuation);
            //For the FindIndex method checks for punctuation in each token

            for (int i = startingPosition; i <= End; i++)
            {
                Text += Tokens[i] + " ";
                Words.Add(Tokens[i]);
            }




            Words.RemoveAll(s => s.Equals("."));       //Removes all periods
            Words.RemoveAll(s => s.Equals("!"));       //Removes all exclamation
            Words.RemoveAll(s => s.Equals("?"));       //Removes all question marks
            Words.RemoveAll(s => s.Equals(";"));       //Removes all semicolons
            Words.RemoveAll(s => s.Equals(","));       //Removes all commas
            Words.RemoveAll(s => s.Equals(":"));       //Removes all colons
            Words.RemoveAll(s => s.Equals("@"));       //Removes all @
            Words.RemoveAll(s => s.Equals("\""));       //Removes all parenthesis

            Words.RemoveAll(s => s.Equals("\n"));       //Removes all newlines
            Words.RemoveAll(s => s.Equals("\r"));       //Removes all returnlines
            Words.RemoveAll(s => s.Equals("\t"));       //Removes all tabs
            //removes all the stuff in order to count only the words


            for (int i = 0; i < Words.Count; i++)
            {
                WordCount++;
                OnlyWords += Words[i];
                //counts only the number of words
            }


            WordsLength = OnlyWords.Length; //the length will be the total length of all the words





            AverageWordLength = WordsLength / WordCount;
        }//end  Sentence(Text, int )



        /// <summary>
        /// Overridden ToString that displays formated sentences with info
        /// </summary>
        /// <returns>
        /// THe sentences with the total number of words and average word length
        /// </returns>
        public override string ToString()
        {
            String strOutput = "";       //the outputted formated String

            strOutput += $"\n  { Utility.FormatText(Text, 5, 100)}";


  
            strOutput += "\n";
            return strOutput;
        }//end ToString()

    }//end Sentence

}//end Project1
