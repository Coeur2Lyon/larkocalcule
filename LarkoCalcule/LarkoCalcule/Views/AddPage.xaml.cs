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
			InitializeComponent();
            jeuAdd = new Jeu();
            InitAddPage();
        }
        private void InitAddPage()
        {
            jeuAdd.GenererAleatoiresChiffres();
            txtChiffre1.Text = (jeuAdd.Chiffre1).ToString();
            txtChiffre2.Text = (jeuAdd.Chiffre2).ToString();
            jeuAdd.VraiResultat = jeuAdd.Chiffre1 + jeuAdd.Chiffre2;

            jeuAdd.GenererAleatoiresChiffres();
            jeuAdd.Fauxresultat1 = jeuAdd.Chiffre1 + jeuAdd.Chiffre2;

            while (jeuAdd.Fauxresultat1 == jeuAdd.VraiResultat)
            {
                jeuAdd.GenererAleatoiresChiffres();
                jeuAdd.Fauxresultat1 = jeuAdd.Chiffre1 + jeuAdd.Chiffre2;
            }
            jeuAdd.GenererAleatoiresChiffres();
            jeuAdd.Fauxresultat2 = jeuAdd.Chiffre1 + jeuAdd.Chiffre2;
            while (jeuAdd.Fauxresultat2 == jeuAdd.VraiResultat || jeuAdd.Fauxresultat2 == jeuAdd.Fauxresultat1)
            {
                jeuAdd.GenererAleatoiresChiffres();
                jeuAdd.Fauxresultat2 = jeuAdd.Chiffre1 + jeuAdd.Chiffre2;
            }
            jeuAdd.GenererAleatoiresChiffres();
            jeuAdd.Fauxresultat3 = jeuAdd.Chiffre1 + jeuAdd.Chiffre2;
            while (jeuAdd.Fauxresultat3 == jeuAdd.VraiResultat || jeuAdd.Fauxresultat3 == jeuAdd.Fauxresultat1 || jeuAdd.Fauxresultat3 == jeuAdd.Fauxresultat2)
            {
                jeuAdd.GenererAleatoiresChiffres();
                jeuAdd.Fauxresultat3 = jeuAdd.Chiffre1 + jeuAdd.Chiffre2;
            }
            jeuAdd.PositionnerLesResultatsAleatoirement();
            btnResult1.Text = jeuAdd.Position1;
            btnResult2.Text = jeuAdd.Position2;
            btnResult3.Text = jeuAdd.Position3;
            btnResult4.Text = jeuAdd.Position4;
        }

        private void btnAutreCalculClicked(object sender, EventArgs e)
        {
            InitAddPage();
        }
        


        private void btnResult1Clicked(object sender, EventArgs e)
        {
            if ((jeuAdd.VraiResultat).ToString() == btnResult1.Text)
            {
                this.Navigation.PushAsync(new BravoPage());
            }
            else if ((jeuAdd.Fauxresultat1).ToString() == btnResult1.Text || (jeuAdd.Fauxresultat2).ToString() == btnResult1.Text || (jeuAdd.Fauxresultat3).ToString() == btnResult1.Text)
            {
                this.Navigation.PushAsync(new ErrorPage());
            }
        }
        private void btnResult2Clicked(object sender, EventArgs e)
        {
            if ((jeuAdd.VraiResultat).ToString() == btnResult2.Text)
            {
                this.Navigation.PushAsync(new BravoPage());
            }
            else if ((jeuAdd.Fauxresultat1).ToString() == btnResult2.Text || (jeuAdd.Fauxresultat2).ToString() == btnResult2.Text || (jeuAdd.Fauxresultat3).ToString() == btnResult2.Text)
            {
                this.Navigation.PushAsync(new ErrorPage());
            }
        }
        private void btnResult3Clicked(object sender, EventArgs e)
        {
            if ((jeuAdd.VraiResultat).ToString() == btnResult3.Text)
            {
                this.Navigation.PushAsync(new BravoPage());
            }
            else if ((jeuAdd.Fauxresultat1).ToString() == btnResult3.Text || (jeuAdd.Fauxresultat2).ToString() == btnResult3.Text || (jeuAdd.Fauxresultat3).ToString() == btnResult3.Text)
            {
                this.Navigation.PushAsync(new ErrorPage());
            }
        }
        private void btnResult4Clicked(object sender, EventArgs e)
        {
            if ((jeuAdd.VraiResultat).ToString() == btnResult4.Text)
            {
                this.Navigation.PushAsync(new BravoPage());
            }
            else if ((jeuAdd.Fauxresultat1).ToString() == btnResult4.Text || (jeuAdd.Fauxresultat2).ToString() == btnResult4.Text || (jeuAdd.Fauxresultat3).ToString() == btnResult4.Text)
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