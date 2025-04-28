using Prototype.Web.Models;

namespace Prototype.Web.Components.Pages
{
	public partial class EditToDo
	{
		public string input { get; set; } = ToDoItems.list[ToDoListItem.index].Items;
		public void Submit()
		{
			ToDoItems.list[ToDoListItem.index].Items = @input;
			NavigationManager.NavigateTo("/");
		}
	}
}
