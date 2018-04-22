using Durczak.AplikacjaWielowarstowa.Core;

namespace Durczak.AplikacjaWielowarstowa.Interfaces
{
    public interface IProduct
    {
        int Id { get; set; }
        string Name { get; set; }
        Propulsion Propulsion { get; set; }
        Material Material { get; set; }
        int Velocity { get; set; }
        int ProducerId { get; set; }
    }
}