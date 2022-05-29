using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenshinLauncher.Tasks
{
    public static class InitializeTask
    {
        //public static iniConfigerTask ini_Launcher;
        //public static iniConfigerTask ini_Game;

        public static void OnLaunch()
        {
            iniConfigerTask ini_Launcher = new iniConfigerTask();
            ini_Launcher.Ini("config.ini");

            App.launcherVer = ini_Launcher.GetValue("version", "General");
            App.unlockFPS = ini_Launcher.GetValue("unlock_FPS", "Extention");

            if (ini_Launcher.GetValue("target_FPS", "Extention") != null) App.targetFPS = int.Parse(ini_Launcher.GetValue("target_FPS", "Extention"));

            if (ini_Launcher.GetValue("launcher_path", "General") != null) App.launcherPath = ini_Launcher.GetValue("launcher_path", "General");
        }
    }
}
