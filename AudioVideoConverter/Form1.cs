using FFMpegCore;
using FFMpegCore.Enums;
using Microsoft.WindowsAPICodePack.Shell.PropertySystem;
using Microsoft.WindowsAPICodePack.Shell;
using System.Diagnostics;
using Xabe.FFmpeg;

namespace AudioVideoConverter
{
    public partial class Form1 : Form
    {
        private static string pathToAddFiles = string.Empty;
        private static string destination = string.Empty;
        private static string[] pathWithFiles = { };
        private static string[] allFiles = { };
        private static HashSet<string> filesNames = new HashSet<string>();

        public Form1()
        {
            InitializeComponent();
            Thread thread = new Thread(PathToDesktop);
            thread.Start();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Clear();
            GetPath();

            richTextBoxItems.Text = string.Join("\r\n", pathWithFiles);

            AddFilesToHasSet();

            richTextBoxItems.Clear();
            richTextBoxItems.Text = string.Join("\r\n", filesNames);

            labelPath.Text = $"Path from: {pathToAddFiles}";
            labelItems.Text = $"Items: {filesNames.Count()}";
        }
        private void PathToDesktop()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            comboBoxDestination.Text = path;
        }
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            string selectedFile = richTextBoxItems.SelectedText;

            filesNames.Remove(selectedFile);

            richTextBoxItems.Text = string.Join("\r\n", filesNames);
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            SaveDestination();
            comboBoxDestination.Text = destination;
        }
        private void SaveDestination()
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                destination = folderBrowserDialog1.SelectedPath;
            }
        }
        private string[] GetPath()
        {
            OpenFileDialog openFileDialog1 = OpenFile();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pathToAddFiles = Path.GetDirectoryName(openFileDialog1.FileName)!;

                pathWithFiles = openFileDialog1.FileNames;
            }
            return pathWithFiles;
        }

        private static OpenFileDialog OpenFile()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog()
            {
                InitialDirectory = @"C:\",
                Title = "Browse AudioVideo Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "All Files",
                Filter = "All Files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true,

                Multiselect = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true,

            };
            return openFileDialog1;

        }

        private HashSet<string> AddFilesToHasSet()
        {
            string[] files = richTextBoxItems.Text.Split("\n");
            //string[] files = Directory.GetFiles(path);

            for (int i = 0; i < files.Length; i++)
            {
                string file = files[i];
                string[] fileName = file.Split('\\');
                filesNames.Add(fileName[fileName.Length - 1]);
            }
            return filesNames;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            string Mp3 = ".mp3";
            string Avi = ".avi";
            string Flv = ".flv";
            string Mp4 = ".mp4";
            string Mkv = ".mkv";
            string otherFormat = comboBoxFormats.Text;

            progressBarAll.Minimum = 0;
            progressBarAll.Maximum = pathWithFiles.Length;
            progressBarAll.Value = 0;

            if (comboBoxFormats.Text != "MP3"
                && comboBoxFormats.Text != "AVI"
                && comboBoxFormats.Text != "FLV"
                && comboBoxFormats.Text != "MP4"
                && comboBoxFormats.Text != "MKV")
            {
                Convert(otherFormat);
            }
            else if (comboBoxFormats.SelectedItem.ToString() == "MP3")
            {
                Convert(Mp3);
            }
            else if (comboBoxFormats.SelectedItem.ToString() == "MKV")
            {
                Convert(Mkv);
            }
            else if (comboBoxFormats.SelectedItem.ToString() == "AVI")
            {
                Convert(Avi);
            }
            else if (comboBoxFormats.SelectedItem.ToString() == "FLV")
            {
                Convert(Flv);
            }
            else if (comboBoxFormats.SelectedItem.ToString() == "MP4")
            {
                Convert(Mp4);
            }

            MessageBox.Show("Waiting Complete");
        }

        private void Convert(string Mp3)
        {
            int countFiles = 0;

            foreach (var pathWithFile in pathWithFiles)
            {
                countFiles++;

                string[] fileName = pathWithFile.Split('\\');
                string fileNewFormat = string.Empty;
                string file = fileName[fileName.Length - 1];
                string[] arrNewFile = file.Split('.');

                for (int i = 0; i < arrNewFile.Length - 1; i++)
                {
                    fileNewFormat += arrNewFile[i];
                    if (i < arrNewFile.Length - 2)
                    {
                        fileNewFormat += '.';
                    }
                }

                //For .NotifyOnProgress()
                //==============================================================================
                Action<double> progressHandler = new Action<double>(p =>
                {
                    //progress value from 0 to 100
                    Debug.WriteLine(p);
                });

                ShellObject shell = ShellObject.FromParsingName(pathWithFile);
                // alternatively: shell.Properties.GetProperty("System.Media.Duration");
                IShellProperty prop = shell.Properties.System.Media.Duration;
                // Duration will be formatted as 00:44:08
                string duration = prop.FormatForDisplay(PropertyDescriptionFormatOptions.None);

                TimeSpan ts = TimeSpan.Parse(duration);
                //==============================================================================

                fileNewFormat += Mp3;
                destination = comboBoxDestination.Text;

                string output2 = Path.Combine($"{destination}\\{fileNewFormat}");
                string inputVideoPath = pathWithFile;


                FFMpegArguments
                    .FromFileInput(inputVideoPath)
                    .OutputToFile(output2)
                    //.NotifyOnProgress(progressHandler, ts)
                    .ProcessSynchronously();

                progressBarAll.Value = countFiles;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            filesNames.Clear();
            richTextBoxItems.Clear();
            pathToAddFiles = string.Empty;
            destination = string.Empty;
            pathWithFiles = null!;
        }
    }
}