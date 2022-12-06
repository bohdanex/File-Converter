using System.Drawing;
using System.Windows.Forms;

namespace File_Converter.Builders
{
    public class LabelBuilder : ILabelBuilder
    {
        private Label _label = new Label();
        public Label GetComponent()
        {
            return _label;
        }

        public ILabelBuilder SetName(string name)
        {
            _label.Name = name;
            return this;
        }
        public ILabelBuilder SetText(string text)
        {
            _label.Text = text; 
            return this;
        }
        public ILabelBuilder SetFontSize(float fontSize) 
        {
            _label.Font = new Font("Segoe UI", fontSize);
            return this;
        }
        public ILabelBuilder SetPosition(int x, int y)
        {
            Point position = new Point(x, y);
            _label.Location = position;
            return this;
        }

        public ILabelBuilder AutoScale(bool isAutoSize)
        {
            _label.AutoSize = isAutoSize;
            return this;
        }
    }
}
