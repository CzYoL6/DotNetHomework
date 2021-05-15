using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20210423homework
{
    public partial class Form1 : Form
    {
        Crawler crawler = new Crawler();
        BindingSource bs_crawledUrl = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            crawler.PageDownloadDone += Crawler_PageDownloaded;
            crawler.CrawlerStopped += Crawler_CrawlerStopped;
            dgv_crawledUrl.DataSource = bs_crawledUrl;
        }

        private async void btn_start_Click(object sender, EventArgs e)
        {
            crawler.init();
            bs_crawledUrl.Clear();
            crawler.StartURL = tb_startUrl.Text;
            crawler.pending.Enqueue(tb_startUrl.Text);

            Match match = Regex.Match(crawler.StartURL, Crawler.urlParseRegex);
            if (match.Length == 0) return;
            string host = match.Groups["host"].Value;
            crawler.HostFilter = "^" + host + "$";
            crawler.FileFilter = "((.html?|.aspx|.jsp|.php)$|^[^.]+$)";
            crawler.Start();
            //btn_start.Enabled = false;
            //Task task = Task.Run(crawler.Start);
            //await task;
            //Task.Run(() => crawler.Start());
            
        }

        private void Crawler_CrawlerStopped(Crawler obj)
        {
            Action action = () => btn_start.Enabled = true;
            if (this.InvokeRequired)
            {
                //MessageBox.Show("爬完了！"+btn_start.Enabled);
                this.Invoke(action);
                //MessageBox.Show(btn_start.Enabled.ToString());
            }
            else
            {
                action();
            }
        }

        private void Crawler_PageDownloaded(Crawler crawler, string url, string info)
        {
            var pageInfo = new { Index = bs_crawledUrl.Count + 1, URL = url, Status = info };
            Action action = () =>
            {
                
                bs_crawledUrl.Add(pageInfo);
                /*dgv_crawledUrl.DataSource = null;
                dgv_crawledUrl.DataSource = bs_crawledUrl;*/
                dgv_crawledUrl.Refresh();
            };
            if (this.InvokeRequired)
            {
                this.Invoke(action);
            }
            else
            {
                action();
            }

        }

        private void bs_crawledUrl_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dgv_crawledUrl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
