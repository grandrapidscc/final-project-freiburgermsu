


public class Enemy {
    
    readonly bool enemy = true;
    public Enemy(string name, int[] position) {
        const string _name = name;
        const string _attackName = "Body Slam";
        const int _hp = 3; const int _HPdamage = 2;
        const int[] _position = position;
        
        if (_name == "Orc") {
            _attackName = "Cleave";
            _hp = 5; _HPdamage = 3;
        }
        else if (_name == "Banshee") {
            _attackName = "Screech";
            _hp = 8; _HPdamage = 5;
        }
        else if (_name == "Goblin") _position = position;
        else Console.WriteLine($"The enemy name {name} is not defiend by the game.");
    }

    public void attacked(int damage) {
        hp -= damage;
        if (hp <= 0) {
            Console.WriteLine("The enemy has perished.");
            // clear the respective Dungeon position. This may require that a Dungeon class is constructed 
            // and each entity is linked within a DungeonCell object which permits its use of the clear function
        }
    }

    public void attack() {
        Console.WriteLine($"The {_name} used {_attackName} and caused {_HPdamage} damage.");
    }
    
}