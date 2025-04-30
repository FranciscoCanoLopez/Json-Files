using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json_Files
{
    internal class Student
    {
        public string? Student_ID { get; set; }
        public string? First_Name { get; set; }
        public string? Last_Name { get; set; }
        public string? Email { get; set; }
        public string? Gender { get; set; }
        public int Age { get; set; }
        public string? Department { get; set; }
        [JsonProperty("Attendance (%)")]
        public double Attendance { get; set; }
        public double Midterm_Score { get; set; }
        public double Final_Score { get; set; }
        public double Assignments_Avg { get; set; }
        public double Quizzes_Avg { get; set; }
        public double Participation_Score { get; set; }
        public double Projects_Score { get; set; }
        public double Total_Score { get; set; }
        public string? Grade { get; set; }
        public double Study_Hours_per_Week { get; set; }
        public string? Extracurricular_Activities { get; set; }
        public string? Internet_Access_at_Home { get; set; }
        public string? Parent_Education_Level { get; set; }
        public string? Family_Income_Level { get; set; }
        [JsonProperty("Stress_Level (1-10)")]
        public int Stress_Level { get; set; }
        public double Sleep_Hours_per_Night { get; set; }
    }
}
