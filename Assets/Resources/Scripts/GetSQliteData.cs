using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite;
using System;


/*此脚本获取数据库数据*/
public class GetSQliteData
{
    #region 单例 
    static GetSQliteData _instance;
    public static GetSQliteData Instance()
    {
        if(_instance == null)
        {
            _instance = new GetSQliteData();
        }
        return _instance;
    }
    private GetSQliteData() { }//私有化构造函数

    #endregion

    SqliteConnection connect;//连接
    SqliteCommand command;//命令
    SqliteDataReader datareader;//数据读取

    /// <summary>
    /// 创建数据库连接, 并打开
    /// </summary>
    /// <param name="path">路径</param>
    public void OpenDB(string path)
    {
        connect = new SqliteConnection(path);
        try
        {
            connect.Open();
        }
        catch (Exception exp)
        {
            Debug.Log(exp.ToString() + "----打开数据库失败");
        }
    }

    /// <summary>
    /// 清空数据库连接
    /// </summary>
    public void CloseDB()
    {
        if(connect != null)
        {
            connect.Dispose();
            connect = null;
        }
    }

    /// <summary>
    /// 创建命令
    /// </summary>
    /// <param name="sqQuery">命令</param>
    public SqliteDataReader CreateCommand(string sqQuery)
    {
        try
        {
            command = connect.CreateCommand();
            command.CommandText = sqQuery;
            datareader = command.ExecuteReader();
        }
        catch (Exception exp)
        {
            Debug.Log(exp.ToString() + "----sq语句错误");
        }       
        return datareader;
    }

    /// <summary>
    /// 读取数据
    /// </summary>
    /// <param name="tableName">表名</param>
    /// <param name="condition">条件</param>
    /// <param name="value">值</param>
    /// <returns></returns>
    public SqliteDataReader GetDataReader(string tableName, string condition, string value)
    {
        string sqQuery = "SELECT *FROM " + tableName + " WHERE " + condition + " = " + "'" + value + "'";

        return CreateCommand(sqQuery);
    }
}
