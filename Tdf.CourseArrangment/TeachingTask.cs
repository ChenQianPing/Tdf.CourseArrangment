using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tdf.CourseArrangment
{
    /// <summary>
    /// 教学任务
    /// </summary>
    public class TeachingTask
    {
        /// <summary>
        /// 教学计划名称
        /// </summary>
        public string PlanName { get; set; }

        /// <summary>
        /// 班级Id
        /// </summary>
        public int ClassId { get; set; }

        /// <summary>
        /// 科目Id
        /// </summary>
        public int CourseId { get; set; }

        /// <summary>
        /// 教师Id
        /// </summary>
        public int TeacherId { get; set; }

        /// <summary>
        /// 安排节数
        /// </summary>
        public int PlanSection { get; set; }


        /// <summary>
        /// 总节数
        /// </summary>
        public int TotalSection { get; set; }

        /// <summary>
        /// 排课天数
        /// </summary>
        public int Days { get; set; }

        /// <summary>
        /// 每天节数
        /// </summary>
        public int DaySection { get; set; }

        /// <summary>
        /// 开始日期
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// 结束日期
        /// </summary>
        public DateTime EndDate { get; set; }
    }
}
