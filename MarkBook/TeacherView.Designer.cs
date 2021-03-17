
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
            this.tableCell1 = new MarkBook.TableCell();
            this.tableCell2 = new MarkBook.TableCell();
            this.NavBar.SuspendLayout();
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
            // studentsHeader
            // 
            this.studentsHeader.BackColor = System.Drawing.Color.Black;
            this.studentsHeader.BorderColor = System.Drawing.Color.Black;
            this.studentsHeader.BorderThickness = 3;
            this.studentsHeader.DisplayText = "Students";
            this.studentsHeader.FillColor = System.Drawing.Color.Transparent;
            this.studentsHeader.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.studentsHeader.ForeColor = System.Drawing.Color.White;
            this.studentsHeader.HasBorder = false;
            this.studentsHeader.Location = new System.Drawing.Point(36, 143);
            this.studentsHeader.Name = "studentsHeader";
            this.studentsHeader.ShowText = true;
            this.studentsHeader.Size = new System.Drawing.Size(233, 60);
            this.studentsHeader.TabIndex = 1;
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
            this.marksHeader.Location = new System.Drawing.Point(269, 143);
            this.marksHeader.Name = "marksHeader";
            this.marksHeader.ShowText = true;
            this.marksHeader.Size = new System.Drawing.Size(274, 60);
            this.marksHeader.TabIndex = 1;
            // 
            // tableCell1
            // 
            this.tableCell1.BackColor = System.Drawing.Color.Black;
            this.tableCell1.BorderColor = System.Drawing.Color.Black;
            this.tableCell1.BorderThickness = 3;
            this.tableCell1.DisplayText = "Students";
            this.tableCell1.FillColor = System.Drawing.Color.Transparent;
            this.tableCell1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tableCell1.ForeColor = System.Drawing.Color.White;
            this.tableCell1.HasBorder = false;
            this.tableCell1.Location = new System.Drawing.Point(36, 57);
            this.tableCell1.Name = "tableCell1";
            this.tableCell1.ShowText = true;
            this.tableCell1.Size = new System.Drawing.Size(233, 35);
            this.tableCell1.TabIndex = 1;
            // 
            // tableCell2
            // 
            this.tableCell2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tableCell2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tableCell2.BorderThickness = 3;
            this.tableCell2.DisplayText = "Marks";
            this.tableCell2.FillColor = System.Drawing.Color.Transparent;
            this.tableCell2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tableCell2.ForeColor = System.Drawing.Color.Black;
            this.tableCell2.HasBorder = false;
            this.tableCell2.Location = new System.Drawing.Point(269, 57);
            this.tableCell2.Name = "tableCell2";
            this.tableCell2.ShowText = true;
            this.tableCell2.Size = new System.Drawing.Size(274, 35);
            this.tableCell2.TabIndex = 1;
            // 
            // TeacherView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(580, 879);
            this.Controls.Add(this.tableCell2);
            this.Controls.Add(this.marksHeader);
            this.Controls.Add(this.tableCell1);
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
            this.ResumeLayout(false);

        }


        private System.Windows.Forms.Panel NavBar;
        private System.Windows.Forms.Label labelFormText;
        private CircularFlatButton closeButton;
        private TableCell studentsHeader;
        private TableCell marksHeader;
        #endregion

        private TableCell tableCell1;
        private TableCell tableCell2;
    }
}