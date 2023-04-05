namespace Vesper_HomeWork.Models
{
    public class SocialMedia
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }  
        public int TeamMemberID { get; set; }   
        public TeamMember TeamMember { get; set; }  
    }
}
