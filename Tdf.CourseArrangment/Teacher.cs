using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tdf.CourseArrangment
{
    /// <summary>
    /// 教师课程班级关系类
    /// </summary>
    public class Teacher
    {
        /// <summary>
        /// 教师编号
        /// </summary>
        public int TeacherId { get; set; }

        /// <summary>
        /// 教师名称
        /// </summary>
        public string TeacherName { get; set; }

        /// <summary>
        /// 老师所授课程，可能存在一个老师教几门课的情况
        /// </summary>
        public List<Course> Courses { get; set; }

        /// <summary>
        /// 老师所授班级，存在一个老师上多个班级的情况
        /// </summary>
        public List<Class> Classes { get; set; }
    }
}
