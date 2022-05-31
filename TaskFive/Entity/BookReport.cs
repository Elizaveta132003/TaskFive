using System;
using System.Collections.Generic;
using System.Text;

namespace TaskFive.Entity
{
	public class BookReport
	{
		public int Id { get; set; }

		public DateTime DateOfGiving { get; set; }

		public bool ReturnStatus { get; set; }

		public string StateOfBook { get; set; }

		public int BookId { get; set; }

		public int SubscriberId { get; set; }
	}
}
