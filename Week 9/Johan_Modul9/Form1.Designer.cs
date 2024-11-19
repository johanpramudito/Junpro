namespace Johan_Modul9
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
            lbl1 = new Label();
            lblSaldo = new Label();
            lbl2 = new Label();
            rbSetor = new RadioButton();
            rbTarik = new RadioButton();
            lbl3 = new Label();
            tbUang = new TextBox();
            lbl4 = new Label();
            btnLanjut = new Button();
            tbPassword = new TextBox();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(111, 21);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(107, 15);
            lbl1.TabIndex = 0;
            lbl1.Text = "Saldo Akun Umum";
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblSaldo.Location = new Point(122, 51);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(84, 32);
            lblSaldo.TabIndex = 1;
            lblSaldo.Text = "14132";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(57, 102);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(48, 15);
            lbl2.TabIndex = 2;
            lbl2.Text = "Action :";
            // 
            // rbSetor
            // 
            rbSetor.AutoSize = true;
            rbSetor.Location = new Point(111, 100);
            rbSetor.Name = "rbSetor";
            rbSetor.Size = new Size(52, 19);
            rbSetor.TabIndex = 3;
            rbSetor.TabStop = true;
            rbSetor.Text = "Setor";
            rbSetor.UseVisualStyleBackColor = true;
            // 
            // rbTarik
            // 
            rbTarik.AutoSize = true;
            rbTarik.Location = new Point(170, 100);
            rbTarik.Name = "rbTarik";
            rbTarik.Size = new Size(49, 19);
            rbTarik.TabIndex = 4;
            rbTarik.TabStop = true;
            rbTarik.Text = "Tarik";
            rbTarik.UseVisualStyleBackColor = true;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Location = new Point(23, 133);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(82, 15);
            lbl3.TabIndex = 5;
            lbl3.Text = "Jumlah Uang :";
            // 
            // tbUang
            // 
            tbUang.Location = new Point(111, 130);
            tbUang.Name = "tbUang";
            tbUang.Size = new Size(108, 23);
            tbUang.TabIndex = 6;
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Location = new Point(42, 164);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(63, 15);
            lbl4.TabIndex = 7;
            lbl4.Text = "Password :";
            // 
            // btnLanjut
            // 
            btnLanjut.Location = new Point(225, 161);
            btnLanjut.Name = "btnLanjut";
            btnLanjut.Size = new Size(75, 23);
            btnLanjut.TabIndex = 9;
            btnLanjut.Text = "Lanjut";
            btnLanjut.UseVisualStyleBackColor = true;
            btnLanjut.Click += btnLanjut_Click;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(111, 161);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(107, 23);
            tbPassword.TabIndex = 10;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 205);
            Controls.Add(tbPassword);
            Controls.Add(btnLanjut);
            Controls.Add(lbl4);
            Controls.Add(tbUang);
            Controls.Add(lbl3);
            Controls.Add(rbTarik);
            Controls.Add(rbSetor);
            Controls.Add(lbl2);
            Controls.Add(lblSaldo);
            Controls.Add(lbl1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private Label lblSaldo;
        private Label lbl2;
        private RadioButton rbSetor;
        private RadioButton rbTarik;
        private Label lbl3;
        private TextBox tbUang;
        private Label lbl4;
        private Button btnLanjut;
        private TextBox tbPassword;
    }
}