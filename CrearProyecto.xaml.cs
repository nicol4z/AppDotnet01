using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AppDotnet01
{
    /// <summary>
    /// Lógica de interacción para CrearProyecto.xaml
    /// </summary>
    public partial class CrearProyecto : Window
    {
        public CrearProyecto()
        {
            InitializeComponent();
        }

        private void BotonIngresar_Click(object sender, RoutedEventArgs e)
        {
            Contexto bd = new Contexto();

            if (string.IsNullOrEmpty(NombreProyecto.Text))
            {
                MessageBox.Show("El nombre del proyecto no puede estar vacio");
            }

            if (string.IsNullOrEmpty(EstadoProyecto.Text))
            {
                MessageBox.Show("El estado del proyecto no puede estar vacio");
            }

            else
            {
                Proyecto p = new Proyecto() { nombre = NombreProyecto.Text, estado = EstadoProyecto.Text };

                bd.Proyectos.Add(p);

                bd.SaveChanges();
            }

            NombreProyecto.Clear();
            EstadoProyecto.Clear();

        }
    }
}
