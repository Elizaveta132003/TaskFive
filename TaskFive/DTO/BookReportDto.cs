using System;
using System.Collections.Generic;
using System.Text;

namespace TaskFive.DTO
{
	public class BookReportDto
	{
		public int Id { get; set; }

		public DateTime DateOfGiving { get; set; }

		public bool ReturnSatus { get; set; }

		public string StateOfBook { get; set; }

		public BookDto Book { get; set; }

		public SubscriberDto Subscriber { get; set; }
	}
}
