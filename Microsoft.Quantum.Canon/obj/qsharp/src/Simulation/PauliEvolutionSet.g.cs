#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "PauliEvolutionImpl (generatorIndex : Microsoft.Quantum.Canon.GeneratorIndex, delta : Double, qubits : Qubit[]) : ()", new string[] { "Controlled", "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\PauliEvolutionSet.qs", 2789L, 73L, 5L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "IntToPauli (idx : Int) : Pauli", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\PauliEvolutionSet.qs", 1146L, 28L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "IntsToPaulis (ints : Int[]) : Pauli[]", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\PauliEvolutionSet.qs", 1781L, 46L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "PauliEvolutionFunction (generatorIndex : Microsoft.Quantum.Canon.GeneratorIndex) : Microsoft.Quantum.Canon.EvolutionUnitary", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\PauliEvolutionSet.qs", 3603L, 98L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "PauliEvolutionSet () : Microsoft.Quantum.Canon.EvolutionSet", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\PauliEvolutionSet.qs", 4202L, 114L, 14L)]
#line hidden
namespace Microsoft.Quantum.Canon
{
    public class IntToPauli : Operation<Int64, Pauli>, ICallable
    {
        public IntToPauli(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "IntToPauli";
        String ICallable.FullName => "Microsoft.Quantum.Canon.IntToPauli";
        public override Func<Int64, Pauli> Body => (__in) =>
        {
            var idx = __in;
#line 29 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\PauliEvolutionSet.qs"
            var paulis = new QArray<Pauli>(Pauli.PauliI, Pauli.PauliX, Pauli.PauliY, Pauli.PauliZ);
#line 30 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\PauliEvolutionSet.qs"
            return paulis[idx];
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __dataOut(Pauli data) => new QTuple<Pauli>(data);
        public static System.Threading.Tasks.Task<Pauli> Run(IOperationFactory __m__, Int64 idx)
        {
            return __m__.Run<IntToPauli, Int64, Pauli>(idx);
        }
    }

    public class IntsToPaulis : Operation<QArray<Int64>, QArray<Pauli>>, ICallable
    {
        public IntsToPaulis(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "IntsToPaulis";
        String ICallable.FullName => "Microsoft.Quantum.Canon.IntsToPaulis";
        protected ICallable<Int64, Pauli> IntToPauli
        {
            get;
            set;
        }

        public override Func<QArray<Int64>, QArray<Pauli>> Body => (__in) =>
        {
            var ints = __in;
#line 47 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\PauliEvolutionSet.qs"
            var nInts = ints.Count;
#line 48 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\PauliEvolutionSet.qs"
            var paulis = new QArray<Pauli>(nInts);
#line 49 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\PauliEvolutionSet.qs"
            foreach (var idxInt in new Range(0L, (nInts - 1L)))
            {
#line 50 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\PauliEvolutionSet.qs"
                paulis[idxInt] = IntToPauli.Apply(ints[idxInt]);
            }

#line 53 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\PauliEvolutionSet.qs"
            return paulis;
        }

        ;
        public override void Init()
        {
            this.IntToPauli = this.Factory.Get<ICallable<Int64, Pauli>>(typeof(Microsoft.Quantum.Canon.IntToPauli));
        }

        public override IApplyData __dataIn(QArray<Int64> data) => data;
        public override IApplyData __dataOut(QArray<Pauli> data) => data;
        public static System.Threading.Tasks.Task<QArray<Pauli>> Run(IOperationFactory __m__, QArray<Int64> ints)
        {
            return __m__.Run<IntsToPaulis, QArray<Int64>, QArray<Pauli>>(ints);
        }
    }

    public class PauliEvolutionImpl : Unitary<(GeneratorIndex,Double,QArray<Qubit>)>, ICallable
    {
        public PauliEvolutionImpl(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(GeneratorIndex,Double,QArray<Qubit>)>, IApplyData
        {
            public In((GeneratorIndex,Double,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item3)?.Qubits;
        }

        String ICallable.Name => "PauliEvolutionImpl";
        String ICallable.FullName => "Microsoft.Quantum.Canon.PauliEvolutionImpl";
        protected IUnitary<(QArray<Pauli>,Double,QArray<Qubit>)> MicrosoftQuantumPrimitiveExp
        {
            get;
            set;
        }

        protected ICallable<QArray<Int64>, QArray<Pauli>> IntsToPaulis
        {
            get;
            set;
        }

        protected ICallable<(IUnitary,QArray<Int64>), IUnitary> RestrictToSubregisterCA
        {
            get;
            set;
        }

        public override Func<(GeneratorIndex,Double,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (generatorIndex,delta,qubits) = __in;
#line 75 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\PauliEvolutionSet.qs"
            var ((idxPaulis,idxDoubles),idxQubits) = generatorIndex;
#line 76 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\PauliEvolutionSet.qs"
            var pauliString = IntsToPaulis.Apply(idxPaulis);
#line 78 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\PauliEvolutionSet.qs"
            var op = MicrosoftQuantumPrimitiveExp.Partial(new Func<QArray<Qubit>, (QArray<Pauli>,Double,QArray<Qubit>)>((_arg1) => (pauliString, (delta * idxDoubles[0L]), _arg1)));
#line 79 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\PauliEvolutionSet.qs"
            RestrictToSubregisterCA.Apply((((IUnitary)op), idxQubits)).Apply(qubits);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(GeneratorIndex,Double,QArray<Qubit>), QVoid> AdjointBody => (__in) =>
        {
            var (generatorIndex,delta,qubits) = __in;
#line 75 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\PauliEvolutionSet.qs"
            var ((idxPaulis,idxDoubles),idxQubits) = generatorIndex;
#line 76 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\PauliEvolutionSet.qs"
            var pauliString = IntsToPaulis.Apply(idxPaulis);
#line 78 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\PauliEvolutionSet.qs"
            var op = MicrosoftQuantumPrimitiveExp.Partial(new Func<QArray<Qubit>, (QArray<Pauli>,Double,QArray<Qubit>)>((_arg1) => (pauliString, (delta * idxDoubles[0L]), _arg1)));
            RestrictToSubregisterCA.Apply((((IUnitary)op), idxQubits)).Adjoint.Apply(qubits);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(GeneratorIndex,Double,QArray<Qubit>)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(generatorIndex,delta,qubits)) = __in;
            var ((idxPaulis,idxDoubles),idxQubits) = generatorIndex;
            var pauliString = IntsToPaulis.Apply(idxPaulis);
            var op = MicrosoftQuantumPrimitiveExp.Partial(new Func<QArray<Qubit>, (QArray<Pauli>,Double,QArray<Qubit>)>((_arg1) => (pauliString, (delta * idxDoubles[0L]), _arg1)));
            RestrictToSubregisterCA.Apply((((IUnitary)op), idxQubits)).Controlled.Apply((controlQubits, qubits));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(GeneratorIndex,Double,QArray<Qubit>)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,(generatorIndex,delta,qubits)) = __in;
            var ((idxPaulis,idxDoubles),idxQubits) = generatorIndex;
            var pauliString = IntsToPaulis.Apply(idxPaulis);
            var op = MicrosoftQuantumPrimitiveExp.Partial(new Func<QArray<Qubit>, (QArray<Pauli>,Double,QArray<Qubit>)>((_arg1) => (pauliString, (delta * idxDoubles[0L]), _arg1)));
            RestrictToSubregisterCA.Apply((((IUnitary)op), idxQubits)).Adjoint.Controlled.Apply((controlQubits, qubits));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveExp = this.Factory.Get<IUnitary<(QArray<Pauli>,Double,QArray<Qubit>)>>(typeof(Microsoft.Quantum.Primitive.Exp));
            this.IntsToPaulis = this.Factory.Get<ICallable<QArray<Int64>, QArray<Pauli>>>(typeof(Microsoft.Quantum.Canon.IntsToPaulis));
            this.RestrictToSubregisterCA = this.Factory.Get<ICallable<(IUnitary,QArray<Int64>), IUnitary>>(typeof(Microsoft.Quantum.Canon.RestrictToSubregisterCA));
        }

        public override IApplyData __dataIn((GeneratorIndex,Double,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, GeneratorIndex generatorIndex, Double delta, QArray<Qubit> qubits)
        {
            return __m__.Run<PauliEvolutionImpl, (GeneratorIndex,Double,QArray<Qubit>), QVoid>((generatorIndex, delta, qubits));
        }
    }

    public class PauliEvolutionFunction : Operation<GeneratorIndex, IUnitary>, ICallable
    {
        public PauliEvolutionFunction(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "PauliEvolutionFunction";
        String ICallable.FullName => "Microsoft.Quantum.Canon.PauliEvolutionFunction";
        protected IUnitary<(GeneratorIndex,Double,QArray<Qubit>)> PauliEvolutionImpl
        {
            get;
            set;
        }

        public override Func<GeneratorIndex, IUnitary> Body => (__in) =>
        {
            var generatorIndex = __in;
#line 100 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\PauliEvolutionSet.qs"
            return new EvolutionUnitary(PauliEvolutionImpl.Partial(new Func<(Double,QArray<Qubit>), (GeneratorIndex,Double,QArray<Qubit>)>((_arg1) => (generatorIndex, _arg1.Item1, _arg1.Item2))));
        }

        ;
        public override void Init()
        {
            this.PauliEvolutionImpl = this.Factory.Get<IUnitary<(GeneratorIndex,Double,QArray<Qubit>)>>(typeof(Microsoft.Quantum.Canon.PauliEvolutionImpl));
        }

        public override IApplyData __dataIn(GeneratorIndex data) => data;
        public override IApplyData __dataOut(IUnitary data) => new QTuple<IUnitary>(data);
        public static System.Threading.Tasks.Task<IUnitary> Run(IOperationFactory __m__, GeneratorIndex generatorIndex)
        {
            return __m__.Run<PauliEvolutionFunction, GeneratorIndex, IUnitary>(generatorIndex);
        }
    }

    public class PauliEvolutionSet : Operation<QVoid, ICallable>, ICallable
    {
        public PauliEvolutionSet(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "PauliEvolutionSet";
        String ICallable.FullName => "Microsoft.Quantum.Canon.PauliEvolutionSet";
        protected ICallable<GeneratorIndex, IUnitary> PauliEvolutionFunction
        {
            get;
            set;
        }

        public override Func<QVoid, ICallable> Body => (__in) =>
        {
#line 116 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Simulation\\PauliEvolutionSet.qs"
            return new EvolutionSet(PauliEvolutionFunction);
        }

        ;
        public override void Init()
        {
            this.PauliEvolutionFunction = this.Factory.Get<ICallable<GeneratorIndex, IUnitary>>(typeof(Microsoft.Quantum.Canon.PauliEvolutionFunction));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(ICallable data) => new QTuple<ICallable>(data);
        public static System.Threading.Tasks.Task<ICallable> Run(IOperationFactory __m__)
        {
            return __m__.Run<PauliEvolutionSet, QVoid, ICallable>(QVoid.Instance);
        }
    }
}