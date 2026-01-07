using BookVault.App.ViewModels;
using BookVault.Data.Context;
using BookVault.Domain.Interfaces;
using BookVault.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyModel;
using System;
using System.Configuration;
using System.Data;
using System.Windows;

namespace BookVault.App
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    /// 

    public partial class App : Application
    {
        private readonly ServiceProvider _serviceProvider;
        public App()
        {
            var services = new ServiceCollection();

            // añadimos los viewmodels
            services.AddTransient<MainViewModel>();
            services.AddTransient<BookListViewModel>();
            services.AddTransient<BookRegisterViewModel>();

            // añadimos el mainwindow
            services.AddSingleton<MainWindow>();
            // añadimos la base de datos
            services.AddDbContext<LibraryContext>(options => options.UseSqlite("Data Source = Library.db"));

            //Repositorio desde como sacar un dato o todos
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();

            _serviceProvider = services.BuildServiceProvider();

        }

        protected override void OnStartup(StartupEventArgs e)
        {
            // Se solicita la ventana al contenedor para que inyecte todo
            var mainWindow = _serviceProvider.GetRequiredService<MainWindow>();
            mainWindow.Show();
            base.OnStartup(e);
        }

    }

}
