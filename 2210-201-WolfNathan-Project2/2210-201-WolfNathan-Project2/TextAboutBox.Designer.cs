////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//  Project:        Project2
//  File Name:      TextAboutBox.Designer.cs
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
    /// Auto generated code for the Text About Box
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    partial class TextAboutBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextAboutBox));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.TextAboutPictureBox = new System.Windows.Forms.PictureBox();
            this.TextAboutBoxProductName = new System.Windows.Forms.Label();
            this.TextAboutlabelVersion = new System.Windows.Forms.Label();
            this.TextAboutLabelCopyright = new System.Windows.Forms.Label();
            this.TextAboutLabelCompanyName = new System.Windows.Forms.Label();
            this.TextAboutDescription = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextAboutPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.tableLayoutPanel.Controls.Add(this.TextAboutPictureBox, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.TextAboutBoxProductName, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.TextAboutlabelVersion, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.TextAboutLabelCopyright, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.TextAboutLabelCompanyName, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.TextAboutDescription, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.okButton, 1, 5);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(12, 11);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 6;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(664, 443);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // TextAboutPictureBox
            // 
            this.TextAboutPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextAboutPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("TextAboutPictureBox.Image")));
            this.TextAboutPictureBox.Location = new System.Drawing.Point(4, 4);
            this.TextAboutPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.TextAboutPictureBox.Name = "TextAboutPictureBox";
            this.tableLayoutPanel.SetRowSpan(this.TextAboutPictureBox, 6);
            this.TextAboutPictureBox.Size = new System.Drawing.Size(211, 435);
            this.TextAboutPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.TextAboutPictureBox.TabIndex = 12;
            this.TextAboutPictureBox.TabStop = false;
            // 
            // TextAboutBoxProductName
            // 
            this.TextAboutBoxProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextAboutBoxProductName.Location = new System.Drawing.Point(227, 0);
            this.TextAboutBoxProductName.Margin = new System.Windows.Forms.Padding(8, 0, 4, 0);
            this.TextAboutBoxProductName.MaximumSize = new System.Drawing.Size(0, 21);
            this.TextAboutBoxProductName.Name = "TextAboutBoxProductName";
            this.TextAboutBoxProductName.Size = new System.Drawing.Size(433, 21);
            this.TextAboutBoxProductName.TabIndex = 19;
            this.TextAboutBoxProductName.Text = "Text Analysis Toolkit";
            this.TextAboutBoxProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TextAboutlabelVersion
            // 
            this.TextAboutlabelVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextAboutlabelVersion.Location = new System.Drawing.Point(227, 44);
            this.TextAboutlabelVersion.Margin = new System.Windows.Forms.Padding(8, 0, 4, 0);
            this.TextAboutlabelVersion.MaximumSize = new System.Drawing.Size(0, 21);
            this.TextAboutlabelVersion.Name = "TextAboutlabelVersion";
            this.TextAboutlabelVersion.Size = new System.Drawing.Size(433, 21);
            this.TextAboutlabelVersion.TabIndex = 0;
            this.TextAboutlabelVersion.Text = "Version 2.0";
            this.TextAboutlabelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TextAboutLabelCopyright
            // 
            this.TextAboutLabelCopyright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextAboutLabelCopyright.Location = new System.Drawing.Point(227, 88);
            this.TextAboutLabelCopyright.Margin = new System.Windows.Forms.Padding(8, 0, 4, 0);
            this.TextAboutLabelCopyright.MaximumSize = new System.Drawing.Size(0, 21);
            this.TextAboutLabelCopyright.Name = "TextAboutLabelCopyright";
            this.TextAboutLabelCopyright.Size = new System.Drawing.Size(433, 21);
            this.TextAboutLabelCopyright.TabIndex = 21;
            this.TextAboutLabelCopyright.Text = "Copyright @ Wolf Ind. 2018";
            this.TextAboutLabelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TextAboutLabelCompanyName
            // 
            this.TextAboutLabelCompanyName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextAboutLabelCompanyName.Location = new System.Drawing.Point(227, 132);
            this.TextAboutLabelCompanyName.Margin = new System.Windows.Forms.Padding(8, 0, 4, 0);
            this.TextAboutLabelCompanyName.MaximumSize = new System.Drawing.Size(0, 21);
            this.TextAboutLabelCompanyName.Name = "TextAboutLabelCompanyName";
            this.TextAboutLabelCompanyName.Size = new System.Drawing.Size(433, 21);
            this.TextAboutLabelCompanyName.TabIndex = 22;
            this.TextAboutLabelCompanyName.Text = "Wolf Inc";
            this.TextAboutLabelCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TextAboutDescription
            // 
            this.TextAboutDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextAboutDescription.Location = new System.Drawing.Point(227, 180);
            this.TextAboutDescription.Margin = new System.Windows.Forms.Padding(8, 4, 4, 4);
            this.TextAboutDescription.Multiline = true;
            this.TextAboutDescription.Name = "TextAboutDescription";
            this.TextAboutDescription.ReadOnly = true;
            this.TextAboutDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextAboutDescription.Size = new System.Drawing.Size(433, 213);
            this.TextAboutDescription.TabIndex = 23;
            this.TextAboutDescription.TabStop = false;
            this.TextAboutDescription.Text = resources.GetString("TextAboutDescription.Text");
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.okButton.Location = new System.Drawing.Point(560, 412);
            this.okButton.Margin = new System.Windows.Forms.Padding(4);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(100, 27);
            this.okButton.TabIndex = 24;
            this.okButton.Text = "&OK";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // TextAboutBox
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 465);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TextAboutBox";
            this.Padding = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TextAboutBox";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextAboutPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.PictureBox TextAboutPictureBox;
        private System.Windows.Forms.Label TextAboutBoxProductName;
        private System.Windows.Forms.Label TextAboutlabelVersion;
        private System.Windows.Forms.Label TextAboutLabelCopyright;
        private System.Windows.Forms.Label TextAboutLabelCompanyName;
        private System.Windows.Forms.TextBox TextAboutDescription;
        private System.Windows.Forms.Button okButton;
    }
}
