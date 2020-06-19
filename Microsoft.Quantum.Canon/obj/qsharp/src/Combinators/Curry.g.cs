#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "UncurryOpImpl<'T, 'U> (curriedOp : ('T -> ('U => ())), first : 'T, second : 'U) : ()", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\Curry.qs", 1429L, 44L, 99L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "UncurryOpCImpl<'T, 'U> (curriedOp : ('T -> ('U => () : Controlled)), first : 'T, second : 'U) : ()", new string[] { "Controlled" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\Curry.qs", 2527L, 77L, 113L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "UncurryOpAImpl<'T, 'U> (curriedOp : ('T -> ('U => () : Adjoint)), first : 'T, second : 'U) : ()", new string[] { "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\Curry.qs", 3660L, 112L, 110L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "UncurryOpCAImpl<'T, 'U> (curriedOp : ('T -> ('U => () : Controlled, Adjoint)), first : 'T, second : 'U) : ()", new string[] { "Controlled", "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\Curry.qs", 4796L, 147L, 123L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "CurryOpImpl<'T, 'U> (op : (('T, 'U) => ()), arg1 : 'T) : ('U => ())", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\Curry.qs", 154L, 7L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "CurryOp<'T, 'U> (op : (('T, 'U) => ())) : ('T -> ('U => ()))", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\Curry.qs", 1223L, 40L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "UncurryOp<'T, 'U> (curriedOp : ('T -> ('U => ()))) : (('T, 'U) => ())", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\Curry.qs", 2286L, 73L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "UncurryOpC<'T, 'U> (curriedOp : ('T -> ('U => () : Controlled))) : (('T, 'U) => () : Controlled)", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\Curry.qs", 3394L, 108L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "UncurryOpA<'T, 'U> (curriedOp : ('T -> ('U => () : Adjoint))) : (('T, 'U) => () : Adjoint)", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\Curry.qs", 4523L, 143L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "UncurryOpCA<'T, 'U> (curriedOp : ('T -> ('U => () : Controlled, Adjoint))) : (('T, 'U) => () : Controlled, Adjoint)", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\Curry.qs", 5735L, 180L, 14L)]
#line hidden
namespace Microsoft.Quantum.Canon
{
    public class CurryOpImpl<__T, __U> : Operation<(ICallable,__T), ICallable>, ICallable
    {
        public CurryOpImpl(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(ICallable,__T)>, IApplyData
        {
            public In((ICallable,__T) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, Data.Item2?.GetQubits());
        }

        String ICallable.Name => "CurryOpImpl";
        String ICallable.FullName => "Microsoft.Quantum.Canon.CurryOpImpl";
        public override Func<(ICallable,__T), ICallable> Body => (__in) =>
        {
            var (op,arg1) = __in;
#line 8 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\Curry.qs"
            return op.Partial((arg1, _));
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((ICallable,__T) data) => new In(data);
        public override IApplyData __dataOut(ICallable data) => new QTuple<ICallable>(data);
        public static System.Threading.Tasks.Task<ICallable> Run(IOperationFactory __m__, ICallable op, __T arg1)
        {
            return __m__.Run<CurryOpImpl<__T,__U>, (ICallable,__T), ICallable>((op, arg1));
        }
    }

    public class CurryOp<__T, __U> : Operation<ICallable, ICallable>, ICallable
    {
        public CurryOp(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "CurryOp";
        String ICallable.FullName => "Microsoft.Quantum.Canon.CurryOp";
        protected ICallable CurryOpImpl
        {
            get;
            set;
        }

        public override Func<ICallable, ICallable> Body => (__in) =>
        {
            var op = __in;
#line 41 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\Curry.qs"
            return CurryOpImpl.Partial((((ICallable)op), _));
        }

        ;
        public override void Init()
        {
            this.CurryOpImpl = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.CurryOpImpl<,>));
        }

        public override IApplyData __dataIn(ICallable data) => new QTuple<ICallable>(data);
        public override IApplyData __dataOut(ICallable data) => new QTuple<ICallable>(data);
        public static System.Threading.Tasks.Task<ICallable> Run(IOperationFactory __m__, ICallable op)
        {
            return __m__.Run<CurryOp<__T,__U>, ICallable, ICallable>(op);
        }
    }

    public class UncurryOpImpl<__T, __U> : Operation<(ICallable,__T,__U), QVoid>, ICallable
    {
        public UncurryOpImpl(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(ICallable,__T,__U)>, IApplyData
        {
            public In((ICallable,__T,__U) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, Data.Item2?.GetQubits(), Data.Item3?.GetQubits());
        }

        String ICallable.Name => "UncurryOpImpl";
        String ICallable.FullName => "Microsoft.Quantum.Canon.UncurryOpImpl";
        public override Func<(ICallable,__T,__U), QVoid> Body => (__in) =>
        {
            var (curriedOp,first,second) = __in;
#line 46 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\Curry.qs"
            var innerOp = curriedOp.Apply<ICallable>(first);
#line 47 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\Curry.qs"
            innerOp.Apply(second);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((ICallable,__T,__U) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, ICallable curriedOp, __T first, __U second)
        {
            return __m__.Run<UncurryOpImpl<__T,__U>, (ICallable,__T,__U), QVoid>((curriedOp, first, second));
        }
    }

    public class UncurryOp<__T, __U> : Operation<ICallable, ICallable>, ICallable
    {
        public UncurryOp(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "UncurryOp";
        String ICallable.FullName => "Microsoft.Quantum.Canon.UncurryOp";
        protected ICallable UncurryOpImpl
        {
            get;
            set;
        }

        public override Func<ICallable, ICallable> Body => (__in) =>
        {
            var curriedOp = __in;
#line 74 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\Curry.qs"
            return UncurryOpImpl.Partial((((ICallable)curriedOp), _, _));
        }

        ;
        public override void Init()
        {
            this.UncurryOpImpl = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.UncurryOpImpl<,>));
        }

        public override IApplyData __dataIn(ICallable data) => new QTuple<ICallable>(data);
        public override IApplyData __dataOut(ICallable data) => new QTuple<ICallable>(data);
        public static System.Threading.Tasks.Task<ICallable> Run(IOperationFactory __m__, ICallable curriedOp)
        {
            return __m__.Run<UncurryOp<__T,__U>, ICallable, ICallable>(curriedOp);
        }
    }

    public class UncurryOpCImpl<__T, __U> : Controllable<(ICallable,__T,__U)>, ICallable
    {
        public UncurryOpCImpl(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(ICallable,__T,__U)>, IApplyData
        {
            public In((ICallable,__T,__U) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, Data.Item2?.GetQubits(), Data.Item3?.GetQubits());
        }

        String ICallable.Name => "UncurryOpCImpl";
        String ICallable.FullName => "Microsoft.Quantum.Canon.UncurryOpCImpl";
        public override Func<(ICallable,__T,__U), QVoid> Body => (__in) =>
        {
            var (curriedOp,first,second) = __in;
#line 79 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\Curry.qs"
            var innerOp = curriedOp.Apply<IControllable>(first);
#line 80 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\Curry.qs"
            innerOp.Apply(second);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(ICallable,__T,__U)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(curriedOp,first,second)) = __in;
            var innerOp = curriedOp.Apply<IControllable>(first);
            innerOp.Controlled.Apply((controlQubits, second));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((ICallable,__T,__U) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, ICallable curriedOp, __T first, __U second)
        {
            return __m__.Run<UncurryOpCImpl<__T,__U>, (ICallable,__T,__U), QVoid>((curriedOp, first, second));
        }
    }

    public class UncurryOpC<__T, __U> : Operation<ICallable, IControllable>, ICallable
    {
        public UncurryOpC(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "UncurryOpC";
        String ICallable.FullName => "Microsoft.Quantum.Canon.UncurryOpC";
        protected IControllable UncurryOpCImpl
        {
            get;
            set;
        }

        public override Func<ICallable, IControllable> Body => (__in) =>
        {
            var curriedOp = __in;
#line 109 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\Curry.qs"
            return UncurryOpCImpl.Partial((((ICallable)curriedOp), _, _));
        }

        ;
        public override void Init()
        {
            this.UncurryOpCImpl = this.Factory.Get<IControllable>(typeof(Microsoft.Quantum.Canon.UncurryOpCImpl<,>));
        }

        public override IApplyData __dataIn(ICallable data) => new QTuple<ICallable>(data);
        public override IApplyData __dataOut(IControllable data) => new QTuple<IControllable>(data);
        public static System.Threading.Tasks.Task<IControllable> Run(IOperationFactory __m__, ICallable curriedOp)
        {
            return __m__.Run<UncurryOpC<__T,__U>, ICallable, IControllable>(curriedOp);
        }
    }

    public class UncurryOpAImpl<__T, __U> : Adjointable<(ICallable,__T,__U)>, ICallable
    {
        public UncurryOpAImpl(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(ICallable,__T,__U)>, IApplyData
        {
            public In((ICallable,__T,__U) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, Data.Item2?.GetQubits(), Data.Item3?.GetQubits());
        }

        String ICallable.Name => "UncurryOpAImpl";
        String ICallable.FullName => "Microsoft.Quantum.Canon.UncurryOpAImpl";
        public override Func<(ICallable,__T,__U), QVoid> Body => (__in) =>
        {
            var (curriedOp,first,second) = __in;
#line 114 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\Curry.qs"
            var innerOp = curriedOp.Apply<IAdjointable>(first);
#line 115 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\Curry.qs"
            innerOp.Apply(second);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(ICallable,__T,__U), QVoid> AdjointBody => (__in) =>
        {
            var (curriedOp,first,second) = __in;
#line 114 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\Curry.qs"
            var innerOp = curriedOp.Apply<IAdjointable>(first);
            innerOp.Adjoint.Apply(second);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((ICallable,__T,__U) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, ICallable curriedOp, __T first, __U second)
        {
            return __m__.Run<UncurryOpAImpl<__T,__U>, (ICallable,__T,__U), QVoid>((curriedOp, first, second));
        }
    }

    public class UncurryOpA<__T, __U> : Operation<ICallable, IAdjointable>, ICallable
    {
        public UncurryOpA(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "UncurryOpA";
        String ICallable.FullName => "Microsoft.Quantum.Canon.UncurryOpA";
        protected IAdjointable UncurryOpAImpl
        {
            get;
            set;
        }

        public override Func<ICallable, IAdjointable> Body => (__in) =>
        {
            var curriedOp = __in;
#line 144 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\Curry.qs"
            return UncurryOpAImpl.Partial((((ICallable)curriedOp), _, _));
        }

        ;
        public override void Init()
        {
            this.UncurryOpAImpl = this.Factory.Get<IAdjointable>(typeof(Microsoft.Quantum.Canon.UncurryOpAImpl<,>));
        }

        public override IApplyData __dataIn(ICallable data) => new QTuple<ICallable>(data);
        public override IApplyData __dataOut(IAdjointable data) => new QTuple<IAdjointable>(data);
        public static System.Threading.Tasks.Task<IAdjointable> Run(IOperationFactory __m__, ICallable curriedOp)
        {
            return __m__.Run<UncurryOpA<__T,__U>, ICallable, IAdjointable>(curriedOp);
        }
    }

    public class UncurryOpCAImpl<__T, __U> : Unitary<(ICallable,__T,__U)>, ICallable
    {
        public UncurryOpCAImpl(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(ICallable,__T,__U)>, IApplyData
        {
            public In((ICallable,__T,__U) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, Data.Item2?.GetQubits(), Data.Item3?.GetQubits());
        }

        String ICallable.Name => "UncurryOpCAImpl";
        String ICallable.FullName => "Microsoft.Quantum.Canon.UncurryOpCAImpl";
        public override Func<(ICallable,__T,__U), QVoid> Body => (__in) =>
        {
            var (curriedOp,first,second) = __in;
#line 149 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\Curry.qs"
            var innerOp = curriedOp.Apply<IUnitary>(first);
#line 150 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\Curry.qs"
            innerOp.Apply(second);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(ICallable,__T,__U), QVoid> AdjointBody => (__in) =>
        {
            var (curriedOp,first,second) = __in;
#line 149 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\Curry.qs"
            var innerOp = curriedOp.Apply<IUnitary>(first);
            innerOp.Adjoint.Apply(second);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(ICallable,__T,__U)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(curriedOp,first,second)) = __in;
            var innerOp = curriedOp.Apply<IUnitary>(first);
            innerOp.Controlled.Apply((controlQubits, second));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(ICallable,__T,__U)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,(curriedOp,first,second)) = __in;
            var innerOp = curriedOp.Apply<IUnitary>(first);
            innerOp.Adjoint.Controlled.Apply((controlQubits, second));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((ICallable,__T,__U) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, ICallable curriedOp, __T first, __U second)
        {
            return __m__.Run<UncurryOpCAImpl<__T,__U>, (ICallable,__T,__U), QVoid>((curriedOp, first, second));
        }
    }

    public class UncurryOpCA<__T, __U> : Operation<ICallable, IUnitary>, ICallable
    {
        public UncurryOpCA(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "UncurryOpCA";
        String ICallable.FullName => "Microsoft.Quantum.Canon.UncurryOpCA";
        protected IUnitary UncurryOpCAImpl
        {
            get;
            set;
        }

        public override Func<ICallable, IUnitary> Body => (__in) =>
        {
            var curriedOp = __in;
#line 181 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\Curry.qs"
            return UncurryOpCAImpl.Partial((((ICallable)curriedOp), _, _));
        }

        ;
        public override void Init()
        {
            this.UncurryOpCAImpl = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.UncurryOpCAImpl<,>));
        }

        public override IApplyData __dataIn(ICallable data) => new QTuple<ICallable>(data);
        public override IApplyData __dataOut(IUnitary data) => new QTuple<IUnitary>(data);
        public static System.Threading.Tasks.Task<IUnitary> Run(IOperationFactory __m__, ICallable curriedOp)
        {
            return __m__.Run<UncurryOpCA<__T,__U>, ICallable, IUnitary>(curriedOp);
        }
    }
}