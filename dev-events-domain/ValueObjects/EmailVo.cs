﻿using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Poc.Domain.ValueObjects
{
    public class EmailVo : ValueObject
    {
        public string Email { get; set; }

        public EmailVo(string email)
        {
            Email = email;
        }

        public override bool IsValid()
        {
            if (string.IsNullOrWhiteSpace(Email)) return false;

            string email = Email;

            try
            {
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper, RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    var domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }

            catch (RegexMatchTimeoutException)
            {
                return false; 
            }

            catch(ArgumentException)
            {
                return false; 
            }

            try
            {
                return Regex.IsMatch(email,
                   @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                   @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                   RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }

        }

        public string Obfuscate()
        {
            if (!IsValid()) return "";

            return Regex.Replace(Email, @"(?<=[\w]{1})[\w-\._\+%\\]*(?=[\w]{1}@)|(?=\@)", m => new string('*', m.Length), RegexOptions.Compiled);
        }
    }
}