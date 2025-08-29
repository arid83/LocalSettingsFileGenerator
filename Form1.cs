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
                    textBox2.Text = settingsJsonData;
                    System.IO.File.WriteAllText($"local.settings{DateTime.Now:MMddyyyyhhmmss}.json", settingsJsonData);
                    ShowMessage($"Success: local.settings.json file is created successfully.", false);
                }
            }
            catch (Exception ex)
            {
                ShowMessage($"Error: Oops! something went wrong... {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ClearMessage();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClearMessage();
        }

        private void ShowMessage(string message, bool isError = true)
        {
            lblResposne.Text = message;
            lblResposne.ForeColor = isError ? System.Drawing.Color.Red : System.Drawing.Color.Green;
        }

        private void ClearMessage()
        {
            lblResposne.Text = string.Empty;
        }
    }

    public class LocalSettings
    {
        public string name { get; set; }
        public string value { get; set; }
    }
}
