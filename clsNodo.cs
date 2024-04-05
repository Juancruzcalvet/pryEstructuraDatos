using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryEstructuraDatos
{
    internal class clsNodo
    {
        //Propiedades del nodo
        private string nom;
        private string tra;
        private Int32 cod;

        //Get busca la variable
        //Set establece la variable
        public Int32 Codigo
        {
            get {return cod;}
            set { cod = value;}
        }
        public string Nombre
        {
            get { return nom; }
            set { nom = value; }
        }
        public string Tra
        {
            get { return tra; }
            set { tra = value; }
        }
            }
}
