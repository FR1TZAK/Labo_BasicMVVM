using ExtensionsLibrary;
using Models.Models;
using Services.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AppWPF.ViewModels
{
    public class Window1ViewModel : ViewModelBase
    {
        private ItemService _itemService = null; // because we use the one from the mainwindow passed along
        public ItemService ItemService { get => _itemService; set => _itemService = value; }


        private object _mapper = null;
        public object Mapper { get => _mapper; set => _mapper = value; }
        private string _characterName = null;
        public string CharacterName
        {
            get => _characterName;
            set
            {
                _characterName = value;
                this.Notify(nameof(CharacterName));
            }
        }


        // ATTACHED TO Window1.xaml
        public Window1ViewModel(ItemService itemService, object mapper, string parameter)
        {
            ItemService = itemService;
            Mapper = mapper;
            CharacterName = parameter;

            this.MakeDataCollection();
        }

        private ObservableCollection<Item> _items = new ObservableCollection<Item>();
        public ObservableCollection<Item> Items { get => _items; set => _items = value; }

        private void MakeDataCollection()
        {
            Items.Clear();
            foreach (Item item in this.ItemService.GenerateItems())
            {
                Items.Add(item);
            }


        }

    }
}
