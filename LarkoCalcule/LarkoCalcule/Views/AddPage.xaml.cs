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
	public partial class AddPage : ContentPage
	{
        private Jeu jeuAdd;
        
        public AddPage ()
		{
			InitializeComponent ();
            jeuAdd = new Jeu();
        }
        private void ValidButtonClicked(object sender, EventArgs e)
        {            
            txtChiffre1.Text = (jeuAdd.Chiffre1).ToString();
        }
        
            private void btnAutreCalculClicked(object sender, EventArgs e)
        {
            ;
        }
        private void CancelButtonClicked(object sender, EventArgs e)
        {
            ;
        }
        private void btnResult1Clicked(object sender, EventArgs e)
        {
            ;
        }
        private void btnResult2Clicked(object sender, EventArgs e)
        {
            ;
        }
        private void btnResult3Clicked(object sender, EventArgs e)
        {
            ;
        }
        private void btnResult4Clicked(object sender, EventArgs e)
        {
            ;
        }
    }
}