using System.Collections.Generic;
using Caliburn.Micro;
using E_Agenda.Models;

namespace E_Agenda.ViewModels {
    class ShellViewModel : Screen {
        private string _nome;
        public static List<Contato> listContato = new List<Contato>();
        public string Nome
        {
            get {
                return _nome;
            }
            set {
                _nome = value;
                NotifyOfPropertyChange(() => Nome);
                NotifyOfPropertyChange(() => NomeCompleto);
            }
        }
        private string _sobrenome;
        
        public string Sobrenome
        {
            get {
                return _sobrenome;
            }
            set {
                _sobrenome = value;
                NotifyOfPropertyChange(() => Sobrenome);
                NotifyOfPropertyChange(() => NomeCompleto);
            }
        }
        
        public string NomeCompleto
        {
            get
            {
                return $"{Nome} {Sobrenome}";
            }
        }

        private string _telefone;

        public string Telefone
        {
            get {
                return _telefone;
            }
            set {
                _telefone = value;
                NotifyOfPropertyChange(() => Telefone);
            }
        }

        private string _email;

        public string Email
        {
            get {
                return _email;
            }
            set {
                _email = value;
                NotifyOfPropertyChange(() => Email);
            }
        }
   
        public void Save()
        {
            Contato contato;            
            contato = new Contato(Nome, Sobrenome, Telefone, Email);
            listContato.Add(contato);
           
            Clear();
                       
            //Message.SetAttach(null,"");
        }
        public List<Contato> DataGricContato()
        {
            return listContato;
        }
        public void Clear()
        {
            _nome = _sobrenome = _telefone = _email = "";
            NotifyOfPropertyChange(() => Nome);
            NotifyOfPropertyChange(() => Sobrenome);
            NotifyOfPropertyChange(() => NomeCompleto);
            NotifyOfPropertyChange(() => Telefone);
            NotifyOfPropertyChange(() => Email);
        }
        public void EndApp()
        {
            App.Current.Shutdown();
        }      
    }
}
