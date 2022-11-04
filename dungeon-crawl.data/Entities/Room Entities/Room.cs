
public class Room
{
    public int ID { get; set; }
    public Room NextRoom { get; set; }
    public Room PrevRoom {get; set;}
    public string Description { get; set; }
    public Encounter Encounter { get; set; }

    public Room(string description, Encounter encounter)
    {
        Description=description;
        Encounter = encounter;
    }
}
