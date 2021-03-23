﻿
using Interface.CustomControls;

namespace Interface
{
    partial class StudentView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentView));
            this.NavBar = new System.Windows.Forms.Panel();
            this.closeButton = new Interface.CustomControls.CircularFlatButton();
            this.labelFormText = new System.Windows.Forms.Label();
            this.subjectsHeader = new Interface.CustomControls.TableCell();
            this.marksHeader = new Interface.CustomControls.TableCell();
            this.minimizeButton = new Interface.CustomControls.CircularFlatButton();
            this.NavBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavBar
            // 
            this.NavBar.BackColor = System.Drawing.Color.Black;
            this.NavBar.Controls.Add(this.minimizeButton);
            this.NavBar.Controls.Add(this.closeButton);
            this.NavBar.Controls.Add(this.labelFormText);
            this.NavBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavBar.Location = new System.Drawing.Point(0, 0);
            this.NavBar.Name = "NavBar";
            this.NavBar.Size = new System.Drawing.Size(580, 40);
            this.NavBar.TabIndex = 0;
            this.NavBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NavBar_MouseDown);
            this.NavBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NavBar_MouseMove);
            this.NavBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NavBar_MouseUp);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.DisplayText = "";
            this.closeButton.FillColor = System.Drawing.Color.Red;
            this.closeButton.Location = new System.Drawing.Point(548, 9);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(20, 20);
            this.closeButton.TabIndex = 2;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // labelFormText
            // 
            this.labelFormText.AutoSize = true;
            this.labelFormText.BackColor = System.Drawing.Color.Transparent;
            this.labelFormText.Font = new System.Drawing.Font("Script MT Bold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelFormText.ForeColor = System.Drawing.Color.White;
            this.labelFormText.Location = new System.Drawing.Point(0, 3);
            this.labelFormText.Name = "labelFormText";
            this.labelFormText.Size = new System.Drawing.Size(422, 28);
            this.labelFormText.TabIndex = 1;
            this.labelFormText.Text = "MarkBook(Student) - {Name} {LastName}";
            // 
            // subjectsHeader
            // 
            this.subjectsHeader.BackColor = System.Drawing.Color.Black;
            this.subjectsHeader.BorderColor = System.Drawing.Color.Black;
            this.subjectsHeader.BorderThickness = 3;
            this.subjectsHeader.DisplayText = "Subjects";
            this.subjectsHeader.FillColor = System.Drawing.Color.Transparent;
            this.subjectsHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subjectsHeader.ForeColor = System.Drawing.Color.White;
            this.subjectsHeader.HasBorder = false;
            this.subjectsHeader.Location = new System.Drawing.Point(40, 70);
            this.subjectsHeader.Name = "subjectsHeader";
            this.subjectsHeader.ShowText = true;
            this.subjectsHeader.Size = new System.Drawing.Size(230, 50);
            this.subjectsHeader.TabIndex = 1;
            this.subjectsHeader.TextFormat = Interface.CustomControls.TextFormats.Center;
            // 
            // marksHeader
            // 
            this.marksHeader.BackColor = System.Drawing.Color.Black;
            this.marksHeader.BorderColor = System.Drawing.Color.Black;
            this.marksHeader.BorderThickness = 3;
            this.marksHeader.DisplayText = "Marks";
            this.marksHeader.FillColor = System.Drawing.Color.Transparent;
            this.marksHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.marksHeader.ForeColor = System.Drawing.Color.White;
            this.marksHeader.HasBorder = false;
            this.marksHeader.Location = new System.Drawing.Point(270, 70);
            this.marksHeader.Name = "marksHeader";
            this.marksHeader.ShowText = true;
            this.marksHeader.Size = new System.Drawing.Size(270, 50);
            this.marksHeader.TabIndex = 1;
            this.marksHeader.TextFormat = Interface.CustomControls.TextFormats.Center;
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.minimizeButton.DisplayText = "";
            this.minimizeButton.FillColor = System.Drawing.Color.Yellow;
            this.minimizeButton.Location = new System.Drawing.Point(520, 9);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(20, 20);
            this.minimizeButton.TabIndex = 3;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // StudentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(580, 879);
            this.Controls.Add(this.marksHeader);
            this.Controls.Add(this.subjectsHeader);
            this.Controls.Add(this.NavBar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentView";
            this.RightToLeftLayout = true;
            this.Load += new System.EventHandler(this.StudentView_Load);
            this.NavBar.ResumeLayout(false);
            this.NavBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel NavBar;
        private System.Windows.Forms.Label labelFormText;
        private CircularFlatButton closeButton;
        private TableCell subjectsHeader;
        private TableCell marksHeader;
        private CircularFlatButton minimizeButton;
    }
}