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
        private void ValidButtonClicked(object sender, EventArgs e)
        {
            // Tester l'égalité
            if ((jeuMultiply.VraiResultat).ToString() == txtResultat.Text)
            {
                this.Navigation.PushAsync(new BravoPage());
            }
            else if((jeuMultiply.Fauxresultat1).ToString() == txtResultat.Text|| (jeuMultiply.Fauxresultat2).ToString() == txtResultat.Text|| (jeuMultiply.Fauxresultat3).ToString() == txtResultat.Text)
            {
                this.Navigation.PushAsync(new BravoPage());
            }
        }
        private void CancelButtonClicked(object sender, EventArgs e)
        {
            txtResultat.Text="??";
        }

        private void btnResult1Clicked(object sender, EventArgs e)
        {
            txtResultat.Text = btnResult1.Text;
        }
        private void btnResult2Clicked(object sender, EventArgs e)
        {
            txtResultat.Text = btnResult2.Text;
        }
        private void btnResult3Clicked(object sender, EventArgs e)
        {
            txtResultat.Text = btnResult3.Text;
        }
        private void btnResult4Clicked(object sender, EventArgs e)
        {
            txtResultat.Text = btnResult3.Text;
        }
    }
}