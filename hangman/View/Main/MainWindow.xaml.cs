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
using Base.ViewModel;
using hangman.Model;

namespace hangman.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string[] lul = {"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z" };
        public MainWindow()
        {
            
            InitializeComponent();
            Thickness mrgin = new Thickness();
            mrgin.Left = 3;
            mrgin.Bottom = 3;
            mrgin.Right = 3;
            mrgin.Top = 3;
            for (int i = 0; i < 26; i++)
            {
                Button btn = new Button();
                Binding myCommandBinding = new Binding();
                myCommandBinding.Path = new PropertyPath("_registrujPismeno");
                myCommandBinding.Source = this.DataContext;
                btn.SetBinding(Button.CommandProperty, myCommandBinding);
                btn.CommandParameter = lul[i];
                btn.MinWidth = 40;
                btn.Name = "button" + i.ToString();
                btn.MinHeight = 40;
                btn.Content = lul[i];
                btn.Margin = mrgin;
                btn.HorizontalAlignment = HorizontalAlignment.Stretch;
                btn.VerticalAlignment = VerticalAlignment.Stretch;
                wrap.Children.Add(btn);
            }
            Button bt = new Button();
            Binding mCommandBinding = new Binding();
            mCommandBinding.Path = new PropertyPath("_novaHra");
            mCommandBinding.Source = this.DataContext;
            bt.SetBinding(Button.CommandProperty, mCommandBinding);
            bt.MinWidth = 83;
            bt.Name = "NH";
            bt.MinHeight = 40;
            bt.Content = "NH";
            bt.HorizontalAlignment = HorizontalAlignment.Stretch;
            bt.VerticalAlignment = VerticalAlignment.Stretch;
            bt.Margin = mrgin;
            wrap.Children.Add(bt);
        }
    }
    // link to application object: ((App)Application.Current).something

    // binding: myComponent.SetBinding(myComponent.BindingProperty, new Binding("BindingPath"){Source = this.DataContext});

    /* Binding Example
        Binding myBinding = new Binding();
        myBinding.Path = new PropertyPath("Name");
        myBinding.Source = this.DataContext;
        BindingOperations.SetBinding(myButton, Button.ContentProperty, myBinding);

        Binding myCommandBinding = new Binding();
        myCommandBinding.Path = new PropertyPath("NewCommand");
        myCommandBinding.Source = this.DataContext;
        myButton.SetBinding(Button.CommandProperty, myCommandBinding);
     */
}

