// Интерфейс фильтра
public interface IFilter
{
    string Execute(string textLine);
}

// Реализация фильтра цифр
public class DigitFilter : IFilter
{
    public string Execute(string textLine)
    {
        // Удаляем все цифры из строки
        string result = new string(textLine.Where(c => !char.IsDigit(c)).ToArray());

        return result;
    }
}

// Реализация фильтра букв
public class LetterFilter : IFilter
{
    public string Execute(string textLine)
    {
        // Удаляем все буквы из строки
        string result = new string(textLine.Where(c => !char.IsLetter(c)).ToArray());

        return result;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Создаем список фильтров
        List<IFilter> filters = new List<IFilter>
        {
            new DigitFilter(),
            new LetterFilter()
        };

        // Текстовая строка, которую будем фильтровать
        string text = "12ABc34d56EF";

        // Проходим по списку фильтров и выводим результат выполнения каждого фильтра
        foreach (IFilter filter in filters)
        {
            string filteredText = filter.Execute(text);
            Console.WriteLine(filteredText);
        }

        Console.ReadKey();
    }
}