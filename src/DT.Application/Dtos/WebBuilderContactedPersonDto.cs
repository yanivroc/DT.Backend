namespace DT.Application.Dtos;

public class WebBuilderContactedPersonDto
{
    public int ContactedPersons_ContactedPersonId { get; set; }
    public int WebBuilders_Id { get; set; }
}

public class CreateWebBuilderContactedPersonDto
{
    public int ContactedPersons_ContactedPersonId { get; set; }
    public int WebBuilders_Id { get; set; }
}

public class UpdateWebBuilderContactedPersonDto
{
    public int ContactedPersons_ContactedPersonId { get; set; }
    public int WebBuilders_Id { get; set; }
}
