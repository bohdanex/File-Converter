using File_Converter.Builders;
using File_Converter.Builders.Concrete_Builders;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace File_Converter.Converter_Factory.Concrete_Factory
{
    public class AudioConverterFactory : ConverterFactory
    {
        public override Label RenderTitle(ILabelBuilder labelBuilder)
        {
            return (labelBuilder.SetName("labelInfo")
                .SetFontSize(12).SetText("Please select an audio file from your \nlocal machine or enter audio file path")
                .SetPosition(12, 62).AutoScale(true)
                .GetComponent());
        }
        public override TextBox RenderTextBox(ITextBoxBuilder textBoxBuilder)
        {
            return textBoxBuilder.SetName("textBoxPath")
                .SetPosition(12, 171).SetSize(389, 27).GetComponent();
        }
    }
}
