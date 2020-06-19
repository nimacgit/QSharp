#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "TrotterStepImpl (evolutionGenerator : Microsoft.Quantum.Canon.EvolutionGenerator, idx : Int, stepsize : Double, qubits : Qubit[]) : ()", new string[] { "Controlled", "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\Algorithms.qs", 994L, 25L, 122L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "TrotterSimulationAlgorithmImpl (trotterStepSize : Double, trotterOrder : Int, maxTime : Double, evolutionGenerator : Microsoft.Quantum.Canon.EvolutionGenerator, qubits : Qubit[]) : ()", new string[] { "Controlled", "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\Algorithms.qs", 4011L, 91L, 70L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "TimeDependentTrotterSimulationAlgorithmImpl (trotterStepSize : Double, trotterOrder : Int, maxTime : Double, evolutionSchedule : Microsoft.Quantum.Canon.EvolutionSchedule, qubits : Qubit[]) : ()", new string[] { "Controlled", "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\Algorithms.qs", 6372L, 146L, 82L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "TrotterStep (evolutionGenerator : Microsoft.Quantum.Canon.EvolutionGenerator, trotterOrder : Int, trotterStepSize : Double) : (Qubit[] => () : Adjoint, Controlled)", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\Algorithms.qs", 2226L, 57L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "TrotterSimulationAlgorithm (trotterStepSize : Double, trotterOrder : Int) : Microsoft.Quantum.Canon.SimulationAlgorithm", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\Algorithms.qs", 4916L, 117L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "TimeDependentTrotterSimulationAlgorithm (trotterStepSize : Double, trotterOrder : Int) : Microsoft.Quantum.Canon.TimeDependentSimulationAlgorithm", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\Algorithms.qs", 7726L, 177L, 14L)]
#line hidden
namespace Microsoft.Quantum.Canon
{
    public class TrotterStepImpl : Unitary<(EvolutionGenerator,Int64,Double,QArray<Qubit>)>, ICallable
    {
        public TrotterStepImpl(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(EvolutionGenerator,Int64,Double,QArray<Qubit>)>, IApplyData
        {
            public In((EvolutionGenerator,Int64,Double,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1?.Item1)?.Qubits, ((IApplyData)Data.Item1?.Item2?.Item2)?.Qubits, ((IApplyData)Data.Item4)?.Qubits);
        }

        String ICallable.Name => "TrotterStepImpl";
        String ICallable.FullName => "Microsoft.Quantum.Canon.TrotterStepImpl";
        public override Func<(EvolutionGenerator,Int64,Double,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (evolutionGenerator,idx,stepsize,qubits) = __in;
#line 27 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\Algorithms.qs"
            var (evolutionSet,generatorSystem) = evolutionGenerator;
#line 28 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\Algorithms.qs"
            var (nTerms,generatorSystemFunction) = generatorSystem;
#line 29 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\Algorithms.qs"
            var generatorIndex = generatorSystemFunction.Apply<GeneratorIndex>(idx);
#line 30 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\Algorithms.qs"
            evolutionSet.Apply<IUnitary>(generatorIndex).Apply((stepsize, qubits));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(EvolutionGenerator,Int64,Double,QArray<Qubit>), QVoid> AdjointBody => (__in) =>
        {
            var (evolutionGenerator,idx,stepsize,qubits) = __in;
#line 27 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\Algorithms.qs"
            var (evolutionSet,generatorSystem) = evolutionGenerator;
#line 28 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\Algorithms.qs"
            var (nTerms,generatorSystemFunction) = generatorSystem;
#line 29 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\Algorithms.qs"
            var generatorIndex = generatorSystemFunction.Apply<GeneratorIndex>(idx);
            evolutionSet.Apply<IUnitary>(generatorIndex).Adjoint.Apply((stepsize, qubits));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(EvolutionGenerator,Int64,Double,QArray<Qubit>)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(evolutionGenerator,idx,stepsize,qubits)) = __in;
            var (evolutionSet,generatorSystem) = evolutionGenerator;
            var (nTerms,generatorSystemFunction) = generatorSystem;
            var generatorIndex = generatorSystemFunction.Apply<GeneratorIndex>(idx);
            evolutionSet.Apply<IUnitary>(generatorIndex).Controlled.Apply((controlQubits, (stepsize, qubits)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(EvolutionGenerator,Int64,Double,QArray<Qubit>)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,(evolutionGenerator,idx,stepsize,qubits)) = __in;
            var (evolutionSet,generatorSystem) = evolutionGenerator;
            var (nTerms,generatorSystemFunction) = generatorSystem;
            var generatorIndex = generatorSystemFunction.Apply<GeneratorIndex>(idx);
            evolutionSet.Apply<IUnitary>(generatorIndex).Adjoint.Controlled.Apply((controlQubits, (stepsize, qubits)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((EvolutionGenerator,Int64,Double,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, EvolutionGenerator evolutionGenerator, Int64 idx, Double stepsize, QArray<Qubit> qubits)
        {
            return __m__.Run<TrotterStepImpl, (EvolutionGenerator,Int64,Double,QArray<Qubit>), QVoid>((evolutionGenerator, idx, stepsize, qubits));
        }
    }

    public class TrotterStep : Operation<(EvolutionGenerator,Int64,Double), IUnitary>, ICallable
    {
        public TrotterStep(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(EvolutionGenerator,Int64,Double)>, IApplyData
        {
            public In((EvolutionGenerator,Int64,Double) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1?.Item1)?.Qubits, ((IApplyData)Data.Item1?.Item2?.Item2)?.Qubits);
        }

        String ICallable.Name => "TrotterStep";
        String ICallable.FullName => "Microsoft.Quantum.Canon.TrotterStep";
        protected ICallable DecomposeIntoTimeStepsCA
        {
            get;
            set;
        }

        protected IUnitary<(EvolutionGenerator,Int64,Double,QArray<Qubit>)> TrotterStepImpl
        {
            get;
            set;
        }

        public override Func<(EvolutionGenerator,Int64,Double), IUnitary> Body => (__in) =>
        {
            var (evolutionGenerator,trotterOrder,trotterStepSize) = __in;
#line 59 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\Algorithms.qs"
            var (evolutionSet,generatorSystem) = evolutionGenerator;
#line 60 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\Algorithms.qs"
            var (nTerms,generatorSystemFunction) = generatorSystem;
            // The input to DecomposeIntoTimeStepsCA has signature
            // (Int, ((Int, Double, Qubit[]) => () : Adjoint, Controlled))
#line 63 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\Algorithms.qs"
            var trotterForm = (nTerms, TrotterStepImpl.Partial(new Func<(Int64,Double,QArray<Qubit>), (EvolutionGenerator,Int64,Double,QArray<Qubit>)>((_arg1) => (evolutionGenerator, _arg1.Item1, _arg1.Item2, _arg1.Item3))));
#line 64 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\Algorithms.qs"
            return DecomposeIntoTimeStepsCA.Apply<IUnitary>((trotterForm, trotterOrder)).Partial(new Func<QArray<Qubit>, (Double,QArray<Qubit>)>((_arg2) => (trotterStepSize, _arg2)));
        }

        ;
        public override void Init()
        {
            this.DecomposeIntoTimeStepsCA = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.DecomposeIntoTimeStepsCA<>));
            this.TrotterStepImpl = this.Factory.Get<IUnitary<(EvolutionGenerator,Int64,Double,QArray<Qubit>)>>(typeof(Microsoft.Quantum.Canon.TrotterStepImpl));
        }

        public override IApplyData __dataIn((EvolutionGenerator,Int64,Double) data) => new In(data);
        public override IApplyData __dataOut(IUnitary data) => new QTuple<IUnitary>(data);
        public static System.Threading.Tasks.Task<IUnitary> Run(IOperationFactory __m__, EvolutionGenerator evolutionGenerator, Int64 trotterOrder, Double trotterStepSize)
        {
            return __m__.Run<TrotterStep, (EvolutionGenerator,Int64,Double), IUnitary>((evolutionGenerator, trotterOrder, trotterStepSize));
        }
    }

    public class TrotterSimulationAlgorithmImpl : Unitary<(Double,Int64,Double,EvolutionGenerator,QArray<Qubit>)>, ICallable
    {
        public TrotterSimulationAlgorithmImpl(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Double,Int64,Double,EvolutionGenerator,QArray<Qubit>)>, IApplyData
        {
            public In((Double,Int64,Double,EvolutionGenerator,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item4?.Item1)?.Qubits, ((IApplyData)Data.Item4?.Item2?.Item2)?.Qubits, ((IApplyData)Data.Item5)?.Qubits);
        }

        String ICallable.Name => "TrotterSimulationAlgorithmImpl";
        String ICallable.FullName => "Microsoft.Quantum.Canon.TrotterSimulationAlgorithmImpl";
        protected ICallable<Double, Int64> MicrosoftQuantumExtensionsMathCeiling
        {
            get;
            set;
        }

        protected ICallable<Int64, Double> MicrosoftQuantumExtensionsConvertToDouble
        {
            get;
            set;
        }

        protected ICallable<(EvolutionGenerator,Int64,Double), IUnitary> TrotterStep
        {
            get;
            set;
        }

        public override Func<(Double,Int64,Double,EvolutionGenerator,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (trotterStepSize,trotterOrder,maxTime,evolutionGenerator,qubits) = __in;
#line 93 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\Algorithms.qs"
            var nTimeSlices = MicrosoftQuantumExtensionsMathCeiling.Apply((maxTime / trotterStepSize));
#line 94 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\Algorithms.qs"
            var resizedTrotterStepSize = (maxTime / MicrosoftQuantumExtensionsConvertToDouble.Apply(nTimeSlices));
#line 95 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\Algorithms.qs"
            foreach (var idxTimeSlice in new Range(0L, (nTimeSlices - 1L)))
            {
#line 96 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\Algorithms.qs"
                TrotterStep.Apply((evolutionGenerator, trotterOrder, resizedTrotterStepSize)).Apply(qubits);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Double,Int64,Double,EvolutionGenerator,QArray<Qubit>), QVoid> AdjointBody => (__in) =>
        {
            var (trotterStepSize,trotterOrder,maxTime,evolutionGenerator,qubits) = __in;
#line 93 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\Algorithms.qs"
            var nTimeSlices = MicrosoftQuantumExtensionsMathCeiling.Apply((maxTime / trotterStepSize));
#line 94 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\Algorithms.qs"
            var resizedTrotterStepSize = (maxTime / MicrosoftQuantumExtensionsConvertToDouble.Apply(nTimeSlices));
            foreach (var idxTimeSlice in new Range((0L - ((((nTimeSlices - 1L) - 0L) / 1L) * -(1L))), -(1L), 0L))
            {
                TrotterStep.Apply((evolutionGenerator, trotterOrder, resizedTrotterStepSize)).Adjoint.Apply(qubits);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Double,Int64,Double,EvolutionGenerator,QArray<Qubit>)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(trotterStepSize,trotterOrder,maxTime,evolutionGenerator,qubits)) = __in;
            var nTimeSlices = MicrosoftQuantumExtensionsMathCeiling.Apply((maxTime / trotterStepSize));
            var resizedTrotterStepSize = (maxTime / MicrosoftQuantumExtensionsConvertToDouble.Apply(nTimeSlices));
            foreach (var idxTimeSlice in new Range(0L, (nTimeSlices - 1L)))
            {
                TrotterStep.Apply((evolutionGenerator, trotterOrder, resizedTrotterStepSize)).Controlled.Apply((controlQubits, qubits));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Double,Int64,Double,EvolutionGenerator,QArray<Qubit>)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,(trotterStepSize,trotterOrder,maxTime,evolutionGenerator,qubits)) = __in;
            var nTimeSlices = MicrosoftQuantumExtensionsMathCeiling.Apply((maxTime / trotterStepSize));
            var resizedTrotterStepSize = (maxTime / MicrosoftQuantumExtensionsConvertToDouble.Apply(nTimeSlices));
            foreach (var idxTimeSlice in new Range((0L - ((((nTimeSlices - 1L) - 0L) / 1L) * -(1L))), -(1L), 0L))
            {
                TrotterStep.Apply((evolutionGenerator, trotterOrder, resizedTrotterStepSize)).Adjoint.Controlled.Apply((controlQubits, qubits));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumExtensionsMathCeiling = this.Factory.Get<ICallable<Double, Int64>>(typeof(Microsoft.Quantum.Extensions.Math.Ceiling));
            this.MicrosoftQuantumExtensionsConvertToDouble = this.Factory.Get<ICallable<Int64, Double>>(typeof(Microsoft.Quantum.Extensions.Convert.ToDouble));
            this.TrotterStep = this.Factory.Get<ICallable<(EvolutionGenerator,Int64,Double), IUnitary>>(typeof(Microsoft.Quantum.Canon.TrotterStep));
        }

        public override IApplyData __dataIn((Double,Int64,Double,EvolutionGenerator,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Double trotterStepSize, Int64 trotterOrder, Double maxTime, EvolutionGenerator evolutionGenerator, QArray<Qubit> qubits)
        {
            return __m__.Run<TrotterSimulationAlgorithmImpl, (Double,Int64,Double,EvolutionGenerator,QArray<Qubit>), QVoid>((trotterStepSize, trotterOrder, maxTime, evolutionGenerator, qubits));
        }
    }

    public class TrotterSimulationAlgorithm : Operation<(Double,Int64), IUnitary>, ICallable
    {
        public TrotterSimulationAlgorithm(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Double,Int64)>, IApplyData
        {
            public In((Double,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "TrotterSimulationAlgorithm";
        String ICallable.FullName => "Microsoft.Quantum.Canon.TrotterSimulationAlgorithm";
        protected IUnitary<(Double,Int64,Double,EvolutionGenerator,QArray<Qubit>)> TrotterSimulationAlgorithmImpl
        {
            get;
            set;
        }

        public override Func<(Double,Int64), IUnitary> Body => (__in) =>
        {
            var (trotterStepSize,trotterOrder) = __in;
#line 120 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\Algorithms.qs"
            return new SimulationAlgorithm(TrotterSimulationAlgorithmImpl.Partial(new Func<(Double,EvolutionGenerator,QArray<Qubit>), (Double,Int64,Double,EvolutionGenerator,QArray<Qubit>)>((_arg1) => (trotterStepSize, trotterOrder, _arg1.Item1, _arg1.Item2, _arg1.Item3))));
        }

        ;
        public override void Init()
        {
            this.TrotterSimulationAlgorithmImpl = this.Factory.Get<IUnitary<(Double,Int64,Double,EvolutionGenerator,QArray<Qubit>)>>(typeof(Microsoft.Quantum.Canon.TrotterSimulationAlgorithmImpl));
        }

        public override IApplyData __dataIn((Double,Int64) data) => new In(data);
        public override IApplyData __dataOut(IUnitary data) => new QTuple<IUnitary>(data);
        public static System.Threading.Tasks.Task<IUnitary> Run(IOperationFactory __m__, Double trotterStepSize, Int64 trotterOrder)
        {
            return __m__.Run<TrotterSimulationAlgorithm, (Double,Int64), IUnitary>((trotterStepSize, trotterOrder));
        }
    }

    public class TimeDependentTrotterSimulationAlgorithmImpl : Unitary<(Double,Int64,Double,EvolutionSchedule,QArray<Qubit>)>, ICallable
    {
        public TimeDependentTrotterSimulationAlgorithmImpl(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Double,Int64,Double,EvolutionSchedule,QArray<Qubit>)>, IApplyData
        {
            public In((Double,Int64,Double,EvolutionSchedule,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item4?.Item1)?.Qubits, ((IApplyData)Data.Item4?.Item2)?.Qubits, ((IApplyData)Data.Item5)?.Qubits);
        }

        String ICallable.Name => "TimeDependentTrotterSimulationAlgorithmImpl";
        String ICallable.FullName => "Microsoft.Quantum.Canon.TimeDependentTrotterSimulationAlgorithmImpl";
        protected ICallable<Double, Int64> MicrosoftQuantumExtensionsMathCeiling
        {
            get;
            set;
        }

        protected ICallable<Int64, Double> MicrosoftQuantumExtensionsConvertToDouble
        {
            get;
            set;
        }

        protected ICallable<(Double,Int64), IUnitary> TrotterSimulationAlgorithm
        {
            get;
            set;
        }

        public override Func<(Double,Int64,Double,EvolutionSchedule,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (trotterStepSize,trotterOrder,maxTime,evolutionSchedule,qubits) = __in;
#line 148 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\Algorithms.qs"
            var nTimeSlices = MicrosoftQuantumExtensionsMathCeiling.Apply((maxTime / trotterStepSize));
#line 149 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\Algorithms.qs"
            var resizedTrotterStepSize = (maxTime / MicrosoftQuantumExtensionsConvertToDouble.Apply(nTimeSlices));
#line 150 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\Algorithms.qs"
            foreach (var idxTimeSlice in new Range(0L, (nTimeSlices - 1L)))
            {
#line 151 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\Algorithms.qs"
                var schedule = (MicrosoftQuantumExtensionsConvertToDouble.Apply(idxTimeSlice) / MicrosoftQuantumExtensionsConvertToDouble.Apply(nTimeSlices));
#line 152 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\Algorithms.qs"
                var (evolutionSet,generatorSystemTimeDependent) = evolutionSchedule;
#line 153 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\Algorithms.qs"
                var generatorSystem = generatorSystemTimeDependent.Apply<GeneratorSystem>(schedule);
#line 154 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\Algorithms.qs"
                var evolutionGenerator = new EvolutionGenerator((evolutionSet, generatorSystem));
#line 155 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\Algorithms.qs"
                TrotterSimulationAlgorithm.Apply((resizedTrotterStepSize, trotterOrder)).Apply((resizedTrotterStepSize, evolutionGenerator, qubits));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Double,Int64,Double,EvolutionSchedule,QArray<Qubit>), QVoid> AdjointBody => (__in) =>
        {
            var (trotterStepSize,trotterOrder,maxTime,evolutionSchedule,qubits) = __in;
#line 148 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\Algorithms.qs"
            var nTimeSlices = MicrosoftQuantumExtensionsMathCeiling.Apply((maxTime / trotterStepSize));
#line 149 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\Algorithms.qs"
            var resizedTrotterStepSize = (maxTime / MicrosoftQuantumExtensionsConvertToDouble.Apply(nTimeSlices));
            foreach (var idxTimeSlice in new Range((0L - ((((nTimeSlices - 1L) - 0L) / 1L) * -(1L))), -(1L), 0L))
            {
#line 151 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\Algorithms.qs"
                var schedule = (MicrosoftQuantumExtensionsConvertToDouble.Apply(idxTimeSlice) / MicrosoftQuantumExtensionsConvertToDouble.Apply(nTimeSlices));
#line 152 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\Algorithms.qs"
                var (evolutionSet,generatorSystemTimeDependent) = evolutionSchedule;
#line 153 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\Algorithms.qs"
                var generatorSystem = generatorSystemTimeDependent.Apply<GeneratorSystem>(schedule);
#line 154 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\Algorithms.qs"
                var evolutionGenerator = new EvolutionGenerator((evolutionSet, generatorSystem));
                TrotterSimulationAlgorithm.Apply((resizedTrotterStepSize, trotterOrder)).Adjoint.Apply((resizedTrotterStepSize, evolutionGenerator, qubits));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Double,Int64,Double,EvolutionSchedule,QArray<Qubit>)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(trotterStepSize,trotterOrder,maxTime,evolutionSchedule,qubits)) = __in;
            var nTimeSlices = MicrosoftQuantumExtensionsMathCeiling.Apply((maxTime / trotterStepSize));
            var resizedTrotterStepSize = (maxTime / MicrosoftQuantumExtensionsConvertToDouble.Apply(nTimeSlices));
            foreach (var idxTimeSlice in new Range(0L, (nTimeSlices - 1L)))
            {
                var schedule = (MicrosoftQuantumExtensionsConvertToDouble.Apply(idxTimeSlice) / MicrosoftQuantumExtensionsConvertToDouble.Apply(nTimeSlices));
                var (evolutionSet,generatorSystemTimeDependent) = evolutionSchedule;
                var generatorSystem = generatorSystemTimeDependent.Apply<GeneratorSystem>(schedule);
                var evolutionGenerator = new EvolutionGenerator((evolutionSet, generatorSystem));
                TrotterSimulationAlgorithm.Apply((resizedTrotterStepSize, trotterOrder)).Controlled.Apply((controlQubits, (resizedTrotterStepSize, evolutionGenerator, qubits)));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Double,Int64,Double,EvolutionSchedule,QArray<Qubit>)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,(trotterStepSize,trotterOrder,maxTime,evolutionSchedule,qubits)) = __in;
            var nTimeSlices = MicrosoftQuantumExtensionsMathCeiling.Apply((maxTime / trotterStepSize));
            var resizedTrotterStepSize = (maxTime / MicrosoftQuantumExtensionsConvertToDouble.Apply(nTimeSlices));
            foreach (var idxTimeSlice in new Range((0L - ((((nTimeSlices - 1L) - 0L) / 1L) * -(1L))), -(1L), 0L))
            {
                var schedule = (MicrosoftQuantumExtensionsConvertToDouble.Apply(idxTimeSlice) / MicrosoftQuantumExtensionsConvertToDouble.Apply(nTimeSlices));
                var (evolutionSet,generatorSystemTimeDependent) = evolutionSchedule;
                var generatorSystem = generatorSystemTimeDependent.Apply<GeneratorSystem>(schedule);
                var evolutionGenerator = new EvolutionGenerator((evolutionSet, generatorSystem));
                TrotterSimulationAlgorithm.Apply((resizedTrotterStepSize, trotterOrder)).Adjoint.Controlled.Apply((controlQubits, (resizedTrotterStepSize, evolutionGenerator, qubits)));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumExtensionsMathCeiling = this.Factory.Get<ICallable<Double, Int64>>(typeof(Microsoft.Quantum.Extensions.Math.Ceiling));
            this.MicrosoftQuantumExtensionsConvertToDouble = this.Factory.Get<ICallable<Int64, Double>>(typeof(Microsoft.Quantum.Extensions.Convert.ToDouble));
            this.TrotterSimulationAlgorithm = this.Factory.Get<ICallable<(Double,Int64), IUnitary>>(typeof(Microsoft.Quantum.Canon.TrotterSimulationAlgorithm));
        }

        public override IApplyData __dataIn((Double,Int64,Double,EvolutionSchedule,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Double trotterStepSize, Int64 trotterOrder, Double maxTime, EvolutionSchedule evolutionSchedule, QArray<Qubit> qubits)
        {
            return __m__.Run<TimeDependentTrotterSimulationAlgorithmImpl, (Double,Int64,Double,EvolutionSchedule,QArray<Qubit>), QVoid>((trotterStepSize, trotterOrder, maxTime, evolutionSchedule, qubits));
        }
    }

    public class TimeDependentTrotterSimulationAlgorithm : Operation<(Double,Int64), IUnitary>, ICallable
    {
        public TimeDependentTrotterSimulationAlgorithm(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Double,Int64)>, IApplyData
        {
            public In((Double,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "TimeDependentTrotterSimulationAlgorithm";
        String ICallable.FullName => "Microsoft.Quantum.Canon.TimeDependentTrotterSimulationAlgorithm";
        protected IUnitary<(Double,Int64,Double,EvolutionSchedule,QArray<Qubit>)> TimeDependentTrotterSimulationAlgorithmImpl
        {
            get;
            set;
        }

        public override Func<(Double,Int64), IUnitary> Body => (__in) =>
        {
            var (trotterStepSize,trotterOrder) = __in;
#line 179 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\Algorithms.qs"
            return new TimeDependentSimulationAlgorithm(TimeDependentTrotterSimulationAlgorithmImpl.Partial(new Func<(Double,EvolutionSchedule,QArray<Qubit>), (Double,Int64,Double,EvolutionSchedule,QArray<Qubit>)>((_arg1) => (trotterStepSize, trotterOrder, _arg1.Item1, _arg1.Item2, _arg1.Item3))));
        }

        ;
        public override void Init()
        {
            this.TimeDependentTrotterSimulationAlgorithmImpl = this.Factory.Get<IUnitary<(Double,Int64,Double,EvolutionSchedule,QArray<Qubit>)>>(typeof(Microsoft.Quantum.Canon.TimeDependentTrotterSimulationAlgorithmImpl));
        }

        public override IApplyData __dataIn((Double,Int64) data) => new In(data);
        public override IApplyData __dataOut(IUnitary data) => new QTuple<IUnitary>(data);
        public static System.Threading.Tasks.Task<IUnitary> Run(IOperationFactory __m__, Double trotterStepSize, Int64 trotterOrder)
        {
            return __m__.Run<TimeDependentTrotterSimulationAlgorithm, (Double,Int64), IUnitary>((trotterStepSize, trotterOrder));
        }
    }
}