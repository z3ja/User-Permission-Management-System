using System;


namespace UPMS.WindowsFormsApp.Entity
{
    public class UserEntity
    {
        public int UId { get; set; }
        public int RId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }

    }
}
