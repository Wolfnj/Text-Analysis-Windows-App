////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//  Project:        Project 2
//  File Name:      Names.cs
//  Description:    Names class that will alter the name entered by the user
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

namespace Project1
{
    /// <summary>
    /// Stores methods for Properly capitalizing Names in different formats
    /// </summary>
    class Name
    {
        public String LastName { get; set; }    //holds the last name of the person

        public String RestName { get; set; }    //holds the remaining part of the person's name other 
                                                //than last name

        public String Suffix { get; set; }      //holds the suffix of the person's name if they have 
                                                //one, otherwise, it is blank



        /// <summary>
        /// Initializes a new instance of the <see cref="Name"/> class.
        /// The default, no argument, constructor for the Name class.
        /// It just sets the name to blank
        /// </summary>
        public Name()
        {
            LastName = "";
            RestName = "";
            Suffix = "";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Name"/> class.
        /// </summary>
        /// <param name="inputString">The input string.
        /// The input String will be the complete name of the individual</param>
        public Name(String inputString)
        {
            RestName = OrganizeFirst(inputString);
            LastName = OrganizeLast(inputString);
            Suffix = GetSuffix(inputString);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Name"/> class.
        /// This is the copy constructor to the Name class
        /// </summary>
        /// <param name="n1">The n1. This is the Name object that will
        /// be copied into the newly created Name object</param>
        public Name(Name n1)
        {
            RestName = n1.RestName;
            LastName = n1.LastName;
            Suffix = n1.Suffix;
        }

        /// <summary>
        /// Organizes the first part of the name.
        /// </summary>
        /// <param name="inputString">
        /// The input string.
        /// The input String will be the complete name of the individual
        /// </param>
        /// <returns>
        /// The output will be the organized first name, i.e. all of the name 
        /// that is not the last name
        /// </returns>
        public String OrganizeFirst(String inputString) 
        {
            int iCol;   //holds certain positions in the string to form a sub string
            String strNoSuffix; //Holds the part of the name without the suffix, if the name has one
            String strOrganizedFirst = ""; //the organized in format,  FirstName LastName

            if(inputString == "")
            {
                throw new Exception("Input String cannot be empty");
            }


            //Checks to see if there is a comma in the name
            if (inputString.Contains(','))
            {
                //Checks if the format is Last, First or First Last, Suffix
                if (inputString.IndexOf(',') == inputString.LastIndexOf(','))
                {
                    //Checks if the format is Last, First
                    if (inputString.IndexOf(',') < inputString.IndexOf(' '))
                    {
                        //Checks if the first name is made up of two parts
                        if (inputString.IndexOf(' ') < inputString.LastIndexOf(' '))
                        {
                            iCol = inputString.IndexOf(' ');
                            strOrganizedFirst = inputString.Substring(iCol + 1);
                        }
                        //Code for organizing the format of last, First
                        else
                        {
                            iCol = inputString.LastIndexOf(' ');
                            strOrganizedFirst = inputString.Substring(iCol + 1);
                        }//end  if (inputString.IndexOf(' ') < inputString.LastIndexOf(' '))
                    }

                    //Code for format of Last, First, Suffix
                    else
                    {

                        iCol = inputString.LastIndexOf(',');

                        strNoSuffix = inputString.Substring(0, iCol);
                        //Just gets the part of the entire name, without the suffix



                        iCol = strNoSuffix.LastIndexOf(' ');
                        strOrganizedFirst = inputString.Substring(0, iCol);
                        //finds the last index of the first name, then
                        //stores the entire first name into strOrganizedFirst
                    }//end  if (inputString.IndexOf(',') < inputString.IndexOf(' '))
                }
                // Options for the Last, First, Suffix format
                else
                {
                    iCol = inputString.IndexOf(' ');
                    strOrganizedFirst = inputString.Substring(iCol + 1, inputString.LastIndexOf(',') - (iCol + 1));
                    //finds the index of the first space, then takes a substring of the inputted string
                    // all the up to the second comma and stores that into strOrganizedFirst
                }//end if (inputString.IndexOf(',') == inputString.LastIndexOf(','))
            }

            //Code for operation of the Format  First Last (no Commas)
            else
            {
                if (inputString.Contains(' '))
                {
                    iCol = inputString.LastIndexOf(' ');
                    strOrganizedFirst = inputString.Substring(0, iCol);
                    //finds the last index of the first name, then
                    //stores the entire first name into strOrganizedFirst
                }
                else
                {
                    strOrganizedFirst = inputString;
                }

            }//end inputString.Contains(',')

            
            return strOrganizedFirst;
        }//end OrganizeFirst(String)



        /// <summary>
        /// Organizes the last name.
        /// </summary>
        /// <param name="inputString">
        /// The input string.
        /// The input String will be the complete name of the individual
        /// </param>
        /// <returns>
        /// the output will be the organized last name
        /// </returns>
        public String OrganizeLast(String inputString)
        {
            int iCol;   //holds certain positions in the string to form a sub string
            String strNoSuffix; //part of the name without the suffix if it is exists
            String strOrganizedLast = ""; //the organized in format,  FirstName LastName

            //Checks to see if there contains a comma in the name
            if (inputString.Contains(','))
            {
                //Checks if the format is Last, First or First Last, Suffix
                if (inputString.IndexOf(',') == inputString.LastIndexOf(','))
                {
                    //Checks if the format is Last, First
                    if (inputString.IndexOf(',') < inputString.IndexOf(' '))
                    {
                        //Checks if the first name is made up of two parts
                        if (inputString.IndexOf(' ') < inputString.LastIndexOf(' '))
                        {
                            iCol = inputString.IndexOf(',');
                            strOrganizedLast = inputString.Substring(0, iCol);
                        }
                        //Code for organizing the format of last, First
                        else
                        {
                            iCol = inputString.IndexOf(',');
                            strOrganizedLast = inputString.Substring(0, iCol);
                        }//end if (inputString.IndexOf(' ') < inputString.LastIndexOf(' '))
                    }
                    //Code for format of Last, First, Suffix
                    else
                    {
                        iCol = inputString.LastIndexOf(',');
                        strNoSuffix = inputString.Substring(0, iCol);
                        //Gets the name without the suffix, i.e. last, first

                        iCol = strNoSuffix.LastIndexOf(' ');
                        strOrganizedLast = strNoSuffix.Substring(iCol + 1);
                        //Finds the index of the last space in the string,
                        //and takes the substring of the last name and puts it
                        //into strOrganizedLast
                 
                       
                    }//end if(inputString.IndexOf(',')< inputString.IndexOf(' '))
                }

                // Options for the Last, First, Suffix format
                else
                {

                    iCol = inputString.IndexOf(',');
                    strOrganizedLast = inputString.Substring(0, iCol);
                    //finds the index of the first comma, then takes a substring from the beginning of
                    //the inputted string all the way up to the first comma, and then stores that 
                    //into strOrganizedLast
                }//end if (inputString.IndexOf(',') == inputString.LastIndexOf(','))
            }

            //Code for operation of the Format  First Last (no Commas)
            else
            {
                if (inputString.Contains(' '))
                {
                    iCol = inputString.LastIndexOf(' ');
                    strOrganizedLast = inputString.Substring(iCol + 1);
                    //finds the index of the last space in the name and takes the substring for 
                    //one space up from that to the end of the name and stores it into strOrganizedLast
                }
                else
                {
                    strOrganizedLast = "";
                    //NO last name entered
                }

            }//end if (inputString.Contains(','))


            return strOrganizedLast;
        }//end OrganizeLast(String)


        /// <summary>
        /// Gets the suffix of the name.
        /// </summary>
        /// <param name="inputString">
        /// The input string.
        /// </param>
        /// <returns>
        /// It returns a string which contains the suffix of the name.
        /// If there is no suffix in the name this method will be an empty string
        /// </returns>
        public String GetSuffix(String inputString)
        {
            int iCol;              //holds certain positions in the string to form a sub string
            String strSuffix = ""; //stores the suffix of the name if it is present

            //Checks to see if there is a comma in the name. If there is, then there may
            //be suffix present in the name
            if (inputString.Contains(','))
            {
                //checks to see if there is just one comma in the name
                if (inputString.IndexOf(',') == inputString.LastIndexOf(','))
                {
                    //checks to see if the format is Last, First
                    if (inputString.IndexOf(',') < inputString.IndexOf(' '))
                    {
                        strSuffix = "";
                        //if the format is Last, First there is no suffix
                    }
                    else
                    {

                        iCol = inputString.LastIndexOf(' ');
                        strSuffix = inputString.Substring(iCol + 1);
                        //this indicates there is a suffix in the name
                        //iCol store the last index of the last space
                        //a substring is taken of the input string from one index greater
                        //than the last empty space to the end of the input string and stores
                        //it into strSuffix
                    }
                }
                //code to organize the format with two commas, Last, First, Suffix
                else
                {
                    iCol = inputString.LastIndexOf(' ');
                    strSuffix = inputString.Substring(iCol + 1);
                    //Takes the index of the last space (iCol), and then takes a substring
                    //from one space greater than iCol. This will be the suffix and is
                    //stored into strSuffix
                }//end if (inputString.IndexOf(',') == inputString.LastIndexOf(','))
            }//end  if (inputString.Contains(','))
            return strSuffix;
        }//end GetSuffix(String)


        /// <summary>
        /// Capitalizes the name. Has the same operations for both the first and last names
        /// </summary>
        /// <param name="inputString">
        /// The input string.
        /// </param>
        /// <returns>
        /// It returns the name properly capitalized
        /// </returns>
        public String CapitalizeName(String inputString)
        {
            int iCol;       //holds certain indexes of positions of the string
            String strRestCap = ""; //stores the name that will be properly capitalized

            //checks to see if the name has a space in it
            if (inputString.Contains(' '))
            {
                //Checks if there is just one space in the name
                if (inputString.IndexOf(' ') == inputString.LastIndexOf(' '))
                {

                    strRestCap = $"{inputString.First().ToString().ToUpper()}" +
                    $"{inputString.Substring(1, inputString.IndexOf(' ') - 1).ToLower()}"
                     + " " +

                    $"{inputString[inputString.LastIndexOf(' ') + 1].ToString().ToUpper()}" +
                    $"{inputString.Substring(inputString.LastIndexOf(' ') + 2).ToString().ToLower()}"
                    ;
                    //Capitalizes the first letter for every word
                }

                //Code for operations for names that have two spaces in them
                else
                {
                    strRestCap = $"{inputString.First().ToString().ToUpper()}" +
                    $"{inputString.Substring(1, inputString.IndexOf(' ') - 1).ToLower()}"

                    + " " +

                    $"{inputString[inputString.IndexOf(' ') + 1].ToString().ToUpper()}" +
                    $"{inputString.Substring(inputString.IndexOf(' ') + 2, inputString.LastIndexOf(' ') - (inputString.IndexOf(' ') + 1)).ToString().ToLower()}"

                    + "" +

                    $"{inputString[inputString.LastIndexOf(' ') + 1].ToString().ToUpper()}" +
                    $"{inputString.Substring(inputString.LastIndexOf(' ') + 2).ToString().ToLower()}"
                    ;
                    //Capitalizes the first letter for every word

                }
            }

            //Code for operations for a name that has no spaces in it
            else
            {
                //checks if the inputstring is not empty
                if (inputString != "")
                {
                    strRestCap = $"{inputString.First().ToString().ToUpper()}{inputString.Substring(1).ToLower()}";
                }
                //capitalizes the first letter of the word
            }


            //checks if there exists a Mc or Mac in the name
            if (strRestCap.Contains("Mc") || strRestCap.Contains("Mac"))
            {
                if (strRestCap.Contains("Mc"))
                {
                    strRestCap = "Mc" + strRestCap.Substring(2).First().ToString().ToUpper() +
                        strRestCap.Substring(3);
                    //Takes a name with "Mc" in it and capitalized the first letter after it
                }
                else
                {
                    strRestCap = "Mac" + strRestCap.Substring(3).First().ToString().ToUpper() +
                        strRestCap.Substring(4);
                    //Takes a name with "Mac" in it and capitalized the first letter after it

                }

            }//ends if (strRestCap.Contains("Mc") || strRestCap.Contains("Mac"))

            //checks if there exists a O' in the name
            if (strRestCap.Contains("O'"))
            {
                strRestCap = "O'" + strRestCap.Substring(2).First().ToString().ToUpper() +
                     strRestCap.Substring(3);
                //Takes a name with "O'" in it and capitalized the first letter after it
            }//end if (strRestCap.Contains("O'"))

            if (strRestCap.Contains('-'))
            {
                iCol = strRestCap.IndexOf('-');
                strRestCap = strRestCap.Substring(0, iCol) + "-" +
                strRestCap.Substring(iCol + 1).First().ToString().ToUpper() + 
                strRestCap.Substring(iCol + 2);
                //Capitalizes names that are hyphenated, it capitalizes the first letter in each word
            }

            return strRestCap;
        }// CapitalizeName(String)
      



        /// <summary>
        /// Capitalizes the suffix.
        /// </summary>
        /// <param name="inputString">
        /// The input string.
        /// </param>
        /// <returns>
        /// The properly capitalized suffix
        /// </returns>
        public String CapitalizeSuffix(String inputString)
        {
            String strCheck;
            String strSuff = "";
            String str1;
            String str2;
            //Checks to see if there is a suffix
            if (inputString != "")
            {

                str1 = inputString.Trim('.');
                str2 = str1.Substring(2);
                strCheck = str2.ToUpper();
                //str1 contains the inputString without a period if there exist one it inputString
                //str2 gets the substring of just the suffix without any spaces
                //strCheck uppercases str2 and checks for known suffixes in the switch statement
            
                switch (strCheck)
                {
                    case "JR":
                    case "JR.":
                        strSuff = ", Jr.";
                        break;
                    case "I":
                    case "II":
                    case "III":
                    case "IV":
                    case "V":
                    case "VI":
                    case "VII":
                    case "VIII":
                    case "VIIII":
                    case "IIIX":
                    case "IIX":
                    case "IX":
                    case "X":
                        strSuff =", " + strCheck;
                        break;
                    case "MD":
                    case "MD.":
                        strSuff = ", MD";
                        break;
                    case "JD":
                    case "JD.":
                        strSuff = ", JD";
                        break;
                    case "PHD":
                    case "PHD.":
                        strSuff = ", PhD";
                        break;
                    default:
                        strSuff = "";
                        break;
                }//end  switch(strCheck)
            }
            else
            {
                strSuff = "";
                //strSuff is an empty string, because there is no suffix
            }
            return strSuff;
        }//end CapitilizeSuffix()


        /// <summary>
        /// Displays the first name first.
        /// </summary>
        /// <returns> A string in the format: First Last</returns>
        public String DisplayFirstNameFirst()
        {
            String strSuffix = "";

            if (Suffix != "")
            {
                strSuffix = $", {Suffix}";
            }
            return $"{CapitalizeName(RestName)} {CapitalizeName(LastName)}{CapitalizeSuffix(strSuffix)}";
        }

        /// <summary>
        /// Displays the last name first.
        /// </summary>
        /// <returns> A String in the format:  Last, First</returns>
        public String DisplayLastNameFirst()
        {
            String strSuffix = "";

            if (Suffix != "")
            {
                strSuffix = $", {Suffix}";
            }
            return $"{CapitalizeName(LastName)}, {CapitalizeName(RestName)}{CapitalizeSuffix(strSuffix)}";
        }
    }//end Name

}//end Project1
