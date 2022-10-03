using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RepositryLayer.Entities
{
    public class UserEntity
    {
        public static string passWord { get; internal set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string EmailId { get; set; }
        public string Password { get; set; }
    }
}
