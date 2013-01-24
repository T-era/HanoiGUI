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
    }
}
