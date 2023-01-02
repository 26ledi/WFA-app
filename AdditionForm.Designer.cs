namespace Lab9WinFormApp
{
    partial class AdditionForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numberofLine = new System.Windows.Forms.TextBox();
            this.numberofColumn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMatriceA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numberofLineB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numberofColumnB = new System.Windows.Forms.TextBox();
            this.textBoxMatriceB = new System.Windows.Forms.TextBox();
            this.ResultBttnAdd = new System.Windows.Forms.Button();
            this.textBoxResultAdd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(331, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Matrice A + B";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Matrice A ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "n:";
            // 
            // numberofLine
            // 
            this.numberofLine.Location = new System.Drawing.Point(46, 95);
            this.numberofLine.Name = "numberofLine";
            this.numberofLine.Size = new System.Drawing.Size(33, 23);
            this.numberofLine.TabIndex = 4;
            // 
            // numberofColumn
            // 
            this.numberofColumn.Location = new System.Drawing.Point(46, 124);
            this.numberofColumn.Name = "numberofColumn";
            this.numberofColumn.Size = new System.Drawing.Size(33, 23);
            this.numberofColumn.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(12, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "m:";
            // 
            // textBoxMatriceA
            // 
            this.textBoxMatriceA.Location = new System.Drawing.Point(12, 160);
            this.textBoxMatriceA.Multiline = true;
            this.textBoxMatriceA.Name = "textBoxMatriceA";
            this.textBoxMatriceA.Size = new System.Drawing.Size(228, 110);
            this.textBoxMatriceA.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(673, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Enter Matrice B";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(673, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "n:";
            // 
            // numberofLineB
            // 
            this.numberofLineB.Location = new System.Drawing.Point(710, 100);
            this.numberofLineB.Name = "numberofLineB";
            this.numberofLineB.Size = new System.Drawing.Size(33, 23);
            this.numberofLineB.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(673, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "m:";
            // 
            // numberofColumnB
            // 
            this.numberofColumnB.Location = new System.Drawing.Point(710, 131);
            this.numberofColumnB.Name = "numberofColumnB";
            this.numberofColumnB.Size = new System.Drawing.Size(33, 23);
            this.numberofColumnB.TabIndex = 12;
            // 
            // textBoxMatriceB
            // 
            this.textBoxMatriceB.Location = new System.Drawing.Point(568, 160);
            this.textBoxMatriceB.Multiline = true;
            this.textBoxMatriceB.Name = "textBoxMatriceB";
            this.textBoxMatriceB.Size = new System.Drawing.Size(220, 110);
            this.textBoxMatriceB.TabIndex = 13;
            // 
            // ResultBttnAdd
            // 
            this.ResultBttnAdd.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ResultBttnAdd.Location = new System.Drawing.Point(354, 243);
            this.ResultBttnAdd.Name = "ResultBttnAdd";
            this.ResultBttnAdd.Size = new System.Drawing.Size(104, 27);
            this.ResultBttnAdd.TabIndex = 14;
            this.ResultBttnAdd.Text = "Result";
            this.ResultBttnAdd.UseVisualStyleBackColor = true;
            this.ResultBttnAdd.Click += new System.EventHandler(this.ResultBttnAdd_Click);
            // 
            // textBoxResultAdd
            // 
            this.textBoxResultAdd.Location = new System.Drawing.Point(264, 276);
            this.textBoxResultAdd.Multiline = true;
            this.textBoxResultAdd.Name = "textBoxResultAdd";
            this.textBoxResultAdd.Size = new System.Drawing.Size(289, 150);
            this.textBoxResultAdd.TabIndex = 15;
            // 
            // AdditionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxResultAdd);
            this.Controls.Add(this.ResultBttnAdd);
            this.Controls.Add(this.textBoxMatriceB);
            this.Controls.Add(this.numberofColumnB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numberofLineB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxMatriceA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numberofColumn);
            this.Controls.Add(this.numberofLine);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdditionForm";
            this.Text = "AdditionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox numberofLine;
        private TextBox numberofColumn;
        private Label label4;
        private TextBox textBoxMatriceA;
        private Label label5;
        private Label label6;
        private TextBox numberofLineB;
        private Label label7;
        private TextBox numberofColumnB;
        private TextBox textBoxMatriceB;
        private Button ResultBttnAdd;
        private TextBox textBoxResultAdd;
    }
}