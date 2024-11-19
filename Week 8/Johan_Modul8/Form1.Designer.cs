namespace Johan_Modul8
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
            Label Alamat;
            label1 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            txtAlamat = new TextBox();
            txtNo_handphone = new TextBox();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dgvData = new DataGridView();
            label3 = new Label();
            btnLoaddata = new Button();
            btnQR = new Button();
            Alamat = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // Alamat
            // 
            Alamat.AutoSize = true;
            Alamat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Alamat.Location = new Point(12, 138);
            Alamat.Name = "Alamat";
            Alamat.Size = new Size(65, 21);
            Alamat.TabIndex = 1;
            Alamat.Text = "Alamat";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 95);
            label1.Name = "label1";
            label1.Size = new Size(56, 21);
            label1.TabIndex = 0;
            label1.Text = "Nama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 178);
            label2.Name = "label2";
            label2.Size = new Size(127, 21);
            label2.TabIndex = 2;
            label2.Text = "No Handphone";
            // 
            // txtName
            // 
            txtName.Location = new Point(148, 95);
            txtName.Name = "txtName";
            txtName.Size = new Size(253, 23);
            txtName.TabIndex = 3;
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(148, 136);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(253, 23);
            txtAlamat.TabIndex = 4;
            // 
            // txtNo_handphone
            // 
            txtNo_handphone.Location = new Point(148, 176);
            txtNo_handphone.Name = "txtNo_handphone";
            txtNo_handphone.Size = new Size(253, 23);
            txtNo_handphone.TabIndex = 5;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.LightGray;
            btnInsert.FlatStyle = FlatStyle.Popup;
            btnInsert.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsert.Location = new Point(416, 96);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(123, 104);
            btnInsert.TabIndex = 6;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.LightGray;
            btnUpdate.BackgroundImageLayout = ImageLayout.None;
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(545, 96);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(123, 104);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.LightGray;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(674, 95);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(123, 105);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvData
            // 
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(12, 215);
            dgvData.Name = "dgvData";
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new Size(914, 179);
            dgvData.TabIndex = 9;
            dgvData.CellContentClick += dgvData_CellClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(328, 20);
            label3.Name = "label3";
            label3.Size = new Size(155, 37);
            label3.TabIndex = 10;
            label3.Text = "Data Users";
            // 
            // btnLoaddata
            // 
            btnLoaddata.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoaddata.Location = new Point(772, 400);
            btnLoaddata.Name = "btnLoaddata";
            btnLoaddata.Size = new Size(154, 30);
            btnLoaddata.TabIndex = 11;
            btnLoaddata.Text = "Load Data";
            btnLoaddata.UseVisualStyleBackColor = true;
            btnLoaddata.Click += btnLoaddata_Click;
            // 
            // btnQR
            // 
            btnQR.BackColor = Color.LightGray;
            btnQR.FlatStyle = FlatStyle.Popup;
            btnQR.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnQR.Location = new Point(803, 95);
            btnQR.Name = "btnQR";
            btnQR.Size = new Size(123, 105);
            btnQR.TabIndex = 12;
            btnQR.Text = "Generate QR";
            btnQR.UseVisualStyleBackColor = false;
            btnQR.Click += btnQR_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 437);
            Controls.Add(btnQR);
            Controls.Add(btnLoaddata);
            Controls.Add(label3);
            Controls.Add(dgvData);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(txtNo_handphone);
            Controls.Add(txtAlamat);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(Alamat);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dgvData;
        private Label label3;
        private Button btnLoaddata;
        private Button btnQR;
        public TextBox txtName;
        public TextBox txtAlamat;
        public TextBox txtNo_handphone;
    }
}