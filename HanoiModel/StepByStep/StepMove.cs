using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HanoiModel.StepByStep
{
    internal class StepMove
    {
        internal Position From { private set; get; }
        internal Position To { private set; get; }
        internal IPlate Plate { private set; get; }

        internal StepMove(Position from, Position to, IPlate plate)
        {
            this.From = from;
            this.To = to;
            this.Plate = plate;
        }
    }
}
