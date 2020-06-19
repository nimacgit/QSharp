#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "DiscretePhaseEstimationIteration (oracle : Microsoft.Quantum.Canon.DiscreteOracle, power : Int, theta : Double, targetState : Qubit[], controlQubit : Qubit) : ()", new string[] { "Controlled", "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\PhaseEstimation\\Iterative.qs", 2373L, 48L, 5L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "ContinuousPhaseEstimationIteration (oracle : Microsoft.Quantum.Canon.ContinuousOracle, time : Double, theta : Double, targetState : Qubit[], controlQubit : Qubit) : ()", new string[] { "Controlled", "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\PhaseEstimation\\Iterative.qs", 4168L, 90L, 5L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "PrepAndMeasurePhaseEstImpl (wInv : Double, t : Double, op : ((Double, Double, Qubit) => ())) : Result", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\PhaseEstimation\\Iterative.qs", 4761L, 109L, 116L)]
#line hidden
namespace Microsoft.Quantum.Canon
{
    public class DiscretePhaseEstimationIteration : Unitary<(IUnitary,Int64,Double,QArray<Qubit>,Qubit)>, ICallable
    {
        public DiscretePhaseEstimationIteration(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IUnitary,Int64,Double,QArray<Qubit>,Qubit)>, IApplyData
        {
            public In((IUnitary,Int64,Double,QArray<Qubit>,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item4)?.Qubits, ((IApplyData)Data.Item5)?.Qubits);
        }

        String ICallable.Name => "DiscretePhaseEstimationIteration";
        String ICallable.FullName => "Microsoft.Quantum.Canon.DiscretePhaseEstimationIteration";
        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get;
            set;
        }

        protected IUnitary<(Double,Qubit)> MicrosoftQuantumPrimitiveRz
        {
            get;
            set;
        }

        protected ICallable<Int64, Double> MicrosoftQuantumExtensionsConvertToDouble
        {
            get;
            set;
        }

        public override Func<(IUnitary,Int64,Double,QArray<Qubit>,Qubit), QVoid> Body => (__in) =>
        {
            var (oracle,power,theta,targetState,controlQubit) = __in;
            // Find the actual inversion angle by rescaling with the power of the
            // oracle.
#line 55 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\PhaseEstimation\\Iterative.qs"
            var inversionAngle = (-(theta) * MicrosoftQuantumExtensionsConvertToDouble.Apply(power));
            // Prepare the control qubit.
#line 58 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\PhaseEstimation\\Iterative.qs"
            MicrosoftQuantumPrimitiveH.Apply(controlQubit);
#line 59 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\PhaseEstimation\\Iterative.qs"
            MicrosoftQuantumPrimitiveRz.Apply((inversionAngle, controlQubit));
#line 61 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\PhaseEstimation\\Iterative.qs"
            oracle.Controlled.Apply((new QArray<Qubit>()
            {controlQubit}, (power, targetState)));
            // Return the control qubit to the appropriate measurement basis.
#line 64 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\PhaseEstimation\\Iterative.qs"
            MicrosoftQuantumPrimitiveH.Apply(controlQubit);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IUnitary,Int64,Double,QArray<Qubit>,Qubit), QVoid> AdjointBody => (__in) =>
        {
            var (oracle,power,theta,targetState,controlQubit) = __in;
            // Find the actual inversion angle by rescaling with the power of the
            // oracle.
#line 55 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\PhaseEstimation\\Iterative.qs"
            var inversionAngle = (-(theta) * MicrosoftQuantumExtensionsConvertToDouble.Apply(power));
            // Prepare the control qubit.
            // Return the control qubit to the appropriate measurement basis.
            MicrosoftQuantumPrimitiveH.Adjoint.Apply(controlQubit);
            oracle.Controlled.Adjoint.Apply((new QArray<Qubit>()
            {controlQubit}, (power, targetState)));
            MicrosoftQuantumPrimitiveRz.Adjoint.Apply((inversionAngle, controlQubit));
            MicrosoftQuantumPrimitiveH.Adjoint.Apply(controlQubit);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(IUnitary,Int64,Double,QArray<Qubit>,Qubit)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(oracle,power,theta,targetState,controlQubit)) = __in;
            // Find the actual inversion angle by rescaling with the power of the
            // oracle.
            var inversionAngle = (-(theta) * MicrosoftQuantumExtensionsConvertToDouble.Apply(power));
            // Prepare the control qubit.
            MicrosoftQuantumPrimitiveH.Controlled.Apply((controlQubits, controlQubit));
            MicrosoftQuantumPrimitiveRz.Controlled.Apply((controlQubits, (inversionAngle, controlQubit)));
            oracle.Controlled.Controlled.Apply((controlQubits, (new QArray<Qubit>()
            {controlQubit}, (power, targetState))));
            // Return the control qubit to the appropriate measurement basis.
            MicrosoftQuantumPrimitiveH.Controlled.Apply((controlQubits, controlQubit));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(IUnitary,Int64,Double,QArray<Qubit>,Qubit)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,(oracle,power,theta,targetState,controlQubit)) = __in;
            // Find the actual inversion angle by rescaling with the power of the
            // oracle.
            var inversionAngle = (-(theta) * MicrosoftQuantumExtensionsConvertToDouble.Apply(power));
            // Prepare the control qubit.
            // Return the control qubit to the appropriate measurement basis.
            MicrosoftQuantumPrimitiveH.Adjoint.Controlled.Apply((controlQubits, controlQubit));
            oracle.Controlled.Adjoint.Controlled.Apply((controlQubits, (new QArray<Qubit>()
            {controlQubit}, (power, targetState))));
            MicrosoftQuantumPrimitiveRz.Adjoint.Controlled.Apply((controlQubits, (inversionAngle, controlQubit)));
            MicrosoftQuantumPrimitiveH.Adjoint.Controlled.Apply((controlQubits, controlQubit));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.MicrosoftQuantumPrimitiveRz = this.Factory.Get<IUnitary<(Double,Qubit)>>(typeof(Microsoft.Quantum.Primitive.Rz));
            this.MicrosoftQuantumExtensionsConvertToDouble = this.Factory.Get<ICallable<Int64, Double>>(typeof(Microsoft.Quantum.Extensions.Convert.ToDouble));
        }

        public override IApplyData __dataIn((IUnitary,Int64,Double,QArray<Qubit>,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IUnitary oracle, Int64 power, Double theta, QArray<Qubit> targetState, Qubit controlQubit)
        {
            return __m__.Run<DiscretePhaseEstimationIteration, (IUnitary,Int64,Double,QArray<Qubit>,Qubit), QVoid>((oracle, power, theta, targetState, controlQubit));
        }
    }

    public class ContinuousPhaseEstimationIteration : Unitary<(IUnitary,Double,Double,QArray<Qubit>,Qubit)>, ICallable
    {
        public ContinuousPhaseEstimationIteration(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IUnitary,Double,Double,QArray<Qubit>,Qubit)>, IApplyData
        {
            public In((IUnitary,Double,Double,QArray<Qubit>,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item4)?.Qubits, ((IApplyData)Data.Item5)?.Qubits);
        }

        String ICallable.Name => "ContinuousPhaseEstimationIteration";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ContinuousPhaseEstimationIteration";
        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get;
            set;
        }

        protected IUnitary<(Double,Qubit)> MicrosoftQuantumPrimitiveRz
        {
            get;
            set;
        }

        public override Func<(IUnitary,Double,Double,QArray<Qubit>,Qubit), QVoid> Body => (__in) =>
        {
            var (oracle,time,theta,targetState,controlQubit) = __in;
#line 92 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\PhaseEstimation\\Iterative.qs"
            var inversionAngle = -((theta * time));
            // Prepare the control qubit.
#line 95 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\PhaseEstimation\\Iterative.qs"
            MicrosoftQuantumPrimitiveH.Apply(controlQubit);
#line 96 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\PhaseEstimation\\Iterative.qs"
            MicrosoftQuantumPrimitiveRz.Apply((inversionAngle, controlQubit));
#line 98 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\PhaseEstimation\\Iterative.qs"
            oracle.Controlled.Apply((new QArray<Qubit>()
            {controlQubit}, (time, targetState)));
            // Return the control qubit to the appropriate measurement basis.
#line 101 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\PhaseEstimation\\Iterative.qs"
            MicrosoftQuantumPrimitiveH.Apply(controlQubit);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IUnitary,Double,Double,QArray<Qubit>,Qubit), QVoid> AdjointBody => (__in) =>
        {
            var (oracle,time,theta,targetState,controlQubit) = __in;
#line 92 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\PhaseEstimation\\Iterative.qs"
            var inversionAngle = -((theta * time));
            // Prepare the control qubit.
            // Return the control qubit to the appropriate measurement basis.
            MicrosoftQuantumPrimitiveH.Adjoint.Apply(controlQubit);
            oracle.Controlled.Adjoint.Apply((new QArray<Qubit>()
            {controlQubit}, (time, targetState)));
            MicrosoftQuantumPrimitiveRz.Adjoint.Apply((inversionAngle, controlQubit));
            MicrosoftQuantumPrimitiveH.Adjoint.Apply(controlQubit);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(IUnitary,Double,Double,QArray<Qubit>,Qubit)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(oracle,time,theta,targetState,controlQubit)) = __in;
            var inversionAngle = -((theta * time));
            // Prepare the control qubit.
            MicrosoftQuantumPrimitiveH.Controlled.Apply((controlQubits, controlQubit));
            MicrosoftQuantumPrimitiveRz.Controlled.Apply((controlQubits, (inversionAngle, controlQubit)));
            oracle.Controlled.Controlled.Apply((controlQubits, (new QArray<Qubit>()
            {controlQubit}, (time, targetState))));
            // Return the control qubit to the appropriate measurement basis.
            MicrosoftQuantumPrimitiveH.Controlled.Apply((controlQubits, controlQubit));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(IUnitary,Double,Double,QArray<Qubit>,Qubit)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,(oracle,time,theta,targetState,controlQubit)) = __in;
            var inversionAngle = -((theta * time));
            // Prepare the control qubit.
            // Return the control qubit to the appropriate measurement basis.
            MicrosoftQuantumPrimitiveH.Adjoint.Controlled.Apply((controlQubits, controlQubit));
            oracle.Controlled.Adjoint.Controlled.Apply((controlQubits, (new QArray<Qubit>()
            {controlQubit}, (time, targetState))));
            MicrosoftQuantumPrimitiveRz.Adjoint.Controlled.Apply((controlQubits, (inversionAngle, controlQubit)));
            MicrosoftQuantumPrimitiveH.Adjoint.Controlled.Apply((controlQubits, controlQubit));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.MicrosoftQuantumPrimitiveRz = this.Factory.Get<IUnitary<(Double,Qubit)>>(typeof(Microsoft.Quantum.Primitive.Rz));
        }

        public override IApplyData __dataIn((IUnitary,Double,Double,QArray<Qubit>,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IUnitary oracle, Double time, Double theta, QArray<Qubit> targetState, Qubit controlQubit)
        {
            return __m__.Run<ContinuousPhaseEstimationIteration, (IUnitary,Double,Double,QArray<Qubit>,Qubit), QVoid>((oracle, time, theta, targetState, controlQubit));
        }
    }

    public class PrepAndMeasurePhaseEstImpl : Operation<(Double,Double,ICallable), Result>, ICallable
    {
        public PrepAndMeasurePhaseEstImpl(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Double,Double,ICallable)>, IApplyData
        {
            public In((Double,Double,ICallable) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item3)?.Qubits;
        }

        String ICallable.Name => "PrepAndMeasurePhaseEstImpl";
        String ICallable.FullName => "Microsoft.Quantum.Canon.PrepAndMeasurePhaseEstImpl";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> MResetZ
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        public override Func<(Double,Double,ICallable), Result> Body => (__in) =>
        {
            var (wInv,t,op) = __in;
#line 111 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\PhaseEstimation\\Iterative.qs"
            var datum = Result.Zero;
#line 112 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\PhaseEstimation\\Iterative.qs"
            var register = Allocate.Apply(1L);
#line 113 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\PhaseEstimation\\Iterative.qs"
            op.Apply((t, wInv, register[0L]));
#line 114 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\PhaseEstimation\\Iterative.qs"
            datum = MResetZ.Apply(register[0L]);
#line hidden
            Release.Apply(register);
#line 116 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\PhaseEstimation\\Iterative.qs"
            return datum;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MResetZ = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Canon.MResetZ));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
        }

        public override IApplyData __dataIn((Double,Double,ICallable) data) => new In(data);
        public override IApplyData __dataOut(Result data) => new QTuple<Result>(data);
        public static System.Threading.Tasks.Task<Result> Run(IOperationFactory __m__, Double wInv, Double t, ICallable op)
        {
            return __m__.Run<PrepAndMeasurePhaseEstImpl, (Double,Double,ICallable), Result>((wInv, t, op));
        }
    }
}