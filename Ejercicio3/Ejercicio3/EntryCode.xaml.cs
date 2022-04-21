using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio3
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EntryCode : ContentPage
	{
		public EntryCode ()
		{
			InitializeComponent ();
            StackLayout stack = new StackLayout();
            var entry = new Entry { Text = "This is a read-only Entry" };
            var labelmark = new Label
            {
                Text = "by Atsumi Amaya",
                FontSize = Device.GetNamedSize(NamedSize.Micro, typeof(Label)),
                VerticalOptions = LayoutOptions.EndAndExpand,
                HorizontalOptions = LayoutOptions.Center
            };
            stack.Children.Add(entry);
            stack.Children.Add(labelmark);
            Content = stack;
		}
	}
}