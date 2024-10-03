using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        // Для поддержки кодировки windows-1251
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

        MedicalCareFormReader reader = new();
        MedicalCareFormWriter writer = new();
        
        Console.Write("Введите путь для чтения файла: ");
        var dictionaryFilePath = Console.ReadLine();

        Console.Write("Введите путь для записи файла: ");
        var dictionaryFilePathSave = Console.ReadLine();

        if (!string.IsNullOrEmpty(dictionaryFilePath) && !string.IsNullOrEmpty(dictionaryFilePathSave))
        {
            List<MedicalCareFormDictionary> testList = reader.ReadFromXml(dictionaryFilePath);
            writer.WriteToJson(testList, dictionaryFilePathSave);
        }
    }
}