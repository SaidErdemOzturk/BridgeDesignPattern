using System;

namespace BridgeCalisma
{
    class Program
    {
        static void Main(string[] args)
        {
            Report report = new SalesReport();
            report.raporCesidi = new Desktop();
            report.Display();
            
            
        }
    }
    interface IRaporCesidi
    {
        void Generate();
    }
    class Desktop : IRaporCesidi
    {
        public void Generate()
        {
            Console.WriteLine("desktop generate");
        }
    }
    class Web : IRaporCesidi
    {
        public void Generate()
        {
            Console.WriteLine("Web Generate");
        }
    }

    abstract class Report
    {
        protected IRaporCesidi _raporCesidi;
        public IRaporCesidi raporCesidi
        {
            set
            {
                _raporCesidi = value;
            }
        }
        public virtual void Display()
        {
            _raporCesidi.Generate();
        }
    }
    class SalesReport : Report
    {
        public override void Display()
        {
            Console.WriteLine("satış raporu :");
            _raporCesidi.Generate();
        }
    }
    class PerformansReport : Report
    {
        public override void Display()
        {
            Console.WriteLine("performans raporu");
            _raporCesidi.Generate();
        }
    }

}
