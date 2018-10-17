using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace codefirstapproach.Models
{
     [Table("Dept")]
	public class Department
	{
		[Key]
		public int Id { get; set; }
		public string Name { get; set; }
		public string Location { get; set; }

		public Employee employee { get; set; }
	}
}