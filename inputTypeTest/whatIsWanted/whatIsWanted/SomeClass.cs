/*
 * Created by SharpDevelop.
 * User: APetrovsky
 * Date: 12/18/2013
 * Time: 5:25 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace whatIsWanted
{
	/// <summary>
	/// Description of SomeClass.
	/// </summary>
	public class SomeClass : ISomeClass
	{
		public void DoSomething()
		{

		}

		public int ReturnSomething()
		{
			return 3;
		}

		public string StringData { get; set; }
		
		public static int ReturnFromStaticMethod()
		{
		    return 5;
		}
		
		public static string StringStaticData { get; set; }
	}
}
