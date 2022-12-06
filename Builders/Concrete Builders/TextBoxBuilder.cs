using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace File_Converter.Builders.Concrete_Builders
{
    public class TextBoxBuilder : ITextBoxBuilder
    {
        TextBox _textBox;
        public TextBoxBuilder()
        {
            _textBox = new TextBox();
        }
        public TextBox GetComponent()
        {
            return _textBox;
        }
        public ITextBoxBuilder SetName(string name)
        {
            _textBox.Name = name;
            return this;
        }

        public ITextBoxBuilder SetText(string text)
        {
            _textBox.Text = text;
            return this;
        }

        public ITextBoxBuilder SetPosition(int x, int y)
        {
            _textBox.Location = new Point(x, y);
            return this;
        }

        public ITextBoxBuilder SetSize(int x, int y)
        {
            _textBox.Size = new Size(x, y);
            return this;
        }
    }
}
