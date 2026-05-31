using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Check_In.Modelos
{
    public class Pasajeros
    {
        private string _nombre;
        private string _apellido;
        private string _dni;
        private string _pasajerosfrecuentes;
        private List<Equipaje> _equipajes = new List<Equipaje>();

        public Pasajeros(string nombre, string apellido, string dni, string pasajerosfrecuentes) // constrvuctor
        {
            _nombre = nombre;
            _apellido = apellido;
            _dni = dni;
            _pasajerosfrecuentes = pasajerosfrecuentes;

        }


        public string Nombre
        {
            get { return _nombre; }
            set
            {
                if (value != string.Empty)
                {

                    _nombre = value;
                }
            }
        }
        public string Apellido
        {
            get { return _apellido; }
            set
            {
                if (value != string.Empty)
                {
                    _apellido = value;
                }
            }
        }
        public string Dni
        {
            get { return _dni; }
            set { _dni = value; }
            {
                if (value != string.Empty)
                {
                    _dni = value;
                }
            }
        }
        public string Pasajerosfrecuentes
        {
            get { return _pasajerosfrecuentes; }
            set
            {
                if (value != string.Empty)
                {
                    _pasajerosfrecuentes = value;
                }
            }
       
        
        }
         public List<Equipaje> GetEquipajes()
            { return _equipajes; }


        public void AgregarEquipaje(Equipaje equipaje)
        {
            _equipajes.Add(equipaje);

    }

    }
} 

 