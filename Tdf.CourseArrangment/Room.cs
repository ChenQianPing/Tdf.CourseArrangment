using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tdf.CourseArrangment
{
    /// <summary>
    /// 教室类
    /// </summary>
    public class Room
    {
        public int RoomId { get; set; }

        public string RoomName { get; set; }

        /// <summary>
        /// 标准容量
        /// </summary>
        public int StandardCapacity { get; set; }

        /// <summary>
        /// 最大容量
        /// </summary>
        public int MaximumCapacity { get; set; }
    }
}
