using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        public int ID { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public int GenreID { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime ReleasedDate { get; set; }

        private DateTime addedDate = DateTime.Now;

        public DateTime AddedDate
        {
            get
            {
                return addedDate;
            }
            set
            {
                addedDate = value;
            }
        }

        [Range(1, 20)]
        public byte NumberInStock { get; set; }
    }
}