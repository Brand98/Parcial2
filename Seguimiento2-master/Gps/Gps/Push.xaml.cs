using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Gps
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Push : ContentPage
	{
		public Push ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            var client = new RestClient("https://appcenter.ms/api/v0.1/apps/brahyanbedoya50-gmail.com/Noti/push/notifications");
            var request = new RestRequest(Method.POST);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("x-api-token", "0c9261d1b503f893e0abe4077a1a54d2ffa5a549");
            request.AddParameter("undefined", "{\r\n  \"notification_content\": {\r\n    \"name\": \""+Nombre.Text.ToString()+"\",\r\n    \"title\": \""+titulo.Text.ToString()+"\",\r\n    \"body\": \""+mensaje.Text.ToString()+"\",\r\n    \"custom_data\": {\"key1\": \"val1\", \"key2\": \"val2\"}\r\n  },\r\n  \"notification_target\": null\r\n}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
        }
    }
}