using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App4.Views
{
    public class Veiculo
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        
        public string PrecoFormatado
        {
            get {
                return string.Format("R$ {0}", Preco);
            }
        }
    }

    public partial class ListagemView : ContentPage
    {
        public List<Veiculo> Veiculos { get; set; }           

        public ListagemView()
        {
            InitializeComponent();

            this.Veiculos = new List<Veiculo>()
            {
                new Veiculo {Nome = "Azera V6", Preco = 60000},
                new Veiculo {Nome = "Fiesta 2.0", Preco = 35000},
                new Veiculo {Nome = "HB20 2.0", Preco = 70000},
                new Veiculo {Nome = "Corolla", Preco = 60000},
                new Veiculo {Nome = "Honda Fit", Preco = 35000},
                new Veiculo {Nome = "Golf GTI", Preco = 70000},
                new Veiculo {Nome = "Ford Focus", Preco = 60000},
                new Veiculo {Nome = "Gol", Preco = 35000},
                new Veiculo {Nome = "Honda Civic", Preco = 70000},
                new Veiculo {Nome = "Honda City", Preco = 60000},
                new Veiculo {Nome = "Fiat Punto", Preco = 35000},
                new Veiculo {Nome = "Nissan Sentra", Preco = 70000},
                new Veiculo {Nome = "Nissan I30", Preco = 60000},
                new Veiculo {Nome = "Renault Sandero", Preco = 35000},
                new Veiculo {Nome = "Elantra", Preco = 70000}
            };

            this.BindingContext = this;
        }

        private void listViewVeiculos_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Veiculo v = (Veiculo)e.Item;

            Navigation.PushAsync(new DetalheView(v));
        }
    }
}
