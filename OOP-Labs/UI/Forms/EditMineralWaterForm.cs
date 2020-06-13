using Domain.Model;
using Domain.Model.NonAlcoholic;
using Domain.Services;
using System;
using System.Windows.Forms;

namespace UI.Forms
{
    public partial class EditMineralWaterForm : Form
    {
        private readonly ModelService _modelService;
        private readonly Drink _drink;

        public EditMineralWaterForm(ModelService modelService)
        {
            InitializeComponent();

            _modelService = modelService;
        }

        public EditMineralWaterForm(ModelService modelService, Drink drink) : this(modelService)
        {
            _drink = drink;

            SetDrinkInfo();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_drink == null)
            {
                var mineralWater = new MineralWater();

                mineralWater.Name = tbName.Text;
                try
                {
                    mineralWater.Cost = decimal.Parse(tbCost.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Enter the correct price!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    mineralWater.SugarContent = float.Parse(tbSugarContent.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Enter the correct sugar content!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                mineralWater.WaterSource = tbWaterSource.Text;  
                try
                {
                    mineralWater.Mineralization = float.Parse(tbMineralization.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Enter the correct mineralization!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                mineralWater.Bottle = new Bottle();
                try
                {
                    mineralWater.Bottle.Volume = int.Parse(tbVolume.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Enter the correct bottle volume!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                mineralWater.Bottle.Color = tbColor.Text;

                _modelService.AddDrink(mineralWater);
            }
            else
            {
                var mineralWater = (MineralWater)_drink;

                mineralWater.Name = tbName.Text;
                try
                {
                    mineralWater.Cost = decimal.Parse(tbCost.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Enter the correct price!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    mineralWater.SugarContent = float.Parse(tbSugarContent.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Enter the correct sugar content!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                mineralWater.WaterSource = tbWaterSource.Text;
                try
                {
                    mineralWater.Mineralization = float.Parse(tbMineralization.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Enter the correct mineralization!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                mineralWater.Bottle = new Bottle();
                try
                {
                    mineralWater.Bottle.Volume = int.Parse(tbVolume.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Enter the correct bottle volume!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                mineralWater.Bottle.Color = tbColor.Text;
            }

            DialogResult = DialogResult.OK;
        }

        private void SetDrinkInfo()
        {
            var drinkInfo = _drink.GetDrinkInfo();

            tbName.Text = drinkInfo["Name"];
            tbCost.Text = drinkInfo["Cost"];
            tbSugarContent.Text = drinkInfo["Sugar content"];
            tbWaterSource.Text = drinkInfo["Water source"];
            tbMineralization.Text = drinkInfo["Mineralization"];
            tbVolume.Text = drinkInfo["Bottle volume"];
            tbColor.Text = drinkInfo["Bottle color"];
        }
    }
}
