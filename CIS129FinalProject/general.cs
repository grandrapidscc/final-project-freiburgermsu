

public class Death : Exception
{
    public WizertDeath(string message) : base(message) { }
    public EnemyDeath(string message) : base(message) { }
}

public static class General {
    public static int[] position() {
        int[] position = new int[2];   // up/down & left/right
        Random randNum = new Random();
        for (int i = 0; i < 2; i++) position[i] = randNum.Next(0, 5);
    }
    public static void sustainDamage(var obj, int damage, bool wizert=false) {
        hp -= damage;
        if (hp <= 0) {
            if (wizert) {
                Console.WriteLine(@"The Wizert has perished. The game is over. 
                Do you want to play another game?
                1: Yes
                2: No");
                int response = Convert.ToInt32(Console.ReadLine());
                if (response==1) Play();
                Console.WriteLine("Thank you for playing the Wizert :)");
            }
            Console.WriteLine("The enemy has perished.");

        }
        string entity = "enemy";
        if (wizert) entity="Wizert";
        Console.WriteLine($"The {entity} sustained {damage} damage and has {hp} remaining.");
    }
}