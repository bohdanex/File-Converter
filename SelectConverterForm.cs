using System;
using System.Windows.Forms;

namespace File_Converter
{
    public partial class SelectConverterForm : Form
    {
        FormConverter goToForm;
        public SelectConverterForm()
        {
            InitializeComponent();
        }

        private void buttonConverter_Click(object sender, EventArgs e)
        {
            Button currentButton = (Button)sender;
            GlobalVariables.SelectedForm = currentButton.Tag.ToString();
            //preventing multiple windows
            if(goToForm != null)
            {
                goToForm.Dispose();
                goToForm= null;
            }
            goToForm = new FormConverter();
            goToForm.Show();
        }
    }
}
