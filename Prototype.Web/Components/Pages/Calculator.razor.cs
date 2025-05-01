using Microsoft.AspNetCore.Components;

namespace Prototype.Web.Components.Pages
{
	public partial class Calculator : ComponentBase
	{
		private float FirstNumber { get; set; }
		private float SecondNumber { get; set; }
		private float Result { get; set; }
		private string Operation { get; set; }
		private bool IsShow { get; set; } = false;

		private void Calculate()
		{
			switch(Operation)
			{
				case "add":
					Result = FirstNumber + SecondNumber;
					break;
				case "subtract":
					Result = FirstNumber - SecondNumber;
					break;
				case "multiply":
					Result = FirstNumber * SecondNumber;
					break;
				case "divide":
					if(SecondNumber != 0)
					{
						Result = FirstNumber / SecondNumber;
					}
					else
					{
						Result = float.NaN;
					}
					break;
				default:
					Result = float.NaN;
					break;

			}
			IsShow = true;
		}
	}
}
