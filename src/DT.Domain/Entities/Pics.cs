namespace DT.Domain.Entities;

public class Pics
{
    public int PicId { get; set; }
    public string? PicPath { get; set; }
    public string? PicDescription { get; set; }
    public string? PicThumbPath { get; set; }
    public int? PicPathHeight { get; set; }
    public int? PicPathWidth { get; set; }
    public int? PicThumbHeight { get; set; }
    public int? PicThumbWidth { get; set; }
    public int DisplayOrder { get; set; }
    public DateTime CreateDateTime { get; set; }
    public DateTime? UpdateDateTime { get; set; }
    public string? PicUrl { get; set; }
}
