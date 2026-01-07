using BookVault.Domain.Interfaces;
using BookVault.Domain.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace BookVault.App.ViewModels
{
    public partial class BookRegisterViewModel : ViewModelBase
    {
        private readonly IBookRepository _bookRepository;
        private readonly ICategoryRepository _categoryRepository;

        [ObservableProperty]
        private string? _title;

        [ObservableProperty]
        private string? _author;

        [ObservableProperty]
        [RegularExpression(@"^\d+$", ErrorMessage = "Solo se permiten números")]
        [IsbnValidation(ErrorMessage = "ISBN no válido")]
        [NotifyDataErrorInfo]
        private ulong? _isbn;

        [ObservableProperty]
        private ObservableCollection<Category> _categories = new ObservableCollection<Category>();

        [ObservableProperty]
        [Required(ErrorMessage = "Seleccione una categoría válida")]
        private Category? _selectedCategory;

        public BookRegisterViewModel(IBookRepository bookRepository, ICategoryRepository categoryRepository)
        {
            _bookRepository = bookRepository;
            _categoryRepository = categoryRepository;

            _ = LoadCategoriesAsync();
        }

        private async Task LoadCategoriesAsync()
        {
            var categories = await _categoryRepository.GetAllAsny();
            foreach (var category in categories)
            {
                Categories.Add(category);
            }
        }

        [RelayCommand]
        private async Task RegisterBookEntry()
        {
            ValidateAllProperties();

            if (HasErrors || SelectedCategory == null || Isbn == null)
            {
                return;
            }

            try
            {
                string formattedIsbn = Isbn.ToString()!;
                if (formattedIsbn.Length > 3)
                {
                    formattedIsbn = formattedIsbn.Insert(3, "-");
                }

                var newBook = new Book
                {
                    Id = Guid.NewGuid(),
                    Title = Title,
                    Author = Author,
                    Isbn = formattedIsbn,
                    CategoryId = SelectedCategory.Id,
                    Category = SelectedCategory,
                    IsSynced = false,
                    LastModified = DateTime.UtcNow,
                    IsDeleted = false
                };

                await _bookRepository.AddAsny(newBook);

                WeakReferenceMessenger.Default.Send(new BookAddedMessage());

                Title = string.Empty;
                Author = string.Empty;
                Isbn = null;
                SelectedCategory = null;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error: {ex.Message}");
            }
        }
    }

    public class IsbnValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value == null || string.IsNullOrWhiteSpace(value.ToString()))
                return ValidationResult.Success;

            if (ISBN.TryParse(value.ToString()!, out _))
            {
                return ValidationResult.Success;
            }

            return new ValidationResult("El ISBN no cumple el estándar matemático internacional.");
        }
    }

    public class BookAddedMessage { }
}