using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HanoiGUI
{
    using HanoiModel;

    public partial class Form1 : Form
    {
        private HanoiEventListener listener;
        public HanoiEventListener Listener
        {
            set
            {
                listener = value;
                this.field1.PlateMoving += value.SetMoving;
            }
        }

        internal Column this[Position p]
        {
            get
            {
                return field1[p];
            }
        }
        public Form1()
        {
            InitializeComponent();

            this.timer1.Tick += (o, e) =>
            {
                listener.DigestStep();
            };
            Listener = new HanoiEventListener(new MyControler(this));
        }

        private void InitButton_Click(object sender, EventArgs e)
        {
            this.field1.InitPlates((int)NumberOfPlates.Value);
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            this.timer1.Interval = trackBar1.Value;
        }
    }
    internal class MyControler : IHanoiControler
    {
        private readonly Form1 form;
        internal MyControler(Form1 form) {
            this.form = form;
        }
        public void InvalidateWindow()
        {
            form.Invalidate();
        }

        public void RemovePlate(Position p)
        {
            form[p].RemovePlate();
        }

        public void AddPlate(Position p, IPlate plate)
        {
            form[p].AddPlate((Plate)plate);
        }
    }
}
