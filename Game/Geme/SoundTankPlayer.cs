using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    [Serializable]
    abstract class SoundTankPlayer : DrivingTankPlayer
    {
        /// <summary>
        /// �����������
        /// </summary>
        /// <param name="rect">������������� ����������� ������� ������� �� ������, ������ � ������</param>
        /// <param name="velocity">��������</param>
        /// <param name="direction">����������� ��������</param>
        public SoundTankPlayer(Rectangle rect, int velocity, Direction direction, int velosityShel)
            : base(rect, velocity, direction, velosityShel)
        { }

        protected void PlaySound()
        {
            if (!isParking)
            {
                SoundGame.SoundMove();
            }
            else if (isParking)
            {
                SoundGame.SoundStop();
            }
        }
    }
}