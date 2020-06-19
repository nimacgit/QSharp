#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "PrepareArbitraryState (coefficients : Microsoft.Quantum.Canon.ComplexPolar[], qubits : Microsoft.Quantum.Canon.BigEndian) : ()", new string[] { "Controlled", "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\StatePreparation\\StatePreparation.qs", 5691L, 134L, 5L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "PrepareArbitraryState_ (coefficients : Microsoft.Quantum.Canon.ComplexPolar[], control : Microsoft.Quantum.Canon.BigEndian, target : Qubit) : ()", new string[] { "Controlled", "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\StatePreparation\\StatePreparation.qs", 6751L, 166L, 5L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "StatePreparationPositiveCoefficients (coefficients : Double[]) : (Microsoft.Quantum.Canon.BigEndian => () : Adjoint, Controlled)", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\StatePreparation\\StatePreparation.qs", 1872L, 47L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "StatePreparationComplexCoefficients (coefficients : Microsoft.Quantum.Canon.ComplexPolar[]) : (Microsoft.Quantum.Canon.BigEndian => () : Adjoint, Controlled)", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\StatePreparation\\StatePreparation.qs", 4125L, 99L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "BlochSphereCoordinates (a0 : Microsoft.Quantum.Canon.ComplexPolar, a1 : Microsoft.Quantum.Canon.ComplexPolar) : (Microsoft.Quantum.Canon.ComplexPolar, Double, Double)", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\StatePreparation\\StatePreparation.qs", 8333L, 206L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "StatePreparationSBMComputeCoefficients_ (coefficients : Microsoft.Quantum.Canon.ComplexPolar[]) : (Double[], Double[], Microsoft.Quantum.Canon.ComplexPolar[])", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\StatePreparation\\StatePreparation.qs", 9005L, 224L, 14L)]
#line hidden
namespace Microsoft.Quantum.Canon
{
    public class StatePreparationPositiveCoefficients : Operation<QArray<Double>, IUnitary>, ICallable
    {
        public StatePreparationPositiveCoefficients(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "StatePreparationPositiveCoefficients";
        String ICallable.FullName => "Microsoft.Quantum.Canon.StatePreparationPositiveCoefficients";
        protected ICallable<Double, Double> MicrosoftQuantumExtensionsMathAbsD
        {
            get;
            set;
        }

        protected IUnitary<(QArray<ComplexPolar>,BigEndian)> PrepareArbitraryState
        {
            get;
            set;
        }

        public override Func<QArray<Double>, IUnitary> Body => (__in) =>
        {
            var coefficients = __in;
#line 49 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\StatePreparation\\StatePreparation.qs"
            var nCoefficients = coefficients.Count;
#line 50 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\StatePreparation\\StatePreparation.qs"
            var coefficientsComplexPolar = new QArray<ComplexPolar>(nCoefficients);
#line 51 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\StatePreparation\\StatePreparation.qs"
            foreach (var idx in new Range(0L, (nCoefficients - 1L)))
            {
#line 52 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\StatePreparation\\StatePreparation.qs"
                coefficientsComplexPolar[idx] = new ComplexPolar((MicrosoftQuantumExtensionsMathAbsD.Apply(coefficients[idx]), 0D));
            }

#line 55 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\StatePreparation\\StatePreparation.qs"
            return PrepareArbitraryState.Partial(new Func<BigEndian, (QArray<ComplexPolar>,BigEndian)>((_arg1) => (coefficientsComplexPolar, _arg1)));
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumExtensionsMathAbsD = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Extensions.Math.AbsD));
            this.PrepareArbitraryState = this.Factory.Get<IUnitary<(QArray<ComplexPolar>,BigEndian)>>(typeof(Microsoft.Quantum.Canon.PrepareArbitraryState));
        }

        public override IApplyData __dataIn(QArray<Double> data) => data;
        public override IApplyData __dataOut(IUnitary data) => new QTuple<IUnitary>(data);
        public static System.Threading.Tasks.Task<IUnitary> Run(IOperationFactory __m__, QArray<Double> coefficients)
        {
            return __m__.Run<StatePreparationPositiveCoefficients, QArray<Double>, IUnitary>(coefficients);
        }
    }

    public class StatePreparationComplexCoefficients : Operation<QArray<ComplexPolar>, IUnitary>, ICallable
    {
        public StatePreparationComplexCoefficients(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "StatePreparationComplexCoefficients";
        String ICallable.FullName => "Microsoft.Quantum.Canon.StatePreparationComplexCoefficients";
        protected IUnitary<(QArray<ComplexPolar>,BigEndian)> PrepareArbitraryState
        {
            get;
            set;
        }

        public override Func<QArray<ComplexPolar>, IUnitary> Body => (__in) =>
        {
            var coefficients = __in;
#line 101 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\StatePreparation\\StatePreparation.qs"
            return PrepareArbitraryState.Partial(new Func<BigEndian, (QArray<ComplexPolar>,BigEndian)>((_arg1) => (coefficients, _arg1)));
        }

        ;
        public override void Init()
        {
            this.PrepareArbitraryState = this.Factory.Get<IUnitary<(QArray<ComplexPolar>,BigEndian)>>(typeof(Microsoft.Quantum.Canon.PrepareArbitraryState));
        }

        public override IApplyData __dataIn(QArray<ComplexPolar> data) => data;
        public override IApplyData __dataOut(IUnitary data) => new QTuple<IUnitary>(data);
        public static System.Threading.Tasks.Task<IUnitary> Run(IOperationFactory __m__, QArray<ComplexPolar> coefficients)
        {
            return __m__.Run<StatePreparationComplexCoefficients, QArray<ComplexPolar>, IUnitary>(coefficients);
        }
    }

    public class PrepareArbitraryState : Unitary<(QArray<ComplexPolar>,BigEndian)>, ICallable
    {
        public PrepareArbitraryState(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<ComplexPolar>,BigEndian)>, IApplyData
        {
            public In((QArray<ComplexPolar>,BigEndian) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "PrepareArbitraryState";
        String ICallable.FullName => "Microsoft.Quantum.Canon.PrepareArbitraryState";
        protected ICallable Pad
        {
            get;
            set;
        }

        protected IUnitary<(QArray<ComplexPolar>,BigEndian,Qubit)> PrepareArbitraryState_
        {
            get;
            set;
        }

        public override Func<(QArray<ComplexPolar>,BigEndian), QVoid> Body => (__in) =>
        {
            var (coefficients,qubits) = __in;
            // pad coefficients at tail length to a power of 2.
#line 138 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\StatePreparation\\StatePreparation.qs"
            var coefficientsPadded = Pad.Apply<QArray<ComplexPolar>>((-(2L).Pow(qubits.Count), new ComplexPolar((0D, 0D)), coefficients));
#line 140 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\StatePreparation\\StatePreparation.qs"
            var target = qubits[(qubits.Count - 1L)];
#line 142 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\StatePreparation\\StatePreparation.qs"
            var op = PrepareArbitraryState_.Partial(new Func<(BigEndian,Qubit), (QArray<ComplexPolar>,BigEndian,Qubit)>((_arg1) => (coefficientsPadded, _arg1.Item1, _arg1.Item2))).Adjoint.Partial(new Func<BigEndian, (BigEndian,Qubit)>((_arg2) => (_arg2, target)));
#line 144 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\StatePreparation\\StatePreparation.qs"
            if ((qubits.Count > 1L))
            {
#line 145 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\StatePreparation\\StatePreparation.qs"
                var control = new BigEndian(qubits?.Slice(new Range(0L, (qubits.Count - 2L))));
#line 146 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\StatePreparation\\StatePreparation.qs"
                op.Apply(control);
            }
            else
            {
#line 149 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\StatePreparation\\StatePreparation.qs"
                var control = new BigEndian(new QArray<Qubit>(0L));
#line 150 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\StatePreparation\\StatePreparation.qs"
                op.Apply(control);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<ComplexPolar>,BigEndian), QVoid> AdjointBody => (__in) =>
        {
            var (coefficients,qubits) = __in;
            // pad coefficients at tail length to a power of 2.
#line 138 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\StatePreparation\\StatePreparation.qs"
            var coefficientsPadded = Pad.Apply<QArray<ComplexPolar>>((-(2L).Pow(qubits.Count), new ComplexPolar((0D, 0D)), coefficients));
#line 140 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\StatePreparation\\StatePreparation.qs"
            var target = qubits[(qubits.Count - 1L)];
#line 142 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\StatePreparation\\StatePreparation.qs"
            var op = PrepareArbitraryState_.Partial(new Func<(BigEndian,Qubit), (QArray<ComplexPolar>,BigEndian,Qubit)>((_arg1) => (coefficientsPadded, _arg1.Item1, _arg1.Item2))).Adjoint.Partial(new Func<BigEndian, (BigEndian,Qubit)>((_arg2) => (_arg2, target)));
            if ((qubits.Count > 1L))
            {
#line 145 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\StatePreparation\\StatePreparation.qs"
                var control = new BigEndian(qubits?.Slice(new Range(0L, (qubits.Count - 2L))));
                op.Adjoint.Apply(control);
            }
            else
            {
#line 149 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\StatePreparation\\StatePreparation.qs"
                var control = new BigEndian(new QArray<Qubit>(0L));
                op.Adjoint.Apply(control);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<ComplexPolar>,BigEndian)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(coefficients,qubits)) = __in;
            // pad coefficients at tail length to a power of 2.
            var coefficientsPadded = Pad.Apply<QArray<ComplexPolar>>((-(2L).Pow(qubits.Count), new ComplexPolar((0D, 0D)), coefficients));
            var target = qubits[(qubits.Count - 1L)];
            var op = PrepareArbitraryState_.Partial(new Func<(BigEndian,Qubit), (QArray<ComplexPolar>,BigEndian,Qubit)>((_arg1) => (coefficientsPadded, _arg1.Item1, _arg1.Item2))).Adjoint.Partial(new Func<BigEndian, (BigEndian,Qubit)>((_arg2) => (_arg2, target)));
            if ((qubits.Count > 1L))
            {
                var control = new BigEndian(qubits?.Slice(new Range(0L, (qubits.Count - 2L))));
                op.Controlled.Apply((controlQubits, control));
            }
            else
            {
                var control = new BigEndian(new QArray<Qubit>(0L));
                op.Controlled.Apply((controlQubits, control));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<ComplexPolar>,BigEndian)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,(coefficients,qubits)) = __in;
            // pad coefficients at tail length to a power of 2.
            var coefficientsPadded = Pad.Apply<QArray<ComplexPolar>>((-(2L).Pow(qubits.Count), new ComplexPolar((0D, 0D)), coefficients));
            var target = qubits[(qubits.Count - 1L)];
            var op = PrepareArbitraryState_.Partial(new Func<(BigEndian,Qubit), (QArray<ComplexPolar>,BigEndian,Qubit)>((_arg1) => (coefficientsPadded, _arg1.Item1, _arg1.Item2))).Adjoint.Partial(new Func<BigEndian, (BigEndian,Qubit)>((_arg2) => (_arg2, target)));
            if ((qubits.Count > 1L))
            {
                var control = new BigEndian(qubits?.Slice(new Range(0L, (qubits.Count - 2L))));
                op.Adjoint.Controlled.Apply((controlQubits, control));
            }
            else
            {
                var control = new BigEndian(new QArray<Qubit>(0L));
                op.Adjoint.Controlled.Apply((controlQubits, control));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Pad = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Pad<>));
            this.PrepareArbitraryState_ = this.Factory.Get<IUnitary<(QArray<ComplexPolar>,BigEndian,Qubit)>>(typeof(Microsoft.Quantum.Canon.PrepareArbitraryState_));
        }

        public override IApplyData __dataIn((QArray<ComplexPolar>,BigEndian) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<ComplexPolar> coefficients, BigEndian qubits)
        {
            return __m__.Run<PrepareArbitraryState, (QArray<ComplexPolar>,BigEndian), QVoid>((coefficients, qubits));
        }
    }

    public class PrepareArbitraryState_ : Unitary<(QArray<ComplexPolar>,BigEndian,Qubit)>, ICallable
    {
        public PrepareArbitraryState_(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<ComplexPolar>,BigEndian,Qubit)>, IApplyData
        {
            public In((QArray<ComplexPolar>,BigEndian,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "PrepareArbitraryState_";
        String ICallable.FullName => "Microsoft.Quantum.Canon.PrepareArbitraryState_";
        protected IUnitary<(QArray<Pauli>,Double,QArray<Qubit>)> MicrosoftQuantumPrimitiveExp
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Double>,Pauli,BigEndian,Qubit)> MultiplexPauli
        {
            get;
            set;
        }

        protected ICallable<QArray<ComplexPolar>, (QArray<Double>,QArray<Double>,QArray<ComplexPolar>)> StatePreparationSBMComputeCoefficients_
        {
            get;
            set;
        }

        public override Func<(QArray<ComplexPolar>,BigEndian,Qubit), QVoid> Body => (__in) =>
        {
            var (coefficients,control,target) = __in;
            // For each 2D block, compute disentangling single-qubit rotation parameters
#line 170 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\StatePreparation\\StatePreparation.qs"
            var (disentanglingY,disentanglingZ,newCoefficients) = StatePreparationSBMComputeCoefficients_.Apply(coefficients);
#line 172 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\StatePreparation\\StatePreparation.qs"
            MultiplexPauli.Apply((disentanglingZ, Pauli.PauliZ, control, target));
#line 173 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\StatePreparation\\StatePreparation.qs"
            MultiplexPauli.Apply((disentanglingY, Pauli.PauliY, control, target));
            // target is now in |0> state up to the phase given by arg of newCoefficients.
            // Continue recursion while there are control qubits.
#line 177 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\StatePreparation\\StatePreparation.qs"
            if ((control.Count == 0L))
            {
#line 178 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\StatePreparation\\StatePreparation.qs"
                var (abs,arg) = newCoefficients[0L];
#line 179 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\StatePreparation\\StatePreparation.qs"
                MicrosoftQuantumPrimitiveExp.Apply((new QArray<Pauli>()
                {Pauli.PauliI}, (-(1D) * arg), new QArray<Qubit>()
                {target}));
            }
            else
            {
#line 182 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\StatePreparation\\StatePreparation.qs"
                var newControl = new BigEndian(control?.Slice(new Range(0L, (control.Count - 2L))));
#line 183 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\StatePreparation\\StatePreparation.qs"
                var newTarget = control[(control.Count - 1L)];
#line 184 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\StatePreparation\\StatePreparation.qs"
                ((IUnitary)this).Apply((newCoefficients, newControl, newTarget));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<ComplexPolar>,BigEndian,Qubit), QVoid> AdjointBody => (__in) =>
        {
            var (coefficients,control,target) = __in;
            // For each 2D block, compute disentangling single-qubit rotation parameters
#line 170 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\StatePreparation\\StatePreparation.qs"
            var (disentanglingY,disentanglingZ,newCoefficients) = StatePreparationSBMComputeCoefficients_.Apply(coefficients);
            // target is now in |0> state up to the phase given by arg of newCoefficients.
            // Continue recursion while there are control qubits.
            if ((control.Count == 0L))
            {
#line 178 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\StatePreparation\\StatePreparation.qs"
                var (abs,arg) = newCoefficients[0L];
                MicrosoftQuantumPrimitiveExp.Adjoint.Apply((new QArray<Pauli>()
                {Pauli.PauliI}, (-(1D) * arg), new QArray<Qubit>()
                {target}));
            }
            else
            {
#line 182 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\StatePreparation\\StatePreparation.qs"
                var newControl = new BigEndian(control?.Slice(new Range(0L, (control.Count - 2L))));
#line 183 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\StatePreparation\\StatePreparation.qs"
                var newTarget = control[(control.Count - 1L)];
                ((IUnitary)this).Adjoint.Apply((newCoefficients, newControl, newTarget));
            }

            MultiplexPauli.Adjoint.Apply((disentanglingY, Pauli.PauliY, control, target));
            MultiplexPauli.Adjoint.Apply((disentanglingZ, Pauli.PauliZ, control, target));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<ComplexPolar>,BigEndian,Qubit)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(coefficients,control,target)) = __in;
            // For each 2D block, compute disentangling single-qubit rotation parameters
            var (disentanglingY,disentanglingZ,newCoefficients) = StatePreparationSBMComputeCoefficients_.Apply(coefficients);
            MultiplexPauli.Controlled.Apply((controlQubits, (disentanglingZ, Pauli.PauliZ, control, target)));
            MultiplexPauli.Controlled.Apply((controlQubits, (disentanglingY, Pauli.PauliY, control, target)));
            // target is now in |0> state up to the phase given by arg of newCoefficients.
            // Continue recursion while there are control qubits.
            if ((control.Count == 0L))
            {
                var (abs,arg) = newCoefficients[0L];
                MicrosoftQuantumPrimitiveExp.Controlled.Apply((controlQubits, (new QArray<Pauli>()
                {Pauli.PauliI}, (-(1D) * arg), new QArray<Qubit>()
                {target})));
            }
            else
            {
                var newControl = new BigEndian(control?.Slice(new Range(0L, (control.Count - 2L))));
                var newTarget = control[(control.Count - 1L)];
                ((IUnitary)this).Controlled.Apply((controlQubits, (newCoefficients, newControl, newTarget)));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<ComplexPolar>,BigEndian,Qubit)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,(coefficients,control,target)) = __in;
            // For each 2D block, compute disentangling single-qubit rotation parameters
            var (disentanglingY,disentanglingZ,newCoefficients) = StatePreparationSBMComputeCoefficients_.Apply(coefficients);
            // target is now in |0> state up to the phase given by arg of newCoefficients.
            // Continue recursion while there are control qubits.
            if ((control.Count == 0L))
            {
                var (abs,arg) = newCoefficients[0L];
                MicrosoftQuantumPrimitiveExp.Adjoint.Controlled.Apply((controlQubits, (new QArray<Pauli>()
                {Pauli.PauliI}, (-(1D) * arg), new QArray<Qubit>()
                {target})));
            }
            else
            {
                var newControl = new BigEndian(control?.Slice(new Range(0L, (control.Count - 2L))));
                var newTarget = control[(control.Count - 1L)];
                ((IUnitary)this).Adjoint.Controlled.Apply((controlQubits, (newCoefficients, newControl, newTarget)));
            }

            MultiplexPauli.Adjoint.Controlled.Apply((controlQubits, (disentanglingY, Pauli.PauliY, control, target)));
            MultiplexPauli.Adjoint.Controlled.Apply((controlQubits, (disentanglingZ, Pauli.PauliZ, control, target)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveExp = this.Factory.Get<IUnitary<(QArray<Pauli>,Double,QArray<Qubit>)>>(typeof(Microsoft.Quantum.Primitive.Exp));
            this.MultiplexPauli = this.Factory.Get<IUnitary<(QArray<Double>,Pauli,BigEndian,Qubit)>>(typeof(Microsoft.Quantum.Canon.MultiplexPauli));
            this.StatePreparationSBMComputeCoefficients_ = this.Factory.Get<ICallable<QArray<ComplexPolar>, (QArray<Double>,QArray<Double>,QArray<ComplexPolar>)>>(typeof(Microsoft.Quantum.Canon.StatePreparationSBMComputeCoefficients_));
        }

        public override IApplyData __dataIn((QArray<ComplexPolar>,BigEndian,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<ComplexPolar> coefficients, BigEndian control, Qubit target)
        {
            return __m__.Run<PrepareArbitraryState_, (QArray<ComplexPolar>,BigEndian,Qubit), QVoid>((coefficients, control, target));
        }
    }

    public class BlochSphereCoordinates : Operation<(ComplexPolar,ComplexPolar), (ComplexPolar,Double,Double)>, ICallable
    {
        public BlochSphereCoordinates(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(ComplexPolar,ComplexPolar)>, IApplyData
        {
            public In((ComplexPolar,ComplexPolar) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        public class Out : QTuple<(ComplexPolar,Double,Double)>, IApplyData
        {
            public Out((ComplexPolar,Double,Double) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "BlochSphereCoordinates";
        String ICallable.FullName => "Microsoft.Quantum.Canon.BlochSphereCoordinates";
        protected ICallable<ComplexPolar, Double> AbsComplexPolar
        {
            get;
            set;
        }

        protected ICallable<(Double,Double), Double> MicrosoftQuantumExtensionsMathArcTan2
        {
            get;
            set;
        }

        protected ICallable<ComplexPolar, Double> ArgComplexPolar
        {
            get;
            set;
        }

        protected ICallable<Double, Double> MicrosoftQuantumExtensionsMathSqrt
        {
            get;
            set;
        }

        public override Func<(ComplexPolar,ComplexPolar), (ComplexPolar,Double,Double)> Body => (__in) =>
        {
            var (a0,a1) = __in;
#line 207 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\StatePreparation\\StatePreparation.qs"
            var abs0 = AbsComplexPolar.Apply(a0);
#line 208 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\StatePreparation\\StatePreparation.qs"
            var abs1 = AbsComplexPolar.Apply(a1);
#line 209 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\StatePreparation\\StatePreparation.qs"
            var arg0 = ArgComplexPolar.Apply(a0);
#line 210 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\StatePreparation\\StatePreparation.qs"
            var arg1 = ArgComplexPolar.Apply(a1);
#line 212 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\StatePreparation\\StatePreparation.qs"
            var r = MicrosoftQuantumExtensionsMathSqrt.Apply(((abs0 * abs0) + (abs1 * abs1)));
#line 213 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\StatePreparation\\StatePreparation.qs"
            var t = (0.5D * (arg0 + arg1));
#line 214 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\StatePreparation\\StatePreparation.qs"
            var phi = (arg1 - arg0);
#line 215 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\StatePreparation\\StatePreparation.qs"
            var theta = (2D * MicrosoftQuantumExtensionsMathArcTan2.Apply((abs1, abs0)));
#line 217 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\StatePreparation\\StatePreparation.qs"
            return (new ComplexPolar((r, t)), phi, theta);
        }

        ;
        public override void Init()
        {
            this.AbsComplexPolar = this.Factory.Get<ICallable<ComplexPolar, Double>>(typeof(Microsoft.Quantum.Canon.AbsComplexPolar));
            this.MicrosoftQuantumExtensionsMathArcTan2 = this.Factory.Get<ICallable<(Double,Double), Double>>(typeof(Microsoft.Quantum.Extensions.Math.ArcTan2));
            this.ArgComplexPolar = this.Factory.Get<ICallable<ComplexPolar, Double>>(typeof(Microsoft.Quantum.Canon.ArgComplexPolar));
            this.MicrosoftQuantumExtensionsMathSqrt = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Extensions.Math.Sqrt));
        }

        public override IApplyData __dataIn((ComplexPolar,ComplexPolar) data) => new In(data);
        public override IApplyData __dataOut((ComplexPolar,Double,Double) data) => new Out(data);
        public static System.Threading.Tasks.Task<(ComplexPolar,Double,Double)> Run(IOperationFactory __m__, ComplexPolar a0, ComplexPolar a1)
        {
            return __m__.Run<BlochSphereCoordinates, (ComplexPolar,ComplexPolar), (ComplexPolar,Double,Double)>((a0, a1));
        }
    }

    public class StatePreparationSBMComputeCoefficients_ : Operation<QArray<ComplexPolar>, (QArray<Double>,QArray<Double>,QArray<ComplexPolar>)>, ICallable
    {
        public StatePreparationSBMComputeCoefficients_(IOperationFactory m) : base(m)
        {
        }

        public class Out : QTuple<(QArray<Double>,QArray<Double>,QArray<ComplexPolar>)>, IApplyData
        {
            public Out((QArray<Double>,QArray<Double>,QArray<ComplexPolar>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "StatePreparationSBMComputeCoefficients_";
        String ICallable.FullName => "Microsoft.Quantum.Canon.StatePreparationSBMComputeCoefficients_";
        protected ICallable<(ComplexPolar,ComplexPolar), (ComplexPolar,Double,Double)> BlochSphereCoordinates
        {
            get;
            set;
        }

        public override Func<QArray<ComplexPolar>, (QArray<Double>,QArray<Double>,QArray<ComplexPolar>)> Body => (__in) =>
        {
            var coefficients = __in;
#line 225 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\StatePreparation\\StatePreparation.qs"
            var disentanglingZ = new QArray<Double>((coefficients.Count / 2L));
#line 226 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\StatePreparation\\StatePreparation.qs"
            var disentanglingY = new QArray<Double>((coefficients.Count / 2L));
#line 227 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\StatePreparation\\StatePreparation.qs"
            var newCoefficients = new QArray<ComplexPolar>((coefficients.Count / 2L));
#line 228 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\StatePreparation\\StatePreparation.qs"
            foreach (var idxCoeff in new Range(0L, 2L, (coefficients.Count - 1L)))
            {
#line 229 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\StatePreparation\\StatePreparation.qs"
                var (rt,phi,theta) = BlochSphereCoordinates.Apply((coefficients[idxCoeff], coefficients[(idxCoeff + 1L)]));
#line 230 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\StatePreparation\\StatePreparation.qs"
                disentanglingZ[(idxCoeff / 2L)] = (0.5D * phi);
#line 231 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\StatePreparation\\StatePreparation.qs"
                disentanglingY[(idxCoeff / 2L)] = (0.5D * theta);
#line 232 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\StatePreparation\\StatePreparation.qs"
                newCoefficients[(idxCoeff / 2L)] = rt;
            }

#line 235 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\StatePreparation\\StatePreparation.qs"
            return (disentanglingY, disentanglingZ, newCoefficients);
        }

        ;
        public override void Init()
        {
            this.BlochSphereCoordinates = this.Factory.Get<ICallable<(ComplexPolar,ComplexPolar), (ComplexPolar,Double,Double)>>(typeof(Microsoft.Quantum.Canon.BlochSphereCoordinates));
        }

        public override IApplyData __dataIn(QArray<ComplexPolar> data) => data;
        public override IApplyData __dataOut((QArray<Double>,QArray<Double>,QArray<ComplexPolar>) data) => new Out(data);
        public static System.Threading.Tasks.Task<(QArray<Double>,QArray<Double>,QArray<ComplexPolar>)> Run(IOperationFactory __m__, QArray<ComplexPolar> coefficients)
        {
            return __m__.Run<StatePreparationSBMComputeCoefficients_, QArray<ComplexPolar>, (QArray<Double>,QArray<Double>,QArray<ComplexPolar>)>(coefficients);
        }
    }
}