namespace ComandPattern
{
    internal abstract class State
    {
        public abstract State SpielStarten(string spiel);
        public abstract State SpielKaufen(string spiel);
        public abstract State SpielVerleihen(string user, string spiel);
        public abstract State SpielAktualisieren(string spiel);
        public abstract State SpielDeinstallieren(string spiel);
        public abstract State SpielHerunterladen(string spiel);
        public abstract State SpielInstallieren(string spiel);
    }
}