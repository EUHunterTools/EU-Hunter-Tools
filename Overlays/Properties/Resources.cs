using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace WindowsFormsApp1.Properties
{
    [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [DebuggerNonUserCode]
    [CompilerGenerated]
    public class Resources
    {
        private static ResourceManager resourceMan;
        private static CultureInfo resourceCulture;

        internal Resources()
        {
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public static ResourceManager ResourceManager
        {
            get
            {
                if (WindowsFormsApp1.Properties.Resources.resourceMan == null)
                    WindowsFormsApp1.Properties.Resources.resourceMan = new ResourceManager("WindowsFormsApp1.Properties.Resources", typeof(WindowsFormsApp1.Properties.Resources).Assembly);
                return WindowsFormsApp1.Properties.Resources.resourceMan;
            }
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public static CultureInfo Culture
        {
            get => WindowsFormsApp1.Properties.Resources.resourceCulture;
            set => WindowsFormsApp1.Properties.Resources.resourceCulture = value;
        }

        public static string EUmats => WindowsFormsApp1.Properties.Resources.ResourceManager.GetString(nameof(EUmats), WindowsFormsApp1.Properties.Resources.resourceCulture);

        public static Bitmap icono => (Bitmap)WindowsFormsApp1.Properties.Resources.ResourceManager.GetObject(nameof(icono), WindowsFormsApp1.Properties.Resources.resourceCulture);

        public static Bitmap moveIcon => (Bitmap)WindowsFormsApp1.Properties.Resources.ResourceManager.GetObject(nameof(moveIcon), WindowsFormsApp1.Properties.Resources.resourceCulture);
    }
}
