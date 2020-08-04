using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSampleComponents.Models
{
	public class TodoModel
	{
		public int Id { get; set; }
		public TodoStatuses Status { get; set; }
		public string Description { get; set; }
		public DateTime LastUpdated { get; set; }
	}

	public enum TodoStatuses
	{
		Todo,
		InProgress,
		Completed
	}
}
