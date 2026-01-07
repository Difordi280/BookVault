using BookVault.App.Views;
using BookVault.Domain.Interfaces;
using BookVault.Domain.Models;
using CommunityToolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BookVault.App.ViewModels
{
    public class BookListViewModel:ViewModelBase
    {
        
        public ObservableCollection<Book> LoadBook { get; set; } = new ObservableCollection<Book>();
        private IBookRepository _repository { get; set; }
        public  BookListViewModel(IBookRepository repository )
        {
            
            _repository= repository;

            
            _ =LoadBooksAsync();

            WeakReferenceMessenger.Default.Register<BookAddedMessage>(this, (r, m) =>
            {
                // Ejecutamos la recarga en el hilo principal
                App.Current.Dispatcher.Invoke(async () => await LoadBooksAsync());
            });

        }

        public async Task LoadBooksAsync()
        {
            var BookDb = await _repository.GetAllAsny();

            
            LoadBook.Clear();

            foreach(var libro in BookDb)
            {
                LoadBook.Add(libro);
            }
        }

    }
}
