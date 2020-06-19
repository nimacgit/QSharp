#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "MeasureStabilizerGenerators (stabilizerGroup : Pauli[][], logicalRegister : Microsoft.Quantum.Canon.LogicalRegister, gadget : ((Pauli[], Qubit[]) => Result)) : Microsoft.Quantum.Canon.Syndrome", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\Utils.qs", 1656L, 43L, 5L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "Recover (code : Microsoft.Quantum.Canon.QECC, fn : Microsoft.Quantum.Canon.RecoveryFn, logicalRegister : Microsoft.Quantum.Canon.LogicalRegister) : ()", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\Utils.qs", 2655L, 70L, 5L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "RecoverCSS (code : Microsoft.Quantum.Canon.CSS, fnX : Microsoft.Quantum.Canon.RecoveryFn, fnZ : Microsoft.Quantum.Canon.RecoveryFn, logicalRegister : Microsoft.Quantum.Canon.LogicalRegister) : ()", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\Utils.qs", 3912L, 102L, 5L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "ResultAsInt (results : Result[]) : Int", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\Utils.qs", 460L, 13L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "TableLookupRecoveryImpl (table : Pauli[][], syndrome : Microsoft.Quantum.Canon.Syndrome) : Pauli[]", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\Utils.qs", 4460L, 116L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "TableLookupRecovery (table : Pauli[][]) : Microsoft.Quantum.Canon.RecoveryFn", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\Utils.qs", 5229L, 133L, 15L)]
#line hidden
namespace Microsoft.Quantum.Canon
{
    public class ResultAsInt : Operation<QArray<Result>, Int64>, ICallable
    {
        public ResultAsInt(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ResultAsInt";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ResultAsInt";
        public override Func<QArray<Result>, Int64> Body => (__in) =>
        {
            var results = __in;
#line 15 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\Utils.qs"
            var n = 0L;
#line 17 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\Utils.qs"
            foreach (var idxResult in new Range(0L, (results.Count - 1L)))
            {
#line 18 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\Utils.qs"
                if ((results[idxResult] == Result.One))
                {
#line 19 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\Utils.qs"
                    n = (n + 2L.Pow(idxResult));
                }
            }

#line 23 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\Utils.qs"
            return n;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(QArray<Result> data) => data;
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, QArray<Result> results)
        {
            return __m__.Run<ResultAsInt, QArray<Result>, Int64>(results);
        }
    }

    public class MeasureStabilizerGenerators : Operation<(QArray<QArray<Pauli>>,LogicalRegister,ICallable), Syndrome>, ICallable
    {
        public MeasureStabilizerGenerators(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<QArray<Pauli>>,LogicalRegister,ICallable)>, IApplyData
        {
            public In((QArray<QArray<Pauli>>,LogicalRegister,ICallable) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "MeasureStabilizerGenerators";
        String ICallable.FullName => "Microsoft.Quantum.Canon.MeasureStabilizerGenerators";
        protected ICallable<(QArray<QArray<Pauli>>,QArray<Qubit>,ICallable), QArray<Result>> MeasurePaulis
        {
            get;
            set;
        }

        public override Func<(QArray<QArray<Pauli>>,LogicalRegister,ICallable), Syndrome> Body => (__in) =>
        {
            var (stabilizerGroup,logicalRegister,gadget) = __in;
#line 45 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\Utils.qs"
            var results = MeasurePaulis.Apply((stabilizerGroup, logicalRegister, ((ICallable)gadget)));
#line 46 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\Utils.qs"
            return new Syndrome(results);
        }

        ;
        public override void Init()
        {
            this.MeasurePaulis = this.Factory.Get<ICallable<(QArray<QArray<Pauli>>,QArray<Qubit>,ICallable), QArray<Result>>>(typeof(Microsoft.Quantum.Canon.MeasurePaulis));
        }

        public override IApplyData __dataIn((QArray<QArray<Pauli>>,LogicalRegister,ICallable) data) => new In(data);
        public override IApplyData __dataOut(Syndrome data) => data;
        public static System.Threading.Tasks.Task<Syndrome> Run(IOperationFactory __m__, QArray<QArray<Pauli>> stabilizerGroup, LogicalRegister logicalRegister, ICallable gadget)
        {
            return __m__.Run<MeasureStabilizerGenerators, (QArray<QArray<Pauli>>,LogicalRegister,ICallable), Syndrome>((stabilizerGroup, logicalRegister, gadget));
        }
    }

    public class Recover : Operation<(QECC,ICallable,LogicalRegister), QVoid>, ICallable
    {
        public Recover(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QECC,ICallable,LogicalRegister)>, IApplyData
        {
            public In((QECC,ICallable,LogicalRegister) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1?.Item1)?.Qubits, ((IApplyData)Data.Item1?.Item2)?.Qubits, ((IApplyData)Data.Item1?.Item3)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "Recover";
        String ICallable.FullName => "Microsoft.Quantum.Canon.Recover";
        protected IUnitary<(QArray<Pauli>,QArray<Qubit>)> ApplyPauli
        {
            get;
            set;
        }

        public override Func<(QECC,ICallable,LogicalRegister), QVoid> Body => (__in) =>
        {
            var (code,fn,logicalRegister) = __in;
#line 72 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\Utils.qs"
            var (encode,decode,syndMeas) = code;
#line 73 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\Utils.qs"
            var syndrome = syndMeas.Apply<Syndrome>(logicalRegister);
#line 74 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\Utils.qs"
            var recoveryOp = fn.Apply<QArray<Pauli>>(syndrome);
#line 75 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\Utils.qs"
            ApplyPauli.Apply((recoveryOp, logicalRegister));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.ApplyPauli = this.Factory.Get<IUnitary<(QArray<Pauli>,QArray<Qubit>)>>(typeof(Microsoft.Quantum.Canon.ApplyPauli));
        }

        public override IApplyData __dataIn((QECC,ICallable,LogicalRegister) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QECC code, ICallable fn, LogicalRegister logicalRegister)
        {
            return __m__.Run<Recover, (QECC,ICallable,LogicalRegister), QVoid>((code, fn, logicalRegister));
        }
    }

    public class RecoverCSS : Operation<(CSS,ICallable,ICallable,LogicalRegister), QVoid>, ICallable
    {
        public RecoverCSS(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(CSS,ICallable,ICallable,LogicalRegister)>, IApplyData
        {
            public In((CSS,ICallable,ICallable,LogicalRegister) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1?.Item1)?.Qubits, ((IApplyData)Data.Item1?.Item2)?.Qubits, ((IApplyData)Data.Item1?.Item3)?.Qubits, ((IApplyData)Data.Item1?.Item4)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits, ((IApplyData)Data.Item4)?.Qubits);
        }

        String ICallable.Name => "RecoverCSS";
        String ICallable.FullName => "Microsoft.Quantum.Canon.RecoverCSS";
        protected IUnitary<(QArray<Pauli>,QArray<Qubit>)> ApplyPauli
        {
            get;
            set;
        }

        protected ICallable<String, QVoid> Message
        {
            get;
            set;
        }

        public override Func<(CSS,ICallable,ICallable,LogicalRegister), QVoid> Body => (__in) =>
        {
            var (code,fnX,fnZ,logicalRegister) = __in;
#line 104 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\Utils.qs"
            var (encode,decode,syndMeasX,syndMeasZ) = code;
#line 105 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\Utils.qs"
            var syndromeX = syndMeasX.Apply<Syndrome>(logicalRegister);
#line 106 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\Utils.qs"
            var recoveryOpX = fnX.Apply<QArray<Pauli>>(syndromeX);
#line 107 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\Utils.qs"
            Message.Apply($"X: {syndromeX} → {recoveryOpX}");
#line 108 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\Utils.qs"
            ApplyPauli.Apply((recoveryOpX, logicalRegister));
#line 109 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\Utils.qs"
            var syndromeZ = syndMeasZ.Apply<Syndrome>(logicalRegister);
#line 110 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\Utils.qs"
            var recoveryOpZ = fnZ.Apply<QArray<Pauli>>(syndromeZ);
#line 111 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\Utils.qs"
            Message.Apply($"Z: {syndromeZ} → {recoveryOpZ}");
#line 112 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\Utils.qs"
            ApplyPauli.Apply((recoveryOpZ, logicalRegister));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.ApplyPauli = this.Factory.Get<IUnitary<(QArray<Pauli>,QArray<Qubit>)>>(typeof(Microsoft.Quantum.Canon.ApplyPauli));
            this.Message = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Primitive.Message));
        }

        public override IApplyData __dataIn((CSS,ICallable,ICallable,LogicalRegister) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, CSS code, ICallable fnX, ICallable fnZ, LogicalRegister logicalRegister)
        {
            return __m__.Run<RecoverCSS, (CSS,ICallable,ICallable,LogicalRegister), QVoid>((code, fnX, fnZ, logicalRegister));
        }
    }

    public class TableLookupRecoveryImpl : Operation<(QArray<QArray<Pauli>>,Syndrome), QArray<Pauli>>, ICallable
    {
        public TableLookupRecoveryImpl(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<QArray<Pauli>>,Syndrome)>, IApplyData
        {
            public In((QArray<QArray<Pauli>>,Syndrome) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "TableLookupRecoveryImpl";
        String ICallable.FullName => "Microsoft.Quantum.Canon.TableLookupRecoveryImpl";
        protected ICallable<QArray<Result>, Int64> ResultAsInt
        {
            get;
            set;
        }

        public override Func<(QArray<QArray<Pauli>>,Syndrome), QArray<Pauli>> Body => (__in) =>
        {
            var (table,syndrome) = __in;
#line 118 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\Utils.qs"
            return table[ResultAsInt.Apply(syndrome)];
        }

        ;
        public override void Init()
        {
            this.ResultAsInt = this.Factory.Get<ICallable<QArray<Result>, Int64>>(typeof(Microsoft.Quantum.Canon.ResultAsInt));
        }

        public override IApplyData __dataIn((QArray<QArray<Pauli>>,Syndrome) data) => new In(data);
        public override IApplyData __dataOut(QArray<Pauli> data) => data;
        public static System.Threading.Tasks.Task<QArray<Pauli>> Run(IOperationFactory __m__, QArray<QArray<Pauli>> table, Syndrome syndrome)
        {
            return __m__.Run<TableLookupRecoveryImpl, (QArray<QArray<Pauli>>,Syndrome), QArray<Pauli>>((table, syndrome));
        }
    }

    public class TableLookupRecovery : Operation<QArray<QArray<Pauli>>, ICallable>, ICallable
    {
        public TableLookupRecovery(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "TableLookupRecovery";
        String ICallable.FullName => "Microsoft.Quantum.Canon.TableLookupRecovery";
        protected ICallable<(QArray<QArray<Pauli>>,Syndrome), QArray<Pauli>> TableLookupRecoveryImpl
        {
            get;
            set;
        }

        public override Func<QArray<QArray<Pauli>>, ICallable> Body => (__in) =>
        {
            var table = __in;
#line 135 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\Utils.qs"
            return new RecoveryFn(TableLookupRecoveryImpl.Partial(new Func<Syndrome, (QArray<QArray<Pauli>>,Syndrome)>((_arg1) => (table, _arg1))));
        }

        ;
        public override void Init()
        {
            this.TableLookupRecoveryImpl = this.Factory.Get<ICallable<(QArray<QArray<Pauli>>,Syndrome), QArray<Pauli>>>(typeof(Microsoft.Quantum.Canon.TableLookupRecoveryImpl));
        }

        public override IApplyData __dataIn(QArray<QArray<Pauli>> data) => data;
        public override IApplyData __dataOut(ICallable data) => new QTuple<ICallable>(data);
        public static System.Threading.Tasks.Task<ICallable> Run(IOperationFactory __m__, QArray<QArray<Pauli>> table)
        {
            return __m__.Run<TableLookupRecovery, QArray<QArray<Pauli>>, ICallable>(table);
        }
    }
}