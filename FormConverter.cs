using System;
using System.Collections.Generic;
using System.Windows.Forms;
using File_Converter.Converter_Factory;
using File_Converter.Converter_Factory.Concrete_Factory;

namespace File_Converter
{
    public partial class FormConverter : Form
    {
        private TextBox _textBoxPath;
        private string _filterType;
        private ConverterFactory _currentFactory;
        
        public FormConverter()
        {
            InitializeComponent();
            PageSetup();
        }

        public void PageSetup()
        {
            //Setting the title and the form name
            this.Text = GlobalVariables.SelectedForm + " file Converter";
            labelTitle.Text = this.Text;
            //Sets the active form as reference
            GlobalVariables.ActiveForm = this;
            //Factories initialization
            if (GlobalVariables.SelectedForm == "Video") 
                _currentFactory= new VideoConverterFactory();
            else if(GlobalVariables.SelectedForm == "Audio")
                _currentFactory = new AudioConverterFactory();
            else if (GlobalVariables.SelectedForm == "Text")
                _currentFactory = new TextConverterFactory();
            RenderItems(_currentFactory.AllControls);
            
            ConverterFactory.SetDropBoxItems(ref dropBoxConvertTo, GlobalVariables.GetFormatList());

            //setting up OpenFileDialog filter
            _filterType = TypeFilterManager.Filter(
                GlobalVariables.SelectedForm, GlobalVariables.GetFormatList());
        }

        private void RenderItems(List<Control> allControls)
        {
            //_textBoxPath = (TextBox)allControls.Find(item => item.Name == "textBoxPath");
            _textBoxPath = (TextBox)Controls.Find("textBoxPath", false)[0];
        }

        //Select file action whe the button is pressed
        private void buttonChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = _filterType;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
                         _textBoxPath.Text = openFileDialog.FileName;
        }
        //Convert file action when the button is pressed
        private void buttonConvert_Click(object sender, EventArgs e)
        {
            string _filePath = _textBoxPath.Text;
            _currentFactory.Convert(_filePath, dropBoxConvertTo.SelectedItem.ToString());
        }
    }
}
