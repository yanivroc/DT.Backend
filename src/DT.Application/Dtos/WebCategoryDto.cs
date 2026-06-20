namespace DT.Application.Dtos;

public class WebCategoryDto
{
    public int Categories_CategoryId { get; set; }
    public int WebBuilders_Id { get; set; }
}

public class CreateWebCategoryDto
{
    public int Categories_CategoryId { get; set; }
    public int WebBuilders_Id { get; set; }
}

public class UpdateWebCategoryDto
{
    public int Categories_CategoryId { get; set; }
    public int WebBuilders_Id { get; set; }
}
