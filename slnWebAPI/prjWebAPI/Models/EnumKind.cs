using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace prjWebAPI.Models
{
    public class EnumKind
    {
        /// <summary>
        /// 裝置種類
        /// </summary>
        public enum DeviceKind 
        {
            [Display(Name = "android")]
            A = 1,

            [Display(Name ="iOS")]
            I,
        }

        /// <summary>
        /// byte轉string方式種類
        /// </summary>
        public enum ByteDataKind 
        {
            Base64,
            BitConcerter,
        }

        #region PlatformMessageKind 平台訊息種類
        /// <summary>
        /// 平台訊息種類
        /// <para>請使用GetDescription取得中文描述</para>
        /// </summary>
        public enum PlatformMessageKind 
        {
            [Description("異常錯誤。")]
            Error,

            [Description("異常操作。")]
            AbnormalOperation,

            [Description("缺少必要資料或資料格式不符。")]
            DataValidFail,

            [Description("系統維護中。")]
            Maintain,

            [Description("此值已存在，請使用別的值。")]
            ValueIsExist,

            [Description("此代碼或編號已存在。")]
            CodeIsExist,

            [Description("此名稱已存在。")]
            NameIsExist,

            [Description("此代碼或編號不存在。")]
            CodeIsNotExist,

            [Description("OK")]
            OK,

            [Description("成功。")]
            Success,

            [Description("查無資料。")]
            NoData,

            [Description("驗證碼錯誤。")]
            AuthKeyFail,

            [Description("已登出。")]
            Logout,

            [Description("請重新登入。")]
            LoginAgain,

            [Description("帳號或密碼錯誤，登入失敗。")]
            LoginFail,

            [Description("帳號已被鎖住。")]
            LoginAccidLock,

            [Description("登入KEY錯誤。")]
            LogonKeyError,

            [Description("帳號已停用。")]
            AccidDisabled,

            [Description("儲存成功。")]
            SaveSuccess,

            [Description("儲存失敗。")]
            SaveFail,

            [Description("刪除成功。")]
            DeleteSuccess,

            [Description("刪除失敗。")]
            DeleteFail,

            [Description("帳號已存在。")]
            AccidIsExist,

            [Description("Mail已存在。")]
            EmailIsExist,

            [Description("無權限。")]
            NoRight,

            [Description("待診所確認後，才給號。")]
            NotRegNumberMessage,

            [Description("診所不存在。")]
            ClinicNotExist,

            [Description("醫師不存在。")]
            DoctorNotExist,

            [Description("此時段醫師沒有看診。")]
            DoctorNotSee,

            [Description("證號或生日不一致。")]
            IdNumAndBirthdayNotExist,

            [Description("取消失敗。")]
            CanceFail,

            [Description("已經是最後的號碼。")]
            IsLastNumber,

            [Description("沒有下一個號碼。")]
            IsNotNextNumber,

            [Description("沒有下一個已報到的號碼。")]
            IsNotCheckInNextNumber,

            [Description("掛號號碼已存在。")]
            RegNumberIsExist,

            [Description("已看診，無法取消。")]
            HaveSeenNotCancel,

            [Description("測試資料建立完成。")]
            CreateTestDataCompleted,
        }
        #endregion

        #region ModelStateErrorMessageReturnType ModelState 錯誤訊息取得種類
        /// <summary>
        /// ModelState錯誤訊息取得的種類
        /// </summary>
        public enum ModelStateErrorMessageReturnType 
        {
            /// <summary>
            /// 只取得第一個錯誤
            /// </summary>
            FirstError,

            /// <summary>
            /// 取得所有錯誤
            /// </summary>
            AllError
        }
        #endregion

        #region 診所使用者角色種類
        /// <summary>
        /// 診所使用者角色種類
        /// </summary>
        public enum ClinicUsrRoleKind 
        {
            [Display(Name ="其他")]
            Other = 0,

            [Display(Name = "醫師")]
            Doctor = 1,

            [Display(Name = "護理師")]
            Nurse = 2,
        }
        #endregion

        #region WeekdayKind 星期幾種類
        /// <summary>
        /// 星期幾種類
        /// </summary>
        public enum WeekdayKind 
        {
            [Display(Name = "星期日")]
            Sunday,

            [Display(Name = "星期一")]
            Monday,

            [Display(Name = "星期二")]
            Tuesday,

            [Display(Name = "星期三")]
            Wednesday,

            [Display(Name = "星期四")]
            Thursday,

            [Display(Name = "星期五")]
            Friday,

            [Display(Name = "星期六")]
            Saturday,
        }
        #endregion

        #region PeriodKind 時段種類
        /// <summary>
        /// 時段種類
        /// </summary>
        public enum PeriodKind 
        {
            [Display(Name = "上午")]
            Morning = 1,

            [Display(Name = "下午")]
            Afternoon,

            [Display(Name = "夜間")]
            Night,
        }
        #endregion

        #region SerialDateKind 取得號碼種類
        /// <summary>
        /// 取得號碼種類
        /// </summary>
        public enum SerialDateKind 
        {
            [Display(Name = "流水號")]
            serial,

            [Display(Name = "掛號號碼")]
            rnum,
        }
        #endregion

        #region ClinicRNumberCreateKind 掛號號碼建立總類
        /// <summary>
        /// 基本(流水序號)
        /// </summary>
        public enum ClinicRNumberCreateKind 
        {
            [Display(Name = "基本(流水序號)")]
            Base,
        }
        #endregion

        #region SearchOpdProgressKind 當日看診清單查詢種類
        /// <summary>
        /// 當日看診清單查詢種類
        /// </summary>
        public enum SearchOpdProgressKind 
        {
            [Display(Name = "當日看診")]
            NeedSee = 1,

            [Display(Name = "過號")]
            PastNumber,

            [Display(Name = "已就診")]
            HaveSeen,

        }
        #endregion

        #region OpdProgressStatusLind 當日看診狀態種類
        /// <summary>
        /// 當日看診狀態種類
        /// </summary>
        public enum OpdProgressStatusLind 
        {
            [Display(Name = "叫號")]
            Call = 1,

            [Display(Name = "報到")]
            CheckIn,

            [Display(Name = "就診")]
            See,
        }
        #endregion

        #region TOCCItemKind TOCC項目種類
        /// <summary>
        /// TOCC項目種類
        /// </summary>
        public enum TOCCItemKind 
        {
            [Display(Name = "症狀")]
            symptom = 1,

            [Display(Name = "出國史")]
            go_country,

            [Display(Name = "國家")]
            country,

            [Display(Name = "職業別")]
            occupation,

            [Display(Name = "接觸史")]
            contact,

            [Display(Name = "接觸史-第二層")]
            contact_l2,

            [Display(Name = "群聚史")]
            cluster,

            [Display(Name = "群聚史-第二層")]
            cluster_l2,
        }
        #endregion

        #region PushTargetKind 推播目標對象種類
        /// <summary>
        /// 推播目標對象種類
        /// </summary>
        public enum PushTargetKind 
        {
            [Display(Name = "全部")]
            All = 1,

            [Display(Name = "指定對象")]
            AsignPat = 2,

            [Display(Name = "依推播項目代碼")]
            PushItem = 32,
        }
        #endregion

        #region PushItemKind 推播項目種類
        /// <summary>
        /// 推播項目種類
        /// </summary>
        public enum PushItemKind 
        {
            [Display(Name = "歲月 (N歲)")]
            Age = 1,

            [Display(Name = "嬰兒 (出生N月)")]
            Baby = 2,

        }
        #endregion

        public enum PatienGetKind 
        {
            all = 1,
            token = 2,
        }
    }
}
