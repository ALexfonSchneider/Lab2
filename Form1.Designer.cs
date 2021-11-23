
namespace Lab2
{
    partial class Form1
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.d3 = new System.Windows.Forms.Label();
            this.d2 = new System.Windows.Forms.Label();
            this.button_calc_determinant = new System.Windows.Forms.Button();
            this.button_build_on_assignment = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_X = new System.Windows.Forms.TextBox();
            this.textBox_matrix_size = new System.Windows.Forms.TextBox();
            this.button_build = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView_M3 = new System.Windows.Forms.DataGridView();
            this.dataGridView_M1 = new System.Windows.Forms.DataGridView();
            this.dataGridView_M2 = new System.Windows.Forms.DataGridView();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_M3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_M1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_M2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.d3);
            this.panel3.Controls.Add(this.d2);
            this.panel3.Controls.Add(this.button_calc_determinant);
            this.panel3.Controls.Add(this.button_build_on_assignment);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.textBox_X);
            this.panel3.Controls.Add(this.textBox_matrix_size);
            this.panel3.Controls.Add(this.button_build);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 320);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 130);
            this.panel3.TabIndex = 0;
            // 
            // d3
            // 
            this.d3.AutoSize = true;
            this.d3.Location = new System.Drawing.Point(643, 3);
            this.d3.Name = "d3";
            this.d3.Size = new System.Drawing.Size(0, 20);
            this.d3.TabIndex = 6;
            // 
            // d2
            // 
            this.d2.AutoSize = true;
            this.d2.Location = new System.Drawing.Point(368, 3);
            this.d2.Name = "d2";
            this.d2.Size = new System.Drawing.Size(0, 20);
            this.d2.TabIndex = 6;
            // 
            // button_calc_determinant
            // 
            this.button_calc_determinant.Location = new System.Drawing.Point(175, 73);
            this.button_calc_determinant.Name = "button_calc_determinant";
            this.button_calc_determinant.Size = new System.Drawing.Size(125, 29);
            this.button_calc_determinant.TabIndex = 4;
            this.button_calc_determinant.Text = "Определители";
            this.button_calc_determinant.UseVisualStyleBackColor = true;
            this.button_calc_determinant.Click += new System.EventHandler(this.button_calc_determinant_Click);
            // 
            // button_build_on_assignment
            // 
            this.button_build_on_assignment.Location = new System.Drawing.Point(175, 38);
            this.button_build_on_assignment.Name = "button_build_on_assignment";
            this.button_build_on_assignment.Size = new System.Drawing.Size(125, 30);
            this.button_build_on_assignment.TabIndex = 3;
            this.button_build_on_assignment.Text = "По заданию";
            this.button_build_on_assignment.UseVisualStyleBackColor = true;
            this.button_build_on_assignment.Click += new System.EventHandler(this.button_build_on_assignment_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "X";
            // 
            // textBox_X
            // 
            this.textBox_X.Location = new System.Drawing.Point(50, 7);
            this.textBox_X.Name = "textBox_X";
            this.textBox_X.Size = new System.Drawing.Size(119, 27);
            this.textBox_X.TabIndex = 0;
            this.textBox_X.Text = "2";
            // 
            // textBox_matrix_size
            // 
            this.textBox_matrix_size.Location = new System.Drawing.Point(50, 40);
            this.textBox_matrix_size.Name = "textBox_matrix_size";
            this.textBox_matrix_size.Size = new System.Drawing.Size(119, 27);
            this.textBox_matrix_size.TabIndex = 0;
            this.textBox_matrix_size.Text = "2";
            // 
            // button_build
            // 
            this.button_build.Location = new System.Drawing.Point(175, 6);
            this.button_build.Name = "button_build";
            this.button_build.Size = new System.Drawing.Size(125, 29);
            this.button_build.TabIndex = 1;
            this.button_build.Text = "Построить";
            this.button_build.UseVisualStyleBackColor = true;
            this.button_build.Click += new System.EventHandler(this.build_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView_M3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView_M1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView_M2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 320);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // dataGridView_M3
            // 
            this.dataGridView_M3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_M3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_M3.Location = new System.Drawing.Point(535, 3);
            this.dataGridView_M3.Name = "dataGridView_M3";
            this.dataGridView_M3.RowHeadersWidth = 51;
            this.dataGridView_M3.Size = new System.Drawing.Size(262, 314);
            this.dataGridView_M3.TabIndex = 6;
            // 
            // dataGridView_M1
            // 
            this.dataGridView_M1.ColumnHeadersHeight = 29;
            this.dataGridView_M1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_M1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_M1.Name = "dataGridView_M1";
            this.dataGridView_M1.RowHeadersWidth = 51;
            this.dataGridView_M1.RowTemplate.Height = 29;
            this.dataGridView_M1.Size = new System.Drawing.Size(260, 314);
            this.dataGridView_M1.TabIndex = 4;
            // 
            // dataGridView_M2
            // 
            this.dataGridView_M2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_M2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_M2.Location = new System.Drawing.Point(269, 3);
            this.dataGridView_M2.Name = "dataGridView_M2";
            this.dataGridView_M2.RowHeadersWidth = 51;
            this.dataGridView_M2.RowTemplate.Height = 29;
            this.dataGridView_M2.Size = new System.Drawing.Size(260, 314);
            this.dataGridView_M2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_M3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_M1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_M2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView_M1;
        private System.Windows.Forms.DataGridView dataGridView_M3;
        private System.Windows.Forms.DataGridView dataGridView_M2;
        private System.Windows.Forms.TextBox textBox_matrix_size;
        private System.Windows.Forms.Button button_build;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_X;
        private System.Windows.Forms.Button button_build_on_assignment;
        private System.Windows.Forms.Button button_calc_determinant;
        private System.Windows.Forms.Label d3;
        private System.Windows.Forms.Label d2;
    }
}

