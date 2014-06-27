
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RadioButtonListLab.Models
{
    public enum RepeatDirections
    {
        // 摘要: 
        //     清單的項目會由左而右，然後由上而下，以水平成列顯示，直到所有項目皆呈現。
        Horizontal = 0,
        //
        // 摘要: 
        //     清單的項目會由上而下，然後由左而右，以垂直成行顯示，直到所有項目皆呈現。
        Vertical = 1,
    }

    public class ProductModel
    {
        public ProductModel()
        {
            this.Direction = RepeatDirections.Horizontal;
        }
        public int ProductId { get; set; }

        [Display(Name = "分類名稱")]
        public string CategoryName { get; set; }

        [Display(Name = "產品名稱")]
        public string ProductName { get; set; }

        public int Qty { get; set; }

        public double Price { get; set; }

        public DateTime CreateDate { get; set; }

        public bool OnSaled { get; set; }

        public RepeatDirections Direction { get; set; }

    }
}