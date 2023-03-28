namespace ChooseTheRestaurantApi.Services.Dtos.Request
{
    public class VoteRequestDto
    {
        public int RestaurantCode { get; set; }
        public string PersonName { get; set; }
        public string PersonCPF { get; set; }
    }
}
