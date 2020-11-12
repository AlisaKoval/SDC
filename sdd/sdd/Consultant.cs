using System;
using System.Collections.Generic;
namespace sdd
{
	public class Consultant
	{
		public Consultant()
		{
		}
		private string positionCode;
		private string fullName;
		private byte age;
		private string telephone;
		private ushort numberOfClients;
		private ushort numberOfPairs;
		private DateTime dateOfEmployment;
		private string lastEmployment;
		private byte experience;
		private string address;
		private string passportData;
		private decimal salary;
		private static ushort cnt;
		private string password;
		private List<Client> listOfClients;

		
		public string FullName
		{
			get => fullName;
		}
		string[] GetInfo()
		{
			return null;
		}
		string GetReport()
		{
			return null;
		}
	}
}
