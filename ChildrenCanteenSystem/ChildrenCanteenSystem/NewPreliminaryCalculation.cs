namespace ChildrenCanteenSystem
{
    using System;
    using System.Linq;
    using System.Windows.Forms;

    using Common.MessagesAndTitles;
    using Enumerations;
    using Events;
    using Models;

    public partial class NewPreliminaryCalculation : BaseForm
    {
        private bool menuForDateExists;
        private DateTime calculationDate;
        private bool calculationDateHasBeenInitialized = false;

        public NewPreliminaryCalculation(User userProfile, DateTime date)
            : base(userProfile)
        {
            InitializeComponent();

            this.menuForDateExists = false;

            AllDataSelected += this.CalculationDataSelected;

            this.calculationDate = date;
            this.calculationDateHasBeenInitialized = true;

            #region Form settings

            this.Text = FormsTitles.NewPreliminaryCalculationTitle;
            this.StartPosition = FormStartPosition.CenterScreen;

            #endregion 
        }

        public NewPreliminaryCalculation(User userProfile)
            : base(userProfile)
        {
            InitializeComponent();

            this.menuForDateExists = false;

            AllDataSelected += this.CalculationDataSelected;

            #region Form settings

            this.Text = FormsTitles.NewPreliminaryCalculationTitle;
            this.StartPosition = FormStartPosition.CenterScreen;
            datePicker.Format = DateTimePickerFormat.Custom;
            datePicker.CustomFormat = " ";

            #endregion 
        }

        private event DataSelectedEventHandler AllDataSelected;

        private void OnDataSelected(DataSelectedEventArgs e)
        {
            DataSelectedEventHandler handler = AllDataSelected;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void CalculationDataSelected(object sender, DataSelectedEventArgs eventArgs)
        {
            if (eventArgs.SaveButtonState == SaveButtonState.Enabled)
            {
                previewButton.Enabled = true;
            }
            else
            {
                previewButton.Enabled = false;
            }
        }

        private void NewPreliminaryCalculation_Load(object sender, EventArgs e)
        {
            if (this.calculationDateHasBeenInitialized)
            {
                this.datePicker.Value = this.calculationDate;
            }
        }

        private void foodCardsCount_TextChanged(object sender, EventArgs e)
        {
            DataSelectedEventArgs eventArgs = new DataSelectedEventArgs(SaveButtonState.Disabled);
            if (this.menuForDateExists)
            {
                int foodCardsCountAsInt;
                if (int.TryParse(foodCardsCount.Text, out foodCardsCountAsInt))
                {
                    if (foodCardsCountAsInt > 0)
                    {
                        eventArgs = new DataSelectedEventArgs(SaveButtonState.Enabled);
                        errorProvider.Clear();
                    }
                    else
                    {
                        errorProvider.SetError(foodCardsCount, ErrorMessages.InvalidFormatForFoodCardsMessage);
                        eventArgs = new DataSelectedEventArgs(SaveButtonState.Disabled);
                    } 
                }
            }
            else
            {
                eventArgs = new DataSelectedEventArgs(SaveButtonState.Disabled);
            }

            this.OnDataSelected(eventArgs);
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            datePicker.Format = DateTimePickerFormat.Long;
            var date = datePicker.Value.Date;
            this.menuForDateExists = base.data.Menus
                .All()
                .Any(m => m.Date == date);

            var preliminaryCalculationExists = base.data.PreliminaryCalculations
                .All()
                .Any(p => p.Menu.Date == date);

            if (!this.menuForDateExists)
            {
                var dialogResult = MessageBox.Show(
                    string.Format(
                        ConfirmMessages.NonExistingMenuConfirmCreateNewMessage,
                        date.ToLongDateString()),
                    MessageBoxesTitles.AttentionTitle,
                    MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var newMenuForm = new NewMenu(this.UserProfile, date);
                    newMenuForm.Show();
                    this.Close();
                }
            }
            else
            {
                this.menuForDateExists = true;
                if (preliminaryCalculationExists)
                {
                    var dialogResult = MessageBox.Show(
                    string.Format(
                        ConfirmMessages.ConfirmReviewPrelimianryCalculationMessage,
                        date.ToLongDateString()),
                    MessageBoxesTitles.AttentionTitle,
                    MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        var reviewPreliminaryCalculationForm =
                            new ReviewPreliminaryCalculation(this.UserProfile, date);
                        reviewPreliminaryCalculationForm.Show();
                        this.Close();
                    }
                }
            }

            int foodCardsCountAsInt;
            DataSelectedEventArgs eventArgs;
            if (!string.IsNullOrEmpty(foodCardsCount.Text) &&
                int.TryParse(foodCardsCount.Text, out foodCardsCountAsInt) &&
                this.menuForDateExists)
            {
                eventArgs = new DataSelectedEventArgs(SaveButtonState.Enabled);
            }
            else
            {
                eventArgs = new DataSelectedEventArgs(SaveButtonState.Disabled);
            }

            this.OnDataSelected(eventArgs);
        }

        private void previewButton_Click(object sender, EventArgs e)
        {
            var previewCalculationForm =
                new PreviewPreliminaryCalculation(
                    this.UserProfile,
                    datePicker.Value.Date,
                    int.Parse(foodCardsCount.Text));
            var result = previewCalculationForm.ShowDialog();
            if (result == DialogResult.Ignore)
            {
                this.Close();
            }
        }
    }
}
