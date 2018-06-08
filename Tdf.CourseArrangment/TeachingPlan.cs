using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tdf.CourseArrangment
{
    /// <summary>
    /// 教学计划
    /// </summary>
    public class TeachingPlan
    {
        /// <summary>
        /// 年级
        /// </summary>
        public string GradeName { get; set; }

        /// <summary>
        /// 计划名称
        /// </summary>
        public string PlanName { get; set; }

        /// <summary>
        /// 年度
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// 学年学期
        /// </summary>
        public string SchoolYear { get; set; }


    }
}
