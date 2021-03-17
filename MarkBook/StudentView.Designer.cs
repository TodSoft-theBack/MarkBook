
namespace MarkBook
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
            this.closeButton = new MarkBook.CircularFlatButton();
            this.labelFormText = new System.Windows.Forms.Label();
            this.subjectsHeader = new MarkBook.TableCell();
            this.marksHeader = new MarkBook.TableCell();
            this.markToolTipConcept = new MarkBook.MarkToolTip();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.circularFlatButton1 = new MarkBook.CircularFlatButton();
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
            this.labelFormText.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFormText.ForeColor = System.Drawing.Color.White;
            this.labelFormText.Location = new System.Drawing.Point(0, 0);
            this.labelFormText.Name = "labelFormText";
            this.labelFormText.Size = new System.Drawing.Size(177, 31);
            this.labelFormText.TabIndex = 1;
            this.labelFormText.Text = "Form text here...";
            // 
            // subjectsHeader
            // 
            this.subjectsHeader.BackColor = System.Drawing.Color.Black;
            this.subjectsHeader.BorderColor = System.Drawing.Color.Black;
            this.subjectsHeader.BorderThickness = 3;
            this.subjectsHeader.DisplayText = "Subjects";
            this.subjectsHeader.FillColor = System.Drawing.Color.Transparent;
            this.subjectsHeader.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subjectsHeader.ForeColor = System.Drawing.Color.White;
            this.subjectsHeader.HasBorder = false;
            this.subjectsHeader.Location = new System.Drawing.Point(36, 68);
            this.subjectsHeader.Name = "subjectsHeader";
            this.subjectsHeader.ShowText = true;
            this.subjectsHeader.Size = new System.Drawing.Size(233, 60);
            this.subjectsHeader.TabIndex = 1;
            // 
            // marksHeader
            // 
            this.marksHeader.BackColor = System.Drawing.Color.Black;
            this.marksHeader.BorderColor = System.Drawing.Color.Black;
            this.marksHeader.BorderThickness = 3;
            this.marksHeader.DisplayText = "Marks";
            this.marksHeader.FillColor = System.Drawing.Color.Transparent;
            this.marksHeader.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.marksHeader.ForeColor = System.Drawing.Color.White;
            this.marksHeader.HasBorder = false;
            this.marksHeader.Location = new System.Drawing.Point(269, 68);
            this.marksHeader.Name = "marksHeader";
            this.marksHeader.ShowText = true;
            this.marksHeader.Size = new System.Drawing.Size(274, 60);
            this.marksHeader.TabIndex = 1;
            // 
            // markToolTipConcept
            // 
            this.markToolTipConcept.BackColor = System.Drawing.Color.Transparent;
            this.markToolTipConcept.BorderColor = System.Drawing.Color.Lime;
            this.markToolTipConcept.BorderRadius = 20;
            this.markToolTipConcept.BorderThickness = 3F;
            this.markToolTipConcept.Controls.Add(this.label3);
            this.markToolTipConcept.Controls.Add(this.label2);
            this.markToolTipConcept.Controls.Add(this.label1);
            this.markToolTipConcept.Controls.Add(this.circularFlatButton1);
            this.markToolTipConcept.CssMode = false;
            this.markToolTipConcept.DisplayText = "";
            this.markToolTipConcept.FillColor = System.Drawing.Color.Lime;
            this.markToolTipConcept.Location = new System.Drawing.Point(269, 407);
            this.markToolTipConcept.Name = "markToolTipConcept";
            this.markToolTipConcept.Size = new System.Drawing.Size(205, 197);
            this.markToolTipConcept.TabIndex = 2;
            this.markToolTipConcept.Visible = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(11, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 96);
            this.label3.TabIndex = 3;
            this.label3.Text = "Контролна работа на вектори.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(11, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "5.87";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Оценка";
            // 
            // circularFlatButton1
            // 
            this.circularFlatButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.circularFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.circularFlatButton1.DisplayText = "";
            this.circularFlatButton1.FillColor = System.Drawing.Color.Red;
            this.circularFlatButton1.Location = new System.Drawing.Point(172, 13);
            this.circularFlatButton1.Name = "circularFlatButton1";
            this.circularFlatButton1.Size = new System.Drawing.Size(20, 20);
            this.circularFlatButton1.TabIndex = 2;
            this.circularFlatButton1.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // StudentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(580, 879);
            this.Controls.Add(this.markToolTipConcept);
            this.Controls.Add(this.marksHeader);
            this.Controls.Add(this.subjectsHeader);
            this.Controls.Add(this.NavBar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentView";
            this.RightToLeftLayout = true;
            this.Text = "MarkBook - <Name> <FamilyName>";
            this.Load += new System.EventHandler(this.StudentView_Load);
            this.TextChanged += new System.EventHandler(this.StudentView_TextChanged);
            this.NavBar.ResumeLayout(false);
            this.NavBar.PerformLayout();
            this.markToolTipConcept.ResumeLayout(false);
            this.markToolTipConcept.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel NavBar;
        private System.Windows.Forms.Label labelFormText;
        private CircularFlatButton closeButton;
        private TableCell subjectsHeader;
        private TableCell marksHeader;
        private MarkToolTip markToolTipConcept;
        private CircularFlatButton circularFlatButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}