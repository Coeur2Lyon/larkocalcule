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
    public partial class MultiplyPage : ContentPage
    {
        private Jeu jeuMultiply;

        public MultiplyPage()
        {
            InitializeComponent();
            jeuMultiply = new Jeu();
            InitPageMultiplication();
        }

        private void InitPageMultiplication()
        {
            jeuMultiply.GenererAleatoiresChiffres();
            txtChiffre1.Text = (jeuMultiply.Chiffre1).ToString();
            txtChiffre2.Text = (jeuMultiply.Chiffre2).ToString();
            jeuMultiply.VraiResultat = jeuMultiply.Chiffre1 * jeuMultiply.Chiffre2;

            jeuMultiply.GenererAleatoiresChiffres();
            jeuMultiply.Fauxresultat1 = jeuMultiply.Chiffre1 * jeuMultiply.Chiffre2;

            while (jeuMultiply.Fauxresultat1 == jeuMultiply.VraiResultat)
            {
                jeuMultiply.GenererAleatoiresChiffres();
                jeuMultiply.Fauxresultat1 = jeuMultiply.Chiffre1 * jeuMultiply.Chiffre2;
            }
            jeuMultiply.GenererAleatoiresChiffres();
            jeuMultiply.Fauxresultat2 = jeuMultiply.Chiffre1 * jeuMultiply.Chiffre2;
            while (jeuMultiply.Fauxresultat2 == jeuMultiply.VraiResultat || jeuMultiply.Fauxresultat2 == jeuMultiply.Fauxresultat1)
            {
                jeuMultiply.GenererAleatoiresChiffres();
                jeuMultiply.Fauxresultat2 = jeuMultiply.Chiffre1 * jeuMultiply.Chiffre2;
            }
            jeuMultiply.GenererAleatoiresChiffres();
            jeuMultiply.Fauxresultat3 = jeuMultiply.Chiffre1 * jeuMultiply.Chiffre2;
            while (jeuMultiply.Fauxresultat3 == jeuMultiply.VraiResultat || jeuMultiply.Fauxresultat3 == jeuMultiply.Fauxresultat1 || jeuMultiply.Fauxresultat3 == jeuMultiply.Fauxresultat2)
            {
                jeuMultiply.GenererAleatoiresChiffres();
                jeuMultiply.Fauxresultat3 = jeuMultiply.Chiffre1 * jeuMultiply.Chiffre2;
            }
            jeuMultiply.PositionnerLesResultatsAleatoirement();
            btnResult1.Text = jeuMultiply.Position1;
            btnResult2.Text = jeuMultiply.Position2;
            btnResult3.Text = jeuMultiply.Position3;
            btnResult4.Text = jeuMultiply.Position4;
        }

        private void btnAutreCalculClicked(object sender, EventArgs e)
        {
            InitPageMultiplication();
        }


        private void btnResult1Clicked(object sender, EventArgs e)
        {
            if ((jeuMultiply.VraiResultat).ToString() == btnResult1.Text)
            {
                this.Navigation.PushAsync(new BravoPage());
            }
            else if ((jeuMultiply.Fauxresultat1).ToString() == btnResult1.Text || (jeuMultiply.Fauxresultat2).ToString() == btnResult1.Text || (jeuMultiply.Fauxresultat3).ToString() == btnResult1.Text)
            {
                this.Navigation.PushAsync(new ErrorPage());
            }
        }
        private void btnResult2Clicked(object sender, EventArgs e)
        {
            if ((jeuMultiply.VraiResultat).ToString() == btnResult2.Text)
            {
                this.Navigation.PushAsync(new BravoPage());
            }
            else if ((jeuMultiply.Fauxresultat1).ToString() == btnResult2.Text || (jeuMultiply.Fauxresultat2).ToString() == btnResult2.Text || (jeuMultiply.Fauxresultat3).ToString() == btnResult2.Text)
            {
                this.Navigation.PushAsync(new ErrorPage());
            }
        }
        private void btnResult3Clicked(object sender, EventArgs e)
        {
            if ((jeuMultiply.VraiResultat).ToString() == btnResult3.Text)
            {
                this.Navigation.PushAsync(new BravoPage());
            }
            else if ((jeuMultiply.Fauxresultat1).ToString() == btnResult3.Text || (jeuMultiply.Fauxresultat2).ToString() == btnResult3.Text || (jeuMultiply.Fauxresultat3).ToString() == btnResult3.Text)
            {
                this.Navigation.PushAsync(new ErrorPage());
            }
        }
        private void btnResult4Clicked(object sender, EventArgs e)
        {
            if ((jeuMultiply.VraiResultat).ToString() == btnResult4.Text)
            {
                this.Navigation.PushAsync(new BravoPage());
            }
            else if ((jeuMultiply.Fauxresultat1).ToString() == btnResult4.Text || (jeuMultiply.Fauxresultat2).ToString() == btnResult4.Text || (jeuMultiply.Fauxresultat3).ToString() == btnResult4.Text)
            {
                this.Navigation.PushAsync(new ErrorPage());
            }
        }
    }
}