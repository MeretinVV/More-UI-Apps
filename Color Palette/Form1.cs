using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color_Palette
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            palette.BackColor = Color.FromArgb(redTrack.Value, greenTrack.Value, blueTrack.Value);
        }

        private void colorTrack_Scroll(object sender, EventArgs e)
        {
            palette.BackColor = Color.FromArgb(redTrack.Value, greenTrack.Value, blueTrack.Value);
        }

        private void palette_BackColorChanged(object sender, EventArgs e)
        {
            Clipboard.SetText(ColorTranslator.ToHtml(palette.BackColor));
        }

        private void palette_MouseHover(object sender, EventArgs e)
        {
            // Можно было бы вытаскивать код из буфера обмена, но тогда если
            // приложение свернуть и что-то скопировать, вместо кода будет скопированный текст.
            hintLbl.Text = ColorTranslator.ToHtml(palette.BackColor);
            hintLbl.Location = Point.Subtract(MousePosition, new Size(Bounds.Location));
            hintLbl.Visible = true;
        }

        private void palette_MouseLeave(object sender, EventArgs e)
        {
            hintLbl.Visible = false;
        }
    }
}
