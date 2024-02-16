using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CookBook.Models;

namespace CookBook.ViewModels
{
    public partial class MainViewModel:ObservableObject
    {
        [ObservableProperty]
        private string title="";

        private CuisineList cuisineList = new CuisineList();

        [ObservableProperty]
        private ObservableCollection<Cuisine> cuisines;

        [ObservableProperty]
        private Cuisine selectedCuisine;
        public MainViewModel()
        {
            cuisines = new ObservableCollection<Cuisine>(cuisineList.Cuisines);
            SelectedCuisine = cuisines[0];
        }
        private ObservableCollection<Recipe> filteredRecipes;
        private string searchIngredients = "";
        private string searchResultMessage = "";

        public string SearchIngredients
        {
            get => searchIngredients;
            set => SetProperty(ref searchIngredients, value);
        }

        public string SearchResultMessage
        {
            get => searchResultMessage;
            set => SetProperty(ref searchResultMessage, value);
        }

        public ObservableCollection<Recipe> FilteredRecipes
        {
            get => filteredRecipes;
            set => SetProperty(ref filteredRecipes, value);
        }

        public ICommand SearchIngredientsCommand => new RelayCommand(SearchByIngredients);

        private void SearchByIngredients()
        {
            if (string.IsNullOrWhiteSpace(SearchIngredients))
            {
                FilteredRecipes = new ObservableCollection<Recipe>();
                return;
            }

            var inputIngredients = SearchIngredients.Split(',').Select(i => i.Trim().ToLower());
            var matchingRecipes = Cuisines.SelectMany(c => c.Recipes)
                                          .Where(r => r.ContainsIngredients(inputIngredients))
                                          .ToList();

            if (matchingRecipes.Any())
            {
                FilteredRecipes = new ObservableCollection<Recipe>(matchingRecipes);
                SearchResultMessage = "";
            }
            else
            {
                FilteredRecipes = new ObservableCollection<Recipe>();
                SearchResultMessage = "Ingredients not found.";
            }
        }
    }
}
