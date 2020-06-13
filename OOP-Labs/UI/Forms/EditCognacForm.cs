using Domain.Model;
using Domain.Model.Alcoholic;
using Domain.Services;
using System;
using System.Windows.Forms;

namespace UI.Forms
{
    public partial class EditCognacForm : Form
    {
        private readonly ModelService _modelService;
        private readonly Drink _drink;

        public EditCognacForm(ModelService modelService)
        {
            InitializeComponent();

            _modelService = modelService;
        }

        public EditCognacForm(ModelService modelService, Drink drink) : this(modelService)
        {
            _drink = drink;

            SetDrinkInfo();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_drink == null)
            {
                var cognac = new Cognac();

                cognac.Name = tbName.Text;
                try
                {
                    cognac.Cost = decimal.Parse(tbCost.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Enter the correct price!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    cognac.AlcoholContent = float.Parse(tbAlcoholContent.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Enter the correct alcohol content!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                cognac.DateOfBottling = dtpDageOfBottling.Value;
                cognac.Class = tbClass.Text;
                cognac.BarrelMaterial = tbBarrelMaterial.Text;
                cognac.Bottle = new Bottle();
                try
                {
                    cognac.Bottle.Volume = int.Parse(tbVolume.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Enter the correct bottle volume!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                cognac.Bottle.Color = tbColor.Text;
                
                _modelService.AddDrink(cognac);
            }
            else
            {
                var cognac = (Cognac)_drink;

                cognac.Name = tbName.Text;
                try
                {
                    cognac.Cost = decimal.Parse(tbCost.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Enter the correct price!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    cognac.AlcoholContent = float.Parse(tbAlcoholContent.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Enter the correct alcohol content!",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                cognac.DateOfBottling = dtpDageOfBottling.Value;
                cognac.Class = tbClass.Text;
                cognac.BarrelMaterial = tbBarrelMaterial.Text;
                try
                {
                    cognac.Bottle.Volume = int.Parse(tbVolume.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Enter the correct bottle volume!",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                cognac.Bottle.Color = tbColor.Text;
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
            tbClass.Text = drinkInfo["Class"];
            tbBarrelMaterial.Text = drinkInfo["Barrel material"];
            tbVolume.Text = drinkInfo["Bottle volume"];
            tbColor.Text = drinkInfo["Bottle color"];
        }
    }
}
