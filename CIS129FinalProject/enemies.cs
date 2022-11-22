


public class Enemy {
    
    readonly bool enemy = true;
    public Enemy(string name, int hp, string attack, int damage) {
        const string _name = name; 
        const string _attack = attack;
        const int _hp = hp; const int _damage = damage;
    }

    public void attacked(int damage) {
        General.sustainDamage(_hp, damage);
    }

    public void attack() {
        Console.WriteLine($"The {_name} used {_attack} and caused {_damage} damage.")
    }
    
}