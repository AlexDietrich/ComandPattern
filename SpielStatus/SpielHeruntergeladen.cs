using System;

namespace ComandPattern.SpielStatus
{
    internal class SpielHeruntergeladen : State
    {
        public override State SpielStarten(string spiel)
        {
            Console.WriteLine(spiel + " ist nicht installiert. Kann nicht gestartet werden!");
            return new SpielHeruntergeladen();
        }

        public override State SpielKaufen(string spiel)
        {
            Console.WriteLine(spiel + " befindet sich bereits in deinem Besitz.");
            return new SpielHeruntergeladen();
        }

        public override State SpielVerleihen(string user, string spiel)
        {
            Console.WriteLine(spiel + " wird an " + user + " verliehen");
            return new SpielVerliehen();
        }

        public override State SpielAktualisieren(string spiel)
        {
            Console.WriteLine(spiel + " wird aktualisiert ...");
            return new SpielAktualisiert();
        }

        public override State SpielDeinstallieren(string spiel)
        {
            Console.WriteLine(spiel + " ist nicht installiert. Kann nicht deinstalliert werden!");
            return new SpielHeruntergeladen();
        }

        public override State SpielHerunterladen(string spiel)
        {
            Console.WriteLine(spiel + " kann nicht erneut heruntergeladen werden. Ist bereits heruntergeladen");
            return new SpielHeruntergeladen();
        }

        public override State SpielInstallieren(string spiel)
        {
            Console.WriteLine(spiel + " wird installiert ...");
            return new SpielInstalliert();
        }
    }
}
