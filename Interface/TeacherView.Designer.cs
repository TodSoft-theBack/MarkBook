
using Interface.CustomControls;
using System;

namespace Interface
{
    partial class TeacherView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherView));
            this.NavBar = new System.Windows.Forms.Panel();
            this.minimizeButton = new Interface.CustomControls.CircularFlatButton();
            this.closeButton = new Interface.CustomControls.CircularFlatButton();
            this.labelFormText = new System.Windows.Forms.Label();
            this.studentsHeader = new Interface.CustomControls.TableCell();
            this.marksHeader = new Interface.CustomControls.TableCell();
            this.buttonAddMark = new Interface.CustomControls.CircularFlatButton();
            this.tableCellSubject = new Interface.CustomControls.TableCell();
            this.comboBoxGrade = new System.Windows.Forms.ComboBox();
            this.tableContainer = new System.Windows.Forms.Label();
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
            this.labelFormText.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelFormText.ForeColor = System.Drawing.Color.White;
            this.labelFormText.Location = new System.Drawing.Point(0, 3);
            this.labelFormText.Name = "labelFormText";
            this.labelFormText.Size = new System.Drawing.Size(436, 35);
            this.labelFormText.TabIndex = 1;
            this.labelFormText.Text = "MarkBook(Teacher) - {Name} {LastName}";
            // 
            // studentsHeader
            // 
            this.studentsHeader.BackColor = System.Drawing.Color.Transparent;
            this.studentsHeader.BorderColor = System.Drawing.Color.Black;
            this.studentsHeader.BorderThickness = 3F;
            this.studentsHeader.DisplayText = "Students";
            this.studentsHeader.FillColor = System.Drawing.Color.Black;
            this.studentsHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.studentsHeader.ForeColor = System.Drawing.Color.White;
            this.studentsHeader.HasBorder = false;
            this.studentsHeader.Location = new System.Drawing.Point(40, 110);
            this.studentsHeader.Name = "studentsHeader";
            this.studentsHeader.ShowText = true;
            this.studentsHeader.Size = new System.Drawing.Size(230, 50);
            this.studentsHeader.TabIndex = 1;
            this.studentsHeader.TextFormat = Interface.CustomControls.TextFormats.Center;
            // 
            // marksHeader
            // 
            this.marksHeader.BackColor = System.Drawing.Color.Transparent;
            this.marksHeader.BorderColor = System.Drawing.Color.Black;
            this.marksHeader.BorderThickness = 3F;
            this.marksHeader.DisplayText = "Marks";
            this.marksHeader.FillColor = System.Drawing.Color.Black;
            this.marksHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.marksHeader.ForeColor = System.Drawing.Color.White;
            this.marksHeader.HasBorder = false;
            this.marksHeader.Location = new System.Drawing.Point(270, 110);
            this.marksHeader.Name = "marksHeader";
            this.marksHeader.ShowText = true;
            this.marksHeader.Size = new System.Drawing.Size(270, 50);
            this.marksHeader.TabIndex = 1;
            this.marksHeader.TextFormat = Interface.CustomControls.TextFormats.Center;
            // 
            // buttonAddMark
            // 
            this.buttonAddMark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddMark.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddMark.DisplayText = "";
            this.buttonAddMark.Enabled = false;
            this.buttonAddMark.FillColor = System.Drawing.Color.Lime;
            this.buttonAddMark.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddMark.Location = new System.Drawing.Point(246, 718);
            this.buttonAddMark.Name = "buttonAddMark";
            this.buttonAddMark.Size = new System.Drawing.Size(135, 134);
            this.buttonAddMark.TabIndex = 2;
            this.buttonAddMark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonAddMark.Click += new System.EventHandler(this.buttonAddMark_Click);
            // 
            // tableCellSubject
            // 
            this.tableCellSubject.BackColor = System.Drawing.Color.Transparent;
            this.tableCellSubject.BorderColor = System.Drawing.Color.Black;
            this.tableCellSubject.BorderThickness = 3F;
            this.tableCellSubject.DisplayText = "Subject:";
            this.tableCellSubject.FillColor = System.Drawing.Color.Black;
            this.tableCellSubject.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tableCellSubject.ForeColor = System.Drawing.Color.White;
            this.tableCellSubject.HasBorder = false;
            this.tableCellSubject.Location = new System.Drawing.Point(40, 61);
            this.tableCellSubject.Name = "tableCellSubject";
            this.tableCellSubject.ShowText = true;
            this.tableCellSubject.Size = new System.Drawing.Size(187, 39);
            this.tableCellSubject.TabIndex = 1;
            this.tableCellSubject.TextFormat = Interface.CustomControls.TextFormats.RightMid;
            // 
            // comboBoxGrade
            // 
            this.comboBoxGrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.comboBoxGrade.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxGrade.FormattingEnabled = true;
            this.comboBoxGrade.Location = new System.Drawing.Point(233, 61);
            this.comboBoxGrade.Name = "comboBoxGrade";
            this.comboBoxGrade.Size = new System.Drawing.Size(307, 39);
            this.comboBoxGrade.TabIndex = 3;
            this.comboBoxGrade.Text = "Grade";
            this.comboBoxGrade.SelectedIndexChanged += new System.EventHandler(this.comboBoxGrade_SelectedIndexChanged);
            // 
            // tableContainer
            // 
            this.tableContainer.BackColor = System.Drawing.Color.Transparent;
            this.tableContainer.Location = new System.Drawing.Point(40, 160);
            this.tableContainer.Name = "tableContainer";
            this.tableContainer.Size = new System.Drawing.Size(500, 558);
            this.tableContainer.TabIndex = 4;
            // 
            // TeacherView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.Background")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(580, 879);
            this.Controls.Add(this.tableContainer);
            this.Controls.Add(this.tableCellSubject);
            this.Controls.Add(this.comboBoxGrade);
            this.Controls.Add(this.buttonAddMark);
            this.Controls.Add(this.marksHeader);
            this.Controls.Add(this.studentsHeader);
            this.Controls.Add(this.NavBar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TeacherView";
            this.RightToLeftLayout = true;
            this.Load += new System.EventHandler(this.TeacherView_Load);
            this.NavBar.ResumeLayout(false);
            this.NavBar.PerformLayout();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Panel NavBar;
        private System.Windows.Forms.Label labelFormText;
        private CircularFlatButton closeButton;
        private TableCell studentsHeader;
        private TableCell marksHeader;
        #endregion
        private CircularFlatButton buttonAddMark;
        private TableCell tableCellSubject;
        private System.Windows.Forms.ComboBox comboBoxGrade;
        private CircularFlatButton minimizeButton;
        private System.Windows.Forms.Label tableContainer;
    }
}