namespace DT.Application.Dtos;

public class MemberPointsDto
{
    public int Id { get; set; }
    public int PointType { get; set; }
    public int MemberId { get; set; }
    public string PagePath { get; set; } = string.Empty;
    public decimal Point { get; set; }
    public DateTime PointDateTime { get; set; }
    public bool IsConsumed { get; set; }
    public string RequestUrl { get; set; } = string.Empty;
}

public class CreateMemberPointsDto
{
    public int PointType { get; set; }
    public int MemberId { get; set; }
    public string PagePath { get; set; } = string.Empty;
    public decimal Point { get; set; }
    public DateTime PointDateTime { get; set; }
    public bool IsConsumed { get; set; }
    public string RequestUrl { get; set; } = string.Empty;
}

public class UpdateMemberPointsDto
{
    public int Id { get; set; }
    public int PointType { get; set; }
    public int MemberId { get; set; }
    public string PagePath { get; set; } = string.Empty;
    public decimal Point { get; set; }
    public DateTime PointDateTime { get; set; }
    public bool IsConsumed { get; set; }
    public string RequestUrl { get; set; } = string.Empty;
}
