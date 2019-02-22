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
            InitPageDivision();
        }

        private void InitPageDivision()
        {
            jeuDivide.GenererAleatoiresChiffres();
            while (jeuDivide.Chiffre1 < jeuDivide.Chiffre2 || jeuDivide.Chiffre1 % jeuDivide.Chiffre2 != 0)
            {
                jeuDivide.GenererAleatoiresChiffres();
            }
            txtChiffre1.Text = (jeuDivide.Chiffre1).ToString();
            txtChiffre2.Text = (jeuDivide.Chiffre2).ToString();
            jeuDivide.VraiResultat = jeuDivide.Chiffre1 / jeuDivide.Chiffre2;
            jeuDivide.GenererAleatoiresChiffres();
            jeuDivide.Fauxresultat1 = jeuDivide.Chiffre1 / jeuDivide.Chiffre2;
            while (jeuDivide.Fauxresultat1 == jeuDivide.VraiResultat || jeuDivide.Chiffre1 < jeuDivide.Chiffre2 || jeuDivide.Chiffre1 % jeuDivide.Chiffre2 != 0)
            {
                jeuDivide.GenererAleatoiresChiffres();
                jeuDivide.Fauxresultat1 = jeuDivide.Chiffre1 / jeuDivide.Chiffre2;
            }
            
            jeuDivide.GenererAleatoiresChiffres();
            jeuDivide.Fauxresultat2 = jeuDivide.Chiffre1 / jeuDivide.Chiffre2;
            while (jeuDivide.Fauxresultat2 == jeuDivide.VraiResultat || jeuDivide.Fauxresultat2 == jeuDivide.Fauxresultat1 || jeuDivide.Chiffre1 < jeuDivide.Chiffre2 || jeuDivide.Chiffre1 % jeuDivide.Chiffre2 != 0)
            {
                jeuDivide.GenererAleatoiresChiffres();
                jeuDivide.Fauxresultat2 = jeuDivide.Chiffre1 / jeuDivide.Chiffre2;
            }
            
            jeuDivide.GenererAleatoiresChiffres();
            jeuDivide.Fauxresultat3 = jeuDivide.Chiffre1 / jeuDivide.Chiffre2;
            while (jeuDivide.Fauxresultat3 == jeuDivide.VraiResultat || jeuDivide.Fauxresultat3 == jeuDivide.Fauxresultat1 || jeuDivide.Fauxresultat3 == jeuDivide.Fauxresultat2 || jeuDivide.Chiffre1 < jeuDivide.Chiffre2 || jeuDivide.Chiffre1 % jeuDivide.Chiffre2 != 0)
            {
                jeuDivide.GenererAleatoiresChiffres();
                jeuDivide.Fauxresultat3 = jeuDivide.Chiffre1 / jeuDivide.Chiffre2;
            }
           
            jeuDivide.PositionnerLesResultatsAleatoirement();
            btnResult1.Text = jeuDivide.Position1;
            btnResult2.Text = jeuDivide.Position2;
            btnResult3.Text = jeuDivide.Position3;
            btnResult4.Text = jeuDivide.Position4;
        }

        private void btnAutreCalculClicked(object sender, EventArgs e)
        {
            InitPageDivision();
        }


        private void btnResult1Clicked(object sender, EventArgs e)
        {
            if ((jeuDivide.VraiResultat).ToString() == btnResult1.Text)
            {
                this.Navigation.PushAsync(new BravoPage());
            }
            else if ((jeuDivide.Fauxresultat1).ToString() == btnResult1.Text || (jeuDivide.Fauxresultat2).ToString() == btnResult1.Text || (jeuDivide.Fauxresultat3).ToString() == btnResult1.Text)
            {
                this.Navigation.PushAsync(new ErrorPage());
            }
        }
        private void btnResult2Clicked(object sender, EventArgs e)
        {
            if ((jeuDivide.VraiResultat).ToString() == btnResult2.Text)
            {
                this.Navigation.PushAsync(new BravoPage());
            }
            else if ((jeuDivide.Fauxresultat1).ToString() == btnResult2.Text || (jeuDivide.Fauxresultat2).ToString() == btnResult2.Text || (jeuDivide.Fauxresultat3).ToString() == btnResult2.Text)
            {
                this.Navigation.PushAsync(new ErrorPage());
            }
        }
        private void btnResult3Clicked(object sender, EventArgs e)
        {
            if ((jeuDivide.VraiResultat).ToString() == btnResult3.Text)
            {
                this.Navigation.PushAsync(new BravoPage());
            }
            else if ((jeuDivide.Fauxresultat1).ToString() == btnResult3.Text || (jeuDivide.Fauxresultat2).ToString() == btnResult3.Text || (jeuDivide.Fauxresultat3).ToString() == btnResult3.Text)
            {
                this.Navigation.PushAsync(new ErrorPage());
            }
        }
        private void btnResult4Clicked(object sender, EventArgs e)
        {
            if ((jeuDivide.VraiResultat).ToString() == btnResult4.Text)
            {
                this.Navigation.PushAsync(new BravoPage());
            }
            else if ((jeuDivide.Fauxresultat1).ToString() == btnResult4.Text || (jeuDivide.Fauxresultat2).ToString() == btnResult4.Text || (jeuDivide.Fauxresultat3).ToString() == btnResult4.Text)
            {
                this.Navigation.PushAsync(new ErrorPage());
            }
        }
        private void CalculButtonClicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new CalculPage());
        }
    }
}