using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HanoiGUI.Control
{
    using HanoiModel;

    class PlateDrag
    {
        internal Column From { private set; get; }
        internal Plate Current { private set; get; }
        internal IList<IPlate> Plates { private set; get; }

        internal PlateDrag(Column from, Plate current, IList<IPlate> plates)
        {
            this.From = from;
            this.Current = current;
            this.Plates = plates;
        }
    }
}
