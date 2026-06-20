namespace DT.Application.Dtos;

public class BizContactedPersonDto
{
    public int Bizs_BizId { get; set; }
    public int ContactedPersons_ContactedPersonId { get; set; }
}

public class CreateBizContactedPersonDto
{
    public int Bizs_BizId { get; set; }
    public int ContactedPersons_ContactedPersonId { get; set; }
}

public class UpdateBizContactedPersonDto
{
    public int Bizs_BizId { get; set; }
    public int ContactedPersons_ContactedPersonId { get; set; }
}
