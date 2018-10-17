using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace codefirstapproach.Models
{
	[Table("emp")]
	public class Employee
	{
		//primary key//

		[Key]
		public int Id { get; set; }
		public string Name { get; set; }
		public string salary { get; set; }

		//foriegn key//

		//public Department department { get; set; }//
	}
}