using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Paddle.Models
{
    public class Court
    {
        [Key]
        public int Id { get; set; }
        public Boolean Active { get; set; }

}