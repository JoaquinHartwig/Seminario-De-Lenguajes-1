using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace WinForm_GestiónAeropuerto.Modelos
{
    public class Pasajero
    {
        private string _nombre;
        private string _apellido;
        private string _nroDocumento;
        private string _nroViajeroFrecuente;
    
        // Definición del constructor
        public Pasajero (string _nombre,
            string _apellido,
            string _nroDocumento,
            string _nroViajeroFrecuente)
         {
            _nombre = nombre;
            _apellido = apellido;
            _nroDocumento = nroDocumento;
            _nroViajeroFrecuente = nroViajeroFrecuente;
         }

         // Definición de las propiedades
         public string nombre
         {
            get { return _nombre; }
            set { _nombre = value; }
         }
         public string apellido
         {
            get { return _apellido; }
            set { _apellido = value; }
         }
         public string nroDocumento
         {
            get { return _nroDocumento; }
            set { _nroDocumento = value; }
         }
         public string nroViajeroFrecuente
         {
            get { return _nroViajeroFrecuente; }
            set { _nroViajeroFrecuente = value; }
         }
    }
}
