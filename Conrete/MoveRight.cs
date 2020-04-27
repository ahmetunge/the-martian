using System;
using TheMartian.Enums;
using TheMartian.Interfaces;

namespace TheMartian.Conrete
{
    public class MoveRight : IMoveable
    {
        public Position Move(IVoucher voucher)
        {
            Position position = voucher.Position;
            switch (voucher.Position.CardinalPoint)
            {
                case CardinalPoint.North:
                    position.CardinalPoint = CardinalPoint.East;
                    break;
                case CardinalPoint.East:
                    position.CardinalPoint = CardinalPoint.South;
                    break;
                case CardinalPoint.South:
                    position.CardinalPoint = CardinalPoint.West;
                    break;
                case CardinalPoint.West:
                    position.CardinalPoint = CardinalPoint.North;
                    break;
            }

            return position;
        }
    }
}