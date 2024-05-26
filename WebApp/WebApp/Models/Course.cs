namespace WebApp.Models;

public class Course
{
    public string Id { get; set; } = null!;
    public string Title { get; set; } = null!;
    public string? Image { get; set; }
    public string Author { get; set; } = null!;
    public bool IsBestseller { get; set; }
    public bool IsDigital { get; set; }
    public int Hours { get; set; }
    public string? LikesInProcent { get; set; }
    public string? NumberOfLikes { get; set; }
    public int? StarRating { get; set; }
    public string? Reviews { get; set; }
    public string OriginalPrice { get; set; } = null!;
    public string? DiscountPrice { get; set; }
    public string? Category { get; set; } = null!;
    public Prices? Prices { get; set; }
    public Content? Content { get; set; }

}

public class Prices
{
    public string? Curreny { get; set; }
    public decimal? Price { get; set; }
    public decimal? Discount { get; set; }
}

public class Content
{
    public string? Description { get; set; }
    public string[]? Includes { get; set; }
    public ProgramDetail[]? ProgramDetails { get; set; }
}

public class ProgramDetail
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
}
