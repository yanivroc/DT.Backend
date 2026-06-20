namespace DT.Application.Dtos;

public class ContactedPersonsDto
{
    public int ContactedPersonId { get; set; }
    public string ContactedPersonName { get; set; } = string.Empty;
    public string ContactedPersonEmail { get; set; } = string.Empty;
    public string? ContactedPersonDescription { get; set; }
    public string? ContactedPersonFilePath { get; set; }
    public DateTime ContactedDateTime { get; set; }
    public string? MobilePhone { get; set; }
}

public class CreateContactedPersonsDto
{
    public string ContactedPersonName { get; set; } = string.Empty;
    public string ContactedPersonEmail { get; set; } = string.Empty;
    public string? ContactedPersonDescription { get; set; }
    public string? ContactedPersonFilePath { get; set; }
    public DateTime ContactedDateTime { get; set; }
    public string? MobilePhone { get; set; }
}

public class UpdateContactedPersonsDto
{
    public int ContactedPersonId { get; set; }
    public string ContactedPersonName { get; set; } = string.Empty;
    public string ContactedPersonEmail { get; set; } = string.Empty;
    public string? ContactedPersonDescription { get; set; }
    public string? ContactedPersonFilePath { get; set; }
    public DateTime ContactedDateTime { get; set; }
    public string? MobilePhone { get; set; }
}
