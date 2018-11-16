using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class SettingsForm : Form
    {
        private string settingsFile = "settings.bin";
        public SettingsForm()
        {
            InitializeComponent();
            var settings = (GameSettings)Serializer.Deserialize(settingsFile) ?? new GameSettings();
            ShowSettings(settings);
        }

        private void ShowSettings(GameSettings settings)
        {
            speedTrackBar.Value = settings.Timer;
            widthTextBox.Text = settings.Columns.ToString();
            heightTextBox.Text = settings.Rows.ToString();
            infiniteCheckBox.Checked = settings.IsInfinite;
            birthCountTextBox.Text = string.Join(" ", settings.BirthCount);
            survivalTextBox.Text = string.Join(" ", settings.StayAliveCount);
        }

        private GameSettings GetSettings()
        {
            var settings = new GameSettings();
            settings.Timer = speedTrackBar.Value;
            settings.Columns = int.Parse(widthTextBox.Text);
            settings.Rows = int.Parse(heightTextBox.Text);
            settings.IsInfinite = infiniteCheckBox.Checked;
            settings.BirthCount = (birthCountTextBox.Text == "") ?
                new int[0] :
                birthCountTextBox.Text.Split().Select(s => int.Parse(s)).ToArray();
            settings.StayAliveCount = (survivalTextBox.Text == "") ?
                new int[0] :
                survivalTextBox.Text.Split().Select(s => int.Parse(s)).ToArray();
            return settings;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var settings = GetSettings();
            Serializer.Serialize(settings, settingsFile);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            var settings = new GameSettings();
            ShowSettings(settings);
            Serializer.Serialize(settings, settingsFile);
        }

        private void speedTrackBar_ValueChanged(object sender, EventArgs e)
        {
            label5.Text = "Refresh(ms) " + speedTrackBar.Value;
        }
    }
}
