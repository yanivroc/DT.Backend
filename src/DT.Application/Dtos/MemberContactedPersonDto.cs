namespace DT.Application.Dtos;

public class MemberContactedPersonDto
{
    public int ContactedPersons_ContactedPersonId { get; set; }
    public int Members_MemberId { get; set; }
}

public class CreateMemberContactedPersonDto
{
    public int ContactedPersons_ContactedPersonId { get; set; }
    public int Members_MemberId { get; set; }
}

public class UpdateMemberContactedPersonDto
{
    public int ContactedPersons_ContactedPersonId { get; set; }
    public int Members_MemberId { get; set; }
}
