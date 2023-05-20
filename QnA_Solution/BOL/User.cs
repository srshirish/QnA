namespace BOL;
using System.ComponentModel.DataAnnotations;

public class User {

        [Key]
        public int UId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string SecurityToken { get; set; }
        public string Password { get; set; }
    
}