using TheMartian.Enums;
using TheMartian.Interfaces;

namespace TheMartian.Conrete
{
    public class Curiosity : VoucherBase, IVoucher
    {
        public Curiosity(Position position) : base(position)
        {
        }
    }
}