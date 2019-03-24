namespace Hkx.Windows.Form
{
    public class TextBox:System.Windows.Forms.TextBox
    {
        public TextBox(): base()
        {
            this.MaxLength = 20;
        }

    }
}
