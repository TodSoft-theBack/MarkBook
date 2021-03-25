
using System;
using System.Windows.Forms;
using Interface.CustomControls;

namespace Interface
{
    partial class LogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            this.NavBar = new System.Windows.Forms.Panel();
            this.normalizeMaximizeForm = new Interface.CustomControls.CircularFlatButton();
            this.minimizeButton = new Interface.CustomControls.CircularFlatButton();
            this.closeButton = new Interface.CustomControls.CircularFlatButton();
            this.LabelFormText = new System.Windows.Forms.Label();
            this.ButtonBoard = new System.Windows.Forms.Panel();
            this.PictureFrame = new Interface.CustomControls.CircularFlatButton();
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
            this.NavBar.Controls.Add(this.normalizeMaximizeForm);
            this.NavBar.Controls.Add(this.minimizeButton);
            this.NavBar.Controls.Add(this.closeButton);
            this.NavBar.Controls.Add(this.LabelFormText);
            this.NavBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavBar.ForeColor = System.Drawing.Color.White;
            this.NavBar.Location = new System.Drawing.Point(0, 0);
            this.NavBar.Name = "NavBar";
            this.NavBar.Size = new System.Drawing.Size(904, 40);
            this.NavBar.TabIndex = 0;
            this.NavBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NavBar_MouseDown);
            this.NavBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NavBar_MouseMove);
            this.NavBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NavBar_MouseUp);
            // 
            // normalizeMaximizeForm
            // 
            this.normalizeMaximizeForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.normalizeMaximizeForm.BackColor = System.Drawing.Color.Transparent;
            this.normalizeMaximizeForm.DisplayText = "";
            this.normalizeMaximizeForm.FillColor = System.Drawing.Color.Lime;
            this.normalizeMaximizeForm.Location = new System.Drawing.Point(846, 9);
            this.normalizeMaximizeForm.Name = "normalizeMaximizeForm";
            this.normalizeMaximizeForm.Size = new System.Drawing.Size(20, 20);
            this.normalizeMaximizeForm.TabIndex = 1;
            this.normalizeMaximizeForm.Click += new System.EventHandler(this.NormalizeMaximizeForm_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.minimizeButton.DisplayText = "";
            this.minimizeButton.FillColor = System.Drawing.Color.Yellow;
            this.minimizeButton.Location = new System.Drawing.Point(820, 9);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(20, 20);
            this.minimizeButton.TabIndex = 1;
            this.minimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.DisplayText = "";
            this.closeButton.FillColor = System.Drawing.Color.Red;
            this.closeButton.Location = new System.Drawing.Point(872, 9);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(20, 20);
            this.closeButton.TabIndex = 1;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // LabelFormText
            // 
            this.LabelFormText.AutoSize = true;
            this.LabelFormText.BackColor = System.Drawing.Color.Transparent;
            this.LabelFormText.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.LabelFormText.Location = new System.Drawing.Point(0, 3);
            this.LabelFormText.Name = "LabelFormText";
            this.LabelFormText.Size = new System.Drawing.Size(208, 35);
            this.LabelFormText.TabIndex = 2;
            this.LabelFormText.Text = "MarkBook - Log in";
            // 
            // ButtonBoard
            // 
            this.ButtonBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.PictureFrame.DisplayText = "User";
            this.PictureFrame.FillColor = System.Drawing.Color.Snow;
            this.PictureFrame.Font = new System.Drawing.Font("Script MT Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PictureFrame.Location = new System.Drawing.Point(164, 29);
            this.PictureFrame.Name = "PictureFrame";
            this.PictureFrame.Size = new System.Drawing.Size(160, 160);
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
            this.buttonLogIn.TabIndex = 0;
            this.buttonLogIn.Text = "Log in";
            this.buttonLogIn.UseVisualStyleBackColor = false;
            this.buttonLogIn.Click += new System.EventHandler(this.ButtonLogIn_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPassword.ForeColor = System.Drawing.Color.Gray;
            this.textBoxPassword.Location = new System.Drawing.Point(19, 270);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.PlaceholderText = "Password here ...";
            this.textBoxPassword.Size = new System.Drawing.Size(450, 47);
            this.textBoxPassword.TabIndex = 2;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUsername.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxUsername.ForeColor = System.Drawing.Color.Gray;
            this.textBoxUsername.Location = new System.Drawing.Point(19, 207);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.PlaceholderText = "Username here ...";
            this.textBoxUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxUsername.Size = new System.Drawing.Size(450, 47);
            this.textBoxUsername.TabIndex = 1;
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
            this.Load += new System.EventHandler(this.LogInForm_Load);
            this.NavBar.ResumeLayout(false);
            this.NavBar.PerformLayout();
            this.ButtonBoard.ResumeLayout(false);
            this.ButtonBoard.PerformLayout();
            this.ResumeLayout(false);

        }

        

        #endregion
        private System.Windows.Forms.Panel NavBar;
        private CustomControls.CircularFlatButton closeButton;
        private Label LabelFormText;
        private Panel ButtonBoard;
        private CustomControls.CircularFlatButton PictureFrame;
        private Button buttonLogIn;
        private TextBox textBoxPassword;
        private TextBox textBoxUsername;
        private CustomControls.CircularFlatButton minimizeButton;
        private CustomControls.CircularFlatButton normalizeMaximizeForm;
    }
}