﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class SourcesLoadSqWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(SourcesLoadSq), typeof(U3DEventFrame.UIBase));
		L.RegFunction("ProcessEvent", ProcessEvent);
		L.RegFunction("HeadLoad", HeadLoad);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ProcessEvent(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			SourcesLoadSq obj = (SourcesLoadSq)ToLua.CheckObject(L, 1, typeof(SourcesLoadSq));
			U3DEventFrame.MsgBase arg0 = (U3DEventFrame.MsgBase)ToLua.CheckObject(L, 2, typeof(U3DEventFrame.MsgBase));
			obj.ProcessEvent(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int HeadLoad(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			SourcesLoadSq obj = (SourcesLoadSq)ToLua.CheckObject(L, 1, typeof(SourcesLoadSq));
			UnityEngine.UI.Text arg0 = (UnityEngine.UI.Text)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.UI.Text));
			obj.HeadLoad(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

