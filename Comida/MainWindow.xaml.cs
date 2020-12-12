using System.Collections.Generic;
using System.Windows;

namespace Comida
{
    public partial class MainWindow : Window
    {
        private List<Plato> Platos { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Platos = Plato.GetSamples(@".\recursos\platos");
            listaPlatos.DataContext = Platos;
        }
    }
}
