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
            this.SelectionModeInfo = Enum.GetValues(typeof(Syncfusion.Maui.TreeMap.SelectionMode));
            this.LayoutTypeInfo = Enum.GetValues(typeof(Syncfusion.Maui.TreeMap.LayoutType));
            this.TextFormatOptionInfo = Enum.GetValues(typeof(Syncfusion.Maui.TreeMap.TextFormatOption));
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the collection of airport details.
        /// </summary>
        public ObservableCollection<AirportDetails> AirportDetails { get; set; }

        /// <summary>
        /// Gets or sets the collection of layout type info.
        /// </summary>
        public Array LayoutTypeInfo { get; set; }

        /// <summary>
        /// Gets or sets the collection of selection mode info.
        /// </summary>
        public Array SelectionModeInfo { get; set; }

        /// <summary>
        /// Gets or sets the collection of text format option info.
        /// </summary>
        public Array TextFormatOptionInfo { get; set; }

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