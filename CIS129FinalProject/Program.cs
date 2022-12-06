

public class Play {
    public Play () {
        Console.WriteLine("Welcome to the Wizert game!");
        Wizert wiz = new Wizert();
        while (true) {
            Console.WriteLine(@"Where will the Wizert move?
            1: North
            2: South
            3: East
            4: West");
            wiz.move(Convert.ToInt32(Console.ReadLine()));
        }
    }
}