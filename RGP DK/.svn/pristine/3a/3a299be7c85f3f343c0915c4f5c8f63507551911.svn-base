using System;
using System.Collections;
using System.Collections.Generic;
using U3DEventFrame;
using UnityEngine;

public class CursorManager : NPCBase
{

    

    public Texture2D cursor_normal;
    public Texture2D cursor_npc_talk;
    public Texture2D cursor_attack;
    public Texture2D cursor_lockTarget;
    public Texture2D cursor_pick;

    private Vector2 hotspot = Vector2.zero;
    private CursorMode mode = CursorMode.Auto;

    void Awake()
    {
        msgIds = new ushort[] {
            (ushort)NPCTextureEvents.MouseEnterNPC,
            (ushort)NPCTextureEvents.MouseExitNPC

        };
        RegistSelf(this, msgIds);
    }
    void Start()
    {

    }

    void Update()
    {

    }


    public override void ProcessEvent(MsgBase msg)
    {
        //throw new NotImplementedException();

        switch (msg.msgId)
        {

            case (ushort)NPCTextureEvents.MouseEnterNPC:
                {
                    Cursor.SetCursor(cursor_npc_talk, hotspot, mode);
                }
                break;
            case (ushort)NPCTextureEvents.MouseExitNPC:
                {
                    Cursor.SetCursor(cursor_normal, hotspot, mode);
                }
                break;

        }
    }



}
