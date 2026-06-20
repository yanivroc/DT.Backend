namespace DT.Application.Dtos;

public class BizAttributesDto
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Value { get; set; } = string.Empty;
    public int BizBizId { get; set; }
    public int MemberMemberId { get; set; }
    public bool Enabled { get; set; }
    public bool IsPublic { get; set; }
    public int AttributeTypeId { get; set; }
    public int DisplayOrder { get; set; }
}

public class CreateBizAttributesDto
{
    public string Title { get; set; } = string.Empty;
    public string Value { get; set; } = string.Empty;
    public int BizBizId { get; set; }
    public int MemberMemberId { get; set; }
    public bool Enabled { get; set; }
    public bool IsPublic { get; set; }
    public int AttributeTypeId { get; set; }
    public int DisplayOrder { get; set; }
}

public class UpdateBizAttributesDto
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Value { get; set; } = string.Empty;
    public int BizBizId { get; set; }
    public int MemberMemberId { get; set; }
    public bool Enabled { get; set; }
    public bool IsPublic { get; set; }
    public int AttributeTypeId { get; set; }
    public int DisplayOrder { get; set; }
}
