using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Runaway_Button
{
    public partial class MainWindow : Form
    {
        private Point _prevMousePosition;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void runningBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Поздравляем! Вы смогли нажать на кнопку!");
        }

        private void MainWindow_MouseMove(object sender, MouseEventArgs e)
        {
            Point mouseChange = Point.Subtract(MousePosition, new Size(_prevMousePosition));

            // Тернарные операторы нужны чтобы когда курсор отдаляется от кнопки она не бежала за ним.
            // Добавляем 10 по оси Y чтобы компенсировать "шапку" окна, если этого не сделать, 
            // то кнопка, загнанная наверх, никогда оттуда не вылезет.
            Point newPosition = new Point(
                Math.Abs(runningBtn.Location.X + runningBtn.Width / 2 + Bounds.X - MousePosition.X) 
                <= Math.Abs(runningBtn.Location.X + runningBtn.Width / 2 + Bounds.X - _prevMousePosition.X)
                ? runningBtn.Location.X + mouseChange.X : runningBtn.Location.X,
                Math.Abs(runningBtn.Location.Y + runningBtn.Height / 2 + Bounds.Y + 10 - MousePosition.Y) 
                <= Math.Abs(runningBtn.Location.Y + runningBtn.Height / 2 + Bounds.Y + 10 - _prevMousePosition.Y)
                ? runningBtn.Location.Y + mouseChange.Y : runningBtn.Location.Y);
            
            // Не даем кнопке выйти за пределы экрана.
            if (newPosition.X < 0) newPosition.X = 0;
            if (newPosition.Y < 0) newPosition.Y = 0;
            if (newPosition.X > ClientRectangle.Width - runningBtn.Width) newPosition.X 
                    = ClientRectangle.Width - runningBtn.Width;
            if (newPosition.Y > ClientRectangle.Height - runningBtn.Height) newPosition.Y 
                    = ClientRectangle.Height - runningBtn.Height;
            
            runningBtn.Location = newPosition;
            _prevMousePosition = MousePosition;
                }

        private void MainWindow_MouseEnter(object sender, EventArgs e)
        {
            _prevMousePosition = MousePosition;
        }
    }
}
