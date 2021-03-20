
namespace MarkBook
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
            this.closeButton = new MarkBook.CircularFlatButton();
            this.labelFormText = new System.Windows.Forms.Label();
            this.studentsHeader = new MarkBook.TableCell();
            this.marksHeader = new MarkBook.TableCell();
            this.buttonAddMark = new MarkBook.CircularFlatButton();
            this.tableCellGrade = new MarkBook.TableCell();
            this.tableCellSubject = new MarkBook.TableCell();
            this.tableCellSubjectName = new MarkBook.TableCell();
            this.comboBoxGrade = new System.Windows.Forms.ComboBox();
            this.markToolTipConcept = new MarkBook.MarkToolTip();
            this.circularFlatButton2 = new MarkBook.CircularFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NavBar.SuspendLayout();
            this.markToolTipConcept.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavBar
            // 
            this.NavBar.BackColor = System.Drawing.Color.Black;
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
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // labelFormText
            // 
            this.labelFormText.AutoSize = true;
            this.labelFormText.BackColor = System.Drawing.Color.Transparent;
            this.labelFormText.Font = new System.Drawing.Font("Script MT Bold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelFormText.ForeColor = System.Drawing.Color.White;
            this.labelFormText.Location = new System.Drawing.Point(0, 3);
            this.labelFormText.Name = "labelFormText";
            this.labelFormText.Size = new System.Drawing.Size(156, 28);
            this.labelFormText.TabIndex = 1;
            this.labelFormText.Text = "Form text here...";
            // 
            // studentsHeader
            // 
            this.studentsHeader.BackColor = System.Drawing.Color.Black;
            this.studentsHeader.BorderColor = System.Drawing.Color.Black;
            this.studentsHeader.BorderThickness = 3;
            this.studentsHeader.DisplayText = "Students";
            this.studentsHeader.FillColor = System.Drawing.Color.Transparent;
            this.studentsHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.studentsHeader.ForeColor = System.Drawing.Color.White;
            this.studentsHeader.HasBorder = false;
            this.studentsHeader.Location = new System.Drawing.Point(40, 152);
            this.studentsHeader.Name = "studentsHeader";
            this.studentsHeader.ShowText = true;
            this.studentsHeader.Size = new System.Drawing.Size(230, 50);
            this.studentsHeader.TabIndex = 1;
            this.studentsHeader.textFormat = MarkBook.TextFormats.Center;
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
            this.marksHeader.Location = new System.Drawing.Point(270, 152);
            this.marksHeader.Name = "marksHeader";
            this.marksHeader.ShowText = true;
            this.marksHeader.Size = new System.Drawing.Size(270, 50);
            this.marksHeader.TabIndex = 1;
            this.marksHeader.textFormat = MarkBook.TextFormats.Center;
            // 
            // buttonAddMark
            // 
            this.buttonAddMark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddMark.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddMark.DisplayText = "Добави oценка";
            this.buttonAddMark.FillColor = System.Drawing.Color.Lime;
            this.buttonAddMark.Location = new System.Drawing.Point(247, 718);
            this.buttonAddMark.Name = "buttonAddMark";
            this.buttonAddMark.Size = new System.Drawing.Size(132, 134);
            this.buttonAddMark.TabIndex = 2;
            this.buttonAddMark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonAddMark.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // tableCellGrade
            // 
            this.tableCellGrade.BackColor = System.Drawing.Color.Black;
            this.tableCellGrade.BorderColor = System.Drawing.Color.Black;
            this.tableCellGrade.BorderThickness = 3;
            this.tableCellGrade.DisplayText = "Grade:";
            this.tableCellGrade.FillColor = System.Drawing.Color.Transparent;
            this.tableCellGrade.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tableCellGrade.ForeColor = System.Drawing.Color.White;
            this.tableCellGrade.HasBorder = false;
            this.tableCellGrade.Location = new System.Drawing.Point(40, 106);
            this.tableCellGrade.Name = "tableCellGrade";
            this.tableCellGrade.ShowText = true;
            this.tableCellGrade.Size = new System.Drawing.Size(230, 40);
            this.tableCellGrade.TabIndex = 1;
            this.tableCellGrade.textFormat = MarkBook.TextFormats.Right;
            // 
            // tableCellSubject
            // 
            this.tableCellSubject.BackColor = System.Drawing.Color.Black;
            this.tableCellSubject.BorderColor = System.Drawing.Color.Black;
            this.tableCellSubject.BorderThickness = 3;
            this.tableCellSubject.DisplayText = "Subject:";
            this.tableCellSubject.FillColor = System.Drawing.Color.Transparent;
            this.tableCellSubject.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tableCellSubject.ForeColor = System.Drawing.Color.White;
            this.tableCellSubject.HasBorder = false;
            this.tableCellSubject.Location = new System.Drawing.Point(40, 60);
            this.tableCellSubject.Name = "tableCellSubject";
            this.tableCellSubject.ShowText = true;
            this.tableCellSubject.Size = new System.Drawing.Size(230, 40);
            this.tableCellSubject.TabIndex = 1;
            this.tableCellSubject.textFormat = MarkBook.TextFormats.Right;
            // 
            // tableCellSubjectName
            // 
            this.tableCellSubjectName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tableCellSubjectName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tableCellSubjectName.BorderThickness = 3;
            this.tableCellSubjectName.DisplayText = "<Subject name>";
            this.tableCellSubjectName.FillColor = System.Drawing.Color.Transparent;
            this.tableCellSubjectName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tableCellSubjectName.ForeColor = System.Drawing.Color.Black;
            this.tableCellSubjectName.HasBorder = false;
            this.tableCellSubjectName.Location = new System.Drawing.Point(276, 60);
            this.tableCellSubjectName.Name = "tableCellSubjectName";
            this.tableCellSubjectName.ShowText = true;
            this.tableCellSubjectName.Size = new System.Drawing.Size(264, 40);
            this.tableCellSubjectName.TabIndex = 1;
            this.tableCellSubjectName.textFormat = MarkBook.TextFormats.Left;
            // 
            // comboBoxGrade
            // 
            this.comboBoxGrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.comboBoxGrade.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxGrade.FormattingEnabled = true;
            this.comboBoxGrade.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBoxGrade.Location = new System.Drawing.Point(276, 106);
            this.comboBoxGrade.Name = "comboBoxGrade";
            this.comboBoxGrade.Size = new System.Drawing.Size(264, 39);
            this.comboBoxGrade.TabIndex = 3;
            this.comboBoxGrade.Text = "Grade";
            // 
            // markToolTipConcept
            // 
            this.markToolTipConcept.BackColor = System.Drawing.Color.Transparent;
            this.markToolTipConcept.BorderColor = System.Drawing.Color.Lime;
            this.markToolTipConcept.BorderRadius = 15;
            this.markToolTipConcept.BorderThickness = 3F;
            this.markToolTipConcept.Controls.Add(this.circularFlatButton2);
            this.markToolTipConcept.Controls.Add(this.label3);
            this.markToolTipConcept.Controls.Add(this.label2);
            this.markToolTipConcept.Controls.Add(this.label1);
            this.markToolTipConcept.CssMode = false;
            this.markToolTipConcept.DisplayText = "";
            this.markToolTipConcept.FillColor = System.Drawing.Color.Lime;
            this.markToolTipConcept.Location = new System.Drawing.Point(12, 733);
            this.markToolTipConcept.Name = "markToolTipConcept";
            this.markToolTipConcept.Size = new System.Drawing.Size(213, 134);
            this.markToolTipConcept.TabIndex = 4;
            this.markToolTipConcept.Visible = false;
            // 
            // circularFlatButton2
            // 
            this.circularFlatButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.circularFlatButton2.BackColor = System.Drawing.Color.Transparent;
            this.circularFlatButton2.DisplayText = "";
            this.circularFlatButton2.FillColor = System.Drawing.Color.Red;
            this.circularFlatButton2.Location = new System.Drawing.Point(183, 13);
            this.circularFlatButton2.Name = "circularFlatButton2";
            this.circularFlatButton2.Size = new System.Drawing.Size(20, 20);
            this.circularFlatButton2.TabIndex = 2;
            this.circularFlatButton2.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(11, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 50);
            this.label3.TabIndex = 3;
            this.label3.Text = "Контролна работа на вектори.";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(11, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "5.87";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Оценка";
            // 
            // TeacherView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(580, 879);
            this.Controls.Add(this.markToolTipConcept);
            this.Controls.Add(this.comboBoxGrade);
            this.Controls.Add(this.buttonAddMark);
            this.Controls.Add(this.tableCellSubjectName);
            this.Controls.Add(this.marksHeader);
            this.Controls.Add(this.tableCellGrade);
            this.Controls.Add(this.tableCellSubject);
            this.Controls.Add(this.studentsHeader);
            this.Controls.Add(this.NavBar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TeacherView";
            this.RightToLeftLayout = true;
            this.Text = "MarkBook - <Name> <FamilyName>";
            this.Load += new System.EventHandler(this.TeacherView_Load);
            this.TextChanged += new System.EventHandler(this.TeacherView_TextChanged);
            this.NavBar.ResumeLayout(false);
            this.NavBar.PerformLayout();
            this.markToolTipConcept.ResumeLayout(false);
            this.markToolTipConcept.PerformLayout();
            this.ResumeLayout(false);

        }


        private System.Windows.Forms.Panel NavBar;
        private System.Windows.Forms.Label labelFormText;
        private CircularFlatButton closeButton;
        private TableCell studentsHeader;
        private TableCell marksHeader;
        #endregion
        private CircularFlatButton buttonAddMark;
        private TableCell tableCellGrade;
        private TableCell tableCellSubject;
        private TableCell tableCellSubjectName;
        private System.Windows.Forms.ComboBox comboBoxGrade;
        private MarkToolTip markToolTipConcept;
        private CircularFlatButton circularFlatButton2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CircularFlatButton circularFlatButton1;
    }
}