namespace Hkx.Windows.Form
{
    public class Button : System.Windows.Forms.Button
    {
        public Button():base()
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
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath grPath =
                new System.Drawing.Drawing2D.GraphicsPath();

            grPath.AddEllipse(1, 1, ClientSize.Width, ClientSize.Height);

            this.Region = new System.Drawing.Region(grPath);

            base.OnPaint(e);
        }
    } 
}
