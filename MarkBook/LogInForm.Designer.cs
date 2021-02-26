
using System;
using System.Windows.Forms;

namespace MarkBook
{
    partial class LogInForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            this.NavBar = new System.Windows.Forms.Panel();
            this.LabelFormText = new System.Windows.Forms.Label();
            this.minimizeButton = new MarkBook.CircularFlatButton();
            this.CloseButton = new MarkBook.CircularFlatButton();
            this.ButtonBoard = new System.Windows.Forms.Panel();
            this.PictureFrame = new MarkBook.CircularFlatButton();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.NavBar.SuspendLayout();
            this.ButtonBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavBar
            // 
            this.NavBar.BackColor = System.Drawing.Color.Black;
            this.NavBar.Controls.Add(this.LabelFormText);
            this.NavBar.Controls.Add(this.minimizeButton);
            this.NavBar.Controls.Add(this.CloseButton);
            this.NavBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavBar.ForeColor = System.Drawing.Color.White;
            this.NavBar.Location = new System.Drawing.Point(0, 0);
            this.NavBar.Name = "NavBar";
            this.NavBar.Size = new System.Drawing.Size(904, 39);
            this.NavBar.TabIndex = 0;
            this.NavBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NavBar_MouseDown);
            this.NavBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NavBar_MouseMove);
            this.NavBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NavBar_MouseUp);
            // 
            // LabelFormText
            // 
            this.LabelFormText.AutoSize = true;
            this.LabelFormText.BackColor = System.Drawing.Color.Transparent;
            this.LabelFormText.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelFormText.Location = new System.Drawing.Point(0, 0);
            this.LabelFormText.Name = "LabelFormText";
            this.LabelFormText.Size = new System.Drawing.Size(183, 31);
            this.LabelFormText.TabIndex = 2;
            this.LabelFormText.Text = "Form text here ...";
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.minimizeButton.FillColor = System.Drawing.Color.Yellow;
            this.minimizeButton.Location = new System.Drawing.Point(846, 9);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(20, 20);
            this.minimizeButton.TabIndex = 1;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.FillColor = System.Drawing.Color.Red;
            this.CloseButton.Location = new System.Drawing.Point(872, 9);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(20, 20);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ButtonBoard
            // 
            this.ButtonBoard.BackColor = System.Drawing.Color.Black;
            this.ButtonBoard.Controls.Add(this.PictureFrame);
            this.ButtonBoard.Controls.Add(this.buttonLogIn);
            this.ButtonBoard.Controls.Add(this.textBoxPassword);
            this.ButtonBoard.Controls.Add(this.textBoxUsername);
            this.ButtonBoard.Location = new System.Drawing.Point(358, 99);
            this.ButtonBoard.Name = "ButtonBoard";
            this.ButtonBoard.Size = new System.Drawing.Size(491, 412);
            this.ButtonBoard.TabIndex = 1;
            // 
            // PictureFrame
            // 
            this.PictureFrame.BackColor = System.Drawing.Color.Transparent;
            this.PictureFrame.FillColor = System.Drawing.Color.Snow;
            this.PictureFrame.Location = new System.Drawing.Point(166, 28);
            this.PictureFrame.Name = "PictureFrame";
            this.PictureFrame.Size = new System.Drawing.Size(159, 164);
            this.PictureFrame.TabIndex = 2;
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogIn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonLogIn.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLogIn.ForeColor = System.Drawing.Color.Black;
            this.buttonLogIn.Location = new System.Drawing.Point(19, 333);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(450, 55);
            this.buttonLogIn.TabIndex = 1;
            this.buttonLogIn.Text = "Log in";
            this.buttonLogIn.UseVisualStyleBackColor = false;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPassword.Location = new System.Drawing.Point(19, 270);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(450, 47);
            this.textBoxPassword.TabIndex = 0;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUsername.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxUsername.Location = new System.Drawing.Point(19, 207);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(450, 47);
            this.textBoxUsername.TabIndex = 0;
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(904, 581);
            this.Controls.Add(this.ButtonBoard);
            this.Controls.Add(this.NavBar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogInForm";
            this.Text = "MarkBook - Log in";
            this.Load += new System.EventHandler(this.LogInForm_Load);
            this.NavBar.ResumeLayout(false);
            this.NavBar.PerformLayout();
            this.ButtonBoard.ResumeLayout(false);
            this.ButtonBoard.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel NavBar;
        private CircularFlatButton CloseButton;
        private Label LabelFormText;
        private Panel ButtonBoard;
        private CircularFlatButton PictureFrame;
        private Button buttonLogIn;
        private TextBox textBoxPassword;
        private TextBox textBoxUsername;
        private CircularFlatButton minimizeButton;
    }
}

