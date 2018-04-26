using System;

namespace ComandPattern.SpielStatus
{
    internal class SpielInstalliert : State
    {
        public override State SpielStarten(string spiel)
        {
            Console.WriteLine(spiel + " wird gestartet...");
            return new SpielGestartet();
        }

        public override State SpielKaufen(string spiel)
        {
            Console.WriteLine(spiel + " wurde bereits gekauft. Kann nicht erneut gekauft werden.");
            return new SpielInstalliert();
        }

        public override State SpielVerleihen(string user, string spiel)
        {
            Console.WriteLine(spiel + " wurde an " + user + " verliehen!");
            return new SpielVerliehen();
        }

        public override State SpielAktualisieren(string spiel)
        {
            Console.WriteLine(spiel + " wird aktualisiert ...");
            return new SpielAktualisiert();
        }

        public override State SpielDeinstallieren(string spiel)
        {
            Console.WriteLine(spiel + " wird deinstalliert ...");
            return new SpielDeinstalliert();
        }

        public override State SpielHerunterladen(string spiel)
        {
            Console.WriteLine(spiel + " wurde bereits installiert. Kann nicht erneut heruntergeladen werden!");
            return new SpielInstalliert();
        }

        public override State SpielInstallieren(string spiel)
        {
            Console.WriteLine(spiel + " ist bereits installiert!");
            return new SpielInstalliert();
        }
    }
}
