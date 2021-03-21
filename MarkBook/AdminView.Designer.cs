
using MarkBook;
using System.Windows.Forms;

namespace Interface
{
    partial class AdminView
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
            this.NavBar = new System.Windows.Forms.Panel();
            this.LabelFormText = new System.Windows.Forms.Label();
            this.NormalizeMaximizeForm = new MarkBook.CircularFlatButton();
            this.minimizeButton = new MarkBook.CircularFlatButton();
            this.CloseButton = new MarkBook.CircularFlatButton();
            this.NavBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavBar
            // 
            this.NavBar.BackColor = System.Drawing.Color.Black;
            this.NavBar.Controls.Add(this.LabelFormText);
            this.NavBar.Controls.Add(this.NormalizeMaximizeForm);
            this.NavBar.Controls.Add(this.minimizeButton);
            this.NavBar.Controls.Add(this.CloseButton);
            this.NavBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavBar.ForeColor = System.Drawing.Color.White;
            this.NavBar.Location = new System.Drawing.Point(0, 0);
            this.NavBar.Name = "NavBar";
            this.NavBar.Size = new System.Drawing.Size(1258, 40);
            this.NavBar.TabIndex = 0;
            this.NavBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NavBar_MouseDown);
            this.NavBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NavBar_MouseMove);
            this.NavBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NavBar_MouseUp);
            // 
            // LabelFormText
            // 
            this.LabelFormText.AutoSize = true;
            this.LabelFormText.BackColor = System.Drawing.Color.Transparent;
            this.LabelFormText.Font = new System.Drawing.Font("Script MT Bold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.LabelFormText.Location = new System.Drawing.Point(0, 3);
            this.LabelFormText.Name = "LabelFormText";
            this.LabelFormText.Size = new System.Drawing.Size(416, 28);
            this.LabelFormText.TabIndex = 2;
            this.LabelFormText.Text = "MarkBook(Admin) - {Name} {LastName}";
            // 
            // NormalizeMaximizeForm
            // 
            this.NormalizeMaximizeForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NormalizeMaximizeForm.BackColor = System.Drawing.Color.Transparent;
            this.NormalizeMaximizeForm.DisplayText = "";
            this.NormalizeMaximizeForm.FillColor = System.Drawing.Color.Lime;
            this.NormalizeMaximizeForm.Location = new System.Drawing.Point(1200, 9);
            this.NormalizeMaximizeForm.Name = "NormalizeMaximizeForm";
            this.NormalizeMaximizeForm.Size = new System.Drawing.Size(20, 20);
            this.NormalizeMaximizeForm.TabIndex = 1;
            this.NormalizeMaximizeForm.Click += new System.EventHandler(this.NormalizeMaximizeForm_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.minimizeButton.DisplayText = "";
            this.minimizeButton.FillColor = System.Drawing.Color.Yellow;
            this.minimizeButton.Location = new System.Drawing.Point(1174, 9);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(20, 20);
            this.minimizeButton.TabIndex = 1;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.DisplayText = "";
            this.CloseButton.FillColor = System.Drawing.Color.Red;
            this.CloseButton.Location = new System.Drawing.Point(1226, 9);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(20, 20);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // AdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1258, 598);
            this.Controls.Add(this.NavBar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminView";
            this.Load += new System.EventHandler(this.AdminView_Load);
            this.NavBar.ResumeLayout(false);
            this.NavBar.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.Panel NavBar;
        private CircularFlatButton CloseButton;
        private Label LabelFormText;
        private CircularFlatButton minimizeButton;
        private CircularFlatButton NormalizeMaximizeForm;
    }
}