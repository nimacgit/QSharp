#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "ApproximateQFT (a : Int, qs : Microsoft.Quantum.Canon.BigEndian) : ()", new string[] { "Controlled", "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\QFT.qs", 1439L, 35L, 60L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "QFT (qs : Microsoft.Quantum.Canon.BigEndian) : ()", new string[] { "Controlled", "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\QFT.qs", 2909L, 78L, 43L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "QFTLE (qs : Microsoft.Quantum.Canon.LittleEndian) : ()", new string[] { "Controlled", "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\QFT.qs", 3577L, 101L, 48L)]
#line hidden
namespace Microsoft.Quantum.Canon
{
    public class ApproximateQFT : Unitary<(Int64,BigEndian)>, ICallable
    {
        public ApproximateQFT(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,BigEndian)>, IApplyData
        {
            public In((Int64,BigEndian) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "ApproximateQFT";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ApproximateQFT";
        protected ICallable<(Boolean,Boolean,String), QVoid> AssertBoolEqual
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get;
            set;
        }

        protected IUnitary<(Int64,Int64,Qubit)> MicrosoftQuantumPrimitiveR1Frac
        {
            get;
            set;
        }

        protected IUnitary<QArray<Qubit>> SwapReverseRegister
        {
            get;
            set;
        }

        public override Func<(Int64,BigEndian), QVoid> Body => (__in) =>
        {
            var (a,qs) = __in;
#line 38 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\QFT.qs"
            var nQubits = qs.Count;
#line 39 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\QFT.qs"
            AssertBoolEqual.Apply(((nQubits > 0L), true, "`Length(qs)` must be least 1"));
#line 40 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\QFT.qs"
            AssertBoolEqual.Apply((((a > 0L) && (a <= nQubits)), true, "`a` must be positive and less than `Length(qs)`"));
#line 44 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\QFT.qs"
            foreach (var i in new Range(0L, (nQubits - 1L)))
            {
#line 45 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\QFT.qs"
                foreach (var j in new Range(0L, (i - 1L)))
                {
#line 46 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\QFT.qs"
                    if (((i - j) < a))
                    {
#line 47 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\QFT.qs"
                        MicrosoftQuantumPrimitiveR1Frac.Controlled.Apply((new QArray<Qubit>()
                        {qs[i]}, (1L, (i - j), qs[j])));
                    }
                }

#line 50 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\QFT.qs"
                MicrosoftQuantumPrimitiveH.Apply(qs[i]);
            }

            // Apply the bit reversal permutation to the quantum register as
            // a side effect, such that we enforce the invariants specified
            // by the BigEndian UDT.
#line 56 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\QFT.qs"
            SwapReverseRegister.Apply(qs);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Int64,BigEndian), QVoid> AdjointBody => (__in) =>
        {
            var (a,qs) = __in;
#line 38 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\QFT.qs"
            var nQubits = qs.Count;
            AssertBoolEqual.Apply(((nQubits > 0L), true, "`Length(qs)` must be least 1"));
            AssertBoolEqual.Apply((((a > 0L) && (a <= nQubits)), true, "`a` must be positive and less than `Length(qs)`"));
            // Apply the bit reversal permutation to the quantum register as
            // a side effect, such that we enforce the invariants specified
            // by the BigEndian UDT.
            SwapReverseRegister.Adjoint.Apply(qs);
            foreach (var i in new Range((0L - ((((nQubits - 1L) - 0L) / 1L) * -(1L))), -(1L), 0L))
            {
                MicrosoftQuantumPrimitiveH.Adjoint.Apply(qs[i]);
                foreach (var j in new Range((0L - ((((i - 1L) - 0L) / 1L) * -(1L))), -(1L), 0L))
                {
                    if (((i - j) < a))
                    {
                        MicrosoftQuantumPrimitiveR1Frac.Controlled.Adjoint.Apply((new QArray<Qubit>()
                        {qs[i]}, (1L, (i - j), qs[j])));
                    }
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Int64,BigEndian)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(a,qs)) = __in;
            var nQubits = qs.Count;
            AssertBoolEqual.Apply(((nQubits > 0L), true, "`Length(qs)` must be least 1"));
            AssertBoolEqual.Apply((((a > 0L) && (a <= nQubits)), true, "`a` must be positive and less than `Length(qs)`"));
            foreach (var i in new Range(0L, (nQubits - 1L)))
            {
                foreach (var j in new Range(0L, (i - 1L)))
                {
                    if (((i - j) < a))
                    {
                        MicrosoftQuantumPrimitiveR1Frac.Controlled.Controlled.Apply((controlQubits, (new QArray<Qubit>()
                        {qs[i]}, (1L, (i - j), qs[j]))));
                    }
                }

                MicrosoftQuantumPrimitiveH.Controlled.Apply((controlQubits, qs[i]));
            }

            // Apply the bit reversal permutation to the quantum register as
            // a side effect, such that we enforce the invariants specified
            // by the BigEndian UDT.
            SwapReverseRegister.Controlled.Apply((controlQubits, qs));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Int64,BigEndian)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,(a,qs)) = __in;
            var nQubits = qs.Count;
            AssertBoolEqual.Apply(((nQubits > 0L), true, "`Length(qs)` must be least 1"));
            AssertBoolEqual.Apply((((a > 0L) && (a <= nQubits)), true, "`a` must be positive and less than `Length(qs)`"));
            // Apply the bit reversal permutation to the quantum register as
            // a side effect, such that we enforce the invariants specified
            // by the BigEndian UDT.
            SwapReverseRegister.Adjoint.Controlled.Apply((controlQubits, qs));
            foreach (var i in new Range((0L - ((((nQubits - 1L) - 0L) / 1L) * -(1L))), -(1L), 0L))
            {
                MicrosoftQuantumPrimitiveH.Adjoint.Controlled.Apply((controlQubits, qs[i]));
                foreach (var j in new Range((0L - ((((i - 1L) - 0L) / 1L) * -(1L))), -(1L), 0L))
                {
                    if (((i - j) < a))
                    {
                        MicrosoftQuantumPrimitiveR1Frac.Controlled.Adjoint.Controlled.Apply((controlQubits, (new QArray<Qubit>()
                        {qs[i]}, (1L, (i - j), qs[j]))));
                    }
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.AssertBoolEqual = this.Factory.Get<ICallable<(Boolean,Boolean,String), QVoid>>(typeof(Microsoft.Quantum.Canon.AssertBoolEqual));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.MicrosoftQuantumPrimitiveR1Frac = this.Factory.Get<IUnitary<(Int64,Int64,Qubit)>>(typeof(Microsoft.Quantum.Primitive.R1Frac));
            this.SwapReverseRegister = this.Factory.Get<IUnitary<QArray<Qubit>>>(typeof(Microsoft.Quantum.Canon.SwapReverseRegister));
        }

        public override IApplyData __dataIn((Int64,BigEndian) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 a, BigEndian qs)
        {
            return __m__.Run<ApproximateQFT, (Int64,BigEndian), QVoid>((a, qs));
        }
    }

    public class QFT : Unitary<BigEndian>, ICallable
    {
        public QFT(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "QFT";
        String ICallable.FullName => "Microsoft.Quantum.Canon.QFT";
        protected IUnitary<(Int64,BigEndian)> ApproximateQFT
        {
            get;
            set;
        }

        public override Func<BigEndian, QVoid> Body => (__in) =>
        {
            var qs = __in;
#line 80 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\QFT.qs"
            ApproximateQFT.Apply((qs.Count, qs));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<BigEndian, QVoid> AdjointBody => (__in) =>
        {
            var qs = __in;
            ApproximateQFT.Adjoint.Apply((qs.Count, qs));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,BigEndian), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,qs) = __in;
            ApproximateQFT.Controlled.Apply((controlQubits, (qs.Count, qs)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,BigEndian), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,qs) = __in;
            ApproximateQFT.Adjoint.Controlled.Apply((controlQubits, (qs.Count, qs)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.ApproximateQFT = this.Factory.Get<IUnitary<(Int64,BigEndian)>>(typeof(Microsoft.Quantum.Canon.ApproximateQFT));
        }

        public override IApplyData __dataIn(BigEndian data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, BigEndian qs)
        {
            return __m__.Run<QFT, BigEndian, QVoid>(qs);
        }
    }

    public class QFTLE : Unitary<LittleEndian>, ICallable
    {
        public QFTLE(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "QFTLE";
        String ICallable.FullName => "Microsoft.Quantum.Canon.QFTLE";
        protected IUnitary<(IUnitary,LittleEndian)> ApplyReversedOpBigEndianCA
        {
            get;
            set;
        }

        protected IUnitary<BigEndian> QFT
        {
            get;
            set;
        }

        public override Func<LittleEndian, QVoid> Body => (__in) =>
        {
            var qs = __in;
#line 103 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\QFT.qs"
            ApplyReversedOpBigEndianCA.Apply((((IUnitary)QFT), qs));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<LittleEndian, QVoid> AdjointBody => (__in) =>
        {
            var qs = __in;
            ApplyReversedOpBigEndianCA.Adjoint.Apply((((IUnitary)QFT), qs));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,LittleEndian), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,qs) = __in;
            ApplyReversedOpBigEndianCA.Controlled.Apply((controlQubits, (((IUnitary)QFT), qs)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,LittleEndian), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,qs) = __in;
            ApplyReversedOpBigEndianCA.Adjoint.Controlled.Apply((controlQubits, (((IUnitary)QFT), qs)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.ApplyReversedOpBigEndianCA = this.Factory.Get<IUnitary<(IUnitary,LittleEndian)>>(typeof(Microsoft.Quantum.Canon.ApplyReversedOpBigEndianCA));
            this.QFT = this.Factory.Get<IUnitary<BigEndian>>(typeof(Microsoft.Quantum.Canon.QFT));
        }

        public override IApplyData __dataIn(LittleEndian data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, LittleEndian qs)
        {
            return __m__.Run<QFTLE, LittleEndian, QVoid>(qs);
        }
    }
}