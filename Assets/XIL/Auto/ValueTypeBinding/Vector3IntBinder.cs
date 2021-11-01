﻿#if USE_HOT
using UnityEngine;
using System.Collections.Generic;
using ILRuntime.Other;
using System;
using System.Reflection;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Stack;

namespace ILRuntime.Runtime.Generated
{
    public unsafe class Vector3IntBinder : ValueTypeBinder<Vector3Int>
    {
        public override unsafe void AssignFromStack(ref Vector3Int ins, StackObject* ptr, IList<object> mStack)
        {
            var v = ILIntepreter.Minus(ptr, 1);
            ins.x = v->Value;
            v = ILIntepreter.Minus(ptr, 2);
            ins.y = v->Value;
            v = ILIntepreter.Minus(ptr, 3);
            ins.z = v->Value;
        }

        public override unsafe void CopyValueTypeToStack(ref Vector3Int ins, StackObject* ptr, IList<object> mStack)
        {
            var v = ILIntepreter.Minus(ptr, 1);
            v->Value = ins.x;
            v = ILIntepreter.Minus(ptr, 2);
            v->Value = ins.y;
            v = ILIntepreter.Minus(ptr, 3);
            v->Value = ins.z;
        }
        public override void RegisterCLRRedirection(ILRuntime.Runtime.Enviorment.AppDomain appdomain)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(Vector3Int);
            args = new Type[] { typeof(int), typeof(int), typeof(int) };
            method = type.GetConstructor(flag, null, args, null);
            appdomain.RegisterCLRMethodRedirection(method, NewVector3Int);

            args = new Type[] { typeof(Vector3Int), typeof(Vector3Int) };
            method = type.GetMethod("op_Addition", flag, null, args, null);
            appdomain.RegisterCLRMethodRedirection(method, Vector3Int_Add);

            args = new Type[] { typeof(Vector3Int), typeof(Vector3Int) };
            method = type.GetMethod("op_Subtraction", flag, null, args, null);
            appdomain.RegisterCLRMethodRedirection(method, Vector3Int_Subtraction);

            args = new Type[] { typeof(Vector3Int), typeof(int) };
            method = type.GetMethod("op_Multiply", flag, null, args, null);
            appdomain.RegisterCLRMethodRedirection(method, Vector3Int_Multiply);

            args = new Type[] { typeof(int), typeof(Vector3Int) };
            method = type.GetMethod("op_Multiply", flag, null, args, null);
            appdomain.RegisterCLRMethodRedirection(method, Vector3Int_Multiply2);

            args = new Type[] { typeof(Vector3Int), typeof(int) };
            method = type.GetMethod("op_Division", flag, null, args, null);
            appdomain.RegisterCLRMethodRedirection(method, Vector3Int_Division);

            args = new Type[] { typeof(Vector3Int) };
            method = type.GetMethod("op_UnaryNegation", flag, null, args, null);
            appdomain.RegisterCLRMethodRedirection(method, Vector3Int_Negate);

            args = new Type[] { typeof(Vector3Int), typeof(Vector3Int) };
            method = type.GetMethod("op_Equality", flag, null, args, null);
            appdomain.RegisterCLRMethodRedirection(method, Vector3Int_Equality);

            args = new Type[] { typeof(Vector3Int), typeof(Vector3Int) };
            method = type.GetMethod("op_Inequality", flag, null, args, null);
            appdomain.RegisterCLRMethodRedirection(method, Vector3Int_Inequality);

            args = new Type[] { typeof(Vector3Int), typeof(Vector3Int) };
            method = type.GetMethod("Distance", flag, null, args, null);
            appdomain.RegisterCLRMethodRedirection(method, Vector3Int_Distance);

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
            method = type.GetMethod("get_up", flag, null, args, null);
            appdomain.RegisterCLRMethodRedirection(method, Get_Up);

            args = new Type[] { };
            method = type.GetMethod("get_down", flag, null, args, null);
            appdomain.RegisterCLRMethodRedirection(method, Get_Down);

            args = new Type[] { };
            method = type.GetMethod("get_left", flag, null, args, null);
            appdomain.RegisterCLRMethodRedirection(method, Get_Left);

            args = new Type[] { };
            method = type.GetMethod("get_right", flag, null, args, null);
            appdomain.RegisterCLRMethodRedirection(method, Get_Right);

            args = new Type[] { };
            method = type.GetMethod("get_forward", flag, null, args, null);
            appdomain.RegisterCLRMethodRedirection(method, Get_Forward);

            args = new Type[] { };
            method = type.GetMethod("get_back", flag, null, args, null);
            appdomain.RegisterCLRMethodRedirection(method, Get_Back);
        }

        StackObject* Vector3Int_Add(ILIntepreter intp, StackObject* esp, IList<object> mStack, CLRMethod method, bool isNewObj)
        {
            var ret = ILIntepreter.Minus(esp, 2);
            var ptr = ILIntepreter.Minus(esp, 1);

            Vector3Int left, right;
            ParseVector3Int(out right, intp, ptr, mStack);

            ptr = ILIntepreter.Minus(esp, 2);
            ParseVector3Int(out left, intp, ptr, mStack);

            var res = left + right;
            PushVector3Int(ref res, intp, ret, mStack);

            return ret + 1;
        }

        StackObject* Vector3Int_Subtraction(ILIntepreter intp, StackObject* esp, IList<object> mStack, CLRMethod method, bool isNewObj)
        {
            var ret = ILIntepreter.Minus(esp, 2);
            var ptr = ILIntepreter.Minus(esp, 1);

            Vector3Int left, right;
            ParseVector3Int(out right, intp, ptr, mStack);

            ptr = ILIntepreter.Minus(esp, 2);
            ParseVector3Int(out left, intp, ptr, mStack);

            var res = left - right;
            PushVector3Int(ref res, intp, ret, mStack);

            return ret + 1;
        }

        StackObject* Vector3Int_Multiply(ILIntepreter intp, StackObject* esp, IList<object> mStack, CLRMethod method, bool isNewObj)
        {
            var ret = ILIntepreter.Minus(esp, 2);

            var ptr = ILIntepreter.Minus(esp, 1);
            var b = ILIntepreter.GetObjectAndResolveReference(ptr);

            int val = b->Value;

            Vector3Int vec;

            ptr = ILIntepreter.Minus(esp, 2);
            ParseVector3Int(out vec, intp, ptr, mStack);

            vec = vec * val;
            PushVector3Int(ref vec, intp, ret, mStack);

            return ret + 1;
        }

        StackObject* Vector3Int_Multiply2(ILIntepreter intp, StackObject* esp, IList<object> mStack, CLRMethod method, bool isNewObj)
        {
            var ret = ILIntepreter.Minus(esp, 2);
            Vector3Int vec;

            var ptr = ILIntepreter.Minus(esp, 1);
            ParseVector3Int(out vec, intp, ptr, mStack);

            ptr = ILIntepreter.Minus(esp, 2);
            var b = ILIntepreter.GetObjectAndResolveReference(ptr);

            int val = b->Value;

            vec = val * vec;
            PushVector3Int(ref vec, intp, ret, mStack);

            return ret + 1;
        }

        StackObject* Vector3Int_Division(ILIntepreter intp, StackObject* esp, IList<object> mStack, CLRMethod method, bool isNewObj)
        {
            var ret = ILIntepreter.Minus(esp, 2);

            var ptr = ILIntepreter.Minus(esp, 1);
            var b = ILIntepreter.GetObjectAndResolveReference(ptr);

            int val = b->Value;

            Vector3Int vec;

            ptr = ILIntepreter.Minus(esp, 2);
            ParseVector3Int(out vec, intp, ptr, mStack);

            vec = vec / val;
            PushVector3Int(ref vec, intp, ret, mStack);

            return ret + 1;
        }

        StackObject* Vector3Int_Negate(ILIntepreter intp, StackObject* esp, IList<object> mStack, CLRMethod method, bool isNewObj)
        {
            var ret = ILIntepreter.Minus(esp, 1);

            var ptr = ILIntepreter.Minus(esp, 1);
            Vector3Int vec;

            ptr = ILIntepreter.Minus(esp, 1);
            ParseVector3Int(out vec, intp, ptr, mStack);

            vec = -vec;
            PushVector3Int(ref vec, intp, ret, mStack);

            return ret + 1;
        }

        StackObject* Vector3Int_Equality(ILIntepreter intp, StackObject* esp, IList<object> mStack, CLRMethod method, bool isNewObj)
        {
            var ret = ILIntepreter.Minus(esp, 2);
            var ptr = ILIntepreter.Minus(esp, 1);

            Vector3Int left, right;
            ParseVector3Int(out right, intp, ptr, mStack);

            ptr = ILIntepreter.Minus(esp, 2);
            ParseVector3Int(out left, intp, ptr, mStack);

            var res = left == right;

            ret->ObjectType = ObjectTypes.Integer;
            ret->Value = res ? 1 : 0;
            return ret + 1;
        }

        StackObject* Vector3Int_Inequality(ILIntepreter intp, StackObject* esp, IList<object> mStack, CLRMethod method, bool isNewObj)
        {
            var ret = ILIntepreter.Minus(esp, 2);
            var ptr = ILIntepreter.Minus(esp, 1);

            Vector3Int left, right;
            ParseVector3Int(out right, intp, ptr, mStack);

            ptr = ILIntepreter.Minus(esp, 2);
            ParseVector3Int(out left, intp, ptr, mStack);

            var res = left != right;

            ret->ObjectType = ObjectTypes.Integer;
            ret->Value = res ? 1 : 0;
            return ret + 1;
        }

        StackObject* Vector3Int_Distance(ILIntepreter intp, StackObject* esp, IList<object> mStack, CLRMethod method, bool isNewObj)
        {
            var ret = ILIntepreter.Minus(esp, 2);
            var ptr = ILIntepreter.Minus(esp, 1);

            Vector3Int left, right;
            ParseVector3Int(out right, intp, ptr, mStack);

            ptr = ILIntepreter.Minus(esp, 2);
            ParseVector3Int(out left, intp, ptr, mStack);

            var res = Vector3Int.Distance(left, right);

            ret->ObjectType = ObjectTypes.Float;
            *(float*)&ret->Value = res;
            return ret + 1;
        }

        StackObject* NewVector3Int(ILIntepreter intp, StackObject* esp, IList<object> mStack, CLRMethod method, bool isNewObj)
        {
            StackObject* ret;
            if (isNewObj)
            {
                ret = ILIntepreter.Minus(esp, 2);
                var ptr = ILIntepreter.Minus(esp, 1);
                var z = ptr->Value;
                ptr = ILIntepreter.Minus(esp, 2);
                var y = ptr->Value;
                ptr = ILIntepreter.Minus(esp, 3);
                var x = ptr->Value;

                Vector3Int vec = new Vector3Int(x, y, z);
                PushVector3Int(ref vec, intp, ptr, mStack);
            }
            else
            {
                ret = ILIntepreter.Minus(esp, 4);
                var instance = ILIntepreter.GetObjectAndResolveReference(ret);
                var dst = *(StackObject**)&instance->Value;
                var f = ILIntepreter.Minus(dst, 1);
                var v = ILIntepreter.Minus(esp, 3);
                *f = *v;

                f = ILIntepreter.Minus(dst, 2);
                v = ILIntepreter.Minus(esp, 2);
                *f = *v;

                f = ILIntepreter.Minus(dst, 3);
                v = ILIntepreter.Minus(esp, 1);
                *f = *v;
            }
            return ret;
        }

        StackObject* Get_Magnitude(ILIntepreter intp, StackObject* esp, IList<object> mStack, CLRMethod method, bool isNewObj)
        {
            var ret = ILIntepreter.Minus(esp, 1);

            var ptr = ILIntepreter.Minus(esp, 1);
            Vector3Int vec;
            ParseVector3Int(out vec, intp, ptr, mStack);

            float res = vec.magnitude;

            ret->ObjectType = ObjectTypes.Float;
            *(float*)&ret->Value = res;
            return ret + 1;
        }

        StackObject* Get_SqrMagnitude(ILIntepreter intp, StackObject* esp, IList<object> mStack, CLRMethod method, bool isNewObj)
        {
            var ret = ILIntepreter.Minus(esp, 1);

            var ptr = ILIntepreter.Minus(esp, 1);
            Vector3Int vec;
            ParseVector3Int(out vec, intp, ptr, mStack);

            int res = vec.sqrMagnitude;

            ret->ObjectType = ObjectTypes.Float;
            ret->Value = res;
            return ret + 1;
        }

        StackObject* Get_One(ILIntepreter intp, StackObject* esp, IList<object> mStack, CLRMethod method, bool isNewObj)
        {
            var ret = esp;
            var res = Vector3Int.one;
            PushVector3Int(ref res, intp, ret, mStack);
            return ret + 1;
        }

        StackObject* Get_Zero(ILIntepreter intp, StackObject* esp, IList<object> mStack, CLRMethod method, bool isNewObj)
        {
            var ret = esp;
            var res = Vector3Int.zero;
            PushVector3Int(ref res, intp, ret, mStack);
            return ret + 1;
        }

        StackObject* Get_Up(ILIntepreter intp, StackObject* esp, IList<object> mStack, CLRMethod method, bool isNewObj)
        {
            var ret = esp;
            var res = Vector3Int.up;
            PushVector3Int(ref res, intp, ret, mStack);
            return ret + 1;
        }

        StackObject* Get_Down(ILIntepreter intp, StackObject* esp, IList<object> mStack, CLRMethod method, bool isNewObj)
        {
            var ret = esp;
            var res = Vector3Int.down;
            PushVector3Int(ref res, intp, ret, mStack);
            return ret + 1;
        }

        StackObject* Get_Left(ILIntepreter intp, StackObject* esp, IList<object> mStack, CLRMethod method, bool isNewObj)
        {
            var ret = esp;
            var res = Vector3Int.left;
            PushVector3Int(ref res, intp, ret, mStack);
            return ret + 1;
        }

        StackObject* Get_Right(ILIntepreter intp, StackObject* esp, IList<object> mStack, CLRMethod method, bool isNewObj)
        {
            var ret = esp;
            var res = Vector3Int.right;
            PushVector3Int(ref res, intp, ret, mStack);
            return ret + 1;
        }

        StackObject* Get_Forward(ILIntepreter intp, StackObject* esp, IList<object> mStack, CLRMethod method, bool isNewObj)
        {
            var ret = esp;
            var res = Vector3Int.forward;
            PushVector3Int(ref res, intp, ret, mStack);
            return ret + 1;
        }

        StackObject* Get_Back(ILIntepreter intp, StackObject* esp, IList<object> mStack, CLRMethod method, bool isNewObj)
        {
            var ret = esp;
            var res = Vector3Int.back;
            PushVector3Int(ref res, intp, ret, mStack);
            return ret + 1;
        }


        public static void ParseVector3Int(out Vector3Int vec, ILIntepreter intp, StackObject* ptr, IList<object> mStack)
        {
            var a = ILIntepreter.GetObjectAndResolveReference(ptr);
            if (a->ObjectType == ObjectTypes.ValueTypeObjectReference)
            {
                vec = default(Vector3Int);
                var src = *(StackObject**)&a->Value;
                vec.x = ILIntepreter.Minus(src, 1)->Value;
                vec.y = ILIntepreter.Minus(src, 2)->Value;
                vec.z = ILIntepreter.Minus(src, 3)->Value;
                intp.FreeStackValueType(ptr);
            }
            else
            {
                vec = (Vector3Int)StackObject.ToObject(a, intp.AppDomain, mStack);
                intp.Free(ptr);
            }
        }

        public void PushVector3Int(ref Vector3Int vec, ILIntepreter intp, StackObject* ptr, IList<object> mStack)
        {
            intp.AllocValueType(ptr, CLRType);
            var dst = *((StackObject**)&ptr->Value);
            CopyValueTypeToStack(ref vec, dst, mStack);
        }
    }
}
#endif