namespace DT.Domain.Entities;

public class WebPageBizs
{
    public int WebPageId { get; set; }
    public int BizTypeId { get; set; }
    public bool ShowInMaps { get; set; }
    public int WebBuilderId { get; set; }
    public bool Feeder { get; set; }
}
