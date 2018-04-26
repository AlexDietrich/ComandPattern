using System;

namespace ComandPattern.SpielStatus
{
    internal class SpielAktualisiert : State
    {
        public override State SpielStarten(string spiel)
        {
            Console.WriteLine(spiel + " wird gestartet...");
            return new SpielGestartet();
        }

        public override State SpielKaufen(string spiel)
        {
            Console.WriteLine(spiel + " wurde bereits gekauft! Es ist installiert und aktualisiert!");
            return new SpielAktualisiert();
        }

        public override State SpielVerleihen(string user, string spiel)
        {
            Console.WriteLine(spiel + " wird an " + user + " verliehen!");
            return new SpielVerliehen();
        }

        public override State SpielAktualisieren(string spiel)
        {
            Console.WriteLine(spiel + " ist bereits aktualisiert!");
            return new SpielAktualisiert();
        }

        public override State SpielDeinstallieren(string spiel)
        {
            Console.WriteLine(spiel + " wird deinstalliert!");
            return new SpielDeinstalliert();
        }

        public override State SpielHerunterladen(string spiel)
        {
            Console.WriteLine(spiel + " kann nicht erneut heruntergeladen werden!");
            return new SpielAktualisiert();
        }

        public override State SpielInstallieren(string spiel)
        {
            Console.WriteLine(spiel + " kann nicht erneut installiert werden!");
            return new SpielAktualisiert();
        }
    }
}
