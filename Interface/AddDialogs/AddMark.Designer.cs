
using Interface.CustomControls;

namespace Interface.AddDialogs
{
    partial class AddMarkDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMarkDialog));
            this.textBoxMarkValue = new System.Windows.Forms.TextBox();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.buttonPreview = new System.Windows.Forms.Button();
            this.NavBar = new System.Windows.Forms.Panel();
            this.minimizeButton = new Interface.CustomControls.CircularFlatButton();
            this.closeButton = new Interface.CustomControls.CircularFlatButton();
            this.labelFormText = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.listBoxPreview = new System.Windows.Forms.ListBox();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.NavBar.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxMarkValue
            // 
            this.textBoxMarkValue.BackColor = System.Drawing.Color.White;
            this.textBoxMarkValue.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMarkValue.Location = new System.Drawing.Point(15, 47);
            this.textBoxMarkValue.Name = "textBoxMarkValue";
            this.textBoxMarkValue.PlaceholderText = "Enter mark here ...";
            this.textBoxMarkValue.Size = new System.Drawing.Size(306, 43);
            this.textBoxMarkValue.TabIndex = 0;
            // 
            // textBoxComment
            // 
            this.textBoxComment.BackColor = System.Drawing.Color.White;
            this.textBoxComment.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxComment.Location = new System.Drawing.Point(15, 96);
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.PlaceholderText = "Enter comment here ...";
            this.textBoxComment.Size = new System.Drawing.Size(306, 43);
            this.textBoxComment.TabIndex = 0;
            // 
            // buttonPreview
            // 
            this.buttonPreview.BackColor = System.Drawing.Color.PeachPuff;
            this.buttonPreview.Location = new System.Drawing.Point(15, 145);
            this.buttonPreview.Name = "buttonPreview";
            this.buttonPreview.Size = new System.Drawing.Size(306, 43);
            this.buttonPreview.TabIndex = 1;
            this.buttonPreview.Text = "Preview";
            this.buttonPreview.UseVisualStyleBackColor = false;
            this.buttonPreview.Click += new System.EventHandler(this.buttonPreview_Click);
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
            this.NavBar.Size = new System.Drawing.Size(816, 42);
            this.NavBar.TabIndex = 0;
            this.NavBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NavBar_MouseDown);
            this.NavBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NavBar_MouseMove);
            this.NavBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NavBar_MouseUp);
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.minimizeButton.ContainsDataInfo = false;
            this.minimizeButton.DisplayText = "";
            this.minimizeButton.FillColor = System.Drawing.Color.Yellow;
            this.minimizeButton.Key = new int[0];
            this.minimizeButton.Location = new System.Drawing.Point(756, 9);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Padding = new System.Windows.Forms.Padding(1);
            this.minimizeButton.Selected = false;
            this.minimizeButton.Size = new System.Drawing.Size(20, 20);
            this.minimizeButton.TabIndex = 3;
            this.minimizeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.ContainsDataInfo = false;
            this.closeButton.DisplayText = "";
            this.closeButton.FillColor = System.Drawing.Color.Red;
            this.closeButton.Key = new int[0];
            this.closeButton.Location = new System.Drawing.Point(782, 9);
            this.closeButton.Name = "closeButton";
            this.closeButton.Padding = new System.Windows.Forms.Padding(1);
            this.closeButton.Selected = false;
            this.closeButton.Size = new System.Drawing.Size(20, 20);
            this.closeButton.TabIndex = 2;
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.labelFormText.Size = new System.Drawing.Size(186, 35);
            this.labelFormText.TabIndex = 1;
            this.labelFormText.Text = "Add mark dialog";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.PeachPuff;
            this.buttonSubmit.Enabled = false;
            this.buttonSubmit.Location = new System.Drawing.Point(15, 194);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(152, 43);
            this.buttonSubmit.TabIndex = 1;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.PeachPuff;
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Location = new System.Drawing.Point(169, 194);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(152, 43);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Revert";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // listBoxPreview
            // 
            this.listBoxPreview.BackColor = System.Drawing.Color.Black;
            this.listBoxPreview.ForeColor = System.Drawing.Color.White;
            this.listBoxPreview.FormattingEnabled = true;
            this.listBoxPreview.ItemHeight = 20;
            this.listBoxPreview.Location = new System.Drawing.Point(376, 87);
            this.listBoxPreview.Name = "listBoxPreview";
            this.listBoxPreview.Size = new System.Drawing.Size(389, 284);
            this.listBoxPreview.TabIndex = 2;
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.Black;
            this.panelInfo.Controls.Add(this.textBoxMarkValue);
            this.panelInfo.Controls.Add(this.textBoxComment);
            this.panelInfo.Controls.Add(this.buttonDelete);
            this.panelInfo.Controls.Add(this.buttonPreview);
            this.panelInfo.Controls.Add(this.buttonSubmit);
            this.panelInfo.Location = new System.Drawing.Point(32, 87);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(338, 290);
            this.panelInfo.TabIndex = 3;
            // 
            // AddMarkDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(816, 437);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.listBoxPreview);
            this.Controls.Add(this.NavBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddMarkDialog";
            this.Text = "AddMarkDialog";
            this.Load += new System.EventHandler(this.AddMarkDialog_Load);
            this.NavBar.ResumeLayout(false);
            this.NavBar.PerformLayout();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel NavBar;
        private CircularFlatButton closeButton;
        private CircularFlatButton minimizeButton;
        private System.Windows.Forms.Label labelFormText;
        private System.Windows.Forms.TextBox textBoxMarkValue;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.Button buttonPreview;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ListBox listBoxPreview;
        private System.Windows.Forms.Panel panelInfo;
    }
}