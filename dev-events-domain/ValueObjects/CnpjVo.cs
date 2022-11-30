using Poc.Domain.Utils;
using System;
using System.Linq;

namespace Poc.Domain.ValueObjects
{
    public class CnpjVo
    {
        public const int LengthCnpj = 14;

        public static bool IsValid(string cpnj)
        {
            var cnpjNumeros = ValidNumber.OnlyNumbers(cpnj);

            if (!TemTamanhoValido(cnpjNumeros)) return false;
            return !TemDigitosRepetidos(cnpjNumeros) && TemDigitosValidos(cnpjNumeros);
        }

        private static bool TemTamanhoValido(string valor)
        {
            return valor.Length == LengthCnpj;
        }

        private static bool TemDigitosRepetidos(string valor)
        {
            string[] invalidNumbers =
            {
                "00000000000000",
                "11111111111111",
                "22222222222222",
                "33333333333333",
                "44444444444444",
                "55555555555555",
                "66666666666666",
                "77777777777777",
                "88888888888888",
                "99999999999999"
            };
            return invalidNumbers.Contains(valor);
        }

        private static bool TemDigitosValidos(string valor)
        {
            var number = valor.Substring(0, LengthCnpj - 2);

            var digitoVerificador = new VerifyingDigit(number)
                .ComMultiplicadoresDeAte(2, 9)
                .Substituindo("0", 10, 11);
            var firstDigit = digitoVerificador.CalculaDigito();
            digitoVerificador.AddDigito(firstDigit);
            var secondDigit = digitoVerificador.CalculaDigito();

            return string.Concat(firstDigit, secondDigit) == valor.Substring(LengthCnpj - 2, 2);
        }
    }
}