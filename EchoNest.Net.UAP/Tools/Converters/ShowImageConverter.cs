using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;
using EchoNest.Net.Core.Entities.ArtistProfile;

namespace EchoNest.Net.UAP.Tools.Converters
{
    public class ShowImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var images = value as Image[];
            if (images == null || images.Length <= 0)
            {
                return null;
            }
            return images.Last().Url;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
