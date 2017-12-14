using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using U3DEventFrame;
using System;


public class LoginSq : UIBase
{

    SqliteDataReader reader;
    private bool have = false;
    private bool zhanghaoR = false;
    public string zhanghao1;

    private AsyncOperation opera;

    //是否开始读取切换场景进度
    private bool isProgressBar = false;
    //用来接收在lua中传过来的进度条slider
    private Slider progressBarSlider;
    private float tmpProgress = 0f;

    void Awake()
    {
        msgIds = new ushort[] {

            (ushort)RoleEvents.GetResource

        };

        RegistSelf(this, msgIds);
    }

    void Start()
    {

    }

    void Update()
    {
        //如果使用切换场景2方法，则需要放开在代码，屏蔽下方代码
        //if (isProgressBar == true)
        //{
        //    Debug.Log(opera.progress);
        //    tmpProgress = Mathf.Lerp(tmpProgress, opera.progress, Time.deltaTime);
        //    progressBarSlider.value = tmpProgress / 9 * 10;
        //    if(tmpProgress / 9 * 10 >= 0.995)
        //    {
        //        isProgressBar = false;
        //        progressBarSlider.value = 1;
        //        opera.allowSceneActivation = true;
        //        //向lua发送加载选择场景UI
        //        MsgBase tmpMsg = ObjectPoolManager<MsgBase>.Instance.GetFreeObject();
        //        tmpMsg.ChangeEventId((ushort)RoleEvents.GetResource);
        //        SendMsg(tmpMsg);
        //    }
        //}

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
    /// <summary>
    /// 登录
    /// </summary>
    public void OnLoginButtonClick(Text hint,string name,string pass)
    {
        string zhanghao = name;
        //切换到play场景，角色魔法师 TODO
        PlayerPrefs.SetString("LoginAccount", zhanghao);
        zhanghao1 = zhanghao;
        string mima1 = pass;
        Sqlite.Instance().Open(Application.dataPath + "/data.db");
        Sqlite.Instance().ExecuteNonQuery("create table if not exists User(uid integer primary key autoincrement,account text,password text,username text,character text)");
        Sqlite.Instance().ExecuteNonQuery("create table if not exists storage(account text,save text,level integer, hpbar real, mpbar real, expbar real, totalExp real, equip text)");
        reader = Sqlite.Instance().ExecuterReader("select * from User where account = '" + zhanghao + "'");

        if (reader.Read())
        {
            string password = reader.GetString(2);
            string character = reader.GetString(4);
            string username = reader.GetString(3);
            if (mima1 == password)
            {
                //Debug.Log("登录成功");
                have = true;
                if (character == "0")
                {
                    //切换到play场景，角色魔法师 TODO
                    PlayerPrefs.SetInt("SelectCharacterIndex", 0);
                    //存储输入的帐号
                    PlayerPrefs.SetString("Account", zhanghao);
                    //StartCoroutine(HandoverScene(3));
                }
                else if (character == "1")
                {
                    //切换到play场景，角色剑士 TODO
                    PlayerPrefs.SetInt("SelectCharacterIndex", 1);
                    //存储输入的帐号
                    PlayerPrefs.SetString("Account", zhanghao);
                    //StartCoroutine(HandoverScene(3));
                }
                else
                {
                    //存储输入的帐号
                    PlayerPrefs.SetString("Account", zhanghao);
                    //切换到character场景
                    
                    //向lua发送加载切换进度条的消息
                    MsgBase tmpMsg = ObjectPoolManager<MsgBase>.Instance.GetFreeObject();
                    tmpMsg.ChangeEventId((ushort)RoleEvents.LoadinProgressLoad);
                    SendMsg(tmpMsg);

                    //HandoverScene2(1);
                    StartCoroutine(HandoverScene(1));
                    //Debug.Log("!!!!!!!!!!!!!!!!!!!!!!");                    
                }

            }
            else
            {
                //Debug.Log("密码错误");
                hint.gameObject.SetActive(true);
                hint.text = "帐号或密码错误";
            }
        }
        else
        {
            //Debug.Log("账号不存在");
            hint.gameObject.SetActive(true);
            hint.text = "账号不存在";
        }
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
    //场景加载(两种方法，这种场景切换是伪进度)
    void HandoverScene2(int num)
    {
        opera = SceneManager.LoadSceneAsync(num);
        opera.allowSceneActivation = false;

    }
    /// <summary>
    /// 结束程序
    /// </summary>
    public void ExitProgram()
    {
        Application.Quit();
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
