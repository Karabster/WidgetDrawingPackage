namespace WidgetDrawingPackage
{
    public class Textbox : Rectangle
    {
        public Textbox(int x, int y, int width, int height, string text) 
            : base(x, y, width, height)
        {
            Text = text;
        }

        public override string ToString()
        {
            return $"{base.ToString()} Text=\"{Text}\"";
        }

        internal string Text { get; }
    }
}
