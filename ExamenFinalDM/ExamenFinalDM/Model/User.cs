using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace ExamenFinalDM.Model
{
    [Table("Usuario")]
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
