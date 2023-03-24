using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serialization;


namespace TypeTest
{
    class Program
	{
		public static String mPreviousTarget = null;
		public static string mCurrentTarget = null;
		public static string CurrentTarget = null;
		static bool result = false;
		string s = null;
		List<int> a = null;
		bool? d = null;
		public static void Main()
        {
			mCurrentTarget = CurrentTarget ?? string.Empty;
				
			Console.WriteLine(mCurrentTarget.Length);
			
			Console.ReadKey();

		}

		//Console.WriteLine(result);


	}
		


    }


