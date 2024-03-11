namespace WindowsFormsApp1
{
    partial class Form2
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
            this.btnFisk = new System.Windows.Forms.Button();
            this.btnTable = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnMoneyFor = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFisk
            // 
            this.btnFisk.Location = new System.Drawing.Point(-2, 0);
            this.btnFisk.Name = "btnFisk";
            this.btnFisk.Size = new System.Drawing.Size(158, 67);
            this.btnFisk.TabIndex = 0;
            this.btnFisk.Text = "Изкарване на фискален бон";
            this.btnFisk.UseVisualStyleBackColor = true;
            this.btnFisk.Click += new System.EventHandler(this.btnFisk_Click);
            // 
            // btnTable
            // 
            this.btnTable.Location = new System.Drawing.Point(154, 0);
            this.btnTable.Name = "btnTable";
            this.btnTable.Size = new System.Drawing.Size(158, 67);
            this.btnTable.TabIndex = 0;
            this.btnTable.Text = "Избиране на маса";
            this.btnTable.UseVisualStyleBackColor = true;
            this.btnTable.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(309, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 67);
            this.button3.TabIndex = 0;
            this.button3.Text = "Implement";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(464, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(158, 67);
            this.button4.TabIndex = 0;
            this.button4.Text = "Implement";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnMoneyFor
            // 
            this.btnMoneyFor.Location = new System.Drawing.Point(773, 0);
            this.btnMoneyFor.Name = "btnMoneyFor";
            this.btnMoneyFor.Size = new System.Drawing.Size(158, 67);
            this.btnMoneyFor.TabIndex = 0;
            this.btnMoneyFor.Text = "Уборот на смяна";
            this.btnMoneyFor.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(619, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(158, 67);
            this.button6.TabIndex = 0;
            this.button6.Text = "Implement";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Маса:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(931, 792);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnMoneyFor);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnTable);
            this.Controls.Add(this.btnFisk);
            this.Name = "Form2";
            this.Text = "Work";
            this.Load += new System.EventHandler(this.Work_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFisk;
        private System.Windows.Forms.Button btnTable;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnMoneyFor;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
    }
}