using System.ComponentModel.DataAnnotations;

namespace MyProject.AccessDatas.Models;

public class Test
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Owner { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}
