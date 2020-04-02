using System;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Module5TP.Utils
{
    [ContentProperty(nameof(Source))]
    public class ImageFromResource : IMarkupExtension
    {
        public string Source { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Source == null)
            {
                return null;
            }

            var imageSource = ImageSource.FromResource(Source, typeof(ImageFromResource).GetTypeInfo().Assembly);

            return imageSource;
        }
    }
}
