#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "AdiabaticStateEnergyUnitary (statePrepUnitary : (Qubit[] => ()), adiabaticUnitary : (Qubit[] => ()), qpeUnitary : (Qubit[] => () : Adjoint, Controlled), phaseEstAlgorithm : ((Microsoft.Quantum.Canon.DiscreteOracle, Qubit[]) => Double), qubits : Qubit[]) : Double", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\Techniques.qs", 4003L, 77L, 71L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "AdiabaticStateEnergyEstimate (nQubits : Int, statePrepUnitary : (Qubit[] => ()), adiabaticUnitary : (Qubit[] => ()), qpeUnitary : (Qubit[] => () : Adjoint, Controlled), phaseEstAlgorithm : ((Microsoft.Quantum.Canon.DiscreteOracle, Qubit[]) => Double)) : Double", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\Techniques.qs", 6083L, 118L, 113L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "EstimateEnergy (nQubits : Int, statePrepUnitary : (Qubit[] => ()), qpeUnitary : (Qubit[] => () : Adjoint, Controlled), phaseEstAlgorithm : ((Microsoft.Quantum.Canon.DiscreteOracle, Qubit[]) => Double)) : Double", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\Techniques.qs", 7891L, 157L, 99L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "InterpolatedEvolution (inerpolationTime : Double, evolutionGeneratorStart : Microsoft.Quantum.Canon.EvolutionGenerator, evolutionGeneratorEnd : Microsoft.Quantum.Canon.EvolutionGenerator, timeDependentSimulationAlgorithm : Microsoft.Quantum.Canon.TimeDependentSimulationAlgorithm) : (Qubit[] => () : Adjoint, Controlled)", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\Techniques.qs", 1232L, 30L, 14L)]
#line hidden
namespace Microsoft.Quantum.Canon
{
    public class InterpolatedEvolution : Operation<(Double,EvolutionGenerator,EvolutionGenerator,IUnitary), IUnitary>, ICallable
    {
        public InterpolatedEvolution(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Double,EvolutionGenerator,EvolutionGenerator,IUnitary)>, IApplyData
        {
            public In((Double,EvolutionGenerator,EvolutionGenerator,IUnitary) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item2?.Item1)?.Qubits, ((IApplyData)Data.Item2?.Item2?.Item2)?.Qubits, ((IApplyData)Data.Item3?.Item1)?.Qubits, ((IApplyData)Data.Item3?.Item2?.Item2)?.Qubits, ((IApplyData)Data.Item4)?.Qubits);
        }

        String ICallable.Name => "InterpolatedEvolution";
        String ICallable.FullName => "Microsoft.Quantum.Canon.InterpolatedEvolution";
        protected ICallable<(GeneratorSystem,GeneratorSystem), ICallable> InterpolateGeneratorSystems
        {
            get;
            set;
        }

        public override Func<(Double,EvolutionGenerator,EvolutionGenerator,IUnitary), IUnitary> Body => (__in) =>
        {
            var (inerpolationTime,evolutionGeneratorStart,evolutionGeneratorEnd,timeDependentSimulationAlgorithm) = __in;
            //   evolutionSetStart and evolutionSetEnd must be identical
#line 37 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\Techniques.qs"
            var (evolutionSetStart,generatorSystemStart) = evolutionGeneratorStart;
#line 38 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\Techniques.qs"
            var (evolutionSetEnd,generatorSystemEnd) = evolutionGeneratorEnd;
#line 39 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\Techniques.qs"
            var generatorSystemTimeDependent = InterpolateGeneratorSystems.Apply((generatorSystemStart, generatorSystemEnd));
#line 40 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\Techniques.qs"
            var evolutionSchedule = new EvolutionSchedule((evolutionSetStart, generatorSystemTimeDependent));
#line 41 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\Techniques.qs"
            return timeDependentSimulationAlgorithm.Partial(new Func<QArray<Qubit>, (Double,EvolutionSchedule,QArray<Qubit>)>((_arg1) => (inerpolationTime, evolutionSchedule, _arg1)));
        }

        ;
        public override void Init()
        {
            this.InterpolateGeneratorSystems = this.Factory.Get<ICallable<(GeneratorSystem,GeneratorSystem), ICallable>>(typeof(Microsoft.Quantum.Canon.InterpolateGeneratorSystems));
        }

        public override IApplyData __dataIn((Double,EvolutionGenerator,EvolutionGenerator,IUnitary) data) => new In(data);
        public override IApplyData __dataOut(IUnitary data) => new QTuple<IUnitary>(data);
        public static System.Threading.Tasks.Task<IUnitary> Run(IOperationFactory __m__, Double inerpolationTime, EvolutionGenerator evolutionGeneratorStart, EvolutionGenerator evolutionGeneratorEnd, IUnitary timeDependentSimulationAlgorithm)
        {
            return __m__.Run<InterpolatedEvolution, (Double,EvolutionGenerator,EvolutionGenerator,IUnitary), IUnitary>((inerpolationTime, evolutionGeneratorStart, evolutionGeneratorEnd, timeDependentSimulationAlgorithm));
        }
    }

    public class AdiabaticStateEnergyUnitary : Operation<(ICallable,ICallable,IUnitary,ICallable,QArray<Qubit>), Double>, ICallable
    {
        public AdiabaticStateEnergyUnitary(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(ICallable,ICallable,IUnitary,ICallable,QArray<Qubit>)>, IApplyData
        {
            public In((ICallable,ICallable,IUnitary,ICallable,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits, ((IApplyData)Data.Item4)?.Qubits, ((IApplyData)Data.Item5)?.Qubits);
        }

        String ICallable.Name => "AdiabaticStateEnergyUnitary";
        String ICallable.FullName => "Microsoft.Quantum.Canon.AdiabaticStateEnergyUnitary";
        protected ICallable<IUnitary, IUnitary> OracleToDiscrete
        {
            get;
            set;
        }

        public override Func<(ICallable,ICallable,IUnitary,ICallable,QArray<Qubit>), Double> Body => (__in) =>
        {
            var (statePrepUnitary,adiabaticUnitary,qpeUnitary,phaseEstAlgorithm,qubits) = __in;
#line 79 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\Techniques.qs"
            statePrepUnitary.Apply(qubits);
#line 80 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\Techniques.qs"
            adiabaticUnitary.Apply(qubits);
#line 81 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\Techniques.qs"
            var phaseEst = phaseEstAlgorithm.Apply<Double>((OracleToDiscrete.Apply(((IUnitary)qpeUnitary)), qubits));
#line 82 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\Techniques.qs"
            return phaseEst;
        }

        ;
        public override void Init()
        {
            this.OracleToDiscrete = this.Factory.Get<ICallable<IUnitary, IUnitary>>(typeof(Microsoft.Quantum.Canon.OracleToDiscrete));
        }

        public override IApplyData __dataIn((ICallable,ICallable,IUnitary,ICallable,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(Double data) => new QTuple<Double>(data);
        public static System.Threading.Tasks.Task<Double> Run(IOperationFactory __m__, ICallable statePrepUnitary, ICallable adiabaticUnitary, IUnitary qpeUnitary, ICallable phaseEstAlgorithm, QArray<Qubit> qubits)
        {
            return __m__.Run<AdiabaticStateEnergyUnitary, (ICallable,ICallable,IUnitary,ICallable,QArray<Qubit>), Double>((statePrepUnitary, adiabaticUnitary, qpeUnitary, phaseEstAlgorithm, qubits));
        }
    }

    public class AdiabaticStateEnergyEstimate : Operation<(Int64,ICallable,ICallable,IUnitary,ICallable), Double>, ICallable
    {
        public AdiabaticStateEnergyEstimate(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,ICallable,ICallable,IUnitary,ICallable)>, IApplyData
        {
            public In((Int64,ICallable,ICallable,IUnitary,ICallable) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits, ((IApplyData)Data.Item4)?.Qubits, ((IApplyData)Data.Item5)?.Qubits);
        }

        String ICallable.Name => "AdiabaticStateEnergyEstimate";
        String ICallable.FullName => "Microsoft.Quantum.Canon.AdiabaticStateEnergyEstimate";
        protected ICallable<(ICallable,ICallable,IUnitary,ICallable,QArray<Qubit>), Double> AdiabaticStateEnergyUnitary
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, QVoid> ResetAll
        {
            get;
            set;
        }

        protected ICallable<Int64, Double> MicrosoftQuantumExtensionsConvertToDouble
        {
            get;
            set;
        }

        public override Func<(Int64,ICallable,ICallable,IUnitary,ICallable), Double> Body => (__in) =>
        {
            var (nQubits,statePrepUnitary,adiabaticUnitary,qpeUnitary,phaseEstAlgorithm) = __in;
#line 120 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\Techniques.qs"
            var phaseEst = MicrosoftQuantumExtensionsConvertToDouble.Apply(0L);
#line 121 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\Techniques.qs"
            var qubits = Allocate.Apply(nQubits);
#line 122 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\Techniques.qs"
            phaseEst = AdiabaticStateEnergyUnitary.Apply((((ICallable)statePrepUnitary), ((ICallable)adiabaticUnitary), ((IUnitary)qpeUnitary), ((ICallable)phaseEstAlgorithm), qubits));
#line 123 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\Techniques.qs"
            ResetAll.Apply(qubits);
#line hidden
            Release.Apply(qubits);
#line 125 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\Techniques.qs"
            return phaseEst;
        }

        ;
        public override void Init()
        {
            this.AdiabaticStateEnergyUnitary = this.Factory.Get<ICallable<(ICallable,ICallable,IUnitary,ICallable,QArray<Qubit>), Double>>(typeof(Microsoft.Quantum.Canon.AdiabaticStateEnergyUnitary));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.MicrosoftQuantumExtensionsConvertToDouble = this.Factory.Get<ICallable<Int64, Double>>(typeof(Microsoft.Quantum.Extensions.Convert.ToDouble));
        }

        public override IApplyData __dataIn((Int64,ICallable,ICallable,IUnitary,ICallable) data) => new In(data);
        public override IApplyData __dataOut(Double data) => new QTuple<Double>(data);
        public static System.Threading.Tasks.Task<Double> Run(IOperationFactory __m__, Int64 nQubits, ICallable statePrepUnitary, ICallable adiabaticUnitary, IUnitary qpeUnitary, ICallable phaseEstAlgorithm)
        {
            return __m__.Run<AdiabaticStateEnergyEstimate, (Int64,ICallable,ICallable,IUnitary,ICallable), Double>((nQubits, statePrepUnitary, adiabaticUnitary, qpeUnitary, phaseEstAlgorithm));
        }
    }

    public class EstimateEnergy : Operation<(Int64,ICallable,IUnitary,ICallable), Double>, ICallable
    {
        public EstimateEnergy(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,ICallable,IUnitary,ICallable)>, IApplyData
        {
            public In((Int64,ICallable,IUnitary,ICallable) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits, ((IApplyData)Data.Item4)?.Qubits);
        }

        String ICallable.Name => "EstimateEnergy";
        String ICallable.FullName => "Microsoft.Quantum.Canon.EstimateEnergy";
        protected ICallable<(Int64,ICallable,ICallable,IUnitary,ICallable), Double> AdiabaticStateEnergyEstimate
        {
            get;
            set;
        }

        protected IUnitary<QArray<Qubit>> NoOp
        {
            get;
            set;
        }

        public override Func<(Int64,ICallable,IUnitary,ICallable), Double> Body => (__in) =>
        {
            var (nQubits,statePrepUnitary,qpeUnitary,phaseEstAlgorithm) = __in;
#line 159 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\Techniques.qs"
            var phaseEst = AdiabaticStateEnergyEstimate.Apply((nQubits, ((ICallable)statePrepUnitary), ((ICallable)NoOp), ((IUnitary)qpeUnitary), ((ICallable)phaseEstAlgorithm)));
#line 160 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\Techniques.qs"
            return phaseEst;
        }

        ;
        public override void Init()
        {
            this.AdiabaticStateEnergyEstimate = this.Factory.Get<ICallable<(Int64,ICallable,ICallable,IUnitary,ICallable), Double>>(typeof(Microsoft.Quantum.Canon.AdiabaticStateEnergyEstimate));
            this.NoOp = this.Factory.Get<IUnitary<QArray<Qubit>>>(typeof(Microsoft.Quantum.Canon.NoOp));
        }

        public override IApplyData __dataIn((Int64,ICallable,IUnitary,ICallable) data) => new In(data);
        public override IApplyData __dataOut(Double data) => new QTuple<Double>(data);
        public static System.Threading.Tasks.Task<Double> Run(IOperationFactory __m__, Int64 nQubits, ICallable statePrepUnitary, IUnitary qpeUnitary, ICallable phaseEstAlgorithm)
        {
            return __m__.Run<EstimateEnergy, (Int64,ICallable,IUnitary,ICallable), Double>((nQubits, statePrepUnitary, qpeUnitary, phaseEstAlgorithm));
        }
    }
}