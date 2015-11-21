﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QCloud.VideoApi.Api;
using QCloud.VideoApi.Common;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace QCloud.VideoApi
{
    class Program
    {
        const int APP_ID = 10000000;
        const string SECRET_ID = "SECRET_ID";
        const string SECRET_KEY = "SECRET_KEY";
        static void Main(string[] args)
        {
            Task.Run(async () =>
            {
                try
                {
                    var result = "";
                    var bucketName = "test";
                    var video = new VideoCloud(APP_ID, SECRET_ID, SECRET_KEY);
                    var start = DateTime.Now.ToUnixTime();
                    //result = await video.GetFolderList(bucketName, "/", 20, "", 0, FolderPattern.Both);
                    //result = await video.CreateFolder(bucketName, "/sdk/");
                    //result = await video.UploadFile(bucketName, "/sdk/3863.MOV", @"C:\3863.MOV", "test video", "hahahaha", "houhouhou", "aaaaa");
                    //result = await video.UpdateFile(bucketName, "/sdk/3863.MOV", "test file");
                    //result = await video.GetFileStat(bucketName, "/sdk/3863.MOV");
                    //result = await video.UpdateFolder(bucketName, "/sdk/", "test folder");
                    //result = await video.GetFolderStat(bucketName, "/sdk/");
                    //result = await video.DeleteFile(bucketName, "/sdk/3863.MOV");
                    //result = await video.DeleteFolder(bucketName, "/sdk/");
                    result = await video.SliceUploadFile(bucketName, "/[电影天堂www.dy2018.net].720p.BD中英双字幕.Scared.Shrekless.rmvb", @"E:\QQDownload\[电影天堂www.dy2018.net].720p.BD中英双字幕.Scared.Shrekless.rmvb");
                    var end = DateTime.Now.ToUnixTime();
                    Console.WriteLine(result);
                    Console.WriteLine("总用时：" + (end - start) + "毫秒");
                    Console.ReadKey();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.ReadKey();
            }).Wait();
        }
    }
}
