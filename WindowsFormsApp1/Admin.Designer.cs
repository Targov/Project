﻿namespace WindowsFormsApp1
{
    partial class Admin
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
            this.buttonTurnOverPerShift = new System.Windows.Forms.Button();
            this.buttonNewEmployee = new System.Windows.Forms.Button();
            this.buttonTurnoverPerMonth = new System.Windows.Forms.Button();
            this.buttonIncomeAndOutcome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonTurnOverPerShift
            // 
            this.buttonTurnOverPerShift.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonTurnOverPerShift.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTurnOverPerShift.Location = new System.Drawing.Point(61, 106);
            this.buttonTurnOverPerShift.Name = "buttonTurnOverPerShift";
            this.buttonTurnOverPerShift.Size = new System.Drawing.Size(180, 99);
            this.buttonTurnOverPerShift.TabIndex = 0;
            this.buttonTurnOverPerShift.Text = "Оборот на смяна";
            this.buttonTurnOverPerShift.UseVisualStyleBackColor = false;
            // 
            // buttonNewEmployee
            // 
            this.buttonNewEmployee.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonNewEmployee.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewEmployee.Location = new System.Drawing.Point(319, 106);
            this.buttonNewEmployee.Name = "buttonNewEmployee";
            this.buttonNewEmployee.Size = new System.Drawing.Size(180, 99);
            this.buttonNewEmployee.TabIndex = 1;
            this.buttonNewEmployee.Text = "Нов служител";
            this.buttonNewEmployee.UseVisualStyleBackColor = false;
            // 
            // buttonTurnoverPerMonth
            // 
            this.buttonTurnoverPerMonth.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonTurnoverPerMonth.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTurnoverPerMonth.Location = new System.Drawing.Point(61, 261);
            this.buttonTurnoverPerMonth.Name = "buttonTurnoverPerMonth";
            this.buttonTurnoverPerMonth.Size = new System.Drawing.Size(180, 99);
            this.buttonTurnoverPerMonth.TabIndex = 2;
            this.buttonTurnoverPerMonth.Text = "Оборот за месец";
            this.buttonTurnoverPerMonth.UseVisualStyleBackColor = false;
            // 
            // buttonIncomeAndOutcome
            // 
            this.buttonIncomeAndOutcome.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonIncomeAndOutcome.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIncomeAndOutcome.Location = new System.Drawing.Point(319, 261);
            this.buttonIncomeAndOutcome.Name = "buttonIncomeAndOutcome";
            this.buttonIncomeAndOutcome.Size = new System.Drawing.Size(180, 99);
            this.buttonIncomeAndOutcome.TabIndex = 3;
            this.buttonIncomeAndOutcome.Text = "Приходи и разходи";
            this.buttonIncomeAndOutcome.UseVisualStyleBackColor = false;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(547, 466);
            this.Controls.Add(this.buttonIncomeAndOutcome);
            this.Controls.Add(this.buttonTurnoverPerMonth);
            this.Controls.Add(this.buttonNewEmployee);
            this.Controls.Add(this.buttonTurnOverPerShift);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonTurnOverPerShift;
        private System.Windows.Forms.Button buttonNewEmployee;
        private System.Windows.Forms.Button buttonTurnoverPerMonth;
        private System.Windows.Forms.Button buttonIncomeAndOutcome;
    }
}