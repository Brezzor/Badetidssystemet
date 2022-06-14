using System;
using System.Collections.Generic;
using System.Text;

namespace Badetidssystemet
{
    class Kreds
    {
        private int _antalDeltagere;

        public Kreds()
        {

        }

        public string ID { get; set; }

        public string Navn { get; set; }

        public string Adresse { get; set; }

        public int AntalDeltagere { 
            get { return _antalDeltagere; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"\nERROR! Antal deltagere skal være mere end 0");
                }
                else
                {
                    _antalDeltagere = value;
                }
            } 
        }

        public override string ToString()
        {
            return $"ID : {ID} | Navn: {Navn} | Adresse: {Adresse} | Deltagere: {AntalDeltagere}";
        }
    }
}
