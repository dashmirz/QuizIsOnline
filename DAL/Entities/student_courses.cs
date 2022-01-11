﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
   public class student_courses
    {
        public int student_course_id { get; set; }
        public int? student_id { get; set; }
        public int? course_id { get; set; }

		public string guid { get; set; }

		public string created_at { get; set; }

		public int? created_by { get; set; }

		public string modified_at { get; set; }
		public int? modified_by { get; set; }
		public int? is_deleted { get; set; }

		public string resultMsg { get; set; }

		public bool IsSuccess { get; set; }

		public string ReturnURL { get; set; }

		public int TotalRecordCount { get; set; }
		public int pageId { get; set; }
		public int ItemsPerPage { get; set; }
		public string created_by_username { get; set; }


		[NotMapped]
		public string user_name { get; set; }
		[NotMapped]
		public string email { get; set; }
		[NotMapped]
		public string title { get; set; }

	}
}
