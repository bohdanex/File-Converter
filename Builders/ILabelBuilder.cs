using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace File_Converter.Builders
{
    public interface ILabelBuilder
    {
        Label GetComponent();
        ILabelBuilder SetName(string name);
        ILabelBuilder SetText(string text);
        ILabelBuilder SetFontSize(float fontSize);
        ILabelBuilder SetPosition(int x, int y);
        ILabelBuilder AutoScale(bool isAutoSize);
    }
}
