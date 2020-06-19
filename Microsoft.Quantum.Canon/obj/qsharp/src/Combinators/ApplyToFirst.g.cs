#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "ApplyToFirstQubit (op : (Qubit => ()), register : Qubit[]) : ()", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToFirst.qs", 865L, 23L, 80L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "ApplyToFirstQubitA (op : (Qubit => () : Adjoint), register : Qubit[]) : ()", new string[] { "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToFirst.qs", 1571L, 43L, 91L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "ApplyToFirstQubitC (op : (Qubit => () : Controlled), register : Qubit[]) : ()", new string[] { "Controlled" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToFirst.qs", 2302L, 64L, 94L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "ApplyToFirstQubitCA (op : (Qubit => () : Adjoint, Controlled), register : Qubit[]) : ()", new string[] { "Controlled", "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToFirst.qs", 3064L, 85L, 104L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "ApplyToFirstTwoQubits (op : ((Qubit, Qubit) => ()), register : Qubit[]) : ()", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToFirst.qs", 4064L, 116L, 92L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "ApplyToFirstTwoQubitsA (op : ((Qubit, Qubit) => () : Adjoint), register : Qubit[]) : ()", new string[] { "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToFirst.qs", 4955L, 143L, 104L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "ApplyToFirstTwoQubitsC (op : ((Qubit, Qubit) => () : Controlled), register : Qubit[]) : ()", new string[] { "Controlled" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToFirst.qs", 5878L, 172L, 107L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "ApplyToFirstTwoQubitsCA (op : ((Qubit, Qubit) => () : Adjoint, Controlled), register : Qubit[]) : ()", new string[] { "Controlled", "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToFirst.qs", 6830L, 200L, 117L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "ApplyToFirstThreeQubits (op : ((Qubit, Qubit, Qubit) => ()), register : Qubit[]) : ()", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToFirst.qs", 7849L, 229L, 100L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "ApplyToFirstThreeQubitsA (op : ((Qubit, Qubit, Qubit) => () : Adjoint), register : Qubit[]) : ()", new string[] { "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToFirst.qs", 8772L, 255L, 111L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "ApplyToFirstThreeQubitsC (op : ((Qubit, Qubit, Qubit) => () : Controlled), register : Qubit[]) : ()", new string[] { "Controlled" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToFirst.qs", 9721L, 282L, 114L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "ApplyToFirstThreeQubitsCA (op : ((Qubit, Qubit, Qubit) => () : Adjoint, Controlled), register : Qubit[]) : ()", new string[] { "Controlled", "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToFirst.qs", 10700L, 309L, 124L)]
#line hidden
namespace Microsoft.Quantum.Canon
{
    public class ApplyToFirstQubit : Operation<(ICallable,QArray<Qubit>), QVoid>, ICallable
    {
        public ApplyToFirstQubit(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(ICallable,QArray<Qubit>)>, IApplyData
        {
            public In((ICallable,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "ApplyToFirstQubit";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ApplyToFirstQubit";
        public override Func<(ICallable,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (op,register) = __in;
#line 25 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToFirst.qs"
            if ((register.Count == 0L))
            {
#line 26 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToFirst.qs"
                throw new ExecutionFailException("Must have at least one qubit to act on.");
            }

#line 28 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToFirst.qs"
            op.Apply(register[0L]);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((ICallable,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, ICallable op, QArray<Qubit> register)
        {
            return __m__.Run<ApplyToFirstQubit, (ICallable,QArray<Qubit>), QVoid>((op, register));
        }
    }

    public class ApplyToFirstQubitA : Adjointable<(IAdjointable,QArray<Qubit>)>, ICallable
    {
        public ApplyToFirstQubitA(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IAdjointable,QArray<Qubit>)>, IApplyData
        {
            public In((IAdjointable,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "ApplyToFirstQubitA";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ApplyToFirstQubitA";
        public override Func<(IAdjointable,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (op,register) = __in;
#line 45 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToFirst.qs"
            if ((register.Count == 0L))
            {
#line 46 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToFirst.qs"
                throw new ExecutionFailException("Must have at least one qubit to act on.");
            }

#line 48 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToFirst.qs"
            op.Apply(register[0L]);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IAdjointable,QArray<Qubit>), QVoid> AdjointBody => (__in) =>
        {
            var (op,register) = __in;
            if ((register.Count == 0L))
            {
#line 46 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToFirst.qs"
                throw new ExecutionFailException("Must have at least one qubit to act on.");
            }

            op.Adjoint.Apply(register[0L]);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((IAdjointable,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IAdjointable op, QArray<Qubit> register)
        {
            return __m__.Run<ApplyToFirstQubitA, (IAdjointable,QArray<Qubit>), QVoid>((op, register));
        }
    }

    public class ApplyToFirstQubitC : Controllable<(IControllable,QArray<Qubit>)>, ICallable
    {
        public ApplyToFirstQubitC(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IControllable,QArray<Qubit>)>, IApplyData
        {
            public In((IControllable,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "ApplyToFirstQubitC";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ApplyToFirstQubitC";
        public override Func<(IControllable,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (op,register) = __in;
#line 66 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToFirst.qs"
            if ((register.Count == 0L))
            {
#line 67 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToFirst.qs"
                throw new ExecutionFailException("Must have at least one qubit to act on.");
            }

#line 69 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToFirst.qs"
            op.Apply(register[0L]);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(IControllable,QArray<Qubit>)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(op,register)) = __in;
            if ((register.Count == 0L))
            {
                throw new ExecutionFailException("Must have at least one qubit to act on.");
            }

            op.Controlled.Apply((controlQubits, register[0L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((IControllable,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IControllable op, QArray<Qubit> register)
        {
            return __m__.Run<ApplyToFirstQubitC, (IControllable,QArray<Qubit>), QVoid>((op, register));
        }
    }

    public class ApplyToFirstQubitCA : Unitary<(IUnitary,QArray<Qubit>)>, ICallable
    {
        public ApplyToFirstQubitCA(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IUnitary,QArray<Qubit>)>, IApplyData
        {
            public In((IUnitary,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "ApplyToFirstQubitCA";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ApplyToFirstQubitCA";
        public override Func<(IUnitary,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (op,register) = __in;
#line 87 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToFirst.qs"
            if ((register.Count == 0L))
            {
#line 88 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToFirst.qs"
                throw new ExecutionFailException("Must have at least one qubit to act on.");
            }

#line 90 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToFirst.qs"
            op.Apply(register[0L]);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IUnitary,QArray<Qubit>), QVoid> AdjointBody => (__in) =>
        {
            var (op,register) = __in;
            if ((register.Count == 0L))
            {
#line 88 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToFirst.qs"
                throw new ExecutionFailException("Must have at least one qubit to act on.");
            }

            op.Adjoint.Apply(register[0L]);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(IUnitary,QArray<Qubit>)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(op,register)) = __in;
            if ((register.Count == 0L))
            {
                throw new ExecutionFailException("Must have at least one qubit to act on.");
            }

            op.Controlled.Apply((controlQubits, register[0L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(IUnitary,QArray<Qubit>)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,(op,register)) = __in;
            if ((register.Count == 0L))
            {
                throw new ExecutionFailException("Must have at least one qubit to act on.");
            }

            op.Adjoint.Controlled.Apply((controlQubits, register[0L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((IUnitary,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IUnitary op, QArray<Qubit> register)
        {
            return __m__.Run<ApplyToFirstQubitCA, (IUnitary,QArray<Qubit>), QVoid>((op, register));
        }
    }

    public class ApplyToFirstTwoQubits : Operation<(ICallable,QArray<Qubit>), QVoid>, ICallable
    {
        public ApplyToFirstTwoQubits(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(ICallable,QArray<Qubit>)>, IApplyData
        {
            public In((ICallable,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "ApplyToFirstTwoQubits";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ApplyToFirstTwoQubits";
        public override Func<(ICallable,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (op,register) = __in;
#line 118 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToFirst.qs"
            if ((register.Count < 2L))
            {
#line 119 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToFirst.qs"
                throw new ExecutionFailException("Must have at least two qubits to act on.");
            }

#line 121 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToFirst.qs"
            op.Apply((register[0L], register[1L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((ICallable,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, ICallable op, QArray<Qubit> register)
        {
            return __m__.Run<ApplyToFirstTwoQubits, (ICallable,QArray<Qubit>), QVoid>((op, register));
        }
    }

    public class ApplyToFirstTwoQubitsA : Adjointable<(IAdjointable,QArray<Qubit>)>, ICallable
    {
        public ApplyToFirstTwoQubitsA(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IAdjointable,QArray<Qubit>)>, IApplyData
        {
            public In((IAdjointable,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "ApplyToFirstTwoQubitsA";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ApplyToFirstTwoQubitsA";
        public override Func<(IAdjointable,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (op,register) = __in;
#line 145 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToFirst.qs"
            if ((register.Count < 2L))
            {
#line 146 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToFirst.qs"
                throw new ExecutionFailException("Must have at least two qubits to act on.");
            }

#line 148 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToFirst.qs"
            op.Apply((register[0L], register[1L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IAdjointable,QArray<Qubit>), QVoid> AdjointBody => (__in) =>
        {
            var (op,register) = __in;
            if ((register.Count < 2L))
            {
#line 146 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToFirst.qs"
                throw new ExecutionFailException("Must have at least two qubits to act on.");
            }

            op.Adjoint.Apply((register[0L], register[1L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((IAdjointable,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IAdjointable op, QArray<Qubit> register)
        {
            return __m__.Run<ApplyToFirstTwoQubitsA, (IAdjointable,QArray<Qubit>), QVoid>((op, register));
        }
    }

    public class ApplyToFirstTwoQubitsC : Controllable<(IControllable,QArray<Qubit>)>, ICallable
    {
        public ApplyToFirstTwoQubitsC(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IControllable,QArray<Qubit>)>, IApplyData
        {
            public In((IControllable,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "ApplyToFirstTwoQubitsC";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ApplyToFirstTwoQubitsC";
        public override Func<(IControllable,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (op,register) = __in;
#line 174 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToFirst.qs"
            if ((register.Count < 2L))
            {
#line 175 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToFirst.qs"
                throw new ExecutionFailException("Must have at least two qubits to act on.");
            }

#line 177 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToFirst.qs"
            op.Apply((register[0L], register[1L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(IControllable,QArray<Qubit>)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(op,register)) = __in;
            if ((register.Count < 2L))
            {
                throw new ExecutionFailException("Must have at least two qubits to act on.");
            }

            op.Controlled.Apply((controlQubits, (register[0L], register[1L])));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((IControllable,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IControllable op, QArray<Qubit> register)
        {
            return __m__.Run<ApplyToFirstTwoQubitsC, (IControllable,QArray<Qubit>), QVoid>((op, register));
        }
    }

    public class ApplyToFirstTwoQubitsCA : Unitary<(IUnitary,QArray<Qubit>)>, ICallable
    {
        public ApplyToFirstTwoQubitsCA(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IUnitary,QArray<Qubit>)>, IApplyData
        {
            public In((IUnitary,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "ApplyToFirstTwoQubitsCA";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ApplyToFirstTwoQubitsCA";
        public override Func<(IUnitary,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (op,register) = __in;
#line 202 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToFirst.qs"
            if ((register.Count < 2L))
            {
#line 203 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToFirst.qs"
                throw new ExecutionFailException("Must have at least two qubits to act on.");
            }

#line 205 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToFirst.qs"
            op.Apply((register[0L], register[1L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IUnitary,QArray<Qubit>), QVoid> AdjointBody => (__in) =>
        {
            var (op,register) = __in;
            if ((register.Count < 2L))
            {
#line 203 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToFirst.qs"
                throw new ExecutionFailException("Must have at least two qubits to act on.");
            }

            op.Adjoint.Apply((register[0L], register[1L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(IUnitary,QArray<Qubit>)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(op,register)) = __in;
            if ((register.Count < 2L))
            {
                throw new ExecutionFailException("Must have at least two qubits to act on.");
            }

            op.Controlled.Apply((controlQubits, (register[0L], register[1L])));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(IUnitary,QArray<Qubit>)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,(op,register)) = __in;
            if ((register.Count < 2L))
            {
                throw new ExecutionFailException("Must have at least two qubits to act on.");
            }

            op.Adjoint.Controlled.Apply((controlQubits, (register[0L], register[1L])));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((IUnitary,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IUnitary op, QArray<Qubit> register)
        {
            return __m__.Run<ApplyToFirstTwoQubitsCA, (IUnitary,QArray<Qubit>), QVoid>((op, register));
        }
    }

    public class ApplyToFirstThreeQubits : Operation<(ICallable,QArray<Qubit>), QVoid>, ICallable
    {
        public ApplyToFirstThreeQubits(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(ICallable,QArray<Qubit>)>, IApplyData
        {
            public In((ICallable,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "ApplyToFirstThreeQubits";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ApplyToFirstThreeQubits";
        public override Func<(ICallable,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (op,register) = __in;
#line 231 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToFirst.qs"
            if ((register.Count < 3L))
            {
#line 232 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToFirst.qs"
                throw new ExecutionFailException("Must have at least three qubits to act on.");
            }

#line 234 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToFirst.qs"
            op.Apply((register[0L], register[1L], register[2L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((ICallable,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, ICallable op, QArray<Qubit> register)
        {
            return __m__.Run<ApplyToFirstThreeQubits, (ICallable,QArray<Qubit>), QVoid>((op, register));
        }
    }

    public class ApplyToFirstThreeQubitsA : Adjointable<(IAdjointable,QArray<Qubit>)>, ICallable
    {
        public ApplyToFirstThreeQubitsA(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IAdjointable,QArray<Qubit>)>, IApplyData
        {
            public In((IAdjointable,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "ApplyToFirstThreeQubitsA";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ApplyToFirstThreeQubitsA";
        public override Func<(IAdjointable,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (op,register) = __in;
#line 257 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToFirst.qs"
            if ((register.Count < 3L))
            {
#line 258 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToFirst.qs"
                throw new ExecutionFailException("Must have at least three qubits to act on.");
            }

#line 260 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToFirst.qs"
            op.Apply((register[0L], register[1L], register[2L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IAdjointable,QArray<Qubit>), QVoid> AdjointBody => (__in) =>
        {
            var (op,register) = __in;
            if ((register.Count < 3L))
            {
#line 258 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToFirst.qs"
                throw new ExecutionFailException("Must have at least three qubits to act on.");
            }

            op.Adjoint.Apply((register[0L], register[1L], register[2L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((IAdjointable,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IAdjointable op, QArray<Qubit> register)
        {
            return __m__.Run<ApplyToFirstThreeQubitsA, (IAdjointable,QArray<Qubit>), QVoid>((op, register));
        }
    }

    public class ApplyToFirstThreeQubitsC : Controllable<(IControllable,QArray<Qubit>)>, ICallable
    {
        public ApplyToFirstThreeQubitsC(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IControllable,QArray<Qubit>)>, IApplyData
        {
            public In((IControllable,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "ApplyToFirstThreeQubitsC";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ApplyToFirstThreeQubitsC";
        public override Func<(IControllable,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (op,register) = __in;
#line 284 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToFirst.qs"
            if ((register.Count < 3L))
            {
#line 285 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToFirst.qs"
                throw new ExecutionFailException("Must have at least three qubits to act on.");
            }

#line 287 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToFirst.qs"
            op.Apply((register[0L], register[1L], register[2L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(IControllable,QArray<Qubit>)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(op,register)) = __in;
            if ((register.Count < 3L))
            {
                throw new ExecutionFailException("Must have at least three qubits to act on.");
            }

            op.Controlled.Apply((controlQubits, (register[0L], register[1L], register[2L])));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((IControllable,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IControllable op, QArray<Qubit> register)
        {
            return __m__.Run<ApplyToFirstThreeQubitsC, (IControllable,QArray<Qubit>), QVoid>((op, register));
        }
    }

    public class ApplyToFirstThreeQubitsCA : Unitary<(IUnitary,QArray<Qubit>)>, ICallable
    {
        public ApplyToFirstThreeQubitsCA(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IUnitary,QArray<Qubit>)>, IApplyData
        {
            public In((IUnitary,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "ApplyToFirstThreeQubitsCA";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ApplyToFirstThreeQubitsCA";
        public override Func<(IUnitary,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (op,register) = __in;
#line 311 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToFirst.qs"
            if ((register.Count < 3L))
            {
#line 312 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToFirst.qs"
                throw new ExecutionFailException("Must have at least three qubits to act on.");
            }

#line 314 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToFirst.qs"
            op.Apply((register[0L], register[1L], register[2L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IUnitary,QArray<Qubit>), QVoid> AdjointBody => (__in) =>
        {
            var (op,register) = __in;
            if ((register.Count < 3L))
            {
#line 312 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToFirst.qs"
                throw new ExecutionFailException("Must have at least three qubits to act on.");
            }

            op.Adjoint.Apply((register[0L], register[1L], register[2L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(IUnitary,QArray<Qubit>)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(op,register)) = __in;
            if ((register.Count < 3L))
            {
                throw new ExecutionFailException("Must have at least three qubits to act on.");
            }

            op.Controlled.Apply((controlQubits, (register[0L], register[1L], register[2L])));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(IUnitary,QArray<Qubit>)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,(op,register)) = __in;
            if ((register.Count < 3L))
            {
                throw new ExecutionFailException("Must have at least three qubits to act on.");
            }

            op.Adjoint.Controlled.Apply((controlQubits, (register[0L], register[1L], register[2L])));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((IUnitary,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IUnitary op, QArray<Qubit> register)
        {
            return __m__.Run<ApplyToFirstThreeQubitsCA, (IUnitary,QArray<Qubit>), QVoid>((op, register));
        }
    }
}