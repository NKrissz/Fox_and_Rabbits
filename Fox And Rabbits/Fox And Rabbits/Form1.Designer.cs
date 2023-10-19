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
            bt_generate = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            lbl_RabbitCount = new Label();
            btn_Exit = new Button();
            lbl_rounds = new Label();
            lbl_foxcounter = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // bt_generate
            // 
            bt_generate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bt_generate.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            bt_generate.Location = new Point(471, 415);
            bt_generate.Name = "bt_generate";
            bt_generate.Size = new Size(244, 75);
            bt_generate.TabIndex = 2;
            bt_generate.Text = "Generálás!";
            bt_generate.UseVisualStyleBackColor = true;
            bt_generate.Click += Btn_generate_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 60F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(336, 178);
            label1.Name = "label1";
            label1.Size = new Size(468, 90);
            label1.TabIndex = 3;
            label1.Text = "Game of Life";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Location = new Point(503, 151);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(383, 425);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // lbl_RabbitCount
            // 
            lbl_RabbitCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_RabbitCount.AutoSize = true;
            lbl_RabbitCount.ForeColor = SystemColors.ButtonFace;
            lbl_RabbitCount.Location = new Point(941, 19);
            lbl_RabbitCount.Name = "lbl_RabbitCount";
            lbl_RabbitCount.Size = new Size(92, 15);
            lbl_RabbitCount.TabIndex = 7;
            lbl_RabbitCount.Text = "A nyulak száma:";
            lbl_RabbitCount.Visible = false;
            // 
            // btn_Exit
            // 
            btn_Exit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_Exit.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Exit.Location = new Point(911, 723);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(244, 75);
            btn_Exit.TabIndex = 2;
            btn_Exit.Text = "Kilépés!";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += Btn_Exit_Click;
            // 
            // lbl_rounds
            // 
            lbl_rounds.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_rounds.AutoSize = true;
            lbl_rounds.BackColor = Color.Transparent;
            lbl_rounds.ForeColor = SystemColors.ButtonFace;
            lbl_rounds.Location = new Point(941, 58);
            lbl_rounds.Name = "lbl_rounds";
            lbl_rounds.Size = new Size(77, 15);
            lbl_rounds.TabIndex = 8;
            lbl_rounds.Text = "Körök száma:";
            lbl_rounds.Visible = false;
            // 
            // lbl_foxcounter
            // 
            lbl_foxcounter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_foxcounter.AutoSize = true;
            lbl_foxcounter.BackColor = Color.Transparent;
            lbl_foxcounter.ForeColor = SystemColors.ButtonFace;
            lbl_foxcounter.Location = new Point(941, 92);
            lbl_foxcounter.Name = "lbl_foxcounter";
            lbl_foxcounter.Size = new Size(86, 15);
            lbl_foxcounter.TabIndex = 9;
            lbl_foxcounter.Text = "A rókák száma:";
            lbl_foxcounter.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Peru;
            ClientSize = new Size(1167, 810);
            Controls.Add(lbl_foxcounter);
            Controls.Add(lbl_rounds);
            Controls.Add(lbl_RabbitCount);
            Controls.Add(label1);
            Controls.Add(btn_Exit);
            Controls.Add(bt_generate);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fox & Rabbits";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button bt_generate;
        private Label label1;
        private PictureBox pictureBox1;
        private Label lbl_RabbitCount;
        private Button btn_Exit;
        private Label lbl_rounds;
        private Label lbl_foxcounter;
    }
}