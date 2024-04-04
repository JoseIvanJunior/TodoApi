namespace TodoApi;

public class NamedAPIResourceList
{
    public int Count { get; set; }
    public string Next { get; set; }
    public string Previous { get; set; }
    public NamedAPIResource[] Results { get; set; }
}
