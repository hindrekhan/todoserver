using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string AccountId { get; set; }
        [Required, MaxLength(255)]
        public string Title { get; set; }
        public string Desc { get; set; }
        public bool MarkedAsDone { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}