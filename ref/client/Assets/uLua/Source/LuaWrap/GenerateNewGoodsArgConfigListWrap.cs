﻿using System;
using System.Collections.Generic;
using LuaInterface;

public class GenerateNewGoodsArgConfigListWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("Add", Add),
			new LuaMethod("AddRange", AddRange),
			new LuaMethod("AsReadOnly", AsReadOnly),
			new LuaMethod("BinarySearch", BinarySearch),
			new LuaMethod("Clear", Clear),
			new LuaMethod("Contains", Contains),
			new LuaMethod("CopyTo", CopyTo),
			new LuaMethod("Exists", Exists),
			new LuaMethod("Find", Find),
			new LuaMethod("FindAll", FindAll),
			new LuaMethod("FindIndex", FindIndex),
			new LuaMethod("FindLast", FindLast),
			new LuaMethod("FindLastIndex", FindLastIndex),
			new LuaMethod("ForEach", ForEach),
			new LuaMethod("GetEnumerator", GetEnumerator),
			new LuaMethod("GetRange", GetRange),
			new LuaMethod("IndexOf", IndexOf),
			new LuaMethod("Insert", Insert),
			new LuaMethod("InsertRange", InsertRange),
			new LuaMethod("LastIndexOf", LastIndexOf),
			new LuaMethod("Remove", Remove),
			new LuaMethod("RemoveAll", RemoveAll),
			new LuaMethod("RemoveAt", RemoveAt),
			new LuaMethod("RemoveRange", RemoveRange),
			new LuaMethod("Reverse", Reverse),
			new LuaMethod("Sort", Sort),
			new LuaMethod("ToArray", ToArray),
			new LuaMethod("TrimExcess", TrimExcess),
			new LuaMethod("TrueForAll", TrueForAll),
			new LuaMethod("get_Item", get_Item),
			new LuaMethod("set_Item", set_Item),
			new LuaMethod("New", _CreateGenerateNewGoodsArgConfigList),
			new LuaMethod("GetClassType", GetClassType),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("Capacity", get_Capacity, set_Capacity),
			new LuaField("Count", get_Count, null),
		};

		LuaScriptMgr.RegisterLib(L, "GenerateNewGoodsArgConfigList", typeof(List<fogs.proto.config.GenerateNewGoodsArgConfig>), regs, fields, typeof(object));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateGenerateNewGoodsArgConfigList(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			List<fogs.proto.config.GenerateNewGoodsArgConfig> obj = new List<fogs.proto.config.GenerateNewGoodsArgConfig>();
			LuaScriptMgr.PushObject(L, obj);
			return 1;
		}
		else if (count == 1 && LuaScriptMgr.CheckTypes(L, 1, typeof(int)))
		{
			int arg0 = (int)LuaScriptMgr.GetNumber(L, 1);
			List<fogs.proto.config.GenerateNewGoodsArgConfig> obj = new List<fogs.proto.config.GenerateNewGoodsArgConfig>(arg0);
			LuaScriptMgr.PushObject(L, obj);
			return 1;
		}
		else if (count == 1 && LuaScriptMgr.CheckTypes(L, 1, typeof(IEnumerable<fogs.proto.config.GenerateNewGoodsArgConfig>)))
		{
			IEnumerable<fogs.proto.config.GenerateNewGoodsArgConfig> arg0 = (IEnumerable<fogs.proto.config.GenerateNewGoodsArgConfig>)LuaScriptMgr.GetNetObject(L, 1, typeof(IEnumerable<fogs.proto.config.GenerateNewGoodsArgConfig>));
			List<fogs.proto.config.GenerateNewGoodsArgConfig> obj = new List<fogs.proto.config.GenerateNewGoodsArgConfig>(arg0);
			LuaScriptMgr.PushObject(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: List<fogs.proto.config.GenerateNewGoodsArgConfig>.New");
		}

		return 0;
	}

	static Type classType = typeof(List<fogs.proto.config.GenerateNewGoodsArgConfig>);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Capacity(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		List<fogs.proto.config.GenerateNewGoodsArgConfig> obj = (List<fogs.proto.config.GenerateNewGoodsArgConfig>)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Capacity");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Capacity on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.Capacity);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Count(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		List<fogs.proto.config.GenerateNewGoodsArgConfig> obj = (List<fogs.proto.config.GenerateNewGoodsArgConfig>)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Count");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Count on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.Count);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Capacity(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		List<fogs.proto.config.GenerateNewGoodsArgConfig> obj = (List<fogs.proto.config.GenerateNewGoodsArgConfig>)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name Capacity");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index Capacity on a nil value");
			}
		}

		obj.Capacity = (int)LuaScriptMgr.GetNumber(L, 3);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Add(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		List<fogs.proto.config.GenerateNewGoodsArgConfig> obj = (List<fogs.proto.config.GenerateNewGoodsArgConfig>)LuaScriptMgr.GetNetObjectSelf(L, 1, "List<fogs.proto.config.GenerateNewGoodsArgConfig>");
		fogs.proto.config.GenerateNewGoodsArgConfig arg0 = (fogs.proto.config.GenerateNewGoodsArgConfig)LuaScriptMgr.GetNetObject(L, 2, typeof(fogs.proto.config.GenerateNewGoodsArgConfig));
		obj.Add(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddRange(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		List<fogs.proto.config.GenerateNewGoodsArgConfig> obj = (List<fogs.proto.config.GenerateNewGoodsArgConfig>)LuaScriptMgr.GetNetObjectSelf(L, 1, "List<fogs.proto.config.GenerateNewGoodsArgConfig>");
		IEnumerable<fogs.proto.config.GenerateNewGoodsArgConfig> arg0 = (IEnumerable<fogs.proto.config.GenerateNewGoodsArgConfig>)LuaScriptMgr.GetNetObject(L, 2, typeof(IEnumerable<fogs.proto.config.GenerateNewGoodsArgConfig>));
		obj.AddRange(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AsReadOnly(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		List<fogs.proto.config.GenerateNewGoodsArgConfig> obj = (List<fogs.proto.config.GenerateNewGoodsArgConfig>)LuaScriptMgr.GetNetObjectSelf(L, 1, "List<fogs.proto.config.GenerateNewGoodsArgConfig>");
		System.Collections.ObjectModel.ReadOnlyCollection<fogs.proto.config.GenerateNewGoodsArgConfig> o = obj.AsReadOnly();
		LuaScriptMgr.PushObject(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int BinarySearch(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2)
		{
			List<fogs.proto.config.GenerateNewGoodsArgConfig> obj = (List<fogs.proto.config.GenerateNewGoodsArgConfig>)LuaScriptMgr.GetNetObjectSelf(L, 1, "List<fogs.proto.config.GenerateNewGoodsArgConfig>");
			fogs.proto.config.GenerateNewGoodsArgConfig arg0 = (fogs.proto.config.GenerateNewGoodsArgConfig)LuaScriptMgr.GetNetObject(L, 2, typeof(fogs.proto.config.GenerateNewGoodsArgConfig));
			int o = obj.BinarySearch(arg0);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 3)
		{
			List<fogs.proto.config.GenerateNewGoodsArgConfig> obj = (List<fogs.proto.config.GenerateNewGoodsArgConfig>)LuaScriptMgr.GetNetObjectSelf(L, 1, "List<fogs.proto.config.GenerateNewGoodsArgConfig>");
			fogs.proto.config.GenerateNewGoodsArgConfig arg0 = (fogs.proto.config.GenerateNewGoodsArgConfig)LuaScriptMgr.GetNetObject(L, 2, typeof(fogs.proto.config.GenerateNewGoodsArgConfig));
			IComparer<fogs.proto.config.GenerateNewGoodsArgConfig> arg1 = (IComparer<fogs.proto.config.GenerateNewGoodsArgConfig>)LuaScriptMgr.GetNetObject(L, 3, typeof(IComparer<fogs.proto.config.GenerateNewGoodsArgConfig>));
			int o = obj.BinarySearch(arg0,arg1);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 5)
		{
			List<fogs.proto.config.GenerateNewGoodsArgConfig> obj = (List<fogs.proto.config.GenerateNewGoodsArgConfig>)LuaScriptMgr.GetNetObjectSelf(L, 1, "List<fogs.proto.config.GenerateNewGoodsArgConfig>");
			int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
			int arg1 = (int)LuaScriptMgr.GetNumber(L, 3);
			fogs.proto.config.GenerateNewGoodsArgConfig arg2 = (fogs.proto.config.GenerateNewGoodsArgConfig)LuaScriptMgr.GetNetObject(L, 4, typeof(fogs.proto.config.GenerateNewGoodsArgConfig));
			IComparer<fogs.proto.config.GenerateNewGoodsArgConfig> arg3 = (IComparer<fogs.proto.config.GenerateNewGoodsArgConfig>)LuaScriptMgr.GetNetObject(L, 5, typeof(IComparer<fogs.proto.config.GenerateNewGoodsArgConfig>));
			int o = obj.BinarySearch(arg0,arg1,arg2,arg3);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: List<fogs.proto.config.GenerateNewGoodsArgConfig>.BinarySearch");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Clear(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		List<fogs.proto.config.GenerateNewGoodsArgConfig> obj = (List<fogs.proto.config.GenerateNewGoodsArgConfig>)LuaScriptMgr.GetNetObjectSelf(L, 1, "List<fogs.proto.config.GenerateNewGoodsArgConfig>");
		obj.Clear();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Contains(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		List<fogs.proto.config.GenerateNewGoodsArgConfig> obj = (List<fogs.proto.config.GenerateNewGoodsArgConfig>)LuaScriptMgr.GetNetObjectSelf(L, 1, "List<fogs.proto.config.GenerateNewGoodsArgConfig>");
		fogs.proto.config.GenerateNewGoodsArgConfig arg0 = (fogs.proto.config.GenerateNewGoodsArgConfig)LuaScriptMgr.GetNetObject(L, 2, typeof(fogs.proto.config.GenerateNewGoodsArgConfig));
		bool o = obj.Contains(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CopyTo(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2)
		{
			List<fogs.proto.config.GenerateNewGoodsArgConfig> obj = (List<fogs.proto.config.GenerateNewGoodsArgConfig>)LuaScriptMgr.GetNetObjectSelf(L, 1, "List<fogs.proto.config.GenerateNewGoodsArgConfig>");
			fogs.proto.config.GenerateNewGoodsArgConfig[] objs0 = LuaScriptMgr.GetArrayObject<fogs.proto.config.GenerateNewGoodsArgConfig>(L, 2);
			obj.CopyTo(objs0);
			return 0;
		}
		else if (count == 3)
		{
			List<fogs.proto.config.GenerateNewGoodsArgConfig> obj = (List<fogs.proto.config.GenerateNewGoodsArgConfig>)LuaScriptMgr.GetNetObjectSelf(L, 1, "List<fogs.proto.config.GenerateNewGoodsArgConfig>");
			fogs.proto.config.GenerateNewGoodsArgConfig[] objs0 = LuaScriptMgr.GetArrayObject<fogs.proto.config.GenerateNewGoodsArgConfig>(L, 2);
			int arg1 = (int)LuaScriptMgr.GetNumber(L, 3);
			obj.CopyTo(objs0,arg1);
			return 0;
		}
		else if (count == 5)
		{
			List<fogs.proto.config.GenerateNewGoodsArgConfig> obj = (List<fogs.proto.config.GenerateNewGoodsArgConfig>)LuaScriptMgr.GetNetObjectSelf(L, 1, "List<fogs.proto.config.GenerateNewGoodsArgConfig>");
			int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
			fogs.proto.config.GenerateNewGoodsArgConfig[] objs1 = LuaScriptMgr.GetArrayObject<fogs.proto.config.GenerateNewGoodsArgConfig>(L, 3);
			int arg2 = (int)LuaScriptMgr.GetNumber(L, 4);
			int arg3 = (int)LuaScriptMgr.GetNumber(L, 5);
			obj.CopyTo(arg0,objs1,arg2,arg3);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: List<fogs.proto.config.GenerateNewGoodsArgConfig>.CopyTo");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Exists(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		List<fogs.proto.config.GenerateNewGoodsArgConfig> obj = (List<fogs.proto.config.GenerateNewGoodsArgConfig>)LuaScriptMgr.GetNetObjectSelf(L, 1, "List<fogs.proto.config.GenerateNewGoodsArgConfig>");
		Predicate<fogs.proto.config.GenerateNewGoodsArgConfig> arg0 = null;
		LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

		if (funcType2 != LuaTypes.LUA_TFUNCTION)
		{
			 arg0 = (Predicate<fogs.proto.config.GenerateNewGoodsArgConfig>)LuaScriptMgr.GetNetObject(L, 2, typeof(Predicate<fogs.proto.config.GenerateNewGoodsArgConfig>));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 2);
			arg0 = (param0) =>
			{
				int top = func.BeginPCall();
				LuaScriptMgr.PushObject(L, param0);
				func.PCall(top, 1);
				object[] objs = func.PopValues(top);
				func.EndPCall(top);
				return (bool)objs[0];
			};
		}

		bool o = obj.Exists(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Find(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		List<fogs.proto.config.GenerateNewGoodsArgConfig> obj = (List<fogs.proto.config.GenerateNewGoodsArgConfig>)LuaScriptMgr.GetNetObjectSelf(L, 1, "List<fogs.proto.config.GenerateNewGoodsArgConfig>");
		Predicate<fogs.proto.config.GenerateNewGoodsArgConfig> arg0 = null;
		LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

		if (funcType2 != LuaTypes.LUA_TFUNCTION)
		{
			 arg0 = (Predicate<fogs.proto.config.GenerateNewGoodsArgConfig>)LuaScriptMgr.GetNetObject(L, 2, typeof(Predicate<fogs.proto.config.GenerateNewGoodsArgConfig>));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 2);
			arg0 = (param0) =>
			{
				int top = func.BeginPCall();
				LuaScriptMgr.PushObject(L, param0);
				func.PCall(top, 1);
				object[] objs = func.PopValues(top);
				func.EndPCall(top);
				return (bool)objs[0];
			};
		}

		fogs.proto.config.GenerateNewGoodsArgConfig o = obj.Find(arg0);
		LuaScriptMgr.PushObject(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindAll(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		List<fogs.proto.config.GenerateNewGoodsArgConfig> obj = (List<fogs.proto.config.GenerateNewGoodsArgConfig>)LuaScriptMgr.GetNetObjectSelf(L, 1, "List<fogs.proto.config.GenerateNewGoodsArgConfig>");
		Predicate<fogs.proto.config.GenerateNewGoodsArgConfig> arg0 = null;
		LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

		if (funcType2 != LuaTypes.LUA_TFUNCTION)
		{
			 arg0 = (Predicate<fogs.proto.config.GenerateNewGoodsArgConfig>)LuaScriptMgr.GetNetObject(L, 2, typeof(Predicate<fogs.proto.config.GenerateNewGoodsArgConfig>));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 2);
			arg0 = (param0) =>
			{
				int top = func.BeginPCall();
				LuaScriptMgr.PushObject(L, param0);
				func.PCall(top, 1);
				object[] objs = func.PopValues(top);
				func.EndPCall(top);
				return (bool)objs[0];
			};
		}

		List<fogs.proto.config.GenerateNewGoodsArgConfig> o = obj.FindAll(arg0);
		LuaScriptMgr.PushObject(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindIndex(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2)
		{
			List<fogs.proto.config.GenerateNewGoodsArgConfig> obj = (List<fogs.proto.config.GenerateNewGoodsArgConfig>)LuaScriptMgr.GetNetObjectSelf(L, 1, "List<fogs.proto.config.GenerateNewGoodsArgConfig>");
			Predicate<fogs.proto.config.GenerateNewGoodsArgConfig> arg0 = null;
			LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

			if (funcType2 != LuaTypes.LUA_TFUNCTION)
			{
				 arg0 = (Predicate<fogs.proto.config.GenerateNewGoodsArgConfig>)LuaScriptMgr.GetNetObject(L, 2, typeof(Predicate<fogs.proto.config.GenerateNewGoodsArgConfig>));
			}
			else
			{
				LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 2);
				arg0 = (param0) =>
				{
					int top = func.BeginPCall();
					LuaScriptMgr.PushObject(L, param0);
					func.PCall(top, 1);
					object[] objs = func.PopValues(top);
					func.EndPCall(top);
					return (bool)objs[0];
				};
			}

			int o = obj.FindIndex(arg0);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 3)
		{
			List<fogs.proto.config.GenerateNewGoodsArgConfig> obj = (List<fogs.proto.config.GenerateNewGoodsArgConfig>)LuaScriptMgr.GetNetObjectSelf(L, 1, "List<fogs.proto.config.GenerateNewGoodsArgConfig>");
			int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
			Predicate<fogs.proto.config.GenerateNewGoodsArgConfig> arg1 = null;
			LuaTypes funcType3 = LuaDLL.lua_type(L, 3);

			if (funcType3 != LuaTypes.LUA_TFUNCTION)
			{
				 arg1 = (Predicate<fogs.proto.config.GenerateNewGoodsArgConfig>)LuaScriptMgr.GetNetObject(L, 3, typeof(Predicate<fogs.proto.config.GenerateNewGoodsArgConfig>));
			}
			else
			{
				LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 3);
				arg1 = (param0) =>
				{
					int top = func.BeginPCall();
					LuaScriptMgr.PushObject(L, param0);
					func.PCall(top, 1);
					object[] objs = func.PopValues(top);
					func.EndPCall(top);
					return (bool)objs[0];
				};
			}

			int o = obj.FindIndex(arg0,arg1);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 4)
		{
			List<fogs.proto.config.GenerateNewGoodsArgConfig> obj = (List<fogs.proto.config.GenerateNewGoodsArgConfig>)LuaScriptMgr.GetNetObjectSelf(L, 1, "List<fogs.proto.config.GenerateNewGoodsArgConfig>");
			int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
			int arg1 = (int)LuaScriptMgr.GetNumber(L, 3);
			Predicate<fogs.proto.config.GenerateNewGoodsArgConfig> arg2 = null;
			LuaTypes funcType4 = LuaDLL.lua_type(L, 4);

			if (funcType4 != LuaTypes.LUA_TFUNCTION)
			{
				 arg2 = (Predicate<fogs.proto.config.GenerateNewGoodsArgConfig>)LuaScriptMgr.GetNetObject(L, 4, typeof(Predicate<fogs.proto.config.GenerateNewGoodsArgConfig>));
			}
			else
			{
				LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 4);
				arg2 = (param0) =>
				{
					int top = func.BeginPCall();
					LuaScriptMgr.PushObject(L, param0);
					func.PCall(top, 1);
					object[] objs = func.PopValues(top);
					func.EndPCall(top);
					return (bool)objs[0];
				};
			}

			int o = obj.FindIndex(arg0,arg1,arg2);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: List<fogs.proto.config.GenerateNewGoodsArgConfig>.FindIndex");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindLast(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		List<fogs.proto.config.GenerateNewGoodsArgConfig> obj = (List<fogs.proto.config.GenerateNewGoodsArgConfig>)LuaScriptMgr.GetNetObjectSelf(L, 1, "List<fogs.proto.config.GenerateNewGoodsArgConfig>");
		Predicate<fogs.proto.config.GenerateNewGoodsArgConfig> arg0 = null;
		LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

		if (funcType2 != LuaTypes.LUA_TFUNCTION)
		{
			 arg0 = (Predicate<fogs.proto.config.GenerateNewGoodsArgConfig>)LuaScriptMgr.GetNetObject(L, 2, typeof(Predicate<fogs.proto.config.GenerateNewGoodsArgConfig>));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 2);
			arg0 = (param0) =>
			{
				int top = func.BeginPCall();
				LuaScriptMgr.PushObject(L, param0);
				func.PCall(top, 1);
				object[] objs = func.PopValues(top);
				func.EndPCall(top);
				return (bool)objs[0];
			};
		}

		fogs.proto.config.GenerateNewGoodsArgConfig o = obj.FindLast(arg0);
		LuaScriptMgr.PushObject(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindLastIndex(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2)
		{
			List<fogs.proto.config.GenerateNewGoodsArgConfig> obj = (List<fogs.proto.config.GenerateNewGoodsArgConfig>)LuaScriptMgr.GetNetObjectSelf(L, 1, "List<fogs.proto.config.GenerateNewGoodsArgConfig>");
			Predicate<fogs.proto.config.GenerateNewGoodsArgConfig> arg0 = null;
			LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

			if (funcType2 != LuaTypes.LUA_TFUNCTION)
			{
				 arg0 = (Predicate<fogs.proto.config.GenerateNewGoodsArgConfig>)LuaScriptMgr.GetNetObject(L, 2, typeof(Predicate<fogs.proto.config.GenerateNewGoodsArgConfig>));
			}
			else
			{
				LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 2);
				arg0 = (param0) =>
				{
					int top = func.BeginPCall();
					LuaScriptMgr.PushObject(L, param0);
					func.PCall(top, 1);
					object[] objs = func.PopValues(top);
					func.EndPCall(top);
					return (bool)objs[0];
				};
			}

			int o = obj.FindLastIndex(arg0);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 3)
		{
			List<fogs.proto.config.GenerateNewGoodsArgConfig> obj = (List<fogs.proto.config.GenerateNewGoodsArgConfig>)LuaScriptMgr.GetNetObjectSelf(L, 1, "List<fogs.proto.config.GenerateNewGoodsArgConfig>");
			int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
			Predicate<fogs.proto.config.GenerateNewGoodsArgConfig> arg1 = null;
			LuaTypes funcType3 = LuaDLL.lua_type(L, 3);

			if (funcType3 != LuaTypes.LUA_TFUNCTION)
			{
				 arg1 = (Predicate<fogs.proto.config.GenerateNewGoodsArgConfig>)LuaScriptMgr.GetNetObject(L, 3, typeof(Predicate<fogs.proto.config.GenerateNewGoodsArgConfig>));
			}
			else
			{
				LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 3);
				arg1 = (param0) =>
				{
					int top = func.BeginPCall();
					LuaScriptMgr.PushObject(L, param0);
					func.PCall(top, 1);
					object[] objs = func.PopValues(top);
					func.EndPCall(top);
					return (bool)objs[0];
				};
			}

			int o = obj.FindLastIndex(arg0,arg1);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 4)
		{
			List<fogs.proto.config.GenerateNewGoodsArgConfig> obj = (List<fogs.proto.config.GenerateNewGoodsArgConfig>)LuaScriptMgr.GetNetObjectSelf(L, 1, "List<fogs.proto.config.GenerateNewGoodsArgConfig>");
			int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
			int arg1 = (int)LuaScriptMgr.GetNumber(L, 3);
			Predicate<fogs.proto.config.GenerateNewGoodsArgConfig> arg2 = null;
			LuaTypes funcType4 = LuaDLL.lua_type(L, 4);

			if (funcType4 != LuaTypes.LUA_TFUNCTION)
			{
				 arg2 = (Predicate<fogs.proto.config.GenerateNewGoodsArgConfig>)LuaScriptMgr.GetNetObject(L, 4, typeof(Predicate<fogs.proto.config.GenerateNewGoodsArgConfig>));
			}
			else
			{
				LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 4);
				arg2 = (param0) =>
				{
					int top = func.BeginPCall();
					LuaScriptMgr.PushObject(L, param0);
					func.PCall(top, 1);
					object[] objs = func.PopValues(top);
					func.EndPCall(top);
					return (bool)objs[0];
				};
			}

			int o = obj.FindLastIndex(arg0,arg1,arg2);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: List<fogs.proto.config.GenerateNewGoodsArgConfig>.FindLastIndex");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ForEach(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		List<fogs.proto.config.GenerateNewGoodsArgConfig> obj = (List<fogs.proto.config.GenerateNewGoodsArgConfig>)LuaScriptMgr.GetNetObjectSelf(L, 1, "List<fogs.proto.config.GenerateNewGoodsArgConfig>");
		Action<fogs.proto.config.GenerateNewGoodsArgConfig> arg0 = null;
		LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

		if (funcType2 != LuaTypes.LUA_TFUNCTION)
		{
			 arg0 = (Action<fogs.proto.config.GenerateNewGoodsArgConfig>)LuaScriptMgr.GetNetObject(L, 2, typeof(Action<fogs.proto.config.GenerateNewGoodsArgConfig>));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 2);
			arg0 = (param0) =>
			{
				int top = func.BeginPCall();
				LuaScriptMgr.PushObject(L, param0);
				func.PCall(top, 1);
				func.EndPCall(top);
			};
		}

		obj.ForEach(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetEnumerator(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		List<fogs.proto.config.GenerateNewGoodsArgConfig> obj = (List<fogs.proto.config.GenerateNewGoodsArgConfig>)LuaScriptMgr.GetNetObjectSelf(L, 1, "List<fogs.proto.config.GenerateNewGoodsArgConfig>");
		List<fogs.proto.config.GenerateNewGoodsArgConfig>.Enumerator o = obj.GetEnumerator();
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRange(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		List<fogs.proto.config.GenerateNewGoodsArgConfig> obj = (List<fogs.proto.config.GenerateNewGoodsArgConfig>)LuaScriptMgr.GetNetObjectSelf(L, 1, "List<fogs.proto.config.GenerateNewGoodsArgConfig>");
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
		int arg1 = (int)LuaScriptMgr.GetNumber(L, 3);
		List<fogs.proto.config.GenerateNewGoodsArgConfig> o = obj.GetRange(arg0,arg1);
		LuaScriptMgr.PushObject(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IndexOf(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2)
		{
			List<fogs.proto.config.GenerateNewGoodsArgConfig> obj = (List<fogs.proto.config.GenerateNewGoodsArgConfig>)LuaScriptMgr.GetNetObjectSelf(L, 1, "List<fogs.proto.config.GenerateNewGoodsArgConfig>");
			fogs.proto.config.GenerateNewGoodsArgConfig arg0 = (fogs.proto.config.GenerateNewGoodsArgConfig)LuaScriptMgr.GetNetObject(L, 2, typeof(fogs.proto.config.GenerateNewGoodsArgConfig));
			int o = obj.IndexOf(arg0);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 3)
		{
			List<fogs.proto.config.GenerateNewGoodsArgConfig> obj = (List<fogs.proto.config.GenerateNewGoodsArgConfig>)LuaScriptMgr.GetNetObjectSelf(L, 1, "List<fogs.proto.config.GenerateNewGoodsArgConfig>");
			fogs.proto.config.GenerateNewGoodsArgConfig arg0 = (fogs.proto.config.GenerateNewGoodsArgConfig)LuaScriptMgr.GetNetObject(L, 2, typeof(fogs.proto.config.GenerateNewGoodsArgConfig));
			int arg1 = (int)LuaScriptMgr.GetNumber(L, 3);
			int o = obj.IndexOf(arg0,arg1);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 4)
		{
			List<fogs.proto.config.GenerateNewGoodsArgConfig> obj = (List<fogs.proto.config.GenerateNewGoodsArgConfig>)LuaScriptMgr.GetNetObjectSelf(L, 1, "List<fogs.proto.config.GenerateNewGoodsArgConfig>");
			fogs.proto.config.GenerateNewGoodsArgConfig arg0 = (fogs.proto.config.GenerateNewGoodsArgConfig)LuaScriptMgr.GetNetObject(L, 2, typeof(fogs.proto.config.GenerateNewGoodsArgConfig));
			int arg1 = (int)LuaScriptMgr.GetNumber(L, 3);
			int arg2 = (int)LuaScriptMgr.GetNumber(L, 4);
			int o = obj.IndexOf(arg0,arg1,arg2);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: List<fogs.proto.config.GenerateNewGoodsArgConfig>.IndexOf");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Insert(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		List<fogs.proto.config.GenerateNewGoodsArgConfig> obj = (List<fogs.proto.config.GenerateNewGoodsArgConfig>)LuaScriptMgr.GetNetObjectSelf(L, 1, "List<fogs.proto.config.GenerateNewGoodsArgConfig>");
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
		fogs.proto.config.GenerateNewGoodsArgConfig arg1 = (fogs.proto.config.GenerateNewGoodsArgConfig)LuaScriptMgr.GetNetObject(L, 3, typeof(fogs.proto.config.GenerateNewGoodsArgConfig));
		obj.Insert(arg0,arg1);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int InsertRange(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		List<fogs.proto.config.GenerateNewGoodsArgConfig> obj = (List<fogs.proto.config.GenerateNewGoodsArgConfig>)LuaScriptMgr.GetNetObjectSelf(L, 1, "List<fogs.proto.config.GenerateNewGoodsArgConfig>");
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
		IEnumerable<fogs.proto.config.GenerateNewGoodsArgConfig> arg1 = (IEnumerable<fogs.proto.config.GenerateNewGoodsArgConfig>)LuaScriptMgr.GetNetObject(L, 3, typeof(IEnumerable<fogs.proto.config.GenerateNewGoodsArgConfig>));
		obj.InsertRange(arg0,arg1);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LastIndexOf(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2)
		{
			List<fogs.proto.config.GenerateNewGoodsArgConfig> obj = (List<fogs.proto.config.GenerateNewGoodsArgConfig>)LuaScriptMgr.GetNetObjectSelf(L, 1, "List<fogs.proto.config.GenerateNewGoodsArgConfig>");
			fogs.proto.config.GenerateNewGoodsArgConfig arg0 = (fogs.proto.config.GenerateNewGoodsArgConfig)LuaScriptMgr.GetNetObject(L, 2, typeof(fogs.proto.config.GenerateNewGoodsArgConfig));
			int o = obj.LastIndexOf(arg0);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 3)
		{
			List<fogs.proto.config.GenerateNewGoodsArgConfig> obj = (List<fogs.proto.config.GenerateNewGoodsArgConfig>)LuaScriptMgr.GetNetObjectSelf(L, 1, "List<fogs.proto.config.GenerateNewGoodsArgConfig>");
			fogs.proto.config.GenerateNewGoodsArgConfig arg0 = (fogs.proto.config.GenerateNewGoodsArgConfig)LuaScriptMgr.GetNetObject(L, 2, typeof(fogs.proto.config.GenerateNewGoodsArgConfig));
			int arg1 = (int)LuaScriptMgr.GetNumber(L, 3);
			int o = obj.LastIndexOf(arg0,arg1);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else if (count == 4)
		{
			List<fogs.proto.config.GenerateNewGoodsArgConfig> obj = (List<fogs.proto.config.GenerateNewGoodsArgConfig>)LuaScriptMgr.GetNetObjectSelf(L, 1, "List<fogs.proto.config.GenerateNewGoodsArgConfig>");
			fogs.proto.config.GenerateNewGoodsArgConfig arg0 = (fogs.proto.config.GenerateNewGoodsArgConfig)LuaScriptMgr.GetNetObject(L, 2, typeof(fogs.proto.config.GenerateNewGoodsArgConfig));
			int arg1 = (int)LuaScriptMgr.GetNumber(L, 3);
			int arg2 = (int)LuaScriptMgr.GetNumber(L, 4);
			int o = obj.LastIndexOf(arg0,arg1,arg2);
			LuaScriptMgr.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: List<fogs.proto.config.GenerateNewGoodsArgConfig>.LastIndexOf");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Remove(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		List<fogs.proto.config.GenerateNewGoodsArgConfig> obj = (List<fogs.proto.config.GenerateNewGoodsArgConfig>)LuaScriptMgr.GetNetObjectSelf(L, 1, "List<fogs.proto.config.GenerateNewGoodsArgConfig>");
		fogs.proto.config.GenerateNewGoodsArgConfig arg0 = (fogs.proto.config.GenerateNewGoodsArgConfig)LuaScriptMgr.GetNetObject(L, 2, typeof(fogs.proto.config.GenerateNewGoodsArgConfig));
		bool o = obj.Remove(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveAll(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		List<fogs.proto.config.GenerateNewGoodsArgConfig> obj = (List<fogs.proto.config.GenerateNewGoodsArgConfig>)LuaScriptMgr.GetNetObjectSelf(L, 1, "List<fogs.proto.config.GenerateNewGoodsArgConfig>");
		Predicate<fogs.proto.config.GenerateNewGoodsArgConfig> arg0 = null;
		LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

		if (funcType2 != LuaTypes.LUA_TFUNCTION)
		{
			 arg0 = (Predicate<fogs.proto.config.GenerateNewGoodsArgConfig>)LuaScriptMgr.GetNetObject(L, 2, typeof(Predicate<fogs.proto.config.GenerateNewGoodsArgConfig>));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 2);
			arg0 = (param0) =>
			{
				int top = func.BeginPCall();
				LuaScriptMgr.PushObject(L, param0);
				func.PCall(top, 1);
				object[] objs = func.PopValues(top);
				func.EndPCall(top);
				return (bool)objs[0];
			};
		}

		int o = obj.RemoveAll(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveAt(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		List<fogs.proto.config.GenerateNewGoodsArgConfig> obj = (List<fogs.proto.config.GenerateNewGoodsArgConfig>)LuaScriptMgr.GetNetObjectSelf(L, 1, "List<fogs.proto.config.GenerateNewGoodsArgConfig>");
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
		obj.RemoveAt(arg0);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveRange(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		List<fogs.proto.config.GenerateNewGoodsArgConfig> obj = (List<fogs.proto.config.GenerateNewGoodsArgConfig>)LuaScriptMgr.GetNetObjectSelf(L, 1, "List<fogs.proto.config.GenerateNewGoodsArgConfig>");
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
		int arg1 = (int)LuaScriptMgr.GetNumber(L, 3);
		obj.RemoveRange(arg0,arg1);
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Reverse(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 1)
		{
			List<fogs.proto.config.GenerateNewGoodsArgConfig> obj = (List<fogs.proto.config.GenerateNewGoodsArgConfig>)LuaScriptMgr.GetNetObjectSelf(L, 1, "List<fogs.proto.config.GenerateNewGoodsArgConfig>");
			obj.Reverse();
			return 0;
		}
		else if (count == 3)
		{
			List<fogs.proto.config.GenerateNewGoodsArgConfig> obj = (List<fogs.proto.config.GenerateNewGoodsArgConfig>)LuaScriptMgr.GetNetObjectSelf(L, 1, "List<fogs.proto.config.GenerateNewGoodsArgConfig>");
			int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
			int arg1 = (int)LuaScriptMgr.GetNumber(L, 3);
			obj.Reverse(arg0,arg1);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: List<fogs.proto.config.GenerateNewGoodsArgConfig>.Reverse");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Sort(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 1)
		{
			List<fogs.proto.config.GenerateNewGoodsArgConfig> obj = (List<fogs.proto.config.GenerateNewGoodsArgConfig>)LuaScriptMgr.GetNetObjectSelf(L, 1, "List<fogs.proto.config.GenerateNewGoodsArgConfig>");
			obj.Sort();
			return 0;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(List<fogs.proto.config.GenerateNewGoodsArgConfig>), typeof(Comparison<fogs.proto.config.GenerateNewGoodsArgConfig>)))
		{
			List<fogs.proto.config.GenerateNewGoodsArgConfig> obj = (List<fogs.proto.config.GenerateNewGoodsArgConfig>)LuaScriptMgr.GetNetObjectSelf(L, 1, "List<fogs.proto.config.GenerateNewGoodsArgConfig>");
			Comparison<fogs.proto.config.GenerateNewGoodsArgConfig> arg0 = null;
			LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

			if (funcType2 != LuaTypes.LUA_TFUNCTION)
			{
				 arg0 = (Comparison<fogs.proto.config.GenerateNewGoodsArgConfig>)LuaScriptMgr.GetLuaObject(L, 2);
			}
			else
			{
				LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 2);
				arg0 = (param0, param1) =>
				{
					int top = func.BeginPCall();
					LuaScriptMgr.PushObject(L, param0);
					LuaScriptMgr.PushObject(L, param1);
					func.PCall(top, 2);
					object[] objs = func.PopValues(top);
					func.EndPCall(top);
					return (int)objs[0];
				};
			}

			obj.Sort(arg0);
			return 0;
		}
		else if (count == 2 && LuaScriptMgr.CheckTypes(L, 1, typeof(List<fogs.proto.config.GenerateNewGoodsArgConfig>), typeof(IComparer<fogs.proto.config.GenerateNewGoodsArgConfig>)))
		{
			List<fogs.proto.config.GenerateNewGoodsArgConfig> obj = (List<fogs.proto.config.GenerateNewGoodsArgConfig>)LuaScriptMgr.GetNetObjectSelf(L, 1, "List<fogs.proto.config.GenerateNewGoodsArgConfig>");
			IComparer<fogs.proto.config.GenerateNewGoodsArgConfig> arg0 = (IComparer<fogs.proto.config.GenerateNewGoodsArgConfig>)LuaScriptMgr.GetLuaObject(L, 2);
			obj.Sort(arg0);
			return 0;
		}
		else if (count == 4)
		{
			List<fogs.proto.config.GenerateNewGoodsArgConfig> obj = (List<fogs.proto.config.GenerateNewGoodsArgConfig>)LuaScriptMgr.GetNetObjectSelf(L, 1, "List<fogs.proto.config.GenerateNewGoodsArgConfig>");
			int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
			int arg1 = (int)LuaScriptMgr.GetNumber(L, 3);
			IComparer<fogs.proto.config.GenerateNewGoodsArgConfig> arg2 = (IComparer<fogs.proto.config.GenerateNewGoodsArgConfig>)LuaScriptMgr.GetNetObject(L, 4, typeof(IComparer<fogs.proto.config.GenerateNewGoodsArgConfig>));
			obj.Sort(arg0,arg1,arg2);
			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: List<fogs.proto.config.GenerateNewGoodsArgConfig>.Sort");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ToArray(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		List<fogs.proto.config.GenerateNewGoodsArgConfig> obj = (List<fogs.proto.config.GenerateNewGoodsArgConfig>)LuaScriptMgr.GetNetObjectSelf(L, 1, "List<fogs.proto.config.GenerateNewGoodsArgConfig>");
		fogs.proto.config.GenerateNewGoodsArgConfig[] o = obj.ToArray();
		LuaScriptMgr.PushArray(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TrimExcess(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 1);
		List<fogs.proto.config.GenerateNewGoodsArgConfig> obj = (List<fogs.proto.config.GenerateNewGoodsArgConfig>)LuaScriptMgr.GetNetObjectSelf(L, 1, "List<fogs.proto.config.GenerateNewGoodsArgConfig>");
		obj.TrimExcess();
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TrueForAll(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		List<fogs.proto.config.GenerateNewGoodsArgConfig> obj = (List<fogs.proto.config.GenerateNewGoodsArgConfig>)LuaScriptMgr.GetNetObjectSelf(L, 1, "List<fogs.proto.config.GenerateNewGoodsArgConfig>");
		Predicate<fogs.proto.config.GenerateNewGoodsArgConfig> arg0 = null;
		LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

		if (funcType2 != LuaTypes.LUA_TFUNCTION)
		{
			 arg0 = (Predicate<fogs.proto.config.GenerateNewGoodsArgConfig>)LuaScriptMgr.GetNetObject(L, 2, typeof(Predicate<fogs.proto.config.GenerateNewGoodsArgConfig>));
		}
		else
		{
			LuaFunction func = LuaScriptMgr.GetLuaFunction(L, 2);
			arg0 = (param0) =>
			{
				int top = func.BeginPCall();
				LuaScriptMgr.PushObject(L, param0);
				func.PCall(top, 1);
				object[] objs = func.PopValues(top);
				func.EndPCall(top);
				return (bool)objs[0];
			};
		}

		bool o = obj.TrueForAll(arg0);
		LuaScriptMgr.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Item(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		List<fogs.proto.config.GenerateNewGoodsArgConfig> obj = (List<fogs.proto.config.GenerateNewGoodsArgConfig>)LuaScriptMgr.GetNetObjectSelf(L, 1, "List<fogs.proto.config.GenerateNewGoodsArgConfig>");
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
		fogs.proto.config.GenerateNewGoodsArgConfig o = obj[arg0];
		LuaScriptMgr.PushObject(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Item(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 3);
		List<fogs.proto.config.GenerateNewGoodsArgConfig> obj = (List<fogs.proto.config.GenerateNewGoodsArgConfig>)LuaScriptMgr.GetNetObjectSelf(L, 1, "List<fogs.proto.config.GenerateNewGoodsArgConfig>");
		int arg0 = (int)LuaScriptMgr.GetNumber(L, 2);
		fogs.proto.config.GenerateNewGoodsArgConfig arg1 = (fogs.proto.config.GenerateNewGoodsArgConfig)LuaScriptMgr.GetNetObject(L, 3, typeof(fogs.proto.config.GenerateNewGoodsArgConfig));
		obj[arg0] = arg1;
		return 0;
	}
}

