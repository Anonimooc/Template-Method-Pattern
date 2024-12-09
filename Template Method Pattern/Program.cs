using System;

// Абстрактный класс ReportGenerator
public abstract class ReportGenerator
{
    // Шаблонный метод, который генерирует отчет
    public void GenerateReport()
    {
        CollectData();  // Шаг 1: Сбор данных
        ProcessData();  // Шаг 2: Обработка данных
        FormatReport(); // Шаг 3: Форматирование отчета
        ExportReport(); // Шаг 4: Экспорт отчета
    }

    // Абстрактные методы, которые должны быть реализованы в конкретных классах
    protected abstract void CollectData(); // Сбор данных
    protected abstract void ProcessData(); // Обработка данных
    protected abstract void FormatReport(); // Форматирование отчета

    // Общий метод для экспорта отчета (можно реализовать в абстрактном классе)
    protected virtual void ExportReport()
    {
        Console.WriteLine("Отчет экспортирован в файл.");
    }
}

// Конкретный класс для отчета по студентам
public class StudentReportGenerator : ReportGenerator
{
    // Сбор данных о студентах
    protected override void CollectData()
    {
        Console.WriteLine("Собраны данные о студентах...");
    }

    // Обработка данных о студентах
    protected override void ProcessData()
    {
        Console.WriteLine("Данные о студентах обработаны...");
    }

    // Форматирование отчета по студентам
    protected override void FormatReport()
    {
        Console.WriteLine("Отчет о студентах отформатирован.");
    }
}

// Конкретный класс для отчета по курсам
public class CourseReportGenerator : ReportGenerator
{
    // Сбор данных о курсах
    protected override void CollectData()
    {
        Console.WriteLine("Собраны данные о курсах...");
    }

    // Обработка данных о курсах
    protected override void ProcessData()
    {
        Console.WriteLine("Данные о курсах обработаны...");
    }

    // Форматирование отчета по курсам
    protected override void FormatReport()
    {
        Console.WriteLine("Отчет о курсах отформатирован.");
    }
}

// Программа для демонстрации работы системы отчетности
class Program
{
    static void Main()
    {
        // Создаем генератор отчетов для студентов
        ReportGenerator studentReportGenerator = new StudentReportGenerator();
        Console.WriteLine("Генерация отчета по студентам:");
        studentReportGenerator.GenerateReport();
        Console.WriteLine(); // Разделитель

        // Создаем генератор отчетов для курсов
        ReportGenerator courseReportGenerator = new CourseReportGenerator();
        Console.WriteLine("Генерация отчета по курсам:");
        courseReportGenerator.GenerateReport();
    }
}
