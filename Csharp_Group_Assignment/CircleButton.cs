using System;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Csharp_Group_Assignment {

    // Taken from https://www.youtube.com/watch?v=U6cil0Gtb44
    class CircleButton : Button {
        protected override void OnPaint(PaintEventArgs pevent) {
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(grPath);
            base.OnPaint(pevent);
        }
    }
}
