////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//  Project:        Project2
//  File Name:      TextAnalysisForm.cs
//  Description:    Main form for the Text Analysis project 
//  Course:         CSCI 2210-201  - Data Structures
//  Author:         Nathan Wolf, wolfnj@etsu.edu
//  Created:        March 16, 2018 
//  Copyright:      Nathan Wolf, 2018
//
////////////////////////////////////////////////////////////////////////////////////////////////////////


using Project1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Project2
{
    /// <summary>
    /// Public class for the main Window for the Text Analysis
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class TextAnalysisForm : Form
    {

        Text text = null;                      //Used for opening the text file
        OpenFileDialog dlg = new OpenFileDialog();     //Lets the user open a test file

        String strFileName;                     //Holds the File Name of the file
        int iLastIndex;                         //Finds last index of / in file path

       

        /// <summary>
        /// Initializes a new instance of the <see cref="TextAnalysisForm"/> class.
        /// </summary>
        public TextAnalysisForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Handles the Click event of the selectTextFileToolStripMenuItem control.
        /// Allows the user to select a text file
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void selectTextFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Words w1;                                   //for finding the DistinctWords
            SentenceList s1;                            //for displaying the Sentences
            ParagraphList p1;                           //for displaying the Paragraphs

            #region Selecting the Text
            dlg.Filter = "text files|*.txt;*.text|all files|*.*";
            dlg.InitialDirectory = @"..\..\TextFile";
            dlg.Title = "Open Text File";

            if (DialogResult.OK != dlg.ShowDialog())
            {
                MessageBox.Show(null, "No file selected. Going back to menu.",
                    "No File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;         //returns to main menu
            }

            text = new Text(dlg.FileName);

            OriginalTextPrint.Text = text.TextFile;
            OriginalTextPrint.Text += "\n\n";       //Adding some extra lines 
            #endregion


            w1 = new Words(text);
            s1 = new SentenceList(text);
            p1 = new ParagraphList(text);

            #region Displaying the Tokens
            TokensListBox.Items.Clear();        //Clears the text box for new info
            for (int i = 0; i < text.Tokens.Count; i++)
            {
                if (text.Tokens[i] == "\r" || text.Tokens[i] == "\n")
                {
                    TokensListBox.Items.Add(@"\n");
                    //changing the \r and \n to literal \ns for the tokens
                }
                else if(text.Tokens[i] == "\t")
                {
                    TokensListBox.Items.Add(@"\t");
                    //changing \t to literal \t in the tokens
                }
                else
                {
                    TokensListBox.Items.Add(text.Tokens[i]);
                    //Just add non escape characters to the TokensListBox
                }

            }
            #endregion


            #region Displaying the Distinct Words
            w1.DistinctWordList.Sort();     //gets the distinct words for w1 and sorts them
            DistinctWordsBox.Items.Clear();             //Clears the text box for new info

            for (int i=0; i < w1.Count; i++)
            {
                DistinctWordsBox.Items.Add($"{w1[i].ToString()}");
                //gets each index of the distinctWord object in the from the DistinctWord List
                // in the Words object by an indexer. 
            }
            #endregion


            #region Labeling the Status Bar

            iLastIndex = dlg.FileName.LastIndexOf('\\');    //find last index of \ for file name
            strFileName = dlg.FileName.Substring(iLastIndex + 1);   //the file name starts one character
                                                                    //after the \
            this.FileStatusLabel.Text = $"File: {strFileName.PadRight(95, ' ')}";
            this.TokensStatusLabel.Text = $"Tokens: {text.Tokens.Count}";
            this.DistinctWordsStatusLabel.Text = $"Distinct Words: {w1.Count}";
            this.SenStatusLabel.Text = $"Sentences: {s1.NumberOfSentences}";
            this.ParaStripStatusLabel.Text = $"Paragraphs: {p1.NumberOfParagraphs}";
            //writes info o the labels in the status strip and pads them

            #endregion
        }


        /// <summary>
        /// Handles the ValueChanged event of the SentenceUpDown control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void SentenceUpDown_ValueChanged(object sender, EventArgs e)
        {
            SentenceList s1;        // Holds List of sentences
            try
            {
                s1 = new SentenceList(text);

                String strSentence; //get the sentence and formats the string

                if ((int)this.SentenceUpDown.Value == 0)
                {
                    this.SentenceTextBox.Text = "Choose A Sentence";
                    //Display this when the value for the up down is zero
                }



                this.SentenceUpDown.Maximum = s1.NumberOfSentences; //max sentence limit
                this.SentenceUpDown.Minimum = 0;                    //min sentence limit

                int i = (int)this.SentenceUpDown.Value;             //The current sentence index
                                                                    //corresponding to the up down


                strSentence = s1[i - 1].ToString().Replace("\b", "");   //gets rid of the backspace characters
                strSentence = Regex.Replace(strSentence, @"\s+", " ");  //gets rid of multi space and 
                                                                        //replaces with single spaces

                for (int k = 0; k < strSentence.Length; k++)
                {
                    if (strSentence[k] == '.' || strSentence[k] == '!' || strSentence[k] == '?' || 
                        strSentence[k] == ',' || strSentence[k] == ';' || strSentence[k] == '"')
                    {
                        strSentence = strSentence.Remove(k - 1,1);
                        //takes out the space before the punctuation
                    }
                }
                


                this.SentenceTextBox.Text = strSentence ; //adds the formated sentence to the text box




                this.SenNumWordsTextBox.Text = $"{s1[i - 1].WordCount}"; 
                this.SenAveWordsTextBox.Text = $"{s1[i - 1].AverageWordLength}";
                //adds the word count and average word length to the respective text boxes


            }
            catch(Exception)
            {
                if ((int)this.SentenceUpDown.Value != 0)
                    MessageBox.Show("Please choose a text file.");
                // Display message if a the control is activated before the user chooses a text file
            }
        }


        /// <summary>
        /// Handles the Click event of the NextSentenceButton control.
        /// Shows the next sentence.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void NextSentenceButton_Click(object sender, EventArgs e)
        {
            this.SentenceUpDown.UpButton();
        }


        /// <summary>
        /// Handles the Click event of the PreviousButton control.
        /// Shows previous sentence.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void PreviousButton_Click(object sender, EventArgs e)
        {
            this.SentenceUpDown.DownButton();
        }


        /// <summary>
        /// Handles the ValueChanged event of the ParagraphUpDown control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ParagraphUpDown_ValueChanged(object sender, EventArgs e)
        {
            ParagraphList p1; // Used to get the paragraphs from the text

            try
            {
                p1 = new ParagraphList(text);
                String strParagraph; //get the paragraph and formats the string

                if ((int)this.ParagraphUpDown.Value == 0)
                {
                    this.ParagraphTextBox.Text = "Choose a Paragraph";
                    
                }



                this.ParagraphUpDown.Maximum = p1.NumberOfParagraphs; //max number of paragraphs
                this.ParagraphUpDown.Minimum = 0;                     //min number of paragraphs
                int i = (int)this.ParagraphUpDown.Value;              //index of current paragraph

                strParagraph = p1[i - 1].ToString().Replace("\b", "");   //gets rid of the backspace characters
                strParagraph = Regex.Replace(strParagraph, @"\s+", " ");  //gets rid of multi space and 
                                                                          //replaces with single spaces
                for (int k = 0; k < strParagraph.Length; k++)
                {
                    if (strParagraph[k] == '.' || strParagraph[k] == '!' || strParagraph[k] == '?' ||
                        strParagraph[k] == ',' || strParagraph[k] == ';' || strParagraph[k] == '"')
                    {
                        strParagraph = strParagraph.Remove(k - 1, 1);
                        //takes out the space before the punctuation
                    }
                }


                this.ParagraphTextBox.Text = strParagraph;


                this.ParaSenNumTextBox.Text = $"{p1[i - 1].SentenceNum}";
                this.ParaWordsNumTextBox.Text = $"{p1[i-1].WordNum}";
                this.ParaAveWordsTextBox.Text = $"{p1[i-1].AverageWordsPerSentence}";

            }
            catch (Exception)
            {
                if((int)this.ParagraphUpDown.Value != 0)
                    MessageBox.Show("Please choose a text file.");
                //Displays message if user has not chosen a text file yet
            }



        }


        /// <summary>
        /// Handles the Click event of the NextParagraphButton control.
        /// Displays Next Paragraph
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void NextParagraphButton_Click(object sender, EventArgs e)
        {
            this.ParagraphUpDown.UpButton();
        }


        /// <summary>
        /// Handles the Click event of the PrevParagraphButton control.
        /// Displays Previous Paragraph
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void PrevParagraphButton_Click(object sender, EventArgs e)
        {
            this.ParagraphUpDown.DownButton();
        }


        /// <summary>
        /// Display about box when help is chosen on the tabbed interface
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextAboutBox box = new TextAboutBox();
            box.ShowDialog();
        }

    }//end TextAnalysisForm
}//end Project2
