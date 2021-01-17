using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceShooter
{
    class LazerBlue : Lazer
    {

        public override void CreateLazer(Form form)
        {
            if(Direction == Direction.left)
            {
                CurrentLazer.Image = Properties.Resources.laserBluekrkn;
            }

            if (Direction == Direction.right)
            {
                CurrentLazer.Image = Properties.Resources.laserBluekrkn;
            }

            if (Direction == Direction.up)
            {
                CurrentLazer.Image = Properties.Resources.laserBlue13;
            }

            if (Direction == Direction.down)
            {
                CurrentLazer.Image = Properties.Resources.laserBlue13;
            }

            CurrentLazer.Tag = "playerLazer";

            base.CreateLazer(form);
        }
    }
}
