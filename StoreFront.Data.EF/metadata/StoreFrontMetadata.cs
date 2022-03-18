using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;//Added for metadata and validation

namespace StoreFront.Data.EF//.metadata
{
    #region Category
    public class CategoryMetaData
    {
        [Required(ErrorMessage = "*")]
        [StringLength(50, ErrorMessage = "Max 50 characters")]
        public string CategoryName { get; set; }
    }

    [MetadataType(typeof(CategoryMetaData))]
    public partial class Category { }

    #endregion

    #region Department

    public class DepartmentMetaData
    {
        [Required(ErrorMessage = "*")]
        [StringLength(50, ErrorMessage = "Max 50 characters")]
        public string Description { get; set; }
    }

    [MetadataType(typeof(DepartmentMetaData))]
    public partial class Department { }

    #endregion

    #region Employee

    public class EmployeeMetaData
    {
        [Required(ErrorMessage = "*")]
        [StringLength(50, ErrorMessage = "Max 50 characters")]
        public string FName { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(50, ErrorMessage = "Max 50 characters")]
        public string LName { get; set; }

        [Required(ErrorMessage = "*")]
        public int DirectReportID { get; set; }

        [Required(ErrorMessage = "*")]
        public int DepartmentID { get; set; }


        public Nullable<System.DateTime> HireDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public Nullable<System.DateTime> Birthdate { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(15, ErrorMessage = "Max 15 characters")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(50, ErrorMessage = "Max 50 characters")]
        public string Email { get; set; }
    }

    [MetadataType(typeof(EmployeeMetaData))]
    public partial class Employee { }

    #endregion

    #region Product

    public class ProductMetaData
    {
        [Required(ErrorMessage = "*")]
        [StringLength(50, ErrorMessage = "Max 50 characters")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "*")]
        [UIHint("MultilineText")]
        public string Description { get; set; }

        [Required(ErrorMessage = "*")]
        public int CategoryID { get; set; }

        [Required(ErrorMessage = "*")]
        public decimal Price { get; set; }

        public Nullable<int> StockStatusID { get; set; }
        public Nullable<int> Quantity { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(100, ErrorMessage = "Max 100 characters")]
        public string ProductImage { get; set; }
    }

    [MetadataType(typeof(ProductMetaData))]
    public partial class Product { }

    #endregion

    public class StockStatusMetaData
    {
        [Required(ErrorMessage = "*")]
        [StringLength(50, ErrorMessage = "Max 50 characters")]
        public string StockStatus1 { get; set; }
    }

    [MetadataType(typeof(StockStatusMetaData))]
    public partial class StockStatus { }

}
