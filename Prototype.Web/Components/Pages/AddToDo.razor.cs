using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Prototype.Web.Models;

namespace Prototype.Web.Components.Pages
{
	public partial class AddToDo
	{
		//public List<Home> tasks = new List<Home>();
		public string input { get; set; }

		
		//public AddToDo()
		//{
		//	tasks = new ToDoItems().list;
		//}
		public void Submit()
		{
			ToDoItems.list.Add(new Home() { Items = @input });
			NavigationManager.NavigateTo("/");

		}
	}
}
