using Domain.Model;
using Domain.Model.Alcoholic;
using Domain.Services;
using System;
using System.Windows.Forms;

namespace UI.Forms
{
    public partial class EditWineForm : Form
    {
        private readonly ModelService _modelService;
        private readonly Drink _drink;

        public EditWineForm(ModelService modelService)
        {
            InitializeComponent();

            _modelService = modelService;
        }

        public EditWineForm(ModelService modelService, Drink drink) : this(modelService)
        {
            _drink = drink;

            SetDrinkInfo();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_drink == null)
            {
                var wine = new Wine();

                wine.Name = tbName.Text;
                try
                {
                    wine.Cost = decimal.Parse(tbCost.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Enter the correct price!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    wine.AlcoholContent = float.Parse(tbAlcoholContent.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Enter the correct alcohol content!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                wine.DateOfBottling = dtpDageOfBottling.Value;
                wine.GrapeSort = tbGrapeSort.Text;
                try
                {
                    wine.VinesAge = int.Parse(tbVinesAge.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Enter the correct vines age!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                wine.Bottle = new Bottle();
                try
                {
                    wine.Bottle.Volume = int.Parse(tbVolume.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Enter the correct bottle volume!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                wine.Bottle.Color = tbColor.Text;

                _modelService.AddDrink(wine);
            }
            else
            {
                var wine = (Wine)_drink;

                wine.Name = tbName.Text;
                try
                {
                    wine.Cost = decimal.Parse(tbCost.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Enter the correct price!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    wine.AlcoholContent = float.Parse(tbAlcoholContent.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Enter the correct alcohol content!",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                wine.DateOfBottling = dtpDageOfBottling.Value;
                wine.GrapeSort = tbGrapeSort.Text;
                try
                {
                    wine.VinesAge = int.Parse(tbVinesAge.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Enter the correct vines age!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    wine.Bottle.Volume = int.Parse(tbVolume.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Enter the correct bottle volume!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                wine.Bottle.Color = tbColor.Text;
            }

            DialogResult = DialogResult.OK;
        }

        private void SetDrinkInfo()
        {
            var drinkInfo = _drink.GetDrinkInfo();

            tbName.Text = drinkInfo["Name"];
            tbCost.Text = drinkInfo["Cost"];
            tbAlcoholContent.Text = drinkInfo["Alcohol content"];
            dtpDageOfBottling.Value = DateTime.Parse(drinkInfo["Date of bottling"]);
            tbGrapeSort.Text = drinkInfo["Grape sort"];
            tbVinesAge.Text = drinkInfo["Vines age"];
            tbVolume.Text = drinkInfo["Bottle volume"];
            tbColor.Text = drinkInfo["Bottle color"];
        }
    }
}
