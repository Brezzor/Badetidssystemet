using System;
using System.Collections.Generic;
using System.Text;

namespace Badetidssystemet
{
    class BadetidsPeriode
    {
        private Dictionary<int, Kreds> _kreds;
        private string _type;
        private DayOfWeek _ugeDag = DayOfWeek.Sunday;
        private DateTime _startTidspunkt = new DateTime();
        private DateTime _slutTidspunkt = new DateTime();

        public BadetidsPeriode()
        {
            _kreds = new Dictionary<int, Kreds> {
                {1, new Kreds() { ID = "1", Navn = "OP2.0", Adresse = "Her", AntalDeltagere = 21 } },
                {2, new Kreds() { ID = "2", Navn = "OP2.1", Adresse = "Her", AntalDeltagere = 23 } },
                {3, new Kreds() { ID = "3", Navn = "OP2.2", Adresse = "Her", AntalDeltagere = 18 } }
            };
        }

        public string Type {
            get { return _type; }
            set { _type = value; } 
        }

        public DayOfWeek UgeDag {
            get { return _ugeDag; }
            set { _ugeDag = value; } 
        }

        public DateTime StartTidspunkt {
            get { return _startTidspunkt; }
            set { _startTidspunkt = value; } 
        }

        public DateTime SlutTidspunkt {
            get { return _slutTidspunkt; }
            set { _slutTidspunkt = value; } 
        }

        public void AdderKreds(Kreds kreds)
        {
            if (!_kreds.ContainsValue(kreds))
            {
                _kreds.Add(Convert.ToInt32(kreds.ID), kreds);
            }
        }

        public void SletKreds(string id)
        {
            if (_kreds.ContainsKey(Convert.ToInt32(id)))
            {
                _kreds.Remove(Convert.ToInt32(id));
            }
        }

        public override string ToString()
        {
            string start = $"\nBadetidsperiode" +
                           $"\n{Type} | {UgeDag} |" +
                           $"\n{StartTidspunkt} | {SlutTidspunkt}";
            
            string mid = "";

            foreach (var k in _kreds)
            {
                mid = $"{mid}\n{k}";
            }

            string end = $"{start}" +
                         $"{mid}";

            return end;
        }
    }
}
