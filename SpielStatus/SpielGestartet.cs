using System;

namespace ComandPattern.SpielStatus
{
    internal class SpielGestartet : State
    {
        public override State SpielStarten(string spiel)
        {
            Console.WriteLine(spiel + " kann nicht erneut gestartet werden! Ist bereits gestartet.");
            return new SpielGestartet();
        }

        public override State SpielKaufen(string spiel)
        {
            Console.WriteLine(spiel + " befindet sich bereits in deinem Besitz.");
            return new SpielGestartet();
        }

        public override State SpielVerleihen(string user, string spiel)
        {
            Console.WriteLine(spiel + " kann nicht verliehen werden während es gestartet ist");
            return new SpielGestartet();
        }

        public override State SpielAktualisieren(string spiel)
        {
            Console.WriteLine(spiel + " wird beendet und aktualisiert ...");
            return new SpielAktualisiert();
        }

        public override State SpielDeinstallieren(string spiel)
        {
            Console.WriteLine(spiel + " wird beendet und deinstalliert...");
            return new SpielDeinstalliert();
        }

        public override State SpielHerunterladen(string spiel)
        {
            Console.WriteLine(spiel + " kann nicht erneut heruntergeladen werden.");
            return new SpielGestartet();
        }

        public override State SpielInstallieren(string spiel)
        {
            Console.WriteLine(spiel + " kann nicht erneut installiert werden");
            return new SpielGestartet();
        }
    }
}
