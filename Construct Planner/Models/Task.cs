namespace Construct_Planner.Models {
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DueDate { get; set; }
        public int Duration { get; set; }
        public string UserId { get; set; }
    }
}