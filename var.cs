using Microsoft.VisualBasic;
using System;
using System.Collections;
//using System.Dynamic;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;

namespace AutomatedQA.script
{

	public class var
	{
	    public class VarDelegate/* : DynamicObject*/
        {
            public static Stack dlgtsForCall;

            private bool isFake;
            private string name;
            private var owner;

	        private VarDelegate_ varDelegate;

            public delegate var VarDelegate_(params var[] args);

            // AutomatedQA.script.var.VarDelegate
            static VarDelegate()
            {
                var.VarDelegate.dlgtsForCall = new Stack();
            }


            public VarDelegate(VarDelegate_ dFun)
	        {
	            varDelegate = dFun;
	        }


            // AutomatedQA.script.var.VarDelegate
            public var.VarDelegate this[string nextName, params var[] args]
            {
                get
                {
                    @var[] args2 = new var[0];
                    return this.Call(args2)[nextName, new var[0]];
                }
                set
                {
                    @var[] args2;
                    if (args != null && args.Length != 0)
                    {
                        object[] array = new object[args.Length + 1];
                        for (int i = 0; i < args.Length; i++)
                        {
                            array[i] = args[i].UnWrap();
                        }
                        array[args.Length] = value.UnWrap();
                        args2 = new var[0];
                        this.Call(args2)[nextName, new var[0]].PutVal(array);
                        return;
                    }
                    args2 = new var[0];
                    this.Call(args2)[nextName, new var[0]].PutVal(new object[]
                    {
                        value.UnWrap()
                    });
                }
            }

            // AutomatedQA.script.var.VarDelegate
            public void PutVal(object[] args)
            {
                var.VarDelegate varDelegate = (var.VarDelegate)var.VarDelegate.dlgtsForCall.Pop();
                varDelegate.PutValNoPop(args);
            }


            // AutomatedQA.script.var.VarDelegate
            public var CallNoPop(params var[] args)
            {
                if (this.name == "")
                {
                    return this.owner;
                }
                object[] array = new object[args.Length];
                for (int i = 0; i < args.Length; i++)
                {
                    array[i] = args[i].UnWrap();
                }
                object arg = this.owner.UnWrap().GetType().InvokeMember(this.name, /*5376*/BindingFlags.InvokeMethod | BindingFlags.GetField | BindingFlags.GetProperty , 
                    null, this.owner.UnWrap(), array);
                return new var(arg);
            }

            public static var CallStatic(params var[] args)
            {
                VarDelegate varDelegate = (VarDelegate)VarDelegate.dlgtsForCall.Pop();
                return varDelegate.CallNoPop(args);
            }

	        public var Do(params var[] args)
	        {
	           return  CallStatic(args);
	        }

            // AutomatedQA.script.var.VarDelegate
            public static var.VarDelegate NewVarDelegate()
            {
               return new VarDelegate(VarDelegate.CallStatic);
            }

            // AutomatedQA.script.var.VarDelegate
            public void SetVar(var anOwner)
            {
                this.owner = anOwner;
            }

            // AutomatedQA.script.var.VarDelegate
            public void SetName(string anName)
            {
                this.name = anName;
            }

            // AutomatedQA.script.var.VarDelegate
            public object UnWrap()
            {
                if (this.isFake)
                {
                    return this.owner.UnWrap();
                }
                @var[] args = new var[0];
                return this.Call(args).UnWrap();

            }
            // AutomatedQA.script.var.VarDelegate
            public var Call(params var[] args)
            {
                if (var.VarDelegate.dlgtsForCall.Count > 0)
                {
                    VarDelegate varDelegate = (var.VarDelegate)var.VarDelegate.dlgtsForCall.Pop();
                    return varDelegate.CallNoPop(args);
                }
                return this.CallNoPop(args);
            }

            // AutomatedQA.script.var.VarDelegate
            public void PutValNoPop(object[] args)
            {
                this.owner.UnWrap().GetType().InvokeMember(this.name, BindingFlags.SetField | BindingFlags.SetProperty, null, this.owner.UnWrap(), args);
                this.owner = null;
                this.name = "";
            }

            // AutomatedQA.script.var.VarDelegate
            public var.VarDelegate SetFakeObject(var arg)
            {
                this.owner = arg;
                this.isFake = true;
                return this;
            }

            
            // AutomatedQA.script.var.VarDelegate
            public var.VarDelegate SetFakeObject(bool arg)
            {
                this.owner = new var(arg);
                this.isFake = true;
                return this;
            }

            // AutomatedQA.script.var.VarDelegate
            public var.VarDelegate SetFakeObject(byte arg)
            {
                this.owner = new var(arg);
                this.isFake = true;
                return this;
            }

            // AutomatedQA.script.var.VarDelegate
            public var.VarDelegate SetFakeObject(sbyte arg)
            {
                this.owner = new var(arg);
                this.isFake = true;
                return this;
            }

            // AutomatedQA.script.var.VarDelegate
            public var.VarDelegate SetFakeObject(char arg)
            {
                this.owner = new var(arg);
                this.isFake = true;
                return this;
            }

            // AutomatedQA.script.var.VarDelegate
            public var.VarDelegate SetFakeObject(decimal arg)
            {
                this.owner = new var(arg);
                this.isFake = true;
                return this;
            }

            // AutomatedQA.script.var.VarDelegate
            public var.VarDelegate SetFakeObject(double arg)
            {
                this.owner = new var(arg);
                this.isFake = true;
                return this;
            }

            // AutomatedQA.script.var.VarDelegate
            public var.VarDelegate SetFakeObject(float arg)
            {
                this.owner = new var(arg);
                this.isFake = true;
                return this;
            }

            // AutomatedQA.script.var.VarDelegate
            public var.VarDelegate SetFakeObject(int arg)
            {
                this.owner = new var(arg);
                this.isFake = true;
                return this;
            }

            // AutomatedQA.script.var.VarDelegate
            public var.VarDelegate SetFakeObject(uint arg)
            {
                this.owner = new var(arg);
                this.isFake = true;
                return this;
            }

            // AutomatedQA.script.var.VarDelegate
            public var.VarDelegate SetFakeObject(long arg)
            {
                this.owner = new var(arg);
                this.isFake = true;
                return this;
            }

            // AutomatedQA.script.var.VarDelegate
            public var.VarDelegate SetFakeObject(ulong arg)
            {
                this.owner = new var(arg);
                this.isFake = true;
                return this;
            }

            // AutomatedQA.script.var.VarDelegate
            public var.VarDelegate SetFakeObject(object arg)
            {
                this.owner = new var(arg);
                this.isFake = true;
                return this;
            }

            // AutomatedQA.script.var.VarDelegate
            public var.VarDelegate SetFakeObject(short arg)
            {
                this.owner = new var(arg);
                this.isFake = true;
                return this;
            }

            // AutomatedQA.script.var.VarDelegate
            public var.VarDelegate SetFakeObject(ushort arg)
            {
                this.owner = new var(arg);
                this.isFake = true;
                return this;
            }

            // AutomatedQA.script.var.VarDelegate
            public var.VarDelegate SetFakeObject(string arg)
            {
                this.owner = new var(arg);
                this.isFake = true;
                return this;
            }

            // AutomatedQA.script.var.VarDelegate
            public static implicit operator var(var.VarDelegate arg)
            {
                @var[] args = new var[0];
                return arg.Call(args);
            }

            // AutomatedQA.script.var.VarDelegate
            public static implicit operator bool(var.VarDelegate arg)
            {
                @var[] args = new var[0];
                return arg.Call(args);
            }

            // AutomatedQA.script.var.VarDelegate
            public static implicit operator var.VarDelegate(bool arg)
            {
                return var.VarDelegate.NewVarDelegate().SetFakeObject(arg);
            }

            // AutomatedQA.script.var.VarDelegate
            public static implicit operator byte(var.VarDelegate arg)
            {
                @var[] args = new var[0];
                return arg.Call(args);
            }

            // AutomatedQA.script.var.VarDelegate
            public static implicit operator var.VarDelegate(byte arg)
            {
                return var.VarDelegate.NewVarDelegate().SetFakeObject(arg);
            }

            // AutomatedQA.script.var.VarDelegate
            public static implicit operator sbyte(var.VarDelegate arg)
            {
                @var[] args = new var[0];
                return arg.Call(args);
            }

            // AutomatedQA.script.var.VarDelegate
            public static implicit operator var.VarDelegate(sbyte arg)
            {
                return var.VarDelegate.NewVarDelegate().SetFakeObject(arg);
            }

            // AutomatedQA.script.var.VarDelegate
            public static implicit operator char(var.VarDelegate arg)
            {
                @var[] args = new var[0];
                return arg.Call(args);
            }

            // AutomatedQA.script.var.VarDelegate
            public static implicit operator var.VarDelegate(char arg)
            {
                return var.VarDelegate.NewVarDelegate().SetFakeObject(arg);
            }

            // AutomatedQA.script.var.VarDelegate
            public static implicit operator decimal(var.VarDelegate arg)
            {
                @var[] args = new var[0];
                return arg.Call(args);
            }

            // AutomatedQA.script.var.VarDelegate
            public static implicit operator var.VarDelegate(decimal arg)
            {
                return var.VarDelegate.NewVarDelegate().SetFakeObject(arg);
            }

            // AutomatedQA.script.var.VarDelegate
            public static implicit operator double(var.VarDelegate arg)
            {
                @var[] args = new var[0];
                return arg.Call(args);
            }

            // AutomatedQA.script.var.VarDelegate
            public static implicit operator var.VarDelegate(double arg)
            {
                return var.VarDelegate.NewVarDelegate().SetFakeObject(arg);
            }

            // AutomatedQA.script.var.VarDelegate
            public static implicit operator float(var.VarDelegate arg)
            {
                @var[] args = new var[0];
                return arg.Call(args);
            }

            // AutomatedQA.script.var.VarDelegate
            public static implicit operator var.VarDelegate(float arg)
            {
                return var.VarDelegate.NewVarDelegate().SetFakeObject(arg);
            }

            // AutomatedQA.script.var.VarDelegate
            public static implicit operator int(var.VarDelegate arg)
            {
                @var[] args = new var[0];
                return arg.Call(args);
            }

            // AutomatedQA.script.var.VarDelegate
            public static implicit operator var.VarDelegate(int arg)
            {
                return var.VarDelegate.NewVarDelegate().SetFakeObject(arg);
            }

            // AutomatedQA.script.var.VarDelegate
            public static implicit operator uint(var.VarDelegate arg)
            {
                @var[] args = new var[0];
                return arg.Call(args);
            }

            // AutomatedQA.script.var.VarDelegate
            public static implicit operator var.VarDelegate(uint arg)
            {
                return var.VarDelegate.NewVarDelegate().SetFakeObject(arg);
            }

            // AutomatedQA.script.var.VarDelegate
            public static implicit operator long(var.VarDelegate arg)
            {
                @var[] args = new var[0];
                return arg.Call(args);
            }

            // AutomatedQA.script.var.VarDelegate
            public static implicit operator var.VarDelegate(long arg)
            {
                return var.VarDelegate.NewVarDelegate().SetFakeObject(arg);
            }

            // AutomatedQA.script.var.VarDelegate
            public static implicit operator ulong(var.VarDelegate arg)
            {
                @var[] args = new var[0];
                return arg.Call(args);
            }

            // AutomatedQA.script.var.VarDelegate
            public static implicit operator var.VarDelegate(ulong arg)
            {
                return var.VarDelegate.NewVarDelegate().SetFakeObject(arg);
            }

            // AutomatedQA.script.var.VarDelegate
            public static implicit operator short(var.VarDelegate arg)
            {
                @var[] args = new var[0];
                return arg.Call(args);
            }

            // AutomatedQA.script.var.VarDelegate
            public static implicit operator var.VarDelegate(short arg)
            {
                return var.VarDelegate.NewVarDelegate().SetFakeObject(arg);
            }
            // AutomatedQA.script.var.VarDelegate
            public static implicit operator ushort(var.VarDelegate arg)
            {
                @var[] args = new var[0];
                return arg.Call(args);
            }

            // AutomatedQA.script.var.VarDelegate
            public static implicit operator var.VarDelegate(ushort arg)
            {
                return var.VarDelegate.NewVarDelegate().SetFakeObject(arg);
            }

            // AutomatedQA.script.var.VarDelegate
            public static implicit operator string(var.VarDelegate arg)
            {
                @var[] args = new var[0];
                return arg.Call(args);
            }

            // AutomatedQA.script.var.VarDelegate
            public static implicit operator var.VarDelegate(string arg)
            {
                return var.VarDelegate.NewVarDelegate().SetFakeObject(arg);
            }
            /*
            public override bool TryInvoke(InvokeBinder binder, object[] parameters, out object result)
            {
                result = varDelegate(parameters as var[]);
                return true;
            }*/



        }


        //[DefaultMember("Item")]
        //public delegate var VarDelegate(params var[] args);

        private class VarOps
		{
			[DllImport("oleaut32.dll")]
			public static extern int VarAdd(ref object left, ref object right, ref object result);

			[DllImport("oleaut32.dll")]
			public static extern int VarCat(ref object left, ref object right, ref object result);

			[DllImport("oleaut32.dll")]
			public static extern int VarSub(ref object left, ref object right, ref object result);

			[DllImport("oleaut32.dll")]
			public static extern int VarMul(ref object left, ref object right, ref object result);

			[DllImport("oleaut32.dll")]
			public static extern int VarAnd(ref object left, ref object right, ref object result);

			[DllImport("oleaut32.dll")]
			public static extern int VarDiv(ref object left, ref object right, ref object result);

			[DllImport("oleaut32.dll")]
			public static extern int VarEqv(ref object left, ref object right, ref object result);

			[DllImport("oleaut32.dll")]
			public static extern int VarIdiv(ref object left, ref object right, ref object result);

			[DllImport("oleaut32.dll")]
			public static extern int VarImp(ref object left, ref object right, ref object result);

			[DllImport("oleaut32.dll")]
			public static extern int VarMod(ref object left, ref object right, ref object result);

			[DllImport("oleaut32.dll")]
			public static extern int VarOr(ref object left, ref object right, ref object result);

			[DllImport("oleaut32.dll")]
			public static extern int VarXor(ref object left, ref object right, ref object result);

			[DllImport("oleaut32.dll")]
			public static extern int VarPow(ref object left, ref object right, out object result);

			[DllImport("oleaut32.dll")]
			public static extern int VarAbs(ref object varIn, ref object result);

			[DllImport("oleaut32.dll")]
			public static extern int VarFix(ref object varIn, ref object result);

			[DllImport("oleaut32.dll")]
			public static extern int VarInt(ref object varIn, ref object result);

			[DllImport("oleaut32.dll")]
			public static extern int VarNeg(ref object varIn, ref object result);

			[DllImport("oleaut32.dll")]
			public static extern int VarNot(ref object varIn, ref object result);

			[DllImport("oleaut32.dll")]
			public static extern int VarRound(ref object varIn, int cDecimals, ref object result);

			[DllImport("oleaut32.dll")]
			public static extern int VarCmp(ref object left, ref object right, uint lcid, uint dwFlags);
		}

		protected object Object;

		public var.VarDelegate this[string name, params var[] args]
		{
			get
			{
                VarDelegate varDelegate = var.VarDelegate.NewVarDelegate();
				varDelegate.SetVar(this);
				varDelegate.SetName(name);
				this.Init();
				var.VarDelegate.dlgtsForCall.Push(varDelegate);
				return varDelegate;
			}
			set
			{
				VarDelegate varDelegate = var.VarDelegate.NewVarDelegate();
				varDelegate.SetVar(this);
				varDelegate.SetName(name);
				this.Init();
				if (args != null && args.Length != 0)
				{
					object[] array = new object[args.Length + 1];
					for (int i = 0; i < args.Length; i++)
					{
						array[i] = args[i].UnWrap();
					}
					array[args.Length] = value.UnWrap();
					varDelegate.PutValNoPop(array);
					return;
				}
				varDelegate.PutValNoPop(new object[]
				{
					value.UnWrap()
				});
			}
		}

		protected virtual void Init()
		{
		}

		public object UnWrap()
		{
			this.Init();
			return this.Object;
		}

		public var()
		{
		}

		public var(bool arg)
		{
			this.Object = arg;
		}

		public var(byte arg)
		{
			this.Object = arg;
		}

		public var(sbyte arg)
		{
			this.Object = arg;
		}

		public var(char arg)
		{
			this.Object = arg;
		}

		public var(decimal arg)
		{
			this.Object = arg;
		}

		public var(double arg)
		{
			this.Object = arg;
		}

		public var(float arg)
		{
			this.Object = arg;
		}

		public var(int arg)
		{
			this.Object = arg;
		}

		public var(uint arg)
		{
			this.Object = arg;
		}

		public var(long arg)
		{
			this.Object = arg;
		}

		public var(ulong arg)
		{
			this.Object = arg;
		}

		public var(object arg)
		{
			if (arg is var.VarDelegate)
			{
				throw new Exception("var(VarDelegate)");
			}
			if (arg is var)
			{
				this.Object = ((var)arg).UnWrap();
				return;
			}
			this.Object = arg;
		}

		public var(short arg)
		{
			this.Object = arg;
		}

		public var(ushort arg)
		{
			this.Object = arg;
		}

		public var(string arg)
		{
			this.Object = arg;
		}

		public static implicit operator var.VarDelegate(var arg)
		{
			arg.Init();
			return var.VarDelegate.NewVarDelegate().SetFakeObject(arg);
		}

		public static implicit operator bool(var arg)
		{
			arg.Init();
			return arg.Object != null && (bool)arg.Object;
		}

		public static implicit operator var(bool arg)
		{
			return new var(arg);
		}

		public static implicit operator byte(var arg)
		{
			arg.Init();
			return (byte)arg.Object;
		}

		public static implicit operator var(byte arg)
		{
			return new var(arg);
		}

		public static implicit operator sbyte(var arg)
		{
			arg.Init();
			return (sbyte)arg.Object;
		}

		public static implicit operator var(sbyte arg)
		{
			return new var(arg);
		}

		public static implicit operator char(var arg)
		{
			arg.Init();
			return (char)arg.Object;
		}

		public static implicit operator var(char arg)
		{
			return new var(arg);
		}

		public static implicit operator decimal(var arg)
		{
			arg.Init();
			return (decimal)arg.Object;
		}

		public static implicit operator var(decimal arg)
		{
			return new var(arg);
		}

		public static implicit operator double(var arg)
		{
			arg.Init();
			return (double)arg.Object;
		}

		public static implicit operator var(double arg)
		{
			return new var(arg);
		}

		public static implicit operator float(var arg)
		{
			arg.Init();
			return (float)arg.Object;
		}

		public static implicit operator var(float arg)
		{
			return new var(arg);
		}

		public static implicit operator int(var arg)
		{
			arg.Init();
			return (int)arg.Object;
		}

		public static implicit operator var(int arg)
		{
			return new var(arg);
		}

		public static implicit operator uint(var arg)
		{
			arg.Init();
			return (uint)arg.Object;
		}

		public static implicit operator var(uint arg)
		{
			return new var(arg);
		}

		public static implicit operator long(var arg)
		{
			arg.Init();
			return (long)arg.Object;
		}

		public static implicit operator var(long arg)
		{
			return new var(arg);
		}

		public static implicit operator ulong(var arg)
		{
			arg.Init();
			return (ulong)arg.Object;
		}

		public static implicit operator var(ulong arg)
		{
			return new var(arg);
		}

		public static implicit operator short(var arg)
		{
			arg.Init();
			return (short)arg.Object;
		}

		public static implicit operator var(short arg)
		{
			return new var(arg);
		}

		public static implicit operator ushort(var arg)
		{
			arg.Init();
			return (ushort)arg.Object;
		}

		public static implicit operator var(ushort arg)
		{
			return new var(arg);
		}

		public static implicit operator string(var arg)
		{
			arg.Init();
			return (string)arg.Object;
		}

		public static implicit operator var(string arg)
		{
			return new var(arg);
		}

		public static var operator +(var varIn)
		{
			return varIn;
		}

		public static var operator -(var varIn)
		{
			object obj = 0;
			object obj2 = varIn.UnWrap();
			object arg = null;
			var.VarOps.VarSub(ref obj, ref obj2, ref arg);
			return new var(arg);
		}

		public static bool operator !(var varIn)
		{
			object obj = varIn.UnWrap();
			return obj == null || !(bool)obj;
		}

		public static var operator ~(var varIn)
		{
			object obj = varIn.UnWrap();
			object obj2 = 1;
			object arg = null;
			var.VarOps.VarNot(ref obj, ref arg);
			var.VarOps.VarAdd(ref obj2, ref arg, ref arg);
			return new var(arg);
		}

		public static var operator ++(var varIn)
		{
			object obj = varIn.UnWrap();
			object obj2 = 1;
			object arg = null;
			var.VarOps.VarAdd(ref obj2, ref obj, ref arg);
			return new var(arg);
		}

		public static var operator --(var varIn)
		{
			object obj = varIn.UnWrap();
			object obj2 = -1;
			object arg = null;
			var.VarOps.VarAdd(ref obj2, ref obj, ref arg);
			return new var(arg);
		}

		public static bool operator true(var varIn)
		{
			object obj = varIn.UnWrap();
			object obj2 = true;
			return 1 == var.VarOps.VarCmp(ref obj, ref obj2, (uint)CultureInfo.CurrentCulture.LCID, 0u);
		}

		public static bool operator false(var varIn)
		{
			object obj = varIn.UnWrap();
			object obj2 = false;
			return 1 == var.VarOps.VarCmp(ref obj, ref obj2, (uint)CultureInfo.CurrentCulture.LCID, 0u);
		}

		public static var operator +(var left, var right)
		{
			object obj = left.UnWrap();
			object obj2 = right.UnWrap();
			object arg = null;
			var.VarOps.VarAdd(ref obj, ref obj2, ref arg);
			return new var(arg);
		}

		public static var operator -(var left, var right)
		{
			object obj = left.UnWrap();
			object obj2 = right.UnWrap();
			object arg = null;
			var.VarOps.VarSub(ref obj, ref obj2, ref arg);
			return new var(arg);
		}

		public static var operator *(var left, var right)
		{
			object obj = left.UnWrap();
			object obj2 = right.UnWrap();
			object arg = null;
			var.VarOps.VarMul(ref obj, ref obj2, ref arg);
			return new var(arg);
		}

		public static var operator /(var left, var right)
		{
			object obj = left.UnWrap();
			object obj2 = right.UnWrap();
			object arg = null;
			var.VarOps.VarDiv(ref obj, ref obj2, ref arg);
			return new var(arg);
		}

		public static var operator %(var left, var right)
		{
			object obj = left.UnWrap();
			object obj2 = right.UnWrap();
			object arg = null;
			var.VarOps.VarMod(ref obj, ref obj2, ref arg);
			return new var(arg);
		}

		public static var operator &(var left, var right)
		{
			object obj = left.UnWrap();
			object obj2 = right.UnWrap();
			object arg = null;
			var.VarOps.VarAnd(ref obj, ref obj2, ref arg);
			return new var(arg);
		}

		public static var operator |(var left, var right)
		{
			object obj = left.UnWrap();
			object obj2 = right.UnWrap();
			object arg = null;
			var.VarOps.VarOr(ref obj, ref obj2, ref arg);
			return new var(arg);
		}

		public static var operator ^(var left, var right)
		{
			object obj = left.UnWrap();
			object obj2 = right.UnWrap();
			object arg = null;
			var.VarOps.VarXor(ref obj, ref obj2, ref arg);
			return new var(arg);
		}

		public override bool Equals(object o)
		{
			return this.Object == (o as var).Object;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public static bool operator ==(var left, var right)
		{
            if (object.ReferenceEquals(left, null))
            {
                return new var(null) == right;
            }
            if (object.ReferenceEquals(right, null))
            {
                return left == new var(null);
            }
			object obj = left.UnWrap();
			object obj2 = right.UnWrap();
			return 1 == var.VarOps.VarCmp(ref obj, ref obj2, (uint)CultureInfo.CurrentCulture.LCID, 0u);
		}

		public static bool operator !=(var left, var right)
		{
            if (object.ReferenceEquals(left, null))
			{
				return new var(null) != right;
			}
            if (object.ReferenceEquals(right, null))
			{
				return left != new var(null);
			}
			object obj = left.UnWrap();
			object obj2 = right.UnWrap();
			return 1 != var.VarOps.VarCmp(ref obj, ref obj2, (uint)CultureInfo.CurrentCulture.LCID, 0u);
		}

		public static bool operator <(var left, var right)
		{
			object obj = left.UnWrap();
			object obj2 = right.UnWrap();
			return 0 == var.VarOps.VarCmp(ref obj, ref obj2, (uint)CultureInfo.CurrentCulture.LCID, 0u);
		}

		public static bool operator >(var left, var right)
		{
			object obj = left.UnWrap();
			object obj2 = right.UnWrap();
			return 2 == var.VarOps.VarCmp(ref obj, ref obj2, (uint)CultureInfo.CurrentCulture.LCID, 0u);
		}

		public static bool operator <=(var left, var right)
		{
			object obj = left.UnWrap();
			object obj2 = right.UnWrap();
			int num = var.VarOps.VarCmp(ref obj, ref obj2, (uint)CultureInfo.CurrentCulture.LCID, 0u);
			return num == 0 || num == 1;
		}

		public static bool operator >=(var left, var right)
		{
			object obj = left.UnWrap();
			object obj2 = right.UnWrap();
			int num = var.VarOps.VarCmp(ref obj, ref obj2, (uint)CultureInfo.CurrentCulture.LCID, 0u);
			return num == 1 || num == 2;
		}

		public var GetObject(string Name)
		{
			try
			{
				this.Object = Marshal.GetActiveObject(Name);
			}
			catch (Exception)
			{
				//this.Object = Interaction.CreateObject(Name, "");
			}
			return this;
		}

		public var GetObjectAlternative(string Name, string AlternativeName)
		{
			try
			{
				this.Object = Marshal.GetActiveObject(Name);
			}
			catch (Exception)
			{
				try
				{
					this.Object = Marshal.GetActiveObject(AlternativeName);
				}
				catch (Exception)
				{
					try
					{
						//this.Object = Interaction.CreateObject(Name, "");
					}
					catch (Exception)
					{
						//this.Object = Interaction.CreateObject(AlternativeName, "");
					}
				}
			}
			return this;
		}
	}
}
