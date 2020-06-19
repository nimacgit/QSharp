#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "FiveQubitCodeEncoderImpl (data : Qubit[], scratch : Qubit[]) : ()", new string[] { "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\5QubitCode.qs", 837L, 21L, 5L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "FiveQubitCodeEncoder (physRegister : Qubit[], auxQubits : Qubit[]) : Microsoft.Quantum.Canon.LogicalRegister", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\5QubitCode.qs", 4482L, 103L, 5L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "FiveQubitCodeDecoder (logicalRegister : Microsoft.Quantum.Canon.LogicalRegister) : (Qubit[], Qubit[])", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\5QubitCode.qs", 5333L, 127L, 5L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "FiveQubitCode () : Microsoft.Quantum.Canon.QECC", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\5QubitCode.qs", 6424L, 151L, 5L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "FiveQubitCodeRecoveryFn () : Microsoft.Quantum.Canon.RecoveryFn", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\5QubitCode.qs", 2825L, 63L, 15L)]
#line hidden
namespace Microsoft.Quantum.Canon
{
    public class FiveQubitCodeEncoderImpl : Adjointable<(QArray<Qubit>,QArray<Qubit>)>, ICallable
    {
        public FiveQubitCodeEncoderImpl(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Qubit>)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "FiveQubitCodeEncoderImpl";
        String ICallable.FullName => "Microsoft.Quantum.Canon.FiveQubitCodeEncoderImpl";
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
            var (data,scratch) = __in;
#line 23 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\5QubitCode.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((data, scratch[1L]));
#line 24 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\5QubitCode.qs"
            MicrosoftQuantumPrimitiveH.Apply(data[0L]);
#line 25 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\5QubitCode.qs"
            MicrosoftQuantumPrimitiveH.Apply(scratch[0L]);
#line 26 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\5QubitCode.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((data, scratch[2L]));
#line 27 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\5QubitCode.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((new QArray<Qubit>()
            {scratch[0L]}, data[0L]));
#line 28 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\5QubitCode.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((data, scratch[1L]));
#line 29 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\5QubitCode.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((new QArray<Qubit>()
            {scratch[0L]}, scratch[3L]));
#line 30 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\5QubitCode.qs"
            MicrosoftQuantumPrimitiveH.Apply(scratch[0L]);
#line 31 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\5QubitCode.qs"
            MicrosoftQuantumPrimitiveH.Apply(data[0L]);
#line 32 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\5QubitCode.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((new QArray<Qubit>()
            {scratch[0L]}, scratch[2L]));
#line 33 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\5QubitCode.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((data, scratch[3L]));
            // The last X below is to correct the signs of stabilizers.
            // The 5-qubit code is non-CSS, so even if the circuit implements
            // the correct symplectic matrix,
            // it may differ from the desired one by a Pauli correction.
#line 38 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\5QubitCode.qs"
            MicrosoftQuantumPrimitiveX.Apply(scratch[2L]);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,QArray<Qubit>), QVoid> AdjointBody => (__in) =>
        {
            var (data,scratch) = __in;
            // The last X below is to correct the signs of stabilizers.
            // The 5-qubit code is non-CSS, so even if the circuit implements
            // the correct symplectic matrix,
            // it may differ from the desired one by a Pauli correction.
            MicrosoftQuantumPrimitiveX.Adjoint.Apply(scratch[2L]);
            MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Apply((data, scratch[3L]));
            MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Apply((new QArray<Qubit>()
            {scratch[0L]}, scratch[2L]));
            MicrosoftQuantumPrimitiveH.Adjoint.Apply(data[0L]);
            MicrosoftQuantumPrimitiveH.Adjoint.Apply(scratch[0L]);
            MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Apply((new QArray<Qubit>()
            {scratch[0L]}, scratch[3L]));
            MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Apply((data, scratch[1L]));
            MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Apply((new QArray<Qubit>()
            {scratch[0L]}, data[0L]));
            MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Apply((data, scratch[2L]));
            MicrosoftQuantumPrimitiveH.Adjoint.Apply(scratch[0L]);
            MicrosoftQuantumPrimitiveH.Adjoint.Apply(data[0L]);
            MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Apply((data, scratch[1L]));
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
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> data, QArray<Qubit> scratch)
        {
            return __m__.Run<FiveQubitCodeEncoderImpl, (QArray<Qubit>,QArray<Qubit>), QVoid>((data, scratch));
        }
    }

    public class FiveQubitCodeRecoveryFn : Operation<QVoid, ICallable>, ICallable
    {
        public FiveQubitCodeRecoveryFn(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "FiveQubitCodeRecoveryFn";
        String ICallable.FullName => "Microsoft.Quantum.Canon.FiveQubitCodeRecoveryFn";
        protected ICallable<QArray<QArray<Pauli>>, ICallable> TableLookupRecovery
        {
            get;
            set;
        }

        public override Func<QVoid, ICallable> Body => (__in) =>
        {
#line 65 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\5QubitCode.qs"
            return TableLookupRecovery.Apply(new QArray<QArray<Pauli>>(new QArray<Pauli>(Pauli.PauliI, Pauli.PauliI, Pauli.PauliI, Pauli.PauliI, Pauli.PauliI), new QArray<Pauli>(Pauli.PauliI, Pauli.PauliX, Pauli.PauliI, Pauli.PauliI, Pauli.PauliI), new QArray<Pauli>(Pauli.PauliI, Pauli.PauliI, Pauli.PauliI, Pauli.PauliI, Pauli.PauliZ), new QArray<Pauli>(Pauli.PauliI, Pauli.PauliI, Pauli.PauliX, Pauli.PauliI, Pauli.PauliI), new QArray<Pauli>(Pauli.PauliI, Pauli.PauliI, Pauli.PauliZ, Pauli.PauliI, Pauli.PauliI), new QArray<Pauli>(Pauli.PauliZ, Pauli.PauliI, Pauli.PauliI, Pauli.PauliI, Pauli.PauliI), new QArray<Pauli>(Pauli.PauliI, Pauli.PauliI, Pauli.PauliI, Pauli.PauliX, Pauli.PauliI), new QArray<Pauli>(Pauli.PauliI, Pauli.PauliI, Pauli.PauliY, Pauli.PauliI, Pauli.PauliI), new QArray<Pauli>(Pauli.PauliX, Pauli.PauliI, Pauli.PauliI, Pauli.PauliI, Pauli.PauliI), new QArray<Pauli>(Pauli.PauliI, Pauli.PauliI, Pauli.PauliI, Pauli.PauliZ, Pauli.PauliI), new QArray<Pauli>(Pauli.PauliI, Pauli.PauliZ, Pauli.PauliI, Pauli.PauliI, Pauli.PauliI), new QArray<Pauli>(Pauli.PauliI, Pauli.PauliY, Pauli.PauliI, Pauli.PauliI, Pauli.PauliI), new QArray<Pauli>(Pauli.PauliI, Pauli.PauliI, Pauli.PauliI, Pauli.PauliI, Pauli.PauliX), new QArray<Pauli>(Pauli.PauliY, Pauli.PauliI, Pauli.PauliI, Pauli.PauliI, Pauli.PauliI), new QArray<Pauli>(Pauli.PauliI, Pauli.PauliI, Pauli.PauliI, Pauli.PauliI, Pauli.PauliY), new QArray<Pauli>(Pauli.PauliI, Pauli.PauliI, Pauli.PauliI, Pauli.PauliY, Pauli.PauliI)));
        }

        ;
        public override void Init()
        {
            this.TableLookupRecovery = this.Factory.Get<ICallable<QArray<QArray<Pauli>>, ICallable>>(typeof(Microsoft.Quantum.Canon.TableLookupRecovery));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(ICallable data) => new QTuple<ICallable>(data);
        public static System.Threading.Tasks.Task<ICallable> Run(IOperationFactory __m__)
        {
            return __m__.Run<FiveQubitCodeRecoveryFn, QVoid, ICallable>(QVoid.Instance);
        }
    }

    public class FiveQubitCodeEncoder : Operation<(QArray<Qubit>,QArray<Qubit>), LogicalRegister>, ICallable
    {
        public FiveQubitCodeEncoder(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Qubit>)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "FiveQubitCodeEncoder";
        String ICallable.FullName => "Microsoft.Quantum.Canon.FiveQubitCodeEncoder";
        protected IAdjointable<(QArray<Qubit>,QArray<Qubit>)> FiveQubitCodeEncoderImpl
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,QArray<Qubit>), LogicalRegister> Body => (__in) =>
        {
            var (physRegister,auxQubits) = __in;
#line 105 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\5QubitCode.qs"
            FiveQubitCodeEncoderImpl.Apply((physRegister, auxQubits));
#line 107 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\5QubitCode.qs"
            var logicalRegister = new LogicalRegister((physRegister + auxQubits));
#line 108 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\5QubitCode.qs"
            return logicalRegister;
        }

        ;
        public override void Init()
        {
            this.FiveQubitCodeEncoderImpl = this.Factory.Get<IAdjointable<(QArray<Qubit>,QArray<Qubit>)>>(typeof(Microsoft.Quantum.Canon.FiveQubitCodeEncoderImpl));
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(LogicalRegister data) => data;
        public static System.Threading.Tasks.Task<LogicalRegister> Run(IOperationFactory __m__, QArray<Qubit> physRegister, QArray<Qubit> auxQubits)
        {
            return __m__.Run<FiveQubitCodeEncoder, (QArray<Qubit>,QArray<Qubit>), LogicalRegister>((physRegister, auxQubits));
        }
    }

    public class FiveQubitCodeDecoder : Operation<LogicalRegister, (QArray<Qubit>,QArray<Qubit>)>, ICallable
    {
        public FiveQubitCodeDecoder(IOperationFactory m) : base(m)
        {
        }

        public class Out : QTuple<(QArray<Qubit>,QArray<Qubit>)>, IApplyData
        {
            public Out((QArray<Qubit>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "FiveQubitCodeDecoder";
        String ICallable.FullName => "Microsoft.Quantum.Canon.FiveQubitCodeDecoder";
        protected IAdjointable<(QArray<Qubit>,QArray<Qubit>)> FiveQubitCodeEncoderImpl
        {
            get;
            set;
        }

        public override Func<LogicalRegister, (QArray<Qubit>,QArray<Qubit>)> Body => (__in) =>
        {
            var logicalRegister = __in;
#line 129 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\5QubitCode.qs"
            var physRegister = new QArray<Qubit>()
            {logicalRegister[0L]};
#line 130 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\5QubitCode.qs"
            var auxQubits = logicalRegister?.Slice(new Range(1L, 4L));
#line 132 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\5QubitCode.qs"
            FiveQubitCodeEncoderImpl.Adjoint.Apply((physRegister, auxQubits));
#line 134 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\5QubitCode.qs"
            return (physRegister, auxQubits);
        }

        ;
        public override void Init()
        {
            this.FiveQubitCodeEncoderImpl = this.Factory.Get<IAdjointable<(QArray<Qubit>,QArray<Qubit>)>>(typeof(Microsoft.Quantum.Canon.FiveQubitCodeEncoderImpl));
        }

        public override IApplyData __dataIn(LogicalRegister data) => data;
        public override IApplyData __dataOut((QArray<Qubit>,QArray<Qubit>) data) => new Out(data);
        public static System.Threading.Tasks.Task<(QArray<Qubit>,QArray<Qubit>)> Run(IOperationFactory __m__, LogicalRegister logicalRegister)
        {
            return __m__.Run<FiveQubitCodeDecoder, LogicalRegister, (QArray<Qubit>,QArray<Qubit>)>(logicalRegister);
        }
    }

    public class FiveQubitCode : Operation<QVoid, QECC>, ICallable
    {
        public FiveQubitCode(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "FiveQubitCode";
        String ICallable.FullName => "Microsoft.Quantum.Canon.FiveQubitCode";
        protected ICallable<LogicalRegister, (QArray<Qubit>,QArray<Qubit>)> FiveQubitCodeDecoder
        {
            get;
            set;
        }

        protected ICallable<(QArray<Qubit>,QArray<Qubit>), LogicalRegister> FiveQubitCodeEncoder
        {
            get;
            set;
        }

        protected ICallable<(QArray<QArray<Pauli>>,LogicalRegister,ICallable), Syndrome> MeasureStabilizerGenerators
        {
            get;
            set;
        }

        protected ICallable<(QArray<Pauli>,QArray<Qubit>), Result> MeasureWithScratch
        {
            get;
            set;
        }

        public override Func<QVoid, QECC> Body => (__in) =>
        {
#line 153 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\5QubitCode.qs"
            var e = new EncodeOp(FiveQubitCodeEncoder);
#line 154 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\5QubitCode.qs"
            var d = new DecodeOp(FiveQubitCodeDecoder);
#line 155 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\5QubitCode.qs"
            var s = new SyndromeMeasOp(MeasureStabilizerGenerators.Partial(new Func<LogicalRegister, (QArray<QArray<Pauli>>,LogicalRegister,ICallable)>((_arg1) => (new QArray<QArray<Pauli>>(new QArray<Pauli>(Pauli.PauliX, Pauli.PauliZ, Pauli.PauliZ, Pauli.PauliX, Pauli.PauliI), new QArray<Pauli>(Pauli.PauliI, Pauli.PauliX, Pauli.PauliZ, Pauli.PauliZ, Pauli.PauliX), new QArray<Pauli>(Pauli.PauliX, Pauli.PauliI, Pauli.PauliX, Pauli.PauliZ, Pauli.PauliZ), new QArray<Pauli>(Pauli.PauliZ, Pauli.PauliX, Pauli.PauliI, Pauli.PauliX, Pauli.PauliZ)), _arg1, ((ICallable)MeasureWithScratch)))));
#line 162 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\5QubitCode.qs"
            var code = new QECC((e, d, s));
#line 163 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\5QubitCode.qs"
            return code;
        }

        ;
        public override void Init()
        {
            this.FiveQubitCodeDecoder = this.Factory.Get<ICallable<LogicalRegister, (QArray<Qubit>,QArray<Qubit>)>>(typeof(Microsoft.Quantum.Canon.FiveQubitCodeDecoder));
            this.FiveQubitCodeEncoder = this.Factory.Get<ICallable<(QArray<Qubit>,QArray<Qubit>), LogicalRegister>>(typeof(Microsoft.Quantum.Canon.FiveQubitCodeEncoder));
            this.MeasureStabilizerGenerators = this.Factory.Get<ICallable<(QArray<QArray<Pauli>>,LogicalRegister,ICallable), Syndrome>>(typeof(Microsoft.Quantum.Canon.MeasureStabilizerGenerators));
            this.MeasureWithScratch = this.Factory.Get<ICallable<(QArray<Pauli>,QArray<Qubit>), Result>>(typeof(Microsoft.Quantum.Canon.MeasureWithScratch));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QECC data) => data;
        public static System.Threading.Tasks.Task<QECC> Run(IOperationFactory __m__)
        {
            return __m__.Run<FiveQubitCode, QVoid, QECC>(QVoid.Instance);
        }
    }
}