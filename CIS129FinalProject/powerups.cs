

public class Powerups {
    string _name, _description;
    int _mp=0; int _hp=0;
    public Powerups(string name) {
        string _name = name;
        if (_name == "Health Potion") {
            _hp=10;
            _description = "restores 10 health.";
        }
        else if (_name == "Magicka Potion") {
            _mp=20;
            _description = "restores 20 magicka.";
        }
    }
    public void consumed() {
        _mp = _hp = 0;
        Console.WriteLine($"The {_name} potion has been consumed and depleted.");
    }
} 