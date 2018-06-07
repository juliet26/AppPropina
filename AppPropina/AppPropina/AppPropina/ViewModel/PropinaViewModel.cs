namespace AppPropina.ViewModel
{
    using AppPropina.Model;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Xamarin.Forms;

    public class PropinaViewModel
    {
        #region Propiedades
        public Propina PropinaModel { get; set; }
        public Command CalcularCommand { get; set; }
        #endregion

        #region Constructor
        public PropinaViewModel()
        {
            PropinaModel = new Propina();
            CalcularCommand = new Command(Calcular);
        }
        #endregion

        private void Calcular(object obj)
        {
            PropinaModel.PropinaTotal = (PropinaModel.Total * PropinaModel.PorcentajePropina) / 100;
            PropinaModel.TotalCuenta = PropinaModel.Total + PropinaModel.PropinaTotal;
            PropinaModel.PropinaPersona = PropinaModel.PropinaTotal / PropinaModel.Personas;
            PropinaModel.TotalPersonas = PropinaModel.Total / PropinaModel.Personas;
        }
    }
}
