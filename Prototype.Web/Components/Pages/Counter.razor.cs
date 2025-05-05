namespace Prototype.Web.Components.Pages
{
	public partial class Counter
	{
		private int currentCount = 0;
		private void IncrementCount()
		{
			currentCount++;
		}
		private void DecrementCount()
		{
			currentCount--;
		}
		private void ResetCount()
		{
			currentCount = 0;
		}
	}
}
