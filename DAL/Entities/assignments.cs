using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class assignments
    {
        public int assignment_id { get; set; }
        public string title { get; set; }
        public string body { get; set; }
        public string start_date { get; set; }
        public string end_date { get; set; }
        public int? allowed_time_minutes { get; set; }
        public int? status { get; set; } 
        public string status_title { get; set; }


        public int course_id { get; set; }
      
        public string description { get; set; }
        public int total_marks { get; set; }  
        public int passing_marks { get; set; }
       
        public string guid { get; set; }
        public string created_at { get; set; }

        public int? created_by { get; set; }

        public string modified_at { get; set; }


        public int? modified_by { get; set; }


        public int? is_deleted { get; set; }

        //Not mapped
        [NotMapped]
        public string course_name { get; set; }
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

        [NotMapped]
        public string submit_status { get; set; }
        [NotMapped]
        public int is_checked_by_teacher { get; set; }
        [NotMapped]
        public string student_ans { get; set; }
        public int assign_answers_id { get; set; }
        public int gain_marks { get; set; } 
    }
}
