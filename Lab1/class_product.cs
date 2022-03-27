using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleApp1
{
    class Produkt

    {
        private string nazwa;
        private float cena;
        private bool wKoszyku;

        Produkt(string a,float b, bool c)
        {
            this.nazwa = a;
            this.cena = b;
            this.wKoszyku = c;
        }
        public override string ToString()
        {
            return $"Nazwa: \n {nazwa}" +
                    $"Cena: \n {cena}";
        }

    }

}
