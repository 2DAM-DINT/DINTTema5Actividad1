using System.Collections.Generic;
using System.Windows;

namespace Comida
{
    public partial class MainWindow : Window
    {
        private List<Plato> Platos { get; set; }

        private List<string> tiposValidos;

        public MainWindow()
        {
            InitializeComponent();
            Platos = Plato.GetSamples(@".\recursos\platos");
            listaPlatos.DataContext = Platos;

            tiposValidos = new List<string>();
            tiposValidos.Add("Americana");
            tiposValidos.Add("Mexicana");
            tiposValidos.Add("China");
            listaTipos.ItemsSource = tiposValidos;
        }
    }
}
