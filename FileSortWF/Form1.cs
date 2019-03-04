using FileSortWF.Shared_Classes;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSortWF
{
    public partial class Form1 : Form
    {
        private string directoryPath;
        private string destinationPath;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Directory_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = "C:\\Users";
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                directoryPath = dialog.FileName;
                DirectoryTextBox.Text = dialog.FileName;
            }
        }

        private void DestinationButton_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = "C:\\Users";
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                destinationPath = dialog.FileName;
                DestinationTextBox.Text = dialog.FileName;
            }
        }

        private async void SortButton_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(DirectoryTextBox.Text) && Directory.Exists(DestinationTextBox.Text))
            {
                ErrorLabel.Text = "";
                CurrentSortLabel.Text = "";
                SortButton.Enabled = false;
                await ProcessSorts();
                SortButton.Enabled = true;
                CurrentSortLabel.Text = "Sort complete";
            }
            else
            {
                ErrorLabel.Text = "Invalid directories chosen";
            }
        }

        private async Task ProcessSorts()
        {
            List<String> checkboxStrings = SortOptionCheckBoxes.CheckedItems.OfType<String>().ToList().ConvertAll(e => e.ToLower());

            CurrentSortLabel.Text = "Please wait...";

            var progress = new Progress<int>(value => ProgressBar.Value = value);
            ProgressBar.Maximum = SortOptionCheckBoxes.CheckedItems.Count;
            List<string> la = new List<string>();
            int counter = 0;
            await Task.Run(() =>
            {
                Parallel.ForEach(checkboxStrings, (option) =>
                {
                    Types type;
                    Enum.TryParse(option, out type);
                    if (type == Types.media)
                    {
                        TypeClasses.Media mediaSort = new TypeClasses.Media(this.directoryPath, this.destinationPath);
                    }
                    else
                    {
                        TypeClasses.Default defaultSort = new TypeClasses.Default(this.directoryPath, this.destinationPath, type);
                    }
                    counter++;
                    ((IProgress<int>)progress).Report(counter);
                });
            });
        }
    }
}
