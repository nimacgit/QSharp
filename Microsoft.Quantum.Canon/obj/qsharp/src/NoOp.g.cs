#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "NoOp (qubits : Qubit[]) : ()", new string[] { "Controlled", "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\NoOp.qs", 266L, 9L, 39L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "NoOp2 (qubitsA : Qubit[], qubitsB : Qubit[]) : ()", new string[] { "Controlled", "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\NoOp.qs", 495L, 18L, 58L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "Ignore<'T> (value : 'T) : ()", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\NoOp.qs", 721L, 31L, 11L)]
#line hidden
namespace Microsoft.Quantum.Canon
{
    public class NoOp : Unitary<QArray<Qubit>>, ICallable
    {
        public NoOp(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "NoOp";
        String ICallable.FullName => "Microsoft.Quantum.Canon.NoOp";
        public override Func<QArray<Qubit>, QVoid> Body => (__in) =>
        {
            var qubits = __in;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<QArray<Qubit>, QVoid> AdjointBody => (__in) =>
        {
            var qubits = __in;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,QArray<Qubit>), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,qubits) = __in;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,QArray<Qubit>), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,qubits) = __in;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qubits)
        {
            return __m__.Run<NoOp, QArray<Qubit>, QVoid>(qubits);
        }
    }

    public class NoOp2 : Unitary<(QArray<Qubit>,QArray<Qubit>)>, ICallable
    {
        public NoOp2(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Qubit>)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "NoOp2";
        String ICallable.FullName => "Microsoft.Quantum.Canon.NoOp2";
        public override Func<(QArray<Qubit>,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (qubitsA,qubitsB) = __in;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,QArray<Qubit>), QVoid> AdjointBody => (__in) =>
        {
            var (qubitsA,qubitsB) = __in;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,QArray<Qubit>)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(qubitsA,qubitsB)) = __in;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,QArray<Qubit>)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,(qubitsA,qubitsB)) = __in;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qubitsA, QArray<Qubit> qubitsB)
        {
            return __m__.Run<NoOp2, (QArray<Qubit>,QArray<Qubit>), QVoid>((qubitsA, qubitsB));
        }
    }

    public class Ignore<__T> : Operation<__T, QVoid>, ICallable
    {
        public Ignore(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "Ignore";
        String ICallable.FullName => "Microsoft.Quantum.Canon.Ignore";
        public override Func<__T, QVoid> Body => (__in) =>
        {
            var value = __in;
#line 32 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\NoOp.qs"
            return QVoid.Instance;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(__T data) => new QTuple<__T>(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, __T value)
        {
            return __m__.Run<Ignore<__T>, __T, QVoid>(value);
        }
    }
}