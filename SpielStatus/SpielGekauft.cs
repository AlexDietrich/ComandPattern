using System;

namespace ComandPattern.SpielStatus
{
    internal class SpielGekauft : State
    {
        public override State SpielStarten(string spiel)
        {
            Console.WriteLine(spiel + " muss heruntergeladen und installiert werden bevor es gestartet werden kann!");
            return new SpielGekauft();
        }

        public override State SpielKaufen(string spiel)
        {
            Console.WriteLine(spiel + " wurde bereits gekauft. Kann nicht erneut gekauft werden.");
            return new SpielGekauft();
        }

        public override State SpielVerleihen(string user, string spiel)
        {
            Console.WriteLine(spiel + " wurde an " + user + " verliehen!");
            return new SpielVerliehen();
        }

        public override State SpielAktualisieren(string spiel)
        {
            Console.WriteLine(spiel + " kann nicht aktualisert werden. Ist nicht installiert!");
            return new SpielGekauft();
        }

        public override State SpielDeinstallieren(string spiel)
        {
            Console.WriteLine(spiel + " kann nicht deinstalliert werden. Ist nicht installiert.");
            return new SpielInstalliert();
        }

        public override State SpielHerunterladen(string spiel)
        {
            Console.WriteLine(spiel + " wird heruntergeladen ...");
            return new SpielHeruntergeladen();
        }

        public override State SpielInstallieren(string spiel)
        {
            Console.WriteLine(spiel + " muss erst heruntergeladen werden bevor es installiert werden kann!");
            return new SpielGekauft();
        }
    }
}
