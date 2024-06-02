
namespace FightingSystem
{
     internal class Program
     {
          static void Main(string[] args)
          {
               // Создаю массив бойцов
               Fighter[] fighters =
               {
                    new Fighter("John", 300, 20, 0),
                    new Fighter("Ryu", 150, 40, 10),
                    new Fighter("Sean", 200, 20, 20),
                    new Fighter("Ann", 100, 50, 15)
               };
               // Переменная для хранения значения выбранного бойца
               int fighterNumber;

               // Вывод бойцов на экран выбора персонажа
               for (int i = 0; i < fighters.Length; i++)
               {
                    Console.Write((i + 1) + " ");
                    fighters[i].ShowStats();
                    
               }
               
               // Выбор бойцов
               Console.Write("\nВыберете номер первого бойца: ");
               fighterNumber = Convert.ToInt32(Console.ReadLine()) - 1;
               Fighter firstFighter = fighters[fighterNumber];

               Console.Write("\nВыберете номер второго бойца: ");
               fighterNumber = Convert.ToInt32(Console.ReadLine()) - 1;
               Fighter secondFighter = fighters[fighterNumber];

               // Бой между бойцами
               while (firstFighter.Health > 0 && secondFighter.Health > 0)
               {
                    firstFighter.TakeDamage(secondFighter.Damage);
                    secondFighter.TakeDamage(firstFighter.Damage);
                    firstFighter.ShowCurrentHealth();
                    secondFighter.ShowCurrentHealth();
               }
               
               // Определение победителя
               if (firstFighter.Health <= 0)
               {
                    Console.WriteLine($"Победа {secondFighter.Name}");
               }
               else if (secondFighter.Health <= 0)
               {
                    Console.WriteLine($"Победа {firstFighter.Name}");
               }
          }
     }
     // Создание класса боец
     class Fighter
     {
          // Приватных переменных
          private string _name;
          private int _health;
          private int _damage;
          private int _armor;
          
          // Вычисляемый свойства для получения приватных значений вне класса
          public int Health
          {
               get => _health;
          }

          public int Damage
          {
               get => _damage;
          }
          
          public string Name
          {
               get => _name;
          }
          
          // Конструктор класса
          public Fighter(string name, int health, int damage, int armor)
          {
               _name = name;
               _health = health; 
               _damage = damage;
               _armor = armor;
          }

          // Метод для получения статистики бойцов
          public void ShowStats()
          {
               Console.WriteLine($"Боец - {_name}, здоровье: {_health}, броня: {_armor}, наносимый урон:{_damage}");
          }
          
          // Метод для получения текущего значения здоровья
          public void ShowCurrentHealth()
          {
               Console.WriteLine($"{_name} здоровье: {_health}");
          }
     
          // Метод для получения урона
          public void TakeDamage(int damage)
          {
               _health -= damage - _armor;
          }
     }
}

