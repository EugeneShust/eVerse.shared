namespace Shared.Protocol.Dtos
{
    public class ProfileDto
    {
        public string Avatar { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public List<string> Events { get; set; } = [];
    }
}
