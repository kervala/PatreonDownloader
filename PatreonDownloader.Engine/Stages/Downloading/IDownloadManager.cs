﻿using System.Collections.Generic;
using System.Threading.Tasks;
using PatreonDownloader.Engine.Models;

namespace PatreonDownloader.Engine.Stages.Downloading
{
    internal interface IDownloadManager
    {
        Task Download(List<CrawledUrl> crawledUrls, string downloadDirectory);
    }
}