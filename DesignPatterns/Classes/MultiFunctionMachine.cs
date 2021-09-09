using DesignPatterns.Interfaces;

namespace DesignPatterns.Classes
{
    public class MultiFunctionMachine : IMultiFunctionDevice
    {
        private readonly IPrinter _printer;
        private readonly IScanner _scanner;

        public MultiFunctionMachine(IPrinter printer, IScanner scanner)
        {
            _printer = printer;
            _scanner = scanner;
        }

        public void Print(Document d)
        {
            _printer.Print(d);
        }

        public void Scan(Document d)
        {
            _scanner.Scan(d);
        }
    }
}