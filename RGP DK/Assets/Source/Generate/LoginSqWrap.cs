﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class LoginSqWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(LoginSq), typeof(U3DEventFrame.UIBase));
		L.RegFunction("OnLoginButtonClick", OnLoginButtonClick);
		L.RegFunction("ExitProgram", ExitProgram);
		L.RegFunction("ProgressBarExecute", ProgressBarExecute);
		L.RegFunction("ProcessEvent", ProcessEvent);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("zhanghao1", get_zhanghao1, set_zhanghao1);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnLoginButtonClick(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			LoginSq obj = (LoginSq)ToLua.CheckObject(L, 1, typeof(LoginSq));
			UnityEngine.UI.Text arg0 = (UnityEngine.UI.Text)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.UI.Text));
			string arg1 = ToLua.CheckString(L, 3);
			string arg2 = ToLua.CheckString(L, 4);
			obj.OnLoginButtonClick(arg0, arg1, arg2);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ExitProgram(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			LoginSq obj = (LoginSq)ToLua.CheckObject(L, 1, typeof(LoginSq));
			obj.ExitProgram();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ProgressBarExecute(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			LoginSq obj = (LoginSq)ToLua.CheckObject(L, 1, typeof(LoginSq));
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.GameObject));
			obj.ProgressBarExecute(arg0);
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
			LoginSq obj = (LoginSq)ToLua.CheckObject(L, 1, typeof(LoginSq));
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

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_zhanghao1(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			LoginSq obj = (LoginSq)o;
			string ret = obj.zhanghao1;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index zhanghao1 on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_zhanghao1(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			LoginSq obj = (LoginSq)o;
			string arg0 = ToLua.CheckString(L, 2);
			obj.zhanghao1 = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index zhanghao1 on a nil value" : e.Message);
		}
	}
}
