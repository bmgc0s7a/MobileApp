using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace Toponimia.ViewModels
{
    public class VM_Dashboard : VM_Base
    {
        public VM_Dashboard()
        {
            OpenPageGestao = new Command(async () =>
            {
                await Application.Current.MainPage.Navigation.PushAsync(new Views.DefaultPage("Gestão"));
            });
            OpenPageLista = new Command(async () =>
            {
                 await Application.Current.MainPage.Navigation.PushAsync(new Views.DefaultPage("Lista"));
            });
             OpenPagePesquisa = new Command(async () =>
             {
                 await Application.Current.MainPage.Navigation.PushAsync(new Views.DefaultPage("Pesquisa"));
            });
         
        }

        public Command  OpenPageGestao { get; }
        public Command  OpenPageLista { get; }
        public Command  OpenPagePesquisa { get; }
       
    }
}
