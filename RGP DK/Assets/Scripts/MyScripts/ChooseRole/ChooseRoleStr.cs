using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using System.Text.RegularExpressions;
using U3DEventFrame;

public class ChooseRoleStr : UIBases {

    private GameObject[] characterGameObjects;
    private int selectedIndex = 0;
    //场景2中用户输入的名字
    private string userName;
    private AsyncOperation opera;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }

    public void InitialGameObject(GameObject[] gameobjects)
    {
        characterGameObjects = gameobjects;
    }

    /// <summary>
    /// set gameobject show and hide
    /// </summary>
    void UpdateCharacterShow()
    {
        characterGameObjects[selectedIndex].SetActive(true);
        for (int i = 0; i < 2; i++)
        {
            if (i != selectedIndex)
            {
                characterGameObjects[i].SetActive(false);
            }
        }
    }
    /// <summary>
    /// 点击下一个按钮，更新数组下标
    /// </summary>
    public void OnNextButtonClick()
    {
        selectedIndex = ++selectedIndex % characterGameObjects.Length;
        UpdateCharacterShow();
    }

    public void OnPrevButtonClick()
    {
        selectedIndex--;
        if (selectedIndex <= -1)
        {
            selectedIndex = characterGameObjects.Length - 1;
        }
        UpdateCharacterShow();
    }

    public void OnOkButtonClick(Text reminder, string name)
    {
        
        Debug.Log(name);
        userName = name;
        if(name != "null")
        {
            bool result2 = Regex.IsMatch(name, "^[\\w]\\w*$");
            if (result2)
            {
                Debug.Log("名字是可用的！");
                //保存选择的角色及输入的名字
                CharacterSave();
                //加载下一个场景
                //StartCoroutine(HandoverScene());
            }
            else
            {
                reminder.gameObject.SetActive(true);
                //名字不能为空TODO
                reminder.text = "输入有非法字符";
                return;
            }
        }
        else
        {
            reminder.gameObject.SetActive(true);
            //名字不能为空TODO
            reminder.text = "请输入名字";
            return;
        }        
    }

    //private void StartCoroutine(IEnumerator enumerator)
    //{
    //    throw new NotImplementedException();
    //}

    /// <summary>
    /// 存储选择的角色及名字
    /// </summary>
    void CharacterSave()
    {
        //存储选择的角色
        PlayerPrefs.SetInt("SelectCharacterIndex", selectedIndex);

        string loginAccount = PlayerPrefs.GetString("loginAccount");

        Sqlite.Instance().Open(Application.dataPath + "/data.db");
        Sqlite.Instance().ExecuteNonQuery(string.Format
            ("update user set username='{0}',character = '{1}' where account='{2}'", userName, selectedIndex.ToString(), loginAccount));
        Sqlite.Instance().Close();
    }
    /// <summary>
    /// 异步切换场景
    /// </summary>
    IEnumerator HandoverScene()
    {
        opera = SceneManager.LoadSceneAsync(3);
        yield return opera;
    }

    public override void ProcessEvent(MsgBase msg)
    {
        throw new NotImplementedException();
    }
}
