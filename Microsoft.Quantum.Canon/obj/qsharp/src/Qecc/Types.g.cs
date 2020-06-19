#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: UdtDeclaration("Microsoft.Quantum.Canon", "LogicalRegister", "Qubit[]", "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\Types.qs", 256L, 9L, 24L)]
[assembly: UdtDeclaration("Microsoft.Quantum.Canon", "Syndrome", "Result[]", "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\Types.qs", 425L, 14L, 27L)]
[assembly: UdtDeclaration("Microsoft.Quantum.Canon", "RecoveryFn", "(Microsoft.Quantum.Canon.Syndrome -> Pauli[])", "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\Types.qs", 615L, 19L, 52L)]
[assembly: UdtDeclaration("Microsoft.Quantum.Canon", "EncodeOp", "((Qubit[], Qubit[]) => Microsoft.Quantum.Canon.LogicalRegister)", "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\Types.qs", 1339L, 34L, 36L)]
[assembly: UdtDeclaration("Microsoft.Quantum.Canon", "DecodeOp", "(Microsoft.Quantum.Canon.LogicalRegister => (Qubit[], Qubit[]))", "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\Types.qs", 1690L, 42L, 34L)]
[assembly: UdtDeclaration("Microsoft.Quantum.Canon", "SyndromeMeasOp", "(Microsoft.Quantum.Canon.LogicalRegister => Microsoft.Quantum.Canon.Syndrome)", "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\Types.qs", 2769L, 68L, 43L)]
[assembly: UdtDeclaration("Microsoft.Quantum.Canon", "QECC", "(Microsoft.Quantum.Canon.EncodeOp, Microsoft.Quantum.Canon.DecodeOp, Microsoft.Quantum.Canon.SyndromeMeasOp)", "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\Types.qs", 2977L, 73L, 53L)]
[assembly: UdtDeclaration("Microsoft.Quantum.Canon", "CSS", "(Microsoft.Quantum.Canon.EncodeOp, Microsoft.Quantum.Canon.DecodeOp, Microsoft.Quantum.Canon.SyndromeMeasOp, Microsoft.Quantum.Canon.SyndromeMeasOp)", "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\Types.qs", 3244L, 79L, 46L)]
#line hidden
namespace Microsoft.Quantum.Canon
{
    public class LogicalRegister : QArray<Qubit>, IApplyData
    {
        public LogicalRegister()
        {
        }

        public LogicalRegister(QArray<Qubit> data) : base(data)
        {
        }

        public void Deconstruct()
        {
        }
    }

    public class Syndrome : QArray<Result>, IApplyData
    {
        public Syndrome()
        {
        }

        public Syndrome(QArray<Result> data) : base(data)
        {
        }

        public void Deconstruct()
        {
        }
    }

    public class RecoveryFn : OperationUdt<Syndrome,QArray<Pauli>>, ICallable, IApplyData
    {
        public RecoveryFn() : base(default(ICallable))
        {
        }

        public RecoveryFn(ICallable data) : base(data)
        {
        }

        public RecoveryFn(OperationUdt<Syndrome,QArray<Pauli>> b) : base(b.Data)
        {
        }

        String ICallable.Name => "RecoveryFn";
        String ICallable.FullName => "Microsoft.Quantum.Canon.RecoveryFn";
    }

    public class EncodeOp : OperationUdt<(QArray<Qubit>,QArray<Qubit>),LogicalRegister>, ICallable, IApplyData
    {
        public EncodeOp() : base(default(ICallable))
        {
        }

        public EncodeOp(ICallable data) : base(data)
        {
        }

        public EncodeOp(OperationUdt<(QArray<Qubit>,QArray<Qubit>),LogicalRegister> b) : base(b.Data)
        {
        }

        String ICallable.Name => "EncodeOp";
        String ICallable.FullName => "Microsoft.Quantum.Canon.EncodeOp";
    }

    public class DecodeOp : OperationUdt<LogicalRegister,(QArray<Qubit>,QArray<Qubit>)>, ICallable, IApplyData
    {
        public DecodeOp() : base(default(ICallable))
        {
        }

        public DecodeOp(ICallable data) : base(data)
        {
        }

        public DecodeOp(OperationUdt<LogicalRegister,(QArray<Qubit>,QArray<Qubit>)> b) : base(b.Data)
        {
        }

        String ICallable.Name => "DecodeOp";
        String ICallable.FullName => "Microsoft.Quantum.Canon.DecodeOp";
    }

    public class SyndromeMeasOp : OperationUdt<LogicalRegister,Syndrome>, ICallable, IApplyData
    {
        public SyndromeMeasOp() : base(default(ICallable))
        {
        }

        public SyndromeMeasOp(ICallable data) : base(data)
        {
        }

        public SyndromeMeasOp(OperationUdt<LogicalRegister,Syndrome> b) : base(b.Data)
        {
        }

        String ICallable.Name => "SyndromeMeasOp";
        String ICallable.FullName => "Microsoft.Quantum.Canon.SyndromeMeasOp";
    }

    public class QECC : QTuple<(ICallable,ICallable,ICallable)>, IApplyData
    {
        public QECC() : base(default((ICallable,ICallable,ICallable)))
        {
        }

        public QECC((ICallable,ICallable,ICallable) data) : base(data)
        {
        }

        public QECC(QTuple<(ICallable,ICallable,ICallable)> b) : base(b.Data)
        {
        }

        public ICallable Item1 => Data.Item1;
        public ICallable Item2 => Data.Item2;
        public ICallable Item3 => Data.Item3;
        System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        public void Deconstruct(out ICallable item1, out ICallable item2, out ICallable item3)
        {
            item1 = Data.Item1;
            item2 = Data.Item2;
            item3 = Data.Item3;
        }
    }

    public class CSS : QTuple<(ICallable,ICallable,ICallable,ICallable)>, IApplyData
    {
        public CSS() : base(default((ICallable,ICallable,ICallable,ICallable)))
        {
        }

        public CSS((ICallable,ICallable,ICallable,ICallable) data) : base(data)
        {
        }

        public CSS(QTuple<(ICallable,ICallable,ICallable,ICallable)> b) : base(b.Data)
        {
        }

        public ICallable Item1 => Data.Item1;
        public ICallable Item2 => Data.Item2;
        public ICallable Item3 => Data.Item3;
        public ICallable Item4 => Data.Item4;
        System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits, ((IApplyData)Data.Item4)?.Qubits);
        public void Deconstruct(out ICallable item1, out ICallable item2, out ICallable item3, out ICallable item4)
        {
            item1 = Data.Item1;
            item2 = Data.Item2;
            item3 = Data.Item3;
            item4 = Data.Item4;
        }
    }
}