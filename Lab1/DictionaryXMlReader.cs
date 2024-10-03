interface DictionaryXMlReader<T> where T : DictionaryBaseType
{
    List<T> ReadFromXml(string filePath);
}