namespace AppPropina.Model
{
    using AppPropina.ViewModel;
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Propina : Notificable
    {
        #region Atributos
        private double total;
        private int personas;
        private double propinaTotal;
        private double totalPersonas;
        private double propinaPersona;
        private double porcentajePropina;
        private double totalCuenta;      
        #endregion

        #region Propiedades
        public double Total
        {
            get {
                return total;
                }
            set { 
            if (total == value)
            {
                    return;
            }
                total = value;
                OnPropertyChanged();
            }
        }
        
        public int Personas
        {
            get {
                return personas;
                }
            set
            {
                if (personas == value)
                {
                    return;
                }
                personas = value;
                OnPropertyChanged();
            }
        }
        
        public double PropinaTotal
        {
            get
            {
                return propinaTotal;
            }
            set
            {
                if (propinaTotal == value)
                {
                    return;
                }
                propinaTotal = value;
                OnPropertyChanged();
            }
        }

        public double TotalPersonas
        {
            get
            {
                return totalPersonas;
            }
            set
            {
                if (totalPersonas == value)
                {
                    return;
                }
                totalPersonas = value;
                OnPropertyChanged();
            }
        }

        public double PropinaPersona
        {
            get
            {
                return propinaPersona;
            }
            set
            {
                if (propinaPersona == value)
                {
                    return;
                }
                propinaPersona = value;
                OnPropertyChanged();
            }
        }

        public double PorcentajePropina
        {
            get
            {
                return porcentajePropina;
            }
            set
            {
                if (porcentajePropina == value)
                {
                    return;
                }
                porcentajePropina = value;
                OnPropertyChanged();
            }
        }

        public double TotalCuenta
        {
            get
            {
                return totalCuenta;
            }
            set
            {
                if (totalCuenta == value)
                {
                    return;
                }
                totalCuenta = value;
                OnPropertyChanged();
            }
        }

        #endregion
    }
}
