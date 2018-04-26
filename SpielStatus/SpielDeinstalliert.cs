using System;

namespace ComandPattern.SpielStatus
{
    internal class SpielDeinstalliert : State
    {
        public override State SpielStarten(string spiel)
        {
            Console.WriteLine(spiel + " ist nicht installiert!");
            return new SpielDeinstalliert();
        }

        public override State SpielKaufen(string spiel)
        {
            Console.WriteLine(spiel + " ist bereits gekauft aber nicht installiert!");
            return new SpielDeinstalliert();
        }

        public override State SpielVerleihen(string user, string spiel)
        {
            Console.WriteLine(spiel + " wurde an " + user + " verliehen!");
            return new SpielVerliehen();
        }

        public override State SpielAktualisieren(string spiel)
        {
            Console.WriteLine(spiel + " kann nicht aktualisert werden. Ist auf dem Gerät nicht installiert!");
            return new SpielDeinstalliert();
        }

        public override State SpielDeinstallieren(string spiel)
        {
            Console.WriteLine(spiel + " ist bereits deinstalliert!");
            return new SpielDeinstalliert();
        }

        public override State SpielHerunterladen(string spiel)
        {
            Console.WriteLine(spiel + " wird heruntergeladen ...");
            return new SpielHeruntergeladen();
        }

        public override State SpielInstallieren(string spiel)
        {
            Console.WriteLine(spiel + " muss erst heruntergeladen werden bevor es installiert werden kann");
            return new SpielDeinstalliert();
        }
    }
}
