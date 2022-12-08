using File_Converter.Builders;
using File_Converter.Builders.Concrete_Builders;
using System.Windows.Forms;

namespace File_Converter.Converter_Factory.Concrete_Factory
{
    public class VideoConverterFactory : ConverterFactory
    {
        public override Label RenderTitle(ILabelBuilder labelBuilder)
        {
            return (labelBuilder.SetName("labelInfo")
                .SetFontSize(12).SetText("Please select a video file from your \nlocal machine or enter the file path")
                .SetPosition(12, 62).AutoScale(true)
                .GetComponent());
        }
        public override TextBox RenderTextBox(ITextBoxBuilder textBoxBuilder)
        {
            return textBoxBuilder.SetName("textBoxPath")
                .SetPosition(12, 121).SetSize(389, 27).GetComponent();
        }
    }
}
