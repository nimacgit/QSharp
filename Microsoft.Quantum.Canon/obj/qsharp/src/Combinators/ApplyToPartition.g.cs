#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "ApplyToPartition (op : ((Qubit[], Qubit[]) => ()), numberOfQubitsToFirstArgument : Int, target : Qubit[]) : ()", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToPartition.qs", 1051L, 28L, 16L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "ApplyToPartitionA (op : ((Qubit[], Qubit[]) => () : Adjoint), numberOfQubitsToFirstArgument : Int, target : Qubit[]) : ()", new string[] { "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToPartition.qs", 2460L, 61L, 16L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "ApplyToPartitionC (op : ((Qubit[], Qubit[]) => () : Controlled), numberOfQubitsToFirstArgument : Int, target : Qubit[]) : ()", new string[] { "Controlled" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToPartition.qs", 3899L, 95L, 16L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "ApplyToPartitionCA (op : ((Qubit[], Qubit[]) => () : Controlled, Adjoint), numberOfQubitsToFirstArgument : Int, target : Qubit[]) : ()", new string[] { "Controlled", "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToPartition.qs", 5370L, 130L, 16L)]
#line hidden
namespace Microsoft.Quantum.Canon
{
    public class ApplyToPartition : Operation<(ICallable,Int64,QArray<Qubit>), QVoid>, ICallable
    {
        public ApplyToPartition(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(ICallable,Int64,QArray<Qubit>)>, IApplyData
        {
            public In((ICallable,Int64,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "ApplyToPartition";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ApplyToPartition";
        protected ICallable<(Boolean,Boolean,String), QVoid> AssertBoolEqual
        {
            get;
            set;
        }

        public override Func<(ICallable,Int64,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (op,numberOfQubitsToFirstArgument,target) = __in;
#line 30 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToPartition.qs"
            AssertBoolEqual.Apply(((numberOfQubitsToFirstArgument >= 0L), true, "numberOfQubitsToFirstArgument must be non-negative"));
#line 32 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToPartition.qs"
            AssertBoolEqual.Apply(((target.Count >= numberOfQubitsToFirstArgument), true, "Length(target) must greater or equal to numberOfQubitsToFirstArgument"));
#line 35 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToPartition.qs"
            op.Apply((target?.Slice(new Range(0L, (numberOfQubitsToFirstArgument - 1L))), target?.Slice(new Range(numberOfQubitsToFirstArgument, (target.Count - 1L)))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.AssertBoolEqual = this.Factory.Get<ICallable<(Boolean,Boolean,String), QVoid>>(typeof(Microsoft.Quantum.Canon.AssertBoolEqual));
        }

        public override IApplyData __dataIn((ICallable,Int64,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, ICallable op, Int64 numberOfQubitsToFirstArgument, QArray<Qubit> target)
        {
            return __m__.Run<ApplyToPartition, (ICallable,Int64,QArray<Qubit>), QVoid>((op, numberOfQubitsToFirstArgument, target));
        }
    }

    public class ApplyToPartitionA : Adjointable<(IAdjointable,Int64,QArray<Qubit>)>, ICallable
    {
        public ApplyToPartitionA(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IAdjointable,Int64,QArray<Qubit>)>, IApplyData
        {
            public In((IAdjointable,Int64,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "ApplyToPartitionA";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ApplyToPartitionA";
        protected ICallable<(Boolean,Boolean,String), QVoid> AssertBoolEqual
        {
            get;
            set;
        }

        public override Func<(IAdjointable,Int64,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (op,numberOfQubitsToFirstArgument,target) = __in;
#line 63 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToPartition.qs"
            AssertBoolEqual.Apply(((numberOfQubitsToFirstArgument >= 0L), true, "numberOfQubitsToFirstArgument must be non-negative"));
#line 65 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToPartition.qs"
            AssertBoolEqual.Apply(((target.Count >= numberOfQubitsToFirstArgument), true, "Length(target) must greater or equal to numberOfQubitsToFirstArgument"));
#line 68 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToPartition.qs"
            op.Apply((target?.Slice(new Range(0L, (numberOfQubitsToFirstArgument - 1L))), target?.Slice(new Range(numberOfQubitsToFirstArgument, (target.Count - 1L)))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IAdjointable,Int64,QArray<Qubit>), QVoid> AdjointBody => (__in) =>
        {
            var (op,numberOfQubitsToFirstArgument,target) = __in;
            AssertBoolEqual.Apply(((numberOfQubitsToFirstArgument >= 0L), true, "numberOfQubitsToFirstArgument must be non-negative"));
            AssertBoolEqual.Apply(((target.Count >= numberOfQubitsToFirstArgument), true, "Length(target) must greater or equal to numberOfQubitsToFirstArgument"));
            op.Adjoint.Apply((target?.Slice(new Range(0L, (numberOfQubitsToFirstArgument - 1L))), target?.Slice(new Range(numberOfQubitsToFirstArgument, (target.Count - 1L)))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.AssertBoolEqual = this.Factory.Get<ICallable<(Boolean,Boolean,String), QVoid>>(typeof(Microsoft.Quantum.Canon.AssertBoolEqual));
        }

        public override IApplyData __dataIn((IAdjointable,Int64,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IAdjointable op, Int64 numberOfQubitsToFirstArgument, QArray<Qubit> target)
        {
            return __m__.Run<ApplyToPartitionA, (IAdjointable,Int64,QArray<Qubit>), QVoid>((op, numberOfQubitsToFirstArgument, target));
        }
    }

    public class ApplyToPartitionC : Controllable<(IControllable,Int64,QArray<Qubit>)>, ICallable
    {
        public ApplyToPartitionC(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IControllable,Int64,QArray<Qubit>)>, IApplyData
        {
            public In((IControllable,Int64,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "ApplyToPartitionC";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ApplyToPartitionC";
        protected ICallable<(Boolean,Boolean,String), QVoid> AssertBoolEqual
        {
            get;
            set;
        }

        public override Func<(IControllable,Int64,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (op,numberOfQubitsToFirstArgument,target) = __in;
#line 97 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToPartition.qs"
            AssertBoolEqual.Apply(((numberOfQubitsToFirstArgument >= 0L), true, "numberOfQubitsToFirstArgument must be non-negative"));
#line 99 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToPartition.qs"
            AssertBoolEqual.Apply(((target.Count >= numberOfQubitsToFirstArgument), true, "Length(target) must greater or equal to numberOfQubitsToFirstArgument"));
#line 102 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToPartition.qs"
            op.Apply((target?.Slice(new Range(0L, (numberOfQubitsToFirstArgument - 1L))), target?.Slice(new Range(numberOfQubitsToFirstArgument, (target.Count - 1L)))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(IControllable,Int64,QArray<Qubit>)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(op,numberOfQubitsToFirstArgument,target)) = __in;
            AssertBoolEqual.Apply(((numberOfQubitsToFirstArgument >= 0L), true, "numberOfQubitsToFirstArgument must be non-negative"));
            AssertBoolEqual.Apply(((target.Count >= numberOfQubitsToFirstArgument), true, "Length(target) must greater or equal to numberOfQubitsToFirstArgument"));
            op.Controlled.Apply((controlQubits, (target?.Slice(new Range(0L, (numberOfQubitsToFirstArgument - 1L))), target?.Slice(new Range(numberOfQubitsToFirstArgument, (target.Count - 1L))))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.AssertBoolEqual = this.Factory.Get<ICallable<(Boolean,Boolean,String), QVoid>>(typeof(Microsoft.Quantum.Canon.AssertBoolEqual));
        }

        public override IApplyData __dataIn((IControllable,Int64,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IControllable op, Int64 numberOfQubitsToFirstArgument, QArray<Qubit> target)
        {
            return __m__.Run<ApplyToPartitionC, (IControllable,Int64,QArray<Qubit>), QVoid>((op, numberOfQubitsToFirstArgument, target));
        }
    }

    public class ApplyToPartitionCA : Unitary<(IUnitary,Int64,QArray<Qubit>)>, ICallable
    {
        public ApplyToPartitionCA(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IUnitary,Int64,QArray<Qubit>)>, IApplyData
        {
            public In((IUnitary,Int64,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "ApplyToPartitionCA";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ApplyToPartitionCA";
        protected ICallable<(Boolean,Boolean,String), QVoid> AssertBoolEqual
        {
            get;
            set;
        }

        public override Func<(IUnitary,Int64,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (op,numberOfQubitsToFirstArgument,target) = __in;
#line 132 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToPartition.qs"
            AssertBoolEqual.Apply(((numberOfQubitsToFirstArgument >= 0L), true, "numberOfQubitsToFirstArgument must be non-negative"));
#line 134 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToPartition.qs"
            AssertBoolEqual.Apply(((target.Count >= numberOfQubitsToFirstArgument), true, "Length(target) must greater or equal to numberOfQubitsToFirstArgument"));
#line 137 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToPartition.qs"
            op.Apply((target?.Slice(new Range(0L, (numberOfQubitsToFirstArgument - 1L))), target?.Slice(new Range(numberOfQubitsToFirstArgument, (target.Count - 1L)))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IUnitary,Int64,QArray<Qubit>), QVoid> AdjointBody => (__in) =>
        {
            var (op,numberOfQubitsToFirstArgument,target) = __in;
            AssertBoolEqual.Apply(((numberOfQubitsToFirstArgument >= 0L), true, "numberOfQubitsToFirstArgument must be non-negative"));
            AssertBoolEqual.Apply(((target.Count >= numberOfQubitsToFirstArgument), true, "Length(target) must greater or equal to numberOfQubitsToFirstArgument"));
            op.Adjoint.Apply((target?.Slice(new Range(0L, (numberOfQubitsToFirstArgument - 1L))), target?.Slice(new Range(numberOfQubitsToFirstArgument, (target.Count - 1L)))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(IUnitary,Int64,QArray<Qubit>)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(op,numberOfQubitsToFirstArgument,target)) = __in;
            AssertBoolEqual.Apply(((numberOfQubitsToFirstArgument >= 0L), true, "numberOfQubitsToFirstArgument must be non-negative"));
            AssertBoolEqual.Apply(((target.Count >= numberOfQubitsToFirstArgument), true, "Length(target) must greater or equal to numberOfQubitsToFirstArgument"));
            op.Controlled.Apply((controlQubits, (target?.Slice(new Range(0L, (numberOfQubitsToFirstArgument - 1L))), target?.Slice(new Range(numberOfQubitsToFirstArgument, (target.Count - 1L))))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(IUnitary,Int64,QArray<Qubit>)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,(op,numberOfQubitsToFirstArgument,target)) = __in;
            AssertBoolEqual.Apply(((numberOfQubitsToFirstArgument >= 0L), true, "numberOfQubitsToFirstArgument must be non-negative"));
            AssertBoolEqual.Apply(((target.Count >= numberOfQubitsToFirstArgument), true, "Length(target) must greater or equal to numberOfQubitsToFirstArgument"));
            op.Adjoint.Controlled.Apply((controlQubits, (target?.Slice(new Range(0L, (numberOfQubitsToFirstArgument - 1L))), target?.Slice(new Range(numberOfQubitsToFirstArgument, (target.Count - 1L))))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.AssertBoolEqual = this.Factory.Get<ICallable<(Boolean,Boolean,String), QVoid>>(typeof(Microsoft.Quantum.Canon.AssertBoolEqual));
        }

        public override IApplyData __dataIn((IUnitary,Int64,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IUnitary op, Int64 numberOfQubitsToFirstArgument, QArray<Qubit> target)
        {
            return __m__.Run<ApplyToPartitionCA, (IUnitary,Int64,QArray<Qubit>), QVoid>((op, numberOfQubitsToFirstArgument, target));
        }
    }
}