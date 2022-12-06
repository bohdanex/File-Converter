using File_Converter.Builders.Concrete_Builders;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace File_Converter.Builders
{
    public interface ITextBoxBuilder
    {
        TextBox GetComponent();
        ITextBoxBuilder SetName(string name);
        ITextBoxBuilder SetText(string text);
        ITextBoxBuilder SetPosition(int x, int y);
        ITextBoxBuilder SetSize(int x, int y);
    }
}
