namespace Prototype.Web.Services
{
	public class StateContainer
	{
		private long totalAmount = 0;

		public long Property
		{
			get => totalAmount;
			set
			{
				totalAmount = value;
				NotifyStateChanged();
			}
		}

		public event Action? OnChange;

		private void NotifyStateChanged() => OnChange?.Invoke();
	}
}
