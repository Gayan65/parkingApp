using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp
{
    internal class Parking
    {
        public Parking(TimeOnly startTime, TimeOnly endTime)
        {
            StartTime = startTime;
            EndTime = endTime;
        }

        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }

        public double FeeCal()
        {
            TimeSpan timeSpan;
            timeSpan = EndTime - StartTime;
            double timeSpanRounded = timeSpan.TotalSeconds;
            int finalHours = (int)Math.Ceiling(timeSpanRounded/(60*60));
            double fee;
            if (finalHours <= 2)
                fee = finalHours * 2;
            else if(finalHours > 2 && finalHours <= 5)
                fee = finalHours * 1.75;
            else
                fee = finalHours * 1.5;

            return fee;
        }
    }
}
