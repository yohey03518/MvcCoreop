using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcCoreop.Models
{
    public class Record
    {
        [Display(Name = "#")]
        public int Seq { get; set; }
        [Display(Name = "類別")]
        public string Category { get; set; }
        [Display(Name = "日期")]
        public string Date { get; set; }
        [Display(Name = "金額")]
        public int Price { get; set; }
    }
}