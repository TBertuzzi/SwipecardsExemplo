using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace SwipecardsExemplo.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        ObservableCollection<string> cartoes;
        public ObservableCollection<string> Cartoes
        {
            get { return cartoes; }
            set { cartoes = value; RaisePropertyChanged(); }
        }

        public MainViewModel()
        {
            cartoes = new ObservableCollection<string>
            {
                "Nintendo Switch",
                "Playstation 4",
                "Xbox One",
                "PC"
            };
        }

        // INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        void RaisePropertyChanged([CallerMemberName] string name = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
