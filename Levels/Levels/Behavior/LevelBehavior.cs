namespace Levels
{
    using Syncfusion.Maui.TreeMap;

    /// <summary>
    /// Represents the behavior for managing the group level in tree map control.
    /// </summary>
    internal class LevelBehavior : Behavior<ContentPage>
    {
        #region Fields

        /// <summary>
        /// The tree map instance.
        /// </summary>
        private SfTreeMap? treeMap;

        /// <summary>
        /// The radio button for the no group level option.
        /// </summary>
        private RadioButton? optionButton;

        /// <summary>
        /// The radio button for the group level option.
        /// </summary>
        private RadioButton? groupOptionButton;

        #endregion

        #region Override methods

        /// <summary>
        /// Invoked when behavior is attached to a view.
        /// </summary>
        /// <param name="sampleView">The sample view to which the behavior is attached.</param>
        protected override void OnAttachedTo(ContentPage sampleView)
        {
            base.OnAttachedTo(sampleView);

            this.treeMap = sampleView.FindByName<SfTreeMap>("treeMap");
            this.optionButton = sampleView.FindByName<RadioButton>("optionButton");
            this.groupOptionButton = sampleView.FindByName<RadioButton>("groupOptionButton");

            if (this.optionButton != null)
            {
                this.optionButton.CheckedChanged += this.OnLevelsTypeButtonCheckedChanged;
            }

            if (this.groupOptionButton != null)
            {
                this.groupOptionButton.CheckedChanged += this.OnLevelsTypeButtonCheckedChanged;
                this.groupOptionButton.IsChecked = true;
            }
        }

        /// <summary>
        /// Invoked when behavior is detached from a view.
        /// </summary>
        /// <param name="sampleView">The sample view from which the behavior is detached.</param>
        protected override void OnDetachingFrom(ContentPage sampleView)
        {
            base.OnDetachingFrom(sampleView);
            if (this.treeMap != null)
            {
                this.treeMap = null;
            }

            if (this.optionButton != null)
            {
                this.optionButton.CheckedChanged -= this.OnLevelsTypeButtonCheckedChanged;
                this.optionButton = null;
            }

            if (this.groupOptionButton != null)
            {
                this.groupOptionButton.CheckedChanged -= this.OnLevelsTypeButtonCheckedChanged;
                this.groupOptionButton = null;
            }
        }

        #endregion

        #region Property changed

        /// <summary>
        /// Event handler for the checked changed event of levels type radio buttons.
        /// </summary>
        /// <param name="sender">The sender of the event.</param>
        /// <param name="e">The event arguments.</param>
        private void OnLevelsTypeButtonCheckedChanged(object? sender, Microsoft.Maui.Controls.CheckedChangedEventArgs e)
        {
            if (sender == null || this.treeMap == null)
            {
                return;
            }

            var content = ((RadioButton)sender).Content;
            switch (content)
            {
                case "Group By Continents":
                    this.treeMap.Levels.Add(new TreeMapLevel() { GroupPath = "Continent", Stroke = Brush.Gray, Background = Brush.Transparent });
                    break;
                case "Without Grouping":
                    this.treeMap.Levels.Clear();
                    break;
                default:
                    break;
            }
        }

        #endregion
    }
}