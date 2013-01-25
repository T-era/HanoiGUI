using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HanoiGUI
{
    using HanoiModel;

    public partial class Plate : UserControl, IPlate
    {
        internal const int PLATE_HEIGHT = 10;

        internal int PlateNo { private set; get; }
        internal Column NowOn { set; get; }

        private Color BorderColorL;
        private Color BorderColorD;
        public override Color BackColor
        {
            get { return base.BackColor; }
            set
            {
                base.BackColor = value;
                this.BorderColorL = GetNewColor(value, x => (x + 255) / 2);
                this.BorderColorD = GetNewColor(value, x => x * 4 / 5);
            }
        }
        private Color GetNewColor(Color b, Func<int, int> f) {
            return Color.FromArgb(b.A, f(b.R), f(b.G), f(b.B));
        }

        public Plate()
        {
            InitializeComponent();

            this.BackColor = Color.LightGray;
            this.Height = PLATE_HEIGHT;
        }

        private const int MIN_WIDTH = 30;
        private const int MAX_WIDTH = 100;
        internal static Plate[] CreatePlates(int num)
        {
            if (num == 1)
            {
                return new[] { new Plate() { Width = MAX_WIDTH, PlateNo = 1 } };
            }
            else
            {
                int d = (MAX_WIDTH - MIN_WIDTH) / (num - 1);
                Plate[] ret = new Plate[num];
                for (int i = 0; i < num; i++)
                {
                    ret[i] = new Plate() { Width = MAX_WIDTH - d * i, PlateNo = num - i };
                }
                return ret;
            }
        }
        public override string ToString()
        {
            return this.PlateNo.ToString();
        }

        internal void SetMoving(bool b)
        {
            if (b)
            {
                this.BackColor = Color.White;
            }
            else
            {
                this.BackColor = Color.LightGray;
            }
        }

        internal bool IsMovablePlate()
        {
            return PlateNo == 1
                || NowOn.TopPlate.PlateNo == 1
                || NowOn.TopPlate.PlateNo == PlateNo;
        }

        private const int BORDER_WIDTH = 1;
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.FillRectangle(new SolidBrush(BorderColorL), 0, 0, Width, BORDER_WIDTH);
            e.Graphics.FillRectangle(new SolidBrush(BorderColorL), 0, 0, BORDER_WIDTH, Height);
            e.Graphics.FillRectangle(new SolidBrush(BorderColorD), 0, Height - BORDER_WIDTH, Width, BORDER_WIDTH);
            e.Graphics.FillRectangle(new SolidBrush(BorderColorD), Width - BORDER_WIDTH, 0, BORDER_WIDTH, Height);
        }
    }
}
