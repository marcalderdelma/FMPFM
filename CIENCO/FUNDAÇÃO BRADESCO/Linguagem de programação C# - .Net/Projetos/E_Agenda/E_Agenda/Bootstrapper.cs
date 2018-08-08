using System;
using Caliburn.Micro;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using E_Agenda.ViewModels;
using E_Agenda.Models;

namespace E_Agenda {
    public class Bootstrapper : BootstrapperBase {
        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();
            //ShellViewModel.listContato.Add(new Contato("Marc-Alder", "Delma", "19983863229", "marcalderdema.mad@gmail.com"));
        }
    }
}
