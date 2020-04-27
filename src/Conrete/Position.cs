using TheMartian.Enums;

namespace TheMartian.Conrete
{
    public class Position
    {
         public Position(int startXPoint,int startYPoint,CardinalPoint startCardinalPoint)
        {
            XPoint=startXPoint;
            YPoint=startYPoint;
            CardinalPoint=startCardinalPoint;
        }
        public int XPoint { get; set; }

        public int YPoint { get; set; }

        public CardinalPoint CardinalPoint { get; set; }
    }
}