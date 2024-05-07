using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Collections;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
/* 
  本程序的要求
（1）只爬取指定网站（与起始地址的域名相同）上的网页 
 （2）只有当爬取的是htm/html/aspx/php/jsp等网页时，才解析并爬取下一级URL。
 （3）相对地址(test/page.html, ./test/page.html, ../test2/page2.html, /test3/page.html)转成完整地址（“协议://域名/路径/文件” 形式）进行爬取。
 （4） 尝试使用Winform来配置初始URL，启动爬虫，显示已经爬取的URL和错误的URL信息。
*/
public class Crawler

{
    private Hashtable urls = new Hashtable();
    private int count = 0;

    public string Download(string url)
    {
        try 
        {
            WebClient webClient = new WebClient();
            webClient.Encoding = Encoding.UTF8;
            string html = webClient.DownloadString(url);

            Console.WriteLine($"已经爬行{url}界面！");

            string fileName = count.ToString()+".html";
            File.WriteAllText(fileName, html, Encoding.UTF8);
            return html;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"下载{url}时候出错"+ex.Message);
            return "";
        }
    }

    public void Parse(string html)
    {
        string strRef = @"(href|HREF)[]* = []*[""'][^""'#>]+[""']";
        MatchCollection matches = new Regex(strRef).Matches(html);
        foreach (Match match in matches)
        {
            strRef = match.Value.Substring(match.Value.IndexOf('=') + 1).Trim('"', '\"', '#', ',', '>');
            if (strRef.Length == 0) continue;
            if (urls[strRef] == null) urls[strRef] = false;
        }
    }


    private void Crawl()
    {
        Console.WriteLine("开始进行爬取");
        while(true) 
        {
            string current = null;
            foreach(string url in urls.Keys ) 
            {
                if ((bool)urls[url]) continue; current = url; //不重复下载
            }
            if (current == null || count > 10) break;

            Console.WriteLine("爬行" + current + "页面!");
            string html = Download(current);
            urls[current] = true;
            count++;
            Parse(html);//解析，加入新的连接
        }
        Console.WriteLine("爬行结束");
    }
    static void Main(string[] args)
    {
        Crawler mycrawler = new Crawler();

        string startUrl = "http://www.cnblogs.com/dstang2000/";
        if(args.Length >= 1)  startUrl = args[0];
        mycrawler.urls.Add(startUrl, false);//加入初始界面
        new Thread(mycrawler.Crawl).Start();
    }

}