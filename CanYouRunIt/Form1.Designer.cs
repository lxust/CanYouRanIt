namespace CanYouRunIt
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbOpMemory = new System.Windows.Forms.TextBox();
            this.tbMemory = new System.Windows.Forms.TextBox();
            this.tbCPU = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbVidioMemory = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MEMORY1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Memory2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Memory3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Memory4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ваш компьютер";
            // 
            // tbOpMemory
            // 
            this.tbOpMemory.Location = new System.Drawing.Point(145, 40);
            this.tbOpMemory.Name = "tbOpMemory";
            this.tbOpMemory.Size = new System.Drawing.Size(100, 23);
            this.tbOpMemory.TabIndex = 1;
            // 
            // tbMemory
            // 
            this.tbMemory.Location = new System.Drawing.Point(145, 69);
            this.tbMemory.Name = "tbMemory";
            this.tbMemory.Size = new System.Drawing.Size(100, 23);
            this.tbMemory.TabIndex = 2;
            // 
            // tbCPU
            // 
            this.tbCPU.Location = new System.Drawing.Point(145, 98);
            this.tbCPU.Name = "tbCPU";
            this.tbCPU.Size = new System.Drawing.Size(100, 23);
            this.tbCPU.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Оперативная память: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Место на диске: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Процессор: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Видио память: ";
            // 
            // tbVidioMemory
            // 
            this.tbVidioMemory.Location = new System.Drawing.Point(145, 128);
            this.tbVidioMemory.Name = "tbVidioMemory";
            this.tbVidioMemory.Size = new System.Drawing.Size(100, 23);
            this.tbVidioMemory.TabIndex = 9;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(170, 157);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 10;
            this.btnFind.Text = "Найти";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.MEMORY1,
            this.Memory2,
            this.Memory3,
            this.Memory4});
            this.dataGridView1.Location = new System.Drawing.Point(12, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(543, 150);
            this.dataGridView1.TabIndex = 11;
            // 
            // Name
            // 
            this.Name.HeaderText = "Название игры";
            this.Name.Name = "Name";
            // 
            // MEMORY1
            // 
            this.MEMORY1.HeaderText = "Оперативная память";
            this.MEMORY1.Name = "MEMORY1";
            // 
            // Memory2
            // 
            this.Memory2.HeaderText = "Место на диске: ";
            this.Memory2.Name = "Memory2";
            // 
            // Memory3
            // 
            this.Memory3.HeaderText = "Процессор";
            this.Memory3.Name = "Memory3";
            // 
            // Memory4
            // 
            this.Memory4.HeaderText = "Видио память";
            this.Memory4.Name = "Memory4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.tbVidioMemory);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCPU);
            this.Controls.Add(this.tbMemory);
            this.Controls.Add(this.tbOpMemory);
            this.Controls.Add(this.label1);
            //this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tbOpMemory;
        private TextBox tbMemory;
        private TextBox tbCPU;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tbVidioMemory;
        private Button btnFind;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn MEMORY1;
        private DataGridViewTextBoxColumn Memory2;
        private DataGridViewTextBoxColumn Memory3;
        private DataGridViewTextBoxColumn Memory4;
    }
}