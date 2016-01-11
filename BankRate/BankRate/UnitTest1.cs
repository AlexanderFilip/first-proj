﻿//  Vrei să iei un credit de 40k euro de la bancă, iar dobânda anuală cerută de bancă e de 7.57%.
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
      /*  public float rataCeruta;
        public double suma ;
        public double dobanda ;
        public double period ;
        public double monthRate ;

        public double suma1 = 40.000;
        public double dobanda1 = 7.57;
        public double period1 = 48; //pt ani, 240 pt 20 de ani
        public double monthRate1 = 39;*/

        [TestMethod]
        public void firstMonthRate()
        {
            decimal rate = rateCalculus(200, 2, 12, 1);
            Assert.AreEqual(102, rate); //100 + 2 Eur
        }
       
        //  public void rateCalculus(decicmal suma2, int perioadaAnuala, decimal dobandaAnuala, int lunaCurenta)    {   } [1st atempt to write the function, then watched the video]
        decimal rateCalculus( decimal suma2, int perioadaAnuala, decimal dobandaLunara, int lunaCurenta) //perioadaAnuala == perioada per Months
        {                                                                                                   //dobandaLunara == dobanda per Month
            decimal principal = suma2 / perioadaAnuala;
            decimal dobandaAnualaExacta =dobandaLunara / 12 / 100; // calcul fix al dobanzii pe luna 
            return principal + suma2 * dobandaAnualaExacta;
        }
    }
}
