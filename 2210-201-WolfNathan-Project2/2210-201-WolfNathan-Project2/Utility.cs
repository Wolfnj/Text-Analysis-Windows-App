////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//  Project:        Project2
//  File Name:      Utility.cs
//  Description:    Contains often used static methods
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

namespace Utils
{
    /// <summary>
    /// Class that contains commonly used static methods
    /// </summary>
    class Utility
    {

        /// <summary>
        /// Displays a welcome message
        /// </summary>
        public static void Welcome()
        {

            Console.WriteLine("////////////////////////////////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("//");
            Console.WriteLine("//  Project:        Project 1");
            Console.WriteLine("//  File Name:      P1Driver.cs");
            Console.WriteLine("//  Description:    Menu driven program that prompts the user to input name, phone number, and email address");
            Console.WriteLine("//  Course:         CSCI 2210-201  - Data Structures");
            Console.WriteLine("//  Author:         Nathan Wolf, wolfnj@etsu.edu");
            Console.WriteLine("//  Created:        Thursday, February 20, 2018 ");
            Console.WriteLine("//  Copyright:      Nathan Wolf, 2018");
            Console.WriteLine("//");
            Console.WriteLine("////////////////////////////////////////////////////////////////////////////////////////////////////////");

        }//end Welcome()


        /// <summary>
        /// Displays an exit message.
        /// </summary>
        public static void Exit()
        {
            Console.WriteLine("The program will now end");
            Console.WriteLine("Thank you!!!");
        }//end Exit()




        /// <summary>
        /// Parses the input string into its individual tokens, which will be returned to in a list
        /// </summary>
        /// <param name="original">The original input string put in to be parsed </param>
        /// <param name="delimiters">Possible delimiters in the text string</param>
        /// <returns> A List of all the tokens </returns>
        public static List<String> Tokenize(string original, string delimiters)
        {
            List<string> tokens = new List<string>();

            //converts the delimiters to a character array
            char[] charArrayDelims = delimiters.ToCharArray();


            //Holds the value of the index of the string 
            int Index;

            //Holds the substring of the new string
            String strNew = "";


            strNew = original.Trim();
            Index = strNew.IndexOfAny(charArrayDelims);
            if (Index == -1)
            {
                //If the strNew is only one word
                tokens.Add(strNew.Substring(0));
            }
            else
            {
                //If strNew is more than one word
                tokens.Add(strNew.Substring(0, Index));

                while (strNew.Length > 1)
                {
                    //Holds the new String with the preceding word removed
                    if (Index == -1)
                    {
                        //If the Index is negative one here, it is the last word and
                        // do not need to be in this while loop
                        break;
                    }
                    strNew = strNew.Substring(Index);
                    strNew = strNew.Trim(' ');
                    Index = strNew.IndexOfAny(charArrayDelims);

                    if (Index == 0)
                    {
                        //This is code for what happens when a delimiter is at index 0

                        tokens.Add(strNew[0].ToString());
                        //the delimiter will be considered a token and be put into the
                        //tokens list

                        strNew = strNew.Substring(1);
                        //After this happens, a substring will be taken of
                        //the index right after the first, up to the end of the
                        //remaining string
                    }
                    else if (Index == -1)
                    {
                        tokens.Add(strNew);
                    }
                    else
                    {
                        //The delimiter is not at index zero
                        //thus take a substring from the beginning to the first index
                        //found in the new string
                        tokens.Add(strNew.Substring(0, Index));
                    }//end if (Index == 0)

                }//end while (strNew.Length > 1)

            }//end if (Index == -1)

            return tokens;
        }//end Tokenize(string,string)


        /// <summary>
        /// Formats and returns displayable Strings from a collection of tokens 
        /// </summary>
        /// <param name="txt">The text file as a input string.</param>
        /// <returns>The formated text</returns>
        public static String FormatText(string txt, int leftMargin, int rightMargin)
        {


            String delims = " \n\n\t,.;?!\r:\"“”";          //delimiters for the text file
            List<String> list = new List<string>();
            list = Tokenize(txt, delims);      //List containing all the tokens in the text
            String strCheck = "";                  //checks the string length before the print
            String strPrint = "";                   //the final string which will be printed
            String strSpaces = "";                  //the number of spaces for the left margin




            list.RemoveAll(s => s.Equals("\n"));       //Removes all newlines
            list.RemoveAll(s => s.Equals("\r"));       //Removes all returnlines
            list.RemoveAll(s => s.Equals("\t"));       //Removes all tabs





            for (int i = 0; i < leftMargin; i++)
            {
                strSpaces += " ";
                //gets the number of spaces from the left margin
            }


            for (int i = 0; i < list.Count; i++)
            {
                if (strCheck.Length < (rightMargin - leftMargin))
                {
                    //checks the total length the string needs to be
                    if (list[i] == ";" | list[i] == "," | list[i] == "." | list[i] == "\"" | list[i] == "?"
                                                    | list[i] == "!")
                    {
                        //takes out the space before the last token if it has any of these characters
                        strCheck += "\b" + list[i] + " ";
                    }
                    else
                    {
                        strCheck += list[i] + " ";
                    }
                }
                else
                {
                    if (list[i] == ";" | list[i] == "," | list[i] == "." | list[i] == "\"")
                    {
                        strCheck += "\b" + list[i];
                    }
                    else
                    {
                        strCheck += list[i] + " ";
                    }
                    strPrint += "\n" + strSpaces + strCheck;   //prints the string with the spaces 
                                                               //before it
                    strCheck = "";                              //empty the string for the next line
                }
            }

            strPrint += "\n" + strSpaces + strCheck;      //for the final line
            strPrint += "\n\n";



            return strPrint;
        }//end FormatText(String, int, int)


        /// <summary>
        /// Presses any key to continue through the program.
        /// </summary>
        public static void PressAnyKey()
        {
            Console.WriteLine("\n\nPress Any Key To Continue");
            Console.ReadKey();
        }//end PressAnyKey()

    }//end Utility


    /// <summary>
    /// A menu class which is use to create the menu in the driver
    /// </summary>
    public class Menu
    {
        private List<string> Items = new List<string>();
        public string Title { get; set; }

        #region Constructor
        /// <summary>
        /// Constructor 
        /// </summary>
        /// <param name="title">the title to be displayed above menu</param>
        public Menu(string title = "Menu")
        {
            Title = title;
        }
        #endregion

        #region Plus and Minus Operators
        /// <summary>
        /// Operator + adds a choice to the menu
        /// </summary>
        /// <param name="m">the menu to which the choice is added</param>
        /// <param name="item">the choice to be added</param>
        /// <returns></returns>
        public static Menu operator +(Menu m, string item)
        {
            m.Items.Add(item);
            return m;
        }

        /// <summary>
        /// Operator  - removes a choice from the menu
        /// </summary>
        /// <param name="m">the menu from which the choice is removed</param>
        /// <param name="item">the number of the choice to be removed</param>
        /// <returns></returns>
        public static Menu operator -(Menu m, int n)
        {
            if (n > 0 && n <= m.Items.Count)
                m.Items.RemoveAt(n - 1);
            return m;
        }
        #endregion

        #region Display and GetChoice methods
        /// <summary>
        /// Display the menu on the console window
        /// </summary>
        public void Display()
        {
            string str = "";
            Console.Clear();
            str = DateTime.Today.ToLongDateString();
            Console.SetCursorPosition(Console.WindowWidth - str.Length, 0);
            Console.WriteLine(str);
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("\n\n\t   " + Title);
            Console.Write("\t   ");
            for (int n = 0; n < Title.Length; n++)
                Console.Write("-");
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            for (int n = 0; n < Items.Count; n++)
                Console.WriteLine("\t{0}. {1}", (n + 1), Items[n]);
        }

        /// <summary>
        /// Obtain the user's selection, verify it is valid, and return it
        /// </summary>
        /// <returns>the number of the user's valid selection</returns>
        public int GetChoice()
        {
            int choice = -1;
            string line;
            if (Items.Count < 1)
                throw new Exception("The menu is empty");

            while (true)
            {
                Display();
                Console.Write("\n\t   Type the number of your choice from the menu: ");
                Console.ForegroundColor = ConsoleColor.Red;
                line = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Blue;
                if (!Int32.TryParse(line, out choice))
                {
                    Console.WriteLine("\n\t   Your choice is not a number between 1 and {0}.  Please try again.",
                        Items.Count);
                    Console.ReadKey();
                }
                else
                {
                    if (choice < 1 || choice > Items.Count)
                    {
                        Console.WriteLine("\n\t   Your choice is not a number between 1 and {0}.  Please try again.",
                        Items.Count);
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.Clear();
                        return choice;
                    }
                }
            }
        }
        #endregion
    }//end Menu



    /// <summary>
    /// Enumerated choices for the menu class
    /// </summary>
    enum Choices
    {
        SELECTTEXT = 1, DISPLAYTEXT, DISPLAYTOKENS, DISPLAYDISTINCT,
        DISPLAYSENTANCES, DISPLAYPARAGRAPHS, QUIT
    }//end Choices

}//end Utils
