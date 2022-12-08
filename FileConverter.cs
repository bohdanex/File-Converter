using MediaToolkit;
using MediaToolkit.Model;
using SautinSoft.Document;
using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace File_Converter
{
    //The most important class in this app
    //The class includes methods which have file convert process 
    //This class represents facade pattern
    public static class FileConverter
    {
        //These methods convert Media using imported library
        public static void ConvertMedia(string filePath, string convertTo)
        {
            if (ErrorHandler(filePath, convertTo)) return;

            MediaFile inFile = new MediaFile(filePath);
            SaveFileDialog saveFileDialog= new SaveFileDialog();
            saveFileDialog.Filter = "|*." + convertTo;
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                MediaFile _outFileDestination = new MediaFile(saveFileDialog.FileName);
                var converterEngine = new Engine();
                try
                {
                    /*MediaToolkit.Options.ConversionOptions conversionOptions = new MediaToolkit.Options.ConversionOptions();
                    conversionOptions.CutMedia(TimeSpan.FromSeconds(0), TimeSpan.FromSeconds(12));*/
                    converterEngine.Convert(inFile, _outFileDestination);
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("File not found", "Error 1");
                    return;
                }
                MessageBox.Show("Succesfully converted", "Result");
            }
           
        }

        public static void ConvertWord(string filePath, string convertTo)
        {
            if (ErrorHandler(filePath, convertTo)) return;
            DocumentCore wordFile = DocumentCore.Load(filePath);
            string _outputName =
                filePath.Substring(0, filePath.LastIndexOf('.') + 1) + convertTo;
            wordFile.Save(_outputName);
            MessageBox.Show("Succesfully converted");
        }
        private static bool ErrorHandler(string filePath, string convertTo)
        {
            if (String.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Please enter valid path", "Error 0");
                return true;
            }
            else if (filePath.Length <= 4)
            {
                MessageBox.Show("Too small file name", "Error 4");
                return true;
            }
            string filePathType = filePath.Substring(filePath.Length - 3, 3);
            if (!GlobalVariables.GetFormatList().Contains(filePathType))
            {
                MessageBox.Show("Wrong file type", "Error 5");
                return true;
            }

            if (filePathType == convertTo)
            {
                MessageBox.Show("File types must be different", "Error 2");
                return true;
            }
            
            return false;
        }
    }
}
