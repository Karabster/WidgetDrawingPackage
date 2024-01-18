namespace WidgetDrawingPackage
{
    public class Textbox : Rectangle
    {
        public Textbox(int x, int y, int width, int height, string text) 
            : base(x, y, width, height)
        {
            _text = text;
        }

        public override string ToString()
        {
            return $"{base.ToString()} text=\"{_text}\"";
        }

        private string _text { get; }
    }
}
