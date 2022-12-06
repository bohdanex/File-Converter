using System.Collections.Generic;
using System.Windows.Forms;

namespace File_Converter.Converter_Factory
{
    //this is a factory method class
    //It sets the UI building rules for class that derives
    public abstract class ConverterFactory
    {
        //Control components Collection
        public virtual List<Control> AllControls { get; set; }
        protected ConverterFactory()
        {
            AllControls = new List<Control>
            {
                RenderTitle(),
                RenderTextBox(),
            };
            GlobalVariables.ActiveForm.Controls.AddRange(AllControls.ToArray());
        }
        public abstract Label RenderTitle();
        public abstract TextBox RenderTextBox();
        //Sets up the ComboBox contoller items and rules
        public static void SetDropBoxItems(ref ComboBox comboBox, List<string> typeList)
        {
            comboBox.Items.Clear();
            comboBox.Items.AddRange(typeList.ToArray());
            comboBox.SelectedIndex = 0;
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        //this method picks the suitable converter method
        //can be overridden
        public virtual void Convert(string filePath, string convertTo) => 
            FileConverter.ConvertMedia(filePath, convertTo); 
    }
}
