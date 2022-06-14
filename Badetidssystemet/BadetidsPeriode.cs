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
        private int _minAlder;
        private int _maxAlder;

        public BadetidsPeriode()
        {
            _kreds = new Dictionary<int, Kreds> {
                {1, new Kreds() { ID = "1", Navn = "OP2.0", Adresse = "Her", AntalDeltagere = 21, MaxAlder = 99, MinAlder = 18 } },
                {2, new Kreds() { ID = "2", Navn = "OP2.1", Adresse = "Her", AntalDeltagere = 23, MaxAlder = 99, MinAlder = 18 } },
                {3, new Kreds() { ID = "3", Navn = "OP2.2", Adresse = "Her", AntalDeltagere = 18, MaxAlder = 99, MinAlder = 18 } }
            };
        }

        public string Type {
            get { return _type; }
            set
            {
                if (value.Length <= 3)
                {
                    throw new ArgumentException($"\nERROR! Type længde: {value} skal være mindst 4 tegn");
                }
                else
                {
                    _type = value;
                }
            } 
        }

        public DayOfWeek UgeDag {
            get { return _ugeDag; }
            set { _ugeDag = value; } 
        }

        public DateTime StartTidspunkt {
            get { return _startTidspunkt; }
            set
            {
                if (value > _slutTidspunkt)
                {
                    throw new ArgumentException($"\nERROR! {value} skal være før {_slutTidspunkt}");
                }
                else
                {
                    _startTidspunkt = value;
                }
            } 
        }

        public DateTime SlutTidspunkt {
            get { return _slutTidspunkt; }
            set 
            {
                if (value < _startTidspunkt)
                {
                    throw new ArgumentException($"\nERROR! {value} skal være senere {_startTidspunkt}");
                }
                else
                {
                    _slutTidspunkt = value;
                }
                 
            } 
        }

        public int MinAlder
        {
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

        public virtual void AdderKreds(Kreds kreds)
        {
            if (!_kreds.ContainsValue(kreds) || kreds.MaxAlder <= _minAlder)
            {
                _kreds.Add(Convert.ToInt32(kreds.ID), kreds);
            }
        }

        public virtual void SletKreds(string id)
        {
            if (_kreds.ContainsKey(Convert.ToInt32(id)))
            {
                _kreds.Remove(Convert.ToInt32(id));
            }
        }

        public override string ToString()
        {
            string start = $"\nBadetidsperiode" +
                           $"\n{Type} | {UgeDag} | {MinAlder}-{MaxAlder}" +
                           $"\n{StartTidspunkt} | {SlutTidspunkt}";
            
            string mid = "";

            foreach (Kreds k in _kreds.Values)
            {
                mid = $"{mid}\n{k}";
            }

            string end = $"{start}" +
                         $"{mid}";

            return end;
        }
    }
}
