#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "QuantumPhaseEstimation (oracle : Microsoft.Quantum.Canon.DiscreteOracle, targetState : Qubit[], controlRegister : Microsoft.Quantum.Canon.BigEndian) : ()", new string[] { "Controlled", "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\PhaseEstimation\\Quantum.qs", 1305L, 29L, 5L)]
#line hidden
namespace Microsoft.Quantum.Canon
{
    public class QuantumPhaseEstimation : Unitary<(IUnitary,QArray<Qubit>,BigEndian)>, ICallable
    {
        public QuantumPhaseEstimation(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IUnitary,QArray<Qubit>,BigEndian)>, IApplyData
        {
            public In((IUnitary,QArray<Qubit>,BigEndian) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "QuantumPhaseEstimation";
        String ICallable.FullName => "Microsoft.Quantum.Canon.QuantumPhaseEstimation";
        protected IUnitary ApplyToEachCA
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Qubit>,Double)> MicrosoftQuantumExtensionsTestingAssertAllZeroTol
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get;
            set;
        }

        protected IUnitary<BigEndian> QFT
        {
            get;
            set;
        }

        public override Func<(IUnitary,QArray<Qubit>,BigEndian), QVoid> Body => (__in) =>
        {
            var (oracle,targetState,controlRegister) = __in;
#line 31 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\PhaseEstimation\\Quantum.qs"
            var nQubits = controlRegister.Count;
#line 33 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\PhaseEstimation\\Quantum.qs"
            MicrosoftQuantumExtensionsTestingAssertAllZeroTol.Apply((controlRegister, 1E-10D));
#line 35 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\PhaseEstimation\\Quantum.qs"
            ApplyToEachCA.Apply((((IUnitary)MicrosoftQuantumPrimitiveH), controlRegister));
#line 37 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\PhaseEstimation\\Quantum.qs"
            foreach (var idxControlQubit in new Range(0L, (nQubits - 1L)))
            {
#line 38 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\PhaseEstimation\\Quantum.qs"
                var control = controlRegister[idxControlQubit];
#line 39 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\PhaseEstimation\\Quantum.qs"
                var power = 2L.Pow(((nQubits - idxControlQubit) - 1L));
#line 40 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\PhaseEstimation\\Quantum.qs"
                oracle.Controlled.Apply((new QArray<Qubit>()
                {control}, (power, targetState)));
            }

#line 43 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\PhaseEstimation\\Quantum.qs"
            QFT.Adjoint.Apply(controlRegister);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IUnitary,QArray<Qubit>,BigEndian), QVoid> AdjointBody => (__in) =>
        {
            var (oracle,targetState,controlRegister) = __in;
#line 31 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\PhaseEstimation\\Quantum.qs"
            var nQubits = controlRegister.Count;
            QFT.Adjoint.Adjoint.Apply(controlRegister);
            foreach (var idxControlQubit in new Range((0L - ((((nQubits - 1L) - 0L) / 1L) * -(1L))), -(1L), 0L))
            {
#line 38 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\PhaseEstimation\\Quantum.qs"
                var control = controlRegister[idxControlQubit];
#line 39 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\PhaseEstimation\\Quantum.qs"
                var power = 2L.Pow(((nQubits - idxControlQubit) - 1L));
                oracle.Controlled.Adjoint.Apply((new QArray<Qubit>()
                {control}, (power, targetState)));
            }

            ApplyToEachCA.Adjoint.Apply((((IUnitary)MicrosoftQuantumPrimitiveH), controlRegister));
            MicrosoftQuantumExtensionsTestingAssertAllZeroTol.Adjoint.Apply((controlRegister, 1E-10D));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(IUnitary,QArray<Qubit>,BigEndian)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(oracle,targetState,controlRegister)) = __in;
            var nQubits = controlRegister.Count;
            MicrosoftQuantumExtensionsTestingAssertAllZeroTol.Controlled.Apply((controlQubits, (controlRegister, 1E-10D)));
            ApplyToEachCA.Controlled.Apply((controlQubits, (((IUnitary)MicrosoftQuantumPrimitiveH), controlRegister)));
            foreach (var idxControlQubit in new Range(0L, (nQubits - 1L)))
            {
                var control = controlRegister[idxControlQubit];
                var power = 2L.Pow(((nQubits - idxControlQubit) - 1L));
                oracle.Controlled.Controlled.Apply((controlQubits, (new QArray<Qubit>()
                {control}, (power, targetState))));
            }

            QFT.Adjoint.Controlled.Apply((controlQubits, controlRegister));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(IUnitary,QArray<Qubit>,BigEndian)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,(oracle,targetState,controlRegister)) = __in;
            var nQubits = controlRegister.Count;
            QFT.Adjoint.Adjoint.Controlled.Apply((controlQubits, controlRegister));
            foreach (var idxControlQubit in new Range((0L - ((((nQubits - 1L) - 0L) / 1L) * -(1L))), -(1L), 0L))
            {
                var control = controlRegister[idxControlQubit];
                var power = 2L.Pow(((nQubits - idxControlQubit) - 1L));
                oracle.Controlled.Adjoint.Controlled.Apply((controlQubits, (new QArray<Qubit>()
                {control}, (power, targetState))));
            }

            ApplyToEachCA.Adjoint.Controlled.Apply((controlQubits, (((IUnitary)MicrosoftQuantumPrimitiveH), controlRegister)));
            MicrosoftQuantumExtensionsTestingAssertAllZeroTol.Adjoint.Controlled.Apply((controlQubits, (controlRegister, 1E-10D)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.ApplyToEachCA = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.ApplyToEachCA<>));
            this.MicrosoftQuantumExtensionsTestingAssertAllZeroTol = this.Factory.Get<IUnitary<(QArray<Qubit>,Double)>>(typeof(Microsoft.Quantum.Extensions.Testing.AssertAllZeroTol));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.QFT = this.Factory.Get<IUnitary<BigEndian>>(typeof(Microsoft.Quantum.Canon.QFT));
        }

        public override IApplyData __dataIn((IUnitary,QArray<Qubit>,BigEndian) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IUnitary oracle, QArray<Qubit> targetState, BigEndian controlRegister)
        {
            return __m__.Run<QuantumPhaseEstimation, (IUnitary,QArray<Qubit>,BigEndian), QVoid>((oracle, targetState, controlRegister));
        }
    }
}