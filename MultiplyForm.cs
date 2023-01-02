using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9WinFormApp
{
    public partial class MultiplyForm : Form
    {
        public MultiplyForm()
        {
            InitializeComponent();
        }
        
        private void ResultBttnMult_Click_1(object sender, EventArgs e)
        {
            try 
            {
                int n1 = Convert.ToInt32(numberofLineA3.Text);
                int m1 = Convert.ToInt32(numberofColumnA3.Text);
                Matrice matriceA = FillArray(n1, m1, textBoxMatriceA3.Text);
                int n2 = Convert.ToInt32(numberoflineB3.Text);
                int m2 = Convert.ToInt32(numberofcolumnB3.Text);
                Matrice matriceB = FillArray(n2, m2, textBoxMatriceB3.Text);
                Matrice multiplication = matriceA * matriceB;
                for (int i = 0; i < multiplication.Lines; i++)
                {
                    for (int j = 0; j < multiplication.Columns; j++)
                    {
                        textBoxResultMult.Text += multiplication[i, j].ToString() + " ";
                    }
                    textBoxResultMult.Text += "\n";
                }
            }
            catch(ForException ex)
            {
                MessageBox.Show("Did you filled very well?Please enter numbers!!!");
            }
            
        }
        private Matrice FillArray(int n, int m, String arrayInString)
        {
            Matrice matriceA = new Matrice(n, m);
            string values1 = arrayInString;
            char[] separators = new char[] { ' ', '\n' };
            string[] tmp1 = values1.Split(separators);
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matriceA[i, j] = Convert.ToInt32(tmp1[k]);
                    k++;
                }
            }

            return matriceA;
        }
    }
    
}
