using System.Drawing;
using System.Windows.Forms;

namespace Snake.Models
{
    /// <summary>
    /// Piece of the Snake body part to print in UI as a label.
    /// </summary>
    public class Piece: Label
    {
        /// <summary>
        /// Piece Constructor
        /// </summary>
        /// <param name="positionX">The X Position</param>
        /// <param name="positionY">THe Y Position</param>
        public Piece(int positionX, int positionY)
        {
            Location = new Point(positionX, positionY);
            Size = new Size(20, 20);
            BackColor = Color.DarkOrange;
            Enabled = false;
        }
    }
}