////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//  Project:        Project2
//  File Name:      TextAnalysisForm.Designer.cs
//  Description:    VS generated Code for the TextAnaylsis Form
//  Course:         CSCI 2210-201  - Data Structures
//  Author:         Nathan Wolf, wolfnj@etsu.edu
//  Created:        March 16, 2018 
//  Copyright:      Nathan Wolf, 2018
//
////////////////////////////////////////////////////////////////////////////////////////////////////////


namespace Project2
{
    /// <summary>
    /// Partial class that contains VS auto generated code for the TextAnalysisDesigner
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    partial class TextAnalysisForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextAnalysisForm));
            this.TextMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectTextFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TextChoicesTabs = new System.Windows.Forms.TabControl();
            this.OrignalText = new System.Windows.Forms.TabPage();
            this.OriginalTextPrint = new System.Windows.Forms.TextBox();
            this.Tokens = new System.Windows.Forms.TabPage();
            this.TokensFoundLabel = new System.Windows.Forms.Label();
            this.TokensListBox = new System.Windows.Forms.ListBox();
            this.DistinctWords = new System.Windows.Forms.TabPage();
            this.OcurrencesLabel = new System.Windows.Forms.Label();
            this.wordsLabel = new System.Windows.Forms.Label();
            this.DistinctWordsBox = new System.Windows.Forms.ListBox();
            this.Sentences = new System.Windows.Forms.TabPage();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.NextSentenceButton = new System.Windows.Forms.Button();
            this.AveWordLengthLabel = new System.Windows.Forms.Label();
            this.WordsNumLabel = new System.Windows.Forms.Label();
            this.SenAveWordsTextBox = new System.Windows.Forms.TextBox();
            this.SenNumWordsTextBox = new System.Windows.Forms.TextBox();
            this.SentenceTextBox = new System.Windows.Forms.TextBox();
            this.SentenceUpDown = new System.Windows.Forms.NumericUpDown();
            this.Paragraphs = new System.Windows.Forms.TabPage();
            this.PrevParagraphButton = new System.Windows.Forms.Button();
            this.NextParagraphButton = new System.Windows.Forms.Button();
            this.ParaAveWordsLabel = new System.Windows.Forms.Label();
            this.ParaWordsNumLabel = new System.Windows.Forms.Label();
            this.ParaSenNumLabel = new System.Windows.Forms.Label();
            this.ParaAveWordsTextBox = new System.Windows.Forms.TextBox();
            this.ParaWordsNumTextBox = new System.Windows.Forms.TextBox();
            this.ParaSenNumTextBox = new System.Windows.Forms.TextBox();
            this.ParagraphTextBox = new System.Windows.Forms.TextBox();
            this.ParagraphUpDown = new System.Windows.Forms.NumericUpDown();
            this.TextStatusStrip = new System.Windows.Forms.StatusStrip();
            this.FileStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.TokensStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.DistinctWordsStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.SenStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ParaStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.TextMenuStrip.SuspendLayout();
            this.TextChoicesTabs.SuspendLayout();
            this.OrignalText.SuspendLayout();
            this.Tokens.SuspendLayout();
            this.DistinctWords.SuspendLayout();
            this.Sentences.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SentenceUpDown)).BeginInit();
            this.Paragraphs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParagraphUpDown)).BeginInit();
            this.TextStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextMenuStrip
            // 
            this.TextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.TextMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.TextMenuStrip.Name = "TextMenuStrip";
            this.TextMenuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.TextMenuStrip.Size = new System.Drawing.Size(1008, 28);
            this.TextMenuStrip.TabIndex = 0;
            this.TextMenuStrip.Text = "TextMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectTextFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // selectTextFileToolStripMenuItem
            // 
            this.selectTextFileToolStripMenuItem.Name = "selectTextFileToolStripMenuItem";
            this.selectTextFileToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.selectTextFileToolStripMenuItem.Text = "&Select Text File";
            this.selectTextFileToolStripMenuItem.Click += new System.EventHandler(this.selectTextFileToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // TextChoicesTabs
            // 
            this.TextChoicesTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextChoicesTabs.Controls.Add(this.OrignalText);
            this.TextChoicesTabs.Controls.Add(this.Tokens);
            this.TextChoicesTabs.Controls.Add(this.DistinctWords);
            this.TextChoicesTabs.Controls.Add(this.Sentences);
            this.TextChoicesTabs.Controls.Add(this.Paragraphs);
            this.TextChoicesTabs.Location = new System.Drawing.Point(0, 28);
            this.TextChoicesTabs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextChoicesTabs.Name = "TextChoicesTabs";
            this.TextChoicesTabs.SelectedIndex = 0;
            this.TextChoicesTabs.Size = new System.Drawing.Size(1008, 722);
            this.TextChoicesTabs.TabIndex = 1;
            // 
            // OrignalText
            // 
            this.OrignalText.Controls.Add(this.OriginalTextPrint);
            this.OrignalText.Location = new System.Drawing.Point(4, 25);
            this.OrignalText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OrignalText.Name = "OrignalText";
            this.OrignalText.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OrignalText.Size = new System.Drawing.Size(1000, 693);
            this.OrignalText.TabIndex = 0;
            this.OrignalText.Text = "Original Text";
            this.OrignalText.UseVisualStyleBackColor = true;
            // 
            // OriginalTextPrint
            // 
            this.OriginalTextPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OriginalTextPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OriginalTextPrint.Location = new System.Drawing.Point(3, 2);
            this.OriginalTextPrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OriginalTextPrint.Multiline = true;
            this.OriginalTextPrint.Name = "OriginalTextPrint";
            this.OriginalTextPrint.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OriginalTextPrint.Size = new System.Drawing.Size(994, 689);
            this.OriginalTextPrint.TabIndex = 0;
            // 
            // Tokens
            // 
            this.Tokens.Controls.Add(this.TokensFoundLabel);
            this.Tokens.Controls.Add(this.TokensListBox);
            this.Tokens.Location = new System.Drawing.Point(4, 25);
            this.Tokens.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tokens.Name = "Tokens";
            this.Tokens.Size = new System.Drawing.Size(1000, 693);
            this.Tokens.TabIndex = 2;
            this.Tokens.Text = "Tokens";
            this.Tokens.UseVisualStyleBackColor = true;
            // 
            // TokensFoundLabel
            // 
            this.TokensFoundLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TokensFoundLabel.AutoSize = true;
            this.TokensFoundLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TokensFoundLabel.Location = new System.Drawing.Point(393, 60);
            this.TokensFoundLabel.Name = "TokensFoundLabel";
            this.TokensFoundLabel.Size = new System.Drawing.Size(196, 32);
            this.TokensFoundLabel.TabIndex = 1;
            this.TokensFoundLabel.Text = "Tokens Found";
            // 
            // TokensListBox
            // 
            this.TokensListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TokensListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TokensListBox.FormattingEnabled = true;
            this.TokensListBox.ItemHeight = 31;
            this.TokensListBox.Location = new System.Drawing.Point(84, 95);
            this.TokensListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TokensListBox.Name = "TokensListBox";
            this.TokensListBox.Size = new System.Drawing.Size(809, 376);
            this.TokensListBox.TabIndex = 0;
            // 
            // DistinctWords
            // 
            this.DistinctWords.Controls.Add(this.OcurrencesLabel);
            this.DistinctWords.Controls.Add(this.wordsLabel);
            this.DistinctWords.Controls.Add(this.DistinctWordsBox);
            this.DistinctWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DistinctWords.Location = new System.Drawing.Point(4, 25);
            this.DistinctWords.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DistinctWords.Name = "DistinctWords";
            this.DistinctWords.Size = new System.Drawing.Size(1000, 693);
            this.DistinctWords.TabIndex = 3;
            this.DistinctWords.Text = "Distinct Words";
            this.DistinctWords.UseVisualStyleBackColor = true;
            // 
            // OcurrencesLabel
            // 
            this.OcurrencesLabel.AutoSize = true;
            this.OcurrencesLabel.Location = new System.Drawing.Point(621, 30);
            this.OcurrencesLabel.Name = "OcurrencesLabel";
            this.OcurrencesLabel.Size = new System.Drawing.Size(223, 44);
            this.OcurrencesLabel.TabIndex = 2;
            this.OcurrencesLabel.Text = "Occurences";
            // 
            // wordsLabel
            // 
            this.wordsLabel.AutoSize = true;
            this.wordsLabel.Location = new System.Drawing.Point(117, 30);
            this.wordsLabel.Name = "wordsLabel";
            this.wordsLabel.Size = new System.Drawing.Size(130, 44);
            this.wordsLabel.TabIndex = 1;
            this.wordsLabel.Text = "Words";
            // 
            // DistinctWordsBox
            // 
            this.DistinctWordsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DistinctWordsBox.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DistinctWordsBox.FormattingEnabled = true;
            this.DistinctWordsBox.ItemHeight = 32;
            this.DistinctWordsBox.Location = new System.Drawing.Point(125, 76);
            this.DistinctWordsBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DistinctWordsBox.Name = "DistinctWordsBox";
            this.DistinctWordsBox.Size = new System.Drawing.Size(719, 516);
            this.DistinctWordsBox.TabIndex = 0;
            // 
            // Sentences
            // 
            this.Sentences.Controls.Add(this.PreviousButton);
            this.Sentences.Controls.Add(this.NextSentenceButton);
            this.Sentences.Controls.Add(this.AveWordLengthLabel);
            this.Sentences.Controls.Add(this.WordsNumLabel);
            this.Sentences.Controls.Add(this.SenAveWordsTextBox);
            this.Sentences.Controls.Add(this.SenNumWordsTextBox);
            this.Sentences.Controls.Add(this.SentenceTextBox);
            this.Sentences.Controls.Add(this.SentenceUpDown);
            this.Sentences.Location = new System.Drawing.Point(4, 25);
            this.Sentences.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sentences.Name = "Sentences";
            this.Sentences.Size = new System.Drawing.Size(1000, 693);
            this.Sentences.TabIndex = 4;
            this.Sentences.Text = "Sentences";
            this.Sentences.UseVisualStyleBackColor = true;
            // 
            // PreviousButton
            // 
            this.PreviousButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PreviousButton.Location = new System.Drawing.Point(332, 485);
            this.PreviousButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(140, 50);
            this.PreviousButton.TabIndex = 8;
            this.PreviousButton.Text = "Previous";
            this.PreviousButton.UseVisualStyleBackColor = true;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // NextSentenceButton
            // 
            this.NextSentenceButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.NextSentenceButton.Location = new System.Drawing.Point(529, 485);
            this.NextSentenceButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NextSentenceButton.Name = "NextSentenceButton";
            this.NextSentenceButton.Size = new System.Drawing.Size(135, 50);
            this.NextSentenceButton.TabIndex = 7;
            this.NextSentenceButton.Text = "Next";
            this.NextSentenceButton.UseVisualStyleBackColor = true;
            this.NextSentenceButton.Click += new System.EventHandler(this.NextSentenceButton_Click);
            // 
            // AveWordLengthLabel
            // 
            this.AveWordLengthLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AveWordLengthLabel.AutoSize = true;
            this.AveWordLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AveWordLengthLabel.Location = new System.Drawing.Point(328, 386);
            this.AveWordLengthLabel.Name = "AveWordLengthLabel";
            this.AveWordLengthLabel.Size = new System.Drawing.Size(171, 20);
            this.AveWordLengthLabel.TabIndex = 6;
            this.AveWordLengthLabel.Text = "Average Word Length";
            // 
            // WordsNumLabel
            // 
            this.WordsNumLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.WordsNumLabel.AutoSize = true;
            this.WordsNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WordsNumLabel.Location = new System.Drawing.Point(332, 334);
            this.WordsNumLabel.Name = "WordsNumLabel";
            this.WordsNumLabel.Size = new System.Drawing.Size(140, 24);
            this.WordsNumLabel.TabIndex = 5;
            this.WordsNumLabel.Text = "Number of Words";
            this.WordsNumLabel.UseCompatibleTextRendering = true;
            // 
            // SenAveWordsTextBox
            // 
            this.SenAveWordsTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SenAveWordsTextBox.Location = new System.Drawing.Point(544, 386);
            this.SenAveWordsTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SenAveWordsTextBox.Name = "SenAveWordsTextBox";
            this.SenAveWordsTextBox.Size = new System.Drawing.Size(100, 22);
            this.SenAveWordsTextBox.TabIndex = 3;
            // 
            // SenNumWordsTextBox
            // 
            this.SenNumWordsTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SenNumWordsTextBox.Location = new System.Drawing.Point(544, 335);
            this.SenNumWordsTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SenNumWordsTextBox.Name = "SenNumWordsTextBox";
            this.SenNumWordsTextBox.Size = new System.Drawing.Size(100, 22);
            this.SenNumWordsTextBox.TabIndex = 2;
            // 
            // SentenceTextBox
            // 
            this.SentenceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SentenceTextBox.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SentenceTextBox.Location = new System.Drawing.Point(3, 68);
            this.SentenceTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SentenceTextBox.Multiline = true;
            this.SentenceTextBox.Name = "SentenceTextBox";
            this.SentenceTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SentenceTextBox.Size = new System.Drawing.Size(937, 229);
            this.SentenceTextBox.TabIndex = 1;
            // 
            // SentenceUpDown
            // 
            this.SentenceUpDown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SentenceUpDown.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SentenceUpDown.Location = new System.Drawing.Point(433, 33);
            this.SentenceUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SentenceUpDown.Name = "SentenceUpDown";
            this.SentenceUpDown.Size = new System.Drawing.Size(67, 29);
            this.SentenceUpDown.TabIndex = 0;
            this.SentenceUpDown.ValueChanged += new System.EventHandler(this.SentenceUpDown_ValueChanged);
            // 
            // Paragraphs
            // 
            this.Paragraphs.Controls.Add(this.PrevParagraphButton);
            this.Paragraphs.Controls.Add(this.NextParagraphButton);
            this.Paragraphs.Controls.Add(this.ParaAveWordsLabel);
            this.Paragraphs.Controls.Add(this.ParaWordsNumLabel);
            this.Paragraphs.Controls.Add(this.ParaSenNumLabel);
            this.Paragraphs.Controls.Add(this.ParaAveWordsTextBox);
            this.Paragraphs.Controls.Add(this.ParaWordsNumTextBox);
            this.Paragraphs.Controls.Add(this.ParaSenNumTextBox);
            this.Paragraphs.Controls.Add(this.ParagraphTextBox);
            this.Paragraphs.Controls.Add(this.ParagraphUpDown);
            this.Paragraphs.Location = new System.Drawing.Point(4, 25);
            this.Paragraphs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Paragraphs.Name = "Paragraphs";
            this.Paragraphs.Size = new System.Drawing.Size(1000, 693);
            this.Paragraphs.TabIndex = 5;
            this.Paragraphs.Text = "Paragraphs";
            this.Paragraphs.UseVisualStyleBackColor = true;
            // 
            // PrevParagraphButton
            // 
            this.PrevParagraphButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PrevParagraphButton.Location = new System.Drawing.Point(333, 567);
            this.PrevParagraphButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PrevParagraphButton.Name = "PrevParagraphButton";
            this.PrevParagraphButton.Size = new System.Drawing.Size(109, 52);
            this.PrevParagraphButton.TabIndex = 9;
            this.PrevParagraphButton.Text = "Previous";
            this.PrevParagraphButton.UseVisualStyleBackColor = true;
            this.PrevParagraphButton.Click += new System.EventHandler(this.PrevParagraphButton_Click);
            // 
            // NextParagraphButton
            // 
            this.NextParagraphButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.NextParagraphButton.Location = new System.Drawing.Point(565, 567);
            this.NextParagraphButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NextParagraphButton.Name = "NextParagraphButton";
            this.NextParagraphButton.Size = new System.Drawing.Size(100, 52);
            this.NextParagraphButton.TabIndex = 8;
            this.NextParagraphButton.Text = "Next";
            this.NextParagraphButton.UseVisualStyleBackColor = true;
            this.NextParagraphButton.Click += new System.EventHandler(this.NextParagraphButton_Click);
            // 
            // ParaAveWordsLabel
            // 
            this.ParaAveWordsLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ParaAveWordsLabel.AutoSize = true;
            this.ParaAveWordsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParaAveWordsLabel.Location = new System.Drawing.Point(339, 507);
            this.ParaAveWordsLabel.Name = "ParaAveWordsLabel";
            this.ParaAveWordsLabel.Size = new System.Drawing.Size(124, 20);
            this.ParaAveWordsLabel.TabIndex = 7;
            this.ParaAveWordsLabel.Text = "Average Words";
            // 
            // ParaWordsNumLabel
            // 
            this.ParaWordsNumLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ParaWordsNumLabel.AutoSize = true;
            this.ParaWordsNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParaWordsNumLabel.Location = new System.Drawing.Point(339, 453);
            this.ParaWordsNumLabel.Name = "ParaWordsNumLabel";
            this.ParaWordsNumLabel.Size = new System.Drawing.Size(141, 20);
            this.ParaWordsNumLabel.TabIndex = 6;
            this.ParaWordsNumLabel.Text = "Number of Words";
            // 
            // ParaSenNumLabel
            // 
            this.ParaSenNumLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ParaSenNumLabel.AutoSize = true;
            this.ParaSenNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParaSenNumLabel.Location = new System.Drawing.Point(339, 393);
            this.ParaSenNumLabel.Name = "ParaSenNumLabel";
            this.ParaSenNumLabel.Size = new System.Drawing.Size(171, 20);
            this.ParaSenNumLabel.TabIndex = 5;
            this.ParaSenNumLabel.Text = "Number of Sentences";
            // 
            // ParaAveWordsTextBox
            // 
            this.ParaAveWordsTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ParaAveWordsTextBox.Location = new System.Drawing.Point(565, 507);
            this.ParaAveWordsTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ParaAveWordsTextBox.Name = "ParaAveWordsTextBox";
            this.ParaAveWordsTextBox.Size = new System.Drawing.Size(100, 22);
            this.ParaAveWordsTextBox.TabIndex = 4;
            // 
            // ParaWordsNumTextBox
            // 
            this.ParaWordsNumTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ParaWordsNumTextBox.Location = new System.Drawing.Point(565, 450);
            this.ParaWordsNumTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ParaWordsNumTextBox.Name = "ParaWordsNumTextBox";
            this.ParaWordsNumTextBox.Size = new System.Drawing.Size(100, 22);
            this.ParaWordsNumTextBox.TabIndex = 3;
            // 
            // ParaSenNumTextBox
            // 
            this.ParaSenNumTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ParaSenNumTextBox.Location = new System.Drawing.Point(565, 391);
            this.ParaSenNumTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ParaSenNumTextBox.Name = "ParaSenNumTextBox";
            this.ParaSenNumTextBox.Size = new System.Drawing.Size(100, 22);
            this.ParaSenNumTextBox.TabIndex = 2;
            // 
            // ParagraphTextBox
            // 
            this.ParagraphTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ParagraphTextBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParagraphTextBox.Location = new System.Drawing.Point(8, 85);
            this.ParagraphTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ParagraphTextBox.Multiline = true;
            this.ParagraphTextBox.Name = "ParagraphTextBox";
            this.ParagraphTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ParagraphTextBox.Size = new System.Drawing.Size(929, 221);
            this.ParagraphTextBox.TabIndex = 1;
            // 
            // ParagraphUpDown
            // 
            this.ParagraphUpDown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ParagraphUpDown.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParagraphUpDown.Location = new System.Drawing.Point(463, 34);
            this.ParagraphUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ParagraphUpDown.Name = "ParagraphUpDown";
            this.ParagraphUpDown.Size = new System.Drawing.Size(45, 31);
            this.ParagraphUpDown.TabIndex = 0;
            this.ParagraphUpDown.ValueChanged += new System.EventHandler(this.ParagraphUpDown_ValueChanged);
            // 
            // TextStatusStrip
            // 
            this.TextStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TextStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileStatusLabel,
            this.TokensStatusLabel,
            this.DistinctWordsStatusLabel,
            this.SenStatusLabel,
            this.ParaStripStatusLabel});
            this.TextStatusStrip.Location = new System.Drawing.Point(0, 758);
            this.TextStatusStrip.Name = "TextStatusStrip";
            this.TextStatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.TextStatusStrip.Size = new System.Drawing.Size(1008, 25);
            this.TextStatusStrip.TabIndex = 3;
            this.TextStatusStrip.Text = "Te";
            // 
            // FileStatusLabel
            // 
            this.FileStatusLabel.Name = "FileStatusLabel";
            this.FileStatusLabel.Size = new System.Drawing.Size(35, 20);
            this.FileStatusLabel.Text = "File:";
            this.FileStatusLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // TokensStatusLabel
            // 
            this.TokensStatusLabel.Name = "TokensStatusLabel";
            this.TokensStatusLabel.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.TokensStatusLabel.Size = new System.Drawing.Size(61, 20);
            this.TokensStatusLabel.Text = " Tokens:";
            // 
            // DistinctWordsStatusLabel
            // 
            this.DistinctWordsStatusLabel.Name = "DistinctWordsStatusLabel";
            this.DistinctWordsStatusLabel.Size = new System.Drawing.Size(108, 20);
            this.DistinctWordsStatusLabel.Text = "Distinct Words:";
            // 
            // SenStatusLabel
            // 
            this.SenStatusLabel.Name = "SenStatusLabel";
            this.SenStatusLabel.Size = new System.Drawing.Size(82, 20);
            this.SenStatusLabel.Text = "Sentences: ";
            // 
            // ParaStripStatusLabel
            // 
            this.ParaStripStatusLabel.Name = "ParaStripStatusLabel";
            this.ParaStripStatusLabel.Size = new System.Drawing.Size(85, 20);
            this.ParaStripStatusLabel.Text = "Paragraphs:";
            // 
            // TextAnalysisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 783);
            this.Controls.Add(this.TextStatusStrip);
            this.Controls.Add(this.TextChoicesTabs);
            this.Controls.Add(this.TextMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.TextMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TextAnalysisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Analysis Toolkit";
            this.TextMenuStrip.ResumeLayout(false);
            this.TextMenuStrip.PerformLayout();
            this.TextChoicesTabs.ResumeLayout(false);
            this.OrignalText.ResumeLayout(false);
            this.OrignalText.PerformLayout();
            this.Tokens.ResumeLayout(false);
            this.Tokens.PerformLayout();
            this.DistinctWords.ResumeLayout(false);
            this.DistinctWords.PerformLayout();
            this.Sentences.ResumeLayout(false);
            this.Sentences.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SentenceUpDown)).EndInit();
            this.Paragraphs.ResumeLayout(false);
            this.Paragraphs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParagraphUpDown)).EndInit();
            this.TextStatusStrip.ResumeLayout(false);
            this.TextStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip TextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectTextFileToolStripMenuItem;
        private System.Windows.Forms.TabControl TextChoicesTabs;
        private System.Windows.Forms.TabPage OrignalText;
        private System.Windows.Forms.TabPage Tokens;
        private System.Windows.Forms.TabPage DistinctWords;
        private System.Windows.Forms.TabPage Sentences;
        private System.Windows.Forms.TabPage Paragraphs;
        private System.Windows.Forms.TextBox OriginalTextPrint;
        private System.Windows.Forms.ListBox TokensListBox;
        private System.Windows.Forms.ListBox DistinctWordsBox;
        private System.Windows.Forms.NumericUpDown SentenceUpDown;
        private System.Windows.Forms.TextBox SentenceTextBox;
        private System.Windows.Forms.Label WordsNumLabel;
        private System.Windows.Forms.TextBox SenAveWordsTextBox;
        private System.Windows.Forms.TextBox SenNumWordsTextBox;
        private System.Windows.Forms.Label AveWordLengthLabel;
        private System.Windows.Forms.Button NextSentenceButton;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.NumericUpDown ParagraphUpDown;
        private System.Windows.Forms.TextBox ParagraphTextBox;
        private System.Windows.Forms.Label ParaAveWordsLabel;
        private System.Windows.Forms.Label ParaWordsNumLabel;
        private System.Windows.Forms.Label ParaSenNumLabel;
        private System.Windows.Forms.TextBox ParaAveWordsTextBox;
        private System.Windows.Forms.TextBox ParaWordsNumTextBox;
        private System.Windows.Forms.TextBox ParaSenNumTextBox;
        private System.Windows.Forms.Button NextParagraphButton;
        private System.Windows.Forms.Button PrevParagraphButton;
        private System.Windows.Forms.Label OcurrencesLabel;
        private System.Windows.Forms.Label wordsLabel;
        private System.Windows.Forms.Label TokensFoundLabel;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.StatusStrip TextStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel FileStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel TokensStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel DistinctWordsStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel SenStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel ParaStripStatusLabel;
    }//end TextAnalysisForm.Designer
}//end Project2

