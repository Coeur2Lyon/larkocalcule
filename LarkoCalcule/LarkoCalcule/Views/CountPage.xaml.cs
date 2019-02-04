using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LarkoCalcule.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CountPage : ContentPage
	{
		public CountPage ()
		{
			InitializeComponent ();
		}
        private void Count_Button_Clicked(object sender, EventArgs e)
        {
            compteur.Text = (int.Parse(compteur.Text) + 1).ToString();
        }
    }
}