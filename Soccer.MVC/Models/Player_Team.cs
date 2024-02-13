using Microsoft.EntityFrameworkCore;

namespace Soccer.MVC.Models
{
    [Keyless]
    public class Player_Team
    {
        public int? Player_ID { get; set; }

        public int? Team_ID { get; set; }
    }
}
