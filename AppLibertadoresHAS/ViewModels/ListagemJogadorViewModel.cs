using AppLibertadoresHAS.Models;
using AppLibertadoresHAS.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AppLibertadoresHAS.ViewModels
{
    public class ListagemJogadorViewModel : BaseViewModel
    {
        private JogadorService _jogadorService;

        private ObservableCollection<Jogador> jogadores;

        public ObservableCollection<Jogador > Jogadores
        {
            get => jogadores;
            set
            {
                jogadores = value;
                OnPropertyChanged();
            }

        }
        public ListagemJogadorViewModel()
        {
            _jogadorService = new JogadorService();
            Jogadores = new ObservableCollection<Jogador>();
            CarregarJogadores();
        }
        private async void CarregarJogadores()
        {
            try
            {
                Jogadores = await _jogadorService.GetJogadoresAsync();
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Erro", ex.Message, "Ok");
            }
        }
    }
}
