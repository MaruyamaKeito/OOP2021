using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleUnitConverter
{
    public class DistanceUnit
    {
        public string Name { get; set; }
        public double Coefficent { get; set; }
        public override string ToString()
        {
            return this.Name;
        }
    }
    //メートル単位を表すクラス
    public class MetricUnit : DistanceUnit
    {
        private static List<MetricUnit> units = new List<MetricUnit>
        {
            new MetricUnit{Name = "mm",Coefficent = 1},
            new MetricUnit{Name = "cm",Coefficent = 10},
            new MetricUnit{Name = "m",Coefficent = 10 * 100,},
            new MetricUnit{Name = "km",Coefficent = 10 * 100 * 1000,},
        };
        public static ICollection<MetricUnit> Units { get { return units; } }

        /// <summary>
        /// ヤード単位からメートル単位に変換します
        /// </summary>
        /// <param name="unit">インチ単位</param>
        /// <param name="value"></param>
        /// <returns></returns>
        public double FromImperialUnit(ImperialUnit unit,double value)
        {
            return (value * unit.Coefficent) * 25.4 / this.Coefficent;
        }
    }
    //ヤード単位を表すクラス
    public class ImperialUnit : DistanceUnit
    {
        private static List<ImperialUnit> units = new List<ImperialUnit>
        {
            new ImperialUnit{Name = "mm",Coefficent = 1},
            new ImperialUnit{Name = "cm",Coefficent = 10},
            new ImperialUnit { Name = "m", Coefficent = 10 * 100, },
            new ImperialUnit { Name = "km", Coefficent = 10 * 100 * 1000, },
        };
        public static ICollection<ImperialUnit> Units { get { return units; } }

        /// <summary>
        /// メートル単位からヤード単位に変換します
        /// </summary>
        /// <param name="unit">メートル単位</param>
        /// <param name="value">係数</param>
        /// <returns></returns>
        public double FromMetricUnit(MetricUnit unit, double value)
        {
            return (value * unit.Coefficent) / 25.4 / this.Coefficent;
        }
    }
}
