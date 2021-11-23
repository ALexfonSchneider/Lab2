using System;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;

namespace Lab2
{
    class Matrix
    {
        int min_size = 2;
        int n;
        public int N
        {
            get => n;
            set => n = (value < min_size) ? 2 : value;
        }
        public int X { get; set; }

        double[,] matrix = null;

        public double this[int l,int r]
        {
            get
            {
                try
                {
                    if (matrix is null) throw new Exception($"Out of range: [{l},{r}]");                    
                }
                catch(Exception exp)
                {
                    Console.WriteLine(exp);
                    Environment.Exit(-1);
                }
                return this.matrix[l, r];
            }
        }
        public Matrix(int n = 2)
        {
            this.N = n;
            matrix = new double[N, N];
        }
        public Matrix makeCopy()
        {
            Matrix newMatrix = new(N);
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++) newMatrix.matrix[i, j] = matrix[i, j];
            }
            return newMatrix;
        }
        public void print(DataGridView d)
        {
            d.ColumnCount = d.RowCount = N;
            if(matrix is not null)
            {
                for(int i = 0;i < N;i++)
                {
                    d.Rows[i].HeaderCell.Value = i.ToString();
                    for (int j = 0; j < N; j++)
                    {
                        d.Columns[i].HeaderCell.Value = i.ToString();
                        if (i == j)
                        {
                            d.Rows[i].Cells[j].Style.BackColor = Color.Red;
                        }
                        else d.Rows[i].Cells[j].Style.BackColor = Color.White;
                        d.Rows[i].Cells[j].Value = matrix[i, j];
                    }
                }
                d.AutoResizeColumns();
                d.AutoResizeRows();
            }
        }
        public static Matrix operator +(Matrix a, Matrix b)
        {
            if (a.N == b.N)
            {
                Matrix c = new(a.N);
                for (int i = 0; i < a.N; i++)
                {
                    for (int j = 0; j < a.N; j++) c.matrix[i, j] = (a.matrix[i, j] + b.matrix[i, j]);
                }
                return c;
            }
            else return new();
        }
        public static Matrix operator *(Matrix a,Matrix b)
        {
            if (a.N == b.N)
            {
                Matrix c = new(a.N);
                for (int i = 0; i < a.N; i++)
                {
                    for (int j = 0; j < a.N; j++)
                    {
                        for (int k = 0; k < a.N; k++) c.matrix[i, j] = (a.matrix[i, k] + b.matrix[k, j]);
                    }
                }
                return c;
            }
            else return new Matrix();
        }
        public static Matrix operator *(Matrix a, long b)
        {
            if (a is not null)
            {
                Matrix temp = a.makeCopy();
                for (int i = 0; i < a.N; i++)
                {
                    for (int j = 0; j < a.N; j++) a.matrix[i, j] *= b;
                }
                return temp;
            }
            else return new();
        }
        public static Matrix operator -(Matrix a)
        {
            Matrix c;
            try
            {
                c = new(a.N);
                for (int i = 0; i < a.N; i++)
                {
                    for (int j = 0; j < a.N; j++) a.matrix[i, j] = -(a.matrix[i, j]);
                }
            }
            catch { c = new(); }
            return c;
        }
        public static Matrix operator -(Matrix a, Matrix b) => a + (-b);
        public static Matrix operator /(Matrix a, long b) => (a * (1 / b));
        // методы
        public void setMatrix(int min,int max)
        {
            if(matrix is not null)
            {
                Random rand = new Random();
                for(int i = 0;i < N;i++)
                {
                    for(int j =0;j < N;j++) matrix[i, j] = rand.Next(min, max);
                }
            }
        }
        public void setMatrix(bool flag)
        {
            if (flag == true && matrix is not null)
            {
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++) matrix[i, j] = n - i;
                }
            }
            else if (matrix is not null)
            {
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        if (i < j) matrix[i, j] = i + j;
                        else matrix[i, j] = (n - i + j);
                    }
                }
            }
        }
        public void setMatrix(int X)
        {
            if(matrix is not null)
            {
                for(int i = 0;i < N;i++)
                {
                    for(int j = 0;j < N;j++)
                    {
                        if (N - i - 1 < j) matrix[i, j] = 1;
                        else matrix[i, j] = (int)Math.Pow(X, i + j + 1);
                    }
                }
            }
        }
        public static Matrix trans(Matrix a, int flag = 1)
        {
            Matrix c;
            if (a.matrix is not null)
            {
                c = new Matrix(a.N);
                if (flag == 1)
                {
                    for (int i = 0; i < a.N; i++)
                    {
                        for (int j = 0; j < a.N; j++) c.matrix[i, j] = a.matrix[j, i];
                    }
                }
                else if (flag == -1)
                {
                    for (int i = 0; i < a.N; i++)
                    {
                        for (int j = 0; j < a.N; j++)
                        {
                            if (a.N - i == j) c.matrix[i, j] = a.matrix[i, j];
                            else c.matrix[i, j] = a.matrix[a.N - j - 1, a.N - i - 1];
                        }
                    }
                }
                else c = a;
            }
            else c = a;
            return c;
        }
        public static Matrix reverse(Matrix a, int flag = 1)
        {
            Matrix c;
            if (a is not null)
            {
                c = new Matrix(a.N); ;
                if (flag == 1)
                {
                    for (int i = 0; i < a.N; i++)
                    {
                        for (int j = 0; j < a.N; j++) c.matrix[i, j] = a.matrix[a.N - i - 1, j];
                    }
                }
                else if (flag == -1)
                {
                    for (int i = 0; i < a.N; i++)
                    {
                        for (int j = 0; j < a.N; j++) c.matrix[i, j] = a.matrix[i, a.N - j - 1];
                    }
                }
                else c = a;
            }
            else c = a;
            return c;
        }
        public void add_side_diagonal_element()
        {
            for (int j = 0; j < N; j++)
            {
                double side_diagonal_element = matrix[N - j - 1, j];
                for (int i = 0; i < N; i++) matrix[i, j] += side_diagonal_element;
            }
        }
        public void line_divEven_multiplyNotEven()
        {
            for(int i = 0;i < N;i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = (i % 2 == 0) ? matrix[i, j] * 2 : matrix[i, j] / 2;
                }
            }
        }
        public double Determinant(double[][] Matrix = null)
        {
            if (Matrix == null)
            {
                Matrix = new double[N][];
                for (int i = 0; i < N; i++)
                {
                    Matrix[i] = new double[N];
                    for (int j = 0; j < N; j++) Matrix[i][j] = matrix[i, j];
                }
            }

            double Returning;
            if (Matrix.Length == 2) Returning = Matrix[0][0] * Matrix[1][1] - Matrix[0][1] * Matrix[1][0];
            else
            {
                double[][] Minor = new double[Matrix.Length - 1][]; //минор, но возможно, что это матрица n-ого порядка
                int Minus = 1;
                double Temp;
                Returning = 0;

                for (int i = 0; i < Matrix.Length; i++)
                {
                    for (int j = 1, k; j < Matrix.Length; j++) //сохраняю значения для "возможно" минора
                    {
                        Minor[j - 1] = new double[Matrix.Length - 1];
                        for (k = 0; k < i; k++) Minor[j - 1][k] = Matrix[j][k]; //значения до диагонали
                        for (k++; k < Matrix.Length; k++) Minor[j - 1][k - 1] = Matrix[j][k]; //значения после диагонали
                    }

                    Temp = Determinant(Minor);
                    Temp = Matrix[0][i] * Minus * Temp;
                    Returning += Temp;

                    Minus = (Minus > 0) ? -1 : 1; //меняю знак, согласно правилам 
                }
            }
            return Returning;
        }
    }
}