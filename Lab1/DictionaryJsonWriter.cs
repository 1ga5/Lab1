interface DictionaryJsonWriter<T> where T : DictionaryBaseType
{
    bool WriteToJson(List<T> dictionaryList, string outputPath);
}