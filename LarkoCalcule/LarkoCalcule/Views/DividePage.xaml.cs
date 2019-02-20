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
    public partial class DividePage : ContentPage
    {
        private Jeu jeuDivide;

        public DividePage()
        {
            InitializeComponent();
            jeuDivide = new Jeu();

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