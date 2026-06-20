namespace DT.Domain.Entities;

public class ContactedPersons
{
    public int ContactedPersonId { get; set; }
    public string ContactedPersonName { get; set; } = string.Empty;
    public string ContactedPersonEmail { get; set; } = string.Empty;
    public string? ContactedPersonDescription { get; set; }
    public string? ContactedPersonFilePath { get; set; }
    public DateTime ContactedDateTime { get; set; }
    public string? MobilePhone { get; set; }
}
