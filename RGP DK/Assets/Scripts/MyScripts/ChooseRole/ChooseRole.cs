using UnityEngine;
using System.Collections;

using U3DEventFrame;
using System;

public class ChooseRole : CharactorBase
{
    public override void ProcessEvent(MsgBase msg)
    {
        switch (msg.msgId)
        {
            case (ushort)CharactorChooseRoleEvents.Initial:
                //加载两个角色模型，其中一个是未激活状态
                AssetResponseMsg tmpMsg = (AssetResponseMsg)msg;
                UnityEngine.Object[] magicianObjs = tmpMsg.GetBundleRes("Roles", "Magician_idle.prefab");
                UnityEngine.Object[] swordmanObjs = tmpMsg.GetBundleRes("Roles", "Swordman_idle.prefab");
                GameObject tmpMagicianObj = GameObject.Instantiate(magicianObjs[0], Vector3.zero, Quaternion.identity) as GameObject;
                GameObject tmpSwordmanObj = GameObject.Instantiate(swordmanObjs[0], Vector3.zero, Quaternion.identity) as GameObject;
                tmpMagicianObj.transform.Rotate(Vector3.up, 180);
                tmpSwordmanObj.transform.Rotate(Vector3.up, 180);
                tmpSwordmanObj.SetActive(false);

                characters = new GameObject[] { tmpMagicianObj, tmpSwordmanObj };
                roleStr.InitialGameObject(characters);

                break;
            case (ushort)CharactorChooseRoleEvents.GetResource:  

                break;
            case (ushort)CharactorChooseRoleEvents.PrevBtn:
                //Debug.Log("受到lua");
                roleStr.OnPrevButtonClick();
                break;
            case (ushort)CharactorChooseRoleEvents.NextBtn:
                roleStr.OnNextButtonClick();
                break;
            case (ushort)CharactorChooseRoleEvents.AcceptBtn:
                Debug.Log("accept coming !!");
                break;
            default:
                break;
        }
    }

    ChooseRoleStr roleStr;
    GameObject[] characters;

    void Awake()
    {
        msgIds = new ushort[] {
            (ushort)CharactorChooseRoleEvents.Initial,
            (ushort)CharactorChooseRoleEvents.GetResource,
            (ushort)CharactorChooseRoleEvents.PrevBtn,
            (ushort)CharactorChooseRoleEvents.NextBtn,
            (ushort)CharactorChooseRoleEvents.AcceptBtn
        };

        RegistSelf(this, msgIds);
        GetResoures();
        roleStr = new ChooseRoleStr();
    }


    private void ReleaseBundle()
    {
        //HunkAssetRes tmpMsg = ObjectPoolManager<HunkAssetRes>.Instance.GetFreeObject();

        //tmpMsg.ChangeReleaseBundleMsg((ushort)AssetEvent.ReleaseBundleAndObject, "scenceName", "bundleName");


        //SendMsg(tmpMsg);

        //ObjectPoolManager<HunkAssetRes>.Instance.ReleaseObject(tmpMsg);

    }

    private void GetResoures()
    {


        //        --- 申请多个bundle 里面多个资源

        //-- bundle 对应的名字   以下是二个bundle 包

        string[] bundle = {
                               "Roles"
                           };



        string[][] resName = new string[1][];

        //第一bundle 包里的资源名字
        resName[0] = new string[2] { "Magician_idle.prefab", "Swordman_idle.prefab" };
        //第二bundle 包里的
        // ------- -----------------------------这里面要加后缀 .prefab   .png----------TestTwo多个情况不用加----------
        



        bool[][] singles = new bool[1][];

        //第一bundle 包里的资源 是单个资源还是多个资源true 表示单个
        singles[0] = new bool[2] { true, true };
        //第二bundle 包里的资源 是单个资源还是多个资源true 表示单个


        AssetRequesetMsg tmpMsg = ObjectPoolManager<AssetRequesetMsg>.Instance.GetFreeObject();

        tmpMsg.ChangeEventMsg((ushort)AssetEvent.HunkMutiRes, (ushort)CharactorChooseRoleEvents.Initial, "ChooseRole", bundle, resName, singles);


        SendMsg(tmpMsg);

        ObjectPoolManager<AssetRequesetMsg>.Instance.ReleaseObject(tmpMsg);



    }


    private void JumpNextView()
    {

      //  MsgBase  tmpMsg= ObjectPoolManager<MsgBase>.Instance.GetFreeObject();

     //   tmpMsg.ChangeEventId((ushort)PoleEvent.ReadData);

      //  SendMsg(tmpMsg);


       // ObjectPoolManager<MsgBase>.Instance.ReleaseObject(tmpMsg);

    }

}
