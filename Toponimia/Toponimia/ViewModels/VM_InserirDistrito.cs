using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace Toponimia.ViewModels
{
    public class VM_InserirDistrito : VM_Base
    {
        public VM_InserirDistrito()
        {
            CommandInsert = new Command(() =>
            {
                Models.Distrito distrito = new Models.Distrito();
                distrito.Id = Guid.NewGuid();
                distrito.Designacao = Designacao_LocalProperty;
                Services.DataAccess.InserirDistrito(distrito);
                Designacao_LocalProperty = string.Empty;
            });
        }

        private string _Designacao_LocalProperty;
        public string Designacao_LocalProperty
        {
            get { return _Designacao_LocalProperty; }
            set
            {
                _Designacao_LocalProperty = value;

                base.InvokeEvent(this, new PropertyChangedEventArgs(nameof(Designacao_LocalProperty)));
            }
        }

        public Command CommandInsert { get; }
    }
}
