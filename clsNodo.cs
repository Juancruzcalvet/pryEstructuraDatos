using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryEstructuraDatos
{
    internal class clsNodo
    {
        //Propiedades del nodo
        private string nom;
        private string tra;
        private Int32 cod;
        private clsNodo sig; 
        private clsNodo ant;

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
        public string Tramite
        {
            get { return tra; }
            set { tra = value; }
        }
        //Para saber cual nodo va siguiente. "Conecta el eslabon"
        public clsNodo Siguiente
        {
            get { return sig; }
            set { sig = value; }
        }
        public clsNodo Anterior
        {
            get { return ant; }
            set { ant = value; }
        }
        public clsNodo Izquierdo
        {
            get { return ant; }
            set { ant = value; }
        }
        public clsNodo Derecho
        {
            get { return sig; }
            set { sig = value; }
        }

    }
}
