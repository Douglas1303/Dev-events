using Poc.Domain.Enum;
using System.Text.RegularExpressions;

namespace Poc.Domain.ValueObjects
{
    public class PhoneVo : ValueObject
    {
        public EPhoneType PhoneType { get; private set; }
        public string Number { get; private set; }

        public PhoneVo(EPhoneType phoneType, string number)
        {
            PhoneType = phoneType;
            Number = number;
        }

        protected bool IsValidCelular()
        {
            return new Regex(@"^\([1-9]{2}\) (?:[2-8]|9[1-9])[0-9]{3}\-[0-9]{4}$", RegexOptions.Compiled).IsMatch(Number);
        }

        protected bool IsValidPhone()
        {
            return new Regex(@"^\([1-9]{2}\) (?:[2-8]|9[1-9])[0-9]{3}\-[0-9]{4}$", RegexOptions.Compiled).IsMatch(Number);
        }

        protected bool IsValidWhatsApp()
        {
            return IsValidCelular() || IsValidPhone();
        }

        public override bool IsValid()
        {
            switch (PhoneType)
            {
                case EPhoneType.Comercial:
                    return IsValidPhone();

                case EPhoneType.Residencial:
                    return IsValidPhone();

                case EPhoneType.Celular:
                    return IsValidCelular();

                case EPhoneType.WhatsApp:
                    return IsValidWhatsApp();

                default:
                    return false;
            }
        }
    }
}