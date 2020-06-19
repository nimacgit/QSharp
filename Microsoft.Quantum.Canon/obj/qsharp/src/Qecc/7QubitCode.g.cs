#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "SteaneCodeEncoderImpl (data : Qubit[], scratch : Qubit[]) : ()", new string[] { "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\7QubitCode.qs", 548L, 17L, 5L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "SteaneCodeEncoder (physRegister : Qubit[], auxQubits : Qubit[]) : Microsoft.Quantum.Canon.LogicalRegister", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\7QubitCode.qs", 4450L, 116L, 5L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "SteaneCodeDecoder (logicalRegister : Microsoft.Quantum.Canon.LogicalRegister) : (Qubit[], Qubit[])", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\7QubitCode.qs", 5993L, 151L, 5L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "SteaneCode () : Microsoft.Quantum.Canon.CSS", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\7QubitCode.qs", 6874L, 174L, 5L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "SteaneCodeRecoveryX (syndrome : Microsoft.Quantum.Canon.Syndrome) : Pauli[]", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\7QubitCode.qs", 2214L, 58L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "SteaneCodeRecoveryZ (syndrome : Microsoft.Quantum.Canon.Syndrome) : Pauli[]", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\7QubitCode.qs", 2738L, 73L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "SteaneCodeRecoveryFns () : (Microsoft.Quantum.Canon.RecoveryFn, Microsoft.Quantum.Canon.RecoveryFn)", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\7QubitCode.qs", 3492L, 94L, 14L)]
#line hidden
namespace Microsoft.Quantum.Canon
{
    public class SteaneCodeEncoderImpl : Adjointable<(QArray<Qubit>,QArray<Qubit>)>, ICallable
    {
        public SteaneCodeEncoderImpl(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Qubit>)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "SteaneCodeEncoderImpl";
        String ICallable.FullName => "Microsoft.Quantum.Canon.SteaneCodeEncoderImpl";
        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveCNOT
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (data,scratch) = __in;
#line 19 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\7QubitCode.qs"
            MicrosoftQuantumPrimitiveH.Apply(scratch[0L]);
#line 20 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\7QubitCode.qs"
            MicrosoftQuantumPrimitiveH.Apply(scratch[2L]);
#line 21 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\7QubitCode.qs"
            MicrosoftQuantumPrimitiveH.Apply(scratch[5L]);
#line 22 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\7QubitCode.qs"
            MicrosoftQuantumPrimitiveCNOT.Apply((data[0L], scratch[4L]));
#line 23 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\7QubitCode.qs"
            MicrosoftQuantumPrimitiveCNOT.Apply((scratch[5L], scratch[1L]));
#line 24 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\7QubitCode.qs"
            MicrosoftQuantumPrimitiveCNOT.Apply((scratch[5L], scratch[3L]));
#line 25 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\7QubitCode.qs"
            MicrosoftQuantumPrimitiveCNOT.Apply((scratch[1L], data[0L]));
#line 26 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\7QubitCode.qs"
            MicrosoftQuantumPrimitiveCNOT.Apply((scratch[2L], scratch[4L]));
#line 27 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\7QubitCode.qs"
            MicrosoftQuantumPrimitiveCNOT.Apply((scratch[0L], scratch[4L]));
#line 28 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\7QubitCode.qs"
            MicrosoftQuantumPrimitiveCNOT.Apply((scratch[4L], scratch[5L]));
#line 29 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\7QubitCode.qs"
            MicrosoftQuantumPrimitiveCNOT.Apply((scratch[2L], scratch[3L]));
#line 30 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\7QubitCode.qs"
            MicrosoftQuantumPrimitiveCNOT.Apply((scratch[0L], scratch[1L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,QArray<Qubit>), QVoid> AdjointBody => (__in) =>
        {
            var (data,scratch) = __in;
            MicrosoftQuantumPrimitiveCNOT.Adjoint.Apply((scratch[0L], scratch[1L]));
            MicrosoftQuantumPrimitiveCNOT.Adjoint.Apply((scratch[2L], scratch[3L]));
            MicrosoftQuantumPrimitiveCNOT.Adjoint.Apply((scratch[4L], scratch[5L]));
            MicrosoftQuantumPrimitiveCNOT.Adjoint.Apply((scratch[0L], scratch[4L]));
            MicrosoftQuantumPrimitiveCNOT.Adjoint.Apply((scratch[2L], scratch[4L]));
            MicrosoftQuantumPrimitiveCNOT.Adjoint.Apply((scratch[1L], data[0L]));
            MicrosoftQuantumPrimitiveCNOT.Adjoint.Apply((scratch[5L], scratch[3L]));
            MicrosoftQuantumPrimitiveCNOT.Adjoint.Apply((scratch[5L], scratch[1L]));
            MicrosoftQuantumPrimitiveCNOT.Adjoint.Apply((data[0L], scratch[4L]));
            MicrosoftQuantumPrimitiveH.Adjoint.Apply(scratch[5L]);
            MicrosoftQuantumPrimitiveH.Adjoint.Apply(scratch[2L]);
            MicrosoftQuantumPrimitiveH.Adjoint.Apply(scratch[0L]);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> data, QArray<Qubit> scratch)
        {
            return __m__.Run<SteaneCodeEncoderImpl, (QArray<Qubit>,QArray<Qubit>), QVoid>((data, scratch));
        }
    }

    public class SteaneCodeRecoveryX : Operation<Syndrome, QArray<Pauli>>, ICallable
    {
        public SteaneCodeRecoveryX(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "SteaneCodeRecoveryX";
        String ICallable.FullName => "Microsoft.Quantum.Canon.SteaneCodeRecoveryX";
        protected ICallable ConstantArray
        {
            get;
            set;
        }

        protected ICallable<(Pauli,Int64,Int64), QArray<Pauli>> EmbedPauli
        {
            get;
            set;
        }

        protected ICallable<QArray<Result>, Int64> ResultAsInt
        {
            get;
            set;
        }

        public override Func<Syndrome, QArray<Pauli>> Body => (__in) =>
        {
            var syndrome = __in;
#line 60 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\7QubitCode.qs"
            var idxQubit = ResultAsInt.Apply(syndrome);
#line 61 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\7QubitCode.qs"
            if ((idxQubit == 0L))
            {
#line 62 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\7QubitCode.qs"
                return ConstantArray.Apply<QArray<Pauli>>((7L, Pauli.PauliI));
            }

#line 64 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\7QubitCode.qs"
            return EmbedPauli.Apply((Pauli.PauliZ, (idxQubit - 1L), 7L));
        }

        ;
        public override void Init()
        {
            this.ConstantArray = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ConstantArray<>));
            this.EmbedPauli = this.Factory.Get<ICallable<(Pauli,Int64,Int64), QArray<Pauli>>>(typeof(Microsoft.Quantum.Canon.EmbedPauli));
            this.ResultAsInt = this.Factory.Get<ICallable<QArray<Result>, Int64>>(typeof(Microsoft.Quantum.Canon.ResultAsInt));
        }

        public override IApplyData __dataIn(Syndrome data) => data;
        public override IApplyData __dataOut(QArray<Pauli> data) => data;
        public static System.Threading.Tasks.Task<QArray<Pauli>> Run(IOperationFactory __m__, Syndrome syndrome)
        {
            return __m__.Run<SteaneCodeRecoveryX, Syndrome, QArray<Pauli>>(syndrome);
        }
    }

    public class SteaneCodeRecoveryZ : Operation<Syndrome, QArray<Pauli>>, ICallable
    {
        public SteaneCodeRecoveryZ(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "SteaneCodeRecoveryZ";
        String ICallable.FullName => "Microsoft.Quantum.Canon.SteaneCodeRecoveryZ";
        protected ICallable ConstantArray
        {
            get;
            set;
        }

        protected ICallable<(Pauli,Int64,Int64), QArray<Pauli>> EmbedPauli
        {
            get;
            set;
        }

        protected ICallable<QArray<Result>, Int64> ResultAsInt
        {
            get;
            set;
        }

        public override Func<Syndrome, QArray<Pauli>> Body => (__in) =>
        {
            var syndrome = __in;
#line 75 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\7QubitCode.qs"
            var idxQubit = ResultAsInt.Apply(syndrome);
#line 76 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\7QubitCode.qs"
            if ((idxQubit == 0L))
            {
#line 77 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\7QubitCode.qs"
                return ConstantArray.Apply<QArray<Pauli>>((7L, Pauli.PauliI));
            }

#line 79 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\7QubitCode.qs"
            return EmbedPauli.Apply((Pauli.PauliX, (idxQubit - 1L), 7L));
        }

        ;
        public override void Init()
        {
            this.ConstantArray = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ConstantArray<>));
            this.EmbedPauli = this.Factory.Get<ICallable<(Pauli,Int64,Int64), QArray<Pauli>>>(typeof(Microsoft.Quantum.Canon.EmbedPauli));
            this.ResultAsInt = this.Factory.Get<ICallable<QArray<Result>, Int64>>(typeof(Microsoft.Quantum.Canon.ResultAsInt));
        }

        public override IApplyData __dataIn(Syndrome data) => data;
        public override IApplyData __dataOut(QArray<Pauli> data) => data;
        public static System.Threading.Tasks.Task<QArray<Pauli>> Run(IOperationFactory __m__, Syndrome syndrome)
        {
            return __m__.Run<SteaneCodeRecoveryZ, Syndrome, QArray<Pauli>>(syndrome);
        }
    }

    public class SteaneCodeRecoveryFns : Operation<QVoid, (ICallable,ICallable)>, ICallable
    {
        public SteaneCodeRecoveryFns(IOperationFactory m) : base(m)
        {
        }

        public class Out : QTuple<(ICallable,ICallable)>, IApplyData
        {
            public Out((ICallable,ICallable) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "SteaneCodeRecoveryFns";
        String ICallable.FullName => "Microsoft.Quantum.Canon.SteaneCodeRecoveryFns";
        protected ICallable<Syndrome, QArray<Pauli>> SteaneCodeRecoveryX
        {
            get;
            set;
        }

        protected ICallable<Syndrome, QArray<Pauli>> SteaneCodeRecoveryZ
        {
            get;
            set;
        }

        public override Func<QVoid, (ICallable,ICallable)> Body => (__in) =>
        {
#line 95 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\7QubitCode.qs"
            return (new RecoveryFn(SteaneCodeRecoveryX), new RecoveryFn(SteaneCodeRecoveryZ));
        }

        ;
        public override void Init()
        {
            this.SteaneCodeRecoveryX = this.Factory.Get<ICallable<Syndrome, QArray<Pauli>>>(typeof(Microsoft.Quantum.Canon.SteaneCodeRecoveryX));
            this.SteaneCodeRecoveryZ = this.Factory.Get<ICallable<Syndrome, QArray<Pauli>>>(typeof(Microsoft.Quantum.Canon.SteaneCodeRecoveryZ));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut((ICallable,ICallable) data) => new Out(data);
        public static System.Threading.Tasks.Task<(ICallable,ICallable)> Run(IOperationFactory __m__)
        {
            return __m__.Run<SteaneCodeRecoveryFns, QVoid, (ICallable,ICallable)>(QVoid.Instance);
        }
    }

    public class SteaneCodeEncoder : Operation<(QArray<Qubit>,QArray<Qubit>), LogicalRegister>, ICallable
    {
        public SteaneCodeEncoder(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Qubit>)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "SteaneCodeEncoder";
        String ICallable.FullName => "Microsoft.Quantum.Canon.SteaneCodeEncoder";
        protected IAdjointable<(QArray<Qubit>,QArray<Qubit>)> SteaneCodeEncoderImpl
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,QArray<Qubit>), LogicalRegister> Body => (__in) =>
        {
            var (physRegister,auxQubits) = __in;
#line 118 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\7QubitCode.qs"
            SteaneCodeEncoderImpl.Apply((physRegister, auxQubits));
#line 120 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\7QubitCode.qs"
            var logicalRegister = new LogicalRegister((physRegister + auxQubits));
#line 121 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\7QubitCode.qs"
            return logicalRegister;
        }

        ;
        public override void Init()
        {
            this.SteaneCodeEncoderImpl = this.Factory.Get<IAdjointable<(QArray<Qubit>,QArray<Qubit>)>>(typeof(Microsoft.Quantum.Canon.SteaneCodeEncoderImpl));
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(LogicalRegister data) => data;
        public static System.Threading.Tasks.Task<LogicalRegister> Run(IOperationFactory __m__, QArray<Qubit> physRegister, QArray<Qubit> auxQubits)
        {
            return __m__.Run<SteaneCodeEncoder, (QArray<Qubit>,QArray<Qubit>), LogicalRegister>((physRegister, auxQubits));
        }
    }

    public class SteaneCodeDecoder : Operation<LogicalRegister, (QArray<Qubit>,QArray<Qubit>)>, ICallable
    {
        public SteaneCodeDecoder(IOperationFactory m) : base(m)
        {
        }

        public class Out : QTuple<(QArray<Qubit>,QArray<Qubit>)>, IApplyData
        {
            public Out((QArray<Qubit>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "SteaneCodeDecoder";
        String ICallable.FullName => "Microsoft.Quantum.Canon.SteaneCodeDecoder";
        protected IAdjointable<(QArray<Qubit>,QArray<Qubit>)> SteaneCodeEncoderImpl
        {
            get;
            set;
        }

        public override Func<LogicalRegister, (QArray<Qubit>,QArray<Qubit>)> Body => (__in) =>
        {
            var logicalRegister = __in;
#line 153 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\7QubitCode.qs"
            var physRegister = new QArray<Qubit>()
            {logicalRegister[0L]};
#line 154 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\7QubitCode.qs"
            var auxQubits = logicalRegister?.Slice(new Range(1L, 6L));
#line 156 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\7QubitCode.qs"
            SteaneCodeEncoderImpl.Adjoint.Apply((physRegister, auxQubits));
#line 158 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\7QubitCode.qs"
            return (physRegister, auxQubits);
        }

        ;
        public override void Init()
        {
            this.SteaneCodeEncoderImpl = this.Factory.Get<IAdjointable<(QArray<Qubit>,QArray<Qubit>)>>(typeof(Microsoft.Quantum.Canon.SteaneCodeEncoderImpl));
        }

        public override IApplyData __dataIn(LogicalRegister data) => data;
        public override IApplyData __dataOut((QArray<Qubit>,QArray<Qubit>) data) => new Out(data);
        public static System.Threading.Tasks.Task<(QArray<Qubit>,QArray<Qubit>)> Run(IOperationFactory __m__, LogicalRegister logicalRegister)
        {
            return __m__.Run<SteaneCodeDecoder, LogicalRegister, (QArray<Qubit>,QArray<Qubit>)>(logicalRegister);
        }
    }

    public class SteaneCode : Operation<QVoid, CSS>, ICallable
    {
        public SteaneCode(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "SteaneCode";
        String ICallable.FullName => "Microsoft.Quantum.Canon.SteaneCode";
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

        protected ICallable<LogicalRegister, (QArray<Qubit>,QArray<Qubit>)> SteaneCodeDecoder
        {
            get;
            set;
        }

        protected ICallable<(QArray<Qubit>,QArray<Qubit>), LogicalRegister> SteaneCodeEncoder
        {
            get;
            set;
        }

        public override Func<QVoid, CSS> Body => (__in) =>
        {
#line 176 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\7QubitCode.qs"
            var e = new EncodeOp(SteaneCodeEncoder);
#line 177 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\7QubitCode.qs"
            var d = new DecodeOp(SteaneCodeDecoder);
#line 178 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\7QubitCode.qs"
            var sx = new SyndromeMeasOp(MeasureStabilizerGenerators.Partial(new Func<LogicalRegister, (QArray<QArray<Pauli>>,LogicalRegister,ICallable)>((_arg1) => (new QArray<QArray<Pauli>>(new QArray<Pauli>(Pauli.PauliX, Pauli.PauliI, Pauli.PauliX, Pauli.PauliI, Pauli.PauliX, Pauli.PauliI, Pauli.PauliX), new QArray<Pauli>(Pauli.PauliI, Pauli.PauliX, Pauli.PauliX, Pauli.PauliI, Pauli.PauliI, Pauli.PauliX, Pauli.PauliX), new QArray<Pauli>(Pauli.PauliI, Pauli.PauliI, Pauli.PauliI, Pauli.PauliX, Pauli.PauliX, Pauli.PauliX, Pauli.PauliX)), _arg1, ((ICallable)MeasureWithScratch)))));
#line 184 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\7QubitCode.qs"
            var sz = new SyndromeMeasOp(MeasureStabilizerGenerators.Partial(new Func<LogicalRegister, (QArray<QArray<Pauli>>,LogicalRegister,ICallable)>((_arg2) => (new QArray<QArray<Pauli>>(new QArray<Pauli>(Pauli.PauliZ, Pauli.PauliI, Pauli.PauliZ, Pauli.PauliI, Pauli.PauliZ, Pauli.PauliI, Pauli.PauliZ), new QArray<Pauli>(Pauli.PauliI, Pauli.PauliZ, Pauli.PauliZ, Pauli.PauliI, Pauli.PauliI, Pauli.PauliZ, Pauli.PauliZ), new QArray<Pauli>(Pauli.PauliI, Pauli.PauliI, Pauli.PauliI, Pauli.PauliZ, Pauli.PauliZ, Pauli.PauliZ, Pauli.PauliZ)), _arg2, ((ICallable)MeasureWithScratch)))));
#line 190 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\7QubitCode.qs"
            var code = new CSS((e, d, sx, sz));
#line 191 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\7QubitCode.qs"
            return code;
        }

        ;
        public override void Init()
        {
            this.MeasureStabilizerGenerators = this.Factory.Get<ICallable<(QArray<QArray<Pauli>>,LogicalRegister,ICallable), Syndrome>>(typeof(Microsoft.Quantum.Canon.MeasureStabilizerGenerators));
            this.MeasureWithScratch = this.Factory.Get<ICallable<(QArray<Pauli>,QArray<Qubit>), Result>>(typeof(Microsoft.Quantum.Canon.MeasureWithScratch));
            this.SteaneCodeDecoder = this.Factory.Get<ICallable<LogicalRegister, (QArray<Qubit>,QArray<Qubit>)>>(typeof(Microsoft.Quantum.Canon.SteaneCodeDecoder));
            this.SteaneCodeEncoder = this.Factory.Get<ICallable<(QArray<Qubit>,QArray<Qubit>), LogicalRegister>>(typeof(Microsoft.Quantum.Canon.SteaneCodeEncoder));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(CSS data) => data;
        public static System.Threading.Tasks.Task<CSS> Run(IOperationFactory __m__)
        {
            return __m__.Run<SteaneCode, QVoid, CSS>(QVoid.Instance);
        }
    }
}