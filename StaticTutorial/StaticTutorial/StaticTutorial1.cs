public static class StaticExample1
{
	public static void Main()
	{
		//var instance = new Constants();

		decimal valueOfPi = Constants.PI;
		decimal valueOf2 = Constants.GetNumber2();
	}
}

static class Constants
{
	public static decimal PI = 3.1415M;

	public static int GetNumber2()
	{
		return 2;
	}
}

