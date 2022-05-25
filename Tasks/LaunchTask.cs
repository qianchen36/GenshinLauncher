using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.UI.Xaml.Controls;

namespace GenshinLauncher.Tasks
{
    static public class LaunchTask
    {
        static private Process GameProcess;

        //启动游戏
        static public async Task RunGame(string GamePath)
        {
            //创建游戏进程实例
            GameProcess = new()
            {
                StartInfo = new ProcessStartInfo()
                {
                    FileName = GamePath,
                    WorkingDirectory = Path.GetDirectoryName(GamePath)
                }
            };
            //启动游戏进程
            GameProcess.Start();

            //等待游戏进程退结束
            await GameProcess.WaitForExitAsync();
            GameProcess.Close();
        }
    }
}
