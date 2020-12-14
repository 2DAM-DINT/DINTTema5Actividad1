using System.Collections.Generic;
using System.Windows;

namespace Comida
{
    public partial class MainWindow : Window
    {
        private List<Plato> Platos { get; set; }

        private readonly List<string> tiposLista;

        public MainWindow()
        {
            InitializeComponent();
            Platos = Plato.GetSamples(@".\recursos\platos");
            listaPlatos.DataContext = Platos;

            listaTipos.ItemsSource = Plato.TIPOS_VALIDOS;
        }
    }
}
