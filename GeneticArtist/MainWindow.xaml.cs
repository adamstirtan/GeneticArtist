using System;
using System.Drawing.Imaging;
using System.Windows;
using System.Windows.Media.Imaging;

using Microsoft.Win32;

using GeneticArtist.Genetic;

namespace GeneticArtist
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonOpen_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog
            {
                Filter = ""
            };

            var codecs = ImageCodecInfo.GetImageEncoders();
            var separator = string.Empty;

            foreach (var codec in codecs)
            {
                var name = codec.CodecName.Substring(8).Replace("Codec", "Files").Trim();

                dialog.Filter = string.Format("{0}{1}{2} ({3})|{3}",
                    dialog.Filter,
                    separator,
                    name,
                    codec.FilenameExtension);

                separator = "|";
            }

            dialog.Filter = string.Format("{0}{1}{2} ({3})|{3}",
                dialog.Filter,
                separator,
                "All Files",
                "*.*");

            if (dialog.ShowDialog() == true)
            {
                ImageSource.Source = new BitmapImage(new Uri(dialog.FileName));
                ButtonStart.IsEnabled = true;
            }
        }

        private void ButtonStart_Click(object sender, RoutedEventArgs e)
        {
            var populationSize = int.Parse(TextBoxPopulationSize.Text);
            var chromosomeLength = int.Parse(TextBoxChromosomes.Text);

            var geneticAlgorithm = new GeneticAlgorithm(populationSize, chromosomeLength);
        }
    }
}
