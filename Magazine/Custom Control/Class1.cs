using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedButton : Button
{
    private int _cornerRadius = 25;
    public int CornerRadius
    {
        get { return _cornerRadius; }
        set
        {
            if (_cornerRadius != value)
            {
                _cornerRadius = value;
                Invalidate();
            }
        }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        GraphicsPath path = new GraphicsPath();
        int radius = CornerRadius * 2;

        // Top left arc
        path.AddArc(0, 0, radius, radius, 180, 90);

        // Top side line
        path.AddLine(CornerRadius, 0, Width - CornerRadius, 0);

        // Top right arc
        path.AddArc(Width - radius, 0, radius, radius, 270, 90);

        // Right side line
        path.AddLine(Width, CornerRadius, Width, Height - CornerRadius);

        // Bottom right arc
        path.AddArc(Width - radius, Height - radius, radius, radius, 0, 90);

        // Bottom side line
        path.AddLine(Width - CornerRadius, Height, CornerRadius, Height);

        // Bottom left arc
        path.AddArc(0, Height - radius, radius, radius, 90, 90);

        // Left side line
        path.AddLine(0, Height - CornerRadius, 0, CornerRadius);

        path.CloseFigure();
        Region = new Region(path);

        base.OnPaint(e);
    }

}
