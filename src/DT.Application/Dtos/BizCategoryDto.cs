namespace DT.Application.Dtos;

public class BizCategoryDto
{
    public int Bizs_BizId { get; set; }
    public int Categories_CategoryId { get; set; }
}

public class CreateBizCategoryDto
{
    public int Bizs_BizId { get; set; }
    public int Categories_CategoryId { get; set; }
}

public class UpdateBizCategoryDto
{
    public int Bizs_BizId { get; set; }
    public int Categories_CategoryId { get; set; }
}
