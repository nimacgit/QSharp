#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: UdtDeclaration("Microsoft.Quantum.Canon", "GeneratorIndex", "((Int[], Double[]), Int[])", "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Data\\GeneratorRepresentation.qs", 1446L, 33L, 50L)]
[assembly: UdtDeclaration("Microsoft.Quantum.Canon", "GeneratorSystem", "(Int, (Int -> Microsoft.Quantum.Canon.GeneratorIndex))", "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Data\\GeneratorRepresentation.qs", 2027L, 47L, 52L)]
[assembly: UdtDeclaration("Microsoft.Quantum.Canon", "TimeDependentGeneratorSystem", "(Double -> Microsoft.Quantum.Canon.GeneratorSystem)", "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Data\\GeneratorRepresentation.qs", 2255L, 52L, 72L)]
[assembly: UdtDeclaration("Microsoft.Quantum.Canon", "Unitary", "(Qubit[] => () : Adjoint, Controlled)", "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Data\\GeneratorRepresentation.qs", 2405L, 56L, 55L)]
[assembly: UdtDeclaration("Microsoft.Quantum.Canon", "EvolutionUnitary", "((Double, Qubit[]) => () : Adjoint, Controlled)", "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Data\\GeneratorRepresentation.qs", 2688L, 62L, 44L)]
[assembly: UdtDeclaration("Microsoft.Quantum.Canon", "EvolutionSet", "(Microsoft.Quantum.Canon.GeneratorIndex -> Microsoft.Quantum.Canon.EvolutionUnitary)", "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Data\\GeneratorRepresentation.qs", 3226L, 72L, 57L)]
[assembly: UdtDeclaration("Microsoft.Quantum.Canon", "EvolutionGenerator", "(Microsoft.Quantum.Canon.EvolutionSet, Microsoft.Quantum.Canon.GeneratorSystem)", "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Data\\GeneratorRepresentation.qs", 3479L, 78L, 43L)]
[assembly: UdtDeclaration("Microsoft.Quantum.Canon", "EvolutionSchedule", "(Microsoft.Quantum.Canon.EvolutionSet, (Double -> Microsoft.Quantum.Canon.GeneratorSystem))", "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Data\\GeneratorRepresentation.qs", 3684L, 83L, 45L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "IdentityGeneratorIndex (idxTerm : Int) : Microsoft.Quantum.Canon.GeneratorIndex", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Data\\GeneratorRepresentation.qs", 4193L, 98L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "IdentityGeneratorSystem () : Microsoft.Quantum.Canon.GeneratorSystem", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Data\\GeneratorRepresentation.qs", 4546L, 109L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "_IdentityTimeDependentGeneratorSystem (schedule : Double) : Microsoft.Quantum.Canon.GeneratorSystem", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Data\\GeneratorRepresentation.qs", 5159L, 125L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "IdentityTimeDependentGeneratorSystem () : Microsoft.Quantum.Canon.TimeDependentGeneratorSystem", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Data\\GeneratorRepresentation.qs", 5572L, 136L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "GetGeneratorSystemNTerms (generatorSystem : Microsoft.Quantum.Canon.GeneratorSystem) : Int", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Data\\GeneratorRepresentation.qs", 6095L, 152L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "GetGeneratorSystemFunction (generatorSystem : Microsoft.Quantum.Canon.GeneratorSystem) : (Int -> Microsoft.Quantum.Canon.GeneratorIndex)", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Data\\GeneratorRepresentation.qs", 6707L, 170L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "MultiplyGeneratorIndex (multiplier : Double, generatorIndex : Microsoft.Quantum.Canon.GeneratorIndex) : Microsoft.Quantum.Canon.GeneratorIndex", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Data\\GeneratorRepresentation.qs", 7731L, 199L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "_MultiplyGeneratorSystem (multiplier : Double, idxTerm : Int, generatorSystem : Microsoft.Quantum.Canon.GeneratorSystem) : Microsoft.Quantum.Canon.GeneratorIndex", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Data\\GeneratorRepresentation.qs", 8280L, 211L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "MultiplyGeneratorSystem (multiplier : Double, generatorSystem : Microsoft.Quantum.Canon.GeneratorSystem) : Microsoft.Quantum.Canon.GeneratorSystem", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Data\\GeneratorRepresentation.qs", 9044L, 231L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "_AddGeneratorSystems (idxTerm : Int, nTermsA : Int, nTermsB : Int, generatorIndexFunctionA : (Int -> Microsoft.Quantum.Canon.GeneratorIndex), generatorIndexFunctionB : (Int -> Microsoft.Quantum.Canon.GeneratorIndex)) : Microsoft.Quantum.Canon.GeneratorIndex", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Data\\GeneratorRepresentation.qs", 9518L, 242L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "AddGeneratorSystems (generatorSystemA : Microsoft.Quantum.Canon.GeneratorSystem, generatorSystemB : Microsoft.Quantum.Canon.GeneratorSystem) : Microsoft.Quantum.Canon.GeneratorSystem", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Data\\GeneratorRepresentation.qs", 10534L, 270L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "InterpolateGeneratorSystemsImpl (schedule : Double, generatorSystemStart : Microsoft.Quantum.Canon.GeneratorSystem, generatorSystemEnd : Microsoft.Quantum.Canon.GeneratorSystem) : Microsoft.Quantum.Canon.GeneratorSystem", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Data\\GeneratorRepresentation.qs", 11980L, 300L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "InterpolateGeneratorSystems (generatorSystemStart : Microsoft.Quantum.Canon.GeneratorSystem, generatorSystemEnd : Microsoft.Quantum.Canon.GeneratorSystem) : Microsoft.Quantum.Canon.TimeDependentGeneratorSystem", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Data\\GeneratorRepresentation.qs", 13134L, 326L, 14L)]
#line hidden
namespace Microsoft.Quantum.Canon
{
    public class GeneratorIndex : QTuple<((QArray<Int64>,QArray<Double>),QArray<Int64>)>, IApplyData
    {
        public GeneratorIndex() : base(default(((QArray<Int64>,QArray<Double>),QArray<Int64>)))
        {
        }

        public GeneratorIndex(((QArray<Int64>,QArray<Double>),QArray<Int64>) data) : base(data)
        {
        }

        public GeneratorIndex(QTuple<((QArray<Int64>,QArray<Double>),QArray<Int64>)> b) : base(b.Data)
        {
        }

        public (QArray<Int64>,QArray<Double>) Item1 => Data.Item1;
        public QArray<Int64> Item2 => Data.Item2;
        System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        public void Deconstruct(out (QArray<Int64>,QArray<Double>) item1, out QArray<Int64> item2)
        {
            item1 = Data.Item1;
            item2 = Data.Item2;
        }
    }

    public class GeneratorSystem : QTuple<(Int64,ICallable)>, IApplyData
    {
        public GeneratorSystem() : base(default((Int64,ICallable)))
        {
        }

        public GeneratorSystem((Int64,ICallable) data) : base(data)
        {
        }

        public GeneratorSystem(QTuple<(Int64,ICallable)> b) : base(b.Data)
        {
        }

        public Int64 Item1 => Data.Item1;
        public ICallable Item2 => Data.Item2;
        System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        public void Deconstruct(out Int64 item1, out ICallable item2)
        {
            item1 = Data.Item1;
            item2 = Data.Item2;
        }
    }

    public class TimeDependentGeneratorSystem : OperationUdt<Double,GeneratorSystem>, ICallable, IApplyData
    {
        public TimeDependentGeneratorSystem() : base(default(ICallable))
        {
        }

        public TimeDependentGeneratorSystem(ICallable data) : base(data)
        {
        }

        public TimeDependentGeneratorSystem(OperationUdt<Double,GeneratorSystem> b) : base(b.Data)
        {
        }

        String ICallable.Name => "TimeDependentGeneratorSystem";
        String ICallable.FullName => "Microsoft.Quantum.Canon.TimeDependentGeneratorSystem";
    }

    public class Unitary : OperationUdt<QArray<Qubit>,QVoid>, ICallable, IApplyData
    {
        public Unitary() : base(default(IUnitary))
        {
        }

        public Unitary(IUnitary data) : base(data)
        {
        }

        public Unitary(OperationUdt<QArray<Qubit>,QVoid> b) : base(b.Data)
        {
        }

        String ICallable.Name => "Unitary";
        String ICallable.FullName => "Microsoft.Quantum.Canon.Unitary";
    }

    public class EvolutionUnitary : OperationUdt<(Double,QArray<Qubit>),QVoid>, ICallable, IApplyData
    {
        public EvolutionUnitary() : base(default(IUnitary))
        {
        }

        public EvolutionUnitary(IUnitary data) : base(data)
        {
        }

        public EvolutionUnitary(OperationUdt<(Double,QArray<Qubit>),QVoid> b) : base(b.Data)
        {
        }

        String ICallable.Name => "EvolutionUnitary";
        String ICallable.FullName => "Microsoft.Quantum.Canon.EvolutionUnitary";
    }

    public class EvolutionSet : OperationUdt<GeneratorIndex,IUnitary>, ICallable, IApplyData
    {
        public EvolutionSet() : base(default(ICallable))
        {
        }

        public EvolutionSet(ICallable data) : base(data)
        {
        }

        public EvolutionSet(OperationUdt<GeneratorIndex,IUnitary> b) : base(b.Data)
        {
        }

        String ICallable.Name => "EvolutionSet";
        String ICallable.FullName => "Microsoft.Quantum.Canon.EvolutionSet";
    }

    public class EvolutionGenerator : QTuple<(ICallable,GeneratorSystem)>, IApplyData
    {
        public EvolutionGenerator() : base(default((ICallable,GeneratorSystem)))
        {
        }

        public EvolutionGenerator((ICallable,GeneratorSystem) data) : base(data)
        {
        }

        public EvolutionGenerator(QTuple<(ICallable,GeneratorSystem)> b) : base(b.Data)
        {
        }

        public ICallable Item1 => Data.Item1;
        public GeneratorSystem Item2 => Data.Item2;
        System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2?.Item2)?.Qubits);
        public void Deconstruct(out ICallable item1, out GeneratorSystem item2)
        {
            item1 = Data.Item1;
            item2 = Data.Item2;
        }
    }

    public class EvolutionSchedule : QTuple<(ICallable,ICallable)>, IApplyData
    {
        public EvolutionSchedule() : base(default((ICallable,ICallable)))
        {
        }

        public EvolutionSchedule((ICallable,ICallable) data) : base(data)
        {
        }

        public EvolutionSchedule(QTuple<(ICallable,ICallable)> b) : base(b.Data)
        {
        }

        public ICallable Item1 => Data.Item1;
        public ICallable Item2 => Data.Item2;
        System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        public void Deconstruct(out ICallable item1, out ICallable item2)
        {
            item1 = Data.Item1;
            item2 = Data.Item2;
        }
    }

    public class IdentityGeneratorIndex : Operation<Int64, GeneratorIndex>, ICallable
    {
        public IdentityGeneratorIndex(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "IdentityGeneratorIndex";
        String ICallable.FullName => "Microsoft.Quantum.Canon.IdentityGeneratorIndex";
        public override Func<Int64, GeneratorIndex> Body => (__in) =>
        {
            var idxTerm = __in;
#line 99 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Data\\GeneratorRepresentation.qs"
            return new GeneratorIndex(((new QArray<Int64>()
            {0L}, new QArray<Double>()
            {0D}), new QArray<Int64>()
            {0L}));
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __dataOut(GeneratorIndex data) => data;
        public static System.Threading.Tasks.Task<GeneratorIndex> Run(IOperationFactory __m__, Int64 idxTerm)
        {
            return __m__.Run<IdentityGeneratorIndex, Int64, GeneratorIndex>(idxTerm);
        }
    }

    public class IdentityGeneratorSystem : Operation<QVoid, GeneratorSystem>, ICallable
    {
        public IdentityGeneratorSystem(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "IdentityGeneratorSystem";
        String ICallable.FullName => "Microsoft.Quantum.Canon.IdentityGeneratorSystem";
        protected ICallable<Int64, GeneratorIndex> IdentityGeneratorIndex
        {
            get;
            set;
        }

        public override Func<QVoid, GeneratorSystem> Body => (__in) =>
        {
#line 110 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Data\\GeneratorRepresentation.qs"
            return new GeneratorSystem((0L, IdentityGeneratorIndex));
        }

        ;
        public override void Init()
        {
            this.IdentityGeneratorIndex = this.Factory.Get<ICallable<Int64, GeneratorIndex>>(typeof(Microsoft.Quantum.Canon.IdentityGeneratorIndex));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(GeneratorSystem data) => data;
        public static System.Threading.Tasks.Task<GeneratorSystem> Run(IOperationFactory __m__)
        {
            return __m__.Run<IdentityGeneratorSystem, QVoid, GeneratorSystem>(QVoid.Instance);
        }
    }

    public class _IdentityTimeDependentGeneratorSystem : Operation<Double, GeneratorSystem>, ICallable
    {
        public _IdentityTimeDependentGeneratorSystem(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "_IdentityTimeDependentGeneratorSystem";
        String ICallable.FullName => "Microsoft.Quantum.Canon._IdentityTimeDependentGeneratorSystem";
        protected ICallable<QVoid, GeneratorSystem> IdentityGeneratorSystem
        {
            get;
            set;
        }

        public override Func<Double, GeneratorSystem> Body => (__in) =>
        {
            var schedule = __in;
#line 126 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Data\\GeneratorRepresentation.qs"
            return IdentityGeneratorSystem.Apply(QVoid.Instance);
        }

        ;
        public override void Init()
        {
            this.IdentityGeneratorSystem = this.Factory.Get<ICallable<QVoid, GeneratorSystem>>(typeof(Microsoft.Quantum.Canon.IdentityGeneratorSystem));
        }

        public override IApplyData __dataIn(Double data) => new QTuple<Double>(data);
        public override IApplyData __dataOut(GeneratorSystem data) => data;
        public static System.Threading.Tasks.Task<GeneratorSystem> Run(IOperationFactory __m__, Double schedule)
        {
            return __m__.Run<_IdentityTimeDependentGeneratorSystem, Double, GeneratorSystem>(schedule);
        }
    }

    public class IdentityTimeDependentGeneratorSystem : Operation<QVoid, ICallable>, ICallable
    {
        public IdentityTimeDependentGeneratorSystem(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "IdentityTimeDependentGeneratorSystem";
        String ICallable.FullName => "Microsoft.Quantum.Canon.IdentityTimeDependentGeneratorSystem";
        protected ICallable<Double, GeneratorSystem> _IdentityTimeDependentGeneratorSystem
        {
            get;
            set;
        }

        public override Func<QVoid, ICallable> Body => (__in) =>
        {
#line 137 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Data\\GeneratorRepresentation.qs"
            return new TimeDependentGeneratorSystem(_IdentityTimeDependentGeneratorSystem);
        }

        ;
        public override void Init()
        {
            this._IdentityTimeDependentGeneratorSystem = this.Factory.Get<ICallable<Double, GeneratorSystem>>(typeof(Microsoft.Quantum.Canon._IdentityTimeDependentGeneratorSystem));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(ICallable data) => new QTuple<ICallable>(data);
        public static System.Threading.Tasks.Task<ICallable> Run(IOperationFactory __m__)
        {
            return __m__.Run<IdentityTimeDependentGeneratorSystem, QVoid, ICallable>(QVoid.Instance);
        }
    }

    public class GetGeneratorSystemNTerms : Operation<GeneratorSystem, Int64>, ICallable
    {
        public GetGeneratorSystemNTerms(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "GetGeneratorSystemNTerms";
        String ICallable.FullName => "Microsoft.Quantum.Canon.GetGeneratorSystemNTerms";
        public override Func<GeneratorSystem, Int64> Body => (__in) =>
        {
            var generatorSystem = __in;
#line 153 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Data\\GeneratorRepresentation.qs"
            var (nTerms,generatorIndexFunction) = generatorSystem;
#line 154 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Data\\GeneratorRepresentation.qs"
            return nTerms;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(GeneratorSystem data) => data;
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, GeneratorSystem generatorSystem)
        {
            return __m__.Run<GetGeneratorSystemNTerms, GeneratorSystem, Int64>(generatorSystem);
        }
    }

    public class GetGeneratorSystemFunction : Operation<GeneratorSystem, ICallable>, ICallable
    {
        public GetGeneratorSystemFunction(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "GetGeneratorSystemFunction";
        String ICallable.FullName => "Microsoft.Quantum.Canon.GetGeneratorSystemFunction";
        public override Func<GeneratorSystem, ICallable> Body => (__in) =>
        {
            var generatorSystem = __in;
#line 171 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Data\\GeneratorRepresentation.qs"
            var (nTerms,generatorIndexFunction) = generatorSystem;
#line 172 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Data\\GeneratorRepresentation.qs"
            return generatorIndexFunction;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(GeneratorSystem data) => data;
        public override IApplyData __dataOut(ICallable data) => new QTuple<ICallable>(data);
        public static System.Threading.Tasks.Task<ICallable> Run(IOperationFactory __m__, GeneratorSystem generatorSystem)
        {
            return __m__.Run<GetGeneratorSystemFunction, GeneratorSystem, ICallable>(generatorSystem);
        }
    }

    public class MultiplyGeneratorIndex : Operation<(Double,GeneratorIndex), GeneratorIndex>, ICallable
    {
        public MultiplyGeneratorIndex(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Double,GeneratorIndex)>, IApplyData
        {
            public In((Double,GeneratorIndex) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "MultiplyGeneratorIndex";
        String ICallable.FullName => "Microsoft.Quantum.Canon.MultiplyGeneratorIndex";
        public override Func<(Double,GeneratorIndex), GeneratorIndex> Body => (__in) =>
        {
            var (multiplier,generatorIndex) = __in;
#line 200 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Data\\GeneratorRepresentation.qs"
            var ((idxTerms,idxDoubles),idxSystems) = generatorIndex;
#line 201 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Data\\GeneratorRepresentation.qs"
            var idxDoublesOut = idxDoubles;
#line 202 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Data\\GeneratorRepresentation.qs"
            idxDoublesOut[0L] = (multiplier * idxDoublesOut[0L]);
#line 203 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Data\\GeneratorRepresentation.qs"
            return new GeneratorIndex(((idxTerms, idxDoublesOut), idxSystems));
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((Double,GeneratorIndex) data) => new In(data);
        public override IApplyData __dataOut(GeneratorIndex data) => data;
        public static System.Threading.Tasks.Task<GeneratorIndex> Run(IOperationFactory __m__, Double multiplier, GeneratorIndex generatorIndex)
        {
            return __m__.Run<MultiplyGeneratorIndex, (Double,GeneratorIndex), GeneratorIndex>((multiplier, generatorIndex));
        }
    }

    public class _MultiplyGeneratorSystem : Operation<(Double,Int64,GeneratorSystem), GeneratorIndex>, ICallable
    {
        public _MultiplyGeneratorSystem(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Double,Int64,GeneratorSystem)>, IApplyData
        {
            public In((Double,Int64,GeneratorSystem) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item3?.Item2)?.Qubits;
        }

        String ICallable.Name => "_MultiplyGeneratorSystem";
        String ICallable.FullName => "Microsoft.Quantum.Canon._MultiplyGeneratorSystem";
        protected ICallable<(Double,GeneratorIndex), GeneratorIndex> MultiplyGeneratorIndex
        {
            get;
            set;
        }

        public override Func<(Double,Int64,GeneratorSystem), GeneratorIndex> Body => (__in) =>
        {
            var (multiplier,idxTerm,generatorSystem) = __in;
#line 212 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Data\\GeneratorRepresentation.qs"
            var (nTerms,generatorIndexFunction) = generatorSystem;
#line 213 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Data\\GeneratorRepresentation.qs"
            return MultiplyGeneratorIndex.Apply((multiplier, generatorIndexFunction.Apply<GeneratorIndex>(idxTerm)));
        }

        ;
        public override void Init()
        {
            this.MultiplyGeneratorIndex = this.Factory.Get<ICallable<(Double,GeneratorIndex), GeneratorIndex>>(typeof(Microsoft.Quantum.Canon.MultiplyGeneratorIndex));
        }

        public override IApplyData __dataIn((Double,Int64,GeneratorSystem) data) => new In(data);
        public override IApplyData __dataOut(GeneratorIndex data) => data;
        public static System.Threading.Tasks.Task<GeneratorIndex> Run(IOperationFactory __m__, Double multiplier, Int64 idxTerm, GeneratorSystem generatorSystem)
        {
            return __m__.Run<_MultiplyGeneratorSystem, (Double,Int64,GeneratorSystem), GeneratorIndex>((multiplier, idxTerm, generatorSystem));
        }
    }

    public class MultiplyGeneratorSystem : Operation<(Double,GeneratorSystem), GeneratorSystem>, ICallable
    {
        public MultiplyGeneratorSystem(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Double,GeneratorSystem)>, IApplyData
        {
            public In((Double,GeneratorSystem) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2?.Item2)?.Qubits;
        }

        String ICallable.Name => "MultiplyGeneratorSystem";
        String ICallable.FullName => "Microsoft.Quantum.Canon.MultiplyGeneratorSystem";
        protected ICallable<GeneratorSystem, Int64> GetGeneratorSystemNTerms
        {
            get;
            set;
        }

        protected ICallable<(Double,Int64,GeneratorSystem), GeneratorIndex> _MultiplyGeneratorSystem
        {
            get;
            set;
        }

        public override Func<(Double,GeneratorSystem), GeneratorSystem> Body => (__in) =>
        {
            var (multiplier,generatorSystem) = __in;
#line 232 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Data\\GeneratorRepresentation.qs"
            var nTerms = GetGeneratorSystemNTerms.Apply(generatorSystem);
#line 233 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Data\\GeneratorRepresentation.qs"
            return new GeneratorSystem((nTerms, _MultiplyGeneratorSystem.Partial(new Func<Int64, (Double,Int64,GeneratorSystem)>((_arg1) => (multiplier, _arg1, generatorSystem)))));
        }

        ;
        public override void Init()
        {
            this.GetGeneratorSystemNTerms = this.Factory.Get<ICallable<GeneratorSystem, Int64>>(typeof(Microsoft.Quantum.Canon.GetGeneratorSystemNTerms));
            this._MultiplyGeneratorSystem = this.Factory.Get<ICallable<(Double,Int64,GeneratorSystem), GeneratorIndex>>(typeof(Microsoft.Quantum.Canon._MultiplyGeneratorSystem));
        }

        public override IApplyData __dataIn((Double,GeneratorSystem) data) => new In(data);
        public override IApplyData __dataOut(GeneratorSystem data) => data;
        public static System.Threading.Tasks.Task<GeneratorSystem> Run(IOperationFactory __m__, Double multiplier, GeneratorSystem generatorSystem)
        {
            return __m__.Run<MultiplyGeneratorSystem, (Double,GeneratorSystem), GeneratorSystem>((multiplier, generatorSystem));
        }
    }

    public class _AddGeneratorSystems : Operation<(Int64,Int64,Int64,ICallable,ICallable), GeneratorIndex>, ICallable
    {
        public _AddGeneratorSystems(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64,Int64,ICallable,ICallable)>, IApplyData
        {
            public In((Int64,Int64,Int64,ICallable,ICallable) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item4)?.Qubits, ((IApplyData)Data.Item5)?.Qubits);
        }

        String ICallable.Name => "_AddGeneratorSystems";
        String ICallable.FullName => "Microsoft.Quantum.Canon._AddGeneratorSystems";
        public override Func<(Int64,Int64,Int64,ICallable,ICallable), GeneratorIndex> Body => (__in) =>
        {
            var (idxTerm,nTermsA,nTermsB,generatorIndexFunctionA,generatorIndexFunctionB) = __in;
#line 247 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Data\\GeneratorRepresentation.qs"
            if ((idxTerm < nTermsA))
            {
#line 248 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Data\\GeneratorRepresentation.qs"
                return generatorIndexFunctionA.Apply<GeneratorIndex>(idxTerm);
            }
            else
            {
#line 251 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Data\\GeneratorRepresentation.qs"
                return generatorIndexFunctionB.Apply<GeneratorIndex>((idxTerm - nTermsA));
            }
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((Int64,Int64,Int64,ICallable,ICallable) data) => new In(data);
        public override IApplyData __dataOut(GeneratorIndex data) => data;
        public static System.Threading.Tasks.Task<GeneratorIndex> Run(IOperationFactory __m__, Int64 idxTerm, Int64 nTermsA, Int64 nTermsB, ICallable generatorIndexFunctionA, ICallable generatorIndexFunctionB)
        {
            return __m__.Run<_AddGeneratorSystems, (Int64,Int64,Int64,ICallable,ICallable), GeneratorIndex>((idxTerm, nTermsA, nTermsB, generatorIndexFunctionA, generatorIndexFunctionB));
        }
    }

    public class AddGeneratorSystems : Operation<(GeneratorSystem,GeneratorSystem), GeneratorSystem>, ICallable
    {
        public AddGeneratorSystems(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(GeneratorSystem,GeneratorSystem)>, IApplyData
        {
            public In((GeneratorSystem,GeneratorSystem) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1?.Item2)?.Qubits, ((IApplyData)Data.Item2?.Item2)?.Qubits);
        }

        String ICallable.Name => "AddGeneratorSystems";
        String ICallable.FullName => "Microsoft.Quantum.Canon.AddGeneratorSystems";
        protected ICallable<GeneratorSystem, ICallable> GetGeneratorSystemFunction
        {
            get;
            set;
        }

        protected ICallable<GeneratorSystem, Int64> GetGeneratorSystemNTerms
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64,Int64,ICallable,ICallable), GeneratorIndex> _AddGeneratorSystems
        {
            get;
            set;
        }

        public override Func<(GeneratorSystem,GeneratorSystem), GeneratorSystem> Body => (__in) =>
        {
            var (generatorSystemA,generatorSystemB) = __in;
#line 271 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Data\\GeneratorRepresentation.qs"
            var nTermsA = GetGeneratorSystemNTerms.Apply(generatorSystemA);
#line 272 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Data\\GeneratorRepresentation.qs"
            var nTermsB = GetGeneratorSystemNTerms.Apply(generatorSystemB);
#line 273 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Data\\GeneratorRepresentation.qs"
            var generatorIndexFunctionA = GetGeneratorSystemFunction.Apply(generatorSystemA);
#line 274 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Data\\GeneratorRepresentation.qs"
            var generatorIndexFunctionB = GetGeneratorSystemFunction.Apply(generatorSystemB);
#line 275 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Data\\GeneratorRepresentation.qs"
            var generatorIndexFunction = _AddGeneratorSystems.Partial(new Func<Int64, (Int64,Int64,Int64,ICallable,ICallable)>((_arg1) => (_arg1, nTermsA, nTermsB, ((ICallable)generatorIndexFunctionA), ((ICallable)generatorIndexFunctionB))));
#line 276 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Data\\GeneratorRepresentation.qs"
            return new GeneratorSystem(((nTermsA + nTermsB), generatorIndexFunction));
        }

        ;
        public override void Init()
        {
            this.GetGeneratorSystemFunction = this.Factory.Get<ICallable<GeneratorSystem, ICallable>>(typeof(Microsoft.Quantum.Canon.GetGeneratorSystemFunction));
            this.GetGeneratorSystemNTerms = this.Factory.Get<ICallable<GeneratorSystem, Int64>>(typeof(Microsoft.Quantum.Canon.GetGeneratorSystemNTerms));
            this._AddGeneratorSystems = this.Factory.Get<ICallable<(Int64,Int64,Int64,ICallable,ICallable), GeneratorIndex>>(typeof(Microsoft.Quantum.Canon._AddGeneratorSystems));
        }

        public override IApplyData __dataIn((GeneratorSystem,GeneratorSystem) data) => new In(data);
        public override IApplyData __dataOut(GeneratorSystem data) => data;
        public static System.Threading.Tasks.Task<GeneratorSystem> Run(IOperationFactory __m__, GeneratorSystem generatorSystemA, GeneratorSystem generatorSystemB)
        {
            return __m__.Run<AddGeneratorSystems, (GeneratorSystem,GeneratorSystem), GeneratorSystem>((generatorSystemA, generatorSystemB));
        }
    }

    public class InterpolateGeneratorSystemsImpl : Operation<(Double,GeneratorSystem,GeneratorSystem), GeneratorSystem>, ICallable
    {
        public InterpolateGeneratorSystemsImpl(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Double,GeneratorSystem,GeneratorSystem)>, IApplyData
        {
            public In((Double,GeneratorSystem,GeneratorSystem) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item2?.Item2)?.Qubits, ((IApplyData)Data.Item3?.Item2)?.Qubits);
        }

        String ICallable.Name => "InterpolateGeneratorSystemsImpl";
        String ICallable.FullName => "Microsoft.Quantum.Canon.InterpolateGeneratorSystemsImpl";
        protected ICallable<(GeneratorSystem,GeneratorSystem), GeneratorSystem> AddGeneratorSystems
        {
            get;
            set;
        }

        protected ICallable<(Double,GeneratorSystem), GeneratorSystem> MultiplyGeneratorSystem
        {
            get;
            set;
        }

        public override Func<(Double,GeneratorSystem,GeneratorSystem), GeneratorSystem> Body => (__in) =>
        {
            var (schedule,generatorSystemStart,generatorSystemEnd) = __in;
#line 302 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Data\\GeneratorRepresentation.qs"
            var sysStart = MultiplyGeneratorSystem.Apply(((1D - schedule), generatorSystemStart));
#line 303 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Data\\GeneratorRepresentation.qs"
            var sysEnd = MultiplyGeneratorSystem.Apply((schedule, generatorSystemEnd));
#line 304 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Data\\GeneratorRepresentation.qs"
            return AddGeneratorSystems.Apply((sysStart, sysEnd));
        }

        ;
        public override void Init()
        {
            this.AddGeneratorSystems = this.Factory.Get<ICallable<(GeneratorSystem,GeneratorSystem), GeneratorSystem>>(typeof(Microsoft.Quantum.Canon.AddGeneratorSystems));
            this.MultiplyGeneratorSystem = this.Factory.Get<ICallable<(Double,GeneratorSystem), GeneratorSystem>>(typeof(Microsoft.Quantum.Canon.MultiplyGeneratorSystem));
        }

        public override IApplyData __dataIn((Double,GeneratorSystem,GeneratorSystem) data) => new In(data);
        public override IApplyData __dataOut(GeneratorSystem data) => data;
        public static System.Threading.Tasks.Task<GeneratorSystem> Run(IOperationFactory __m__, Double schedule, GeneratorSystem generatorSystemStart, GeneratorSystem generatorSystemEnd)
        {
            return __m__.Run<InterpolateGeneratorSystemsImpl, (Double,GeneratorSystem,GeneratorSystem), GeneratorSystem>((schedule, generatorSystemStart, generatorSystemEnd));
        }
    }

    public class InterpolateGeneratorSystems : Operation<(GeneratorSystem,GeneratorSystem), ICallable>, ICallable
    {
        public InterpolateGeneratorSystems(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(GeneratorSystem,GeneratorSystem)>, IApplyData
        {
            public In((GeneratorSystem,GeneratorSystem) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1?.Item2)?.Qubits, ((IApplyData)Data.Item2?.Item2)?.Qubits);
        }

        String ICallable.Name => "InterpolateGeneratorSystems";
        String ICallable.FullName => "Microsoft.Quantum.Canon.InterpolateGeneratorSystems";
        protected ICallable<(Double,GeneratorSystem,GeneratorSystem), GeneratorSystem> InterpolateGeneratorSystemsImpl
        {
            get;
            set;
        }

        public override Func<(GeneratorSystem,GeneratorSystem), ICallable> Body => (__in) =>
        {
            var (generatorSystemStart,generatorSystemEnd) = __in;
#line 328 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Data\\GeneratorRepresentation.qs"
            return new TimeDependentGeneratorSystem(InterpolateGeneratorSystemsImpl.Partial(new Func<Double, (Double,GeneratorSystem,GeneratorSystem)>((_arg1) => (_arg1, generatorSystemStart, generatorSystemEnd))));
        }

        ;
        public override void Init()
        {
            this.InterpolateGeneratorSystemsImpl = this.Factory.Get<ICallable<(Double,GeneratorSystem,GeneratorSystem), GeneratorSystem>>(typeof(Microsoft.Quantum.Canon.InterpolateGeneratorSystemsImpl));
        }

        public override IApplyData __dataIn((GeneratorSystem,GeneratorSystem) data) => new In(data);
        public override IApplyData __dataOut(ICallable data) => new QTuple<ICallable>(data);
        public static System.Threading.Tasks.Task<ICallable> Run(IOperationFactory __m__, GeneratorSystem generatorSystemStart, GeneratorSystem generatorSystemEnd)
        {
            return __m__.Run<InterpolateGeneratorSystems, (GeneratorSystem,GeneratorSystem), ICallable>((generatorSystemStart, generatorSystemEnd));
        }
    }
}