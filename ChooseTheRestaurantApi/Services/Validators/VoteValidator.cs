using ChooseTheRestaurantApi.Entities;
using FluentValidation;

namespace ChooseTheRestaurantApi.Services.Validators
{
    public class VoteValidator : AbstractValidator<Vote> 
    {
        public VoteValidator()
        {
            RuleFor(vote => vote.CreationDate).GreaterThan(DateTime.Today.AddHours(9));
            RuleFor(vote => vote.CreationDate).LessThan(DateTime.Today.AddHours(11).AddMinutes(50));
            RuleFor(vote => vote.RestaurantCode).NotNull().NotEmpty();
            RuleFor(vote => vote.PersonName).NotNull().NotEmpty();
            RuleFor(vote => vote.PersonCPF).NotNull().NotEmpty().Length(11).WithMessage("Informe um CPF válido");
        }
    }
}
