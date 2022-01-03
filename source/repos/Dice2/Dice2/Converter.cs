using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.IO;
using static Dice2.VM;

namespace Dice2
{
    public class ImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch ((DieImageCodes)value)
            {
                case DieImageCodes.ONE:
                    return Path.Combine("DImage", "Die1.bmp");
                case DieImageCodes.TWO:
                    return Path.Combine("DImage", "Die2.bmp");
                case DieImageCodes.THREE:
                    return Path.Combine("DImage", "Die3.bmp");
                case DieImageCodes.FOUR:
                    return Path.Combine("DImage", "Die4.bmp");
                case DieImageCodes.FIVE:
                    return Path.Combine("DImage", "Die5.bmp");
                case DieImageCodes.SIX:
                    return Path.Combine("DImage", "Die6.bmp");
                case DieImageCodes.TWENTY_SIDE:
                    return Path.Combine("DImage", "20Dice.png");
                default:
                    return String.Empty;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
