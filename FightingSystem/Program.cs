
namespace FightingSystem
{
     internal class Program
     {
          static void Main(string[] args)
          {
               
          }
     }

     class Fighter
     {
          private string _name;
          private int _health;
          private int _damage;
          private int _armor;

          public Fighter(string name, int health, int damage, int armor)
          {
               _name = name;
               _health = health; 
               _damage = damage;
               _armor = armor;
          }

          public void ShowStats()
          {
               Console.WriteLine($"Боец - {_name}, здоровье: {_health}, броня: {_armor}, наносимый урон:{_damage}");
          }

          public void ShowCurrentHealth()
          {
               Console.WriteLine($"{_name} здоровье: {_health}");
          }

          public void TakeDamage(int damage)
          {
               _health -= damage - _armor;
          }
     }
}

