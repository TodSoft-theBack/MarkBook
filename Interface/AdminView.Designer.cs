
using Interface.CustomControls;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminView));
            this.NavBar = new System.Windows.Forms.Panel();
            this.labelFormText = new System.Windows.Forms.Label();
            this.NormalizeMaximizeForm = new Interface.CustomControls.CircularFlatButton();
            this.minimizeButton = new Interface.CustomControls.CircularFlatButton();
            this.CloseButton = new Interface.CustomControls.CircularFlatButton();
            this.listBoxSubjects = new System.Windows.Forms.ListBox();
            this.listBoxStudents = new System.Windows.Forms.ListBox();
            this.buttonAddGrade = new System.Windows.Forms.Label();
            this.buttonAddSubject = new System.Windows.Forms.Label();
            this.buttonAddStudent = new System.Windows.Forms.Label();
            this.listBoxTeachers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxGrade = new System.Windows.Forms.ComboBox();
            this.NavBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavBar
            // 
            this.NavBar.BackColor = System.Drawing.Color.Black;
            this.NavBar.Controls.Add(this.labelFormText);
            this.NavBar.Controls.Add(this.NormalizeMaximizeForm);
            this.NavBar.Controls.Add(this.minimizeButton);
            this.NavBar.Controls.Add(this.CloseButton);
            this.NavBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavBar.ForeColor = System.Drawing.Color.White;
            this.NavBar.Location = new System.Drawing.Point(0, 0);
            this.NavBar.Name = "NavBar";
            this.NavBar.Size = new System.Drawing.Size(1002, 40);
            this.NavBar.TabIndex = 0;
            this.NavBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NavBar_MouseDown);
            this.NavBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NavBar_MouseMove);
            this.NavBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NavBar_MouseUp);
            // 
            // labelFormText
            // 
            this.labelFormText.AutoSize = true;
            this.labelFormText.BackColor = System.Drawing.Color.Transparent;
            this.labelFormText.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelFormText.Location = new System.Drawing.Point(0, 3);
            this.labelFormText.Name = "labelFormText";
            this.labelFormText.Size = new System.Drawing.Size(427, 35);
            this.labelFormText.TabIndex = 2;
            this.labelFormText.Text = "MarkBook(Admin) - {Name} {LastName}";
            // 
            // NormalizeMaximizeForm
            // 
            this.NormalizeMaximizeForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NormalizeMaximizeForm.BackColor = System.Drawing.Color.Transparent;
            this.NormalizeMaximizeForm.DisplayText = "";
            this.NormalizeMaximizeForm.FillColor = System.Drawing.Color.Lime;
            this.NormalizeMaximizeForm.Location = new System.Drawing.Point(944, 9);
            this.NormalizeMaximizeForm.Name = "NormalizeMaximizeForm";
            this.NormalizeMaximizeForm.Padding = new System.Windows.Forms.Padding(1);
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
            this.minimizeButton.Location = new System.Drawing.Point(918, 9);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Padding = new System.Windows.Forms.Padding(1);
            this.minimizeButton.Size = new System.Drawing.Size(20, 20);
            this.minimizeButton.TabIndex = 1;
            this.minimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.DisplayText = "";
            this.CloseButton.FillColor = System.Drawing.Color.Red;
            this.CloseButton.Location = new System.Drawing.Point(970, 9);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Padding = new System.Windows.Forms.Padding(1);
            this.CloseButton.Size = new System.Drawing.Size(20, 20);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // listBoxSubjects
            // 
            this.listBoxSubjects.BackColor = System.Drawing.Color.Black;
            this.listBoxSubjects.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxSubjects.ForeColor = System.Drawing.Color.White;
            this.listBoxSubjects.FormattingEnabled = true;
            this.listBoxSubjects.ItemHeight = 37;
            this.listBoxSubjects.Items.AddRange(new object[] {
            "<select a grade first>"});
            this.listBoxSubjects.Location = new System.Drawing.Point(45, 129);
            this.listBoxSubjects.Name = "listBoxSubjects";
            this.listBoxSubjects.Size = new System.Drawing.Size(291, 374);
            this.listBoxSubjects.TabIndex = 1;
            // 
            // listBoxStudents
            // 
            this.listBoxStudents.BackColor = System.Drawing.Color.Black;
            this.listBoxStudents.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxStudents.ForeColor = System.Drawing.Color.White;
            this.listBoxStudents.FormattingEnabled = true;
            this.listBoxStudents.ItemHeight = 37;
            this.listBoxStudents.Items.AddRange(new object[] {
            "<select a grade first>"});
            this.listBoxStudents.Location = new System.Drawing.Point(352, 129);
            this.listBoxStudents.Name = "listBoxStudents";
            this.listBoxStudents.Size = new System.Drawing.Size(295, 374);
            this.listBoxStudents.TabIndex = 1;
            // 
            // buttonAddGrade
            // 
            this.buttonAddGrade.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonAddGrade.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddGrade.ForeColor = System.Drawing.Color.White;
            this.buttonAddGrade.Location = new System.Drawing.Point(352, 59);
            this.buttonAddGrade.Name = "buttonAddGrade";
            this.buttonAddGrade.Size = new System.Drawing.Size(239, 40);
            this.buttonAddGrade.TabIndex = 2;
            this.buttonAddGrade.Text = "Add a new grade";
            this.buttonAddGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAddSubject
            // 
            this.buttonAddSubject.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonAddSubject.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddSubject.ForeColor = System.Drawing.Color.White;
            this.buttonAddSubject.Location = new System.Drawing.Point(45, 512);
            this.buttonAddSubject.Name = "buttonAddSubject";
            this.buttonAddSubject.Size = new System.Drawing.Size(291, 56);
            this.buttonAddSubject.TabIndex = 2;
            this.buttonAddSubject.Text = "Add a new subject";
            this.buttonAddSubject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonAddStudent.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddStudent.ForeColor = System.Drawing.Color.White;
            this.buttonAddStudent.Location = new System.Drawing.Point(352, 512);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(295, 56);
            this.buttonAddStudent.TabIndex = 2;
            this.buttonAddStudent.Text = "Add a new student";
            this.buttonAddStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxTeachers
            // 
            this.listBoxTeachers.BackColor = System.Drawing.Color.Black;
            this.listBoxTeachers.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxTeachers.ForeColor = System.Drawing.Color.White;
            this.listBoxTeachers.FormattingEnabled = true;
            this.listBoxTeachers.ItemHeight = 37;
            this.listBoxTeachers.Items.AddRange(new object[] {
            "<select a grade first>"});
            this.listBoxTeachers.Location = new System.Drawing.Point(662, 129);
            this.listBoxTeachers.Name = "listBoxTeachers";
            this.listBoxTeachers.Size = new System.Drawing.Size(295, 374);
            this.listBoxTeachers.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(662, 512);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 56);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add a new teacher";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxGrade
            // 
            this.comboBoxGrade.BackColor = System.Drawing.Color.Black;
            this.comboBoxGrade.Font = new System.Drawing.Font("Bookman Old Style", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxGrade.ForeColor = System.Drawing.Color.White;
            this.comboBoxGrade.FormattingEnabled = true;
            this.comboBoxGrade.Location = new System.Drawing.Point(45, 59);
            this.comboBoxGrade.Name = "comboBoxGrade";
            this.comboBoxGrade.Size = new System.Drawing.Size(291, 40);
            this.comboBoxGrade.TabIndex = 3;
            // 
            // AdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1002, 605);
            this.Controls.Add(this.comboBoxGrade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddStudent);
            this.Controls.Add(this.buttonAddSubject);
            this.Controls.Add(this.buttonAddGrade);
            this.Controls.Add(this.listBoxTeachers);
            this.Controls.Add(this.listBoxStudents);
            this.Controls.Add(this.listBoxSubjects);
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
        private CustomControls.CircularFlatButton CloseButton;
        private Label labelFormText;
        private CustomControls.CircularFlatButton minimizeButton;
        private CustomControls.CircularFlatButton NormalizeMaximizeForm;
        private ListBox listBoxSubjects;
        private ListBox listBoxStudents;
        private Label buttonAddGrade;
        private Label buttonAddSubject;
        private Label buttonAddStudent;
        private ListBox listBoxTeachers;
        private Label label1;
        private ComboBox comboBoxGrade;
    }
}