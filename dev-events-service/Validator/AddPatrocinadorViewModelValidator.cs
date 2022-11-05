using FluentValidation;
using Poc.Application.ViewModel;

namespace dev_events_service.Validator
{
    public class AddPatrocinadorViewModelValidator : AbstractValidator<AddPatrocinadorViewModel>
    {
        public AddPatrocinadorViewModelValidator()
        {
            Validators();
        }

        private void Validators()
        {
            RuleFor(p => p.TipoPatrocinador)
                .NotEmpty()
                .NotNull();
            RuleFor(p => p.NomePatrocinador)
                .NotEmpty()
                .NotNull();
            RuleFor(p => p.Documento)
                .NotEmpty()
                .NotNull();
            RuleFor(p => p.Cep)
                .NotEmpty()
                .NotNull();
        }
    }
}
