using Avalonia.Controls;
using System.Collections.Generic;
using System.Linq;

namespace AvaloniaApplication2

{
    public partial class MainWindow : Window
    {
        List<Product> _LBoxItems = new();

        public MainWindow()
        {
            InitializeComponent();


        }
        private void Perexod(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            Window1 window = new Window1();
            window.Show(); 
        }
    }
}
