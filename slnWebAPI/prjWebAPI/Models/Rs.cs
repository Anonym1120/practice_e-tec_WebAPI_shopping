using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prjWebAPI.Models
{
    public class Rs
    {
        /// <summary>
        /// 是否成功
        /// </summary> 
        public bool isSuccess { get; set; }

        /// <summary>
        /// 成功或失敗的訊息
        /// </summary>
        public string message { get; set; }

        ///<summary>
        /// 例外錯誤或其他錯誤的訊息
        ///</summary>
        ///
        public string errorMessage { get; set; }
    }



    /// <summary>
    /// Rs 附帶資料
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ObjRs<T> : Rs
    {
        /// <summary>
        /// 資料結果物件
        /// </summary>
        public T resultObj { get; set; }
        
    }



    /// <summary>
    /// 附帶資料清單
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ListRs<T> : Rs 
    {
        /// <summary>
        /// 資料結果清單
        /// </summary>
        public IList<T> resultList { get; set; }

        public ListRs()
        {
            this.resultList = new List<T>();
        }
    }



    /// <summary>
    /// API固定格式結果
    /// </summary>
    /// <typeparam name="O"></typeparam>
    /// <typeparam name="L"></typeparam>
    public class ApiRs<O, L> : Rs 
    {
        public ApiRs()
        {
            this.resultList = new List<L>();
        }

        /// <summary>
        /// 資料結果物件
        /// </summary>
        public O resultObj { get; set; }

        /// <summary>
        /// 資料結果清單
        /// </summary>
        public IList<L> resultList { get; set; }
    }

}