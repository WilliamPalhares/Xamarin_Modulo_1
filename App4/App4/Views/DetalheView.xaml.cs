using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App4.Views
{
    public partial class DetalheView : ContentPage
    {
        private const int FREIO_ABS = 800;
        private const int AR_CONDICIONANDO = 1000;
        private const int MP3_PLAYER = 500;

        public Veiculo Veiculo { get; set; }

        public string TextoFreioABS
        {
            get
            {
                return string.Format("Freio ABS - R$ {0}", FREIO_ABS);
            }
        }

        public string TextoArCondicionado
        {
            get
            {
                return string.Format("Ar Condiconado - R$ {0}", AR_CONDICIONANDO);
            }
        }

        public string TextoMp3Player
        {
            get
            {
                return string.Format("MP3 Player - R$ {0}", MP3_PLAYER);
            }
        }

        bool temFreioABS;

        public bool TemFreioABS
        {
            get
            {
                return temFreioABS;
            }
            set
            {
                temFreioABS = value;
                OnPropertyChanged(nameof(ValorTotal));
            }
        }

        bool temArCondicionado;

        public bool TemArCondicionado
        {
            get
            {
                return temArCondicionado;
            }
            set
            {
                temArCondicionado = value;
                OnPropertyChanged(nameof(ValorTotal));
            }
        }

        bool temMp3Player;

        public bool TemMp3Player
        {
            get
            {
                return temMp3Player;
            }
            set
            {
                temMp3Player = value;
                OnPropertyChanged(nameof(ValorTotal));
            }
        }

        public string ValorTotal
        {
            get
            {
                return string.Format("Valor Total: R$ {0}", Veiculo.Preco
                    + (temFreioABS ? FREIO_ABS : 0)
                    + (temArCondicionado ? AR_CONDICIONANDO : 0)
                    + (temMp3Player ? MP3_PLAYER : 0));
            }
        }

        public DetalheView(Veiculo v)
        {
            InitializeComponent();

            this.Veiculo = v;
            this.BindingContext = this;
        }

        private void buttonProximo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AgendamentoView(this.Veiculo));
        }
    }
}