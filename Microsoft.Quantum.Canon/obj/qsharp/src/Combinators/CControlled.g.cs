#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "ApplyIf<'T> (op : ('T => ()), bit : Bool, target : 'T) : ()", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\CControlled.qs", 927L, 28L, 5L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "ApplyIfC<'T> (op : ('T => () : Controlled), bit : Bool, target : 'T) : ()", new string[] { "Controlled" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\CControlled.qs", 1811L, 56L, 5L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "ApplyIfA<'T> (op : ('T => () : Adjoint), bit : Bool, target : 'T) : ()", new string[] { "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\CControlled.qs", 2719L, 86L, 5L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "ApplyIfCA<'T> (op : ('T => () : Controlled, Adjoint), bit : Bool, target : 'T) : ()", new string[] { "Controlled", "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\CControlled.qs", 3654L, 116L, 5L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "CControlled<'T> (op : ('T => ())) : ((Bool, 'T) => ())", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\CControlled.qs", 4508L, 147L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "CControlledC<'T> (op : ('T => () : Controlled)) : ((Bool, 'T) => () : Controlled)", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\CControlled.qs", 5262L, 170L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "CControlledA<'T> (op : ('T => () : Adjoint)) : ((Bool, 'T) => () : Adjoint)", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\CControlled.qs", 6044L, 193L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "CControlledCA<'T> (op : ('T => () : Controlled, Adjoint)) : ((Bool, 'T) => () : Controlled, Adjoint)", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\CControlled.qs", 6837L, 216L, 14L)]
#line hidden
namespace Microsoft.Quantum.Canon
{
    public class ApplyIf<__T> : Operation<(ICallable,Boolean,__T), QVoid>, ICallable
    {
        public ApplyIf(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(ICallable,Boolean,__T)>, IApplyData
        {
            public In((ICallable,Boolean,__T) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, Data.Item3?.GetQubits());
        }

        String ICallable.Name => "ApplyIf";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ApplyIf";
        public override Func<(ICallable,Boolean,__T), QVoid> Body => (__in) =>
        {
            var (op,bit,target) = __in;
#line 30 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\CControlled.qs"
            if (bit)
            {
#line 31 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\CControlled.qs"
                op.Apply(target);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((ICallable,Boolean,__T) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, ICallable op, Boolean bit, __T target)
        {
            return __m__.Run<ApplyIf<__T>, (ICallable,Boolean,__T), QVoid>((op, bit, target));
        }
    }

    public class ApplyIfC<__T> : Controllable<(IControllable,Boolean,__T)>, ICallable
    {
        public ApplyIfC(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IControllable,Boolean,__T)>, IApplyData
        {
            public In((IControllable,Boolean,__T) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, Data.Item3?.GetQubits());
        }

        String ICallable.Name => "ApplyIfC";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ApplyIfC";
        public override Func<(IControllable,Boolean,__T), QVoid> Body => (__in) =>
        {
            var (op,bit,target) = __in;
#line 58 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\CControlled.qs"
            if (bit)
            {
#line 59 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\CControlled.qs"
                op.Apply(target);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(IControllable,Boolean,__T)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(op,bit,target)) = __in;
            if (bit)
            {
                op.Controlled.Apply((controlQubits, target));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((IControllable,Boolean,__T) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IControllable op, Boolean bit, __T target)
        {
            return __m__.Run<ApplyIfC<__T>, (IControllable,Boolean,__T), QVoid>((op, bit, target));
        }
    }

    public class ApplyIfA<__T> : Adjointable<(IAdjointable,Boolean,__T)>, ICallable
    {
        public ApplyIfA(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IAdjointable,Boolean,__T)>, IApplyData
        {
            public In((IAdjointable,Boolean,__T) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, Data.Item3?.GetQubits());
        }

        String ICallable.Name => "ApplyIfA";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ApplyIfA";
        public override Func<(IAdjointable,Boolean,__T), QVoid> Body => (__in) =>
        {
            var (op,bit,target) = __in;
#line 88 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\CControlled.qs"
            if (bit)
            {
#line 89 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\CControlled.qs"
                op.Apply(target);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IAdjointable,Boolean,__T), QVoid> AdjointBody => (__in) =>
        {
            var (op,bit,target) = __in;
            if (bit)
            {
                op.Adjoint.Apply(target);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((IAdjointable,Boolean,__T) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IAdjointable op, Boolean bit, __T target)
        {
            return __m__.Run<ApplyIfA<__T>, (IAdjointable,Boolean,__T), QVoid>((op, bit, target));
        }
    }

    public class ApplyIfCA<__T> : Unitary<(IUnitary,Boolean,__T)>, ICallable
    {
        public ApplyIfCA(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IUnitary,Boolean,__T)>, IApplyData
        {
            public In((IUnitary,Boolean,__T) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, Data.Item3?.GetQubits());
        }

        String ICallable.Name => "ApplyIfCA";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ApplyIfCA";
        public override Func<(IUnitary,Boolean,__T), QVoid> Body => (__in) =>
        {
            var (op,bit,target) = __in;
#line 118 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\CControlled.qs"
            if (bit)
            {
#line 119 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\CControlled.qs"
                op.Apply(target);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IUnitary,Boolean,__T), QVoid> AdjointBody => (__in) =>
        {
            var (op,bit,target) = __in;
            if (bit)
            {
                op.Adjoint.Apply(target);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(IUnitary,Boolean,__T)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(op,bit,target)) = __in;
            if (bit)
            {
                op.Controlled.Apply((controlQubits, target));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(IUnitary,Boolean,__T)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,(op,bit,target)) = __in;
            if (bit)
            {
                op.Adjoint.Controlled.Apply((controlQubits, target));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((IUnitary,Boolean,__T) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IUnitary op, Boolean bit, __T target)
        {
            return __m__.Run<ApplyIfCA<__T>, (IUnitary,Boolean,__T), QVoid>((op, bit, target));
        }
    }

    public class CControlled<__T> : Operation<ICallable, ICallable>, ICallable
    {
        public CControlled(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "CControlled";
        String ICallable.FullName => "Microsoft.Quantum.Canon.CControlled";
        protected ICallable ApplyIf
        {
            get;
            set;
        }

        public override Func<ICallable, ICallable> Body => (__in) =>
        {
            var op = __in;
#line 149 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\CControlled.qs"
            return ApplyIf.Partial((((ICallable)op), _, _));
        }

        ;
        public override void Init()
        {
            this.ApplyIf = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ApplyIf<>));
        }

        public override IApplyData __dataIn(ICallable data) => new QTuple<ICallable>(data);
        public override IApplyData __dataOut(ICallable data) => new QTuple<ICallable>(data);
        public static System.Threading.Tasks.Task<ICallable> Run(IOperationFactory __m__, ICallable op)
        {
            return __m__.Run<CControlled<__T>, ICallable, ICallable>(op);
        }
    }

    public class CControlledC<__T> : Operation<IControllable, IControllable>, ICallable
    {
        public CControlledC(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "CControlledC";
        String ICallable.FullName => "Microsoft.Quantum.Canon.CControlledC";
        protected IControllable ApplyIfC
        {
            get;
            set;
        }

        public override Func<IControllable, IControllable> Body => (__in) =>
        {
            var op = __in;
#line 172 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\CControlled.qs"
            return ApplyIfC.Partial((((IControllable)op), _, _));
        }

        ;
        public override void Init()
        {
            this.ApplyIfC = this.Factory.Get<IControllable>(typeof(Microsoft.Quantum.Canon.ApplyIfC<>));
        }

        public override IApplyData __dataIn(IControllable data) => new QTuple<IControllable>(data);
        public override IApplyData __dataOut(IControllable data) => new QTuple<IControllable>(data);
        public static System.Threading.Tasks.Task<IControllable> Run(IOperationFactory __m__, IControllable op)
        {
            return __m__.Run<CControlledC<__T>, IControllable, IControllable>(op);
        }
    }

    public class CControlledA<__T> : Operation<IAdjointable, IAdjointable>, ICallable
    {
        public CControlledA(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "CControlledA";
        String ICallable.FullName => "Microsoft.Quantum.Canon.CControlledA";
        protected IAdjointable ApplyIfA
        {
            get;
            set;
        }

        public override Func<IAdjointable, IAdjointable> Body => (__in) =>
        {
            var op = __in;
#line 195 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\CControlled.qs"
            return ApplyIfA.Partial((((IAdjointable)op), _, _));
        }

        ;
        public override void Init()
        {
            this.ApplyIfA = this.Factory.Get<IAdjointable>(typeof(Microsoft.Quantum.Canon.ApplyIfA<>));
        }

        public override IApplyData __dataIn(IAdjointable data) => new QTuple<IAdjointable>(data);
        public override IApplyData __dataOut(IAdjointable data) => new QTuple<IAdjointable>(data);
        public static System.Threading.Tasks.Task<IAdjointable> Run(IOperationFactory __m__, IAdjointable op)
        {
            return __m__.Run<CControlledA<__T>, IAdjointable, IAdjointable>(op);
        }
    }

    public class CControlledCA<__T> : Operation<IUnitary, IUnitary>, ICallable
    {
        public CControlledCA(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "CControlledCA";
        String ICallable.FullName => "Microsoft.Quantum.Canon.CControlledCA";
        protected IUnitary ApplyIfCA
        {
            get;
            set;
        }

        public override Func<IUnitary, IUnitary> Body => (__in) =>
        {
            var op = __in;
#line 218 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\CControlled.qs"
            return ApplyIfCA.Partial((((IUnitary)op), _, _));
        }

        ;
        public override void Init()
        {
            this.ApplyIfCA = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.ApplyIfCA<>));
        }

        public override IApplyData __dataIn(IUnitary data) => new QTuple<IUnitary>(data);
        public override IApplyData __dataOut(IUnitary data) => new QTuple<IUnitary>(data);
        public static System.Threading.Tasks.Task<IUnitary> Run(IOperationFactory __m__, IUnitary op)
        {
            return __m__.Run<CControlledCA<__T>, IUnitary, IUnitary>(op);
        }
    }
}