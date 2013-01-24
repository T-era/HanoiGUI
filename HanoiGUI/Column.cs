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
    using HanoiGUI.Control;
    using HanoiModel;

    public partial class Column : UserControl
    {
        internal event EventHandler<PlateMovingEvent> PlateMoving;

        private readonly LinkedList<Plate> plates = new LinkedList<Plate>();
        public Position Where { set; get; }
        public Plate TopPlate { get { return plates.First.Value; } }

        public Column()
        {
            InitializeComponent();
        }

        internal void ClearPlate()
        {
            plates.Clear();
            this.Controls.Clear();
        }
        internal void AddPlate(Plate plate)
        {
            plate.NowOn = this;
            plate.SetMoving(false);

            plates.AddFirst(plate);
            this.Controls.Add(plate);
            ResetPosition();
        }
        internal Plate RemovePlate()
        {
            var plate = plates.First.Value;
            plates.RemoveFirst();
            this.Controls.Remove(plate);
            return plate;
        }

        internal IEnumerable<Plate> MovingPlateOver(Plate temp)
        {
            foreach (var plate in plates)
            {
                plate.SetMoving(true);
                yield return plate;
                if (plate == temp)
                {
                    break;
                }
            }
        }

        private void Column_SizeChanged(object sender, EventArgs e)
        {
            ResetPosition();
            Invalidate();
        }
        private void ResetPosition()
        {
            int count = plates.Count;
            foreach (var plate in plates)
            {
                plate.Top = this.Height - 20 - Plate.PLATE_HEIGHT * count;
                plate.Left = (this.Width / 2) - (plate.Width / 2);
                count--;
            }
        }

        private void Column_DragDrop(object sender, DragEventArgs e)
        {
            PlateDrag ddObject = (PlateDrag)e.Data.GetData(typeof(PlateDrag));
            if (ddObject != null)
            {
                if (plates.Count == 0 || plates.First.Value.Width > ddObject.Current.Width)
                {
                    PlateMoving(this, new PlateMovingEvent(ddObject, this.Where));
                }
                else
                {
                    throw new Exception("NG");
                }
            }
        }

        private void Column_DragOver(object sender, DragEventArgs e)
        {
            PlateDrag ddObject = (PlateDrag)e.Data.GetData(typeof(PlateDrag));
            if (ddObject != null)
            {
                if (plates.Count == 0 || plates.First.Value.Width > ddObject.Current.Width)
                {
                    e.Effect = DragDropEffects.Move;
                }
                else
                {
                    e.Effect = DragDropEffects.None;
                }
            }
        }

        private void Column_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Gray, this.Width / 2 - 2, this.Top + 10, 4, Height - 30);
        }
    }
}
