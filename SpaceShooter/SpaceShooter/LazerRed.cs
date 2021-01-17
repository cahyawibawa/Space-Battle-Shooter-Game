using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceShooter
{
    class LazerRed : Lazer
    {
        public override void CreateLazer(Form form)
        {
            if(Direction == Direction.left)
            {
                CurrentLazer.Image = Properties.Resources.laserRedkn;
            }

            if (Direction == Direction.right)
            {
                CurrentLazer.Image = Properties.Resources.laserRedkn;
            }

            if (Direction == Direction.up)
            {
                CurrentLazer.Image = Properties.Resources.laserRedbwh;
            }

            if (Direction == Direction.down)
            {
                CurrentLazer.Image = Properties.Resources.laserRedbwh;
            }

            CurrentLazer.Tag = "enemyLazer";

            base.CreateLazer(form);


        }
    }
}
