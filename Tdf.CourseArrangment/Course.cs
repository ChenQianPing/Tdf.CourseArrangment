using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tdf.CourseArrangment
{
    /// <summary>
    /// 课程类
    /// </summary>
    public class Course
    {
        /// <summary>
        /// 课程编号
        /// </summary>
        public int CourseId { get; set; }

        /// <summary>
        /// 课程名称
        /// </summary>
        public string CourseName { get; set; }

        /// <summary>
        /// 课程的重要程度
        /// </summary>
        public int Weight { get; set; }
    }
}
