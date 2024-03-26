﻿namespace GettingStarted
{
    using System.Collections.ObjectModel;

    /// <summary>
    /// Represents the view model for the getting started functionality.
    /// </summary>
    public class ViewModel
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewModel"/> class.
        /// </summary>
        public ViewModel()
        {
            this.AirportDetails = this.GetAirportDetails();
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the collection of airport details.
        /// </summary>
        public ObservableCollection<AirportDetails> AirportDetails { get; set; }

        #endregion

        #region Methods
        /// <summary>
        /// Method to get a collection of airport details.
        /// </summary>
        /// <returns>The airport details collection.</returns>
        private ObservableCollection<AirportDetails> GetAirportDetails()
        {
            return new ObservableCollection<AirportDetails>
            {
                new AirportDetails { State = "Brazil", Count = 31 },
                new AirportDetails { State = "Colombia", Count = 32 },
                new AirportDetails { State = "Argentina", Count = 26 },
                new AirportDetails { State = "Ecuador", Count = 7 },
                new AirportDetails { State = "Chile", Count = 5 },
                new AirportDetails { State = "Peru", Count = 3 },
                new AirportDetails { State = "Venezuela", Count = 3 },
                new AirportDetails { State = "Bolivia", Count = 3 },
                new AirportDetails { State = "Paraguay", Count = 2 },
                new AirportDetails { State = "Uruguay", Count = 3 },
                new AirportDetails { State = "Falkland Islands", Count = 1 },
                new AirportDetails { State = "French Guiana", Count = 1 },
                new AirportDetails { State = "Guyana", Count = 1 },
                new AirportDetails { State = "Suriname", Count = 1 }
            };
        }

        #endregion
    }
}