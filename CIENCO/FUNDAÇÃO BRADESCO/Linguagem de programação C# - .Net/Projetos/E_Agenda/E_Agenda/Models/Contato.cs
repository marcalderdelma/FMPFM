using System.Text;

namespace E_Agenda.Models {
    public class Contato {
        public int id { get { return id; } set { id = value; } }
        public string nome { get { return nome; } set { nome = value; } }
        public string sobrenome { get { return sobrenome; } set { sobrenome = value; } }
        public string telefone { get { return telefone; } set { telefone = value; } }
        public string email { get { return email; } set { email = value; } }
        private string nomeCompleto;

        public Contato(/*int id, */string nome, string sobrenome, string telefone, string email)
        {
            //this.id = id;
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.telefone = telefone;
            this.email = email;
            nomeCompleto = $"{nome} {sobrenome}";
        }

        public string NomeCompleto(string nome, string sobrenome)
        {
            return $"{nome} {sobrenome}";
        }
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append(id)
                   .Append(", ")
                   .Append(NomeCompleto(nome,sobrenome).ToString())
                   .Append(", ")
                   .Append(telefone)
                   .Append(", ")
                   .Append(email);
            return builder.ToString();
        }
    }
}
