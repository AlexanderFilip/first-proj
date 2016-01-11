//  Vrei să iei un credit de 40k euro de la bancă, iar dobânda anuală cerută de bancă e de 7.57%.
//  Creditul e pentru o perioadă de 20 ani iar contractul prevede restituirea în rate descrescătoare.
//Calculează ce rată trebuie plătită în luna martie al celui de al 4-lea an?
//Generalizează pentru orice sumă, perioadă și dobândă.

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankRate
{
    [TestClass]
    public class UnitTest1
    {
        public float rataCeruta;
        public double suma ;
        public double dobanda ;
        public double period ;
        public double monthRate ;

        public double suma1 = 40.000;
        public double dobanda1 = 7.57;
        public double period1 = 48;
        public double monthRate1 = 39;

        [TestMethod]
        public void TestMethod1()
        {
        }

        public void rateCalculus(decicmal suma2, int perioadaAnuala, decimal dobandaAnuala, int lunaCurenta)
        {
        }
    }
}
