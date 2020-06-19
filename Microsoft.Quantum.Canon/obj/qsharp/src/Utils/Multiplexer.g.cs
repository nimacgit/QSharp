#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "MultiplexPauli (coefficients : Double[], pauli : Pauli, control : Microsoft.Quantum.Canon.BigEndian, target : Qubit) : ()", new string[] { "Controlled", "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs", 1317L, 35L, 106L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "MultiplexZ (coefficients : Double[], control : Microsoft.Quantum.Canon.BigEndian, target : Qubit) : ()", new string[] { "Controlled", "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs", 3315L, 88L, 90L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "ApplyDiagonalUnitary (coefficients : Double[], qubits : Microsoft.Quantum.Canon.BigEndian) : ()", new string[] { "Controlled", "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs", 5740L, 144L, 84L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "MultiplexOperations<'T> (unitaries : ('T => () : Adjoint, Controlled)[], index : Microsoft.Quantum.Canon.BigEndian, target : 'T) : ()", new string[] { "Controlled", "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs", 8719L, 212L, 122L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "MultiplexOperations_<'T> (unitaries : ('T => () : Adjoint, Controlled)[], ancilla : Qubit[], index : Microsoft.Quantum.Canon.BigEndian, target : 'T) : ()", new string[] { "Controlled", "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs", 9450L, 231L, 141L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "MultiplexZComputeCoefficients_ (coefficients : Double[]) : (Double[], Double[])", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs", 6880L, 173L, 14L)]
#line hidden
namespace Microsoft.Quantum.Canon
{
    public class MultiplexPauli : Unitary<(QArray<Double>,Pauli,BigEndian,Qubit)>, ICallable
    {
        public MultiplexPauli(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Double>,Pauli,BigEndian,Qubit)>, IApplyData
        {
            public In((QArray<Double>,Pauli,BigEndian,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item3)?.Qubits, ((IApplyData)Data.Item4)?.Qubits);
        }

        String ICallable.Name => "MultiplexPauli";
        String ICallable.FullName => "Microsoft.Quantum.Canon.MultiplexPauli";
        protected IUnitary<(QArray<Double>,BigEndian)> ApplyDiagonalUnitary
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Double>,BigEndian,Qubit)> MultiplexZ
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveS
        {
            get;
            set;
        }

        protected IUnitary WithCA
        {
            get;
            set;
        }

        public override Func<(QArray<Double>,Pauli,BigEndian,Qubit), QVoid> Body => (__in) =>
        {
            var (coefficients,pauli,control,target) = __in;
#line 37 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
            if ((pauli == Pauli.PauliZ))
            {
#line 38 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
                var op = MultiplexZ.Partial(new Func<Qubit, (QArray<Double>,BigEndian,Qubit)>((_arg1) => (coefficients, control, _arg1)));
#line 39 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
                op.Apply(target);
            }
            else if ((pauli == Pauli.PauliX))
            {
#line 42 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
                var op = ((IUnitary)this).Partial(new Func<Qubit, (QArray<Double>,Pauli,BigEndian,Qubit)>((_arg1) => (coefficients, Pauli.PauliZ, control, _arg1)));
#line 43 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
                WithCA.Apply((((IAdjointable)MicrosoftQuantumPrimitiveH), ((IUnitary)op), target));
            }
            else if ((pauli == Pauli.PauliY))
            {
#line 46 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
                var op = ((IUnitary)this).Partial(new Func<Qubit, (QArray<Double>,Pauli,BigEndian,Qubit)>((_arg1) => (coefficients, Pauli.PauliX, control, _arg1)));
#line 47 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
                WithCA.Apply((((IAdjointable)MicrosoftQuantumPrimitiveS.Adjoint), ((IUnitary)op), target));
            }
            else if ((pauli == Pauli.PauliI))
            {
#line 50 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
                ApplyDiagonalUnitary.Apply((coefficients, control));
            }
            else
            {
#line 53 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
                throw new ExecutionFailException($"MultiplexPauli failed. Invalid pauli {pauli}.");
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Double>,Pauli,BigEndian,Qubit), QVoid> AdjointBody => (__in) =>
        {
            var (coefficients,pauli,control,target) = __in;
            if ((pauli == Pauli.PauliZ))
            {
#line 38 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
                var op = MultiplexZ.Partial(new Func<Qubit, (QArray<Double>,BigEndian,Qubit)>((_arg1) => (coefficients, control, _arg1)));
                op.Adjoint.Apply(target);
            }
            else if ((pauli == Pauli.PauliX))
            {
#line 42 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
                var op = ((IUnitary)this).Partial(new Func<Qubit, (QArray<Double>,Pauli,BigEndian,Qubit)>((_arg1) => (coefficients, Pauli.PauliZ, control, _arg1)));
                WithCA.Adjoint.Apply((((IAdjointable)MicrosoftQuantumPrimitiveH), ((IUnitary)op), target));
            }
            else if ((pauli == Pauli.PauliY))
            {
#line 46 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
                var op = ((IUnitary)this).Partial(new Func<Qubit, (QArray<Double>,Pauli,BigEndian,Qubit)>((_arg1) => (coefficients, Pauli.PauliX, control, _arg1)));
                WithCA.Adjoint.Apply((((IAdjointable)MicrosoftQuantumPrimitiveS.Adjoint), ((IUnitary)op), target));
            }
            else if ((pauli == Pauli.PauliI))
            {
                ApplyDiagonalUnitary.Adjoint.Apply((coefficients, control));
            }
            else
            {
#line 53 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
                throw new ExecutionFailException($"MultiplexPauli failed. Invalid pauli {pauli}.");
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Double>,Pauli,BigEndian,Qubit)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(coefficients,pauli,control,target)) = __in;
            if ((pauli == Pauli.PauliZ))
            {
                var op = MultiplexZ.Partial(new Func<Qubit, (QArray<Double>,BigEndian,Qubit)>((_arg1) => (coefficients, control, _arg1)));
                op.Controlled.Apply((controlQubits, target));
            }
            else if ((pauli == Pauli.PauliX))
            {
                var op = ((IUnitary)this).Partial(new Func<Qubit, (QArray<Double>,Pauli,BigEndian,Qubit)>((_arg1) => (coefficients, Pauli.PauliZ, control, _arg1)));
                WithCA.Controlled.Apply((controlQubits, (((IAdjointable)MicrosoftQuantumPrimitiveH), ((IUnitary)op), target)));
            }
            else if ((pauli == Pauli.PauliY))
            {
                var op = ((IUnitary)this).Partial(new Func<Qubit, (QArray<Double>,Pauli,BigEndian,Qubit)>((_arg1) => (coefficients, Pauli.PauliX, control, _arg1)));
                WithCA.Controlled.Apply((controlQubits, (((IAdjointable)MicrosoftQuantumPrimitiveS.Adjoint), ((IUnitary)op), target)));
            }
            else if ((pauli == Pauli.PauliI))
            {
                ApplyDiagonalUnitary.Controlled.Apply((controlQubits, (coefficients, control)));
            }
            else
            {
                throw new ExecutionFailException($"MultiplexPauli failed. Invalid pauli {pauli}.");
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Double>,Pauli,BigEndian,Qubit)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,(coefficients,pauli,control,target)) = __in;
            if ((pauli == Pauli.PauliZ))
            {
                var op = MultiplexZ.Partial(new Func<Qubit, (QArray<Double>,BigEndian,Qubit)>((_arg1) => (coefficients, control, _arg1)));
                op.Adjoint.Controlled.Apply((controlQubits, target));
            }
            else if ((pauli == Pauli.PauliX))
            {
                var op = ((IUnitary)this).Partial(new Func<Qubit, (QArray<Double>,Pauli,BigEndian,Qubit)>((_arg1) => (coefficients, Pauli.PauliZ, control, _arg1)));
                WithCA.Adjoint.Controlled.Apply((controlQubits, (((IAdjointable)MicrosoftQuantumPrimitiveH), ((IUnitary)op), target)));
            }
            else if ((pauli == Pauli.PauliY))
            {
                var op = ((IUnitary)this).Partial(new Func<Qubit, (QArray<Double>,Pauli,BigEndian,Qubit)>((_arg1) => (coefficients, Pauli.PauliX, control, _arg1)));
                WithCA.Adjoint.Controlled.Apply((controlQubits, (((IAdjointable)MicrosoftQuantumPrimitiveS.Adjoint), ((IUnitary)op), target)));
            }
            else if ((pauli == Pauli.PauliI))
            {
                ApplyDiagonalUnitary.Adjoint.Controlled.Apply((controlQubits, (coefficients, control)));
            }
            else
            {
                throw new ExecutionFailException($"MultiplexPauli failed. Invalid pauli {pauli}.");
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.ApplyDiagonalUnitary = this.Factory.Get<IUnitary<(QArray<Double>,BigEndian)>>(typeof(Microsoft.Quantum.Canon.ApplyDiagonalUnitary));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.MultiplexZ = this.Factory.Get<IUnitary<(QArray<Double>,BigEndian,Qubit)>>(typeof(Microsoft.Quantum.Canon.MultiplexZ));
            this.MicrosoftQuantumPrimitiveS = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.S));
            this.WithCA = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.WithCA<>));
        }

        public override IApplyData __dataIn((QArray<Double>,Pauli,BigEndian,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Double> coefficients, Pauli pauli, BigEndian control, Qubit target)
        {
            return __m__.Run<MultiplexPauli, (QArray<Double>,Pauli,BigEndian,Qubit), QVoid>((coefficients, pauli, control, target));
        }
    }

    public class MultiplexZ : Unitary<(QArray<Double>,BigEndian,Qubit)>, ICallable
    {
        public MultiplexZ(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Double>,BigEndian,Qubit)>, IApplyData
        {
            public In((QArray<Double>,BigEndian,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "MultiplexZ";
        String ICallable.FullName => "Microsoft.Quantum.Canon.MultiplexZ";
        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveCNOT
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Pauli>,Double,QArray<Qubit>)> MicrosoftQuantumPrimitiveExp
        {
            get;
            set;
        }

        protected ICallable<QArray<Double>, (QArray<Double>,QArray<Double>)> MultiplexZComputeCoefficients_
        {
            get;
            set;
        }

        protected ICallable Pad
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(QArray<Double>,BigEndian,Qubit), QVoid> Body => (__in) =>
        {
            var (coefficients,control,target) = __in;
            // pad coefficients length at tail to a power of 2.
#line 91 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
            var coefficientsPadded = Pad.Apply<QArray<Double>>((-(2L).Pow(control.Count), 0D, coefficients));
#line 93 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
            if ((coefficientsPadded.Count == 1L))
            {
                // Termination case
#line 95 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
                MicrosoftQuantumPrimitiveExp.Apply((new QArray<Pauli>()
                {Pauli.PauliZ}, coefficientsPadded[0L], new QArray<Qubit>()
                {target}));
            }
            else
            {
                // Compute new coefficients.
#line 99 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
                var (coefficients0,coefficients1) = MultiplexZComputeCoefficients_.Apply(coefficientsPadded);
#line 100 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
                ((IUnitary)this).Apply((coefficients0, new BigEndian(control?.Slice(new Range(1L, (control.Count - 1L)))), target));
#line 101 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
                MicrosoftQuantumPrimitiveCNOT.Apply((control[0L], target));
#line 102 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
                ((IUnitary)this).Apply((coefficients1, new BigEndian(control?.Slice(new Range(1L, (control.Count - 1L)))), target));
#line 103 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
                MicrosoftQuantumPrimitiveCNOT.Apply((control[0L], target));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Double>,BigEndian,Qubit), QVoid> AdjointBody => (__in) =>
        {
            var (coefficients,control,target) = __in;
            // pad coefficients length at tail to a power of 2.
#line 91 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
            var coefficientsPadded = Pad.Apply<QArray<Double>>((-(2L).Pow(control.Count), 0D, coefficients));
            if ((coefficientsPadded.Count == 1L))
            {
                // Termination case
                MicrosoftQuantumPrimitiveExp.Adjoint.Apply((new QArray<Pauli>()
                {Pauli.PauliZ}, coefficientsPadded[0L], new QArray<Qubit>()
                {target}));
            }
            else
            {
                // Compute new coefficients.
#line 99 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
                var (coefficients0,coefficients1) = MultiplexZComputeCoefficients_.Apply(coefficientsPadded);
                MicrosoftQuantumPrimitiveCNOT.Adjoint.Apply((control[0L], target));
                ((IUnitary)this).Adjoint.Apply((coefficients1, new BigEndian(control?.Slice(new Range(1L, (control.Count - 1L)))), target));
                MicrosoftQuantumPrimitiveCNOT.Adjoint.Apply((control[0L], target));
                ((IUnitary)this).Adjoint.Apply((coefficients0, new BigEndian(control?.Slice(new Range(1L, (control.Count - 1L)))), target));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Double>,BigEndian,Qubit)), QVoid> ControlledBody => (__in) =>
        {
            var (controlRegister,(coefficients,control,target)) = __in;
            // pad coefficients length to a power of 2.
#line 109 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
            var coefficientsPadded = Pad.Apply<QArray<Double>>((2L.Pow((control.Count + 1L)), 0D, Pad.Apply<QArray<Double>>((-(2L).Pow(control.Count), 0D, coefficients))));
#line 111 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
            var (coefficients0,coefficients1) = MultiplexZComputeCoefficients_.Apply(coefficientsPadded);
#line 113 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
            ((IUnitary)this).Apply((coefficients0, control, target));
#line 114 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((controlRegister, target));
#line 115 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
            ((IUnitary)this).Apply((coefficients1, control, target));
#line 116 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((controlRegister, target));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Double>,BigEndian,Qubit)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlRegister,(coefficients,control,target)) = __in;
            // pad coefficients length to a power of 2.
#line 109 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
            var coefficientsPadded = Pad.Apply<QArray<Double>>((2L.Pow((control.Count + 1L)), 0D, Pad.Apply<QArray<Double>>((-(2L).Pow(control.Count), 0D, coefficients))));
#line 111 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
            var (coefficients0,coefficients1) = MultiplexZComputeCoefficients_.Apply(coefficientsPadded);
            MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Apply((controlRegister, target));
            ((IUnitary)this).Adjoint.Apply((coefficients1, control, target));
            MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Apply((controlRegister, target));
            ((IUnitary)this).Adjoint.Apply((coefficients0, control, target));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
            this.MicrosoftQuantumPrimitiveExp = this.Factory.Get<IUnitary<(QArray<Pauli>,Double,QArray<Qubit>)>>(typeof(Microsoft.Quantum.Primitive.Exp));
            this.MultiplexZComputeCoefficients_ = this.Factory.Get<ICallable<QArray<Double>, (QArray<Double>,QArray<Double>)>>(typeof(Microsoft.Quantum.Canon.MultiplexZComputeCoefficients_));
            this.Pad = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Pad<>));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((QArray<Double>,BigEndian,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Double> coefficients, BigEndian control, Qubit target)
        {
            return __m__.Run<MultiplexZ, (QArray<Double>,BigEndian,Qubit), QVoid>((coefficients, control, target));
        }
    }

    public class ApplyDiagonalUnitary : Unitary<(QArray<Double>,BigEndian)>, ICallable
    {
        public ApplyDiagonalUnitary(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Double>,BigEndian)>, IApplyData
        {
            public In((QArray<Double>,BigEndian) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "ApplyDiagonalUnitary";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ApplyDiagonalUnitary";
        protected IUnitary<(QArray<Pauli>,Double,QArray<Qubit>)> MicrosoftQuantumPrimitiveExp
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Double>,BigEndian,Qubit)> MultiplexZ
        {
            get;
            set;
        }

        protected ICallable<QArray<Double>, (QArray<Double>,QArray<Double>)> MultiplexZComputeCoefficients_
        {
            get;
            set;
        }

        protected ICallable Pad
        {
            get;
            set;
        }

        public override Func<(QArray<Double>,BigEndian), QVoid> Body => (__in) =>
        {
            var (coefficients,qubits) = __in;
#line 146 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
            if ((qubits.Count == 0L))
            {
#line 147 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
                throw new ExecutionFailException($"operation ApplyDiagonalUnitary -- Number of qubits must be greater than 0.");
            }

            // pad coefficients length at tail to a power of 2.
#line 151 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
            var coefficientsPadded = Pad.Apply<QArray<Double>>((-(2L).Pow(qubits.Count), 0D, coefficients));
            // Compute new coefficients.
#line 154 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
            var (coefficients0,coefficients1) = MultiplexZComputeCoefficients_.Apply(coefficientsPadded);
#line 155 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
            MultiplexZ.Apply((coefficients1, new BigEndian(qubits?.Slice(new Range(1L, (qubits.Count - 1L)))), qubits[0L]));
#line 156 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
            if ((coefficientsPadded.Count == 2L))
            {
                // Termination case
#line 158 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
                MicrosoftQuantumPrimitiveExp.Apply((new QArray<Pauli>()
                {Pauli.PauliI}, (1D * coefficients0[0L]), qubits));
            }
            else
            {
#line 161 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
                ((IUnitary)this).Apply((coefficients0, new BigEndian(qubits?.Slice(new Range(1L, (qubits.Count - 1L))))));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Double>,BigEndian), QVoid> AdjointBody => (__in) =>
        {
            var (coefficients,qubits) = __in;
            if ((qubits.Count == 0L))
            {
#line 147 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
                throw new ExecutionFailException($"operation ApplyDiagonalUnitary -- Number of qubits must be greater than 0.");
            }

            // pad coefficients length at tail to a power of 2.
#line 151 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
            var coefficientsPadded = Pad.Apply<QArray<Double>>((-(2L).Pow(qubits.Count), 0D, coefficients));
            // Compute new coefficients.
#line 154 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
            var (coefficients0,coefficients1) = MultiplexZComputeCoefficients_.Apply(coefficientsPadded);
            if ((coefficientsPadded.Count == 2L))
            {
                // Termination case
                MicrosoftQuantumPrimitiveExp.Adjoint.Apply((new QArray<Pauli>()
                {Pauli.PauliI}, (1D * coefficients0[0L]), qubits));
            }
            else
            {
                ((IUnitary)this).Adjoint.Apply((coefficients0, new BigEndian(qubits?.Slice(new Range(1L, (qubits.Count - 1L))))));
            }

            MultiplexZ.Adjoint.Apply((coefficients1, new BigEndian(qubits?.Slice(new Range(1L, (qubits.Count - 1L)))), qubits[0L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Double>,BigEndian)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(coefficients,qubits)) = __in;
            if ((qubits.Count == 0L))
            {
                throw new ExecutionFailException($"operation ApplyDiagonalUnitary -- Number of qubits must be greater than 0.");
            }

            // pad coefficients length at tail to a power of 2.
            var coefficientsPadded = Pad.Apply<QArray<Double>>((-(2L).Pow(qubits.Count), 0D, coefficients));
            // Compute new coefficients.
            var (coefficients0,coefficients1) = MultiplexZComputeCoefficients_.Apply(coefficientsPadded);
            MultiplexZ.Controlled.Apply((controlQubits, (coefficients1, new BigEndian(qubits?.Slice(new Range(1L, (qubits.Count - 1L)))), qubits[0L])));
            if ((coefficientsPadded.Count == 2L))
            {
                // Termination case
                MicrosoftQuantumPrimitiveExp.Controlled.Apply((controlQubits, (new QArray<Pauli>()
                {Pauli.PauliI}, (1D * coefficients0[0L]), qubits)));
            }
            else
            {
                ((IUnitary)this).Controlled.Apply((controlQubits, (coefficients0, new BigEndian(qubits?.Slice(new Range(1L, (qubits.Count - 1L)))))));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Double>,BigEndian)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,(coefficients,qubits)) = __in;
            if ((qubits.Count == 0L))
            {
                throw new ExecutionFailException($"operation ApplyDiagonalUnitary -- Number of qubits must be greater than 0.");
            }

            // pad coefficients length at tail to a power of 2.
            var coefficientsPadded = Pad.Apply<QArray<Double>>((-(2L).Pow(qubits.Count), 0D, coefficients));
            // Compute new coefficients.
            var (coefficients0,coefficients1) = MultiplexZComputeCoefficients_.Apply(coefficientsPadded);
            if ((coefficientsPadded.Count == 2L))
            {
                // Termination case
                MicrosoftQuantumPrimitiveExp.Adjoint.Controlled.Apply((controlQubits, (new QArray<Pauli>()
                {Pauli.PauliI}, (1D * coefficients0[0L]), qubits)));
            }
            else
            {
                ((IUnitary)this).Adjoint.Controlled.Apply((controlQubits, (coefficients0, new BigEndian(qubits?.Slice(new Range(1L, (qubits.Count - 1L)))))));
            }

            MultiplexZ.Adjoint.Controlled.Apply((controlQubits, (coefficients1, new BigEndian(qubits?.Slice(new Range(1L, (qubits.Count - 1L)))), qubits[0L])));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveExp = this.Factory.Get<IUnitary<(QArray<Pauli>,Double,QArray<Qubit>)>>(typeof(Microsoft.Quantum.Primitive.Exp));
            this.MultiplexZ = this.Factory.Get<IUnitary<(QArray<Double>,BigEndian,Qubit)>>(typeof(Microsoft.Quantum.Canon.MultiplexZ));
            this.MultiplexZComputeCoefficients_ = this.Factory.Get<ICallable<QArray<Double>, (QArray<Double>,QArray<Double>)>>(typeof(Microsoft.Quantum.Canon.MultiplexZComputeCoefficients_));
            this.Pad = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Pad<>));
        }

        public override IApplyData __dataIn((QArray<Double>,BigEndian) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Double> coefficients, BigEndian qubits)
        {
            return __m__.Run<ApplyDiagonalUnitary, (QArray<Double>,BigEndian), QVoid>((coefficients, qubits));
        }
    }

    public class MultiplexZComputeCoefficients_ : Operation<QArray<Double>, (QArray<Double>,QArray<Double>)>, ICallable
    {
        public MultiplexZComputeCoefficients_(IOperationFactory m) : base(m)
        {
        }

        public class Out : QTuple<(QArray<Double>,QArray<Double>)>, IApplyData
        {
            public Out((QArray<Double>,QArray<Double>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "MultiplexZComputeCoefficients_";
        String ICallable.FullName => "Microsoft.Quantum.Canon.MultiplexZComputeCoefficients_";
        public override Func<QArray<Double>, (QArray<Double>,QArray<Double>)> Body => (__in) =>
        {
            var coefficients = __in;
#line 174 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
            var newCoefficientsLength = (coefficients.Count / 2L);
#line 175 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
            var coefficients0 = new QArray<Double>(newCoefficientsLength);
#line 176 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
            var coefficients1 = new QArray<Double>(newCoefficientsLength);
#line 177 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
            foreach (var idxCoeff in new Range(0L, (newCoefficientsLength - 1L)))
            {
#line 178 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
                coefficients0[idxCoeff] = (0.5D * (coefficients[idxCoeff] + coefficients[(idxCoeff + newCoefficientsLength)]));
#line 179 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
                coefficients1[idxCoeff] = (0.5D * (coefficients[idxCoeff] - coefficients[(idxCoeff + newCoefficientsLength)]));
            }

#line 181 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
            return (coefficients0, coefficients1);
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(QArray<Double> data) => data;
        public override IApplyData __dataOut((QArray<Double>,QArray<Double>) data) => new Out(data);
        public static System.Threading.Tasks.Task<(QArray<Double>,QArray<Double>)> Run(IOperationFactory __m__, QArray<Double> coefficients)
        {
            return __m__.Run<MultiplexZComputeCoefficients_, QArray<Double>, (QArray<Double>,QArray<Double>)>(coefficients);
        }
    }

    public class MultiplexOperations<__T> : Unitary<(QArray<IUnitary>,BigEndian,__T)>, ICallable
    {
        public MultiplexOperations(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<IUnitary>,BigEndian,__T)>, IApplyData
        {
            public In((QArray<IUnitary>,BigEndian,__T) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, Data.Item3?.GetQubits());
        }

        String ICallable.Name => "MultiplexOperations";
        String ICallable.FullName => "Microsoft.Quantum.Canon.MultiplexOperations";
        protected IUnitary MultiplexOperations_
        {
            get;
            set;
        }

        public override Func<(QArray<IUnitary>,BigEndian,__T), QVoid> Body => (__in) =>
        {
            var (unitaries,index,target) = __in;
#line 214 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
            if ((index.Count == 0L))
            {
#line 215 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
                throw new ExecutionFailException("MultiplexOperations failed. Number of index qubits must be greater than 0.");
            }

#line 217 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
            if ((unitaries.Count > 0L))
            {
#line 218 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
                var ancilla = new QArray<Qubit>(0L);
#line 219 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
                MultiplexOperations_.Apply((unitaries, ancilla, index, target));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<IUnitary>,BigEndian,__T), QVoid> AdjointBody => (__in) =>
        {
            var (unitaries,index,target) = __in;
            if ((index.Count == 0L))
            {
#line 215 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
                throw new ExecutionFailException("MultiplexOperations failed. Number of index qubits must be greater than 0.");
            }

            if ((unitaries.Count > 0L))
            {
#line 218 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
                var ancilla = new QArray<Qubit>(0L);
                MultiplexOperations_.Adjoint.Apply((unitaries, ancilla, index, target));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<IUnitary>,BigEndian,__T)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(unitaries,index,target)) = __in;
            if ((index.Count == 0L))
            {
                throw new ExecutionFailException("MultiplexOperations failed. Number of index qubits must be greater than 0.");
            }

            if ((unitaries.Count > 0L))
            {
                var ancilla = new QArray<Qubit>(0L);
                MultiplexOperations_.Controlled.Apply((controlQubits, (unitaries, ancilla, index, target)));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<IUnitary>,BigEndian,__T)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,(unitaries,index,target)) = __in;
            if ((index.Count == 0L))
            {
                throw new ExecutionFailException("MultiplexOperations failed. Number of index qubits must be greater than 0.");
            }

            if ((unitaries.Count > 0L))
            {
                var ancilla = new QArray<Qubit>(0L);
                MultiplexOperations_.Adjoint.Controlled.Apply((controlQubits, (unitaries, ancilla, index, target)));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MultiplexOperations_ = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.MultiplexOperations_<>));
        }

        public override IApplyData __dataIn((QArray<IUnitary>,BigEndian,__T) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<IUnitary> unitaries, BigEndian index, __T target)
        {
            return __m__.Run<MultiplexOperations<__T>, (QArray<IUnitary>,BigEndian,__T), QVoid>((unitaries, index, target));
        }
    }

    public class MultiplexOperations_<__T> : Unitary<(QArray<IUnitary>,QArray<Qubit>,BigEndian,__T)>, ICallable
    {
        public MultiplexOperations_(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<IUnitary>,QArray<Qubit>,BigEndian,__T)>, IApplyData
        {
            public In((QArray<IUnitary>,QArray<Qubit>,BigEndian,__T) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits, Data.Item4?.GetQubits());
        }

        String ICallable.Name => "MultiplexOperations_";
        String ICallable.FullName => "Microsoft.Quantum.Canon.MultiplexOperations_";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64), Int64> MicrosoftQuantumExtensionsMathMinI
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(QArray<IUnitary>,QArray<Qubit>,BigEndian,__T), QVoid> Body => (__in) =>
        {
            var (unitaries,ancilla,index,target) = __in;
#line 233 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
            var nIndex = index.Count;
#line 234 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
            var nStates = 2L.Pow(nIndex);
#line 235 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
            var nUnitaries = unitaries.Count;
#line 237 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
            var nUnitariesRight = MicrosoftQuantumExtensionsMathMinI.Apply((nUnitaries, (nStates / 2L)));
#line 238 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
            var nUnitariesLeft = MicrosoftQuantumExtensionsMathMinI.Apply((nUnitaries, nStates));
#line 240 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
            var rightUnitaries = unitaries?.Slice(new Range(0L, (nUnitariesRight - 1L)));
#line 241 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
            var leftUnitaries = unitaries?.Slice(new Range(nUnitariesRight, (nUnitariesLeft - 1L)));
#line 242 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
            var newControls = new BigEndian(index?.Slice(new Range(1L, (nIndex - 1L))));
#line 244 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
            if ((nUnitaries > 0L))
            {
#line 245 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
                if (((ancilla.Count == 1L) && (nIndex == 0L)))
                {
                    // Termination case
#line 247 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
                    unitaries[0L].Controlled.Apply((ancilla, target));
                }
                else if (((ancilla.Count == 0L) && (nIndex >= 1L)))
                {
                    // Start case
#line 251 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
                    var newAncilla = new QArray<Qubit>()
                    {index[0L]};
#line 252 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
                    if ((nUnitariesLeft > 0L))
                    {
#line 253 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
                        ((IUnitary)this).Apply((leftUnitaries, newAncilla, newControls, target));
                    }

#line 255 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
                    MicrosoftQuantumPrimitiveX.Apply(newAncilla[0L]);
#line 256 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
                    ((IUnitary)this).Apply((rightUnitaries, newAncilla, newControls, target));
#line 257 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
                    MicrosoftQuantumPrimitiveX.Apply(newAncilla[0L]);
                }
                else
                {
                    // Recursion that reduces nIndex by 1 & sets Length(ancilla) to 1.
#line 261 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
                    var newAncilla = Allocate.Apply(1L);
#line 262 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
                    MicrosoftQuantumPrimitiveX.Controlled.Apply(((ancilla + new QArray<Qubit>()
                    {index[0L]}), newAncilla[0L]));
#line 263 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
                    if ((nUnitariesLeft > 0L))
                    {
#line 264 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
                        ((IUnitary)this).Apply((leftUnitaries, newAncilla, newControls, target));
                    }

#line 266 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
                    MicrosoftQuantumPrimitiveX.Controlled.Apply((ancilla, newAncilla[0L]));
#line 267 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
                    ((IUnitary)this).Apply((rightUnitaries, newAncilla, newControls, target));
#line 268 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
                    MicrosoftQuantumPrimitiveX.Controlled.Apply((ancilla, newAncilla[0L]));
#line 269 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
                    MicrosoftQuantumPrimitiveX.Controlled.Apply(((ancilla + new QArray<Qubit>()
                    {index[0L]}), newAncilla[0L]));
#line hidden
                    Release.Apply(newAncilla);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<IUnitary>,QArray<Qubit>,BigEndian,__T), QVoid> AdjointBody => (__in) =>
        {
            var (unitaries,ancilla,index,target) = __in;
#line 233 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
            var nIndex = index.Count;
#line 234 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
            var nStates = 2L.Pow(nIndex);
#line 235 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
            var nUnitaries = unitaries.Count;
#line 237 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
            var nUnitariesRight = MicrosoftQuantumExtensionsMathMinI.Apply((nUnitaries, (nStates / 2L)));
#line 238 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
            var nUnitariesLeft = MicrosoftQuantumExtensionsMathMinI.Apply((nUnitaries, nStates));
#line 240 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
            var rightUnitaries = unitaries?.Slice(new Range(0L, (nUnitariesRight - 1L)));
#line 241 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
            var leftUnitaries = unitaries?.Slice(new Range(nUnitariesRight, (nUnitariesLeft - 1L)));
#line 242 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
            var newControls = new BigEndian(index?.Slice(new Range(1L, (nIndex - 1L))));
            if ((nUnitaries > 0L))
            {
                if (((ancilla.Count == 1L) && (nIndex == 0L)))
                {
                    // Termination case
                    unitaries[0L].Controlled.Adjoint.Apply((ancilla, target));
                }
                else if (((ancilla.Count == 0L) && (nIndex >= 1L)))
                {
                    // Start case
#line 251 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
                    var newAncilla = new QArray<Qubit>()
                    {index[0L]};
                    MicrosoftQuantumPrimitiveX.Adjoint.Apply(newAncilla[0L]);
                    ((IUnitary)this).Adjoint.Apply((rightUnitaries, newAncilla, newControls, target));
                    MicrosoftQuantumPrimitiveX.Adjoint.Apply(newAncilla[0L]);
                    if ((nUnitariesLeft > 0L))
                    {
                        ((IUnitary)this).Adjoint.Apply((leftUnitaries, newAncilla, newControls, target));
                    }
                }
                else
                {
                    // Recursion that reduces nIndex by 1 & sets Length(ancilla) to 1.
                    var newAncilla = Allocate.Apply(1L);
                    MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Apply(((ancilla + new QArray<Qubit>()
                    {index[0L]}), newAncilla[0L]));
                    MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Apply((ancilla, newAncilla[0L]));
                    ((IUnitary)this).Adjoint.Apply((rightUnitaries, newAncilla, newControls, target));
                    MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Apply((ancilla, newAncilla[0L]));
                    if ((nUnitariesLeft > 0L))
                    {
                        ((IUnitary)this).Adjoint.Apply((leftUnitaries, newAncilla, newControls, target));
                    }

                    MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Apply(((ancilla + new QArray<Qubit>()
                    {index[0L]}), newAncilla[0L]));
#line hidden
                    Release.Apply(newAncilla);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<IUnitary>,QArray<Qubit>,BigEndian,__T)), QVoid> ControlledBody => (__in) =>
        {
            var (controlRegister,(unitaries,ancilla,index,target)) = __in;
#line 276 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Multiplexer.qs"
            ((IUnitary)this).Apply((unitaries, controlRegister, index, target));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<IUnitary>,QArray<Qubit>,BigEndian,__T)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlRegister,(unitaries,ancilla,index,target)) = __in;
            ((IUnitary)this).Adjoint.Apply((unitaries, controlRegister, index, target));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumExtensionsMathMinI = this.Factory.Get<ICallable<(Int64,Int64), Int64>>(typeof(Microsoft.Quantum.Extensions.Math.MinI));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((QArray<IUnitary>,QArray<Qubit>,BigEndian,__T) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<IUnitary> unitaries, QArray<Qubit> ancilla, BigEndian index, __T target)
        {
            return __m__.Run<MultiplexOperations_<__T>, (QArray<IUnitary>,QArray<Qubit>,BigEndian,__T), QVoid>((unitaries, ancilla, index, target));
        }
    }
}