namespace Lab9WinFormApp
{
    partial class Menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.AdditionBttn = new System.Windows.Forms.Button();
            this.SoustractBttn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(372, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            // 
            // AdditionBttn
            // 
            this.AdditionBttn.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AdditionBttn.Location = new System.Drawing.Point(354, 107);
            this.AdditionBttn.Name = "AdditionBttn";
            this.AdditionBttn.Size = new System.Drawing.Size(104, 33);
            this.AdditionBttn.TabIndex = 1;
            this.AdditionBttn.Text = "Matrice A + B";
            this.AdditionBttn.UseVisualStyleBackColor = true;
            this.AdditionBttn.Click += new System.EventHandler(this.AdditionBttn_Click);
            // 
            // SoustractBttn
            // 
            this.SoustractBttn.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SoustractBttn.Location = new System.Drawing.Point(354, 179);
            this.SoustractBttn.Name = "SoustractBttn";
            this.SoustractBttn.Size = new System.Drawing.Size(104, 27);
            this.SoustractBttn.TabIndex = 2;
            this.SoustractBttn.Text = "Matrice A-B";
            this.SoustractBttn.UseVisualStyleBackColor = true;
            this.SoustractBttn.Click += new System.EventHandler(this.SoustractBttn_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(354, 241);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 28);
            this.button3.TabIndex = 3;
            this.button3.Text = "Matrice A*B";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.SoustractBttn);
            this.Controls.Add(this.AdditionBttn);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button AdditionBttn;
        private Button SoustractBttn;
        private Button button3;
    }
}