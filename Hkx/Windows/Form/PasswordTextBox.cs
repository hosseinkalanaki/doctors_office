namespace Hkx.Windows.Form
{
    public class PasswordTextBox: System.Windows.Forms.TextBox
    {
        public PasswordTextBox():base()
        {
            this.MaxLength = 40;
            this.PasswordChar = '●';
            this.UseSystemPasswordChar = true;

        }

    }
}
