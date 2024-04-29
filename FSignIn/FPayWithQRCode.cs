using Hotel_Management.Payment;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management
{
    public partial class FPayWithQRCode : Form
    {
        public FPayWithQRCode()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FPayWithQRCode_Load(object sender, EventArgs e)
        {
            using (WebClient client = new WebClient())
            {
                var htmlData = client.DownloadData("https://api.vietqr.io/v2/banks");
                var bankRawJson = Encoding.UTF8.GetString(htmlData);
                var listBankData = JsonConvert.DeserializeObject<Bank>(bankRawJson);

                cbbBanks.DataSource = listBankData!.data;
                cbbBanks.DisplayMember = "shortName";
                cbbBanks.ValueMember = "bin";
                cbbTemplate.SelectedIndex = 0;
            }
        }

        private void btnCreateQRCode_Click(object sender, EventArgs e)
        {
            try
            {
                var apiRequest = new ApiRequest();
                apiRequest.acqId = Convert.ToInt32(cbbBanks!.SelectedValue!.ToString());
                apiRequest.accountNo = long.Parse(txtSTK.Text);
                apiRequest.accountName = txtAccountName.Text;
                apiRequest.amount = Convert.ToInt32(txtInvoice.Text);
                apiRequest.format = "text";
                apiRequest.template = cbbTemplate.SelectedItem.ToString();

                var jsonRequest = JsonConvert.SerializeObject(apiRequest);
                var client = new RestClient("https://api.vietqr.io/v2/generate");
                var request = new RestRequest();

                request.Method = Method.Post;
                request.AddHeader("Accept", "application/json");

                request.AddParameter("application/json", jsonRequest, ParameterType.RequestBody);

                var response = client.Execute(request);
                var content = response.Content;
                var dataResult = JsonConvert.DeserializeObject<ApiResponse>(content!);

                var image = Base64ToImage(dataResult!.data!.qrDataURL!.Replace("data:image/png;base64,", ""));

                pbQRCode.Image = image;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
            return image;
        }
    }
}
