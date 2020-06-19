#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: UdtDeclaration("Microsoft.Quantum.Canon", "ReflectionOracle", "((Double, Qubit[]) => () : Adjoint, Controlled)", "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\Types.qs", 613L, 16L, 22L)]
[assembly: UdtDeclaration("Microsoft.Quantum.Canon", "ObliviousOracle", "((Qubit[], Qubit[]) => () : Adjoint, Controlled)", "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\Types.qs", 1698L, 34L, 130L)]
[assembly: UdtDeclaration("Microsoft.Quantum.Canon", "StateOracle", "((Int, Qubit[]) => () : Adjoint, Controlled)", "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\Types.qs", 2522L, 48L, 128L)]
[assembly: UdtDeclaration("Microsoft.Quantum.Canon", "DeterministicStateOracle", "(Qubit[] => () : Adjoint, Controlled)", "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\Types.qs", 3032L, 58L, 67L)]
[assembly: UdtDeclaration("Microsoft.Quantum.Canon", "AmpAmpReflectionPhases", "(Double[], Double[])", "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\Types.qs", 3615L, 66L, 202L)]
[assembly: UdtDeclaration("Microsoft.Quantum.Canon", "AmpAmpRotationPhases", "Double[]", "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\Types.qs", 3997L, 74L, 69L)]
#line hidden
namespace Microsoft.Quantum.Canon
{
    public class ReflectionOracle : OperationUdt<(Double,QArray<Qubit>),QVoid>, ICallable, IApplyData
    {
        public ReflectionOracle() : base(default(IUnitary))
        {
        }

        public ReflectionOracle(IUnitary data) : base(data)
        {
        }

        public ReflectionOracle(OperationUdt<(Double,QArray<Qubit>),QVoid> b) : base(b.Data)
        {
        }

        String ICallable.Name => "ReflectionOracle";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ReflectionOracle";
    }

    public class ObliviousOracle : OperationUdt<(QArray<Qubit>,QArray<Qubit>),QVoid>, ICallable, IApplyData
    {
        public ObliviousOracle() : base(default(IUnitary))
        {
        }

        public ObliviousOracle(IUnitary data) : base(data)
        {
        }

        public ObliviousOracle(OperationUdt<(QArray<Qubit>,QArray<Qubit>),QVoid> b) : base(b.Data)
        {
        }

        String ICallable.Name => "ObliviousOracle";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ObliviousOracle";
    }

    public class StateOracle : OperationUdt<(Int64,QArray<Qubit>),QVoid>, ICallable, IApplyData
    {
        public StateOracle() : base(default(IUnitary))
        {
        }

        public StateOracle(IUnitary data) : base(data)
        {
        }

        public StateOracle(OperationUdt<(Int64,QArray<Qubit>),QVoid> b) : base(b.Data)
        {
        }

        String ICallable.Name => "StateOracle";
        String ICallable.FullName => "Microsoft.Quantum.Canon.StateOracle";
    }

    public class DeterministicStateOracle : OperationUdt<QArray<Qubit>,QVoid>, ICallable, IApplyData
    {
        public DeterministicStateOracle() : base(default(IUnitary))
        {
        }

        public DeterministicStateOracle(IUnitary data) : base(data)
        {
        }

        public DeterministicStateOracle(OperationUdt<QArray<Qubit>,QVoid> b) : base(b.Data)
        {
        }

        String ICallable.Name => "DeterministicStateOracle";
        String ICallable.FullName => "Microsoft.Quantum.Canon.DeterministicStateOracle";
    }

    public class AmpAmpReflectionPhases : QTuple<(QArray<Double>,QArray<Double>)>, IApplyData
    {
        public AmpAmpReflectionPhases() : base(default((QArray<Double>,QArray<Double>)))
        {
        }

        public AmpAmpReflectionPhases((QArray<Double>,QArray<Double>) data) : base(data)
        {
        }

        public AmpAmpReflectionPhases(QTuple<(QArray<Double>,QArray<Double>)> b) : base(b.Data)
        {
        }

        public QArray<Double> Item1 => Data.Item1;
        public QArray<Double> Item2 => Data.Item2;
        System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        public void Deconstruct(out QArray<Double> item1, out QArray<Double> item2)
        {
            item1 = Data.Item1;
            item2 = Data.Item2;
        }
    }

    public class AmpAmpRotationPhases : QArray<Double>, IApplyData
    {
        public AmpAmpRotationPhases()
        {
        }

        public AmpAmpRotationPhases(QArray<Double> data) : base(data)
        {
        }

        public void Deconstruct()
        {
        }
    }
}