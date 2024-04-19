using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryEstructuraDatos
{
    internal class clsListaDoble
    {
        private clsNodo Pri;
        private clsNodo Ult;
        public clsNodo Primero
        {
            get { return Pri; }
            set { Pri = value; }
        }
        public clsNodo Ultimo
        {
            get { return Ult; }
            set { Ult = value; }
        }
        public void Agregar(clsNodo Nuevo)
        {
            if (Primero == null)
            {
                Primero = Nuevo;
                Ultimo = Nuevo;
            }
            else
            {
                if(Nuevo.Codigo < Primero.Codigo)
                {
                    Primero.Anterior = Nuevo;
                    Nuevo.Siguiente = Primero;
                    Primero = Nuevo;
                }
                else
                {
                    if(Nuevo.Codigo > Ultimo.Codigo)
                    {
                        Nuevo.Anterior = Ultimo;
                        Ultimo.Siguiente= Nuevo;
                        Ultimo = Nuevo;
                    }
                    else
                    {
                        clsNodo Sig = Primero;
                        clsNodo Ant = Primero;
                        while (Nuevo.Codigo > Sig.Codigo && Sig != null)
                        {
                            Ant = Sig;
                            Sig = Sig.Siguiente;
                        }
                        Ant.Siguiente = Nuevo;
                        Nuevo.Siguiente = Sig;
                        Nuevo.Anterior = Ant;
                        Sig.Anterior = Nuevo;
                    }

                }
            }
        }
        public void Eliminar(Int32 Numero)
        {
            if (Primero.Codigo == Numero)
            {
                Primero = Primero.Siguiente;
            }
            else
            {
                if(Ultimo.Codigo == Numero)
                {
                    Ultimo = Ultimo.Anterior;
                }
                else
                {
                    clsNodo Aux = Primero;
                    clsNodo Ant = Primero;
                    while (Aux.Codigo != Numero)
                    {
                        Ant = Aux;
                        Aux = Aux.Siguiente;
                    }
                    Ant.Siguiente = Aux.Siguiente;
                    Aux = Aux.Siguiente;
                    Aux.Anterior = Ant;

                    // - Ant Aux -
                }
            }
        }
        public void Recorrer(DataGridView Grilla)
        {
            clsNodo Aux = Primero; //Declaramos aux para que recorra. Si recorremos con primero sería lo mismo que borrar los datos.
            Grilla.Rows.Clear(); //Borramos lo anteriormente puesto en la grilla.
            while (Aux != null) //Recorremos mientras haya datos
            {
                Grilla.Rows.Add(Aux.Codigo, Aux.Nombre, Aux.Tramite);
                Aux = Aux.Siguiente; //Esto rompe el while.
            }
        }      
        public void RecorrerDescendiente(DataGridView Grilla)
        {
            clsNodo Aux = Ultimo; //Declaramos aux para que recorra. Si recorremos con primero sería lo mismo que borrar los datos.
            Grilla.Rows.Clear(); //Borramos lo anteriormente puesto en la grilla.
            while (Aux != null) //Recorremos mientras haya datos
            {
                Grilla.Rows.Add(Aux.Codigo, Aux.Nombre, Aux.Tramite);
                Aux = Aux.Anterior; //Esto rompe el while.
            }
        }
        public void Recorrer(ListBox Lista)
        {
            clsNodo Aux = Primero;
            Lista.Items.Clear();
            while (Aux != null)
            {
                Lista.Items.Add(Aux.Codigo);
                Aux = Aux.Siguiente;
            }

        }
        public void Recorrer(ComboBox Combo)
        {
            clsNodo Aux = Primero;
            Combo.Items.Clear();
            while (Aux != null)
            {
                Combo.Items.Add(Aux.Nombre);
                Aux = Aux.Siguiente;
            }

        }
        public void Recorrer()
        {
            clsNodo Aux = Primero;
            StreamWriter AD = new StreamWriter("ListaDoble.csv", false, Encoding.UTF8); //Creamos archivo.
            AD.WriteLine("Lista de espera \n"); //Este será el título.
            AD.WriteLine("Código;Nombre;Trámite"); //Encabezado de los distintos datos.
            while (Aux != null)
            {
                AD.Write(Aux.Codigo); //Escribe distintos datos del nodo.
                AD.Write(";"); //Separamos los datos
                AD.Write(Aux.Nombre);
                AD.Write(";");
                AD.WriteLine(Aux.Tramite); //Atencion a writeline aca, separa los distintos nodos entre si.
                Aux = Aux.Siguiente;
            }
            AD.Close(); //Cerrar archivo para evitar errores.

        }
    }
}
