using Prototype.Web.Models;
namespace Prototype.Web.Components.Pages
{
	public partial class ToDoListItem
	{
		public static List<string> input { get; set; } = new List<string>();

		public static int index;

		public void Delete(Home t)
		{
			tasks.Remove(t);
		}

		public void Done(Home t)
		{
			input.Add(t.Items);
			tasks.Remove(t);
		}

		public void Edit(Home t)
		{
			index = tasks.IndexOf(t);
			NavigationManager.NavigateTo("/edittodo");
		}

	}
}
