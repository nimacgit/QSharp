#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "AssertProbInt (stateIndex : Int, expected : Double, qubits : Microsoft.Quantum.Canon.LittleEndian, tolerance : Double) : ()", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Asserts\\QuantumAsserts.qs", 1549L, 39L, 110L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "AssertProbIntBE (stateIndex : Int, prob : Double, qubits : Microsoft.Quantum.Canon.BigEndian, tolerance : Double) : ()", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Asserts\\QuantumAsserts.qs", 3366L, 81L, 105L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "AssertPhase (expected : Double, qubit : Qubit, tolerance : Double) : ()", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Asserts\\QuantumAsserts.qs", 4675L, 114L, 83L)]
#line hidden
namespace Microsoft.Quantum.Canon
{
    public class AssertProbInt : Operation<(Int64,Double,LittleEndian,Double), QVoid>, ICallable
    {
        public AssertProbInt(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Double,LittleEndian,Double)>, IApplyData
        {
            public In((Int64,Double,LittleEndian,Double) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item3)?.Qubits;
        }

        String ICallable.Name => "AssertProbInt";
        String ICallable.FullName => "Microsoft.Quantum.Canon.AssertProbInt";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Pauli>,QArray<Qubit>,Result,Double,String,Double)> AssertProb
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64), QArray<Boolean>> BoolArrFromPositiveInt
        {
            get;
            set;
        }

        protected ICallable ControlledOnBitString
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

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(Int64,Double,LittleEndian,Double), QVoid> Body => (__in) =>
        {
            var (stateIndex,expected,qubits,tolerance) = __in;
#line 41 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Asserts\\QuantumAsserts.qs"
            var nQubits = qubits.Count;
#line 42 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Asserts\\QuantumAsserts.qs"
            var bits = BoolArrFromPositiveInt.Apply((stateIndex, nQubits));
#line 44 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Asserts\\QuantumAsserts.qs"
            var flag = Allocate.Apply(1L);
#line 45 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Asserts\\QuantumAsserts.qs"
            ControlledOnBitString.Apply<IUnitary>((bits, ((IUnitary)MicrosoftQuantumPrimitiveX))).Apply((qubits, flag[0L]));
#line 46 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Asserts\\QuantumAsserts.qs"
            AssertProb.Apply((new QArray<Pauli>()
            {Pauli.PauliZ}, flag, Result.One, expected, $"AssertProbInt failed on stateIndex {stateIndex}, expected probability {expected}.", tolerance));
            //Uncompute flag qubit.
#line 49 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Asserts\\QuantumAsserts.qs"
            ControlledOnBitString.Apply<IUnitary>((bits, ((IUnitary)MicrosoftQuantumPrimitiveX))).Apply((qubits, flag[0L]));
#line 50 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Asserts\\QuantumAsserts.qs"
            ResetAll.Apply(flag);
#line hidden
            Release.Apply(flag);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.AssertProb = this.Factory.Get<IUnitary<(QArray<Pauli>,QArray<Qubit>,Result,Double,String,Double)>>(typeof(Microsoft.Quantum.Primitive.AssertProb));
            this.BoolArrFromPositiveInt = this.Factory.Get<ICallable<(Int64,Int64), QArray<Boolean>>>(typeof(Microsoft.Quantum.Canon.BoolArrFromPositiveInt));
            this.ControlledOnBitString = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ControlledOnBitString<>));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((Int64,Double,LittleEndian,Double) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 stateIndex, Double expected, LittleEndian qubits, Double tolerance)
        {
            return __m__.Run<AssertProbInt, (Int64,Double,LittleEndian,Double), QVoid>((stateIndex, expected, qubits, tolerance));
        }
    }

    public class AssertProbIntBE : Operation<(Int64,Double,BigEndian,Double), QVoid>, ICallable
    {
        public AssertProbIntBE(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Double,BigEndian,Double)>, IApplyData
        {
            public In((Int64,Double,BigEndian,Double) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item3)?.Qubits;
        }

        String ICallable.Name => "AssertProbIntBE";
        String ICallable.FullName => "Microsoft.Quantum.Canon.AssertProbIntBE";
        protected ICallable<(Int64,Double,LittleEndian,Double), QVoid> AssertProbInt
        {
            get;
            set;
        }

        protected ICallable Reverse
        {
            get;
            set;
        }

        public override Func<(Int64,Double,BigEndian,Double), QVoid> Body => (__in) =>
        {
            var (stateIndex,prob,qubits,tolerance) = __in;
#line 83 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Asserts\\QuantumAsserts.qs"
            var qubitsLE = new LittleEndian(Reverse.Apply<QArray<Qubit>>(qubits));
#line 84 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Asserts\\QuantumAsserts.qs"
            AssertProbInt.Apply((stateIndex, prob, qubitsLE, tolerance));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.AssertProbInt = this.Factory.Get<ICallable<(Int64,Double,LittleEndian,Double), QVoid>>(typeof(Microsoft.Quantum.Canon.AssertProbInt));
            this.Reverse = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Reverse<>));
        }

        public override IApplyData __dataIn((Int64,Double,BigEndian,Double) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 stateIndex, Double prob, BigEndian qubits, Double tolerance)
        {
            return __m__.Run<AssertProbIntBE, (Int64,Double,BigEndian,Double), QVoid>((stateIndex, prob, qubits, tolerance));
        }
    }

    public class AssertPhase : Operation<(Double,Qubit,Double), QVoid>, ICallable
    {
        public AssertPhase(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Double,Qubit,Double)>, IApplyData
        {
            public In((Double,Qubit,Double) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item2;
                }
            }
        }

        String ICallable.Name => "AssertPhase";
        String ICallable.FullName => "Microsoft.Quantum.Canon.AssertPhase";
        protected IUnitary<(QArray<Pauli>,QArray<Qubit>,Result,Double,String,Double)> AssertProb
        {
            get;
            set;
        }

        protected ICallable<Double, Double> MicrosoftQuantumExtensionsMathCos
        {
            get;
            set;
        }

        protected ICallable<QVoid, Double> MicrosoftQuantumExtensionsMathPI
        {
            get;
            set;
        }

        protected ICallable<Double, Double> MicrosoftQuantumExtensionsMathSin
        {
            get;
            set;
        }

        public override Func<(Double,Qubit,Double), QVoid> Body => (__in) =>
        {
            var (expected,qubit,tolerance) = __in;
#line 116 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Asserts\\QuantumAsserts.qs"
            var exptectedProbX = (MicrosoftQuantumExtensionsMathCos.Apply(expected) * MicrosoftQuantumExtensionsMathCos.Apply(expected));
#line 117 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Asserts\\QuantumAsserts.qs"
            var exptectedProbY = (MicrosoftQuantumExtensionsMathSin.Apply(((-(1D) * expected) + (MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance) / 4D))) * MicrosoftQuantumExtensionsMathSin.Apply(((-(1D) * expected) + (MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance) / 4D))));
#line 118 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Asserts\\QuantumAsserts.qs"
            AssertProb.Apply((new QArray<Pauli>()
            {Pauli.PauliZ}, new QArray<Qubit>()
            {qubit}, Result.Zero, 0.5D, $"AssertPhase failed. Was not given a uniform superposition.", tolerance));
#line 119 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Asserts\\QuantumAsserts.qs"
            AssertProb.Apply((new QArray<Pauli>()
            {Pauli.PauliY}, new QArray<Qubit>()
            {qubit}, Result.Zero, exptectedProbY, $"AssertPhase failed. PauliY Zero basis did not give probability {exptectedProbY}.", tolerance));
#line 120 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Asserts\\QuantumAsserts.qs"
            AssertProb.Apply((new QArray<Pauli>()
            {Pauli.PauliX}, new QArray<Qubit>()
            {qubit}, Result.Zero, exptectedProbX, $"AssertPhase failed. PauliX Zero basis did not give probability {exptectedProbX}.", tolerance));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.AssertProb = this.Factory.Get<IUnitary<(QArray<Pauli>,QArray<Qubit>,Result,Double,String,Double)>>(typeof(Microsoft.Quantum.Primitive.AssertProb));
            this.MicrosoftQuantumExtensionsMathCos = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Extensions.Math.Cos));
            this.MicrosoftQuantumExtensionsMathPI = this.Factory.Get<ICallable<QVoid, Double>>(typeof(Microsoft.Quantum.Extensions.Math.PI));
            this.MicrosoftQuantumExtensionsMathSin = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Extensions.Math.Sin));
        }

        public override IApplyData __dataIn((Double,Qubit,Double) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Double expected, Qubit qubit, Double tolerance)
        {
            return __m__.Run<AssertPhase, (Double,Qubit,Double), QVoid>((expected, qubit, tolerance));
        }
    }
}