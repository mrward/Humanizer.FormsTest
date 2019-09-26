using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Humanizer.FormsTest
{
	// Learn more about making custom code visible in the Xamarin.Forms previewer
	// by visiting https://aka.ms/xamarinforms-previewer
	[DesignTimeVisible (false)]
	public partial class MainPage : ContentPage
	{
		public MainPage ()
		{
			InitializeComponent ();

			string message = string.Format (
				"HumanizerText='{0}'\n CurrentUICulture={1}",
				DateTime.UtcNow.AddHours (-30).Humanize (), // Should be translated but it is not.
				CultureInfo.CurrentUICulture);
			messageLabel.Text = message;
		}
	}
}
