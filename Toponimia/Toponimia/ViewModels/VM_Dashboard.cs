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
            OpenPageNewDistrito = new Command(async () =>
            {
                await Application.Current.MainPage.Navigation.PushAsync(new Views.InserirDistrito());
            });
            OpenPageNewConcelho = new Command(() =>
            {

            });
            OpenPageNewFreguesia = new Command(() =>
            {

            });
            OpenPageNewToponimo = new Command(() =>
            {

            });
        }

        public Command OpenPageNewDistrito { get; }
        public Command OpenPageNewConcelho { get; }
        public Command OpenPageNewFreguesia { get; }
        public Command OpenPageNewToponimo { get; }
    }
}
