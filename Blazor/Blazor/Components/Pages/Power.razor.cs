namespace Blazor.Components.Pages
{
	public partial class Power
	{
		double number;
		double exponent;
		double power;
		void Calculate()
		{
			power = Math.Pow(number, exponent);
		}
	}
}
