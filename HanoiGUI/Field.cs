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

    public partial class Field : UserControl
    {
        internal event EventHandler<PlateMovingEvent> PlateMoving
        {
            add
            {
                ColumnA.PlateMoving += value;
                ColumnB.PlateMoving += value;
                ColumnC.PlateMoving += value;
            }
            remove
            {
                throw new NotSupportedException();
            }
        }

        internal Column this[Position p]
        {
            get
            {
                switch (p)
                {
                    case Position.A:
                        return ColumnA;
                    case Position.B:
                        return ColumnB;
                    case Position.C:
                        return ColumnC;
                    default:
                        throw new Exception();
                }
            }
        }

        public Field()
        {
            InitializeComponent();
        }

        internal void InitPlates(int number)
        {
            ColumnA.ClearPlate();
            ColumnB.ClearPlate();
            ColumnC.ClearPlate();
            foreach (var plate in Plate.CreatePlates(number))
            {
                var temp = plate;
                temp.MouseDown += (o, e) =>
                {
                    if (temp.IsMovablePlate())
                    {
                        this.DoDragDrop(new PlateDrag(temp.NowOn, temp, temp.NowOn.MovingPlateOver(temp).ToList<IPlate>()), DragDropEffects.Move);
                    }
                };
                ColumnA.AddPlate(temp);
            }
            Field_SizeChanged();
        }

        private void Field_SizeChanged(object sender, EventArgs e)
        {
            Field_SizeChanged();
        }
        private void Field_SizeChanged()
        {
            ColumnA.Width = this.Width / 3;
            ColumnB.Width = this.Width / 3;
            ColumnC.Width = this.Width / 3;

            ColumnA.Left = 0;
            ColumnB.Left = this.Width / 3;
            ColumnC.Left = this.Width / 3 * 2;
        }
    }
}
