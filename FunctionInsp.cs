using static System.Runtime.InteropServices.JavaScript.JSType;

namespace InspectorLib
{
    public class FunctionInsp
    {
        //Данные об Автоинспекции(название, гл.инспектор, ФИО сотрудников):
        public string NameInspector = "Автоинспекция г. Чита";
        public string NameInspectorBoss = "Васильев Василий Иванович";
        public List<string> FIO_workers = new List<string>
        {
            "Иванов И.И.",
            "Зиронов Т.А.",
            "Миронов А.В.",
            "Васильев В.И."
        };

        //Методы, возвращающие ФИО гл.инспектора и название автоинспекции
        public string GetInspector()
        {
            return NameInspectorBoss;
        }
        public string GetСarInspection()
        {
            return NameInspector;
        }

        //Метод, где ФИО гл.инспектора меняется только если оно есть в FIO_workers, если нет - сообщение об ошибке
        public void SetInspector(string fullname)
        {
            if (FIO_workers.Contains(fullname))
            {
                NameInspectorBoss = fullname;
            }
            else
            {
                throw new ArgumentException("Данный сотрудник отсутствует в списке!");
            }
        }

        //Метод, генерирующий госномер (я недопоняла задание, поэтому (Number – случайный номер) я получаю рандомно
        public string GenerateNumber(char symbol)
        {
            char UpperSymbol = char.ToUpper(symbol);
            Random random = new Random();
            int number = random.Next(100, 1000);
            int code = 75;
            return $"{UpperSymbol}{number}_{code}";
        }

        //Метод для получения списка сотрудников
        public List<string> GetWorker()
        {
            return FIO_workers;
        }

        //Добавление нового сотрудника в список сотрудников
        public void AddWorker(string FIO)
        {
            FIO_workers.Add(FIO);
        }
    }
}