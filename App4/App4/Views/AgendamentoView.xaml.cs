using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App4.Views
{
    public partial class AgendamentoView : ContentPage
    {
        public Veiculo Veiculo { get; set; }
        public string Nome { get; set; }        
        public string Telefone { get; set; }
        public string Email { get; set; }

        private DateTime dataAgendamento = DateTime.Today;

        public DateTime DataAgendamento
        {
            get { return dataAgendamento; }
            set { dataAgendamento = value; }
        }
        
        public TimeSpan HoraAgendamento { get; set; }

        public AgendamentoView(Veiculo veiculo)
        {
            InitializeComponent();

            this.Veiculo = veiculo;
            this.BindingContext = this;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Agendamento", "Agendamento Concluido com sucesso!", "Ok");
        }
    }
}