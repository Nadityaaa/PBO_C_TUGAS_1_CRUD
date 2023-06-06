namespace TUGAS_PRAKTIKUM
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Admin = new System.Windows.Forms.Label();
            this.btnCreateNewData = new System.Windows.Forms.Button();
            this.btnReadDataLaptop = new System.Windows.Forms.Button();
            this.btnCreateTransaction = new System.Windows.Forms.Button();
            this.btnReadDataTransaction = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Desktop;
            this.dataGridView1.Location = new System.Drawing.Point(342, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(446, 333);
            this.dataGridView1.TabIndex = 0;
            // 
            // Admin
            // 
            this.Admin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Admin.Font = new System.Drawing.Font("Franklin Gothic Heavy", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin.Location = new System.Drawing.Point(152, 23);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(511, 64);
            this.Admin.TabIndex = 1;
            this.Admin.Text = "Welcome Back ^_^";
            this.Admin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCreateNewData
            // 
            this.btnCreateNewData.BackColor = System.Drawing.Color.Silver;
            this.btnCreateNewData.Font = new System.Drawing.Font("Franklin Gothic Demi", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateNewData.Location = new System.Drawing.Point(38, 131);
            this.btnCreateNewData.Name = "btnCreateNewData";
            this.btnCreateNewData.Size = new System.Drawing.Size(257, 50);
            this.btnCreateNewData.TabIndex = 2;
            this.btnCreateNewData.Text = "Create New Data Laptop";
            this.btnCreateNewData.UseVisualStyleBackColor = false;
            this.btnCreateNewData.Click += new System.EventHandler(this.btnCreateNewData_Click);
            // 
            // btnReadDataLaptop
            // 
            this.btnReadDataLaptop.BackColor = System.Drawing.Color.Silver;
            this.btnReadDataLaptop.Font = new System.Drawing.Font("Franklin Gothic Demi", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadDataLaptop.Location = new System.Drawing.Point(38, 282);
            this.btnReadDataLaptop.Name = "btnReadDataLaptop";
            this.btnReadDataLaptop.Size = new System.Drawing.Size(257, 51);
            this.btnReadDataLaptop.TabIndex = 3;
            this.btnReadDataLaptop.Text = "Read Data Laptop";
            this.btnReadDataLaptop.UseVisualStyleBackColor = false;
            this.btnReadDataLaptop.Click += new System.EventHandler(this.btnReadDataLaptop_Click);
            // 
            // btnCreateTransaction
            // 
            this.btnCreateTransaction.BackColor = System.Drawing.Color.Silver;
            this.btnCreateTransaction.Font = new System.Drawing.Font("Franklin Gothic Demi", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTransaction.Location = new System.Drawing.Point(38, 206);
            this.btnCreateTransaction.Name = "btnCreateTransaction";
            this.btnCreateTransaction.Size = new System.Drawing.Size(257, 50);
            this.btnCreateTransaction.TabIndex = 4;
            this.btnCreateTransaction.Text = "Create New Transaction";
            this.btnCreateTransaction.UseVisualStyleBackColor = false;
            this.btnCreateTransaction.Click += new System.EventHandler(this.btnCreateTransaction_Click);
            // 
            // btnReadDataTransaction
            // 
            this.btnReadDataTransaction.BackColor = System.Drawing.Color.Silver;
            this.btnReadDataTransaction.Font = new System.Drawing.Font("Franklin Gothic Demi", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadDataTransaction.Location = new System.Drawing.Point(38, 358);
            this.btnReadDataTransaction.Name = "btnReadDataTransaction";
            this.btnReadDataTransaction.Size = new System.Drawing.Size(257, 51);
            this.btnReadDataTransaction.TabIndex = 5;
            this.btnReadDataTransaction.Text = "Read Data Transaction";
            this.btnReadDataTransaction.UseVisualStyleBackColor = false;
            this.btnReadDataTransaction.Click += new System.EventHandler(this.btnReadDataTransaction_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReadDataTransaction);
            this.Controls.Add(this.btnCreateTransaction);
            this.Controls.Add(this.btnReadDataLaptop);
            this.Controls.Add(this.btnCreateNewData);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Admin;
        private System.Windows.Forms.Button btnCreateNewData;
        private System.Windows.Forms.Button btnReadDataLaptop;
        private System.Windows.Forms.Button btnCreateTransaction;
        private System.Windows.Forms.Button btnReadDataTransaction;
    }
}

