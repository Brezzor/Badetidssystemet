using System;
using System.Collections.Generic;
using System.Text;

namespace Badetidssystemet
{
    class BadetidsPeriodeForLoopAndList : BadetidsPeriode
    {
        private List<Kreds> _kredseList;

        public BadetidsPeriodeForLoopAndList()
        {
            _kredseList = new List<Kreds>() 
            {
                new Kreds() { ID = "1", Navn = "OP10.0", Adresse = "Der", AntalDeltagere = 5 },
                new Kreds() { ID = "2", Navn = "OP10.1", Adresse = "Der", AntalDeltagere = 3 },
                new Kreds() { ID = "3", Navn = "OP10.2", Adresse = "Der", AntalDeltagere = 1 }
            };
        }

        public override void AdderKreds(Kreds kreds)
        {
            if (!_kredseList.Contains(kreds))
            {
                _kredseList.Add(kreds);
            }
        }

        public override void SletKreds(string id)
        {
            _kredseList.Remove(_kredseList.Find(k => k.ID == id));
        }

        public override string ToString()
        {
            string start = $"\nBadetidsPeriodeForLoopAndList" +
                           $"\n{Type} | {UgeDag} |" +
                           $"\n{StartTidspunkt} | {SlutTidspunkt}";

            string mid = "";

            foreach (Kreds k in _kredseList)
            {
                mid = $"{mid}\n{k}";
            }

            string end = $"{start}" +
                         $"{mid}";

            return end;
        }
    }
}
