#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "_ExtractLogicalQubitFromSteaneCode (code : Microsoft.Quantum.Canon.LogicalRegister) : (Qubit, Int, Int)", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\KnillDistill.qs", 1442L, 31L, 5L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "InjectPi4YRotation (data : Qubit, magic : Qubit) : ()", new string[] { "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\KnillDistill.qs", 3679L, 97L, 5L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "KnillDistill (roughMagic : Qubit[]) : Bool", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\KnillDistill.qs", 5782L, 160L, 5L)]
#line hidden
namespace Microsoft.Quantum.Canon
{
    public class _ExtractLogicalQubitFromSteaneCode : Operation<LogicalRegister, (Qubit,Int64,Int64)>, ICallable
    {
        public _ExtractLogicalQubitFromSteaneCode(IOperationFactory m) : base(m)
        {
        }

        public class Out : QTuple<(Qubit,Int64,Int64)>, IApplyData
        {
            public Out((Qubit,Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item1;
                }
            }
        }

        String ICallable.Name => "_ExtractLogicalQubitFromSteaneCode";
        String ICallable.FullName => "Microsoft.Quantum.Canon._ExtractLogicalQubitFromSteaneCode";
        protected ICallable<Qubit, Result> M
        {
            get;
            set;
        }

        protected IAdjointable<(QArray<Qubit>,QArray<Qubit>)> SteaneCodeEncoderImpl
        {
            get;
            set;
        }

        public override Func<LogicalRegister, (Qubit,Int64,Int64)> Body => (__in) =>
        {
            var code = __in;
#line 33 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\KnillDistill.qs"
            SteaneCodeEncoderImpl.Adjoint.Apply((code?.Slice(new Range(0L, 0L)), code?.Slice(new Range(1L, 6L))));
#line 35 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\KnillDistill.qs"
            var x0 = M.Apply(code[6L]);
#line 36 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\KnillDistill.qs"
            var x1 = M.Apply(code[1L]);
#line 37 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\KnillDistill.qs"
            var x2 = M.Apply(code[3L]);
#line 39 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\KnillDistill.qs"
            var xsyn = 0L;
#line 40 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\KnillDistill.qs"
            if ((x0 == Result.One))
            {
#line 40 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\KnillDistill.qs"
                xsyn = (xsyn ^ 1L);
            }

#line 41 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\KnillDistill.qs"
            if ((x1 == Result.One))
            {
#line 41 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\KnillDistill.qs"
                xsyn = (xsyn ^ 2L);
            }

#line 42 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\KnillDistill.qs"
            if ((x2 == Result.One))
            {
#line 42 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\KnillDistill.qs"
                xsyn = (xsyn ^ 4L);
            }

#line 43 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\KnillDistill.qs"
            xsyn = (xsyn - 1L);
            // xsyn contains the qubit index (0..6) at which a single Z-error would
            // produce the given syndrome.
#line 47 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\KnillDistill.qs"
            var z0 = M.Apply(code[5L]);
#line 48 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\KnillDistill.qs"
            var z1 = M.Apply(code[2L]);
#line 49 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\KnillDistill.qs"
            var z2 = M.Apply(code[4L]);
#line 51 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\KnillDistill.qs"
            var zsyn = 0L;
#line 52 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\KnillDistill.qs"
            if ((z0 == Result.One))
            {
#line 52 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\KnillDistill.qs"
                zsyn = (zsyn ^ 1L);
            }

#line 53 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\KnillDistill.qs"
            if ((z1 == Result.One))
            {
#line 53 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\KnillDistill.qs"
                zsyn = (zsyn ^ 2L);
            }

#line 54 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\KnillDistill.qs"
            if ((z2 == Result.One))
            {
#line 54 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\KnillDistill.qs"
                zsyn = (zsyn ^ 5L);
            }

#line 55 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\KnillDistill.qs"
            zsyn = (zsyn - 1L);
            // zsyn contains the qubit index (0..6) at which a single X-error would
            // produce the given syndrome.
#line 59 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\KnillDistill.qs"
            return (code[0L], xsyn, zsyn);
        }

        ;
        public override void Init()
        {
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.SteaneCodeEncoderImpl = this.Factory.Get<IAdjointable<(QArray<Qubit>,QArray<Qubit>)>>(typeof(Microsoft.Quantum.Canon.SteaneCodeEncoderImpl));
        }

        public override IApplyData __dataIn(LogicalRegister data) => data;
        public override IApplyData __dataOut((Qubit,Int64,Int64) data) => new Out(data);
        public static System.Threading.Tasks.Task<(Qubit,Int64,Int64)> Run(IOperationFactory __m__, LogicalRegister code)
        {
            return __m__.Run<_ExtractLogicalQubitFromSteaneCode, LogicalRegister, (Qubit,Int64,Int64)>(code);
        }
    }

    public class InjectPi4YRotation : Adjointable<(Qubit,Qubit)>, ICallable
    {
        public InjectPi4YRotation(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,Qubit)>, IApplyData
        {
            public In((Qubit,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item1;
                    yield return Data.Item2;
                }
            }
        }

        String ICallable.Name => "InjectPi4YRotation";
        String ICallable.FullName => "Microsoft.Quantum.Canon.InjectPi4YRotation";
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

        protected ICallable<Qubit, Result> MResetY
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveS
        {
            get;
            set;
        }

        public override Func<(Qubit,Qubit), QVoid> Body => (__in) =>
        {
            var (data,magic) = __in;
#line 99 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\KnillDistill.qs"
            MicrosoftQuantumPrimitiveS.Adjoint.Apply(data);
#line 100 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\KnillDistill.qs"
            MicrosoftQuantumPrimitiveCNOT.Apply((magic, data));
#line 101 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\KnillDistill.qs"
            MicrosoftQuantumPrimitiveS.Apply(data);
#line 102 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\KnillDistill.qs"
            var r = MResetY.Apply(magic);
#line 103 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\KnillDistill.qs"
            if ((r == Result.One))
            {
                // The following five gates is equal to	Ry( Pi()/2.0, data)
                // up to global phase.
#line 106 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\KnillDistill.qs"
                MicrosoftQuantumPrimitiveS.Apply(data);
#line 107 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\KnillDistill.qs"
                MicrosoftQuantumPrimitiveH.Apply(data);
#line 108 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\KnillDistill.qs"
                MicrosoftQuantumPrimitiveS.Adjoint.Apply(data);
#line 109 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\KnillDistill.qs"
                MicrosoftQuantumPrimitiveH.Apply(data);
#line 110 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\KnillDistill.qs"
                MicrosoftQuantumPrimitiveS.Adjoint.Apply(data);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Qubit,Qubit), QVoid> AdjointBody => (__in) =>
        {
            var (data,magic) = __in;
#line 114 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\KnillDistill.qs"
            MicrosoftQuantumPrimitiveS.Adjoint.Apply(data);
#line 115 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\KnillDistill.qs"
            MicrosoftQuantumPrimitiveCNOT.Apply((magic, data));
#line 116 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\KnillDistill.qs"
            MicrosoftQuantumPrimitiveS.Apply(data);
#line 117 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\KnillDistill.qs"
            var r = MResetY.Apply(magic);
#line 118 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\KnillDistill.qs"
            if ((r == Result.Zero))
            {
#line 119 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\KnillDistill.qs"
                MicrosoftQuantumPrimitiveS.Apply(data);
#line 120 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\KnillDistill.qs"
                MicrosoftQuantumPrimitiveH.Apply(data);
#line 121 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\KnillDistill.qs"
                MicrosoftQuantumPrimitiveS.Apply(data);
#line 122 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\KnillDistill.qs"
                MicrosoftQuantumPrimitiveH.Apply(data);
#line 123 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\KnillDistill.qs"
                MicrosoftQuantumPrimitiveS.Adjoint.Apply(data);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.MResetY = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Canon.MResetY));
            this.MicrosoftQuantumPrimitiveS = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.S));
        }

        public override IApplyData __dataIn((Qubit,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit data, Qubit magic)
        {
            return __m__.Run<InjectPi4YRotation, (Qubit,Qubit), QVoid>((data, magic));
        }
    }

    public class KnillDistill : Operation<QArray<Qubit>, Boolean>, ICallable
    {
        public KnillDistill(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "KnillDistill";
        String ICallable.FullName => "Microsoft.Quantum.Canon.KnillDistill";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveCNOT
        {
            get;
            set;
        }

        protected IAdjointable<(Qubit,Qubit)> InjectPi4YRotation
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

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveSWAP
        {
            get;
            set;
        }

        protected IAdjointable<(QArray<Qubit>,QArray<Qubit>)> SteaneCodeEncoderImpl
        {
            get;
            set;
        }

        protected ICallable<LogicalRegister, (Qubit,Int64,Int64)> _ExtractLogicalQubitFromSteaneCode
        {
            get;
            set;
        }

        public override Func<QArray<Qubit>, Boolean> Body => (__in) =>
        {
            var roughMagic = __in;
#line 162 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\KnillDistill.qs"
            var accept = false;
#line 163 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\KnillDistill.qs"
            var scratch = Allocate.Apply(8L);
#line 164 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\KnillDistill.qs"
            var anc = scratch[7L];
#line 165 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\KnillDistill.qs"
            var code = scratch?.Slice(new Range(0L, 6L));
#line 166 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\KnillDistill.qs"
            InjectPi4YRotation.Apply((code[0L], roughMagic[14L]));
#line 167 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\KnillDistill.qs"
            SteaneCodeEncoderImpl.Apply((code?.Slice(new Range(0L, 0L)), code?.Slice(new Range(1L, 6L))));
#line 168 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\KnillDistill.qs"
            foreach (var idx in new Range(0L, 6L))
            {
#line 169 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\KnillDistill.qs"
                InjectPi4YRotation.Adjoint.Apply((code[idx], roughMagic[idx]));
#line 170 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\KnillDistill.qs"
                MicrosoftQuantumPrimitiveCNOT.Apply((code[idx], anc));
#line 171 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\KnillDistill.qs"
                InjectPi4YRotation.Apply((code[idx], roughMagic[(idx + 7L)]));
            }

#line 173 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\KnillDistill.qs"
            var (logicalQubit,xsyn,zsyn) = _ExtractLogicalQubitFromSteaneCode.Apply(new LogicalRegister(code));
#line 175 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\KnillDistill.qs"
            var m = M.Apply(anc);
#line 176 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\KnillDistill.qs"
            if ((((xsyn == -(1L)) && (zsyn == -(1L))) && (m == Result.Zero)))
            {
#line 177 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\KnillDistill.qs"
                MicrosoftQuantumPrimitiveSWAP.Apply((logicalQubit, roughMagic[0L]));
#line 178 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\KnillDistill.qs"
                accept = true;
            }

#line 181 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\KnillDistill.qs"
            ResetAll.Apply(scratch);
#line hidden
            Release.Apply(scratch);
#line 183 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Qecc\\KnillDistill.qs"
            return accept;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
            this.InjectPi4YRotation = this.Factory.Get<IAdjointable<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Canon.InjectPi4YRotation));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.MicrosoftQuantumPrimitiveSWAP = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.SWAP));
            this.SteaneCodeEncoderImpl = this.Factory.Get<IAdjointable<(QArray<Qubit>,QArray<Qubit>)>>(typeof(Microsoft.Quantum.Canon.SteaneCodeEncoderImpl));
            this._ExtractLogicalQubitFromSteaneCode = this.Factory.Get<ICallable<LogicalRegister, (Qubit,Int64,Int64)>>(typeof(Microsoft.Quantum.Canon._ExtractLogicalQubitFromSteaneCode));
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(Boolean data) => new QTuple<Boolean>(data);
        public static System.Threading.Tasks.Task<Boolean> Run(IOperationFactory __m__, QArray<Qubit> roughMagic)
        {
            return __m__.Run<KnillDistill, QArray<Qubit>, Boolean>(roughMagic);
        }
    }
}