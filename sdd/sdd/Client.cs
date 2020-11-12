using System;
using System.Collections.Generic;
using System.Text;

namespace sdd
{
	public class Client
	{
		public Client()
		{ }
		public Client(string[] info) { }
		public string FullName
		{
			get => fullName;
		}
		public string Code
		{
			get => code;
		}
		public Dictionary<string, string> ListOfCandidates
		{
			get => listOfCandidates;
			set => listOfCandidates = value;
		}
		public Dictionary<string, string> ListOfMeetings
		{
			get => listOfMeetings;
			set => listOfMeetings = value;
		}
		public byte FullYears
		{
			get => fullYears;
		}

		string[] GetInfo() { return null; }
		string GetReport() { return null; }
		private string code;
		private string fullName;
		private DateTime dateOfBirth;
		private byte fullYears;
		private string education;
		private string placeOfWork;
		private string position;
		private decimal financialPosition;
		private string maritalStatus;
		private bool availabilityOfchildren;
		private string children_sAccommodation;
		private string housingConditions;
		private bool availabilityOfCar;
		private string attitudeToBadHabits;
		private byte height;
		private byte weight;
		private string bodyType;
		private string eyeColor;
		private string hairColor;
		private string religion;
		private string nationality;
		private string interestsOrHobbies;
		private string characterTraits;
		private string lifePriorities;

		private string lifeCredo;
		private string phoneNumber;
		private string e_mail;
		private string timeForCommunication;
		private string placeOfLiving;
		private bool registeredInDispensary;
		private bool criminalRecord;
		private bool toHaveChildrenInMarriage;
		private DateTime term;
		private byte partner_sAge;
		private byte partner_sHeight;
		private byte partner_sWeight;
		private string partner_sBodyType;
		private string partner_sEducation;
		private string partner_sPlaceOfLiving;
		private bool partnerHasChildren;
		private string partner_sChildrenAccommodation;
		private string partner_sHousingConditions;
		private string partner_sReligion;
		private string partner_sNationality;
		private string partner_sAttitudeToBadHabits;
		private string partner_sImportantQualities;
		private string notNeeded;
		private string additionally;
		private Dictionary<string, string> listOfCandidates;
		private Dictionary<string, string> listOfMeetings;
		//private static ushort cntW;
		//private static ushort cntM;
	}
	}
