using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Kata04
{
    public class TemperatureData
    {
        private const int Offset = 1000;
        public int Day
        {
            get;
            set;
        }

        public decimal MaxTemperature
        {
            get;
            set;
        }

        public decimal MinTemperature
        {
            get;
            set;
        }

        /// <summary>
        /// gets the difference between max and min. Ill just offest it by a big number
        /// </summary>
        public decimal SpreadTemperature
        {

            get
            {
                if (MaxTemperature < MinTemperature)
                {
                    throw new InvalidDataException("MaxTemperature can not be less than MinTemperature");
                }
                return MaxTemperature + Offset - (MinTemperature + Offset);
            }
        }

        public class TemperatureStorage : List<TemperatureData>
        {
            public int? GetBiggestSpread()
            {
                decimal spreadTemperature = this.Max(x => x.SpreadTemperature);
                TemperatureData first = this.FirstOrDefault(y => y.SpreadTemperature == spreadTemperature);
                return first == null ? null : (int?)first.Day;
            }

        }
    }
}
