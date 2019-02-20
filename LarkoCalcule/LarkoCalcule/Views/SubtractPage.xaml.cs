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
        private Jeu jeuSub;

        public SubtractPage()
        {
            InitializeComponent();
            jeuSub = new Jeu();
            InitPageSoustraction();
        }

        private void InitPageSoustraction()
        {
            jeuSub.GenererAleatoiresChiffres();
            while (jeuSub.Chiffre1 < jeuSub.Chiffre2 )
            {
                jeuSub.GenererAleatoiresChiffres();
            }
            txtChiffre1.Text = (jeuSub.Chiffre1).ToString();
            txtChiffre2.Text = (jeuSub.Chiffre2).ToString();
            jeuSub.VraiResultat = jeuSub.Chiffre1 - jeuSub.Chiffre2;
            jeuSub.GenererAleatoiresChiffres();
            jeuSub.Fauxresultat1 = jeuSub.Chiffre1 - jeuSub.Chiffre2;
            while (jeuSub.Fauxresultat1 == jeuSub.VraiResultat || jeuSub.Chiffre1 < jeuSub.Chiffre2 )
            {
                jeuSub.GenererAleatoiresChiffres();
                jeuSub.Fauxresultat1 = jeuSub.Chiffre1 - jeuSub.Chiffre2;
            }

            jeuSub.GenererAleatoiresChiffres();
            jeuSub.Fauxresultat2 = jeuSub.Chiffre1 - jeuSub.Chiffre2;
            while (jeuSub.Fauxresultat2 == jeuSub.VraiResultat || jeuSub.Fauxresultat2 == jeuSub.Fauxresultat1 || jeuSub.Chiffre1 < jeuSub.Chiffre2 )
            {
                jeuSub.GenererAleatoiresChiffres();
                jeuSub.Fauxresultat2 = jeuSub.Chiffre1 - jeuSub.Chiffre2;
            }

            jeuSub.GenererAleatoiresChiffres();
            jeuSub.Fauxresultat3 = jeuSub.Chiffre1 - jeuSub.Chiffre2;
            while (jeuSub.Fauxresultat3 == jeuSub.VraiResultat || jeuSub.Fauxresultat3 == jeuSub.Fauxresultat1 || jeuSub.Fauxresultat3 == jeuSub.Fauxresultat2 || jeuSub.Chiffre1 < jeuSub.Chiffre2 )
            {
                jeuSub.GenererAleatoiresChiffres();
                jeuSub.Fauxresultat3 = jeuSub.Chiffre1 - jeuSub.Chiffre2;
            }

            jeuSub.PositionnerLesResultatsAleatoirement();
            btnResult1.Text = jeuSub.Position1;
            btnResult2.Text = jeuSub.Position2;
            btnResult3.Text = jeuSub.Position3;
            btnResult4.Text = jeuSub.Position4;
        }

        private void btnAutreCalculClicked(object sender, EventArgs e)
        {
            InitPageSoustraction();
        }


        private void btnResult1Clicked(object sender, EventArgs e)
        {
            if ((jeuSub.VraiResultat).ToString() == btnResult1.Text)
            {
                this.Navigation.PushAsync(new BravoPage());
            }
            else if ((jeuSub.Fauxresultat1).ToString() == btnResult1.Text || (jeuSub.Fauxresultat2).ToString() == btnResult1.Text || (jeuSub.Fauxresultat3).ToString() == btnResult1.Text)
            {
                this.Navigation.PushAsync(new ErrorPage());
            }
        }
        private void btnResult2Clicked(object sender, EventArgs e)
        {
            if ((jeuSub.VraiResultat).ToString() == btnResult2.Text)
            {
                this.Navigation.PushAsync(new BravoPage());
            }
            else if ((jeuSub.Fauxresultat1).ToString() == btnResult2.Text || (jeuSub.Fauxresultat2).ToString() == btnResult2.Text || (jeuSub.Fauxresultat3).ToString() == btnResult2.Text)
            {
                this.Navigation.PushAsync(new ErrorPage());
            }
        }
        private void btnResult3Clicked(object sender, EventArgs e)
        {
            if ((jeuSub.VraiResultat).ToString() == btnResult3.Text)
            {
                this.Navigation.PushAsync(new BravoPage());
            }
            else if ((jeuSub.Fauxresultat1).ToString() == btnResult3.Text || (jeuSub.Fauxresultat2).ToString() == btnResult3.Text || (jeuSub.Fauxresultat3).ToString() == btnResult3.Text)
            {
                this.Navigation.PushAsync(new ErrorPage());
            }
        }
        private void btnResult4Clicked(object sender, EventArgs e)
        {
            if ((jeuSub.VraiResultat).ToString() == btnResult4.Text)
            {
                this.Navigation.PushAsync(new BravoPage());
            }
            else if ((jeuSub.Fauxresultat1).ToString() == btnResult4.Text || (jeuSub.Fauxresultat2).ToString() == btnResult4.Text || (jeuSub.Fauxresultat3).ToString() == btnResult4.Text)
            {
                this.Navigation.PushAsync(new ErrorPage());
            }
        }
    }
}