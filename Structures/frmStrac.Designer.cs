namespace Structures
{
    partial class frmStrac
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
            lblTitle = new Label();
            lblAuthor = new Label();
            lblYear = new Label();
            txttitle = new TextBox();
            txtauthor = new TextBox();
            txtyear = new TextBox();
            btnsaveandshow = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(41, 37);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(35, 18);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Title";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(41, 81);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(51, 18);
            lblAuthor.TabIndex = 1;
            lblAuthor.Text = "Author";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(41, 125);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(39, 18);
            lblYear.TabIndex = 2;
            lblYear.Text = "Year";
            // 
            // txttitle
            // 
            txttitle.Location = new Point(117, 37);
            txttitle.Margin = new Padding(3, 2, 3, 2);
            txttitle.Name = "txttitle";
            txttitle.Size = new Size(186, 26);
            txttitle.TabIndex = 3;
            // 
            // txtauthor
            // 
            txtauthor.Location = new Point(117, 81);
            txtauthor.Margin = new Padding(3, 2, 3, 2);
            txtauthor.Name = "txtauthor";
            txtauthor.Size = new Size(186, 26);
            txtauthor.TabIndex = 3;
            // 
            // txtyear
            // 
            txtyear.Location = new Point(117, 125);
            txtyear.Margin = new Padding(3, 2, 3, 2);
            txtyear.Name = "txtyear";
            txtyear.Size = new Size(186, 26);
            txtyear.TabIndex = 3;
            // 
            // btnsaveandshow
            // 
            btnsaveandshow.Location = new Point(335, 37);
            btnsaveandshow.Name = "btnsaveandshow";
            btnsaveandshow.Size = new Size(159, 114);
            btnsaveandshow.TabIndex = 4;
            btnsaveandshow.Text = "Save and Show";
            btnsaveandshow.UseVisualStyleBackColor = true;
            btnsaveandshow.Click += btnsaveandshow_Click;
            // 
            // frmStrac
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 198);
            Controls.Add(btnsaveandshow);
            Controls.Add(txtyear);
            Controls.Add(txtauthor);
            Controls.Add(txttitle);
            Controls.Add(lblYear);
            Controls.Add(lblAuthor);
            Controls.Add(lblTitle);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmStrac";
            Text = "Structure Example";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblAuthor;
        private Label lblYear;
        private TextBox txttitle;
        private TextBox txtauthor;
        private TextBox txtyear;
        private Button btnsaveandshow;
    }
}
