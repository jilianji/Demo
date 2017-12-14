using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite;

public class Sqlite
{
    private static Sqlite instance;
    public static Sqlite Instance() {
        if (instance == null) {
            instance = new Sqlite();
        }
        return instance;
    }
    SqliteConnection con;
    SqliteCommand cmd;
    SqliteDataReader reader;


    public void Open(string fileName)
    {
        con = new SqliteConnection("data source=" + fileName);
        con.Open();
    }
    public void Close()
    {
        reader.Close();
        con.Close();

    }
    public int ExecuteNonQuery(string command)
    {
        cmd = new SqliteCommand(command, con);
        int count = cmd.ExecuteNonQuery();
        cmd.Dispose();
        return count;
    }
    public SqliteDataReader ExecuterReader(string command)
    {
        cmd = new SqliteCommand(command, con);
        reader = cmd.ExecuteReader();
        cmd.Dispose();
        return reader;
    }


}
