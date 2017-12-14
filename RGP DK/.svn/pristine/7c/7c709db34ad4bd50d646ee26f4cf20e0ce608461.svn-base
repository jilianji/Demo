using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite;
using UnityEngine.SceneManagement;
using System.Text.RegularExpressions;
using UnityEngine.UI;
using U3DEventFrame;
using System;

public class SigninSq: UIBase
{
    SqliteDataReader reader;
    private bool have = false;


    private AsyncOperation opera;
    //是否开始读取切换场景进度
    private bool isProgressBar = false;
    //用来接收在lua中传过来的进度条slider
    private Slider progressBarSlider;
    private float tmpProgress = 0f;

    void Start()
    {

    }

    void Update()
    {
        if (opera == null)
        {
            return;
        }
        // 进度条的显示
        if (opera.progress / 0.9f * 100 > tmpProgress)
        {
            ++tmpProgress;
            progressBarSlider.value = tmpProgress / 100f;
        }
    }
    // <summary>
    // 提示语
    // </summary>
    // <param name = "reminder" > 提示语 </ param >



    public void OnClickOk(Text hint,string name, string pass)
    {
        string zhanghao = name;
        string mima1 = pass;
        Sqlite.Instance().Open(Application.dataPath + "/data.db");
        Sqlite.Instance().ExecuteNonQuery("create table if not exists User(uid integer primary key autoincrement,account text,password text,username text,character text)");
        Sqlite.Instance().ExecuteNonQuery("create table if not exists storage(account text,save text,level integer, hpbar real, mpbar real, expbar real, totalExp real, equip text)");
        
        //int a = Sqlite.Instance.ExecuteNonQuery(string.Format("insert into User values('{0}','{1}')", zhanghao, mima1));
        
        bool result1 = Regex.IsMatch(zhanghao, "^\\d{8,12}$");
        bool result2 = Regex.IsMatch(mima1, "^.{8,12}$");
        if (zhanghao == "null" || mima1 == "null")
        {
            //Debug.Log("qweqwe");
            hint.gameObject.SetActive(true);
            hint.text = "帐号或密码不能为空";
        }
        else if (!result1)
        {
            hint.gameObject.SetActive(true);
            hint.text = "账号长度为8-12位的数字";
        }
        else
        {
            if (!result2)
            {
                hint.gameObject.SetActive(true);
                hint.text = "密码长度为8-12位";
            }
            else
            {
                reader = Sqlite.Instance().ExecuterReader("select * from User where account = '" + zhanghao + "'");
                if (reader.Read())
                {
                    hint.gameObject.SetActive(true);
                    hint.text = "账号已存在";
                }
                else
                {
                    //存储输入的帐号
                    PlayerPrefs.SetString("Account", zhanghao);

                    Sqlite.Instance().ExecuteNonQuery(string.Format("insert into User(account,password,username,character) values('{0}','{1}','{2}','{3}')", zhanghao, mima1, 000, "风云无忌"));
                    Sqlite.Instance().ExecuteNonQuery(string.Format("insert into storage values('{0}','{1}', 1, 100, 100, 0, 100, '0')", zhanghao, 0));
                    
                    //向lua发送加载切换进度条的消息
                    MsgBase tmpMsg = ObjectPoolManager<MsgBase>.Instance.GetFreeObject();
                    tmpMsg.ChangeEventId((ushort)RoleEvents.SigninProgressLoad);
                    SendMsg(tmpMsg);

                    StartCoroutine(HandoverScene(1));
                }
            }
        }
        //Sqlite.Instance.ExecuteNonQuery("delete from Userr");
        //Debug.Log("清空数据库");
        Sqlite.Instance().Close();
    }
    /// <summary>
    /// 异步切换场景
    /// </summary>
    IEnumerator HandoverScene(int num)
    {
        //slider.gameObject.SetActive(true);
        //gameObject.SetActive(false);
        //reminderLabel.gameObject.SetActive(false);
        opera = SceneManager.LoadSceneAsync(num);
        opera.allowSceneActivation = false;

        while (!opera.isDone)
        {
            if (tmpProgress >= 100)
                break;
            yield return null;
        }
        //yield return opera;
        yield return new WaitForSeconds(0.1f);

        isProgressBar = true;

        //向lua发送加载选择场景UI
        MsgBase tmpMsg = ObjectPoolManager<MsgBase>.Instance.GetFreeObject();
        tmpMsg.ChangeEventId((ushort)RoleEvents.GetResource);
        SendMsg(tmpMsg);

        opera.allowSceneActivation = true;
    }
    // <summary>
    // 异步切换场景
    // </summary>
    public void HandoverScene2()
    {
        //直接进入play场景
        SceneManager.LoadSceneAsync(1);
    }

    //lua中来执行开始切换场景的进度条
    public void ProgressBarExecute(GameObject progressBarSlider)
    {
        isProgressBar = true;
        this.progressBarSlider = progressBarSlider.GetComponent<Slider>();
    }

    public override void ProcessEvent(MsgBase msg)
    {
        throw new NotImplementedException();
    }
}
