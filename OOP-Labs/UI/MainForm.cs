using Domain.Helpers;
using Domain.Model;
using Domain.Serializer;
using Domain.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using UI.Forms;

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
                drink.Name == lbListOfDrinks.SelectedItem?.ToString()));

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

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = string.Join("|", _modelService.Serializers.Select(f => f.Filter));

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (var fileStream = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                {
                    try
                    {
                        _modelService.AddDrinks(_modelService
                            .Serializers[openFileDialog.FilterIndex - 1]
                            .Serializator
                            .Deserialize<List<Drink>>(fileStream));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    _modelService.LastSerializer = _modelService.Serializers[openFileDialog.FilterIndex - 1].Serializator;
                    _modelService.LastFile = openFileDialog.FileName;
                }

                SetDrinksToListOfDrinks();
                SetDrinkInfo();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = string.Join("|", _modelService.Serializers.Select(f => f.Filter));

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                _modelService.LastFile = saveFileDialog.FileName;
                _modelService.LastSerializer = _modelService.Serializers[saveFileDialog.FilterIndex - 1].Serializator;

                if (_modelService.LastSerializer is SerializerWithPlugins)
                {
                    var selectPluginForm = CreateSelectPluginAndSerializerForm();
                    if (selectPluginForm.ShowDialog() == DialogResult.OK)
                    {
                        var serialzier = _modelService.LastSerializer as SerializerWithPlugins;
                        serialzier.SelectedSerializer = selectPluginForm.SelectedSerializer;
                        serialzier.SelectedPlugin = selectPluginForm.SelectedPlugin;
                    }
                }
 
                saveToolStripMenuItem_Click(null, null);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var serializerWithPlugins = _modelService.LastSerializer as SerializerWithPlugins;
            bool isLastPluginEmpty =
                serializerWithPlugins != null 
                && (serializerWithPlugins.SelectedPlugin == null 
                || serializerWithPlugins.SelectedSerializer == null);

            if (_modelService.LastFile == null || _modelService.LastSerializer == null || isLastPluginEmpty)
            {
                saveAsToolStripMenuItem_Click(null, null);
            }
            else
            {
                using (var fileStream = new FileStream(_modelService.LastFile, FileMode.Create, FileAccess.Write))
                {
                    try
                    {
                        _modelService.LastSerializer.Serialize(fileStream, _modelService.Drinks);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
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

        private SelectPluginAndSerializerForm CreateSelectPluginAndSerializerForm()
        {
            var fileFormat = _modelService.Serializers.ToDictionary(s => (s.Filter.Split('(')[0]), s => s.Serializator);

            var plugins = _modelService.Serializers
                .Select(s => s.Serializator)
                .OfType<SerializerWithPlugins>()
                .Single().Plugins
                .ToDictionary(p => p.GetType().Name.Replace("Plugin", ""), p => p);

            return new SelectPluginAndSerializerForm(fileFormat, plugins);
        }
    }
}
