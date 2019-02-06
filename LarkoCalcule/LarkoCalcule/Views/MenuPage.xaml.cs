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
	public partial class MenuPage : ContentPage
	{
		public MenuPage ()
		{
			InitializeComponent ();
		}
        private void MultiplyButtonClicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new MultiplyPage());
        }
        private void DivideButtonClicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new DividePage());
        }
        private void AddButtonClicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new AddPage());
        }
        private void SubtractButtonClicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new SubtractPage());
        }
        private void CalculButtonClicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new CalculPage());
        }

    }
}