using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Lógica de interacción para ModificarTarea1.xaml
    /// </summary>
    public partial class ModificarTarea1 : Window
    {
        public ModificarTarea1()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void ModificarTarea_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(NombreTareas.Text) || string.IsNullOrEmpty(Avance1.Text) ||
                string.IsNullOrEmpty(Estado.Text))
            {
                MessageBox.Show("Ningun campo puede estar vacio");
            }
            else
            {
                Contexto contexto = new Contexto();
                List<Tarea> tareas = contexto.Tareas.ToList();
                int idTarea = 0;
                foreach (Tarea t in tareas)
                {
                    if (t.nombre == NombreTareas.Text)
                    {
                        idTarea = t.IDTarea;
                        
                    }
                }

                


            }
            Estado.Clear();
            Avance1.Clear();
            NombreTareas.SelectedItem = null;
        }

        public void CargarDatos()
        {
            Contexto contexto = new Contexto();
            List<Tarea> tarea = contexto.Tareas.ToList();
            foreach (Tarea t in tarea)
            {
                NombreTareas.Items.Add(t.nombre);
            }



        }

        public int AsignarIdTarea()
        {
            Contexto contexto = new Contexto();
            List<Tarea> tareas = contexto.Tareas.ToList();
            int idTarea = 0;
            foreach (Tarea t in tareas)
            {
                if (t.nombre == NombreTareas.Text)
                {
                    idTarea = t.IDTarea;
                }
            }
            return idTarea;
        }
    }
}
