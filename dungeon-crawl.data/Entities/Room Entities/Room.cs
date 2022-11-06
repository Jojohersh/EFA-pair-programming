
public class Room
{
    public int ID { get; set; }
    //integer IDs to retrieve the appropriate rooms from the DB
    public int NextRoomID { get; set; }
    public int PrevRoomID {get; set;}
    public string Description { get; set; }
    public Encounter Encounter { get; set; }
    // a boolean to determine if this room has been completed or not
    public bool Completed {get; set;} = false;

    public Room(string description, Encounter encounter)
    {
        Description=description;
        Encounter = encounter;
    }

    public void ReadDescription() {
        System.Console.WriteLine("Entering the room, you see " + Description);
    }
}
