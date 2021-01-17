﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceShooter
{
    public abstract class Lazer
    {
        Direction direction;

        int LazerPosLeft;
        int LazerPosRight;

        int speed = 20;

        PictureBox lazer = new PictureBox();

        Timer lazerTimer = new Timer();

        public Direction Direction { get => direction; set => direction = value; }
        public int LazerPosLeft1 { get => LazerPosLeft; set => LazerPosLeft = value; }
        public int LazerPosTop { get => LazerPosRight; set => LazerPosRight = value; }
        public int Speed { get => speed; set => speed = value; }
        public PictureBox CurrentLazer { get => lazer; set => lazer = value; }
        public Timer LazerTimer { get => lazerTimer; set => lazerTimer = value; }

        public virtual void CreateLazer(Form form)
        {
            CurrentLazer.BackColor = Color.Transparent;
            CurrentLazer.Left = LazerPosLeft;
            CurrentLazer.Top = LazerPosTop;
            CurrentLazer.BringToFront();
            form.Controls.Add(CurrentLazer);

            lazerTimer.Interval = Speed;
            lazerTimer.Tick += new EventHandler(LazerTick);
            lazerTimer.Start();
        }

        private void LazerTick(object sender, EventArgs e)
        {
            if(Direction == Direction.left)
            {
                CurrentLazer.Left -= Speed;
            }

            if (Direction == Direction.right)
            {
                CurrentLazer.Left += Speed;
            }

            if (Direction == Direction.up)
            {
                CurrentLazer.Top -= Speed;
            }

            if (Direction == Direction.down)
            {
                CurrentLazer.Top += Speed;
            }

            if(CurrentLazer.Right < 0 || CurrentLazer.Left > 1000 || CurrentLazer.Bottom < 0 || CurrentLazer.Top > 900)
            {
                lazerTimer.Stop();
                lazerTimer.Dispose();
                CurrentLazer.Dispose();

               lazerTimer = null;
              CurrentLazer = null;
            }





        }
    }
}
