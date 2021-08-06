using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LabraryMVC.Models
{
    public class CategoryDetail
    {
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Category Name is Required")]
        [StringLength(100, ErrorMessage = "Minimum 3 and maximum 100 charaters are allwed", MinimumLength = 3)]
        public string CategoryName { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDelete { get; set; }

    }

    public class BookDetail
    {
        public int BookId { get; set; }
        [Required(ErrorMessage = "Book Name is Required")]
        [StringLength(100, ErrorMessage = "Minimum 3 and maximum 100 charaters are allwed", MinimumLength = 3)]
        public string BookName { get; set; }
        [Required]
        [Range(1, 50)]
        public Nullable<int> CategoryId { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string Description { get; set; }
        [Required(ErrorMessage = "Description is Required")]
        public string BookImage { get; set; }
        public Nullable<bool> IsFeatured { get; set; }
        public Nullable<int> Quantity { get; set; }
        public string Author { get; set; }
        [Required]
        public Nullable<System.DateTime> PublicationDate { get; set; }
        [Required]
        public SelectList Categories { get; set; }
    }
}
