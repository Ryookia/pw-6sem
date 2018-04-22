namespace Durczak.AplikacjaWielowarstowa.Interfaces
{
    public interface IProducer
    {
        int Id { get; set; }
        string Name { get; set; }
        string CountryOrigin { get; set; }
    }
}