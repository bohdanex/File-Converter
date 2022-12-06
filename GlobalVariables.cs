using System.Collections.Generic;
using System.Windows.Forms;

namespace File_Converter
{
    //This is Singleton class
    public sealed class GlobalVariables
    {
        //this variable depends the on pressed button in the SelectConverterForm
        public static string SelectedForm { get; set; }
        //this Collection is responsible for the converter availible formats 
        public static Form ActiveForm { get; set; }
        public static List<string> GetFormatList()
        {
            switch (SelectedForm)
            {
                case "Video":
                    return _videoFormatList;
                case "Audio":
                    return _audioFormatList;
                case "Text":
                    return _textFormatList;
                default: return new List<string>();
            }
        }
        private static List<string> _videoFormatList = new List<string>()
        {
            "mkv",
            "wmv",
            "mp4",
            "avi",
        };
        private static List<string> _audioFormatList = new List<string>()
        {
            "mp3",
            "ogg",
            "wav",
            "flac",
        };
        private static List<string> _textFormatList = new List<string>()
        {
            "doc",
            "docx",
            "pdf",
            "rtf",
            "txt",
            "html",
        };
    }
}
