namespace TaskApp.Models
{
    public class MyTaskDto
    {
        public DateTime? StartDate { get; set; } = DateTime.Now;
        public DateTime? EndDate { get; set; } = DateTime.Now.AddDays(7);
        public string Name { get; set; } = "";
        public string? Description { get; set; } = "";
        public string Category { get; set; } = "";
    }
}
