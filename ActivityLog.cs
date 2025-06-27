public class ActivityLog
{
    public DateTime Timestamp { get; set; }
    public string Description { get; set; }

    public override string ToString() => $"{Timestamp:G} - {Description}";
}