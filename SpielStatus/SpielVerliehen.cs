using System;

namespace ComandPattern.SpielStatus
{
    internal class SpielVerliehen : State
    {
        public override State SpielStarten(string spiel)
        {
            Console.WriteLine(spiel + " kann nicht gestartet werden. Es wurde verliehen!");
            return new SpielVerliehen();
        }

        public override State SpielKaufen(string spiel)
        {
            Console.WriteLine(spiel + " kann nicht erneut gekauft werden. Spiel wurde verliehen!");
            return new SpielVerliehen();
        }

        public override State SpielVerleihen(string user, string spiel)
        {
            Console.WriteLine(spiel + " kann nicht ein zweites mal verliehen werden!");
            return new SpielVerliehen();
        }

        public override State SpielAktualisieren(string spiel)
        {
            Console.WriteLine(spiel + " kann nicht aktualisiert werden. Spiel befindet sich momentan nicht in deinem Besitz!");
            return new SpielVerliehen();
        }

        public override State SpielDeinstallieren(string spiel)
        {
            Console.WriteLine(spiel + " kann nicht deinstalliert werden. Spiel befindet sich momentan nicht in deinem Besitz!");
            return new SpielVerliehen();
        }

        public override State SpielHerunterladen(string spiel)
        {
            Console.WriteLine(spiel + " wird heruntergeladen... Spiel wechselt den Besitz zu dir. Es kann von anderen Personen nicht mehr gestartet werden.");
            return new SpielHeruntergeladen();
        }

        public override State SpielInstallieren(string spiel)
        {
            Console.WriteLine(spiel + " kann nicht installiert werden. Spiel befindet sich momentan nicht in deinem Besitz!");
            return new SpielVerliehen();
        }
    }
}
