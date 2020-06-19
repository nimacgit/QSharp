#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "RAll1 (phase : Double, qubits : Qubit[]) : ()", new string[] { "Controlled", "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\Utils.qs", 568L, 17L, 5L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "RAll0 (phase : Double, qubits : Qubit[]) : ()", new string[] { "Controlled", "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\Utils.qs", 1357L, 44L, 5L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "_ObliviousOracleFromDeterministicStateOracle (ancillaOracle : Microsoft.Quantum.Canon.DeterministicStateOracle, signalOracle : Microsoft.Quantum.Canon.ObliviousOracle, ancillaRegister : Qubit[], systemRegister : Qubit[]) : ()", new string[] { "Controlled", "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\Utils.qs", 1859L, 58L, 189L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "_DeterministicStateOracleFromStateOracle (idxFlagQubit : Int, stateOracle : Microsoft.Quantum.Canon.StateOracle, startQubits : Qubit[]) : ()", new string[] { "Controlled", "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\Utils.qs", 3184L, 89L, 128L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "_StateOracleFromDeterministicStateOracle (idxFlagQubit : Int, oracleStateDeterministic : Microsoft.Quantum.Canon.DeterministicStateOracle, qubits : Qubit[]) : ()", new string[] { "Controlled", "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\Utils.qs", 4680L, 124L, 5L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "_ReflectionStart (phase : Double, qubits : Qubit[]) : ()", new string[] { "Controlled", "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\Utils.qs", 5824L, 154L, 70L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "ReflectionOracleFromDeterministicStateOracleImpl (phase : Double, oracle : Microsoft.Quantum.Canon.DeterministicStateOracle, systemRegister : Qubit[]) : ()", new string[] { "Controlled", "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\Utils.qs", 6715L, 178L, 5L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "TargetStateReflectionOracleImpl (phase : Double, idxFlagQubit : Int, qubits : Qubit[]) : ()", new string[] { "Controlled", "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\Utils.qs", 7890L, 209L, 5L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "ObliviousOracleFromDeterministicStateOracle (ancillaOracle : Microsoft.Quantum.Canon.DeterministicStateOracle, signalOracle : Microsoft.Quantum.Canon.ObliviousOracle) : Microsoft.Quantum.Canon.ObliviousOracle", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\Utils.qs", 2680L, 83L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "DeterministicStateOracleFromStateOracle (idxFlagQubit : Int, stateOracle : Microsoft.Quantum.Canon.StateOracle) : Microsoft.Quantum.Canon.DeterministicStateOracle", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\Utils.qs", 4171L, 117L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "StateOracleFromDeterministicStateOracle (deterministicStateOracle : Microsoft.Quantum.Canon.DeterministicStateOracle) : Microsoft.Quantum.Canon.StateOracle", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\Utils.qs", 5443L, 148L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "ReflectionStart () : Microsoft.Quantum.Canon.ReflectionOracle", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\Utils.qs", 6337L, 171L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "ReflectionOracleFromDeterministicStateOracle (oracle : Microsoft.Quantum.Canon.DeterministicStateOracle) : Microsoft.Quantum.Canon.ReflectionOracle", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\Utils.qs", 7464L, 201L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "TargetStateReflectionOracle (idxFlagQubit : Int) : Microsoft.Quantum.Canon.ReflectionOracle", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\Utils.qs", 8539L, 232L, 14L)]
#line hidden
namespace Microsoft.Quantum.Canon
{
    public class RAll1 : Unitary<(Double,QArray<Qubit>)>, ICallable
    {
        public RAll1(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Double,QArray<Qubit>)>, IApplyData
        {
            public In((Double,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "RAll1";
        String ICallable.FullName => "Microsoft.Quantum.Canon.RAll1";
        protected IUnitary<(Double,Qubit)> MicrosoftQuantumPrimitiveR1
        {
            get;
            set;
        }

        public override Func<(Double,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (phase,qubits) = __in;
#line 19 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\Utils.qs"
            var nQubits = qubits.Count;
#line 20 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\Utils.qs"
            var flagQubit = qubits[0L];
#line 21 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\Utils.qs"
            var systemRegister = qubits?.Slice(new Range(1L, (nQubits - 1L)));
#line 23 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\Utils.qs"
            MicrosoftQuantumPrimitiveR1.Partial(new Func<Qubit, (Double,Qubit)>((_arg1) => (phase, _arg1))).Controlled.Apply((systemRegister, flagQubit));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Double,QArray<Qubit>), QVoid> AdjointBody => (__in) =>
        {
            var (phase,qubits) = __in;
#line 19 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\Utils.qs"
            var nQubits = qubits.Count;
#line 20 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\Utils.qs"
            var flagQubit = qubits[0L];
#line 21 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\Utils.qs"
            var systemRegister = qubits?.Slice(new Range(1L, (nQubits - 1L)));
            MicrosoftQuantumPrimitiveR1.Partial(new Func<Qubit, (Double,Qubit)>((_arg1) => (phase, _arg1))).Controlled.Adjoint.Apply((systemRegister, flagQubit));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Double,QArray<Qubit>)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(phase,qubits)) = __in;
            var nQubits = qubits.Count;
            var flagQubit = qubits[0L];
            var systemRegister = qubits?.Slice(new Range(1L, (nQubits - 1L)));
            MicrosoftQuantumPrimitiveR1.Partial(new Func<Qubit, (Double,Qubit)>((_arg1) => (phase, _arg1))).Controlled.Controlled.Apply((controlQubits, (systemRegister, flagQubit)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Double,QArray<Qubit>)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,(phase,qubits)) = __in;
            var nQubits = qubits.Count;
            var flagQubit = qubits[0L];
            var systemRegister = qubits?.Slice(new Range(1L, (nQubits - 1L)));
            MicrosoftQuantumPrimitiveR1.Partial(new Func<Qubit, (Double,Qubit)>((_arg1) => (phase, _arg1))).Controlled.Adjoint.Controlled.Apply((controlQubits, (systemRegister, flagQubit)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveR1 = this.Factory.Get<IUnitary<(Double,Qubit)>>(typeof(Microsoft.Quantum.Primitive.R1));
        }

        public override IApplyData __dataIn((Double,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Double phase, QArray<Qubit> qubits)
        {
            return __m__.Run<RAll1, (Double,QArray<Qubit>), QVoid>((phase, qubits));
        }
    }

    public class RAll0 : Unitary<(Double,QArray<Qubit>)>, ICallable
    {
        public RAll0(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Double,QArray<Qubit>)>, IApplyData
        {
            public In((Double,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "RAll0";
        String ICallable.FullName => "Microsoft.Quantum.Canon.RAll0";
        protected IUnitary ApplyToEachCA
        {
            get;
            set;
        }

        protected IUnitary<(Double,QArray<Qubit>)> RAll1
        {
            get;
            set;
        }

        protected IUnitary WithCA
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(Double,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (phase,qubits) = __in;
#line 47 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\Utils.qs"
            WithCA.Apply((((IAdjointable)ApplyToEachCA.Partial((((IUnitary)MicrosoftQuantumPrimitiveX), _))), ((IUnitary)RAll1.Partial(new Func<QArray<Qubit>, (Double,QArray<Qubit>)>((_arg1) => (phase, _arg1)))), qubits));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Double,QArray<Qubit>), QVoid> AdjointBody => (__in) =>
        {
            var (phase,qubits) = __in;
            WithCA.Adjoint.Apply((((IAdjointable)ApplyToEachCA.Partial((((IUnitary)MicrosoftQuantumPrimitiveX), _))), ((IUnitary)RAll1.Partial(new Func<QArray<Qubit>, (Double,QArray<Qubit>)>((_arg1) => (phase, _arg1)))), qubits));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Double,QArray<Qubit>)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(phase,qubits)) = __in;
            WithCA.Controlled.Apply((controlQubits, (((IAdjointable)ApplyToEachCA.Partial((((IUnitary)MicrosoftQuantumPrimitiveX), _))), ((IUnitary)RAll1.Partial(new Func<QArray<Qubit>, (Double,QArray<Qubit>)>((_arg1) => (phase, _arg1)))), qubits)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Double,QArray<Qubit>)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,(phase,qubits)) = __in;
            WithCA.Adjoint.Controlled.Apply((controlQubits, (((IAdjointable)ApplyToEachCA.Partial((((IUnitary)MicrosoftQuantumPrimitiveX), _))), ((IUnitary)RAll1.Partial(new Func<QArray<Qubit>, (Double,QArray<Qubit>)>((_arg1) => (phase, _arg1)))), qubits)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.ApplyToEachCA = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.ApplyToEachCA<>));
            this.RAll1 = this.Factory.Get<IUnitary<(Double,QArray<Qubit>)>>(typeof(Microsoft.Quantum.Canon.RAll1));
            this.WithCA = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.WithCA<>));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((Double,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Double phase, QArray<Qubit> qubits)
        {
            return __m__.Run<RAll0, (Double,QArray<Qubit>), QVoid>((phase, qubits));
        }
    }

    public class _ObliviousOracleFromDeterministicStateOracle : Unitary<(IUnitary,IUnitary,QArray<Qubit>,QArray<Qubit>)>, ICallable
    {
        public _ObliviousOracleFromDeterministicStateOracle(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IUnitary,IUnitary,QArray<Qubit>,QArray<Qubit>)>, IApplyData
        {
            public In((IUnitary,IUnitary,QArray<Qubit>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits, ((IApplyData)Data.Item4)?.Qubits);
        }

        String ICallable.Name => "_ObliviousOracleFromDeterministicStateOracle";
        String ICallable.FullName => "Microsoft.Quantum.Canon._ObliviousOracleFromDeterministicStateOracle";
        public override Func<(IUnitary,IUnitary,QArray<Qubit>,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (ancillaOracle,signalOracle,ancillaRegister,systemRegister) = __in;
#line 60 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\Utils.qs"
            ancillaOracle.Apply(ancillaRegister);
#line 61 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\Utils.qs"
            signalOracle.Apply((ancillaRegister, systemRegister));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IUnitary,IUnitary,QArray<Qubit>,QArray<Qubit>), QVoid> AdjointBody => (__in) =>
        {
            var (ancillaOracle,signalOracle,ancillaRegister,systemRegister) = __in;
            signalOracle.Adjoint.Apply((ancillaRegister, systemRegister));
            ancillaOracle.Adjoint.Apply(ancillaRegister);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(IUnitary,IUnitary,QArray<Qubit>,QArray<Qubit>)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(ancillaOracle,signalOracle,ancillaRegister,systemRegister)) = __in;
            ancillaOracle.Controlled.Apply((controlQubits, ancillaRegister));
            signalOracle.Controlled.Apply((controlQubits, (ancillaRegister, systemRegister)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(IUnitary,IUnitary,QArray<Qubit>,QArray<Qubit>)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,(ancillaOracle,signalOracle,ancillaRegister,systemRegister)) = __in;
            signalOracle.Adjoint.Controlled.Apply((controlQubits, (ancillaRegister, systemRegister)));
            ancillaOracle.Adjoint.Controlled.Apply((controlQubits, ancillaRegister));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((IUnitary,IUnitary,QArray<Qubit>,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IUnitary ancillaOracle, IUnitary signalOracle, QArray<Qubit> ancillaRegister, QArray<Qubit> systemRegister)
        {
            return __m__.Run<_ObliviousOracleFromDeterministicStateOracle, (IUnitary,IUnitary,QArray<Qubit>,QArray<Qubit>), QVoid>((ancillaOracle, signalOracle, ancillaRegister, systemRegister));
        }
    }

    public class ObliviousOracleFromDeterministicStateOracle : Operation<(IUnitary,IUnitary), IUnitary>, ICallable
    {
        public ObliviousOracleFromDeterministicStateOracle(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IUnitary,IUnitary)>, IApplyData
        {
            public In((IUnitary,IUnitary) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "ObliviousOracleFromDeterministicStateOracle";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ObliviousOracleFromDeterministicStateOracle";
        protected IUnitary<(IUnitary,IUnitary,QArray<Qubit>,QArray<Qubit>)> _ObliviousOracleFromDeterministicStateOracle
        {
            get;
            set;
        }

        public override Func<(IUnitary,IUnitary), IUnitary> Body => (__in) =>
        {
            var (ancillaOracle,signalOracle) = __in;
#line 84 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\Utils.qs"
            return new ObliviousOracle(_ObliviousOracleFromDeterministicStateOracle.Partial(new Func<(QArray<Qubit>,QArray<Qubit>), (IUnitary,IUnitary,QArray<Qubit>,QArray<Qubit>)>((_arg1) => (ancillaOracle, signalOracle, _arg1.Item1, _arg1.Item2))));
        }

        ;
        public override void Init()
        {
            this._ObliviousOracleFromDeterministicStateOracle = this.Factory.Get<IUnitary<(IUnitary,IUnitary,QArray<Qubit>,QArray<Qubit>)>>(typeof(Microsoft.Quantum.Canon._ObliviousOracleFromDeterministicStateOracle));
        }

        public override IApplyData __dataIn((IUnitary,IUnitary) data) => new In(data);
        public override IApplyData __dataOut(IUnitary data) => new QTuple<IUnitary>(data);
        public static System.Threading.Tasks.Task<IUnitary> Run(IOperationFactory __m__, IUnitary ancillaOracle, IUnitary signalOracle)
        {
            return __m__.Run<ObliviousOracleFromDeterministicStateOracle, (IUnitary,IUnitary), IUnitary>((ancillaOracle, signalOracle));
        }
    }

    public class _DeterministicStateOracleFromStateOracle : Unitary<(Int64,IUnitary,QArray<Qubit>)>, ICallable
    {
        public _DeterministicStateOracleFromStateOracle(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,IUnitary,QArray<Qubit>)>, IApplyData
        {
            public In((Int64,IUnitary,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "_DeterministicStateOracleFromStateOracle";
        String ICallable.FullName => "Microsoft.Quantum.Canon._DeterministicStateOracleFromStateOracle";
        public override Func<(Int64,IUnitary,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (idxFlagQubit,stateOracle,startQubits) = __in;
#line 91 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\Utils.qs"
            stateOracle.Apply((idxFlagQubit, startQubits));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Int64,IUnitary,QArray<Qubit>), QVoid> AdjointBody => (__in) =>
        {
            var (idxFlagQubit,stateOracle,startQubits) = __in;
            stateOracle.Adjoint.Apply((idxFlagQubit, startQubits));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Int64,IUnitary,QArray<Qubit>)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(idxFlagQubit,stateOracle,startQubits)) = __in;
            stateOracle.Controlled.Apply((controlQubits, (idxFlagQubit, startQubits)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Int64,IUnitary,QArray<Qubit>)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,(idxFlagQubit,stateOracle,startQubits)) = __in;
            stateOracle.Adjoint.Controlled.Apply((controlQubits, (idxFlagQubit, startQubits)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((Int64,IUnitary,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 idxFlagQubit, IUnitary stateOracle, QArray<Qubit> startQubits)
        {
            return __m__.Run<_DeterministicStateOracleFromStateOracle, (Int64,IUnitary,QArray<Qubit>), QVoid>((idxFlagQubit, stateOracle, startQubits));
        }
    }

    public class DeterministicStateOracleFromStateOracle : Operation<(Int64,IUnitary), IUnitary>, ICallable
    {
        public DeterministicStateOracleFromStateOracle(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,IUnitary)>, IApplyData
        {
            public In((Int64,IUnitary) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "DeterministicStateOracleFromStateOracle";
        String ICallable.FullName => "Microsoft.Quantum.Canon.DeterministicStateOracleFromStateOracle";
        protected IUnitary<(Int64,IUnitary,QArray<Qubit>)> _DeterministicStateOracleFromStateOracle
        {
            get;
            set;
        }

        public override Func<(Int64,IUnitary), IUnitary> Body => (__in) =>
        {
            var (idxFlagQubit,stateOracle) = __in;
#line 118 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\Utils.qs"
            return new DeterministicStateOracle(_DeterministicStateOracleFromStateOracle.Partial(new Func<QArray<Qubit>, (Int64,IUnitary,QArray<Qubit>)>((_arg1) => (idxFlagQubit, stateOracle, _arg1))));
        }

        ;
        public override void Init()
        {
            this._DeterministicStateOracleFromStateOracle = this.Factory.Get<IUnitary<(Int64,IUnitary,QArray<Qubit>)>>(typeof(Microsoft.Quantum.Canon._DeterministicStateOracleFromStateOracle));
        }

        public override IApplyData __dataIn((Int64,IUnitary) data) => new In(data);
        public override IApplyData __dataOut(IUnitary data) => new QTuple<IUnitary>(data);
        public static System.Threading.Tasks.Task<IUnitary> Run(IOperationFactory __m__, Int64 idxFlagQubit, IUnitary stateOracle)
        {
            return __m__.Run<DeterministicStateOracleFromStateOracle, (Int64,IUnitary), IUnitary>((idxFlagQubit, stateOracle));
        }
    }

    public class _StateOracleFromDeterministicStateOracle : Unitary<(Int64,IUnitary,QArray<Qubit>)>, ICallable
    {
        public _StateOracleFromDeterministicStateOracle(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,IUnitary,QArray<Qubit>)>, IApplyData
        {
            public In((Int64,IUnitary,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "_StateOracleFromDeterministicStateOracle";
        String ICallable.FullName => "Microsoft.Quantum.Canon._StateOracleFromDeterministicStateOracle";
        public override Func<(Int64,IUnitary,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (idxFlagQubit,oracleStateDeterministic,qubits) = __in;
#line 126 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\Utils.qs"
            oracleStateDeterministic.Apply(qubits);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Int64,IUnitary,QArray<Qubit>), QVoid> AdjointBody => (__in) =>
        {
            var (idxFlagQubit,oracleStateDeterministic,qubits) = __in;
            oracleStateDeterministic.Adjoint.Apply(qubits);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Int64,IUnitary,QArray<Qubit>)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(idxFlagQubit,oracleStateDeterministic,qubits)) = __in;
            oracleStateDeterministic.Controlled.Apply((controlQubits, qubits));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Int64,IUnitary,QArray<Qubit>)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,(idxFlagQubit,oracleStateDeterministic,qubits)) = __in;
            oracleStateDeterministic.Adjoint.Controlled.Apply((controlQubits, qubits));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((Int64,IUnitary,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 idxFlagQubit, IUnitary oracleStateDeterministic, QArray<Qubit> qubits)
        {
            return __m__.Run<_StateOracleFromDeterministicStateOracle, (Int64,IUnitary,QArray<Qubit>), QVoid>((idxFlagQubit, oracleStateDeterministic, qubits));
        }
    }

    public class StateOracleFromDeterministicStateOracle : Operation<IUnitary, IUnitary>, ICallable
    {
        public StateOracleFromDeterministicStateOracle(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "StateOracleFromDeterministicStateOracle";
        String ICallable.FullName => "Microsoft.Quantum.Canon.StateOracleFromDeterministicStateOracle";
        protected IUnitary<(Int64,IUnitary,QArray<Qubit>)> _StateOracleFromDeterministicStateOracle
        {
            get;
            set;
        }

        public override Func<IUnitary, IUnitary> Body => (__in) =>
        {
            var deterministicStateOracle = __in;
#line 149 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\Utils.qs"
            return new StateOracle(_StateOracleFromDeterministicStateOracle.Partial(new Func<(Int64,QArray<Qubit>), (Int64,IUnitary,QArray<Qubit>)>((_arg1) => (_arg1.Item1, deterministicStateOracle, _arg1.Item2))));
        }

        ;
        public override void Init()
        {
            this._StateOracleFromDeterministicStateOracle = this.Factory.Get<IUnitary<(Int64,IUnitary,QArray<Qubit>)>>(typeof(Microsoft.Quantum.Canon._StateOracleFromDeterministicStateOracle));
        }

        public override IApplyData __dataIn(IUnitary data) => new QTuple<IUnitary>(data);
        public override IApplyData __dataOut(IUnitary data) => new QTuple<IUnitary>(data);
        public static System.Threading.Tasks.Task<IUnitary> Run(IOperationFactory __m__, IUnitary deterministicStateOracle)
        {
            return __m__.Run<StateOracleFromDeterministicStateOracle, IUnitary, IUnitary>(deterministicStateOracle);
        }
    }

    public class _ReflectionStart : Unitary<(Double,QArray<Qubit>)>, ICallable
    {
        public _ReflectionStart(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Double,QArray<Qubit>)>, IApplyData
        {
            public In((Double,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "_ReflectionStart";
        String ICallable.FullName => "Microsoft.Quantum.Canon._ReflectionStart";
        protected IUnitary<(Double,QArray<Qubit>)> RAll0
        {
            get;
            set;
        }

        public override Func<(Double,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (phase,qubits) = __in;
#line 156 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\Utils.qs"
            RAll0.Apply((phase, qubits));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Double,QArray<Qubit>), QVoid> AdjointBody => (__in) =>
        {
            var (phase,qubits) = __in;
            RAll0.Adjoint.Apply((phase, qubits));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Double,QArray<Qubit>)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(phase,qubits)) = __in;
            RAll0.Controlled.Apply((controlQubits, (phase, qubits)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Double,QArray<Qubit>)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,(phase,qubits)) = __in;
            RAll0.Adjoint.Controlled.Apply((controlQubits, (phase, qubits)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.RAll0 = this.Factory.Get<IUnitary<(Double,QArray<Qubit>)>>(typeof(Microsoft.Quantum.Canon.RAll0));
        }

        public override IApplyData __dataIn((Double,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Double phase, QArray<Qubit> qubits)
        {
            return __m__.Run<_ReflectionStart, (Double,QArray<Qubit>), QVoid>((phase, qubits));
        }
    }

    public class ReflectionStart : Operation<QVoid, IUnitary>, ICallable
    {
        public ReflectionStart(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ReflectionStart";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ReflectionStart";
        protected IUnitary<(Double,QArray<Qubit>)> _ReflectionStart
        {
            get;
            set;
        }

        public override Func<QVoid, IUnitary> Body => (__in) =>
        {
#line 172 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\Utils.qs"
            return new ReflectionOracle(_ReflectionStart.Partial(new Func<(Double,QArray<Qubit>), (Double,QArray<Qubit>)>((_arg1) => (_arg1.Item1, _arg1.Item2))));
        }

        ;
        public override void Init()
        {
            this._ReflectionStart = this.Factory.Get<IUnitary<(Double,QArray<Qubit>)>>(typeof(Microsoft.Quantum.Canon._ReflectionStart));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(IUnitary data) => new QTuple<IUnitary>(data);
        public static System.Threading.Tasks.Task<IUnitary> Run(IOperationFactory __m__)
        {
            return __m__.Run<ReflectionStart, QVoid, IUnitary>(QVoid.Instance);
        }
    }

    public class ReflectionOracleFromDeterministicStateOracleImpl : Unitary<(Double,IUnitary,QArray<Qubit>)>, ICallable
    {
        public ReflectionOracleFromDeterministicStateOracleImpl(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Double,IUnitary,QArray<Qubit>)>, IApplyData
        {
            public In((Double,IUnitary,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "ReflectionOracleFromDeterministicStateOracleImpl";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ReflectionOracleFromDeterministicStateOracleImpl";
        protected IUnitary<(Double,QArray<Qubit>)> RAll0
        {
            get;
            set;
        }

        protected IUnitary WithCA
        {
            get;
            set;
        }

        public override Func<(Double,IUnitary,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (phase,oracle,systemRegister) = __in;
#line 180 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\Utils.qs"
            WithCA.Apply((((IAdjointable)oracle.Adjoint), ((IUnitary)RAll0.Partial(new Func<QArray<Qubit>, (Double,QArray<Qubit>)>((_arg1) => (phase, _arg1)))), systemRegister));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Double,IUnitary,QArray<Qubit>), QVoid> AdjointBody => (__in) =>
        {
            var (phase,oracle,systemRegister) = __in;
            WithCA.Adjoint.Apply((((IAdjointable)oracle.Adjoint), ((IUnitary)RAll0.Partial(new Func<QArray<Qubit>, (Double,QArray<Qubit>)>((_arg1) => (phase, _arg1)))), systemRegister));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Double,IUnitary,QArray<Qubit>)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(phase,oracle,systemRegister)) = __in;
            WithCA.Controlled.Apply((controlQubits, (((IAdjointable)oracle.Adjoint), ((IUnitary)RAll0.Partial(new Func<QArray<Qubit>, (Double,QArray<Qubit>)>((_arg1) => (phase, _arg1)))), systemRegister)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Double,IUnitary,QArray<Qubit>)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,(phase,oracle,systemRegister)) = __in;
            WithCA.Adjoint.Controlled.Apply((controlQubits, (((IAdjointable)oracle.Adjoint), ((IUnitary)RAll0.Partial(new Func<QArray<Qubit>, (Double,QArray<Qubit>)>((_arg1) => (phase, _arg1)))), systemRegister)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.RAll0 = this.Factory.Get<IUnitary<(Double,QArray<Qubit>)>>(typeof(Microsoft.Quantum.Canon.RAll0));
            this.WithCA = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.WithCA<>));
        }

        public override IApplyData __dataIn((Double,IUnitary,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Double phase, IUnitary oracle, QArray<Qubit> systemRegister)
        {
            return __m__.Run<ReflectionOracleFromDeterministicStateOracleImpl, (Double,IUnitary,QArray<Qubit>), QVoid>((phase, oracle, systemRegister));
        }
    }

    public class ReflectionOracleFromDeterministicStateOracle : Operation<IUnitary, IUnitary>, ICallable
    {
        public ReflectionOracleFromDeterministicStateOracle(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ReflectionOracleFromDeterministicStateOracle";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ReflectionOracleFromDeterministicStateOracle";
        protected IUnitary<(Double,IUnitary,QArray<Qubit>)> ReflectionOracleFromDeterministicStateOracleImpl
        {
            get;
            set;
        }

        public override Func<IUnitary, IUnitary> Body => (__in) =>
        {
            var oracle = __in;
#line 203 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\Utils.qs"
            return new ReflectionOracle(ReflectionOracleFromDeterministicStateOracleImpl.Partial(new Func<(Double,QArray<Qubit>), (Double,IUnitary,QArray<Qubit>)>((_arg1) => (_arg1.Item1, oracle, _arg1.Item2))));
        }

        ;
        public override void Init()
        {
            this.ReflectionOracleFromDeterministicStateOracleImpl = this.Factory.Get<IUnitary<(Double,IUnitary,QArray<Qubit>)>>(typeof(Microsoft.Quantum.Canon.ReflectionOracleFromDeterministicStateOracleImpl));
        }

        public override IApplyData __dataIn(IUnitary data) => new QTuple<IUnitary>(data);
        public override IApplyData __dataOut(IUnitary data) => new QTuple<IUnitary>(data);
        public static System.Threading.Tasks.Task<IUnitary> Run(IOperationFactory __m__, IUnitary oracle)
        {
            return __m__.Run<ReflectionOracleFromDeterministicStateOracle, IUnitary, IUnitary>(oracle);
        }
    }

    public class TargetStateReflectionOracleImpl : Unitary<(Double,Int64,QArray<Qubit>)>, ICallable
    {
        public TargetStateReflectionOracleImpl(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Double,Int64,QArray<Qubit>)>, IApplyData
        {
            public In((Double,Int64,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item3)?.Qubits;
        }

        String ICallable.Name => "TargetStateReflectionOracleImpl";
        String ICallable.FullName => "Microsoft.Quantum.Canon.TargetStateReflectionOracleImpl";
        protected IUnitary<(Double,Qubit)> MicrosoftQuantumPrimitiveR1
        {
            get;
            set;
        }

        public override Func<(Double,Int64,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (phase,idxFlagQubit,qubits) = __in;
#line 211 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\Utils.qs"
            MicrosoftQuantumPrimitiveR1.Apply((phase, qubits[idxFlagQubit]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Double,Int64,QArray<Qubit>), QVoid> AdjointBody => (__in) =>
        {
            var (phase,idxFlagQubit,qubits) = __in;
            MicrosoftQuantumPrimitiveR1.Adjoint.Apply((phase, qubits[idxFlagQubit]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Double,Int64,QArray<Qubit>)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(phase,idxFlagQubit,qubits)) = __in;
            MicrosoftQuantumPrimitiveR1.Controlled.Apply((controlQubits, (phase, qubits[idxFlagQubit])));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Double,Int64,QArray<Qubit>)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,(phase,idxFlagQubit,qubits)) = __in;
            MicrosoftQuantumPrimitiveR1.Adjoint.Controlled.Apply((controlQubits, (phase, qubits[idxFlagQubit])));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveR1 = this.Factory.Get<IUnitary<(Double,Qubit)>>(typeof(Microsoft.Quantum.Primitive.R1));
        }

        public override IApplyData __dataIn((Double,Int64,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Double phase, Int64 idxFlagQubit, QArray<Qubit> qubits)
        {
            return __m__.Run<TargetStateReflectionOracleImpl, (Double,Int64,QArray<Qubit>), QVoid>((phase, idxFlagQubit, qubits));
        }
    }

    public class TargetStateReflectionOracle : Operation<Int64, IUnitary>, ICallable
    {
        public TargetStateReflectionOracle(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "TargetStateReflectionOracle";
        String ICallable.FullName => "Microsoft.Quantum.Canon.TargetStateReflectionOracle";
        protected IUnitary<(Double,Int64,QArray<Qubit>)> TargetStateReflectionOracleImpl
        {
            get;
            set;
        }

        public override Func<Int64, IUnitary> Body => (__in) =>
        {
            var idxFlagQubit = __in;
#line 234 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\Utils.qs"
            return new ReflectionOracle(TargetStateReflectionOracleImpl.Partial(new Func<(Double,QArray<Qubit>), (Double,Int64,QArray<Qubit>)>((_arg1) => (_arg1.Item1, idxFlagQubit, _arg1.Item2))));
        }

        ;
        public override void Init()
        {
            this.TargetStateReflectionOracleImpl = this.Factory.Get<IUnitary<(Double,Int64,QArray<Qubit>)>>(typeof(Microsoft.Quantum.Canon.TargetStateReflectionOracleImpl));
        }

        public override IApplyData __dataIn(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __dataOut(IUnitary data) => new QTuple<IUnitary>(data);
        public static System.Threading.Tasks.Task<IUnitary> Run(IOperationFactory __m__, Int64 idxFlagQubit)
        {
            return __m__.Run<TargetStateReflectionOracle, Int64, IUnitary>(idxFlagQubit);
        }
    }
}