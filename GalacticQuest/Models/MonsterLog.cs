using GalacticQuest.Monsters;

namespace GalacticQuest.Models;

internal class MonsterLog<T> where T : Monster
{
    private List<T> _history = new List<T>();

    public void AddEntry(T monster)
    {
        _history.Add(monster);
        Console.WriteLine($"{monster.GetType().ToString()}");
    }

    public void ShowAll()
    {
        Console.WriteLine("Monster Log History:");
        foreach (var monster in _history)
        {
            Console.WriteLine($"{monster.GetType().Name}");
        }
    }
}