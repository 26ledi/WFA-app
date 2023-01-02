using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab9WinFormApp
{
    public partial class AdditionForm : Form
    {
        public AdditionForm()
        {
            InitializeComponent();
        }

        private void ResultBttnAdd_Click(object sender, EventArgs e)
        {
            Matrice matriceA = null;
            Matrice matriceB = null;
            try
            {
                int n1 = Convert.ToInt32(numberofLine.Text);
                int m1 = Convert.ToInt32(numberofColumn.Text);
                int n2 = Convert.ToInt32(numberofLineB.Text);
                int m2 = Convert.ToInt32(numberofColumnB.Text);
                if (n1==m1 && n2== m2)
                {
                    matriceA = FillArray(n1, m1, textBoxMatriceA.Text);

                    matriceB = FillArray(n2, m2, textBoxMatriceB.Text);

                    Matrice addition = matriceA + matriceB;
                    for (int i = 0; i < addition.Lines; i++)
                    {
                        for (int j = 0; j < addition.Columns; j++)
                        {
                            textBoxResultAdd.Text += addition[i, j].ToString() + " ";
                        }
                        textBoxResultAdd.Text += "\n";
                    }
                }
                else 
                {
                    throw new ForException("Error");
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
            char[] separators = new char[] {' ','\n' };
            string[] tmp1 = values1.Split(separators);
            int k =0;
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
