using Domain.Serializer;
using Domain.Services;
using Plugin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace UI.Forms
{
    public partial class SelectPluginAndSerializerForm : Form
    {
        private readonly PluginService _pluginService;

        public ISerializer SelectedSerializer => _pluginService.SelectedSerializer;

        public IPlugin SelectedPlugin => _pluginService.SelectedPlugin;

        public SelectPluginAndSerializerForm(Dictionary<string, ISerializer> serializers,
            Dictionary<string, IPlugin> plugins)
        {
            InitializeComponent();

            _pluginService = new PluginService(serializers, plugins);

            SetFileFormats();
            SetPlugins();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void cbFileFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            _pluginService.SelectedSerializer = _pluginService.Serializers
                .ElementAtOrDefault(cbFileFormat.SelectedIndex).Value;
        }

        private void cbPlugin_SelectedIndexChanged(object sender, EventArgs e)
        {
            _pluginService.SelectedPlugin = _pluginService.Plugins
                .ElementAtOrDefault(cbPlugin.SelectedIndex).Value;
        }

        private void SetFileFormats()
        {
            cbFileFormat.Items.AddRange(_pluginService.Serializers.Keys.ToArray());
            cbFileFormat.SelectedIndex = 0;
        }

        private void SetPlugins()
        {
            cbPlugin.Items.AddRange(_pluginService.Plugins.Keys.ToArray());
            cbPlugin.SelectedIndex = 0;
        }
    }
}
