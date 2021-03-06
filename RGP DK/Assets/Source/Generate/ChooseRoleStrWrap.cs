﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class ChooseRoleStrWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(ChooseRoleStr), typeof(UIBases));
		L.RegFunction("InitialGameObject", InitialGameObject);
		L.RegFunction("OnNextButtonClick", OnNextButtonClick);
		L.RegFunction("OnPrevButtonClick", OnPrevButtonClick);
		L.RegFunction("OnOkButtonClick", OnOkButtonClick);
		L.RegFunction("ProcessEvent", ProcessEvent);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int InitialGameObject(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			ChooseRoleStr obj = (ChooseRoleStr)ToLua.CheckObject(L, 1, typeof(ChooseRoleStr));
			UnityEngine.GameObject[] arg0 = ToLua.CheckObjectArray<UnityEngine.GameObject>(L, 2);
			obj.InitialGameObject(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnNextButtonClick(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			ChooseRoleStr obj = (ChooseRoleStr)ToLua.CheckObject(L, 1, typeof(ChooseRoleStr));
			obj.OnNextButtonClick();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnPrevButtonClick(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			ChooseRoleStr obj = (ChooseRoleStr)ToLua.CheckObject(L, 1, typeof(ChooseRoleStr));
			obj.OnPrevButtonClick();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnOkButtonClick(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			ChooseRoleStr obj = (ChooseRoleStr)ToLua.CheckObject(L, 1, typeof(ChooseRoleStr));
			UnityEngine.UI.Text arg0 = (UnityEngine.UI.Text)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.UI.Text));
			string arg1 = ToLua.CheckString(L, 3);
			obj.OnOkButtonClick(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ProcessEvent(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			ChooseRoleStr obj = (ChooseRoleStr)ToLua.CheckObject(L, 1, typeof(ChooseRoleStr));
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

