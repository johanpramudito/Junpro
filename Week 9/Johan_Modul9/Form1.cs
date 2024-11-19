namespace Johan_Modul9
{
    public partial class Form1 : Form
    {
        Akun akun1 = new AkunPremium(20000, "hiyahiyahiya");
        public Form1()
        {
            InitializeComponent();
            lblSaldo.Text = akun1.Saldo.ToString();
        }
        private void TarikSaldo(int total)
        {
            akun1.Tarik(total);
            lblSaldo.Text = akun1.Saldo.ToString();
        }
        private void SetorSaldo(int total)
        {
            akun1.Setor(total);
            lblSaldo.Text = akun1.Saldo.ToString();
        }

        private void btnLanjut_Click(object sender, EventArgs e)
        {
            if (akun1.PasswordTervalidasi(tbPassword.Text))
            {
                if (rbSetor.Checked)
                    SetorSaldo(int.Parse(tbUang.Text));
                else if (rbTarik.Checked)
                    TarikSaldo(int.Parse(tbUang.Text));
            }
            else
            {
                MessageBox.Show("Password salah");
            }
        }
    }
}

