using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prjWebAPI.Models
{
    public class GeneralsOPDProgressGetResoutObj
    {
        /// <summary>
        /// 日期
        /// </summary>
        [Newtonsoft.Json.JsonConverter(typeof(Models.DateConverter))]
        public DateTime date { get; set; }

        /// <summary>
        /// 星期幾
        /// </summary>
        public int weekday { get { return (int)this.date.DayOfWeek; } }

        /// <summary>
        /// 時段
        /// </summary>
        public int? period { get; set; }

        //public string weekdayDesc { get { return } }
    }
}