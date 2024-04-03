namespace salesperson_menu
{
    partial class Summary
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
            this.SalesTextBox = new System.Windows.Forms.Label();
            this.CommissionTextBox = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PayTextBox = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(28, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Sales:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SalesTextBox
            // 
            this.SalesTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SalesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SalesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesTextBox.Location = new System.Drawing.Point(189, 36);
            this.SalesTextBox.Name = "SalesTextBox";
            this.SalesTextBox.Size = new System.Drawing.Size(188, 23);
            this.SalesTextBox.TabIndex = 1;
            this.SalesTextBox.Text = "label2";
            this.SalesTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CommissionTextBox
            // 
            this.CommissionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CommissionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CommissionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommissionTextBox.Location = new System.Drawing.Point(189, 74);
            this.CommissionTextBox.Name = "CommissionTextBox";
            this.CommissionTextBox.Size = new System.Drawing.Size(188, 23);
            this.CommissionTextBox.TabIndex = 3;
            this.CommissionTextBox.Text = "label3";
            this.CommissionTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(28, 74);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 7, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Total Commissions:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PayTextBox
            // 
            this.PayTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PayTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayTextBox.Location = new System.Drawing.Point(189, 112);
            this.PayTextBox.Name = "PayTextBox";
            this.PayTextBox.Size = new System.Drawing.Size(188, 23);
            this.PayTextBox.TabIndex = 5;
            this.PayTextBox.Text = "label5";
            this.PayTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(28, 112);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 0, 7, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Total Pay:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Summary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 171);
            this.Controls.Add(this.PayTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CommissionTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SalesTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Summary";
            this.Text = "SummaryForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SalesTextBox;
        private System.Windows.Forms.Label CommissionTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label PayTextBox;
        private System.Windows.Forms.Label label6;
    }
}