using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Getech.EAP.Entity.EAPEntities.FileData
{
    public class FileService
    {

        public static bool FileSave(string filepath, string fileName,string fileInfo)
        {
            try
            {
                string path = filepath + "/" + fileName;
                if (!File.Exists(path))
                {
                    FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);//创建写入文件 
                    StreamWriter sw = new StreamWriter(fs);
                    //开始写入
                    sw.Write(fileInfo);
                    //清空缓冲区
                    sw.Flush();
                    //关闭流
                    sw.Close();
                    fs.Close();
                    return true;

                }
                else
                {
                    FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(fs);
                    //开始写入
                    sw.Write(fileInfo);
                    //清空缓冲区
                    sw.Flush();
                    //关闭流
                    sw.Close();
                    fs.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            
        }

        public static bool FileDel(string filepath, string fileName)
        {
            try
            {
                string path = filepath + "/" + fileName;
                string path1 = Environment.CurrentDirectory + "\\MyTest";
                string path2 = Environment.CurrentDirectory + "\\新建文本文档.txt";
                //删除文件
                if (File.Exists(path))
                    File.Delete(path);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        // add by lc 20220915 for 泡沫盒线删除当前路劲下所有的箱签
        public static bool FileDelAll(string filepath)
        {
            try
            {
                
                string path = filepath;
                //string path1 = Environment.CurrentDirectory + "\\MyTest";
                //string path2 = Environment.CurrentDirectory + "\\新建文本文档.txt";
                DirectoryInfo dirInfo = new DirectoryInfo(path);
                dirInfo.Attributes= FileAttributes.Normal& FileAttributes.Directory;
                File.SetAttributes(path, FileAttributes.Normal);
                //删除文件
                if (Directory.Exists(path))
                  //dirInfo.Delete();
               foreach (string f in  Directory.GetFileSystemEntries(path))
                {
                    if (File.Exists(f))
                    {
                        File.Delete(f);
                    }
                    else 
                    {
                    }
                   
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public static Dictionary<string, Dictionary<string, string>> FileInit(string filepath)
        {
            Dictionary<string, Dictionary<string, string>> dic_dicResult = new Dictionary<string, Dictionary<string,string>>();
            try
            {
                if (!Directory.Exists(filepath))
                {
                    Directory.CreateDirectory(filepath);//不存在就创建目录
                    return null;
                }
                DirectoryInfo root = new DirectoryInfo(filepath);
                foreach (FileInfo f in root.GetFiles())
                {
                    string name = f.Name;
                    string[] strArray = name.Split('&');
                    string fullName = f.FullName;
                    if (!dic_dicResult.ContainsKey(strArray[0]))
                    {
                        Dictionary<string, string> dicResult = new Dictionary<string, string>();
                        dicResult.Add(strArray[1], FileGet(fullName));
                        dic_dicResult.Add(strArray[0], dicResult);
                    }
                    else {
                        Dictionary<string, string> dicResult = dic_dicResult[strArray[0]];
                        dicResult.Add(strArray[1], FileGet(fullName));
                    }
                }
                return dic_dicResult;
            }
            catch (Exception ex)
            {
                return dic_dicResult;
            }

        }
        private static string FileGet(string filepath)
        {
            if (!File.Exists(filepath)) return null;
            return @File.ReadAllText(filepath);
        }
    }
}
