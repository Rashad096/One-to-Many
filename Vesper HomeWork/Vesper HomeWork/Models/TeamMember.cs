using System.Collections.Generic;

namespace Vesper_HomeWork.Models
{
    public class TeamMember
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string FullName { get; set; }
        public string Position { get; set; }

        public List<SocialMedia> SocialMedias { get; set; }
    }
}
