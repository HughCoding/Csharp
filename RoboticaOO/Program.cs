class Program
{
    static void Main()
    {
        Cat cat = new Cat();
        cat.Eat();
        cat.Run("quintal");
        cat.Breath();

        RoboCat robo = new RoboCat();
        robo.Run("laboratório");
    }
}