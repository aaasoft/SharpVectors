using System.Windows;

using SharpVectors.Dom.Svg;
using System.Windows.Media;

namespace SharpVectors.Renderers.Wpf
{
    public abstract class WpfEmbeddedImageVisitor : DependencyObject
    {
        protected WpfEmbeddedImageVisitor()
        {   
        }

        public abstract ImageSource Visit(SvgImageElement element, 
            WpfDrawingContext context);
    }
}
