using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Johan_Modul9
{
    public class AkunPremium : Akun
    {
        public AkunPremium(int saldo, string password) : base(saldo, password)
        {
            this.password = password;
            Saldo = saldo;
        }

        public new int Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                    throw new InvalidOperationException("Saldo tidak bisa kurang dari 0 rupiah");
                else
                    _saldo = value;
            }
        }

        public override void Setor(int jumlah)
        {
            Saldo += jumlah + 500;
        }

        public override void Tarik(int jumlah) 
        {
            Saldo -= jumlah + 500;
        }
    }
}
