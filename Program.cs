using System;
using TheMartian.Conrete;
using TheMartian.Enums;
using TheMartian.Interfaces;

namespace TheMartian
{
    class Program
    {
        static void Main(string[] args)
        {
            int startXPoint = 3;
            int startYPoint = 3;
            CardinalPoint startCaridnalPoint = CardinalPoint.East;

            string codes = "MMRMMRMRRM";

            Position startPosition = new Position(startXPoint, startYPoint, startCaridnalPoint);

            IVoucher curiosity = new Curiosity(startPosition);

            Position lastPosition = curiosity.Move(codes);

            Console.WriteLine(lastPosition.CardinalPoint);
            Console.WriteLine(lastPosition.XPoint);
            Console.WriteLine(lastPosition.YPoint);

            Console.ReadLine();
        }
    }
}
