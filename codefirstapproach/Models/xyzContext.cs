using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace codefirstapproach.Models
{
	public class xyzContext : DbContext
	{
		//create constructor of context class

		
	public DbSet<Department> Dept { get; set; }
	public DbSet<Employee> emp{ get; set; }



	
}   }
