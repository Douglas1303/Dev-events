using Poc.Domain.Utils;
using System;
using System.Linq;

namespace Poc.Domain.ValueObjects
{
    public class CpfVo
    {
        public const int LengthCpf = 11;

        public static bool IsValid(string cpf)
        {
            var cpfNumber = ValidNumber.OnlyNumbers(cpf);

            if (!LengthValid(cpfNumber)) return false;

            return !RepeatedDigits(cpfNumber) && ValidDigits(cpfNumber);
        }

        private static bool LengthValid(string value)
        {
            return value.Length == LengthCpf;
        }

        private static bool RepeatedDigits(string value)
        {
            string[] invalidNumbers =
            {
                "00000000000",
                "11111111111",
                "22222222222",
                "33333333333",
                "44444444444",
                "55555555555",
                "66666666666",
                "77777777777",
                "88888888888",
                "99999999999"
            };
            return invalidNumbers.Contains(value);
        }

        private static bool ValidDigits(string value)
        {
            var number = value.Substring(0, LengthCpf - 2);
            var digitoVerificador = new VerifyingDigit(number)
                .ComMultiplicadoresDeAte(2, 11)
                .Substituindo("0", 10, 11);
            var firstDigit = digitoVerificador.CalculaDigito();
            digitoVerificador.AddDigito(firstDigit);
            var secondDigit = digitoVerificador.CalculaDigito();

            return string.Concat(firstDigit, secondDigit) == value.Substring(LengthCpf - 2, 2);
        }
    }
}