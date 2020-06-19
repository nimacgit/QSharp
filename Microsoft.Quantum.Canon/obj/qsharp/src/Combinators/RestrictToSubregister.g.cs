#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "ApplyToSubregister (op : (Qubit[] => ()), idxs : Int[], target : Qubit[]) : ()", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\RestrictToSubregister.qs", 1158L, 32L, 93L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "ApplyToSubregisterA (op : (Qubit[] => () : Adjoint), idxs : Int[], target : Qubit[]) : ()", new string[] { "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\RestrictToSubregister.qs", 1937L, 54L, 104L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "ApplyToSubregisterC (op : (Qubit[] => () : Controlled), idxs : Int[], target : Qubit[]) : ()", new string[] { "Controlled" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\RestrictToSubregister.qs", 2775L, 78L, 107L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "ApplyToSubregisterCA (op : (Qubit[] => () : Controlled, Adjoint), idxs : Int[], target : Qubit[]) : ()", new string[] { "Controlled", "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\RestrictToSubregister.qs", 3700L, 103L, 117L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "RestrictToSubregister (op : (Qubit[] => ()), idxs : Int[]) : (Qubit[] => ())", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\RestrictToSubregister.qs", 4786L, 135L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "RestrictToSubregisterA (op : (Qubit[] => () : Adjoint), idxs : Int[]) : (Qubit[] => () : Adjoint)", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\RestrictToSubregister.qs", 5469L, 153L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "RestrictToSubregisterC (op : (Qubit[] => () : Controlled), idxs : Int[]) : (Qubit[] => () : Controlled)", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\RestrictToSubregister.qs", 6175L, 171L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "RestrictToSubregisterCA (op : (Qubit[] => () : Adjoint, Controlled), idxs : Int[]) : (Qubit[] => () : Adjoint, Controlled)", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\RestrictToSubregister.qs", 6904L, 189L, 14L)]
#line hidden
namespace Microsoft.Quantum.Canon
{
    public class ApplyToSubregister : Operation<(ICallable,QArray<Int64>,QArray<Qubit>), QVoid>, ICallable
    {
        public ApplyToSubregister(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(ICallable,QArray<Int64>,QArray<Qubit>)>, IApplyData
        {
            public In((ICallable,QArray<Int64>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "ApplyToSubregister";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ApplyToSubregister";
        protected ICallable Subarray
        {
            get;
            set;
        }

        public override Func<(ICallable,QArray<Int64>,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (op,idxs,target) = __in;
#line 34 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\RestrictToSubregister.qs"
            var subregister = Subarray.Apply<QArray<Qubit>>((idxs, target));
#line 35 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\RestrictToSubregister.qs"
            op.Apply(subregister);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Subarray = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Subarray<>));
        }

        public override IApplyData __dataIn((ICallable,QArray<Int64>,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, ICallable op, QArray<Int64> idxs, QArray<Qubit> target)
        {
            return __m__.Run<ApplyToSubregister, (ICallable,QArray<Int64>,QArray<Qubit>), QVoid>((op, idxs, target));
        }
    }

    public class ApplyToSubregisterA : Adjointable<(IAdjointable,QArray<Int64>,QArray<Qubit>)>, ICallable
    {
        public ApplyToSubregisterA(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IAdjointable,QArray<Int64>,QArray<Qubit>)>, IApplyData
        {
            public In((IAdjointable,QArray<Int64>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "ApplyToSubregisterA";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ApplyToSubregisterA";
        protected ICallable<(ICallable,QArray<Int64>,QArray<Qubit>), QVoid> ApplyToSubregister
        {
            get;
            set;
        }

        public override Func<(IAdjointable,QArray<Int64>,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (op,idxs,target) = __in;
#line 56 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\RestrictToSubregister.qs"
            ApplyToSubregister.Apply((((ICallable)op), idxs, target));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IAdjointable,QArray<Int64>,QArray<Qubit>), QVoid> AdjointBody => (__in) =>
        {
            var (op,idxs,target) = __in;
#line 59 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\RestrictToSubregister.qs"
            ApplyToSubregister.Apply((((ICallable)op.Adjoint), idxs, target));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.ApplyToSubregister = this.Factory.Get<ICallable<(ICallable,QArray<Int64>,QArray<Qubit>), QVoid>>(typeof(Microsoft.Quantum.Canon.ApplyToSubregister));
        }

        public override IApplyData __dataIn((IAdjointable,QArray<Int64>,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IAdjointable op, QArray<Int64> idxs, QArray<Qubit> target)
        {
            return __m__.Run<ApplyToSubregisterA, (IAdjointable,QArray<Int64>,QArray<Qubit>), QVoid>((op, idxs, target));
        }
    }

    public class ApplyToSubregisterC : Controllable<(IControllable,QArray<Int64>,QArray<Qubit>)>, ICallable
    {
        public ApplyToSubregisterC(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IControllable,QArray<Int64>,QArray<Qubit>)>, IApplyData
        {
            public In((IControllable,QArray<Int64>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "ApplyToSubregisterC";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ApplyToSubregisterC";
        protected ICallable<(ICallable,QArray<Int64>,QArray<Qubit>), QVoid> ApplyToSubregister
        {
            get;
            set;
        }

        public override Func<(IControllable,QArray<Int64>,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (op,idxs,target) = __in;
#line 80 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\RestrictToSubregister.qs"
            ApplyToSubregister.Apply((((ICallable)op), idxs, target));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(IControllable,QArray<Int64>,QArray<Qubit>)), QVoid> ControlledBody => (__in) =>
        {
            var (controls,(op,idxs,target)) = __in;
#line 83 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\RestrictToSubregister.qs"
            var cop = op.Controlled;
#line 84 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\RestrictToSubregister.qs"
            ApplyToSubregister.Apply((((ICallable)cop.Partial(new Func<QArray<Qubit>, (QArray<Qubit>,QArray<Qubit>)>((_arg1) => (controls, _arg1)))), idxs, target));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.ApplyToSubregister = this.Factory.Get<ICallable<(ICallable,QArray<Int64>,QArray<Qubit>), QVoid>>(typeof(Microsoft.Quantum.Canon.ApplyToSubregister));
        }

        public override IApplyData __dataIn((IControllable,QArray<Int64>,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IControllable op, QArray<Int64> idxs, QArray<Qubit> target)
        {
            return __m__.Run<ApplyToSubregisterC, (IControllable,QArray<Int64>,QArray<Qubit>), QVoid>((op, idxs, target));
        }
    }

    public class ApplyToSubregisterCA : Unitary<(IUnitary,QArray<Int64>,QArray<Qubit>)>, ICallable
    {
        public ApplyToSubregisterCA(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IUnitary,QArray<Int64>,QArray<Qubit>)>, IApplyData
        {
            public In((IUnitary,QArray<Int64>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "ApplyToSubregisterCA";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ApplyToSubregisterCA";
        protected ICallable<(ICallable,QArray<Int64>,QArray<Qubit>), QVoid> ApplyToSubregister
        {
            get;
            set;
        }

        public override Func<(IUnitary,QArray<Int64>,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (op,idxs,target) = __in;
#line 105 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\RestrictToSubregister.qs"
            ApplyToSubregister.Apply((((ICallable)op), idxs, target));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IUnitary,QArray<Int64>,QArray<Qubit>), QVoid> AdjointBody => (__in) =>
        {
            var (op,idxs,target) = __in;
#line 108 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\RestrictToSubregister.qs"
            ApplyToSubregister.Apply((((ICallable)op.Adjoint), idxs, target));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(IUnitary,QArray<Int64>,QArray<Qubit>)), QVoid> ControlledBody => (__in) =>
        {
            var (controls,(op,idxs,target)) = __in;
#line 111 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\RestrictToSubregister.qs"
            var cop = op.Controlled;
#line 112 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\RestrictToSubregister.qs"
            ApplyToSubregister.Apply((((ICallable)cop.Partial(new Func<QArray<Qubit>, (QArray<Qubit>,QArray<Qubit>)>((_arg1) => (controls, _arg1)))), idxs, target));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(IUnitary,QArray<Int64>,QArray<Qubit>)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controls,(op,idxs,target)) = __in;
#line 115 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\RestrictToSubregister.qs"
            var cop = op.Adjoint.Controlled;
#line 116 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\RestrictToSubregister.qs"
            ApplyToSubregister.Apply((((ICallable)cop.Partial(new Func<QArray<Qubit>, (QArray<Qubit>,QArray<Qubit>)>((_arg1) => (controls, _arg1)))), idxs, target));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.ApplyToSubregister = this.Factory.Get<ICallable<(ICallable,QArray<Int64>,QArray<Qubit>), QVoid>>(typeof(Microsoft.Quantum.Canon.ApplyToSubregister));
        }

        public override IApplyData __dataIn((IUnitary,QArray<Int64>,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IUnitary op, QArray<Int64> idxs, QArray<Qubit> target)
        {
            return __m__.Run<ApplyToSubregisterCA, (IUnitary,QArray<Int64>,QArray<Qubit>), QVoid>((op, idxs, target));
        }
    }

    public class RestrictToSubregister : Operation<(ICallable,QArray<Int64>), ICallable>, ICallable
    {
        public RestrictToSubregister(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(ICallable,QArray<Int64>)>, IApplyData
        {
            public In((ICallable,QArray<Int64>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "RestrictToSubregister";
        String ICallable.FullName => "Microsoft.Quantum.Canon.RestrictToSubregister";
        protected ICallable<(ICallable,QArray<Int64>,QArray<Qubit>), QVoid> ApplyToSubregister
        {
            get;
            set;
        }

        public override Func<(ICallable,QArray<Int64>), ICallable> Body => (__in) =>
        {
            var (op,idxs) = __in;
#line 136 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\RestrictToSubregister.qs"
            return ApplyToSubregister.Partial(new Func<QArray<Qubit>, (ICallable,QArray<Int64>,QArray<Qubit>)>((_arg1) => (((ICallable)op), idxs, _arg1)));
        }

        ;
        public override void Init()
        {
            this.ApplyToSubregister = this.Factory.Get<ICallable<(ICallable,QArray<Int64>,QArray<Qubit>), QVoid>>(typeof(Microsoft.Quantum.Canon.ApplyToSubregister));
        }

        public override IApplyData __dataIn((ICallable,QArray<Int64>) data) => new In(data);
        public override IApplyData __dataOut(ICallable data) => new QTuple<ICallable>(data);
        public static System.Threading.Tasks.Task<ICallable> Run(IOperationFactory __m__, ICallable op, QArray<Int64> idxs)
        {
            return __m__.Run<RestrictToSubregister, (ICallable,QArray<Int64>), ICallable>((op, idxs));
        }
    }

    public class RestrictToSubregisterA : Operation<(IAdjointable,QArray<Int64>), IAdjointable>, ICallable
    {
        public RestrictToSubregisterA(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IAdjointable,QArray<Int64>)>, IApplyData
        {
            public In((IAdjointable,QArray<Int64>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "RestrictToSubregisterA";
        String ICallable.FullName => "Microsoft.Quantum.Canon.RestrictToSubregisterA";
        protected IAdjointable<(IAdjointable,QArray<Int64>,QArray<Qubit>)> ApplyToSubregisterA
        {
            get;
            set;
        }

        public override Func<(IAdjointable,QArray<Int64>), IAdjointable> Body => (__in) =>
        {
            var (op,idxs) = __in;
#line 154 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\RestrictToSubregister.qs"
            return ApplyToSubregisterA.Partial(new Func<QArray<Qubit>, (IAdjointable,QArray<Int64>,QArray<Qubit>)>((_arg1) => (((IAdjointable)op), idxs, _arg1)));
        }

        ;
        public override void Init()
        {
            this.ApplyToSubregisterA = this.Factory.Get<IAdjointable<(IAdjointable,QArray<Int64>,QArray<Qubit>)>>(typeof(Microsoft.Quantum.Canon.ApplyToSubregisterA));
        }

        public override IApplyData __dataIn((IAdjointable,QArray<Int64>) data) => new In(data);
        public override IApplyData __dataOut(IAdjointable data) => new QTuple<IAdjointable>(data);
        public static System.Threading.Tasks.Task<IAdjointable> Run(IOperationFactory __m__, IAdjointable op, QArray<Int64> idxs)
        {
            return __m__.Run<RestrictToSubregisterA, (IAdjointable,QArray<Int64>), IAdjointable>((op, idxs));
        }
    }

    public class RestrictToSubregisterC : Operation<(IControllable,QArray<Int64>), IControllable>, ICallable
    {
        public RestrictToSubregisterC(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IControllable,QArray<Int64>)>, IApplyData
        {
            public In((IControllable,QArray<Int64>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "RestrictToSubregisterC";
        String ICallable.FullName => "Microsoft.Quantum.Canon.RestrictToSubregisterC";
        protected IControllable<(IControllable,QArray<Int64>,QArray<Qubit>)> ApplyToSubregisterC
        {
            get;
            set;
        }

        public override Func<(IControllable,QArray<Int64>), IControllable> Body => (__in) =>
        {
            var (op,idxs) = __in;
#line 172 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\RestrictToSubregister.qs"
            return ApplyToSubregisterC.Partial(new Func<QArray<Qubit>, (IControllable,QArray<Int64>,QArray<Qubit>)>((_arg1) => (((IControllable)op), idxs, _arg1)));
        }

        ;
        public override void Init()
        {
            this.ApplyToSubregisterC = this.Factory.Get<IControllable<(IControllable,QArray<Int64>,QArray<Qubit>)>>(typeof(Microsoft.Quantum.Canon.ApplyToSubregisterC));
        }

        public override IApplyData __dataIn((IControllable,QArray<Int64>) data) => new In(data);
        public override IApplyData __dataOut(IControllable data) => new QTuple<IControllable>(data);
        public static System.Threading.Tasks.Task<IControllable> Run(IOperationFactory __m__, IControllable op, QArray<Int64> idxs)
        {
            return __m__.Run<RestrictToSubregisterC, (IControllable,QArray<Int64>), IControllable>((op, idxs));
        }
    }

    public class RestrictToSubregisterCA : Operation<(IUnitary,QArray<Int64>), IUnitary>, ICallable
    {
        public RestrictToSubregisterCA(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IUnitary,QArray<Int64>)>, IApplyData
        {
            public In((IUnitary,QArray<Int64>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "RestrictToSubregisterCA";
        String ICallable.FullName => "Microsoft.Quantum.Canon.RestrictToSubregisterCA";
        protected IUnitary<(IUnitary,QArray<Int64>,QArray<Qubit>)> ApplyToSubregisterCA
        {
            get;
            set;
        }

        public override Func<(IUnitary,QArray<Int64>), IUnitary> Body => (__in) =>
        {
            var (op,idxs) = __in;
#line 190 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\RestrictToSubregister.qs"
            return ApplyToSubregisterCA.Partial(new Func<QArray<Qubit>, (IUnitary,QArray<Int64>,QArray<Qubit>)>((_arg1) => (((IUnitary)op), idxs, _arg1)));
        }

        ;
        public override void Init()
        {
            this.ApplyToSubregisterCA = this.Factory.Get<IUnitary<(IUnitary,QArray<Int64>,QArray<Qubit>)>>(typeof(Microsoft.Quantum.Canon.ApplyToSubregisterCA));
        }

        public override IApplyData __dataIn((IUnitary,QArray<Int64>) data) => new In(data);
        public override IApplyData __dataOut(IUnitary data) => new QTuple<IUnitary>(data);
        public static System.Threading.Tasks.Task<IUnitary> Run(IOperationFactory __m__, IUnitary op, QArray<Int64> idxs)
        {
            return __m__.Run<RestrictToSubregisterCA, (IUnitary,QArray<Int64>), IUnitary>((op, idxs));
        }
    }
}