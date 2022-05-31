using System;
using System.Collections.Generic;
using System.Text;

namespace TaskFive.Entity
{
	internal class Subscriber
	{
		public int Id { get; set; }
		public string FirstName { get; set; }

		public string MiddleName { get; set; }

		public string LastName { get; set; }

		public bool Sex { get; set; }
		public DateTime DateOfBirth { get; set; }
	}
}
