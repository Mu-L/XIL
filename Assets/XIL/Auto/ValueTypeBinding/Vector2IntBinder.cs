﻿#if USE_HOT
using UnityEngine;
using System.Collections.Generic;
using ILRuntime.Other;
using System;
using System.Reflection;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.CLR.Method;
using ILRuntime.CLR.TypeSystem;
using ILRuntime.Runtime.Stack;
using System.Numerics;

namespace ILRuntime.Runtime.Generated
{
    public unsafe class Vector2IntBinder : ValueTypeBinder<Vector2Int>
    {
        public override unsafe void AssignFromStack(ref Vector2Int ins, StackObject* ptr, IList<object> mStack)
        {
            var v = ILIntepreter.Minus(ptr, 1);
            ins.x = v->Value;
            v = ILIntepreter.Minus(ptr, 2);
            ins.y = v->Value;
        }

        public override unsafe void CopyValueTypeToStack(ref Vector2Int ins, StackObject* ptr, IList<object> mStack)
        {
            var v = ILIntepreter.Minus(ptr, 1);
            v->Value = ins.x;
            v = ILIntepreter.Minus(ptr, 2);
            v->Value = ins.y;
        }

        public override void RegisterCLRRedirection(ILRuntime.Runtime.Enviorment.AppDomain appdomain)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(Vector2Int);
            args = new Type[] { typeof(int), typeof(int) };
            method = type.GetConstructor(flag, null, args, null);
            appdomain.RegisterCLRMethodRedirection(method, NewVector2Int);

            args = new Type[] { typeof(Vector2Int), typeof(Vector2Int) };
            method = type.GetMethod("op_Addition", flag, null, args, null);
            appdomain.RegisterCLRMethodRedirection(method, Vector2Int_Add);

            args = new Type[] { typeof(Vector2Int), typeof(Vector2Int) };
            method = type.GetMethod("op_Subtraction", flag, null, args, null);
            appdomain.RegisterCLRMethodRedirection(method, Vector2Int_Subtraction);

            args = new Type[] { typeof(int), typeof(Vector2Int) };
            method = type.GetMethod("op_Multiply", flag, null, args, null);
            appdomain.RegisterCLRMethodRedirection(method, Vector2Int_Multiply);

            args = new Type[] { typeof(Vector2Int), typeof(int) };
            method = type.GetMethod("op_Multiply", flag, null, args, null);
            appdomain.RegisterCLRMethodRedirection(method, Vector2Int_Multiply2);

            args = new Type[] { typeof(Vector2Int), typeof(Vector2Int) };
            method = type.GetMethod("op_Multiply", flag, null, args, null);
            appdomain.RegisterCLRMethodRedirection(method, Vector2Int_Multiply3);

            args = new Type[] { typeof(Vector2Int), typeof(int) };
            method = type.GetMethod("op_Division", flag, null, args, null);
            appdomain.RegisterCLRMethodRedirection(method, Vector2Int_Division);

            args = new Type[] { typeof(Vector2Int) };
            method = type.GetMethod("op_UnaryNegation", flag, null, args, null);
            appdomain.RegisterCLRMethodRedirection(method, Vector2Int_Negate);

            args = new Type[] { typeof(Vector2Int), typeof(Vector2Int) };
            method = type.GetMethod("op_Equality", flag, null, args, null);
            appdomain.RegisterCLRMethodRedirection(method, Vector2Int_Equality);

            args = new Type[] { typeof(Vector2Int), typeof(Vector2Int) };
            method = type.GetMethod("op_Inequality", flag, null, args, null);
            appdomain.RegisterCLRMethodRedirection(method, Vector2Int_Inequality);

            args = new Type[] { typeof(Vector2Int), typeof(Vector2Int) };
            method = type.GetMethod("Distance", flag, null, args, null);
            appdomain.RegisterCLRMethodRedirection(method, Vector2Int_Distance);

            args = new Type[] { };
            method = type.GetMethod("get_magnitude", flag, null, args, null);
            appdomain.RegisterCLRMethodRedirection(method, Get_Magnitude);

            args = new Type[] { };
            method = type.GetMethod("get_sqrMagnitude", flag, null, args, null);
            appdomain.RegisterCLRMethodRedirection(method, Get_SqrMagnitude);

            args = new Type[] { };
            method = type.GetMethod("get_one", flag, null, args, null);
            appdomain.RegisterCLRMethodRedirection(method, Get_One);

            args = new Type[] { };
            method = type.GetMethod("get_zero", flag, null, args, null);
            appdomain.RegisterCLRMethodRedirection(method, Get_Zero);

            args = new Type[] { };
            method = type.GetMethod("get_down", flag, null, args, null);
            appdomain.RegisterCLRMethodRedirection(method, Get_Down);

            args = new Type[] { };
            method = type.GetMethod("get_up", flag, null, args, null);
            appdomain.RegisterCLRMethodRedirection(method, Get_Up);

            args = new Type[] { };
            method = type.GetMethod("get_left", flag, null, args, null);
            appdomain.RegisterCLRMethodRedirection(method, Get_Left);

            args = new Type[] { };
            method = type.GetMethod("get_right", flag, null, args, null);
            appdomain.RegisterCLRMethodRedirection(method, Get_Right);
        }

        StackObject* Vector2Int_Add(ILIntepreter intp, StackObject* esp, IList<object> mStack, CLRMethod method, bool isNewObj)
        {
            var ret = ILIntepreter.Minus(esp, 2);
            var ptr = ILIntepreter.Minus(esp, 1);

            Vector2Int left, right;
            ParseVector2Int(out right, intp, ptr, mStack);

            ptr = ILIntepreter.Minus(esp, 2);
            ParseVector2Int(out left, intp, ptr, mStack);

            var res = left + right;
            PushVector2Int(ref res, intp, ret, mStack);

            return ret + 1;
        }

        StackObject* Vector2Int_Subtraction(ILIntepreter intp, StackObject* esp, IList<object> mStack, CLRMethod method, bool isNewObj)
        {
            var ret = ILIntepreter.Minus(esp, 2);
            var ptr = ILIntepreter.Minus(esp, 1);

            Vector2Int left, right;
            ParseVector2Int(out right, intp, ptr, mStack);

            ptr = ILIntepreter.Minus(esp, 2);
            ParseVector2Int(out left, intp, ptr, mStack);

            var res = left - right;
            PushVector2Int(ref res, intp, ret, mStack);

            return ret + 1;
        }

        StackObject* Vector2Int_Multiply(ILIntepreter intp, StackObject* esp, IList<object> mStack, CLRMethod method, bool isNewObj)
        {
            var ret = ILIntepreter.Minus(esp, 2);

            var ptr = ILIntepreter.Minus(esp, 1);
            var b = ILIntepreter.GetObjectAndResolveReference(ptr);

            int val = b->Value;

            Vector2Int vec;

            ptr = ILIntepreter.Minus(esp, 2);
            ParseVector2Int(out vec, intp, ptr, mStack);

            vec = vec * val;
            PushVector2Int(ref vec, intp, ret, mStack);

            return ret + 1;
        }

        StackObject* Vector2Int_Multiply2(ILIntepreter intp, StackObject* esp, IList<object> mStack, CLRMethod method, bool isNewObj)
        {
            var ret = ILIntepreter.Minus(esp, 2);
            Vector2Int vec;

            var ptr = ILIntepreter.Minus(esp, 1);
            ParseVector2Int(out vec, intp, ptr, mStack);

            ptr = ILIntepreter.Minus(esp, 2);
            var b = ILIntepreter.GetObjectAndResolveReference(ptr);

            int val = b->Value;

            vec = val * vec;
            PushVector2Int(ref vec, intp, ret, mStack);

            return ret + 1;
        }

        StackObject* Vector2Int_Multiply3(ILIntepreter intp, StackObject* esp, IList<object> mStack, CLRMethod method, bool isNewObj)
        {
            var ret = ILIntepreter.Minus(esp, 2);
            Vector2Int left, right;

            var ptr = ILIntepreter.Minus(esp, 1);
            ParseVector2Int(out left, intp, ptr, mStack);

            ptr = ILIntepreter.Minus(esp, 2);
            ParseVector2Int(out right, intp, ptr, mStack);

            left = left * right;
            PushVector2Int(ref left, intp, ret, mStack);

            return ret + 1;
        }

        StackObject* Vector2Int_Division(ILIntepreter intp, StackObject* esp, IList<object> mStack, CLRMethod method, bool isNewObj)
        {
            var ret = ILIntepreter.Minus(esp, 2);

            var ptr = ILIntepreter.Minus(esp, 1);
            var b = ILIntepreter.GetObjectAndResolveReference(ptr);

            int val = b->Value;

            Vector2Int vec;

            ptr = ILIntepreter.Minus(esp, 2);
            ParseVector2Int(out vec, intp, ptr, mStack);

            vec = vec / val;
            PushVector2Int(ref vec, intp, ret, mStack);

            return ret + 1;
        }

        StackObject* Vector2Int_Negate(ILIntepreter intp, StackObject* esp, IList<object> mStack, CLRMethod method, bool isNewObj)
        {
            var ret = ILIntepreter.Minus(esp, 1);

            var ptr = ILIntepreter.Minus(esp, 1);
            Vector2Int vec;

            ptr = ILIntepreter.Minus(esp, 1);
            ParseVector2Int(out vec, intp, ptr, mStack);

            vec = -vec;
            PushVector2Int(ref vec, intp, ret, mStack);

            return ret + 1;
        }

        StackObject* Vector2Int_Equality(ILIntepreter intp, StackObject* esp, IList<object> mStack, CLRMethod method, bool isNewObj)
        {
            var ret = ILIntepreter.Minus(esp, 2);
            var ptr = ILIntepreter.Minus(esp, 1);

            Vector2Int left, right;
            ParseVector2Int(out right, intp, ptr, mStack);

            ptr = ILIntepreter.Minus(esp, 2);
            ParseVector2Int(out left, intp, ptr, mStack);

            var res = left == right;

            ret->ObjectType = ObjectTypes.Integer;
            ret->Value = res ? 1 : 0;
            return ret + 1;
        }

        StackObject* Vector2Int_Inequality(ILIntepreter intp, StackObject* esp, IList<object> mStack, CLRMethod method, bool isNewObj)
        {
            var ret = ILIntepreter.Minus(esp, 2);
            var ptr = ILIntepreter.Minus(esp, 1);

            Vector2Int left, right;
            ParseVector2Int(out right, intp, ptr, mStack);

            ptr = ILIntepreter.Minus(esp, 2);
            ParseVector2Int(out left, intp, ptr, mStack);

            var res = left != right;

            ret->ObjectType = ObjectTypes.Integer;
            ret->Value = res ? 1 : 0;
            return ret + 1;
        }

        StackObject* Vector2Int_Distance(ILIntepreter intp, StackObject* esp, IList<object> mStack, CLRMethod method, bool isNewObj)
        {
            var ret = ILIntepreter.Minus(esp, 2);
            var ptr = ILIntepreter.Minus(esp, 1);

            Vector2Int left, right;
            ParseVector2Int(out right, intp, ptr, mStack);

            ptr = ILIntepreter.Minus(esp, 2);
            ParseVector2Int(out left, intp, ptr, mStack);

            var res = Vector2Int.Distance(left, right);

            ret->ObjectType = ObjectTypes.Float;
            *(float*)&ret->Value = res;
            return ret + 1;
        }

        StackObject* NewVector2Int(ILIntepreter intp, StackObject* esp, IList<object> mStack, CLRMethod method, bool isNewObj)
        {
            StackObject* ret;
            if (isNewObj)
            {
                ret = ILIntepreter.Minus(esp, 1);

                StackObject* ptr = null;
                ptr = ILIntepreter.Minus(esp, 1); var y = ptr->Value;
                ptr = ILIntepreter.Minus(esp, 2); var x = ptr->Value;

                Vector2Int vec = new Vector2Int(x, y);
                PushVector2Int(ref vec, intp, ILIntepreter.Minus(esp, 2), mStack);
            }
            else
            {
                ret = ILIntepreter.Minus(esp, 3);
                var instance = ILIntepreter.GetObjectAndResolveReference(ret);
                var dst = *(StackObject**)&instance->Value;
                var f = ILIntepreter.Minus(dst, 1);
                var v = ILIntepreter.Minus(esp, 2);
                *f = *v;

                f = ILIntepreter.Minus(dst, 2);
                v = ILIntepreter.Minus(esp, 1);
                *f = *v;
            }
            return ret;
        }

        StackObject* Get_Magnitude(ILIntepreter intp, StackObject* esp, IList<object> mStack, CLRMethod method, bool isNewObj)
        {
            var ret = ILIntepreter.Minus(esp, 1);

            var ptr = ILIntepreter.Minus(esp, 1);
            Vector2Int vec;
            ParseVector2Int(out vec, intp, ptr, mStack);

            float res = vec.magnitude;

            ret->ObjectType = ObjectTypes.Float;
            *(float*)&ret->Value = res;
            return ret + 1;
        }

        StackObject* Get_SqrMagnitude(ILIntepreter intp, StackObject* esp, IList<object> mStack, CLRMethod method, bool isNewObj)
        {
            var ret = ILIntepreter.Minus(esp, 1);

            var ptr = ILIntepreter.Minus(esp, 1);
            Vector2Int vec;
            ParseVector2Int(out vec, intp, ptr, mStack);

            int res = vec.sqrMagnitude;

            ret->ObjectType = ObjectTypes.Float;
            ret->Value = res;
            return ret + 1;
        }

        StackObject* Get_One(ILIntepreter intp, StackObject* esp, IList<object> mStack, CLRMethod method, bool isNewObj)
        {
            var ret = esp;
            var res = Vector2Int.one;
            PushVector2Int(ref res, intp, ret, mStack);
            return ret + 1;
        }

        StackObject* Get_Zero(ILIntepreter intp, StackObject* esp, IList<object> mStack, CLRMethod method, bool isNewObj)
        {
            var ret = esp;
            var res = Vector2Int.zero;
            PushVector2Int(ref res, intp, ret, mStack);
            return ret + 1;
        }

        StackObject* Get_Down(ILIntepreter intp, StackObject* esp, IList<object> mStack, CLRMethod method, bool isNewObj)
        {
            var ret = esp;
            var res = Vector2Int.down;
            PushVector2Int(ref res, intp, ret, mStack);
            return ret + 1;
        }

        StackObject* Get_Up(ILIntepreter intp, StackObject* esp, IList<object> mStack, CLRMethod method, bool isNewObj)
        {
            var ret = esp;
            var res = Vector2Int.up;
            PushVector2Int(ref res, intp, ret, mStack);
            return ret + 1;
        }

        StackObject* Get_Left(ILIntepreter intp, StackObject* esp, IList<object> mStack, CLRMethod method, bool isNewObj)
        {
            var ret = esp;
            var res = Vector2Int.left;
            PushVector2Int(ref res, intp, ret, mStack);
            return ret + 1;
        }

        StackObject* Get_Right(ILIntepreter intp, StackObject* esp, IList<object> mStack, CLRMethod method, bool isNewObj)
        {
            var ret = esp;
            var res = Vector2Int.right;
            PushVector2Int(ref res, intp, ret, mStack);
            return ret + 1;
        }

        public static void ParseVector2Int(out Vector2Int vec, ILIntepreter intp, StackObject* ptr, IList<object> mStack)
        {
            var a = ILIntepreter.GetObjectAndResolveReference(ptr);
            if (a->ObjectType == ObjectTypes.ValueTypeObjectReference)
            {
                vec = default(Vector2Int);
                var src = *(StackObject**)&a->Value;
                vec.x = ILIntepreter.Minus(src, 1)->Value;
                vec.y = ILIntepreter.Minus(src, 2)->Value;
                intp.FreeStackValueType(ptr);
            }
            else
            {
                vec = (Vector2Int)StackObject.ToObject(a, intp.AppDomain, mStack);
                intp.Free(ptr);
            }
        }

        public void PushVector2Int(ref Vector2Int vec, ILIntepreter intp, StackObject* ptr, IList<object> mStack)
        {
            intp.AllocValueType(ptr, CLRType);
            var dst = *((StackObject**)&ptr->Value);
            CopyValueTypeToStack(ref vec, dst, mStack);
        }
    }
}
#endif