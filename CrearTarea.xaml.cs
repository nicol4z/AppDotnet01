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
    /// Lógica de interacción para CrearTarea.xaml
    /// </summary>
    public partial class CrearTarea : Window
    {
        int Indice;
        public CrearTarea()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void BotonIngresar_Click(object sender, RoutedEventArgs e)
        {
           
            if(string.IsNullOrEmpty(Nombre.Text) || string.IsNullOrEmpty(Estado.Text) ||
                string.IsNullOrEmpty(Avance.Text) || string.IsNullOrEmpty(Proyectos.Text))
            {
                MessageBox.Show("Ningun campo puede estar vacio");
            }
            else
            {
                Contexto contexto = new Contexto();

                Tarea tarea = new Tarea() { nombre = Nombre.Text , estado = Estado.Text, avance = Avance.Text, IDProyecto = AsignarId()};
                contexto.Tareas.Add(tarea);
                contexto.SaveChanges();
          

            }
            Nombre.Clear();
            Estado.Clear();
            Avance.Clear();
            Proyectos.SelectedItem = null;
            
        }

        public void CargarDatos()
        {
            Contexto contexto = new Contexto();
            List<Proyecto> proyectos = contexto.Proyectos.ToList();
            

            foreach (Proyecto p in proyectos)
            {
                Proyectos.Items.Add(p.nombre);
            }
        }

        public int AsignarId()
        {
            Contexto contexto = new Contexto();
            List<Proyecto> proyectos = contexto.Proyectos.ToList();
            int idProyecto = 0;
            foreach(Proyecto p in proyectos)
            {
                if (p.nombre == Proyectos.Text)
                {
                    idProyecto = p.Id;
                }
            }
            return idProyecto;
        }
    }
}
