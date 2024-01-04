public static class FileHandler
{
    private const string DefaultFilePath = "genome.json";

    public static string ReadFile(string filePath = DefaultFilePath)
    {
        return File.ReadAllText(filePath);
    }

    public static void WriteFile(string content, string filePath = DefaultFilePath)
    {
        File.WriteAllText(filePath, content);
    }
}