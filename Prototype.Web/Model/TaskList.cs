namespace Prototype.Web;

public enum Priority
{
	Low,
	Medium,
	High
}

public enum Status
{
	Completed,
	Progress
}

public class TaskList
{
	public Guid Id { get; set; } = Guid.NewGuid();
	public string Name { get; set; }
	public int EstimatedHours { get; set; }
	public Priority Priority { get; set; }
	public Status IsCompleted { get; set; } = Status.Progress;
}