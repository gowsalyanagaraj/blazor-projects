
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Prototype.Web.Models;

namespace Prototype.Web.Components.Pages
{
	public partial class Button
	{

		[Parameter]
		public EventCallback<MouseEventArgs> eventCallback { get; set; }

		
	}
}
