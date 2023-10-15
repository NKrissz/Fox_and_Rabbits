namespace Fox_And_Rabbits
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
            tb_rows = new TextBox();
            tb_cols = new TextBox();
            bt_generate = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tb_rows
            // 
            tb_rows.Location = new Point(755, 340);
            tb_rows.Name = "tb_rows";
            tb_rows.Size = new Size(31, 23);
            tb_rows.TabIndex = 0;
            // 
            // tb_cols
            // 
            tb_cols.Location = new Point(424, 340);
            tb_cols.Name = "tb_cols";
            tb_cols.Size = new Size(31, 23);
            tb_cols.TabIndex = 1;
            // 
            // bt_generate
            // 
            bt_generate.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            bt_generate.Location = new Point(424, 430);
            bt_generate.Name = "bt_generate";
            bt_generate.Size = new Size(244, 75);
            bt_generate.TabIndex = 2;
            bt_generate.Text = "Generálás!";
            bt_generate.UseVisualStyleBackColor = true;
            bt_generate.Click += Button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 60F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(305, 184);
            label1.Name = "label1";
            label1.Size = new Size(468, 90);
            label1.TabIndex = 3;
            label1.Text = "Game of Life";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(252, 340);
            label2.Name = "label2";
            label2.Size = new Size(166, 19);
            label2.TabIndex = 4;
            label2.Text = "Adja meg a sorok számát:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(557, 340);
            label3.Name = "label3";
            label3.Size = new Size(192, 19);
            label3.TabIndex = 5;
            label3.Text = "Adja meg az oszlopok számát:";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Location = new Point(392, 200);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(314, 305);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(1098, 690);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(bt_generate);
            Controls.Add(tb_cols);
            Controls.Add(tb_rows);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Fox & Rabbits";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_rows;
        private TextBox tb_cols;
        private Button bt_generate;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
    }
}