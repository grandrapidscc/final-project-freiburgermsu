using System.Linq;
using System;


public class Wizert {
    private int[] _position = new int[2];
    private int _mp = 200;
    private int _hp = 100;

    public void move(int directionNum) {
        if (directionNum < 1 || directionNum > 4)) {
            Console.WriteLine($"The {directionNum} direction is not valid.");
        }
        switch (directionNum) {
            case 1:
                movement("North");
                _position[0]++;
            case 2:
                movement("South");
                _position[0]--;
            case 3:
                movement("East");
                _position[1]++;
            case 4:
                movement("West");
                _position[1]--;
        }
    }

    public void encounter(int attack) {
        if (directionNum < 1 || directionNum > 4)) {
            Console.WriteLine($"The {directionNum} direction is not valid.");
        }
        switch (attack) {
            case 1:
                movement("Fireball: The Wizert casts a fireball that burns the enemy.");
                _mp-=3;
            case 2:
                movement("Heal: The Wizert casts a spell to heal his wounds.");
                _mp-=5;
                _hp+=3;
            case 3:
                movement("Flee: The Wizert attempts to flee from battle.");
                _position[1]++;
        }
    }

    private void movement(string direction) {Console.WriteLine($"Wizert moved {direction}");}
    private void attack(string attack) {Console.WriteLine($"Wizert moved {direction}");}

    private void attacked() {
        
        Console.WriteLine($"Wizert has {_hp} remaining.");
        }
}