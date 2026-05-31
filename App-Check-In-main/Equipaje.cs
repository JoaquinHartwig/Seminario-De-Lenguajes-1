using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Check_In
{
    internal class Equipaje
    {
        private double  _pesoKg;
        private string _id;


        public Equipaje(double pesoKg, string id) // constructor
        {
            _pesoKg = pesoKg;
            _id = id;
        }

        public double pesoKg {  get { return _pesoKg; }}
    }
}
