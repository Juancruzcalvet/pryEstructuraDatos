using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryEstructuraDatos
{
    internal class clsCola
    {
        //Instanciamos clases
        private clsNodo pri;
        private clsNodo ult;







        //Les damos sus respectivos valores
        public clsNodo Primero
        {
            get { return pri; }
            set { pri = value; }
        }
        public clsNodo Ultimo
        {
            get { return ult; }
            set { ult = value; }
        }

        //Agregamos un nodo
        public void Agregar(clsNodo Nuevo) 
        {
            if (Primero == null) //Si no hay nadie en la lista, el nuevo es ultimo y primero
            {
                Primero = Nuevo;
                Ultimo = Nuevo;
            }
            else //Si ya hay cola, enganchamos al ultimo con el nuevo, y luego el nuevo es ultimo.
            {
                Ultimo.Siguiente = Nuevo;
                Ultimo = Nuevo;
            }
        }
        public void Eliminar()
        {
            if (Primero == Ultimo) //Si es el unico en la lista, tenemos que nulificar primero y ultimo
            {
                Primero = null;
                Ultimo = null;
            }
            else //Si ya hay fila, pasamos el siguiente a primero.
            {
                Primero = Primero.Siguiente;
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
            StreamWriter AD = new StreamWriter("Cola.csv", false, Encoding.UTF8); //Creamos archivo.
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
