using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Android_ID_Changer
{
    public class Tool
    {
        public static string SN { get; set; }

        public static string ADB(string command)
        {
            string log = null;
            using (var p = new Process())
            {
                p.StartInfo.FileName = "adb.exe";
                p.StartInfo.Arguments = $"{(SN != null ? $"-s {SN}" : "")} {command}";
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardOutput = true;
                p.Start();
                log = p.StandardOutput.ReadToEnd();
                p.WaitForExit();
            }
            return log;
        }

        public static string ADBShell(string command, bool SU = false)
        {
            string log = null;
            using (var p = new Process())
            {
                p.StartInfo.FileName = "adb.exe";
                p.StartInfo.Arguments = $"{(SN != null ? $"-s {SN}" : "")} shell {(SU ? "su -c " : "")}\"{command}\"";
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardOutput = true;
                p.Start();
                log = p.StandardOutput.ReadToEnd();
                p.WaitForExit();
            }
            return log;
        }

        public static string ReadID(int version)
        {
            string id = null;
            if (version == 1)
            {
                id = ADBShell("content query --uri content://settings/secure --where \"name=\\'android_id\\'\"");
                id = id.Substring(id.IndexOf("value=") + 6).Replace("\r\n", "");
            }
            if (version == 2)
            {
                id = ADBShell("settings get secure android_id");
                id = id.Replace("\r\n", "");
            }
            return id;
        }

        public static void WriteID(int version, string new_id)
        {
            if (version == 1)
            {
                ADBShell("content delete --uri content://settings/secure --where \"name=\\'android_id\\'\"");
                ADBShell($"content insert --uri content://settings/secure --bind name:s:android_id --bind value:s:{new_id}");
            }
            if (version == 2)
            {
                ADBShell($"settings put secure android_id {new_id}");
            }
        }
    }
}
