namespace Vixen_Editor
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RTBComments = new System.Windows.Forms.RichTextBox();
            this.updateBTN = new System.Windows.Forms.Button();
            this.clearBTN = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.Datalbl = new System.Windows.Forms.Label();
            this.orderNum = new System.Windows.Forms.TextBox();
            this.dateComp = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.subJobNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.jobNum = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Job Number : ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RTBComments);
            this.panel1.Controls.Add(this.updateBTN);
            this.panel1.Controls.Add(this.clearBTN);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.searchBtn);
            this.panel1.Controls.Add(this.Datalbl);
            this.panel1.Controls.Add(this.orderNum);
            this.panel1.Controls.Add(this.dateComp);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.subJobNum);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.jobNum);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 599);
            this.panel1.TabIndex = 1;
            // 
            // RTBComments
            // 
            this.RTBComments.Location = new System.Drawing.Point(293, 307);
            this.RTBComments.Name = "RTBComments";
            this.RTBComments.Size = new System.Drawing.Size(368, 179);
            this.RTBComments.TabIndex = 6;
            this.RTBComments.Text = "";
            // 
            // updateBTN
            // 
            this.updateBTN.Location = new System.Drawing.Point(668, 310);
            this.updateBTN.Name = "updateBTN";
            this.updateBTN.Size = new System.Drawing.Size(99, 176);
            this.updateBTN.TabIndex = 8;
            this.updateBTN.Text = "Update";
            this.updateBTN.UseVisualStyleBackColor = true;
            this.updateBTN.Click += new System.EventHandler(this.updateBTN_Click);
            // 
            // clearBTN
            // 
            this.clearBTN.Location = new System.Drawing.Point(293, 492);
            this.clearBTN.Name = "clearBTN";
            this.clearBTN.Size = new System.Drawing.Size(368, 46);
            this.clearBTN.TabIndex = 7;
            this.clearBTN.Text = "Clear";
            this.clearBTN.UseVisualStyleBackColor = true;
            this.clearBTN.Click += new System.EventHandler(this.clearBTN_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Comments : ";
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(293, 132);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(368, 40);
            this.searchBtn.TabIndex = 4;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // Datalbl
            // 
            this.Datalbl.AutoSize = true;
            this.Datalbl.Location = new System.Drawing.Point(103, 262);
            this.Datalbl.Name = "Datalbl";
            this.Datalbl.Size = new System.Drawing.Size(184, 25);
            this.Datalbl.TabIndex = 3;
            this.Datalbl.Text = "Date Completed : ";
            // 
            // orderNum
            // 
            this.orderNum.Location = new System.Drawing.Point(293, 71);
            this.orderNum.Name = "orderNum";
            this.orderNum.Size = new System.Drawing.Size(145, 31);
            this.orderNum.TabIndex = 3;
            // 
            // dateComp
            // 
            this.dateComp.Location = new System.Drawing.Point(293, 257);
            this.dateComp.Name = "dateComp";
            this.dateComp.Size = new System.Drawing.Size(368, 31);
            this.dateComp.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Order Number : ";
            // 
            // subJobNum
            // 
            this.subJobNum.Location = new System.Drawing.Point(540, 23);
            this.subJobNum.MaxLength = 3;
            this.subJobNum.Name = "subJobNum";
            this.subJobNum.Size = new System.Drawing.Size(121, 31);
            this.subJobNum.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(516, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "/";
            // 
            // jobNum
            // 
            this.jobNum.Location = new System.Drawing.Point(293, 23);
            this.jobNum.MaxLength = 6;
            this.jobNum.Name = "jobNum";
            this.jobNum.Size = new System.Drawing.Size(217, 31);
            this.jobNum.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 655);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Vixen Entry Edit";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox subJobNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox jobNum;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox orderNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Datalbl;
        private System.Windows.Forms.DateTimePicker dateComp;
        private System.Windows.Forms.Button updateBTN;
        private System.Windows.Forms.Button clearBTN;
        private System.Windows.Forms.RichTextBox RTBComments;
    }
}

