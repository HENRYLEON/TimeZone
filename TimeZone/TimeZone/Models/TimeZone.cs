namespace TimeZone
{
  public class TimeZone
  {
    public string _value { get; set; }
    public string _text { get; set; }
    public byte _selected { get; set; }
    public TimeZone(string value,string text, byte selected)
    {
      _value = value;
      _text = text;
      _selected = selected;
    }
  }
}