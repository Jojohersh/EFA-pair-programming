Human human = new Human();
Goblin goblin = new Goblin();
CombatEncounter combat1 = new CombatEncounter(human, goblin);
Room room1 =new Room("This is a room", combat1);
room1.Encounter.StartEncounter();