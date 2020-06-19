#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: UdtDeclaration("Microsoft.Quantum.Canon", "SimulationAlgorithm", "((Double, Microsoft.Quantum.Canon.EvolutionGenerator, Qubit[]) => () : Adjoint, Controlled)", "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\Types.qs", 858L, 24L, 58L)]
[assembly: UdtDeclaration("Microsoft.Quantum.Canon", "TimeDependentSimulationAlgorithm", "((Double, Microsoft.Quantum.Canon.EvolutionSchedule, Qubit[]) => () : Adjoint, Controlled)", "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\Types.qs", 1581L, 41L, 73L)]
#line hidden
namespace Microsoft.Quantum.Canon
{
    public class SimulationAlgorithm : OperationUdt<(Double,EvolutionGenerator,QArray<Qubit>),QVoid>, ICallable, IApplyData
    {
        public SimulationAlgorithm() : base(default(IUnitary))
        {
        }

        public SimulationAlgorithm(IUnitary data) : base(data)
        {
        }

        public SimulationAlgorithm(OperationUdt<(Double,EvolutionGenerator,QArray<Qubit>),QVoid> b) : base(b.Data)
        {
        }

        String ICallable.Name => "SimulationAlgorithm";
        String ICallable.FullName => "Microsoft.Quantum.Canon.SimulationAlgorithm";
    }

    public class TimeDependentSimulationAlgorithm : OperationUdt<(Double,EvolutionSchedule,QArray<Qubit>),QVoid>, ICallable, IApplyData
    {
        public TimeDependentSimulationAlgorithm() : base(default(IUnitary))
        {
        }

        public TimeDependentSimulationAlgorithm(IUnitary data) : base(data)
        {
        }

        public TimeDependentSimulationAlgorithm(OperationUdt<(Double,EvolutionSchedule,QArray<Qubit>),QVoid> b) : base(b.Data)
        {
        }

        String ICallable.Name => "TimeDependentSimulationAlgorithm";
        String ICallable.FullName => "Microsoft.Quantum.Canon.TimeDependentSimulationAlgorithm";
    }
}