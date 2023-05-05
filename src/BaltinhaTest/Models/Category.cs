namespace BaltinhaTest.Models;

public class Category
{
    public Category()
    {
        
    }
    
    public Category(int id, string title, string description)
    {
        Id = id;
        Title = title;
        Description = description;
    }

    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}