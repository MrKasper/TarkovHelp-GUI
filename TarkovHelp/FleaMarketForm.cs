using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using ConvertApiDotNet;

namespace TarkovHelp
{
    public partial class FleaMarketForm : Form
    {
        public static string FilePath { get; set; } = @"img-flea\";
        public static string urlFile { get; set; }
        public static WebClient client = new WebClient();
        public FleaMarketForm()
        {
            InitializeComponent();
        }

        private void FleaMarketForm_Load(object sender, EventArgs e)
        {

        }

        private async void buttonSearch_Click(object sender, EventArgs e)
        {
            string item = textBoxSearch.Text;
            Dictionary<string, string> data = new Dictionary<string, string>();
            data.Add("query", "{items(lang:ru,name: " + "\"" + $"{item}" + "\")" + "{name basePrice avg24hPrice iconLink}}");
            using (var httpClient = new HttpClient())
            {

                //Http response message
                var httpResponse = await httpClient.PostAsJsonAsync("https://api.tarkov.dev/graphql", data);

                //Response content
                var responseContent = await httpResponse.Content.ReadAsStringAsync();

                //Print response
                string searchText = "name";
                var result = Regex.Matches(responseContent, @"\b" + searchText + @"\b", RegexOptions.IgnoreCase).Count;
                if (result > 1)
                {
                    MessageBox.Show("Найдено более 1 предмета!\nУкажите название предмета точнее");
                    return;
                }
                else
                {
                    int foundName = responseContent.IndexOf(":\"");
                    string itemName = responseContent.Substring(foundName + 1);
                    NameItem.Text = itemName.Substring(0, itemName.IndexOf(','));

                    int foundBasePrice = responseContent.IndexOf("\"basePrice\":");
                    string basePrice = responseContent.Substring(foundBasePrice + 1);
                    int newBasePrice = basePrice.IndexOf(':');
                    string s_BP = basePrice.Substring(newBasePrice + 1);
                    BasePrice.Text = s_BP.Substring(0, s_BP.IndexOf(','));

                    int foundAvgPrice = responseContent.IndexOf("\"avg24hPrice\":");
                    string avgPrice = responseContent.Substring(foundAvgPrice + 1);
                    int newAvgPrice = avgPrice.IndexOf(':');
                    string avg24hPrice = avgPrice.Substring(newAvgPrice + 1);
                    AvgPrice.Text = avg24hPrice.Substring(0, avg24hPrice.IndexOf(','));

                    int foundIcon = responseContent.IndexOf("\"iconLink\":");
                    string iconLink = responseContent.Substring(foundIcon + 1);
                    int newFoundIcon = iconLink.IndexOf(':');
                    string icon = iconLink.Substring(newFoundIcon + 2);
                    int ic_n = icon.Length - 5;
                    //LogoIcon.LoadAsync(icon.Remove(ic_n));

                    urlFile = icon.Remove(ic_n);
                    client.DownloadFile(icon.Remove(ic_n), FilePath + "pic.png");
                    Convert(FilePath, urlFile);
                    Thread.Sleep(200);
                }
            }
        }
        public async void Convert(string path, string url)
        {
            var convertApi = new ConvertApi("AKnHPv6CHsCbdDmq");
            var convert = await convertApi.ConvertAsync("webp", "png",
                new ConvertApiFileParam("File", FilePath + "pic.png")
            );
            await convert.SaveFilesAsync(path);
            LoadImage();
        }
        public void LoadImage()
        {
            var ms = new MemoryStream();
            using (FileStream stream = File.OpenRead(FilePath + "pic.png"))
            {
                stream.CopyTo(ms);
                LogoIcon.Image = Bitmap.FromStream(ms);
            }
        }
    }
}
