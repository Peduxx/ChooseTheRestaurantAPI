using ChooseTheRestaurantApi.Entities.Base;

namespace ChooseTheRestaurantApi.Entities
{
    public class Restaurant : BaseEntity
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public List<Vote> Votes { get; set; }
    }
}
