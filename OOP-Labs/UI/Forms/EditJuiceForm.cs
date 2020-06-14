using Domain.Model;
using Domain.Model.NonAlcoholic;
using Domain.Services;
using System;
using System.Windows.Forms;

namespace UI.Forms
{
    public partial class EditJuiceForm : Form
    {
        private readonly ModelService _modelService;
        private readonly Drink _drink;

        public EditJuiceForm(ModelService modelService)
        {
            InitializeComponent();

            _modelService = modelService;
        }

        public EditJuiceForm(ModelService modelService, Drink drink) : this(modelService)
        {
            _drink = drink;

            SetDrinkInfo();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_drink == null)
            {
                var juice = new Juice()
                {
                    Bottle = new Bottle()
                };

                if (!SetJuiceProperties(juice))
                {
                    return;
                }

                _modelService.AddDrink(juice);
            }
            else
            {
                var juice = (Juice)_drink;

                if (!SetJuiceProperties(juice))
                {
                    return;
                }
            }

            DialogResult = DialogResult.OK;
        }

        private void SetDrinkInfo()
        {
            var drinkInfo = _drink.GetDrinkInfo();

            tbName.Text = drinkInfo["Name"];
            tbCost.Text = drinkInfo["Cost"];
            tbSugarContent.Text = drinkInfo["Sugar content"];
            tbFruit.Text = drinkInfo["Fruit"];
            tbJuiceContent.Text = drinkInfo["Juice content"];
            tbPulpContent.Text = drinkInfo["Pulp content"];
            tbVolume.Text = drinkInfo["Bottle volume"];
            tbColor.Text = drinkInfo["Bottle color"];
        }

        private bool SetJuiceProperties(Juice juice)
        {
            juice.Name = tbName.Text;
            try
            {
                juice.Cost = decimal.Parse(tbCost.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter the correct price!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            try
            {
                juice.SugarContent = float.Parse(tbSugarContent.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter the correct sugar content!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            juice.Fruit = tbFruit.Text;
            try
            {
                juice.JuiceContent = float.Parse(tbJuiceContent.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter the correct fruit content!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            try
            {
                juice.PulpContent = float.Parse(tbPulpContent.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter the correct pulp content!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            juice.Bottle = new Bottle();
            try
            {
                juice.Bottle.Volume = int.Parse(tbVolume.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter the correct bottle volume!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            juice.Bottle.Color = tbColor.Text;

            return true;
        }
    }
}
