using System;
using System.Text;

namespace Day4
{
    class Duration
    {
        public int Seconds  {get; set;}
        public int Minutes  {get; set;}
        public int Hours    {get; set;}

        public Duration(int Seconds, int Minutes, int Hours)
        {
            this.Seconds = Seconds;
            this.Minutes = Minutes;
            this.Hours   = Hours;
        }
        public Duration(int totalSeconds)
        {
            Hours    = totalSeconds/3600;
            Minutes = (totalSeconds % 3600) /60;
            Seconds = totalSeconds % 60;
        }
        public override string ToString()
        {
            StringBuilder show = new StringBuilder();

            if(Hours>0) show.Append($"Hours: {Hours}");
            show.Append($"Minutes: {Minutes}, Seconds: {Seconds}");
            return show.ToString();
        }
    }
}