using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenshinLauncher.Tasks
{
    public class LaunchTask
    {
        public void RunGame( string GamePath )
        {
            //创建游戏进程对象
            Process GameProcess = new Process();
            //设置游戏路径参数
            GameProcess.StartInfo.FileName = GamePath;
            GameProcess.StartInfo.WorkingDirectory = Path.GetDirectoryName(GamePath);
            //启动游戏进程
            GameProcess.Start();
        }
    }
}
