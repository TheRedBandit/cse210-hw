public class ReadScripture
{
    string[] scripture;

    public string GetScriptureText()
    {
        string scrip = File.ReadAllText("Scripture.txt");
        return scrip;
    }
}