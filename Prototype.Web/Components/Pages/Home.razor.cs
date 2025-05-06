
using Microsoft.AspNetCore.Components;
using Prototype.Web.Models;

namespace Prototype.Web.Components.Pages
{
	public partial class Home
	{
		public string Items { get; set; }

		public List<Home> tasksList = ToDoItems.list;
		
	}
}
