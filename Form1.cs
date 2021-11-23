using System;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        Matrix matrix1 = null;
        Matrix matrix2 = null;
        Matrix matrix3 = null;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void build_Click(object sender, EventArgs e)
        {
            int matrix_size;
            int x;
            try {
                matrix_size = Convert.ToInt32(textBox_matrix_size.Text);
            }
            catch {
                matrix_size = 2;
            }
            try {
                x = Convert.ToInt32(textBox_X.Text);
            }
            catch {
                x = 2;
            }
            matrix1 = new(matrix_size);
            matrix1.setMatrix(x);
            matrix1.print(dataGridView_M1);
        }

        private void button_build_on_assignment_Click(object sender, EventArgs e)
        {
            build_Click(this, null);

            matrix2 = matrix1.makeCopy();
            matrix2.add_side_diagonal_element();
            matrix2.print(dataGridView_M2);

            matrix3 = matrix1.makeCopy();
            matrix3.line_divEven_multiplyNotEven();
            matrix3.print(dataGridView_M3);
        }
        private void button_calc_determinant_Click(object sender, EventArgs e)
        {
            d2.Text = Convert.ToString(matrix2.Determinant());
            d3.Text = Convert.ToString(matrix3.Determinant());
        }
    }
}
