using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
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

            ImageSource imageSource = ImageSource.FromResource(Source, typeof(ImageFromResource).GetTypeInfo().Assembly);

            return imageSource;
        }
    }
}
