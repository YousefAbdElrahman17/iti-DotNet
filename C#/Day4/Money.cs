using System;

namespace Day4
{
    class Money
    {
        public double Amount {get; set;}
        public string Currency {get; set;}

        public Money(double Amount, string Currency)
        {
            this.Amount = Amount;
            this.Amount = Amount;
        }
        public override string ToString()
        {
            return ($"{Amount} {Currency}");
        }
        public static Money operator +(Money m1, Money m2)
        {
            return new Money(m1.Amount + m2.Amount, m1.Currency);
        }
        public static Money operator -(Money m1, Money m2)
        {
            return new Money(m1.Amount - m2.Amount, m1.Currency);
        }
        public static Money operator ++(Money m)
        {
            return new Money(m.Amount +1, m.Currency);
        }
        public static bool operator ==(Money m1, Money m2)
        {
            if(ReferenceEquals(m1,m2)) return true;
            if(m1 is null || m2 is null) return false;
            return m1.Amount == m2.Amount;
        }
        public static bool operator !=(Money m1, Money m2)
        {
            return m1 == m2;
        }
        public override int GetHashCode()
        {
            return Amount.GetHashCode();
        }
    }

}