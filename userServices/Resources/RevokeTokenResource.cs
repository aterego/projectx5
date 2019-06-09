using System.ComponentModel.DataAnnotations;

namespace userServices.Resources
{
    public class RevokeTokenResource
    {
        [Required]
        public string Token { get; set; }
    }
}
