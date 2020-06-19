#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "MeasureAllZ (register : Qubit[]) : Result", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qcvv\\ProcessTomography.qs", 619L, 20L, 56L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "MeasureIdentity (register : Qubit[]) : Result", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qcvv\\ProcessTomography.qs", 1895L, 54L, 60L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "PrepareSingleQubitIdentity (qubit : Qubit) : ()", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qcvv\\ProcessTomography.qs", 3141L, 84L, 62L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "PrepareIdentity (register : Qubit[]) : ()", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qcvv\\ProcessTomography.qs", 3766L, 102L, 56L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "EstimateFrequency (preparation : (Qubit[] => ()), measurement : (Qubit[] => Result), nQubits : Int, nMeasurements : Int) : Double", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qcvv\\ProcessTomography.qs", 5213L, 135L, 144L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "PrepareQubit (basis : Pauli, qubit : Qubit) : ()", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qcvv\\ProcessTomography.qs", 6749L, 171L, 63L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "PrepareEntangledState (left : Qubit[], right : Qubit[]) : ()", new string[] { "Controlled", "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qcvv\\ProcessTomography.qs", 7562L, 195L, 75L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "PrepareChoiState (op : (Qubit[] => ()), reference : Qubit[], target : Qubit[]) : ()", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qcvv\\ProcessTomography.qs", 9584L, 247L, 98L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "PrepareChoiStateC (op : (Qubit[] => () : Controlled), reference : Qubit[], target : Qubit[]) : ()", new string[] { "Controlled" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qcvv\\ProcessTomography.qs", 10053L, 259L, 112L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "PrepareChoiStateA (op : (Qubit[] => () : Adjoint), reference : Qubit[], target : Qubit[]) : ()", new string[] { "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qcvv\\ProcessTomography.qs", 10548L, 273L, 109L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "PrepareChoiStateCA (op : (Qubit[] => () : Controlled, Adjoint), reference : Qubit[], target : Qubit[]) : ()", new string[] { "Controlled", "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qcvv\\ProcessTomography.qs", 11077L, 288L, 122L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "SingleQubitProcessTomographyMeasurement (preparation : Pauli, measurement : Pauli, channel : (Qubit => ())) : Result", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qcvv\\ProcessTomography.qs", 12853L, 341L, 16L)]
#line hidden
namespace Microsoft.Quantum.Canon
{
    public class MeasureAllZ : Operation<QArray<Qubit>, Result>, ICallable
    {
        public MeasureAllZ(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "MeasureAllZ";
        String ICallable.FullName => "Microsoft.Quantum.Canon.MeasureAllZ";
        protected ICallable<(QArray<Pauli>,QArray<Qubit>), Result> Measure
        {
            get;
            set;
        }

        public override Func<QArray<Qubit>, Result> Body => (__in) =>
        {
            var register = __in;
#line 22 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qcvv\\ProcessTomography.qs"
            var nQubits = register.Count;
#line 23 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qcvv\\ProcessTomography.qs"
            var allZMeasurement = new QArray<Pauli>(nQubits);
#line 24 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qcvv\\ProcessTomography.qs"
            foreach (var idxQubit in new Range(0L, (nQubits - 1L)))
            {
#line 25 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qcvv\\ProcessTomography.qs"
                allZMeasurement[idxQubit] = Pauli.PauliZ;
            }

#line 28 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qcvv\\ProcessTomography.qs"
            return Measure.Apply((allZMeasurement, register));
        }

        ;
        public override void Init()
        {
            this.Measure = this.Factory.Get<ICallable<(QArray<Pauli>,QArray<Qubit>), Result>>(typeof(Microsoft.Quantum.Primitive.Measure));
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(Result data) => new QTuple<Result>(data);
        public static System.Threading.Tasks.Task<Result> Run(IOperationFactory __m__, QArray<Qubit> register)
        {
            return __m__.Run<MeasureAllZ, QArray<Qubit>, Result>(register);
        }
    }

    public class MeasureIdentity : Operation<QArray<Qubit>, Result>, ICallable
    {
        public MeasureIdentity(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "MeasureIdentity";
        String ICallable.FullName => "Microsoft.Quantum.Canon.MeasureIdentity";
        public override Func<QArray<Qubit>, Result> Body => (__in) =>
        {
            var register = __in;
#line 56 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qcvv\\ProcessTomography.qs"
            return Result.Zero;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(Result data) => new QTuple<Result>(data);
        public static System.Threading.Tasks.Task<Result> Run(IOperationFactory __m__, QArray<Qubit> register)
        {
            return __m__.Run<MeasureIdentity, QArray<Qubit>, Result>(register);
        }
    }

    public class PrepareSingleQubitIdentity : Operation<Qubit, QVoid>, ICallable
    {
        public PrepareSingleQubitIdentity(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "PrepareSingleQubitIdentity";
        String ICallable.FullName => "Microsoft.Quantum.Canon.PrepareSingleQubitIdentity";
        protected IUnitary<(QArray<Pauli>,QArray<Qubit>)> ApplyPauli
        {
            get;
            set;
        }

        protected ICallable<QVoid, Pauli> RandomSingleQubitPauli
        {
            get;
            set;
        }

        public override Func<Qubit, QVoid> Body => (__in) =>
        {
            var qubit = __in;
#line 86 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qcvv\\ProcessTomography.qs"
            ApplyPauli.Apply((new QArray<Pauli>()
            {RandomSingleQubitPauli.Apply(QVoid.Instance)}, new QArray<Qubit>()
            {qubit}));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.ApplyPauli = this.Factory.Get<IUnitary<(QArray<Pauli>,QArray<Qubit>)>>(typeof(Microsoft.Quantum.Canon.ApplyPauli));
            this.RandomSingleQubitPauli = this.Factory.Get<ICallable<QVoid, Pauli>>(typeof(Microsoft.Quantum.Canon.RandomSingleQubitPauli));
        }

        public override IApplyData __dataIn(Qubit data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit qubit)
        {
            return __m__.Run<PrepareSingleQubitIdentity, Qubit, QVoid>(qubit);
        }
    }

    public class PrepareIdentity : Operation<QArray<Qubit>, QVoid>, ICallable
    {
        public PrepareIdentity(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "PrepareIdentity";
        String ICallable.FullName => "Microsoft.Quantum.Canon.PrepareIdentity";
        protected ICallable ApplyToEach
        {
            get;
            set;
        }

        protected ICallable<Qubit, QVoid> PrepareSingleQubitIdentity
        {
            get;
            set;
        }

        public override Func<QArray<Qubit>, QVoid> Body => (__in) =>
        {
            var register = __in;
#line 104 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qcvv\\ProcessTomography.qs"
            ApplyToEach.Apply((((ICallable)PrepareSingleQubitIdentity), register));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.ApplyToEach = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ApplyToEach<>));
            this.PrepareSingleQubitIdentity = this.Factory.Get<ICallable<Qubit, QVoid>>(typeof(Microsoft.Quantum.Canon.PrepareSingleQubitIdentity));
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> register)
        {
            return __m__.Run<PrepareIdentity, QArray<Qubit>, QVoid>(register);
        }
    }

    public class EstimateFrequency : Operation<(ICallable,ICallable,Int64,Int64), Double>, ICallable
    {
        public EstimateFrequency(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(ICallable,ICallable,Int64,Int64)>, IApplyData
        {
            public In((ICallable,ICallable,Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "EstimateFrequency";
        String ICallable.FullName => "Microsoft.Quantum.Canon.EstimateFrequency";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected ICallable ApplyToEach
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<Qubit, QVoid> Reset
        {
            get;
            set;
        }

        protected ICallable<Int64, Double> MicrosoftQuantumExtensionsConvertToDouble
        {
            get;
            set;
        }

        public override Func<(ICallable,ICallable,Int64,Int64), Double> Body => (__in) =>
        {
            var (preparation,measurement,nQubits,nMeasurements) = __in;
#line 137 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qcvv\\ProcessTomography.qs"
            var nUp = 0L;
#line 139 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qcvv\\ProcessTomography.qs"
            foreach (var idxMeasurement in new Range(0L, (nMeasurements - 1L)))
            {
#line 140 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qcvv\\ProcessTomography.qs"
                var register = Allocate.Apply(nQubits);
#line 141 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qcvv\\ProcessTomography.qs"
                preparation.Apply(register);
#line 142 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qcvv\\ProcessTomography.qs"
                var result = measurement.Apply<Result>(register);
#line 143 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qcvv\\ProcessTomography.qs"
                if ((result == Result.Zero))
                {
                    // NB!!!!! This reverses Zero and One to use conventions
                    //         common in the QCVV community. That is confusing
                    //         but is confusing with an actual purpose.
#line 147 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qcvv\\ProcessTomography.qs"
                    nUp = (nUp + 1L);
                }

                // NB: We absolutely must reset here, since preparation()
                //     and measurement() can each use randomness internally.
#line 151 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qcvv\\ProcessTomography.qs"
                ApplyToEach.Apply((((ICallable)Reset), register));
#line hidden
                Release.Apply(register);
            }

#line 155 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qcvv\\ProcessTomography.qs"
            return (MicrosoftQuantumExtensionsConvertToDouble.Apply(nUp) / MicrosoftQuantumExtensionsConvertToDouble.Apply(nMeasurements));
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.ApplyToEach = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ApplyToEach<>));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.Reset = this.Factory.Get<ICallable<Qubit, QVoid>>(typeof(Microsoft.Quantum.Primitive.Reset));
            this.MicrosoftQuantumExtensionsConvertToDouble = this.Factory.Get<ICallable<Int64, Double>>(typeof(Microsoft.Quantum.Extensions.Convert.ToDouble));
        }

        public override IApplyData __dataIn((ICallable,ICallable,Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(Double data) => new QTuple<Double>(data);
        public static System.Threading.Tasks.Task<Double> Run(IOperationFactory __m__, ICallable preparation, ICallable measurement, Int64 nQubits, Int64 nMeasurements)
        {
            return __m__.Run<EstimateFrequency, (ICallable,ICallable,Int64,Int64), Double>((preparation, measurement, nQubits, nMeasurements));
        }
    }

    public class PrepareQubit : Operation<(Pauli,Qubit), QVoid>, ICallable
    {
        public PrepareQubit(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Pauli,Qubit)>, IApplyData
        {
            public In((Pauli,Qubit) data) : base(data)
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

        String ICallable.Name => "PrepareQubit";
        String ICallable.FullName => "Microsoft.Quantum.Canon.PrepareQubit";
        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get;
            set;
        }

        protected ICallable<Qubit, QVoid> PrepareSingleQubitIdentity
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveS
        {
            get;
            set;
        }

        public override Func<(Pauli,Qubit), QVoid> Body => (__in) =>
        {
            var (basis,qubit) = __in;
#line 173 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qcvv\\ProcessTomography.qs"
            if ((basis == Pauli.PauliI))
            {
#line 174 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qcvv\\ProcessTomography.qs"
                PrepareSingleQubitIdentity.Apply(qubit);
            }
            else if ((basis == Pauli.PauliX))
            {
#line 176 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qcvv\\ProcessTomography.qs"
                MicrosoftQuantumPrimitiveH.Apply(qubit);
            }
            else if ((basis == Pauli.PauliY))
            {
#line 178 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qcvv\\ProcessTomography.qs"
                MicrosoftQuantumPrimitiveH.Apply(qubit);
#line 179 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qcvv\\ProcessTomography.qs"
                MicrosoftQuantumPrimitiveS.Apply(qubit);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.PrepareSingleQubitIdentity = this.Factory.Get<ICallable<Qubit, QVoid>>(typeof(Microsoft.Quantum.Canon.PrepareSingleQubitIdentity));
            this.MicrosoftQuantumPrimitiveS = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.S));
        }

        public override IApplyData __dataIn((Pauli,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Pauli basis, Qubit qubit)
        {
            return __m__.Run<PrepareQubit, (Pauli,Qubit), QVoid>((basis, qubit));
        }
    }

    public class PrepareEntangledState : Unitary<(QArray<Qubit>,QArray<Qubit>)>, ICallable
    {
        public PrepareEntangledState(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Qubit>)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "PrepareEntangledState";
        String ICallable.FullName => "Microsoft.Quantum.Canon.PrepareEntangledState";
        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (left,right) = __in;
#line 197 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qcvv\\ProcessTomography.qs"
            if ((left.Count != right.Count))
            {
#line 198 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qcvv\\ProcessTomography.qs"
                throw new ExecutionFailException("Left and right registers must be the same length.");
            }

#line 201 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qcvv\\ProcessTomography.qs"
            foreach (var idxQubit in new Range(0L, (left.Count - 1L)))
            {
#line 202 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qcvv\\ProcessTomography.qs"
                MicrosoftQuantumPrimitiveH.Apply(left[idxQubit]);
#line 203 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qcvv\\ProcessTomography.qs"
                MicrosoftQuantumPrimitiveX.Controlled.Apply((new QArray<Qubit>()
                {left[idxQubit]}, right[idxQubit]));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,QArray<Qubit>), QVoid> AdjointBody => (__in) =>
        {
            var (left,right) = __in;
            if ((left.Count != right.Count))
            {
#line 198 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qcvv\\ProcessTomography.qs"
                throw new ExecutionFailException("Left and right registers must be the same length.");
            }

            foreach (var idxQubit in new Range((0L - ((((left.Count - 1L) - 0L) / 1L) * -(1L))), -(1L), 0L))
            {
                MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Apply((new QArray<Qubit>()
                {left[idxQubit]}, right[idxQubit]));
                MicrosoftQuantumPrimitiveH.Adjoint.Apply(left[idxQubit]);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,QArray<Qubit>)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(left,right)) = __in;
            if ((left.Count != right.Count))
            {
                throw new ExecutionFailException("Left and right registers must be the same length.");
            }

            foreach (var idxQubit in new Range(0L, (left.Count - 1L)))
            {
                MicrosoftQuantumPrimitiveH.Controlled.Apply((controlQubits, left[idxQubit]));
                MicrosoftQuantumPrimitiveX.Controlled.Controlled.Apply((controlQubits, (new QArray<Qubit>()
                {left[idxQubit]}, right[idxQubit])));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,QArray<Qubit>)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,(left,right)) = __in;
            if ((left.Count != right.Count))
            {
                throw new ExecutionFailException("Left and right registers must be the same length.");
            }

            foreach (var idxQubit in new Range((0L - ((((left.Count - 1L) - 0L) / 1L) * -(1L))), -(1L), 0L))
            {
                MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Controlled.Apply((controlQubits, (new QArray<Qubit>()
                {left[idxQubit]}, right[idxQubit])));
                MicrosoftQuantumPrimitiveH.Adjoint.Controlled.Apply((controlQubits, left[idxQubit]));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> left, QArray<Qubit> right)
        {
            return __m__.Run<PrepareEntangledState, (QArray<Qubit>,QArray<Qubit>), QVoid>((left, right));
        }
    }

    public class PrepareChoiState : Operation<(ICallable,QArray<Qubit>,QArray<Qubit>), QVoid>, ICallable
    {
        public PrepareChoiState(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(ICallable,QArray<Qubit>,QArray<Qubit>)>, IApplyData
        {
            public In((ICallable,QArray<Qubit>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "PrepareChoiState";
        String ICallable.FullName => "Microsoft.Quantum.Canon.PrepareChoiState";
        protected IUnitary<(QArray<Qubit>,QArray<Qubit>)> PrepareEntangledState
        {
            get;
            set;
        }

        public override Func<(ICallable,QArray<Qubit>,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (op,reference,target) = __in;
#line 249 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qcvv\\ProcessTomography.qs"
            PrepareEntangledState.Apply((reference, target));
#line 250 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qcvv\\ProcessTomography.qs"
            op.Apply(target);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.PrepareEntangledState = this.Factory.Get<IUnitary<(QArray<Qubit>,QArray<Qubit>)>>(typeof(Microsoft.Quantum.Canon.PrepareEntangledState));
        }

        public override IApplyData __dataIn((ICallable,QArray<Qubit>,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, ICallable op, QArray<Qubit> reference, QArray<Qubit> target)
        {
            return __m__.Run<PrepareChoiState, (ICallable,QArray<Qubit>,QArray<Qubit>), QVoid>((op, reference, target));
        }
    }

    public class PrepareChoiStateC : Controllable<(IControllable,QArray<Qubit>,QArray<Qubit>)>, ICallable
    {
        public PrepareChoiStateC(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IControllable,QArray<Qubit>,QArray<Qubit>)>, IApplyData
        {
            public In((IControllable,QArray<Qubit>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "PrepareChoiStateC";
        String ICallable.FullName => "Microsoft.Quantum.Canon.PrepareChoiStateC";
        protected IUnitary<(QArray<Qubit>,QArray<Qubit>)> PrepareEntangledState
        {
            get;
            set;
        }

        public override Func<(IControllable,QArray<Qubit>,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (op,reference,target) = __in;
#line 261 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qcvv\\ProcessTomography.qs"
            PrepareEntangledState.Apply((reference, target));
#line 262 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qcvv\\ProcessTomography.qs"
            op.Apply(target);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(IControllable,QArray<Qubit>,QArray<Qubit>)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(op,reference,target)) = __in;
            PrepareEntangledState.Controlled.Apply((controlQubits, (reference, target)));
            op.Controlled.Apply((controlQubits, target));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.PrepareEntangledState = this.Factory.Get<IUnitary<(QArray<Qubit>,QArray<Qubit>)>>(typeof(Microsoft.Quantum.Canon.PrepareEntangledState));
        }

        public override IApplyData __dataIn((IControllable,QArray<Qubit>,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IControllable op, QArray<Qubit> reference, QArray<Qubit> target)
        {
            return __m__.Run<PrepareChoiStateC, (IControllable,QArray<Qubit>,QArray<Qubit>), QVoid>((op, reference, target));
        }
    }

    public class PrepareChoiStateA : Adjointable<(IAdjointable,QArray<Qubit>,QArray<Qubit>)>, ICallable
    {
        public PrepareChoiStateA(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IAdjointable,QArray<Qubit>,QArray<Qubit>)>, IApplyData
        {
            public In((IAdjointable,QArray<Qubit>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "PrepareChoiStateA";
        String ICallable.FullName => "Microsoft.Quantum.Canon.PrepareChoiStateA";
        protected IUnitary<(QArray<Qubit>,QArray<Qubit>)> PrepareEntangledState
        {
            get;
            set;
        }

        public override Func<(IAdjointable,QArray<Qubit>,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (op,reference,target) = __in;
#line 275 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qcvv\\ProcessTomography.qs"
            PrepareEntangledState.Apply((reference, target));
#line 276 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qcvv\\ProcessTomography.qs"
            op.Apply(target);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IAdjointable,QArray<Qubit>,QArray<Qubit>), QVoid> AdjointBody => (__in) =>
        {
            var (op,reference,target) = __in;
            op.Adjoint.Apply(target);
            PrepareEntangledState.Adjoint.Apply((reference, target));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.PrepareEntangledState = this.Factory.Get<IUnitary<(QArray<Qubit>,QArray<Qubit>)>>(typeof(Microsoft.Quantum.Canon.PrepareEntangledState));
        }

        public override IApplyData __dataIn((IAdjointable,QArray<Qubit>,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IAdjointable op, QArray<Qubit> reference, QArray<Qubit> target)
        {
            return __m__.Run<PrepareChoiStateA, (IAdjointable,QArray<Qubit>,QArray<Qubit>), QVoid>((op, reference, target));
        }
    }

    public class PrepareChoiStateCA : Unitary<(IUnitary,QArray<Qubit>,QArray<Qubit>)>, ICallable
    {
        public PrepareChoiStateCA(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IUnitary,QArray<Qubit>,QArray<Qubit>)>, IApplyData
        {
            public In((IUnitary,QArray<Qubit>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "PrepareChoiStateCA";
        String ICallable.FullName => "Microsoft.Quantum.Canon.PrepareChoiStateCA";
        protected IUnitary<(QArray<Qubit>,QArray<Qubit>)> PrepareEntangledState
        {
            get;
            set;
        }

        public override Func<(IUnitary,QArray<Qubit>,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (op,reference,target) = __in;
#line 290 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qcvv\\ProcessTomography.qs"
            PrepareEntangledState.Apply((reference, target));
#line 291 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qcvv\\ProcessTomography.qs"
            op.Apply(target);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IUnitary,QArray<Qubit>,QArray<Qubit>), QVoid> AdjointBody => (__in) =>
        {
            var (op,reference,target) = __in;
            op.Adjoint.Apply(target);
            PrepareEntangledState.Adjoint.Apply((reference, target));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(IUnitary,QArray<Qubit>,QArray<Qubit>)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(op,reference,target)) = __in;
            PrepareEntangledState.Controlled.Apply((controlQubits, (reference, target)));
            op.Controlled.Apply((controlQubits, target));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(IUnitary,QArray<Qubit>,QArray<Qubit>)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,(op,reference,target)) = __in;
            op.Adjoint.Controlled.Apply((controlQubits, target));
            PrepareEntangledState.Adjoint.Controlled.Apply((controlQubits, (reference, target)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.PrepareEntangledState = this.Factory.Get<IUnitary<(QArray<Qubit>,QArray<Qubit>)>>(typeof(Microsoft.Quantum.Canon.PrepareEntangledState));
        }

        public override IApplyData __dataIn((IUnitary,QArray<Qubit>,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IUnitary op, QArray<Qubit> reference, QArray<Qubit> target)
        {
            return __m__.Run<PrepareChoiStateCA, (IUnitary,QArray<Qubit>,QArray<Qubit>), QVoid>((op, reference, target));
        }
    }

    public class SingleQubitProcessTomographyMeasurement : Operation<(Pauli,Pauli,ICallable), Result>, ICallable
    {
        public SingleQubitProcessTomographyMeasurement(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Pauli,Pauli,ICallable)>, IApplyData
        {
            public In((Pauli,Pauli,ICallable) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item3)?.Qubits;
        }

        String ICallable.Name => "SingleQubitProcessTomographyMeasurement";
        String ICallable.FullName => "Microsoft.Quantum.Canon.SingleQubitProcessTomographyMeasurement";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected ICallable<(QArray<Pauli>,QArray<Qubit>), Result> Measure
        {
            get;
            set;
        }

        protected ICallable<(Pauli,Qubit), QVoid> PrepareQubit
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<Qubit, QVoid> Reset
        {
            get;
            set;
        }

        public override Func<(Pauli,Pauli,ICallable), Result> Body => (__in) =>
        {
            var (preparation,measurement,channel) = __in;
#line 343 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qcvv\\ProcessTomography.qs"
            var result = Result.Zero;
#line 345 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qcvv\\ProcessTomography.qs"
            var register = Allocate.Apply(1L);
#line 346 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qcvv\\ProcessTomography.qs"
            var qubit = register[0L];
#line 348 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qcvv\\ProcessTomography.qs"
            PrepareQubit.Apply((preparation, qubit));
#line 349 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qcvv\\ProcessTomography.qs"
            channel.Apply(qubit);
#line 350 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qcvv\\ProcessTomography.qs"
            result = Measure.Apply((new QArray<Pauli>()
            {measurement}, new QArray<Qubit>()
            {qubit}));
#line 352 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qcvv\\ProcessTomography.qs"
            Reset.Apply(qubit);
#line hidden
            Release.Apply(register);
#line 355 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qcvv\\ProcessTomography.qs"
            return result;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Measure = this.Factory.Get<ICallable<(QArray<Pauli>,QArray<Qubit>), Result>>(typeof(Microsoft.Quantum.Primitive.Measure));
            this.PrepareQubit = this.Factory.Get<ICallable<(Pauli,Qubit), QVoid>>(typeof(Microsoft.Quantum.Canon.PrepareQubit));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.Reset = this.Factory.Get<ICallable<Qubit, QVoid>>(typeof(Microsoft.Quantum.Primitive.Reset));
        }

        public override IApplyData __dataIn((Pauli,Pauli,ICallable) data) => new In(data);
        public override IApplyData __dataOut(Result data) => new QTuple<Result>(data);
        public static System.Threading.Tasks.Task<Result> Run(IOperationFactory __m__, Pauli preparation, Pauli measurement, ICallable channel)
        {
            return __m__.Run<SingleQubitProcessTomographyMeasurement, (Pauli,Pauli,ICallable), Result>((preparation, measurement, channel));
        }
    }
}