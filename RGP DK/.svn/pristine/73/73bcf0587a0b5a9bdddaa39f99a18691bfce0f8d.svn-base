using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using U3DEventFrame;
using System;
using System.Text;
using Mono.Data.Sqlite;
using UnityEngine.UI;

public class SourcesLoadSq : UIBase
{
    private object itemGridList;

    public override void ProcessEvent(MsgBase msg)
    {
        throw new NotImplementedException();
    }

    void Start () {
		
	}
	
	void Update () {
		
	}

    /// <summary>
    /// 存档
    /// </summary>
    //public void Save()
    //{
    //    StringBuilder sb = new StringBuilder();
    //    StringBuilder equipIdSb = new StringBuilder();
    //    for (int i = 0; i < itemGridList.Count; i++)
    //    {
    //        int id = itemGridList[i].id;
    //        sb.Append(id + "|");
    //    }
    //    for (int i = 0; i < itemGridList.Count; i++)
    //    {
    //        if (itemGridList[i].num != 0)
    //        {
    //            int num = itemGridList[i].num;
    //            sb.Append(num + "|");
    //        }
    //    }
    //    //获取武器装备栏数据
    //    int[] equipIds = EquipMentUI.Instance.ids;
    //    for (int i = 0; i < equipIds.Length; i++)
    //    {
    //        equipIdSb.Append(equipIds[i] + "|");
    //    }
    //    //添加金币
    //    int coin = coinCount;//players.coin;
    //    sb.Append(coin);
    //    string zhanghao = denglu.Instance.zhanghao1;

    //    int level = PlayerStatus.Instance.level;
    //    float hpRemain = PlayerStatus.Instance.HpRemain;
    //    float mpRemain = PlayerStatus.Instance.HpRemain;
    //    float exp = PlayerStatus.Instance.exp;
    //    float totalExp = PlayerStatus.Instance.TotalExp;

    //    Sqlite.Instance.Open(Application.dataPath + "/data.db");
    //    string characterType = "0";
    //    if (PlayerStatus.Instance.heroType == HeroType.Magician)
    //    {
    //        characterType = "0";
    //    }
    //    else if (PlayerStatus.Instance.heroType == HeroType.Swordman)
    //    {
    //        characterType = "1";
    //    }
    //    Sqlite.Instance.ExecuteNonQuery(string.Format
    //        ("update user set username='{0}',character = '{1}' where account='{2}'", PlayerStatus.Instance.playerName, characterType, zhanghao));
    //    Sqlite.Instance.ExecuteNonQuery(string.Format("update storage set save='{0}',level = '{1}',hpbar = '{2}',mpbar = '{3}',expbar = '{4}',totalExp = '{5}',equip = '{6}' where account='{7}'",
    //        sb, level, hpRemain, mpRemain, exp, totalExp, equipIdSb, zhanghao));
    //    Sqlite.Instance.Close();
    //}

    /// <summary>
    /// 读取
    /// </summary>
    public void HeadLoad(Text nameText)
    {
        Sqlite.Instance().Open(Application.dataPath + "/data.db");
        string loginAccount = PlayerPrefs.GetString("LoginAccount");
        Debug.Log(loginAccount);

        SqliteDataReader userReader = Sqlite.Instance().ExecuterReader("select username,character from User where account ='" + loginAccount + "'");
        SqliteDataReader reader = Sqlite.Instance().ExecuterReader("select * from storage where account ='" + loginAccount + "'");

        if (userReader.Read())
        {
            nameText.text = userReader.GetString(0);
        }

        if (reader.Read())
        {
            Debug.Log(reader.GetString(1));
            string sb = null;
            int level = 1;
            float hpbar = 100;
            float mpbar = 100;
            float exp = 0;
            float totalExp = 100;
            string equip = null;

            sb = reader.GetString(1);
            level = reader.GetInt32(2);
            hpbar = reader.GetFloat(3);
            mpbar = reader.GetFloat(4);
            exp = reader.GetFloat(5);
            totalExp = reader.GetFloat(6);
            equip = reader.GetString(7);

            if (sb == "0")
            {
                Debug.Log("没有存储");
            }
            else
            {
                //string[] itemids = sb.Split('|');
                //for (int i = 0; i < itemGridList.Count; i++)
                //{
                //    if (int.Parse(itemids[i]) != 0)
                //    {
                //        GetId(int.Parse(itemids[i]));
                //    }
                //    for (int j = itemGridList.Count; j < itemids.Length - 1; j++)
                //    {
                //        if (itemGridList[i].id != 0)
                //        {
                //            //Debug.Log(int.Parse(itemids[j]) + "  id");
                //            itemGridList[i].InitNumber(int.Parse(itemids[j]));
                //        }
                //    }
                //}
                ////读取存档，穿上装备
                //string[] equipIds = equip.Split('|');
                //Debug.Log(equip);
                //for (int i = 0; i < EquipMentUI.Instance.ids.Length; i++)
                //{
                //    if (int.Parse(equipIds[i]) != 0)
                //    {
                //        EquipMentUI.Instance.Dress(int.Parse(equipIds[i]));
                //    }
                //}

                //PlayerStatus.Instance.InitStatus(level, hpbar, mpbar, exp, totalExp);
                //Setcoin(int.Parse(itemids[itemids.Length - 1]));
            }
        }
        Sqlite.Instance().Close();
    }
}
