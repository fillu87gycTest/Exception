using System;

/*
 * Before os generated
 * Standard message is :
 * System.IndexOutOfRangeException: インデックスが配列の境界外です。
 *    場所 ExcTest.GenException() 場所 D:\Program\Cs\ConsoleApplication36\ConsoleApplication36\ExcTest.cs:行 10
 *    場所 UseException.Main() 場所 D:\Program\Cs\ConsoleApplication36\ConsoleApplication36\Program.cs:行 9
 * Stack trace :    
 *    場所 ExcTest.GenException() 場所 D:\Program\Cs\ConsoleApplication36\ConsoleApplication36\ExcTest.cs:行 10
 *    場所 UseException.Main() 場所 D:\Program\Cs\ConsoleApplication36\ConsoleApplication36\Program.cs:行 9
 * Mmessage : インデックスが配列の境界外です。
 * TragetSite : Void GenException()
 * 
 * After try/catch block
 * 続行するには何かキーを押してください . . . 
 */

class UseException
{
	static void Main()
	{
		try
		{
			ExcTest.GenException();
		}
		catch (IndexOutOfRangeException exc)
		{
			Console.WriteLine("Standard message is : ");
			Console.WriteLine(exc);
			Console.WriteLine("Stack trace : " + exc.StackTrace);
			Console.WriteLine("Mmessage : "+ exc.Message);
			Console.WriteLine("TragetSite : "+exc.TargetSite);
			Console.WriteLine();
		}
		Console.WriteLine("After try/catch block");
	}
}