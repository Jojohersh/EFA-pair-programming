
    public class Encounter
    {
        public bool Succeeded { get; set; }
        public virtual void StartEncounter() {
            System.Console.WriteLine("Generic Encounter");
        }
    }
