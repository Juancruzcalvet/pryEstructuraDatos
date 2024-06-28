using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructuraDatos
{
    public partial class frmRepasoDeOperaciones : Form
    {
        public frmRepasoDeOperaciones()
        {
            InitializeComponent();
        }
        private void cmbOperaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsBaseDeDatos objBaseDeDatos = new clsBaseDeDatos();
            string consulta = "SELECT * FROM LIBRO";

            switch (cmbOperaciones.SelectedIndex)
            {
                case 0: //Caso de union A
                    consulta = "SELECT * FROM LIBRO WHERE IDIDIOMA = 1 " + "UNION " + "SELECT * FROM LIBRO WHERE IDIDIOMA = 6 " + "UNION " + "SELECT * FROM LIBRO WHERE IDIDIOMA = 14 ";
                    lblListar.Text = "Libros donde el idioma es inglés, español o portugués.";
                    break;
                case 1: //Union caso B
                    consulta = "SELECT TITULO, AÑO, PRECIO FROM LIBRO WHERE IDAUTOR = 23 " + "UNION " + "SELECT TITULO, AÑO, PRECIO FROM LIBRO WHERE IDAUTOR = 42 " + "UNION " + "SELECT TITULO, AÑO, PRECIO FROM LIBRO WHERE IDAUTOR = 44 ";
                    lblListar.Text = "Libros cuyo autores son William Shakespeare, D. H. Lawrence u Homero";
                    break;
                case 2://Consulta de interseccion A
                    consulta = "SELECT * FROM LIBRO WHERE AÑO < 1500 AND PRECIO > 1000";
                    lblListar.Text = "Libros donde el año de emisión es menor a 1500 y con un precio mayor a 1000";
                    break;
                case 3: //Consulta de interseccion B
                    consulta = "SELECT * FROM LIBRO WHERE IDIDIOMA = 6 AND CANTIDAD > 3";
                    lblListar.Text = "Libros en español con un stock mayor a 3";
                    break;
                case 4: //Consulta de diferencia A
                    consulta = "SELECT * FROM LIBRO WHERE IDAUTOR NOT IN (SELECT DISTINCT IDAUTOR FROM LIBRO WHERE IDAUTOR = 10)";
                    lblListar.Text = "Libros donde el autor no sea Edgar Allan Poe";
                    break;
                case 5: //Consulta de diferencia B
                    consulta = "SELECT * FROM LIBRO WHERE IDIDIOMA NOT IN (SELECT DISTINCT IDIDIOMA FROM LIBRO WHERE IDIDIOMA < 24) ";
                    lblListar.Text = "Libros donde el idioma es griego o griego moderno";
                    break;
                case 6: //Consulta de seleccion simple A
                    consulta = "SELECT TITULO, CANTIDAD FROM LIBRO WHERE IDIDIOMA = 6 ";
                    lblListar.Text = "Titulo y cantidad de libros donde el idioma es español";
                    break;
                case 7: //Consulta de seleccion simple B
                    consulta = "SELECT TITULO, PRECIO FROM LIBRO WHERE PRECIO < 500";
                    lblListar.Text = "Titulo y precio de libros más baratos que 500";
                    break;
                case 8: //Consulta de seleccion multiatributo A
                    consulta = "SELECT * FROM LIBRO WHERE CANTIDAD > 3 AND IDIDIOMA = 1";
                    lblListar.Text = "Libros que están en inglés y hay un stock mayor a 3";
                    break;
                case 9: //Consulta de seleccion multiatributo B
                    consulta = "SELECT TITULO, AÑO, PRECIO FROM LIBRO WHERE IDAUTOR = 23 AND CANTIDAD > 1";
                    lblListar.Text = "Libros que de Shakespeare en stock";
                    break;
                case 10://Consulta de seleccion multiatributo por convolusion A
                    consulta = "SELECT * FROM (SELECT * FROM LIBRO AS T1 WHERE T1.IDPAIS = 1) as T2 WHERE T2.IDIDIOMA = 1";
                    lblListar.Text = "Libro donde el idioma es inglés y su país el Reino Unido";
                    break;
                case 11://Consulta de seleccion multiatributo por convolusion B
                    consulta = "SELECT * FROM (SELECT * FROM LIBRO AS T1 WHERE T1.CANTIDAD > 5) as T2 WHERE T2.PRECIO < 300";
                    lblListar.Text = "Selecciona libros donde el stock es mayor a 5 y el precio menor a 300";
                    break;
                case 12: //Ordenado A
                    consulta = "SELECT IDLIBRO, TITULO, IDAUTOR, PRECIO FROM LIBRO ORDER BY PRECIO DESC";
                    lblListar.Text = "Ordena los libros de mayor a menor segun el precio";
                    break;
                case 13://Ordenado B
                    consulta = "SELECT IDLIBRO, TITULO, IDAUTOR, PRECIO FROM LIBRO ORDER BY TITULO ASC";
                    lblListar.Text = "Ordena los libros de manera alfabética";
                    break;
                case 14://Proyeccion por un atributo A
                    consulta = "SELECT TITULO FROM LIBRO";
                    lblListar.Text = "Muestra sólo los titulos de los libros";
                    break;
                case 15: //Proyeccion por un atributo B
                    consulta = "SELECT NOMBRE FROM IDIOMA";
                    lblListar.Text = "Muestra los idiomas registrados";
                    break;
                case 16://Proyección multiatributo A
                    consulta = "SELECT TITULO, PRECIO, CANTIDAD FROM LIBRO";
                    lblListar.Text = "Muestra el nombre, el precio y la cantidad de los libros";
                    break;
                case 17://Proyección multiatributo B
                    consulta = "SELECT IDPAIS , NOMBRE FROM PAIS";
                    lblListar.Text = "Muestra los ID del pais y sus respectivos nombres";
                    break;
                case 18://Consulta juntar A
                    consulta = "SELECT LIBRO.TITULO, LIBRO.CANTIDAD, IDIOMA.NOMBRE AS IDIOMA FROM LIBRO, IDIOMA WHERE LIBRO.IDIDIOMA = IDIOMA.IDIDIOMA";
                    lblListar.Text = "Muestra titulo, cantidad e idioma de los libros";
                    break;
                case 19://Consulta juntar B
                    consulta = "SELECT LIBRO.TITULO, PAIS.NOMBRE AS PAIS FROM LIBRO, PAIS WHERE LIBRO.IDPAIS = PAIS.IDPAIS";
                    lblListar.Text = "Muestra el pais de cada libro segun sus ID";
                    break;
            } 
            objBaseDeDatos.Listar(dgvBaseDatos, consulta);
        }
    }
}
