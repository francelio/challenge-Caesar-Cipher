using System;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.Text;
using System.IO;
using System.Net.Http.Headers;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		private const string Token = "55a47d91e63fd1b57152e42208028e249926e164";
		private const string GetRequestUri = "https://api.codenation.dev/v1/challenge/dev-ps/generate-data?token=";
		private const string PostRequestUri = "https://api.codenation.dev/v1/challenge/dev-ps/submit-solution?token=";
		private JsonData objeto;
		public Form1()
		{
			InitializeComponent();
		}


		private void button1_Click(object sender, EventArgs e)
		{
			GetJsonData();
			
		}

		private async void GetJsonData()
		{
			using (var client = new HttpClient())
			{
				using (var response = await client.GetAsync(string.Concat(GetRequestUri, Token)))
				{
					if (response.IsSuccessStatusCode)
					{
						var CesarJsonString = await response.Content.ReadAsStringAsync();

						objeto = JsonConvert.DeserializeObject<JsonData>(CesarJsonString); ;
						
						//alterar valores resposta
						objeto.Decifrado = CesarCriptografy.Decipher(objeto.Cifrado, objeto.NumeroCasas);
						objeto.ResumoCriptografico = SHA1.Calculate(objeto.Decifrado);

						txtDadosCasas.Text = objeto.NumeroCasas.ToString();
						txtDadosCifrado.Text = objeto.Cifrado;
						txtDadosToken.Text = objeto.Token;
						txtDadosDecifrado.Text = objeto.Decifrado;
						txtDadosResumo.Text = objeto.ResumoCriptografico;



						Arquivo.SaveJsonData(objeto);
						PostJsonData(Arquivo.GetJsonStream());
					}
					else
					{
						MessageBox.Show("Não foi possível obter o os dados : " + response.StatusCode);
					}
				}
			}
		}

		private async void PostJsonData(Stream arquivo)
		{

			using (var client = new HttpClient())
			{
				using (HttpContent fileStreamContent = new StreamContent(arquivo))
				{

					using (var formData = new MultipartFormDataContent())
					{
						formData.Add(fileStreamContent, "answer", "answer.json");
						using (var response = await client.PostAsync(string.Concat(PostRequestUri, Token), formData))
						{
							if (response.IsSuccessStatusCode)
							{
								MessageBox.Show("Arquivo enviado com sucess");

							}
							else
							{
								MessageBox.Show("Não foi possívelenviar o arquivo, error: " + response.StatusCode);
							}
						}
					}
				}
			}
		}
	}
}

