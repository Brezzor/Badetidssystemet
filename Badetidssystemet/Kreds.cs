using System;
using System.Collections.Generic;
using System.Text;

namespace Badetidssystemet
{
    class Kreds
    {
        private int _antalDeltagere;
        private int _minAlder;
        private int _maxAlder;

        public Kreds()
        {

        }

        public string ID { get; set; }

        public string Navn { get; set; }

        public string Adresse { get; set; }

        public int MinAlder {
            get { return _minAlder; }
            set
            {
                if (value > _maxAlder)
                {
                    throw new ArgumentException($"\nERROR! {value} skal være mindre {_maxAlder}");
                }
                else
                {
                    _minAlder = value;
                }
            } 
        }

        public int MaxAlder
        {
            get { return _maxAlder; }
            set
            {
                if (value < _minAlder)
                {
                    throw new ArgumentException($"\nERROR! {value} skal være større {_minAlder}");
                }
                else
                {
                    _maxAlder = value;
                }
            }
        }

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
            return $"ID : {ID} | Navn: {Navn} | Adresse: {Adresse} | Deltagere: {AntalDeltagere} | Aldersgrænse: {MinAlder}-{MaxAlder}";
        }
    }
}
