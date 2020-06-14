using Domain.Helpers;
using Domain.Model;
using Domain.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace UI
{
    public partial class MainForm : Form
    {
        private List<Type> _typesOfDrink;
        private readonly ModelService _modelService;

        public MainForm()
        {
            InitializeComponent();

            _typesOfDrink = ModelHelper.GetAllModelTypes();
            _modelService = new ModelService();

            InitializeTypesOfDrink();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addForm = GetFormForSelectedDrink();
            if (addForm.ShowDialog(this) == DialogResult.OK)
            {
                SetDrinksToListOfDrinks();
                SetDrinkInfo();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var editForm = GetFormForSelectedDrink(GetSelectedDrink());

            if (editForm == null)
            {
                return;
            }

            if (editForm.ShowDialog(this) == DialogResult.OK)
            {
                SetDrinksToListOfDrinks();
                SetDrinkInfo();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _modelService.Drinks.Remove(_modelService.Drinks.FirstOrDefault(drink =>
                ((Drink)drink).Name == lbListOfDrinks.SelectedItem?.ToString()));

            SetDrinksToListOfDrinks();
            SetDrinkInfo();
        }

        private void lbListOfDrinks_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetDrinkInfo();
        }

        private void cbTypeOfDrink_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetDrinksToListOfDrinks();
            SetDrinkInfo();
        }

        private void InitializeTypesOfDrink()
        {
            foreach (var typeOfDrink in _typesOfDrink)
            {
                cbTypeOfDrink.Items.Add(typeOfDrink.Name);
            }

            cbTypeOfDrink.Tag = _typesOfDrink;
            cbTypeOfDrink.SelectedIndex = 0;
        }

        private Form GetFormForSelectedDrink()
        {
            var typeOfDrink = cbTypeOfDrink.SelectedItem.ToString();

            var assembly = GetType().Assembly;
            var form = assembly.GetTypes().FirstOrDefault(
                type => type.IsClass
                && type.FullName.Contains(typeOfDrink));

            return (Form)Activator.CreateInstance(form, _modelService);
        }

        private Form GetFormForSelectedDrink(Drink drink)
        {
            if (drink == null)
            {
                return null;
            }

            var typeOfDrink = cbTypeOfDrink.SelectedItem.ToString();

            var assembly = GetType().Assembly;
            var form = assembly.GetTypes().FirstOrDefault(
                type => type.IsClass
                && type.FullName.Contains(typeOfDrink));

            return (Form)Activator.CreateInstance(form, _modelService, drink);
        }

        private void SetDrinksToListOfDrinks()
        {
            lbListOfDrinks.Items.Clear();

            var typeOfDrink = _typesOfDrink[cbTypeOfDrink.SelectedIndex];

            var drinks = _modelService.Drinks.Where(drink => drink.GetType() == typeOfDrink);

            foreach (var drink in drinks)
            {
                lbListOfDrinks.Items.Add(drink.Name);
            }
        }

        private void SetDrinkInfo()
        {
            lbDrinkInfo.Items.Clear();

            var drink = GetSelectedDrink();
            var drinkInfo = drink?.GetDrinkInfo();

            if (drinkInfo == null)
            {
                return;
            }

            foreach (var info in drinkInfo)
            {
                lbDrinkInfo.Items.Add($"{info.Key}: {info.Value}");
            }
        }

        private Drink GetSelectedDrink()
        {
            return _modelService.Drinks.FirstOrDefault(drink =>
                drink.GetType() == _typesOfDrink[cbTypeOfDrink.SelectedIndex]
                && drink.Name == lbListOfDrinks.SelectedItem?.ToString());
        }
    }
}
