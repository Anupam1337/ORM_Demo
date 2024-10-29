namespace Management.Models
{
    public class UserData
    {
        //user_name	name	Email	password	user_id	profile_pic	role_id	role_name	CreatedAt	UpdatedAt
        public string user_name { get; set; } 
        public string name { get; set; } 
        public string? Email { get; set; } = null;
        public string password { get; set; } = string.Empty;
        public int user_id { get; set; }
        public string? profile_pic { get; set; }
        public int role_id { get; set; }
        public string? role_name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
