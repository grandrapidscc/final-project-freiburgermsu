int[] _position = General.position();

// populate the Dungeon grid
DungeonCell[,] Dungeon = new DungeonCell[5,5];
Dungeon[0,0] = DungeonCell(enemyName="Banshee", position=new int[] {0,0});
Dungeon[0,1] = DungeonCell(exit=true, position=new int[] {0,1});
Dungeon[0,2] = DungeonCell(enemyName="Banshee", position=new int[] {0,2});
Dungeon[0,3] = DungeonCell(enemyName="Banshee", position=new int[] {0,3});
Dungeon[0,4] = DungeonCell(powerupName="Magicka Potion", position=new int[] {0,4});
Dungeon[1,0] = DungeonCell(enemyName="Orc", position=new int[] {1,0});
Dungeon[1,1] = DungeonCell(enemyName="Goblin", position=new int[] {1,1});
Dungeon[1,2] = DungeonCell(powerupName="Health Potion", position=new int[] {1,2});
Dungeon[1,3] = DungeonCell(enemyName="Goblin", position=new int[] {1,3});
Dungeon[1,4] = DungeonCell(enemyName="Goblin", position=new int[] {1,4});
Dungeon[2,0] = DungeonCell(enemyName="Orc", position=new int[] {2,0});
Dungeon[2,1] = DungeonCell(position=new int[] {2,1});
Dungeon[2,2] = DungeonCell(powerupName="Magicka Potion", position=new int[] {2,2});
Dungeon[2,3] = DungeonCell(position=new int[] {2,3});
Dungeon[2,4] = DungeonCell(powerupName="Health Potion", position=new int[] {2,4});
Dungeon[3,0] = DungeonCell(powerupName="Magicka Potion", position=new int[] {3,0});
Dungeon[3,1] = DungeonCell(enemyName="Goblin", position=new int[] {3,1});
Dungeon[3,2] = DungeonCell(enemyName="Orc", position=new int[] {3,2});
Dungeon[3,3] = DungeonCell(enemyName="Orc", position=new int[] {3,3});
Dungeon[3,4] = DungeonCell(powerupName="Health Potion", position=new int[] {3,4});
Dungeon[4,0] = DungeonCell(powerupName="Magicka Potion", position=new int[] {4,0});
Dungeon[4,1] = DungeonCell(enemyName="Orc", position=new int[] {4,1});
Dungeon[4,2] = DungeonCell(powerupName="Health Potion", position=new int[] {4,2});
Dungeon[4,3] = DungeonCell(powerupName="Magicka Potion", position=new int[] {4,3});
Dungeon[4,4] = DungeonCell(enemyName="Goblin", position=new int[] {4,4});
Dungeon[5,0] = DungeonCell(position=new int[] {5,0});
Dungeon[5,1] = DungeonCell(position=new int[] {5,1});
Dungeon[5,2] = DungeonCell(position=new int[] {5,2});
Dungeon[5,3] = DungeonCell(Wizert=true, position=new int[] {5,3});
Dungeon[5,4] = DungeonCell(position=new int[] {5,4});

public class DungeonCell {
    public DungeonCell(string? enemyName, string? powerupName, bool wizert, bool exit, int[] position) {
        const Enemy? _enemy = new Enemy(enemyName);
        const Powerups? _powerup = new Powerups(powerupName);
        const bool _wizert = wizert;
        const bool _exit = exit;
    }
    public void clear() {_enemy=null; _powerup=null;}
}