internal class Program
{
    private static void Main(string[] args)
    {
        Animal animal = new Animal { type = "Собака", name = "Вольт", age = 4 };
    }
}

struct Animal
{
    // Поля структуры
    public string type;
    public string name;
    public int age;

    // Метод структуры
    public void Info()
    {
        Console.WriteLine("Это {0} по кличке {1}, ему {2}", type, name, age);
    }
}
