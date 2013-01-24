using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HanoiModel
{
    public interface IPlateMoving
    {
        Position From { get; }
        Position To { get; }
        IPlate Current { get; }
        IList<IPlate> Plates { get; }
    }
}
