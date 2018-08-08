using System;
using System.Text;

namespace Agenda {
    class Contato {
        private int id;
        private string nome;
        private string telefone;
        private string email;

        public int Id {
            get => id;
            set { id = value; }
        }
        public string Nome {
            get => nome;
            set { nome = value; }
        }
        public string Telefone {
            get => telefone;
            set { telefone = value; }
        }
        public string Email {
            get => email;
            set { email = value; }
        }
        public Contato(int id, string nome, string telefone, string email)
        {
            this.id = id;
            this.nome = nome;
            this.telefone = telefone;
            this.email = email;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            try{
                builder.Append(id)
                       .Append("\t")
                       .Append(nome)
                       .Append("\t")
                       .Append(telefone)
                       .Append("\t")
                       .Append(email)
                       .Append("\r\n");
            } catch (Exception e) {
                throw e;
            }
            return builder.ToString();
        }
        public bool CompareTo(object obj)
        {
            Contato outro = (Contato)obj;
            
            if (nome.Equals(outro.nome)) return true;
            return false;
        }
    }
}
