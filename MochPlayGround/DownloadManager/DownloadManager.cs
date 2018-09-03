using System;
using System.Net;
using System.Diagnostics;
using System.ComponentModel;

namespace MochPlayGround.DownloadManagers
{
    public class DownloadManager
    {
        private Stopwatch clocker;
        private WebClient downloader;

        public DownloadManager()
        {
            clocker = new Stopwatch();
            downloader = new WebClient();
        }

        public void DownloadFile(string sourceUrl, string targetFolder)
        {
            SetUp();
            Execute(sourceUrl, targetFolder);
        }

        private void Execute(string sourceUrl, string targetFolder)
        {
            clocker.Start();
            downloader.DownloadFileAsync(new Uri(sourceUrl), targetFolder);
        }

        private void SetUp()
        {
            downloader.Headers.Add("User-Agent", "Mozilla/4.0 (compatible; MSIE 8.0)");
            downloader.DownloadFileCompleted += new AsyncCompletedEventHandler(OnComplete);
            downloader.DownloadProgressChanged += new DownloadProgressChangedEventHandler(OnDownload);
        }

        private void OnDownload(object sender, DownloadProgressChangedEventArgs e)
        {
            Console.WriteLine(e.BytesReceived + "/" + e.TotalBytesToReceive + " byte(" + e.ProgressPercentage + "%)");
        }

        private void OnComplete(object sender, AsyncCompletedEventArgs e)
        {
            clocker.Stop();

            if (e.Error != null)
            {
                Console.WriteLine(e.Error.Message);
                return;
            }

            Console.WriteLine("Download Completed!!! " + clocker.ElapsedMilliseconds + "ms");
        }
    }
}
