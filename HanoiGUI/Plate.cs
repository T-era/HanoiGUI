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
        internal Column NowOn { set; get; }
        internal const int PLATE_HEIGHT = 10;
        public Plate()
        {
            InitializeComponent();

            this.Height = PLATE_HEIGHT;
        }

        private const int MIN_WIDTH = 30;
        private const int MAX_WIDTH = 100;
        internal static Plate[] CreatePlates(int num)
        {
            if (num == 1)
            {
                return new[] { new Plate() { Width = MAX_WIDTH, } };
            }
            else
            {
                int d = (MAX_WIDTH - MIN_WIDTH) / (num - 1);
                Plate[] ret = new Plate[num];
                for (int i = 0; i < num; i++)
                {
                    ret[i] = new Plate() { Width = MAX_WIDTH - d * i, };
                }
                return ret;
            }
        }
        public override string ToString()
        {
            return this.Width.ToString();
        }

        internal void SetMoving(bool b)
        {
            if (b)
            {
                this.BackColor = Color.LightGray;
            }
            else
            {
                this.BackColor = Color.Brown;
            }
        }
    }

    class PlateMoveStartingEventArgs : EventArgs
    {
        public Plate Plate { set; get; }
    }
}
