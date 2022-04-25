using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace JsonHelper
{
    public class Json
    {
        /// <summary>
        /// 将数据存为Json字符串文件
        /// </summary>
        /// <param name="path">路径</param>
        /// <param name="fileName">文件名</param>
        /// <param name="data">数据</param>
        /// <param name="fileMode">存储方式</param>
        public static void SaveJsonFile(string path, string fileName, object data, FileMode fileMode = FileMode.Create)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            path = path + fileName + ".json";

            string json = JsonSerializer.Serialize(data, data.GetType());
            byte[] jsonBytes = Encoding.UTF8.GetBytes(json);
            FileStream file = new FileStream(path, fileMode);
            file.Write(jsonBytes, 0, jsonBytes.Length);//写入
            file.Flush();
            file.Close();
        }

        /// <summary>
        /// 读取Json文件，返回指定类型的数据
        /// </summary>
        /// <typeparam name="T">返回的数据类型</typeparam>
        /// <param name="jsonFile">json文件</param>
        /// <returns>返回的数据</returns>
        [return: MaybeNull]
        public static T ReadJsonFile<T>(string jsonFile)
        {
            if (File.Exists(jsonFile))
            {
                FileStream file = new FileStream(jsonFile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                StreamReader stream = new StreamReader(file);
                T? data = JsonSerializer.Deserialize<T>(stream.ReadToEnd());
                file.Flush();
                file.Close();
                return data;
            }
            return default;
        }
    }

    public class DefaultData
    {
        public string Name { get; set; }

        public DefaultData()
        {
            Name = "default";
        }
    }
}
