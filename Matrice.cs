using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9WinFormApp
{
    public class Matrice
    {
        //field
        public int[,] array { get; set; }
       
        public int this[int i, int j]//l'indexeurs est utilisé pour accéder à une instance d’une classe
        {
            get
            {
                return array[i, j];
            }
            set
            {
                array[i, j] = value;
            }
        }
        public int Lines
        {
            get
            {
                return array.GetLength(0);
            }
        }
        public int Columns
        {
            get
            {
                return array.GetLength(1);
            }
        }
        //constructor
        public Matrice(int Lines, int Columns)
        {
            array = new int[Lines, Columns];
        }
     
        public static Matrice operator +(Matrice a, Matrice b)
        {
            Matrice c = new Matrice(a.Lines, a.Columns);

            for (int i = 0; i < a.Lines; i++)
            {
                for (int j = 0; j < a.Columns; j++)
                {
                    c[i, j] = a[i, j] + b[i, j];
                }
            }

            return c;
        }
        public static Matrice operator -(Matrice a, Matrice b)
        {
            Matrice s = new Matrice(a.Lines, a.Columns);

            for (int i = 0; i < a.Lines; i++)
            {
                for (int j = 0; j < a.Columns; j++)
                {
                    s[i, j] = a[i, j] - b[i, j];
                }
            }

            return s;
        }
        public static Matrice operator *(Matrice a, Matrice b)
        {
            Matrice m = new Matrice(a.Lines, a.Columns);

            //check for same amount of row and columns
            //if not equal than "throw new (YourException)"

            for (int i = 0; i < a.Lines; i++)
            {
                for (int j = 0; j < a.Columns; j++)
                {
                    m[i, j] = a[i, j] * b[i, j];
                }
            }

            return m;
        }

    }
}

