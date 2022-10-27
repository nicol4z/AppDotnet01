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
using System.Windows.Navigation;
using System.Windows.Shapes;
using AppDotnet01;

namespace AppDotnet01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BotonConsumoMaterial_Click(object sender, RoutedEventArgs e)
        {
            //Crear Proyecto
            CrearProyecto crearProyecto = new CrearProyecto();
            crearProyecto.Show();
            
        }

        private void BotonMaterial_Click(object sender, RoutedEventArgs e)
        {
            //Crear Tarea
            CrearTarea crearTarea = new CrearTarea();
            crearTarea.Show();
        }

        private void BotonTarea_Click(object sender, RoutedEventArgs e)
        {
            //Modificar Tarea
            ModificarTarea1 modificar = new ModificarTarea1();
            modificar.Show();
        }

        private void BotonProyecto_Click(object sender, RoutedEventArgs e)
        {
            //Asignar Material
            AsignarMaterial1 asignarMaterial = new AsignarMaterial1();
            asignarMaterial.Show();

            

        }
    }
}
