namespace LayoutType
{
    using Syncfusion.Maui.TreeMap;

    /// <summary>
    /// Behavior class for handling interactions for tree map related properties.
    /// </summary>
    internal class LayoutTypeBehavior : Behavior<ContentPage>
    {
        #region Fields

        /// <summary>
        /// The tree map instance.
        /// </summary>
        private SfTreeMap? treeMap;

        /// <summary>
        /// The layout type option.
        /// </summary>
        private Picker? layoutTypePicker;

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
            this.layoutTypePicker = sampleView.FindByName<Picker>("layoutTypePicker");
            if (this.layoutTypePicker != null)
            {
                this.layoutTypePicker.SelectedIndexChanged += OnLayoutTypePickerSelectedIndexChanged;
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

            if (this.layoutTypePicker != null)
            {
                this.layoutTypePicker.SelectedIndexChanged -= this.OnLayoutTypePickerSelectedIndexChanged;
                this.layoutTypePicker = null;
            }
        }

        #endregion

        #region Property changed

        /// <summary>
        /// Invokes on picker selection changed.
        /// </summary>
        /// <param name="sender">The picker.</param>
        /// <param name="e">The event args.</param>
        private void OnLayoutTypePickerSelectedIndexChanged(object? sender, EventArgs e)
        {
            if (this.treeMap == null || sender == null)
            {
                return;
            }

            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;
            if (selectedIndex == 0)
            {
                this.treeMap.LayoutType = LayoutType.Squarified;
            }
            else if (selectedIndex == 1)
            {
                this.treeMap.LayoutType = LayoutType.SliceAndDiceHorizontal;
            }
            else if (selectedIndex == 2)
            {
                this.treeMap.LayoutType = LayoutType.SliceAndDiceVertical;
            }
            else
            {
                this.treeMap.LayoutType = LayoutType.SliceAndDiceAuto;
            }
        }

        #endregion
    }
}