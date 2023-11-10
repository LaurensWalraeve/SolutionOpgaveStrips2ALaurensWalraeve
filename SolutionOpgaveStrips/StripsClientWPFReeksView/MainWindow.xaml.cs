using StripsClientWPFReeksView.Model;
using StripsClientWPFReeksView.Services;
using System;
using System.Collections;
using System.Windows;
using System.Windows.Data;

namespace StripsClientWPFReeksView
{
    public partial class MainWindow : Window
    {
        private StripServiceClient stripService;

        public MainWindow()
        {
            InitializeComponent();
            stripService = new StripServiceClient();
        }

        private async void GetReeksButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int reeksId;
                if (int.TryParse(ReeksIdTextBox.Text, out reeksId))
                {
                    ReeksDTO reeksDTO = await stripService.GetReeksDetailsAsync(reeksId);

                    // Update UI based on reeksDTO properties
                    NaamTextBox.Text = reeksDTO.Naam;
                    

                    // Clear previous data in the DataGrid
                    StripsDataGrid.Items.Clear();
                    int totalStrips = 0;
                    // Add new data to the DataGrid
                    foreach (var stripDTO in reeksDTO.Strips)
                    {
                        StripsDataGrid.Items.Add(new
                        {
                            Titel = stripDTO.Titel,
                            Nr = stripDTO.Nr
                        });
                        totalStrips++;
                    }

                    AantalTextBox.Text = totalStrips.ToString();
                }
                else
                {
                    MessageBox.Show("Invalid Reeks ID. Please enter a valid numeric ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
