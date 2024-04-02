namespace Levels
{
    using System.Collections.ObjectModel;

    /// <summary>
    /// Represents the view model for the treemap's group level functionality.
    /// </summary>
    public class ViewModel
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewModel"/> class.
        /// </summary>
        public ViewModel()
        {
            this.PopulationDetails = this.GetPopulationDetails();
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the collection of population details.
        /// </summary>
        public ObservableCollection<PopulationDetails> PopulationDetails { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Method to get a collection of population details.
        /// </summary>
        /// <returns>The population details collection.</returns>
        private ObservableCollection<PopulationDetails> GetPopulationDetails()
        {
            return new ObservableCollection<PopulationDetails>()
            {
                new PopulationDetails() { Continent ="North America", Country = "United States of America", Population = 339996564 },
                new PopulationDetails() { Continent ="South America", Country = "Brazil", Population = 216422446 },
                new PopulationDetails() { Continent ="North America", Country = "Mexico", Population = 128455567 },
                new PopulationDetails() { Continent ="South America", Country = "Colombia", Population = 52085168 },
                new PopulationDetails() { Continent ="South America", Country = "Argentina", Population = 45773884 },
                new PopulationDetails() { Continent ="North America", Country = "Canada", Population = 38781292 },
                new PopulationDetails() { Continent ="South America", Country = "Peru", Population = 34352719 },
                new PopulationDetails() { Continent ="South America", Country = "Venezuela", Population = 28838499 },
                new PopulationDetails() { Continent ="South America", Country = "Chile", Population = 19629590 },
                new PopulationDetails() { Continent ="South America", Country = "Ecuador", Population = 18190484 },
                new PopulationDetails() { Continent ="North America", Country = "Guatemala", Population = 18092026 },
                new PopulationDetails() { Continent ="South America", Country = "Bolivia", Population = 12388571 },
                new PopulationDetails() { Continent ="North America", Country = "Honduras", Population = 10593798 },
                new PopulationDetails() { Continent ="North America", Country = "Nicaragua", Population = 7046311 },
                new PopulationDetails() { Continent ="South America", Country = "Paraguay", Population = 6861524 },
                new PopulationDetails() { Continent ="North America", Country = "El Salvador", Population = 6364943 },
                new PopulationDetails() { Continent ="North America", Country = "Costa Rica", Population = 5212173 },
                new PopulationDetails() { Continent ="South America", Country = "Uruguay", Population = 3423109 },
            };
        }

        #endregion
    }
}