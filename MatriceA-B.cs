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
    public partial class MatriceA_B : Form
    {
        public MatriceA_B()
        {
            InitializeComponent();
        }

        private void ResultBttnSoustr_Click(object sender, EventArgs e)
        {
            try 
            {
                int n1 = Convert.ToInt32(numberofLineA2.Text);
                int m1 = Convert.ToInt32(numberofColumnA2.Text);
                Matrice matriceA = FillArray(n1, m1, textBoxMatriceA2.Text);
                int n2 = Convert.ToInt32(numberoflineB2.Text);
                int m2 = Convert.ToInt32(numberofcolumnB2.Text);
                Matrice matriceB = FillArray(n2, m2, textBoxMatriceB2.Text);
                Matrice soustraction = matriceA - matriceB;
                for (int i = 0; i < soustraction.Lines; i++)
                {
                    for (int j = 0; j < soustraction.Columns; j++)
                    {
                        textBoxResultSoust.Text += soustraction[i, j].ToString() + " ";
                    }
                    textBoxResultSoust.Text += "\n";
                }
            }
            catch (ForException ex)
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

