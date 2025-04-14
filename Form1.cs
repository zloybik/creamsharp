using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using RestSharp;
using System.Net;
using System.IO;
using System.Deployment.Application;

namespace Creamsharp
{
    public partial class Form1 : Form
    {
        int tagsCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public async void downloadMaterialsIGuess(string tags, int limit)
        {
            RestClient rqstClient = new RestClient($"https://api.rule34.xxx/index.php?page=dapi&s=post&q=index&json=1&tags={tags}&limit={limit}");
            RestRequest rqst = new RestRequest();
            rqst.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36");
            RestResponse response = await rqstClient.ExecuteAsync(rqst);
            dynamic responseJSON = JsonConvert.DeserializeObject(response.Content);
            if (responseJSON == null)
            {
                MessageBox.Show("API не выдал результатов");
                return;
            }
            progressBarOfDownloading.Maximum = responseJSON.Count;
            for (int index = 0; index < responseJSON.Count; index++)
            {
                string fileUrl = responseJSON[index].file_url;
                WebClient downloadManager = new WebClient();
                string filename = Path.GetFileName(fileUrl);
                downloadManager.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadFileCompletedCallback);
                if (System.IO.Directory.Exists("./download/"))
                    downloadManager.DownloadFileAsync(new Uri(fileUrl), $"./download/{filename}");
                else
                {
                    System.IO.Directory.CreateDirectory("./download/");
                    downloadManager.DownloadFileAsync(new Uri(fileUrl), $"./download/{filename}");
                }
            }
        }

        public void DownloadFileCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            countDownloadedFilesLabel.Text = Convert.ToString(Convert.ToInt32(countDownloadedFilesLabel.Text) + 1);
            progressBarOfDownloading.Value += 1;
        }


        private async void downloadButton_Click(object sender, EventArgs e)
        {
            progressBarOfDownloading.Value = 0;
            countDownloadedFilesLabel.Text = "0";
            downloadMaterialsIGuess(richBoxTags.Text, Convert.ToInt32(numericLimitCount.Value));
        }

        private void buttonAcceptTag_click(object sender, EventArgs e)
        {
            string tag = textBoxTags.Text.Replace(" ", "");
            if(tagsCount == 0)
                richBoxTags.Text = tag;
            else
                richBoxTags.Text = $"{richBoxTags.Text}+{tag}";

            tagsCount++;
        }

        private void buttonDelteAllTags_Click(object sender, EventArgs e)
        {
            tagsCount = 0;
            richBoxTags.Text = "";
        }

        private void checkBoxShowTags_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxShowTags.CheckState == CheckState.Checked) richBoxTags.Visible = true;
            else richBoxTags.Visible = false;
        }
    }
}
