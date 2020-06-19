#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "MeasureWithScratch (pauli : Pauli[], target : Qubit[]) : Result", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs", 719L, 23L, 5L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "RandomSingleQubitPauli () : Pauli", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs", 2014L, 62L, 48L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "ApplyPauli (pauli : Pauli[], target : Qubit[]) : ()", new string[] { "Controlled", "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs", 2901L, 91L, 5L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "ApplyPauliFromBitString (pauli : Pauli, bitApply : Bool, bits : Bool[], qubits : Qubit[]) : ()", new string[] { "Controlled", "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs", 5233L, 163L, 5L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "MeasurePaulis (paulis : Pauli[][], target : Qubit[], gadget : ((Pauli[], Qubit[]) => Result)) : Result[]", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs", 6402L, 195L, 5L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "_BasisChangeZtoY (target : Qubit) : ()", new string[] { "Controlled", "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs", 8852L, 268L, 53L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "MultiM (targets : Qubit[]) : Result[]", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs", 9304L, 286L, 5L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "MResetZ (target : Qubit) : Result", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs", 9954L, 307L, 48L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "MResetX (target : Qubit) : Result", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs", 10754L, 331L, 48L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "MResetY (target : Qubit) : Result", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs", 11661L, 357L, 48L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "HY (target : Qubit) : ()", new string[] { "Controlled", "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs", 12723L, 391L, 39L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "PauliFromBitString (pauli : Pauli, bitApply : Bool, bits : Bool[]) : Pauli[]", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs", 4024L, 130L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "EmbedPauli (pauli : Pauli, location : Int, n : Int) : Pauli[]", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs", 7396L, 226L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "WeightOnePaulis (nQubits : Int) : Pauli[][]", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs", 8290L, 254L, 14L)]
#line hidden
namespace Microsoft.Quantum.Canon
{
    public class MeasureWithScratch : Operation<(QArray<Pauli>,QArray<Qubit>), Result>, ICallable
    {
        public MeasureWithScratch(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Pauli>,QArray<Qubit>)>, IApplyData
        {
            public In((QArray<Pauli>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "MeasureWithScratch";
        String ICallable.FullName => "Microsoft.Quantum.Canon.MeasureWithScratch";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> M
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

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveY
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveZ
        {
            get;
            set;
        }

        public override Func<(QArray<Pauli>,QArray<Qubit>), Result> Body => (__in) =>
        {
            var (pauli,target) = __in;
#line 25 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
            var result = Result.Zero;
#line 27 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
            var scratchRegister = Allocate.Apply(1L);
#line 28 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
            var scratch = scratchRegister[0L];
#line 29 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
            MicrosoftQuantumPrimitiveH.Apply(scratch);
#line 30 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
            foreach (var idxPauli in new Range(0L, (pauli.Count - 1L)))
            {
#line 31 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
                var P = pauli[idxPauli];
#line 32 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
                var src = target[idxPauli];
#line 34 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
                if ((P == Pauli.PauliX))
                {
#line 35 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
                    MicrosoftQuantumPrimitiveX.Controlled.Apply((new QArray<Qubit>()
                    {scratch}, src));
                }
                else if ((P == Pauli.PauliY))
                {
#line 37 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
                    MicrosoftQuantumPrimitiveY.Controlled.Apply((new QArray<Qubit>()
                    {scratch}, src));
                }
                else if ((P == Pauli.PauliZ))
                {
#line 39 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
                    MicrosoftQuantumPrimitiveZ.Controlled.Apply((new QArray<Qubit>()
                    {scratch}, src));
                }
            }

#line 42 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
            MicrosoftQuantumPrimitiveH.Apply(scratch);
#line 43 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
            result = M.Apply(scratch);
#line 45 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
            ResetAll.Apply(scratchRegister);
#line hidden
            Release.Apply(scratchRegister);
#line 48 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
            return result;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
            this.MicrosoftQuantumPrimitiveY = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.Y));
            this.MicrosoftQuantumPrimitiveZ = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.Z));
        }

        public override IApplyData __dataIn((QArray<Pauli>,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(Result data) => new QTuple<Result>(data);
        public static System.Threading.Tasks.Task<Result> Run(IOperationFactory __m__, QArray<Pauli> pauli, QArray<Qubit> target)
        {
            return __m__.Run<MeasureWithScratch, (QArray<Pauli>,QArray<Qubit>), Result>((pauli, target));
        }
    }

    public class RandomSingleQubitPauli : Operation<QVoid, Pauli>, ICallable
    {
        public RandomSingleQubitPauli(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "RandomSingleQubitPauli";
        String ICallable.FullName => "Microsoft.Quantum.Canon.RandomSingleQubitPauli";
        protected ICallable<QArray<Double>, Int64> Random
        {
            get;
            set;
        }

        public override Func<QVoid, Pauli> Body => (__in) =>
        {
#line 64 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
            var probs = new QArray<Double>(0.5D, 0.5D, 0.5D, 0.5D);
#line 65 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
            var idxPauli = Random.Apply(probs);
#line 66 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
            var singleQubitPaulis = new QArray<Pauli>(Pauli.PauliI, Pauli.PauliX, Pauli.PauliY, Pauli.PauliZ);
#line 67 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
            return singleQubitPaulis[idxPauli];
        }

        ;
        public override void Init()
        {
            this.Random = this.Factory.Get<ICallable<QArray<Double>, Int64>>(typeof(Microsoft.Quantum.Primitive.Random));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(Pauli data) => new QTuple<Pauli>(data);
        public static System.Threading.Tasks.Task<Pauli> Run(IOperationFactory __m__)
        {
            return __m__.Run<RandomSingleQubitPauli, QVoid, Pauli>(QVoid.Instance);
        }
    }

    public class ApplyPauli : Unitary<(QArray<Pauli>,QArray<Qubit>)>, ICallable
    {
        public ApplyPauli(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Pauli>,QArray<Qubit>)>, IApplyData
        {
            public In((QArray<Pauli>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "ApplyPauli";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ApplyPauli";
        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveY
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveZ
        {
            get;
            set;
        }

        public override Func<(QArray<Pauli>,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (pauli,target) = __in;
#line 93 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
            foreach (var idxPauli in new Range(0L, (pauli.Count - 1L)))
            {
#line 94 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
                var P = pauli[idxPauli];
#line 95 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
                var targ = target[idxPauli];
#line 97 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
                if ((P == Pauli.PauliX))
                {
#line 98 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
                    MicrosoftQuantumPrimitiveX.Apply(targ);
                }
                else if ((P == Pauli.PauliY))
                {
#line 101 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
                    MicrosoftQuantumPrimitiveY.Apply(targ);
                }
                else if ((P == Pauli.PauliZ))
                {
#line 104 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
                    MicrosoftQuantumPrimitiveZ.Apply(targ);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Pauli>,QArray<Qubit>), QVoid> AdjointBody => (__in) =>
        {
            var (pauli,target) = __in;
            foreach (var idxPauli in new Range((0L - ((((pauli.Count - 1L) - 0L) / 1L) * -(1L))), -(1L), 0L))
            {
#line 94 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
                var P = pauli[idxPauli];
#line 95 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
                var targ = target[idxPauli];
                if ((P == Pauli.PauliX))
                {
                    MicrosoftQuantumPrimitiveX.Adjoint.Apply(targ);
                }
                else if ((P == Pauli.PauliY))
                {
                    MicrosoftQuantumPrimitiveY.Adjoint.Apply(targ);
                }
                else if ((P == Pauli.PauliZ))
                {
                    MicrosoftQuantumPrimitiveZ.Adjoint.Apply(targ);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Pauli>,QArray<Qubit>)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(pauli,target)) = __in;
            foreach (var idxPauli in new Range(0L, (pauli.Count - 1L)))
            {
                var P = pauli[idxPauli];
                var targ = target[idxPauli];
                if ((P == Pauli.PauliX))
                {
                    MicrosoftQuantumPrimitiveX.Controlled.Apply((controlQubits, targ));
                }
                else if ((P == Pauli.PauliY))
                {
                    MicrosoftQuantumPrimitiveY.Controlled.Apply((controlQubits, targ));
                }
                else if ((P == Pauli.PauliZ))
                {
                    MicrosoftQuantumPrimitiveZ.Controlled.Apply((controlQubits, targ));
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Pauli>,QArray<Qubit>)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,(pauli,target)) = __in;
            foreach (var idxPauli in new Range((0L - ((((pauli.Count - 1L) - 0L) / 1L) * -(1L))), -(1L), 0L))
            {
                var P = pauli[idxPauli];
                var targ = target[idxPauli];
                if ((P == Pauli.PauliX))
                {
                    MicrosoftQuantumPrimitiveX.Adjoint.Controlled.Apply((controlQubits, targ));
                }
                else if ((P == Pauli.PauliY))
                {
                    MicrosoftQuantumPrimitiveY.Adjoint.Controlled.Apply((controlQubits, targ));
                }
                else if ((P == Pauli.PauliZ))
                {
                    MicrosoftQuantumPrimitiveZ.Adjoint.Controlled.Apply((controlQubits, targ));
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
            this.MicrosoftQuantumPrimitiveY = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.Y));
            this.MicrosoftQuantumPrimitiveZ = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.Z));
        }

        public override IApplyData __dataIn((QArray<Pauli>,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Pauli> pauli, QArray<Qubit> target)
        {
            return __m__.Run<ApplyPauli, (QArray<Pauli>,QArray<Qubit>), QVoid>((pauli, target));
        }
    }

    public class PauliFromBitString : Operation<(Pauli,Boolean,QArray<Boolean>), QArray<Pauli>>, ICallable
    {
        public PauliFromBitString(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Pauli,Boolean,QArray<Boolean>)>, IApplyData
        {
            public In((Pauli,Boolean,QArray<Boolean>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "PauliFromBitString";
        String ICallable.FullName => "Microsoft.Quantum.Canon.PauliFromBitString";
        public override Func<(Pauli,Boolean,QArray<Boolean>), QArray<Pauli>> Body => (__in) =>
        {
            var (pauli,bitApply,bits) = __in;
#line 131 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
            var nBits = bits.Count;
#line 132 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
            var paulis = new QArray<Pauli>(nBits);
#line 134 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
            foreach (var idxBit in new Range(0L, (nBits - 1L)))
            {
#line 135 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
                if ((bits[idxBit] == bitApply))
                {
#line 136 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
                    paulis[idxBit] = pauli;
                }
                else
                {
#line 138 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
                    paulis[idxBit] = Pauli.PauliI;
                }
            }

#line 142 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
            return paulis;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((Pauli,Boolean,QArray<Boolean>) data) => new In(data);
        public override IApplyData __dataOut(QArray<Pauli> data) => data;
        public static System.Threading.Tasks.Task<QArray<Pauli>> Run(IOperationFactory __m__, Pauli pauli, Boolean bitApply, QArray<Boolean> bits)
        {
            return __m__.Run<PauliFromBitString, (Pauli,Boolean,QArray<Boolean>), QArray<Pauli>>((pauli, bitApply, bits));
        }
    }

    public class ApplyPauliFromBitString : Unitary<(Pauli,Boolean,QArray<Boolean>,QArray<Qubit>)>, ICallable
    {
        public ApplyPauliFromBitString(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Pauli,Boolean,QArray<Boolean>,QArray<Qubit>)>, IApplyData
        {
            public In((Pauli,Boolean,QArray<Boolean>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item4)?.Qubits;
        }

        String ICallable.Name => "ApplyPauliFromBitString";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ApplyPauliFromBitString";
        protected IUnitary<(QArray<Pauli>,QArray<Qubit>)> ApplyPauli
        {
            get;
            set;
        }

        public override Func<(Pauli,Boolean,QArray<Boolean>,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (pauli,bitApply,bits,qubits) = __in;
#line 165 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
            var nBits = bits.Count;
            //FailOn (nbits != Length(qubits), "Number of control bits must be equal to number of control qubits")
#line 168 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
            foreach (var idxBit in new Range(0L, (nBits - 1L)))
            {
#line 169 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
                if ((bits[idxBit] == bitApply))
                {
#line 170 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
                    ApplyPauli.Apply((new QArray<Pauli>()
                    {pauli}, new QArray<Qubit>()
                    {qubits[idxBit]}));
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Pauli,Boolean,QArray<Boolean>,QArray<Qubit>), QVoid> AdjointBody => (__in) =>
        {
            var (pauli,bitApply,bits,qubits) = __in;
#line 165 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
            var nBits = bits.Count;
            //FailOn (nbits != Length(qubits), "Number of control bits must be equal to number of control qubits")
            foreach (var idxBit in new Range((0L - ((((nBits - 1L) - 0L) / 1L) * -(1L))), -(1L), 0L))
            {
                if ((bits[idxBit] == bitApply))
                {
                    ApplyPauli.Adjoint.Apply((new QArray<Pauli>()
                    {pauli}, new QArray<Qubit>()
                    {qubits[idxBit]}));
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Pauli,Boolean,QArray<Boolean>,QArray<Qubit>)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(pauli,bitApply,bits,qubits)) = __in;
            var nBits = bits.Count;
            //FailOn (nbits != Length(qubits), "Number of control bits must be equal to number of control qubits")
            foreach (var idxBit in new Range(0L, (nBits - 1L)))
            {
                if ((bits[idxBit] == bitApply))
                {
                    ApplyPauli.Controlled.Apply((controlQubits, (new QArray<Pauli>()
                    {pauli}, new QArray<Qubit>()
                    {qubits[idxBit]})));
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Pauli,Boolean,QArray<Boolean>,QArray<Qubit>)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,(pauli,bitApply,bits,qubits)) = __in;
            var nBits = bits.Count;
            //FailOn (nbits != Length(qubits), "Number of control bits must be equal to number of control qubits")
            foreach (var idxBit in new Range((0L - ((((nBits - 1L) - 0L) / 1L) * -(1L))), -(1L), 0L))
            {
                if ((bits[idxBit] == bitApply))
                {
                    ApplyPauli.Adjoint.Controlled.Apply((controlQubits, (new QArray<Pauli>()
                    {pauli}, new QArray<Qubit>()
                    {qubits[idxBit]})));
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.ApplyPauli = this.Factory.Get<IUnitary<(QArray<Pauli>,QArray<Qubit>)>>(typeof(Microsoft.Quantum.Canon.ApplyPauli));
        }

        public override IApplyData __dataIn((Pauli,Boolean,QArray<Boolean>,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Pauli pauli, Boolean bitApply, QArray<Boolean> bits, QArray<Qubit> qubits)
        {
            return __m__.Run<ApplyPauliFromBitString, (Pauli,Boolean,QArray<Boolean>,QArray<Qubit>), QVoid>((pauli, bitApply, bits, qubits));
        }
    }

    public class MeasurePaulis : Operation<(QArray<QArray<Pauli>>,QArray<Qubit>,ICallable), QArray<Result>>, ICallable
    {
        public MeasurePaulis(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<QArray<Pauli>>,QArray<Qubit>,ICallable)>, IApplyData
        {
            public In((QArray<QArray<Pauli>>,QArray<Qubit>,ICallable) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "MeasurePaulis";
        String ICallable.FullName => "Microsoft.Quantum.Canon.MeasurePaulis";
        public override Func<(QArray<QArray<Pauli>>,QArray<Qubit>,ICallable), QArray<Result>> Body => (__in) =>
        {
            var (paulis,target,gadget) = __in;
#line 197 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
            var results = new QArray<Result>(paulis.Count);
#line 199 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
            foreach (var idxPauli in new Range(0L, (paulis.Count - 1L)))
            {
#line 200 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
                results[idxPauli] = gadget.Apply<Result>((paulis[idxPauli], target));
            }

#line 203 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
            return results;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((QArray<QArray<Pauli>>,QArray<Qubit>,ICallable) data) => new In(data);
        public override IApplyData __dataOut(QArray<Result> data) => data;
        public static System.Threading.Tasks.Task<QArray<Result>> Run(IOperationFactory __m__, QArray<QArray<Pauli>> paulis, QArray<Qubit> target, ICallable gadget)
        {
            return __m__.Run<MeasurePaulis, (QArray<QArray<Pauli>>,QArray<Qubit>,ICallable), QArray<Result>>((paulis, target, gadget));
        }
    }

    public class EmbedPauli : Operation<(Pauli,Int64,Int64), QArray<Pauli>>, ICallable
    {
        public EmbedPauli(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Pauli,Int64,Int64)>, IApplyData
        {
            public In((Pauli,Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "EmbedPauli";
        String ICallable.FullName => "Microsoft.Quantum.Canon.EmbedPauli";
        public override Func<(Pauli,Int64,Int64), QArray<Pauli>> Body => (__in) =>
        {
            var (pauli,location,n) = __in;
#line 228 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
            var pauliArray = new QArray<Pauli>(n);
#line 229 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
            foreach (var index in new Range(0L, (n - 1L)))
            {
#line 230 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
                if ((index == location))
                {
#line 231 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
                    pauliArray[index] = pauli;
                }
                else
                {
#line 234 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
                    pauliArray[index] = Pauli.PauliI;
                }
            }

#line 237 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
            return pauliArray;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((Pauli,Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(QArray<Pauli> data) => data;
        public static System.Threading.Tasks.Task<QArray<Pauli>> Run(IOperationFactory __m__, Pauli pauli, Int64 location, Int64 n)
        {
            return __m__.Run<EmbedPauli, (Pauli,Int64,Int64), QArray<Pauli>>((pauli, location, n));
        }
    }

    public class WeightOnePaulis : Operation<Int64, QArray<QArray<Pauli>>>, ICallable
    {
        public WeightOnePaulis(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "WeightOnePaulis";
        String ICallable.FullName => "Microsoft.Quantum.Canon.WeightOnePaulis";
        protected ICallable<(Pauli,Int64,Int64), QArray<Pauli>> EmbedPauli
        {
            get;
            set;
        }

        public override Func<Int64, QArray<QArray<Pauli>>> Body => (__in) =>
        {
            var nQubits = __in;
#line 255 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
            var paulis = new QArray<QArray<Pauli>>((3L * nQubits));
#line 256 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
            var pauliGroup = new QArray<Pauli>(Pauli.PauliX, Pauli.PauliY, Pauli.PauliZ);
#line 258 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
            foreach (var idxQubit in new Range(0L, (nQubits - 1L)))
            {
#line 259 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
                foreach (var idxPauli in new Range(0L, (pauliGroup.Count - 1L)))
                {
#line 260 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
                    paulis[((idxQubit * pauliGroup.Count) + idxPauli)] = EmbedPauli.Apply((pauliGroup[idxPauli], idxQubit, nQubits));
                }
            }

#line 264 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
            return paulis;
        }

        ;
        public override void Init()
        {
            this.EmbedPauli = this.Factory.Get<ICallable<(Pauli,Int64,Int64), QArray<Pauli>>>(typeof(Microsoft.Quantum.Canon.EmbedPauli));
        }

        public override IApplyData __dataIn(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __dataOut(QArray<QArray<Pauli>> data) => data;
        public static System.Threading.Tasks.Task<QArray<QArray<Pauli>>> Run(IOperationFactory __m__, Int64 nQubits)
        {
            return __m__.Run<WeightOnePaulis, Int64, QArray<QArray<Pauli>>>(nQubits);
        }
    }

    public class _BasisChangeZtoY : Unitary<Qubit>, ICallable
    {
        public _BasisChangeZtoY(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "_BasisChangeZtoY";
        String ICallable.FullName => "Microsoft.Quantum.Canon._BasisChangeZtoY";
        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveS
        {
            get;
            set;
        }

        public override Func<Qubit, QVoid> Body => (__in) =>
        {
            var target = __in;
#line 270 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
            MicrosoftQuantumPrimitiveH.Apply(target);
#line 271 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
            MicrosoftQuantumPrimitiveS.Apply(target);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<Qubit, QVoid> AdjointBody => (__in) =>
        {
            var target = __in;
            MicrosoftQuantumPrimitiveS.Adjoint.Apply(target);
            MicrosoftQuantumPrimitiveH.Adjoint.Apply(target);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,Qubit), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,target) = __in;
            MicrosoftQuantumPrimitiveH.Controlled.Apply((controlQubits, target));
            MicrosoftQuantumPrimitiveS.Controlled.Apply((controlQubits, target));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,Qubit), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,target) = __in;
            MicrosoftQuantumPrimitiveS.Adjoint.Controlled.Apply((controlQubits, target));
            MicrosoftQuantumPrimitiveH.Adjoint.Controlled.Apply((controlQubits, target));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.MicrosoftQuantumPrimitiveS = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.S));
        }

        public override IApplyData __dataIn(Qubit data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit target)
        {
            return __m__.Run<_BasisChangeZtoY, Qubit, QVoid>(target);
        }
    }

    public class MultiM : Operation<QArray<Qubit>, QArray<Result>>, ICallable
    {
        public MultiM(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "MultiM";
        String ICallable.FullName => "Microsoft.Quantum.Canon.MultiM";
        protected ICallable<Qubit, Result> M
        {
            get;
            set;
        }

        public override Func<QArray<Qubit>, QArray<Result>> Body => (__in) =>
        {
            var targets = __in;
#line 288 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
            var results = new QArray<Result>(targets.Count);
#line 289 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
            foreach (var idxQubit in new Range(0L, (targets.Count - 1L)))
            {
#line 290 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
                results[idxQubit] = M.Apply(targets[idxQubit]);
            }

#line 292 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
            return results;
        }

        ;
        public override void Init()
        {
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QArray<Result> data) => data;
        public static System.Threading.Tasks.Task<QArray<Result>> Run(IOperationFactory __m__, QArray<Qubit> targets)
        {
            return __m__.Run<MultiM, QArray<Qubit>, QArray<Result>>(targets);
        }
    }

    public class MResetZ : Operation<Qubit, Result>, ICallable
    {
        public MResetZ(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "MResetZ";
        String ICallable.FullName => "Microsoft.Quantum.Canon.MResetZ";
        protected ICallable<Qubit, Result> M
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<Qubit, Result> Body => (__in) =>
        {
            var target = __in;
#line 309 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
            var result = M.Apply(target);
#line 310 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
            if ((result == Result.One))
            {
                // Recall that the +1 eigenspace of a measurement operator corresponds to
                // the Result case Zero. Thus, if we see a One case, we must reset the state 
                // have +1 eigenvalue.
#line 314 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
                MicrosoftQuantumPrimitiveX.Apply(target);
            }

#line 316 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
            return result;
        }

        ;
        public override void Init()
        {
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn(Qubit data) => data;
        public override IApplyData __dataOut(Result data) => new QTuple<Result>(data);
        public static System.Threading.Tasks.Task<Result> Run(IOperationFactory __m__, Qubit target)
        {
            return __m__.Run<MResetZ, Qubit, Result>(target);
        }
    }

    public class MResetX : Operation<Qubit, Result>, ICallable
    {
        public MResetX(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "MResetX";
        String ICallable.FullName => "Microsoft.Quantum.Canon.MResetX";
        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get;
            set;
        }

        protected ICallable<(QArray<Pauli>,QArray<Qubit>), Result> Measure
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<Qubit, Result> Body => (__in) =>
        {
            var target = __in;
#line 333 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
            var result = Measure.Apply((new QArray<Pauli>()
            {Pauli.PauliX}, new QArray<Qubit>()
            {target}));
            // We must return the qubit to the Z basis as well.
#line 335 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
            MicrosoftQuantumPrimitiveH.Apply(target);
#line 336 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
            if ((result == Result.One))
            {
                // Recall that the +1 eigenspace of a measurement operator corresponds to
                // the Result case Zero. Thus, if we see a One case, we must reset the state 
                // have +1 eigenvalue.
#line 340 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
                MicrosoftQuantumPrimitiveX.Apply(target);
            }

#line 342 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
            return result;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.Measure = this.Factory.Get<ICallable<(QArray<Pauli>,QArray<Qubit>), Result>>(typeof(Microsoft.Quantum.Primitive.Measure));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn(Qubit data) => data;
        public override IApplyData __dataOut(Result data) => new QTuple<Result>(data);
        public static System.Threading.Tasks.Task<Result> Run(IOperationFactory __m__, Qubit target)
        {
            return __m__.Run<MResetX, Qubit, Result>(target);
        }
    }

    public class MResetY : Operation<Qubit, Result>, ICallable
    {
        public MResetY(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "MResetY";
        String ICallable.FullName => "Microsoft.Quantum.Canon.MResetY";
        protected ICallable<(QArray<Pauli>,QArray<Qubit>), Result> Measure
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        protected IUnitary<Qubit> _BasisChangeZtoY
        {
            get;
            set;
        }

        public override Func<Qubit, Result> Body => (__in) =>
        {
            var target = __in;
#line 359 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
            var result = Measure.Apply((new QArray<Pauli>()
            {Pauli.PauliY}, new QArray<Qubit>()
            {target}));
            // We must return the qubit to the Z basis as well.
#line 362 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
            _BasisChangeZtoY.Adjoint.Apply(target);
#line 363 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
            if ((result == Result.One))
            {
                // Recall that the +1 eigenspace of a measurement operator corresponds to
                // the Result case Zero. Thus, if we see a One case, we must reset the state 
                // have +1 eigenvalue.
#line 367 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
                MicrosoftQuantumPrimitiveX.Apply(target);
            }

#line 369 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
            return result;
        }

        ;
        public override void Init()
        {
            this.Measure = this.Factory.Get<ICallable<(QArray<Pauli>,QArray<Qubit>), Result>>(typeof(Microsoft.Quantum.Primitive.Measure));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
            this._BasisChangeZtoY = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Canon._BasisChangeZtoY));
        }

        public override IApplyData __dataIn(Qubit data) => data;
        public override IApplyData __dataOut(Result data) => new QTuple<Result>(data);
        public static System.Threading.Tasks.Task<Result> Run(IOperationFactory __m__, Qubit target)
        {
            return __m__.Run<MResetY, Qubit, Result>(target);
        }
    }

    public class HY : Unitary<Qubit>, ICallable
    {
        public HY(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "HY";
        String ICallable.FullName => "Microsoft.Quantum.Canon.HY";
        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveS
        {
            get;
            set;
        }

        public override Func<Qubit, QVoid> Body => (__in) =>
        {
            var target = __in;
#line 393 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
            MicrosoftQuantumPrimitiveH.Apply(target);
#line 394 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Paulis.qs"
            MicrosoftQuantumPrimitiveS.Apply(target);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<Qubit, QVoid> AdjointBody => (__in) =>
        {
            var target = __in;
            MicrosoftQuantumPrimitiveS.Adjoint.Apply(target);
            MicrosoftQuantumPrimitiveH.Adjoint.Apply(target);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,Qubit), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,target) = __in;
            MicrosoftQuantumPrimitiveH.Controlled.Apply((controlQubits, target));
            MicrosoftQuantumPrimitiveS.Controlled.Apply((controlQubits, target));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,Qubit), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,target) = __in;
            MicrosoftQuantumPrimitiveS.Adjoint.Controlled.Apply((controlQubits, target));
            MicrosoftQuantumPrimitiveH.Adjoint.Controlled.Apply((controlQubits, target));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.MicrosoftQuantumPrimitiveS = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.S));
        }

        public override IApplyData __dataIn(Qubit data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit target)
        {
            return __m__.Run<HY, Qubit, QVoid>(target);
        }
    }
}