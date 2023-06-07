using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
public class HoverButton : Button
{
    private Color _hoverColor = Color.Red;

    public Color HoverColor
    {
        get { return _hoverColor; }
        set { _hoverColor = value; }
    }

    public HoverButton()
    {
        MouseEnter += OnMouseEnter;
        MouseLeave += OnMouseLeave;
    }

    private void OnMouseEnter(object sender, EventArgs e)
    {
        ForeColor = HoverColor;
    }

    private void OnMouseLeave(object sender, EventArgs e)
    {
        if(BackColor == Color.Black) {
            ForeColor = Color.White;
        }
        else
        {
            ForeColor = Color.Black;
        }
   
    }
}
