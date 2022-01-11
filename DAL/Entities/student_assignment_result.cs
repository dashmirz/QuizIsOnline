﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
   public class student_assignment_result
    {
        [NotMapped]
        public int assign_answers_id { get; set; }
        [NotMapped]
        public string assignmentTitle { get; set; }

        [NotMapped]
        public int student_id { get; set; }
        [NotMapped]
        public string first_name { get; set; }
        [NotMapped]
        public string last_name { get; set; }
        [NotMapped]
        public string user_name { get; set; }
        [NotMapped]
        public string email { get; set; }

        [NotMapped]
        public int assignment_id { get; set; }


        [NotMapped]
        public int total_marks { get; set; } 
        [NotMapped]
        public int passing_marks { get; set; } 
        [NotMapped]
        public int gain_marks { get; set; }   
        [NotMapped]
        public int passStatus { get; set; }  

      
        [NotMapped]
        public int std_percentage { get; set; }
        public int is_checked_by_teacher { get; set; } 


        [NotMapped]
        public string resultMsg { get; set; }
        [NotMapped]
        public bool IsSuccess { get; set; }
        [NotMapped]
        public string ReturnURL { get; set; }
        [NotMapped]
        public int TotalRecordCount { get; set; }
        [NotMapped]
        public int pageId { get; set; }
        [NotMapped]
        public int ItemsPerPage { get; set; }
        [NotMapped]
        public string created_by_username { get; set; }



    }
}
