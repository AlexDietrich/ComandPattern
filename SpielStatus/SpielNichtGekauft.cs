using System;

namespace ComandPattern.SpielStatus
{
    internal class SpielNichtGekauft : State
    {
        public override State SpielStarten(string spiel)
        {
            Console.WriteLine(spiel + " kann nicht gestartet werden. Es befindet sich nicht in deinem Besitz!");
            return new SpielNichtGekauft();
        }

        public override State SpielKaufen(string spiel)
        {
            Console.WriteLine(spiel + " erfolgreicht gekauft!");
            return new SpielGekauft();
        }

        public override State SpielVerleihen(string user, string spiel)
        {
            Console.WriteLine(spiel + " kann nicht verliehen werden. Es befindet sich nicht in deinem Besitz!");
            return new SpielNichtGekauft();
        }

        public override State SpielAktualisieren(string spiel)
        {
            Console.WriteLine(spiel + " kann nicht aktualisiert werden. Es befindet sich nicht in deinem Besitz!");
            return new SpielNichtGekauft();
        }

        public override State SpielDeinstallieren(string spiel)
        {
            Console.WriteLine(spiel + " kann nicht deinstalliert werden. Es befindet sich nicht in deinem Besitz!");
            return new SpielNichtGekauft();
        }

        public override State SpielHerunterladen(string spiel)
        {
            Console.WriteLine(spiel + " kann nicht heruntergeladen werden. Es befindet sich nicht in deinem Besitz!");
            return new SpielNichtGekauft();
        }

        public override State SpielInstallieren(string spiel)
        {
            Console.WriteLine(spiel + " kann nicht installiert werden. Es befindet sich nicht in deinem Besitz!");
            return new SpielNichtGekauft();
        }
    }
}
