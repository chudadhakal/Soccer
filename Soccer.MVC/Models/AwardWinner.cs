using Soccer.MVC.Models.ViewModels;

namespace Soccer.MVC.Models
{
    public class AwardWinner
    {
        public Award Award { get; set; }
        public List<Award_Season> AwardSeason { get; set; }

        public List<WinnerList> WinnerList { get; set; }
    }
}
