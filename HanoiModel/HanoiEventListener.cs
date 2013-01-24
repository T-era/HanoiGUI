using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HanoiModel
{
    using HanoiModel.StepByStep;
    public class HanoiEventListener
    {
        public bool IsRunning { private set; get; }

        private IList<StepMove> steps = null;
        private readonly IHanoiControler controler;
        public HanoiEventListener(IHanoiControler controler)
        {
            this.controler = controler;
            this.IsRunning = false;
        }

        public void SetMoving(object o, IPlateMoving moving)
        {
            steps = HanoiSequencer.Sequence(moving);
            IsRunning = true;
        }

        public void DigestStep()
        {
            if (!IsRunning) return;

            var step = FirstStep();
            if (step != null)
            {
                controler.RemovePlate(step.From);
                controler.AddPlate(step.To, step.Plate);
            }
            else
            {
                step = null;
                IsRunning = false;
            }
        }
        private StepMove FirstStep()
        {
            if (steps.Count == 0) return null;
            var step = steps[0];
            steps.Remove(step);
            return step;
        }
    }

    internal static class HanoiSequencer
    {
        internal static IList<StepMove> Sequence(IPlateMoving moving)
        {
            IList<StepMove> list = new List<StepMove>();
            Sequence(list, moving.Plates, moving.From, moving.To);
            return list;
        }

        private static void Sequence(IList<StepMove> list, IList<IPlate> plates, Position from, Position to)
        {
            if (plates.Count == 0) return;

            Position temp = Not(from, to);
            Sequence(list, plates.Take(plates.Count - 1).ToList(), from, temp);
            list.Add(new StepMove(from, to, plates[plates.Count - 1]));
            Sequence(list, plates.Take(plates.Count - 1).ToList(), temp, to);
        }

        private static Position Not(Position x, Position y)
        {
            if (x == Position.A && y == Position.B) return Position.C;
            if (x == Position.A && y == Position.C) return Position.B;
            if (x == Position.B && y == Position.C) return Position.A;
            return Not(y, x);
        }
    }
}
