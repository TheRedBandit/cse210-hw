public class Entry
{
    private DateTime _entryDate;
    private string _entry;
    private string _prompt;

    public Entry(string entry, string prompt)
    {
        _entry = entry;
        _prompt = prompt;
        _entryDate = DateTime.Now;
    }

    public string DisplayEntry()
    {
        return $"{_entryDate} {_prompt} {_entry}";
    }
}