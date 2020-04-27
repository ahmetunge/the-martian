using TheMartian.Enums;
using TheMartian.Interfaces;

namespace TheMartian.Conrete
{
    public class VoucherBase : IVoucher
    {
        public VoucherBase(Position position)
        {
            Position = position;
        }

        public Position Position { get; set; }

        public Position Move(string codes)
        {
            IMoveable moveable;
            foreach (char code in codes)
            {


                if (code == 'L')
                {

                    moveable = new MoveLeft();
                    Position = moveable.Move(this);
                }

                else if (code == 'R')
                {
                    moveable = new MoveRight();
                    Position = moveable.Move(this);
                }

                else if (code == 'M')
                {
                    moveable = new MoveOneStep();
                    Position = moveable.Move(this);
                }
            }

            return Position;

        }
    }
}
