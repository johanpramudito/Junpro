using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Johan_Modul9
{
    public class Akun
    {
        private const int maxSaldo = 2000000;
        protected int _saldo;
        protected string password;

        public int Saldo { get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                    throw new InvalidOperationException("Saldo tidak bisa kurang dari 0 rupiah");
                else if (value > maxSaldo)
                    throw new InvalidOperationException("Saldo tidak boleh melebihi 2000000 rupiah");
                else
                    _saldo = value;
            }
        }
        public Akun(int saldo, string password)
        {
            _saldo = saldo;
            this.password = password;
        }

        public virtual void Setor(int jumlah)
        {
            Saldo += jumlah;
        }

        public virtual void Tarik(int jumlah)
        {
            Saldo -= jumlah;
        }

        public bool PasswordTervalidasi(string password)
        {
            if (this.password == password)
                return true;
            else 
                return false;
        }
    }
}

