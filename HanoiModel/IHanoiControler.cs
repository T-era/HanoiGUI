using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HanoiModel
{
    public interface IHanoiControler
    {
        void AddPlate(Position position, IPlate plate);
        void RemovePlate(Position position);

        void InvalidateWindow();
    }
}
