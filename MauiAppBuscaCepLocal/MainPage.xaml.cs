using MauiAppBuscaCepLocal.Model;
using MauiAppBuscaCepLocal.Services;

namespace MauiAppBuscaCepLocal
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
           
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                Endereco? dados_endereco =
                    await DataServiceCep.GetEnderecoByCep(txt_cep.Text);

                BindingContext = dados_endereco;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }

        }
    }

}
