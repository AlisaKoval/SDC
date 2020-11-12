using System;
using System.Collections.Generic;
namespace sdd
{
	public class Couple
	{
		public Couple()
		{
		}
		private string firstClientFullName;
		private string secondClientFullName;
		private string firstClientCode;
		private string secondClientCode;
		private DateTime dateOfTheMeeting;
		private string meetingPlase;
		private static ushort cnt;

		public string FirstClientFullName
		{
			get => firstClientFullName;
		}
		public string SecondClientFullName
		{
			get => secondClientFullName;
		}
		string[] GetInfo()
		{
			return null;
		}

	}
}
