namespace DT.Application.Dtos;

public class WebPageBizsDto
{
    public int WebPageId { get; set; }
    public int BizTypeId { get; set; }
    public bool ShowInMaps { get; set; }
    public int WebBuilderId { get; set; }
    public bool Feeder { get; set; }
}

public class CreateWebPageBizsDto
{
    public int WebPageId { get; set; }
    public int BizTypeId { get; set; }
    public bool ShowInMaps { get; set; }
    public int WebBuilderId { get; set; }
    public bool Feeder { get; set; }
}

public class UpdateWebPageBizsDto
{
    public int WebPageId { get; set; }
    public int BizTypeId { get; set; }
    public bool ShowInMaps { get; set; }
    public int WebBuilderId { get; set; }
    public bool Feeder { get; set; }
}
