using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Asp.net_MVC_task_2.Models
{
	public class Student
	{
		[Required]
		[RegularExpression(@"^\d{2}-\d{5}-\d",ErrorMessage = "Id must be in the format: **-*****-*")]
		public int Id { get; set; }
		[Required]
		[MaxLength(30)]
		public string Name { get; set; }
		[Required]
		[RegularExpression(@"^\d{2}-\d{5}-\d@student.aiub.edu$",
            ErrorMessage = "Email must be in the format: **-*****-*@student.aiub.edu")]
		public string Email { get; set; }
		[Required]
		[DataType(DataType.Date)]
		public string DateOfBirth { get; set; }
	}
}