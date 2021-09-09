using DesignPatterns.Interfaces;

namespace DesignPatterns.Classes
{
    public class OldFashionedPrinter : IMachine
    {
        public void Print(Document d)
        {
            throw new System.NotImplementedException();
        }

        public void Scan(Document d)
        {
            throw new System.NotImplementedException();
        }

        public void Fax(Document d)
        {
            throw new System.NotImplementedException();
        }
    }
}