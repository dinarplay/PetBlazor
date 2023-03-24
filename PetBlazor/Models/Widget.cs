using PetBlazor.Components;

namespace PetBlazor.Models
{
    public class Widget
    {
        public Widget()
        {
            widgets = new List<Type>();
        }
        public List<Type> widgets;
        private bool _showParser;
        public bool ShowParser
        {
            get
            {
                return _showParser;
            }
            set
            {
                _showParser = value;
                if (_showParser)
                {
                    if (widgets.Contains(typeof(ParserComponent)))
                        return;
                    else
                        widgets.Add(typeof(ParserComponent));
                }
                else
                {
                    widgets.Remove(typeof(ParserComponent));
                }
            }
        }
        private bool _showPassGen;
        public bool ShowPassGen
        {
            get
            {
                return _showPassGen;
            }
            set
            {
                _showPassGen = value;
                if (_showPassGen)
                {
                    if (widgets.Contains(typeof(PassGenerateComponent)))
                        return;
                    else
                        widgets.Add(typeof(PassGenerateComponent));
                }
                else
                {
                    widgets.Remove(typeof(PassGenerateComponent));
                }
            }
        }
    }
}
