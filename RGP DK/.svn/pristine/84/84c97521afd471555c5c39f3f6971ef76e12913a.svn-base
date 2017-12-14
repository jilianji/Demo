using System;
using System.Collections;
using System.Collections.Generic;
using U3DEventFrame;
using UnityEngine;

public class NNPPCC : NPCBase {
    public override void ProcessEvent(MsgBase msg)
    {
        
    }

    // Use this for initialization
    void Awake() {
        msgIds = new ushort[] {
            (ushort)NPCTextureEvents.MouseEnterNPC,
            (ushort)NPCTextureEvents.MouseExitNPC

        };
        RegistSelf(this, msgIds);
        
    }


    void Start () {
		
	}


    void OnMouseEnter() {
        MsgBase tmpMsg = ObjectPoolManager<MsgBase>.Instance.GetFreeObject();

        tmpMsg.ChangeEventId((ushort)NPCTextureEvents.MouseEnterNPC);

        SendMsg(tmpMsg);


    }


    void OnMouseExit()
    {
        MsgBase tmpMsg = ObjectPoolManager<MsgBase>.Instance.GetFreeObject();

        tmpMsg.ChangeEventId((ushort)NPCTextureEvents.MouseExitNPC);

        SendMsg(tmpMsg);
    }

    // Update is called once per frame
    void Update () {
     
    }
}
