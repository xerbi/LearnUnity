using System.Drawing;
using System.Xml.Linq;

namespace LearnC_
{
    abstract class Entity
    {
        string name;
        int age;

        public string Name
        {
            get => name;
        }

        public int Age
        {
            get => age;
        }

        protected Entity(int _age, string _name)
        {
            name = _name;
            age = _age;
        }

        public abstract void Say();
    }

    class Enemy : Entity
    {
        int level_angry;

        public int Level_angry
        {
            get => level_angry;
        }

        public Enemy(int _level_angry, int _age, string _name) : base(_age, _name)
        {
            level_angry = _level_angry;
        }

        public override void Say()
        {
            Console.WriteLine("Ловите его!!!");
        }

        public void Show()
        {
            Console.WriteLine("HELLO WORLD");
        }
    }

    class Enimals : Entity
    {
        public Enimals(int _age, string _name) : base(_age, _name) { }
        public override void Say()
        {
            Console.WriteLine("МЯУ МЯУ");
        }
    }

    class Character : Entity
    {
        public Character(int _age, string _name) : base(_age, _name) { }
        public override void Say()
        {
            Console.WriteLine("Привет!");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Enemy enemy = new Enemy(10, 22, "Eudolf");
            Enimals enimals = new Enimals(3, "Salamon");
            Character character = new Character(16, "MyBut");

            Console.WriteLine($"Level angry: {enemy.Level_angry}");

            ShowSay(enemy);
            ShowSay(enimals);
            ShowSay(character);
        }

        static void ShowSay(Entity e)
        {
            e.Say();
            Console.WriteLine("Name is {0}", e.Name);
            Console.WriteLine($"Age is {e.Age}");
        }
    }
}     