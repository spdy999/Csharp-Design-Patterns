using DesignPatterns.Classes;

namespace DesignPatterns.Interfaces
{
    public interface IMachine : IMultiFunctionDevice
    {
        void Fax(Document d);
    }
}