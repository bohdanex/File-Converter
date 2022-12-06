using System;
using System.Collections.Generic;
using System.Text;

//facade
namespace File_Converter
{
    //The main task of this class - make filtering options and return us a string
    //Filter option example without method: "Video files(*.mp4; *.mkv)|*.mp4;*.mkv"
    //With using this class method: Filter("Video files", _formatList(automatically sets by Singleton class))
    public class TypeFilterManager
    {
        public static string Filter(string text, List<string> typeList)
        {
            StringBuilder strBuilderFilter = new StringBuilder(text + " (");

            for (int i = 0; i < typeList.Count; i++)
            {
                strBuilderFilter.Append("*." + typeList[i] + "; ");
            }

            strBuilderFilter.Remove(strBuilderFilter.Length - 2, 2);
            strBuilderFilter.Append(")|");

            for (int i = 0; i < typeList.Count; i++)
            {
                strBuilderFilter.Append("*." + typeList[i] + ";");
            }

            strBuilderFilter.Remove(strBuilderFilter.Length - 1, 1);
            return strBuilderFilter.ToString();
        }
    }
}
