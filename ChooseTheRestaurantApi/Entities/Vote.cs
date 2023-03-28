using ChooseTheRestaurantApi.Entities.Base;

namespace ChooseTheRestaurantApi.Entities
{
    public class Vote : BaseEntity
    {
        public int Id { get; set; }
        public int RestaurantCode { get; set; }
        public string PersonName { get; set; }
        public string PersonCPF { get; set; }
    }
}
