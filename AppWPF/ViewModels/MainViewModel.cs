using AppWPF.Windows;
using ExtensionsLibrary;
using Services.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace AppWPF.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private ItemService _itemService = new ItemService();
        public ItemService ItemService { get => _itemService; set => _itemService = value; }

        public object Mapper { get; set; } = new object();
        public string CharacterName { get; set; } = "I am Deckard Cain, a character from the MainWindow";


        public ICommand OpenWindow { get; set; }


        // ATTACHED TO MainWindow.xaml
        public MainViewModel()
        {
            //this.OpenWindow = new RelayCommand(OnOpenWindow); // we need a relaycommand -> option A
            this.OpenWindow = new RelayCommand(new Action<object>(OnOpenWindow)); // -> option B also works

        }

        private void OnOpenWindow(object windowName)
        {
           if(windowName != null)
            {
                switch(windowName)
                {
                    case "Window1":
                        Window win1 = new Window1();
                        win1.DataContext = new Window1ViewModel(ItemService, Mapper, CharacterName);
                        win1.Show();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
