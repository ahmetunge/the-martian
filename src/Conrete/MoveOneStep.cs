using System;
using TheMartian.Enums;
using TheMartian.Interfaces;

namespace TheMartian.Conrete
{
    public class MoveOneStep : IMoveable
    {
        public Position Move(IVoucher voucher)
        {
             Position position = voucher.Position;
            switch (voucher.Position.CardinalPoint)
            {
                case CardinalPoint.North:
                    position.YPoint=position.YPoint+1;
                    break;
                case CardinalPoint.West:
                    position.XPoint=position.XPoint-1;
                    break;
                case CardinalPoint.South:
                  position.YPoint=position.YPoint-1;
                    break;
                case CardinalPoint.East:
                  position.XPoint=position.XPoint+1;
                    break;
            }

            return position;
        }
    }
}