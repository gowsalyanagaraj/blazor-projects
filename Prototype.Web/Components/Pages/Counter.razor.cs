namespace Prototype.Web.Components.Pages
{
	public partial class Counter
	{
		private int currentCount = 0;
		private int upperLimit = 20;
		private int lowerLimit = -20;
		private string message = "";

		private void IncrementCount()
		{
			if(!(currentCount >= upperLimit))
			{
				currentCount++;
				message = "";
			}
			else
			{
				message = "Limit reached.";
			}

		}
		private void DecrementCount()
		{
			if(!(currentCount <= lowerLimit))
			{
				currentCount--;
				message = "";
			}
			else
			{
				message = "Limit reached.";
			}
		}
		private void ResetCount()
		{
			message = "";
			currentCount = 0;
		}
	}
}
