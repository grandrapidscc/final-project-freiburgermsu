using System.Linq;
using System;


public class Wizert {
    private int[] _position = new int[] {5,3};
    private int _mp = 200;
    private int _hp = 100;

    public void move(int directionNum) {
        if (directionNum < 1 || directionNum > 4) {
            Console.WriteLine($"The {directionNum} direction is not valid.");
        }
        switch (directionNum) {
            case 1:
                movement("North"); updateLocation(0,1);
            case 2:
                movement("South"); updateLocation(0,-1);
            case 3:
                movement("East"); updateLocation(1,1);
            case 4:
                movement("West"); updateLocation(1,-1);
        }
    }

    public void enemyEncounter(string enemyName) {
        // enemy moves
        Enemy enemy = new Enemy(enemyName);
        Console.WriteLine($"A(n) {enemyName} is encountered!");
        attacked(enemyName);
        
        // fight back
        Console.WriteLine(@"What attack do you choose?
        1: Fireball: The Wizert casts a fireball that burns the enemy (Damage: 3 | MP: -3)
        2: Heal: The Wizert casts a spell to heal his wounds (Heal: 3 | MP: -5)
        3: Flee: The Wizert attempts to flee from battle");
        attack(Convert.ToInt32(Console.ReadLine()), enemy);

    }

    private void movement(string direction) {Console.WriteLine($"Wizert moved {direction}");}
    private void attack(int attack, Enemy enemy) {
        switch (attack) {
            case 1:
                _mp -= 3;
                Console.WriteLine($@"The Wizert is conjuring a fireball. The {enemy._name} is blasted with
                a fireball. The Wizert now has {_mp} MP and {_hp} HP.");
                enemy.attacked(5);
            case 2:
                Console.WriteLine($@"The Wizert is surrounded in a vail of water. He has healed 3 HP and now
                has {_mp} MP and {_hp} HP.");
                _mp-=5; _hp+=3;
            case 3:
                Console.WriteLine($"The Wizert scrambles to evade the {enemy._name}. He succeeds.");
                _position[1]++;
        }
    }
    private void updateLocation(int positionIndex, int change) {
        if (_position[positionIndex] == 5 || _position[positionIndex] == 0) {
            Console.WriteLine($"The Wizert hit a dungeon wall.");
        }
        else {
            _position[positionIndex] += change;
        }
        DungeonCell cell = Dungeon(_position);
        if (cell._enemy) enemyEncounter(cell._enemy._name);
        else if (cell._powerup) {
            Powerups pwup = cell._powerup;
            consume(pwup._mp, pwup._hp);
            Console.WriteLine($@"The Wizert encountered an {pwup._name} powerup,
            which {pwup._description}. The Wizert now has {_mp} MP and {_hp} HP.");
        }
        // foreach (var obj in objects) {
        //     if (_position.OrderBy(a => a).SequenceEqual(obj._position.OrderBy(async => a))) {
        //         if (obj._enemy) enemyEncounter(obj._name);
        //         else {
        //             consume(obj._mp, obj._hp);
        //             Console.WriteLine($@"The Wizert encountered an {obj._name} powerup,
        //             which {obj._description}. The Wizert now has {_mp} MP and {_hp} HP.");
        //         }
        //     }
        // }
        // encounter should be called when The Wizert's location is coincident with another object.
        //   This may be necessary to track in the outer object of the Play class.
    }

    private void attacked(int damage) {
        hp -= damage;
        if (hp <= 0) {
            Console.WriteLine(@"The Wizert has perished. The game is over. 
            Do you want to play another game?
            1: Yes
            2: No");
            int response = Convert.ToInt32(Console.ReadLine());
            if (response==1) Play();
            Console.WriteLine("Thank you for playing the Wizert :)");
        }
    }
    private void consume(int dMP, int dHP) {
        _mp += dMP; _hp += dHP;
    }
}