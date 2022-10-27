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
    /// Lógica de interacción para AsignarMaterial1.xaml
    /// </summary>
    public partial class AsignarMaterial1 : Window
    {
        public AsignarMaterial1()
        {
            InitializeComponent();
            CargarDatos();
            Fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void BotonIngresar_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Fecha.Text) || string.IsNullOrEmpty(Cantidad.Text) ||
                string.IsNullOrEmpty(Tareas.Text) || string.IsNullOrEmpty(Materiales.Text))
            {
                MessageBox.Show("Ningun campo puede estar vacio");
            }
            else
            {
                
                DateTime fecha = DateTime.Parse(Fecha.Text);
                
                int cantidad = Int32.Parse(Cantidad.Text);
                Contexto contexto = new Contexto();

                ConsumoMaterial consumo = new ConsumoMaterial() { Fecha = fecha, Cantidad = cantidad, IDTarea = AsignarIdTarea(), IDMaterial = AsignarIdMaterial() };
                contexto.ConsumoMateriales.Add(consumo);
                contexto.SaveChanges();


            }
            Fecha.Clear();
            Cantidad.Clear();
            Tareas.SelectedItem = null;
            Materiales.SelectedItem = null;
        }

        public void CargarDatos()
        {
            Contexto contexto = new Contexto();
            List<Tarea> tarea = contexto.Tareas.ToList();
            foreach (Tarea t in tarea)
            {
                Tareas.Items.Add(t.nombre);
            }


            List<Material> material = contexto.Materiales.ToList();
            foreach (Material m in material)
            {
                Materiales.Items.Add(m.nombre);
                
            }
        }

        public int AsignarIdTarea()
        {
            Contexto contexto = new Contexto();
            List<Tarea> tareas = contexto.Tareas.ToList();
            int idTarea = 0;
            foreach (Tarea t in tareas)
            {
                if (t.nombre == Tareas.Text)
                {
                    idTarea = t.IDTarea;
                }
            }
            return idTarea;
        }

        public int AsignarIdMaterial()
        {
            Contexto contexto = new Contexto();
            List<Material> material = contexto.Materiales.ToList();
            int idMaterial = 0;
            foreach (Material m in material)
            {
                if (m.nombre == Materiales.Text)
                {
                    idMaterial = m.codigo;
                }
            }
            return idMaterial;
        }
    }
}
