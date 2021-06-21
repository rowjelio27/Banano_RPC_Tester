using System;
using System.Linq;

namespace DotNano.Shared.DataTypes
{
    public class PublicAddress
    {
        public const string Default = "ban_1111111111111111111111111111111111111111111111111117353trpda";
        const string Prefix = "ban_";
        public string Address { get; }
        public PublicAddress(string address)
        {
            Validate(address);

            Address = address;
        }

        public static bool IsPublicAddress(string @string)
        {
            //**NOTE**: this check MAY NOT WORK for all banano addresses. I'm thinking the vanity addresses. may need to change this line to
            // return @string.Length == 64
            //that is, DONT CHECK for the other stuff.
            return @string.Length == 64 && @string.StartsWith(Prefix) && @string.Substring(Prefix.Length).All(c => (c >= '0' && c <= '9') || (c >= 'a' && c <= 'z'));
        }

        private void Validate(string address)
        {
            if (!IsPublicAddress(address))
              throw new ArgumentException("Incorrect address provided");
        }

        public override string ToString()
        {
            return Address;
        }

        public static implicit operator PublicAddress(string address)
        {
            return new PublicAddress(address);
        }
        
        public override int GetHashCode()
        {
            return HashCode.Combine(Address);
        }

        public override bool Equals(object obj)
        {
            return obj is PublicAddress address &&
                   Address == address.Address;
        }
    }
}
