using System;
using System.Collections.Generic;
using System.Text;

namespace Badetidssystemet
{
    class Kreds
    {
        public Kreds()
        {

        }

        public string ID { get; set; }

        public string Navn { get; set; }

        public string Adresse { get; set; }

        public int AntalDeltagere { get; set; }

        public override string ToString()
        {
            return $"ID : {ID} | Navn: {Navn} | Adresse: {Adresse} | Deltagere: {AntalDeltagere}";
        }
    }
}
