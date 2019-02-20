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
    public partial class SubtractPage : ContentPage
    {
        private Jeu jeuSubtract;


        public SubtractPage()
        {
            InitializeComponent();
            jeuSubtract = new Jeu(); 
        }
        private void btnAutreCalculClicked(object sender, EventArgs e)
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