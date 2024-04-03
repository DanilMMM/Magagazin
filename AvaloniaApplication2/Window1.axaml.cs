using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AvaloniaApplication2;

public partial class Window1 : Window
{
    
    List<Product> _LBoxItems = new();

public Window1()
{
    InitializeComponent();

    LBox.ItemsSource = _LBoxItems.ToList();
}

    
   
    private void AddItem(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
{


        _LBoxItems.Add(new Product(Name.Text, Convert.ToDouble(Price.Text), _LBoxItems.Count));
        //    double Price = Convert.ToDouble(Price);

        LBox.ItemsSource = _LBoxItems.ToList();
}

private void DelItem(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
{
    _LBoxItems.RemoveAt((int)(sender as Button)!.Tag!);

    for (int i = 0; i < _LBoxItems.Count; i++)
    {
        _LBoxItems[i].Id = i;
    }

    LBox.ItemsSource = _LBoxItems.ToList();

}

}

class Product
{
    private string _name;
    private double _price;
    private int _id;
    
    public Product(string name, double price, int id)
    {
        _name = name;
        _price = price;
        _id = id;
    }


    public string Name
    {
        get { return _name; }
        set { _name = Name; }
    }

    public double Price
    {
        get { return _price; }
        set { _price = Price; }
    }

    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }


}
