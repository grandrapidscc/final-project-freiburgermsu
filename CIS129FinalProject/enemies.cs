


public class Enemy {
    string _name, _attack;
    int _hp, _damage;
    public Enemy(string name, int hp, string attack, int damage) {
        _name = name; _attack = attack;
        _hp = hp; _damage = damage;
    }

    public void attack() {
        Console.WriteLine($"The {_name} used {_attack} and caused {_damage} damage.")
    }
    
}