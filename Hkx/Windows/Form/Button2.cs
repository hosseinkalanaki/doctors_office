namespace Hkx.Windows.Form
{
    public class Button2 : System.Windows.Forms.Button
    {

        public Button2()
        {

        }

        protected override void OnMouseEnter(System.EventArgs e)
        {
            base.OnMouseEnter(e);

            BackColor = System.Drawing.Color.Khaki;
        }

        protected override void OnMouseLeave(System.EventArgs e)
        {
            base.OnMouseLeave(e);

            BackColor = System.Drawing.Color.Silver;
        }
    }
}
