using LibraryApi.Models.Enums;

namespace LibraryApi.Models.Entities
{
    public abstract class Library
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public UserState State { get; set; } = UserState.Enabled;
        public UserType Type { get; set; } = UserType.User;
    }
}
