////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//  Project:        Project2
//  File Name:      Text.cs
//  Description:    Inputs text from a file, parses it into tokens, and serves the collection of those tokens
//                  to other classes that will analyze the text
//  Course:         CSCI 2210-201  - Data Structures
//  Author:         Nathan Wolf, wolfnj@etsu.edu
//  Created:        March 16, 2018 
//  Copyright:      Nathan Wolf, 2018
//
////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;

namespace Project1
{
    /// <summary>
    /// Input text from a class file, parses the words, and
    /// puts those words in a list as tokens
    /// </summary>
    class Text
    {
        public String TextFile { get; set; }        //String consisting of the entire text form the file
        public List<String> Tokens { get; set; }    //String list consisting of all the tokens found 
                                                    //in the text file

        OpenFileDialog dlg = new OpenFileDialog();  //Lets the user open a test file

        StreamReader rdr = null;                    //reads text from the file


        /// <summary>
        /// Default constructor for the Text class
        /// </summary>
        public Text()
        {
            TextFile = "";
            Tokens = new List<string>();
        }//end Text()

        /// <summary>
        /// Parameterized constructor for the Text Class
        /// </summary>
        /// <param name="strInputTextFile">The path/file name of the text file.</param>
        public Text(String strInputTextFile)
        {
            Tokens = new List<string>();        //Contains each individual string in a list
            String str = "";     //accepts each line from the text file
            String delims = " \n\n\t,’.;?!\r:\"“”";      //possible delimiters

            try
            {
                rdr = new StreamReader(strInputTextFile);
                str = rdr.ReadToEnd();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                if (rdr != null)
                    rdr.Close();
            }

            TextFile = str;         //sets the entire text file into the property
            Tokens = Utility.Tokenize(TextFile, delims);

        }//end Text(String)

        /// <summary>
        /// Displays the original string.
        /// </summary>
        /// <returns>The original String</returns>
        public string DisplayOriginalString(String strInputTextFile)
        {
            String str = "";    //holds the original string read in form the text file

            try
            {
                rdr = new StreamReader(strInputTextFile);
                for (int i = 0; rdr.Peek() != -1; i++)
                {
                    str += " " + rdr.ReadLine();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (rdr != null)
                    rdr.Close();
            }
            return str;
        }//end DisplayOriginalString()




    }//end Text
}//end Project1
