#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "BFEncoderImpl (coherentRecovery : Bool, data : Qubit[], scratch : Qubit[]) : ()", new string[] { "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\BitFlipCode.qs", 785L, 20L, 5L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "BitFlipEncoder (physRegister : Qubit[], auxQubits : Qubit[]) : Microsoft.Quantum.Canon.LogicalRegister", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\BitFlipCode.qs", 1723L, 49L, 5L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "BitFlipDecoder (logicalRegister : Microsoft.Quantum.Canon.LogicalRegister) : (Qubit[], Qubit[])", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\BitFlipCode.qs", 2497L, 73L, 5L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "BitFlipCode () : Microsoft.Quantum.Canon.QECC", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\BitFlipCode.qs", 3096L, 92L, 5L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "BitFlipRecoveryFn () : Microsoft.Quantum.Canon.RecoveryFn", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\BitFlipCode.qs", 3932L, 116L, 14L)]
#line hidden
namespace Microsoft.Quantum.Canon
{
    public class BFEncoderImpl : Adjointable<(Boolean,QArray<Qubit>,QArray<Qubit>)>, ICallable
    {
        public BFEncoderImpl(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Boolean,QArray<Qubit>,QArray<Qubit>)>, IApplyData
        {
            public In((Boolean,QArray<Qubit>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "BFEncoderImpl";
        String ICallable.FullName => "Microsoft.Quantum.Canon.BFEncoderImpl";
        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(Boolean,QArray<Qubit>,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (coherentRecovery,data,scratch) = __in;
#line 22 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\BitFlipCode.qs"
            if (coherentRecovery)
            {
#line 23 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\BitFlipCode.qs"
                MicrosoftQuantumPrimitiveX.Controlled.Apply((scratch, data[0L]));
            }

#line 25 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\BitFlipCode.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((data, scratch[0L]));
#line 26 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\BitFlipCode.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((data, scratch[1L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Boolean,QArray<Qubit>,QArray<Qubit>), QVoid> AdjointBody => (__in) =>
        {
            var (coherentRecovery,data,scratch) = __in;
            MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Apply((data, scratch[1L]));
            MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Apply((data, scratch[0L]));
            if (coherentRecovery)
            {
                MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Apply((scratch, data[0L]));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((Boolean,QArray<Qubit>,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Boolean coherentRecovery, QArray<Qubit> data, QArray<Qubit> scratch)
        {
            return __m__.Run<BFEncoderImpl, (Boolean,QArray<Qubit>,QArray<Qubit>), QVoid>((coherentRecovery, data, scratch));
        }
    }

    public class BitFlipEncoder : Operation<(QArray<Qubit>,QArray<Qubit>), LogicalRegister>, ICallable
    {
        public BitFlipEncoder(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Qubit>)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "BitFlipEncoder";
        String ICallable.FullName => "Microsoft.Quantum.Canon.BitFlipEncoder";
        protected IAdjointable<(Boolean,QArray<Qubit>,QArray<Qubit>)> BFEncoderImpl
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,QArray<Qubit>), LogicalRegister> Body => (__in) =>
        {
            var (physRegister,auxQubits) = __in;
#line 51 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\BitFlipCode.qs"
            BFEncoderImpl.Apply((false, physRegister, auxQubits));
#line 53 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\BitFlipCode.qs"
            var logicalRegister = new LogicalRegister((physRegister + auxQubits));
#line 54 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\BitFlipCode.qs"
            return logicalRegister;
        }

        ;
        public override void Init()
        {
            this.BFEncoderImpl = this.Factory.Get<IAdjointable<(Boolean,QArray<Qubit>,QArray<Qubit>)>>(typeof(Microsoft.Quantum.Canon.BFEncoderImpl));
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(LogicalRegister data) => data;
        public static System.Threading.Tasks.Task<LogicalRegister> Run(IOperationFactory __m__, QArray<Qubit> physRegister, QArray<Qubit> auxQubits)
        {
            return __m__.Run<BitFlipEncoder, (QArray<Qubit>,QArray<Qubit>), LogicalRegister>((physRegister, auxQubits));
        }
    }

    public class BitFlipDecoder : Operation<LogicalRegister, (QArray<Qubit>,QArray<Qubit>)>, ICallable
    {
        public BitFlipDecoder(IOperationFactory m) : base(m)
        {
        }

        public class Out : QTuple<(QArray<Qubit>,QArray<Qubit>)>, IApplyData
        {
            public Out((QArray<Qubit>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "BitFlipDecoder";
        String ICallable.FullName => "Microsoft.Quantum.Canon.BitFlipDecoder";
        protected IAdjointable<(Boolean,QArray<Qubit>,QArray<Qubit>)> BFEncoderImpl
        {
            get;
            set;
        }

        public override Func<LogicalRegister, (QArray<Qubit>,QArray<Qubit>)> Body => (__in) =>
        {
            var logicalRegister = __in;
#line 75 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\BitFlipCode.qs"
            var physRegister = new QArray<Qubit>()
            {logicalRegister[0L]};
#line 76 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\BitFlipCode.qs"
            var auxQubits = logicalRegister?.Slice(new Range(1L, 2L));
#line 78 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\BitFlipCode.qs"
            BFEncoderImpl.Adjoint.Apply((false, physRegister, auxQubits));
#line 80 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\BitFlipCode.qs"
            return (physRegister, auxQubits);
        }

        ;
        public override void Init()
        {
            this.BFEncoderImpl = this.Factory.Get<IAdjointable<(Boolean,QArray<Qubit>,QArray<Qubit>)>>(typeof(Microsoft.Quantum.Canon.BFEncoderImpl));
        }

        public override IApplyData __dataIn(LogicalRegister data) => data;
        public override IApplyData __dataOut((QArray<Qubit>,QArray<Qubit>) data) => new Out(data);
        public static System.Threading.Tasks.Task<(QArray<Qubit>,QArray<Qubit>)> Run(IOperationFactory __m__, LogicalRegister logicalRegister)
        {
            return __m__.Run<BitFlipDecoder, LogicalRegister, (QArray<Qubit>,QArray<Qubit>)>(logicalRegister);
        }
    }

    public class BitFlipCode : Operation<QVoid, QECC>, ICallable
    {
        public BitFlipCode(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "BitFlipCode";
        String ICallable.FullName => "Microsoft.Quantum.Canon.BitFlipCode";
        protected ICallable<LogicalRegister, (QArray<Qubit>,QArray<Qubit>)> BitFlipDecoder
        {
            get;
            set;
        }

        protected ICallable<(QArray<Qubit>,QArray<Qubit>), LogicalRegister> BitFlipEncoder
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
#line 94 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\BitFlipCode.qs"
            var e = new EncodeOp(BitFlipEncoder);
#line 95 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\BitFlipCode.qs"
            var d = new DecodeOp(BitFlipDecoder);
#line 96 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\BitFlipCode.qs"
            var s = new SyndromeMeasOp(MeasureStabilizerGenerators.Partial(new Func<LogicalRegister, (QArray<QArray<Pauli>>,LogicalRegister,ICallable)>((_arg1) => (new QArray<QArray<Pauli>>(new QArray<Pauli>(Pauli.PauliZ, Pauli.PauliZ, Pauli.PauliI), new QArray<Pauli>(Pauli.PauliI, Pauli.PauliZ, Pauli.PauliZ)), _arg1, ((ICallable)MeasureWithScratch)))));
#line 100 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\BitFlipCode.qs"
            var code = new QECC((e, d, s));
#line 101 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\BitFlipCode.qs"
            return code;
        }

        ;
        public override void Init()
        {
            this.BitFlipDecoder = this.Factory.Get<ICallable<LogicalRegister, (QArray<Qubit>,QArray<Qubit>)>>(typeof(Microsoft.Quantum.Canon.BitFlipDecoder));
            this.BitFlipEncoder = this.Factory.Get<ICallable<(QArray<Qubit>,QArray<Qubit>), LogicalRegister>>(typeof(Microsoft.Quantum.Canon.BitFlipEncoder));
            this.MeasureStabilizerGenerators = this.Factory.Get<ICallable<(QArray<QArray<Pauli>>,LogicalRegister,ICallable), Syndrome>>(typeof(Microsoft.Quantum.Canon.MeasureStabilizerGenerators));
            this.MeasureWithScratch = this.Factory.Get<ICallable<(QArray<Pauli>,QArray<Qubit>), Result>>(typeof(Microsoft.Quantum.Canon.MeasureWithScratch));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QECC data) => data;
        public static System.Threading.Tasks.Task<QECC> Run(IOperationFactory __m__)
        {
            return __m__.Run<BitFlipCode, QVoid, QECC>(QVoid.Instance);
        }
    }

    public class BitFlipRecoveryFn : Operation<QVoid, ICallable>, ICallable
    {
        public BitFlipRecoveryFn(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "BitFlipRecoveryFn";
        String ICallable.FullName => "Microsoft.Quantum.Canon.BitFlipRecoveryFn";
        protected ICallable<QArray<QArray<Pauli>>, ICallable> TableLookupRecovery
        {
            get;
            set;
        }

        public override Func<QVoid, ICallable> Body => (__in) =>
        {
#line 118 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\BitFlipCode.qs"
            return TableLookupRecovery.Apply(new QArray<QArray<Pauli>>(new QArray<Pauli>(Pauli.PauliI, Pauli.PauliI, Pauli.PauliI), new QArray<Pauli>(Pauli.PauliX, Pauli.PauliI, Pauli.PauliI), new QArray<Pauli>(Pauli.PauliI, Pauli.PauliI, Pauli.PauliX), new QArray<Pauli>(Pauli.PauliI, Pauli.PauliX, Pauli.PauliI)));
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
            return __m__.Run<BitFlipRecoveryFn, QVoid, ICallable>(QVoid.Instance);
        }
    }
}