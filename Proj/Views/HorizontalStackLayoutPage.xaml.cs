using Proj.Models;
using System.Collections.ObjectModel;
namespace Proj
{
    public partial class HorizontalStackLayoutPage : ContentPage
    {
        public ObservableCollection<TreeModel> Trees { get; set; }

        public HorizontalStackLayoutPage()
        {
            InitializeComponent();

            // Sample data for trees
            Trees = new ObservableCollection<TreeModel>
            {
                new TreeModel { Name = "Oak Tree", GrowsOn = "Land", Photo = "oak_tree.jpg", Season = "Spring" },
                new TreeModel { Name = "Pine Tree", GrowsOn = "Mountain", Photo = "pine_tree.jpg", Season = "Winter" },
                new TreeModel { Name = "Maple Tree", GrowsOn = "Land", Photo = "maple_tree.jpg", Season = "Autumn" },
                new TreeModel { Name = "Willow Tree", GrowsOn = "Riverbank", Photo = "willow_tree.jpg", Season = "Summer" },
                new TreeModel { Name = "Birch Tree", GrowsOn = "Forest", Photo = "birch_tree.jpg", Season = "Spring" },
                new TreeModel { Name = "Cypress Tree", GrowsOn = "Swamp", Photo = "cypress_tree.jpg", Season = "Fall" }

                // Add more trees as needed
            };

            // Set the data context for the CollectionView
            this.BindingContext = this;
        }
    }
}
