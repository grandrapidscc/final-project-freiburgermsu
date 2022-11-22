readonly int[] _position = General.position();

DungeonCell[] Dungeon = new DungeonCell[] {

}
public class DungeonCell {
    public DungeonCell(string? enemyName, string? powerupName, bool wizert, bool exit) {
        const Enemy? _enemy = new Enemy(enemyName);
        const Powerups? _powerup = new Powerups(powerupName);
        const bool _wizert = wizert;
        const bool _exit = exit;
    }
}