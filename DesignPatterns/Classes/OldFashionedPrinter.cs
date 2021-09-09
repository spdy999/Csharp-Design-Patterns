using DesignPatterns.Interfaces;

namespace DesignPatterns.Classes
{
    // can only print
    public class OldFashionedPrinter : IMachine
    {
        public void Print(Document d)
        {
            //
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