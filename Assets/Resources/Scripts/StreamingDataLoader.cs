using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

/*此脚本copy Streaming数据到沙盒中*/
public class StreamingDataLoader : MonoBehaviour {

    /// <summary>
    /// 加载路径下的数据拷贝到沙盒中
    /// </summary>
    /// <param name="paths">需要拷贝到沙盒路径中的文件夹路径数组</param>
    public void LoadWithPath(string[] paths)
    {
        //开启一个协程
        StartCoroutine("CopyFile", paths);
    }

    IEnumerator CopyFile(string[] paths)
    {
        string streamingPath;


        for (int i = 0; i < paths.Length; i++)
        {
            streamingPath = Path.Combine(Application.streamingAssetsPath, paths[i]);
            if (!streamingPath.Contains("file://"))
            {
                streamingPath = "file://" + streamingPath;
                //file://StreamingAssets/MyConnect.db
            }
            //通过www类对本地数据进行下载(读取本地文件的过程)
            WWW www = new WWW(streamingPath);
            yield return www;

            string perPath = Path.Combine(Application.persistentDataPath, paths[i]);
            print("沙盒路径" + perPath);

            //拷贝
            WriteBytes(www.bytes, perPath);

        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="bytes">拷贝的内容</param>
    /// <param name="path">拷贝到的路径</param>
    private void WriteBytes(byte[] bytes, string path)
    {
        //判断文件是否存在
        if (!File.Exists(path))
        {
            //根据路径以及文件模式创建一个文件流
            FileStream fs = new FileStream(path, FileMode.Create);
            //写入文件流
            fs.Write(bytes, 0, bytes.Length);
            //清除文件流
            fs.Flush();
            //关闭文件流
            fs.Close();

        }
    }
}
