#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "OperationPowImpl<'T> (oracle : ('T => ()), power : Int, target : 'T) : ()", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\OperationPow.qs", 234L, 8L, 5L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "OperationPowImplC<'T> (oracle : ('T => () : Controlled), power : Int, target : 'T) : ()", new string[] { "Controlled" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\OperationPow.qs", 480L, 17L, 5L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "OperationPowImplA<'T> (oracle : ('T => () : Adjoint), power : Int, target : 'T) : ()", new string[] { "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\OperationPow.qs", 750L, 28L, 5L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "OperationPowImplCA<'T> (oracle : ('T => () : Controlled, Adjoint), power : Int, target : 'T) : ()", new string[] { "Controlled", "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\OperationPow.qs", 1030L, 39L, 5L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "OperationPow<'T> (oracle : ('T => ()), power : Int) : ('T => ())", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\OperationPow.qs", 1965L, 72L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "OperationPowC<'T> (oracle : ('T => () : Controlled), power : Int) : ('T => () : Controlled)", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\OperationPow.qs", 2779L, 97L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "OperationPowA<'T> (oracle : ('T => () : Adjoint), power : Int) : ('T => () : Adjoint)", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\OperationPow.qs", 3621L, 122L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "OperationPowCA<'T> (oracle : ('T => () : Controlled, Adjoint), power : Int) : ('T => () : Controlled, Adjoint)", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\OperationPow.qs", 4474L, 147L, 14L)]
#line hidden
namespace Microsoft.Quantum.Canon
{
    public class OperationPowImpl<__T> : Operation<(ICallable,Int64,__T), QVoid>, ICallable
    {
        public OperationPowImpl(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(ICallable,Int64,__T)>, IApplyData
        {
            public In((ICallable,Int64,__T) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, Data.Item3?.GetQubits());
        }

        String ICallable.Name => "OperationPowImpl";
        String ICallable.FullName => "Microsoft.Quantum.Canon.OperationPowImpl";
        public override Func<(ICallable,Int64,__T), QVoid> Body => (__in) =>
        {
            var (oracle,power,target) = __in;
#line 10 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\OperationPow.qs"
            foreach (var idxApplication in new Range(0L, (power - 1L)))
            {
#line 11 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\OperationPow.qs"
                oracle.Apply(target);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((ICallable,Int64,__T) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, ICallable oracle, Int64 power, __T target)
        {
            return __m__.Run<OperationPowImpl<__T>, (ICallable,Int64,__T), QVoid>((oracle, power, target));
        }
    }

    public class OperationPowImplC<__T> : Controllable<(IControllable,Int64,__T)>, ICallable
    {
        public OperationPowImplC(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IControllable,Int64,__T)>, IApplyData
        {
            public In((IControllable,Int64,__T) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, Data.Item3?.GetQubits());
        }

        String ICallable.Name => "OperationPowImplC";
        String ICallable.FullName => "Microsoft.Quantum.Canon.OperationPowImplC";
        public override Func<(IControllable,Int64,__T), QVoid> Body => (__in) =>
        {
            var (oracle,power,target) = __in;
#line 19 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\OperationPow.qs"
            foreach (var idxApplication in new Range(0L, (power - 1L)))
            {
#line 20 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\OperationPow.qs"
                oracle.Apply(target);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(IControllable,Int64,__T)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(oracle,power,target)) = __in;
            foreach (var idxApplication in new Range(0L, (power - 1L)))
            {
                oracle.Controlled.Apply((controlQubits, target));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((IControllable,Int64,__T) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IControllable oracle, Int64 power, __T target)
        {
            return __m__.Run<OperationPowImplC<__T>, (IControllable,Int64,__T), QVoid>((oracle, power, target));
        }
    }

    public class OperationPowImplA<__T> : Adjointable<(IAdjointable,Int64,__T)>, ICallable
    {
        public OperationPowImplA(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IAdjointable,Int64,__T)>, IApplyData
        {
            public In((IAdjointable,Int64,__T) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, Data.Item3?.GetQubits());
        }

        String ICallable.Name => "OperationPowImplA";
        String ICallable.FullName => "Microsoft.Quantum.Canon.OperationPowImplA";
        public override Func<(IAdjointable,Int64,__T), QVoid> Body => (__in) =>
        {
            var (oracle,power,target) = __in;
#line 30 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\OperationPow.qs"
            foreach (var idxApplication in new Range(0L, (power - 1L)))
            {
#line 31 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\OperationPow.qs"
                oracle.Apply(target);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IAdjointable,Int64,__T), QVoid> AdjointBody => (__in) =>
        {
            var (oracle,power,target) = __in;
            foreach (var idxApplication in new Range((0L - ((((power - 1L) - 0L) / 1L) * -(1L))), -(1L), 0L))
            {
                oracle.Adjoint.Apply(target);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((IAdjointable,Int64,__T) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IAdjointable oracle, Int64 power, __T target)
        {
            return __m__.Run<OperationPowImplA<__T>, (IAdjointable,Int64,__T), QVoid>((oracle, power, target));
        }
    }

    public class OperationPowImplCA<__T> : Unitary<(IUnitary,Int64,__T)>, ICallable
    {
        public OperationPowImplCA(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IUnitary,Int64,__T)>, IApplyData
        {
            public In((IUnitary,Int64,__T) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, Data.Item3?.GetQubits());
        }

        String ICallable.Name => "OperationPowImplCA";
        String ICallable.FullName => "Microsoft.Quantum.Canon.OperationPowImplCA";
        public override Func<(IUnitary,Int64,__T), QVoid> Body => (__in) =>
        {
            var (oracle,power,target) = __in;
#line 41 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\OperationPow.qs"
            foreach (var idxApplication in new Range(0L, (power - 1L)))
            {
#line 42 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\OperationPow.qs"
                oracle.Apply(target);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IUnitary,Int64,__T), QVoid> AdjointBody => (__in) =>
        {
            var (oracle,power,target) = __in;
            foreach (var idxApplication in new Range((0L - ((((power - 1L) - 0L) / 1L) * -(1L))), -(1L), 0L))
            {
                oracle.Adjoint.Apply(target);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(IUnitary,Int64,__T)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(oracle,power,target)) = __in;
            foreach (var idxApplication in new Range(0L, (power - 1L)))
            {
                oracle.Controlled.Apply((controlQubits, target));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(IUnitary,Int64,__T)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,(oracle,power,target)) = __in;
            foreach (var idxApplication in new Range((0L - ((((power - 1L) - 0L) / 1L) * -(1L))), -(1L), 0L))
            {
                oracle.Adjoint.Controlled.Apply((controlQubits, target));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((IUnitary,Int64,__T) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IUnitary oracle, Int64 power, __T target)
        {
            return __m__.Run<OperationPowImplCA<__T>, (IUnitary,Int64,__T), QVoid>((oracle, power, target));
        }
    }

    public class OperationPow<__T> : Operation<(ICallable,Int64), ICallable>, ICallable
    {
        public OperationPow(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(ICallable,Int64)>, IApplyData
        {
            public In((ICallable,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "OperationPow";
        String ICallable.FullName => "Microsoft.Quantum.Canon.OperationPow";
        protected ICallable OperationPowImpl
        {
            get;
            set;
        }

        public override Func<(ICallable,Int64), ICallable> Body => (__in) =>
        {
            var (oracle,power) = __in;
#line 74 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\OperationPow.qs"
            return OperationPowImpl.Partial((((ICallable)oracle), power, _));
        }

        ;
        public override void Init()
        {
            this.OperationPowImpl = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.OperationPowImpl<>));
        }

        public override IApplyData __dataIn((ICallable,Int64) data) => new In(data);
        public override IApplyData __dataOut(ICallable data) => new QTuple<ICallable>(data);
        public static System.Threading.Tasks.Task<ICallable> Run(IOperationFactory __m__, ICallable oracle, Int64 power)
        {
            return __m__.Run<OperationPow<__T>, (ICallable,Int64), ICallable>((oracle, power));
        }
    }

    public class OperationPowC<__T> : Operation<(IControllable,Int64), IControllable>, ICallable
    {
        public OperationPowC(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IControllable,Int64)>, IApplyData
        {
            public In((IControllable,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "OperationPowC";
        String ICallable.FullName => "Microsoft.Quantum.Canon.OperationPowC";
        protected IControllable OperationPowImplC
        {
            get;
            set;
        }

        public override Func<(IControllable,Int64), IControllable> Body => (__in) =>
        {
            var (oracle,power) = __in;
#line 99 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\OperationPow.qs"
            return OperationPowImplC.Partial((((IControllable)oracle), power, _));
        }

        ;
        public override void Init()
        {
            this.OperationPowImplC = this.Factory.Get<IControllable>(typeof(Microsoft.Quantum.Canon.OperationPowImplC<>));
        }

        public override IApplyData __dataIn((IControllable,Int64) data) => new In(data);
        public override IApplyData __dataOut(IControllable data) => new QTuple<IControllable>(data);
        public static System.Threading.Tasks.Task<IControllable> Run(IOperationFactory __m__, IControllable oracle, Int64 power)
        {
            return __m__.Run<OperationPowC<__T>, (IControllable,Int64), IControllable>((oracle, power));
        }
    }

    public class OperationPowA<__T> : Operation<(IAdjointable,Int64), IAdjointable>, ICallable
    {
        public OperationPowA(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IAdjointable,Int64)>, IApplyData
        {
            public In((IAdjointable,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "OperationPowA";
        String ICallable.FullName => "Microsoft.Quantum.Canon.OperationPowA";
        protected IAdjointable OperationPowImplA
        {
            get;
            set;
        }

        public override Func<(IAdjointable,Int64), IAdjointable> Body => (__in) =>
        {
            var (oracle,power) = __in;
#line 124 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\OperationPow.qs"
            return OperationPowImplA.Partial((((IAdjointable)oracle), power, _));
        }

        ;
        public override void Init()
        {
            this.OperationPowImplA = this.Factory.Get<IAdjointable>(typeof(Microsoft.Quantum.Canon.OperationPowImplA<>));
        }

        public override IApplyData __dataIn((IAdjointable,Int64) data) => new In(data);
        public override IApplyData __dataOut(IAdjointable data) => new QTuple<IAdjointable>(data);
        public static System.Threading.Tasks.Task<IAdjointable> Run(IOperationFactory __m__, IAdjointable oracle, Int64 power)
        {
            return __m__.Run<OperationPowA<__T>, (IAdjointable,Int64), IAdjointable>((oracle, power));
        }
    }

    public class OperationPowCA<__T> : Operation<(IUnitary,Int64), IUnitary>, ICallable
    {
        public OperationPowCA(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IUnitary,Int64)>, IApplyData
        {
            public In((IUnitary,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "OperationPowCA";
        String ICallable.FullName => "Microsoft.Quantum.Canon.OperationPowCA";
        protected IUnitary OperationPowImplCA
        {
            get;
            set;
        }

        public override Func<(IUnitary,Int64), IUnitary> Body => (__in) =>
        {
            var (oracle,power) = __in;
#line 149 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\OperationPow.qs"
            return OperationPowImplCA.Partial((((IUnitary)oracle), power, _));
        }

        ;
        public override void Init()
        {
            this.OperationPowImplCA = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.OperationPowImplCA<>));
        }

        public override IApplyData __dataIn((IUnitary,Int64) data) => new In(data);
        public override IApplyData __dataOut(IUnitary data) => new QTuple<IUnitary>(data);
        public static System.Threading.Tasks.Task<IUnitary> Run(IOperationFactory __m__, IUnitary oracle, Int64 power)
        {
            return __m__.Run<OperationPowCA<__T>, (IUnitary,Int64), IUnitary>((oracle, power));
        }
    }
}