using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HanoiGUI.Control
{
    using HanoiModel;

    class PlateMovingEvent : EventArgs, IPlateMoving
    {
        public Position From { private set; get; }
        public Position To { private set; get; }
        public IPlate Current { private set; get; }
        public IList<IPlate> Plates { private set; get; }

        internal PlateMovingEvent(PlateDrag drag, Position to)
        {
            this.From = drag.From.Where;
            this.To = to;
            this.Current = drag.Current;
            this.Plates = drag.Plates;
        }
    }
}
