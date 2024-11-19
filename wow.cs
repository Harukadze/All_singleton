using System;

public class wow
{
    private static MySingleton _instance;
    private static readonly object _lock = new object();

    // Приватный конструктор, чтобы предотвратить создание экземпляров класса
    private wow() { }

    public static wow Instance
    {
        get
        {
            // Используем блокировку для потокобезопасности
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new wow();
                }
                return _instance;
            }
        }
    }

    public void SomeMethod()
    {
        Console.WriteLine("Это метод класса Singleton.");
    }
}
