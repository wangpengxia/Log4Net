﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LogUtility;

namespace ConsoleApp
{
    class Program
    {

        static void Main(string[] args)
        {
            //加载日志配置文件，只需要在程序启动时加载一次
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "Log4net.config";
            LogHelper.SetConfig(filePath);

            LogData();
        }

        public static void LogData()
        {
            //记录一般信息
            LogHelper.Info("info");
            //记录调试信息
            LogHelper.Debug("debug");
            //记录警告信息
            LogHelper.Warn("warn");

            //记录错误日志
            LogHelper.Error("error", new Exception("发生了一个异常"));
            //记录严重错误
            LogHelper.Fatal("fatal", new Exception("发生了一个致命错误"));

            Console.WriteLine("日志记录完毕。");
            Console.Read();


        }


    }
}
