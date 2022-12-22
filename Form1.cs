using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace LocalSettingsFileGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string settingsJson = textBox1.Text.Trim();
                if (!string.IsNullOrEmpty(settingsJson))
                {
                    var settingsList = JsonSerializer.Deserialize<IList<LocalSettings>>(settingsJson);
                    StringBuilder sb = new StringBuilder();

                    foreach (var setting in settingsList)
                    {
                        sb.AppendLine($"\t\"{setting.name}\": \"{setting.value}\",");
                    }

                    var settingsJsonData = $"{{{Environment.NewLine}\"IsEncrypted\": false, {Environment.NewLine}\"Values\": {{ {Environment.NewLine}{sb}{Environment.NewLine}  }} {Environment.NewLine}}}";
                    System.IO.File.WriteAllText($"local.settings.json", settingsJsonData);
                    MessageBox.Show("local.settings.json file is created successfully.", "Success", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Oops! something went wrong", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
        }
    }

    public class LocalSettings
    {
        public string name { get; set; }
        public string value { get; set; }
    }
}
