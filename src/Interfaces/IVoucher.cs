using TheMartian.Conrete;

namespace TheMartian.Interfaces
{
    public interface IVoucher
    {
        Position Position { get; set; }

        Position Move(string code);
        
    }
}