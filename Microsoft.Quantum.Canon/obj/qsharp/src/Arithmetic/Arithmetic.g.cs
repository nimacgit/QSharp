#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "InPlaceXorLE (value : Int, target : Microsoft.Quantum.Canon.LittleEndian) : ()", new string[] { "Controlled", "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs", 1049L, 28L, 69L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "MeasureInteger (target : Microsoft.Quantum.Canon.LittleEndian) : Int", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs", 2138L, 59L, 60L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "MeasureIntegerBE (target : Microsoft.Quantum.Canon.BigEndian) : Int", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs", 2628L, 74L, 59L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "IntegerIncrementPhaseLE (increment : Int, target : Microsoft.Quantum.Canon.PhaseLittleEndian) : ()", new string[] { "Controlled", "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs", 4169L, 112L, 90L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "AssertHighestBit (value : Result, number : Microsoft.Quantum.Canon.LittleEndian) : ()", new string[] { "Controlled", "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs", 5076L, 140L, 80L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "AssertLessThanPhaseLE (value : Int, number : Microsoft.Quantum.Canon.PhaseLittleEndian) : ()", new string[] { "Controlled", "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs", 5965L, 165L, 88L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "IntegerIncrementLE (increment : Int, target : Microsoft.Quantum.Canon.LittleEndian) : ()", new string[] { "Controlled", "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs", 7156L, 195L, 80L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "ModularIncrementLE (increment : Int, modulus : Int, target : Microsoft.Quantum.Canon.LittleEndian) : ()", new string[] { "Controlled", "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs", 8404L, 228L, 96L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "CopyMostSignificantBitLE (from : Microsoft.Quantum.Canon.LittleEndian, target : Qubit) : ()", new string[] { "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs", 9442L, 258L, 16L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "ModularIncrementPhaseLE (increment : Int, modulus : Int, target : Microsoft.Quantum.Canon.PhaseLittleEndian) : ()", new string[] { "Controlled", "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs", 10453L, 285L, 48L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "ModularAddProductLE (constMultiplier : Int, modulus : Int, multiplier : Microsoft.Quantum.Canon.LittleEndian, summand : Microsoft.Quantum.Canon.LittleEndian) : ()", new string[] { "Controlled", "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs", 15669L, 391L, 5L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "ModularAddProductPhaseLE (constMultiplier : Int, modulus : Int, multiplier : Microsoft.Quantum.Canon.LittleEndian, phaseSummand : Microsoft.Quantum.Canon.PhaseLittleEndian) : ()", new string[] { "Controlled", "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs", 16686L, 419L, 5L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "ModularMultiplyByConstantLE (constMultiplier : Int, modulus : Int, multiplier : Microsoft.Quantum.Canon.LittleEndian) : ()", new string[] { "Controlled", "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs", 19066L, 474L, 5L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "_EnableExtraAssertsForArithmetic () : Bool", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs", 441L, 14L, 14L)]
#line hidden
namespace Microsoft.Quantum.Canon
{
    public class _EnableExtraAssertsForArithmetic : Operation<QVoid, Boolean>, ICallable
    {
        public _EnableExtraAssertsForArithmetic(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "_EnableExtraAssertsForArithmetic";
        String ICallable.FullName => "Microsoft.Quantum.Canon._EnableExtraAssertsForArithmetic";
        public override Func<QVoid, Boolean> Body => (__in) =>
        {
#line 15 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            return false;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(Boolean data) => new QTuple<Boolean>(data);
        public static System.Threading.Tasks.Task<Boolean> Run(IOperationFactory __m__)
        {
            return __m__.Run<_EnableExtraAssertsForArithmetic, QVoid, Boolean>(QVoid.Instance);
        }
    }

    public class InPlaceXorLE : Unitary<(Int64,LittleEndian)>, ICallable
    {
        public InPlaceXorLE(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,LittleEndian)>, IApplyData
        {
            public In((Int64,LittleEndian) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "InPlaceXorLE";
        String ICallable.FullName => "Microsoft.Quantum.Canon.InPlaceXorLE";
        protected ICallable<(Int64,Int64), QArray<Boolean>> BoolArrFromPositiveInt
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(Int64,LittleEndian), QVoid> Body => (__in) =>
        {
            var (value,target) = __in;
#line 30 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            var bitrepresentation = BoolArrFromPositiveInt.Apply((value, target.Count));
#line 31 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            foreach (var idx in new Range(0L, (target.Count - 1L)))
            {
#line 32 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
                if (bitrepresentation[idx])
                {
#line 33 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
                    MicrosoftQuantumPrimitiveX.Apply(target[idx]);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Int64,LittleEndian), QVoid> AdjointBody => (__in) =>
        {
            var (value,target) = __in;
#line 30 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            var bitrepresentation = BoolArrFromPositiveInt.Apply((value, target.Count));
            foreach (var idx in new Range((0L - ((((target.Count - 1L) - 0L) / 1L) * -(1L))), -(1L), 0L))
            {
                if (bitrepresentation[idx])
                {
                    MicrosoftQuantumPrimitiveX.Adjoint.Apply(target[idx]);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Int64,LittleEndian)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(value,target)) = __in;
            var bitrepresentation = BoolArrFromPositiveInt.Apply((value, target.Count));
            foreach (var idx in new Range(0L, (target.Count - 1L)))
            {
                if (bitrepresentation[idx])
                {
                    MicrosoftQuantumPrimitiveX.Controlled.Apply((controlQubits, target[idx]));
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Int64,LittleEndian)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,(value,target)) = __in;
            var bitrepresentation = BoolArrFromPositiveInt.Apply((value, target.Count));
            foreach (var idx in new Range((0L - ((((target.Count - 1L) - 0L) / 1L) * -(1L))), -(1L), 0L))
            {
                if (bitrepresentation[idx])
                {
                    MicrosoftQuantumPrimitiveX.Adjoint.Controlled.Apply((controlQubits, target[idx]));
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.BoolArrFromPositiveInt = this.Factory.Get<ICallable<(Int64,Int64), QArray<Boolean>>>(typeof(Microsoft.Quantum.Canon.BoolArrFromPositiveInt));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((Int64,LittleEndian) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 value, LittleEndian target)
        {
            return __m__.Run<InPlaceXorLE, (Int64,LittleEndian), QVoid>((value, target));
        }
    }

    public class MeasureInteger : Operation<LittleEndian, Int64>, ICallable
    {
        public MeasureInteger(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "MeasureInteger";
        String ICallable.FullName => "Microsoft.Quantum.Canon.MeasureInteger";
        protected ICallable<Qubit, Result> MResetZ
        {
            get;
            set;
        }

        protected ICallable<QArray<Result>, Int64> PositiveIntFromResultArr
        {
            get;
            set;
        }

        public override Func<LittleEndian, Int64> Body => (__in) =>
        {
            var target = __in;
#line 61 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            var results = new QArray<Result>(target.Count);
#line 62 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            foreach (var idx in new Range(0L, (target.Count - 1L)))
            {
#line 63 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
                results[idx] = MResetZ.Apply(target[idx]);
            }

#line 65 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            return PositiveIntFromResultArr.Apply(results);
        }

        ;
        public override void Init()
        {
            this.MResetZ = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Canon.MResetZ));
            this.PositiveIntFromResultArr = this.Factory.Get<ICallable<QArray<Result>, Int64>>(typeof(Microsoft.Quantum.Canon.PositiveIntFromResultArr));
        }

        public override IApplyData __dataIn(LittleEndian data) => data;
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, LittleEndian target)
        {
            return __m__.Run<MeasureInteger, LittleEndian, Int64>(target);
        }
    }

    public class MeasureIntegerBE : Operation<BigEndian, Int64>, ICallable
    {
        public MeasureIntegerBE(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "MeasureIntegerBE";
        String ICallable.FullName => "Microsoft.Quantum.Canon.MeasureIntegerBE";
        protected ICallable<Qubit, Result> MResetZ
        {
            get;
            set;
        }

        protected ICallable<QArray<Result>, Int64> PositiveIntFromResultArr
        {
            get;
            set;
        }

        protected ICallable Reverse
        {
            get;
            set;
        }

        public override Func<BigEndian, Int64> Body => (__in) =>
        {
            var target = __in;
#line 76 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            var results = new QArray<Result>(target.Count);
#line 77 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            foreach (var idx in new Range(0L, (target.Count - 1L)))
            {
#line 78 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
                results[idx] = MResetZ.Apply(target[idx]);
            }

#line 80 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            return PositiveIntFromResultArr.Apply(Reverse.Apply<QArray<Result>>(results));
        }

        ;
        public override void Init()
        {
            this.MResetZ = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Canon.MResetZ));
            this.PositiveIntFromResultArr = this.Factory.Get<ICallable<QArray<Result>, Int64>>(typeof(Microsoft.Quantum.Canon.PositiveIntFromResultArr));
            this.Reverse = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Reverse<>));
        }

        public override IApplyData __dataIn(BigEndian data) => data;
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, BigEndian target)
        {
            return __m__.Run<MeasureIntegerBE, BigEndian, Int64>(target);
        }
    }

    public class IntegerIncrementPhaseLE : Unitary<(Int64,PhaseLittleEndian)>, ICallable
    {
        public IntegerIncrementPhaseLE(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,PhaseLittleEndian)>, IApplyData
        {
            public In((Int64,PhaseLittleEndian) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "IntegerIncrementPhaseLE";
        String ICallable.FullName => "Microsoft.Quantum.Canon.IntegerIncrementPhaseLE";
        protected IUnitary<(Int64,Int64,Qubit)> MicrosoftQuantumPrimitiveR1Frac
        {
            get;
            set;
        }

        public override Func<(Int64,PhaseLittleEndian), QVoid> Body => (__in) =>
        {
            var (increment,target) = __in;
#line 114 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            var d = target.Count;
#line 115 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            foreach (var j in new Range(0L, (d - 1L)))
            {
                //  Use Microsoft.Quantum.Primitive.R1Frac
#line 117 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
                MicrosoftQuantumPrimitiveR1Frac.Apply((increment, ((d - 1L) - j), target[j]));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Int64,PhaseLittleEndian), QVoid> AdjointBody => (__in) =>
        {
            var (increment,target) = __in;
#line 114 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            var d = target.Count;
            foreach (var j in new Range((0L - ((((d - 1L) - 0L) / 1L) * -(1L))), -(1L), 0L))
            {
                //  Use Microsoft.Quantum.Primitive.R1Frac
                MicrosoftQuantumPrimitiveR1Frac.Adjoint.Apply((increment, ((d - 1L) - j), target[j]));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Int64,PhaseLittleEndian)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(increment,target)) = __in;
            var d = target.Count;
            foreach (var j in new Range(0L, (d - 1L)))
            {
                //  Use Microsoft.Quantum.Primitive.R1Frac
                MicrosoftQuantumPrimitiveR1Frac.Controlled.Apply((controlQubits, (increment, ((d - 1L) - j), target[j])));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Int64,PhaseLittleEndian)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,(increment,target)) = __in;
            var d = target.Count;
            foreach (var j in new Range((0L - ((((d - 1L) - 0L) / 1L) * -(1L))), -(1L), 0L))
            {
                //  Use Microsoft.Quantum.Primitive.R1Frac
                MicrosoftQuantumPrimitiveR1Frac.Adjoint.Controlled.Apply((controlQubits, (increment, ((d - 1L) - j), target[j])));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveR1Frac = this.Factory.Get<IUnitary<(Int64,Int64,Qubit)>>(typeof(Microsoft.Quantum.Primitive.R1Frac));
        }

        public override IApplyData __dataIn((Int64,PhaseLittleEndian) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 increment, PhaseLittleEndian target)
        {
            return __m__.Run<IntegerIncrementPhaseLE, (Int64,PhaseLittleEndian), QVoid>((increment, target));
        }
    }

    public class AssertHighestBit : Unitary<(Result,LittleEndian)>, ICallable
    {
        public AssertHighestBit(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Result,LittleEndian)>, IApplyData
        {
            public In((Result,LittleEndian) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "AssertHighestBit";
        String ICallable.FullName => "Microsoft.Quantum.Canon.AssertHighestBit";
        protected ICallable<QArray<Qubit>, QArray<Qubit>> AsQubitArray
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Pauli>,QArray<Qubit>,Result,String)> Assert
        {
            get;
            set;
        }

        protected ICallable Tail
        {
            get;
            set;
        }

        public override Func<(Result,LittleEndian), QVoid> Body => (__in) =>
        {
            var (value,number) = __in;
#line 142 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            var mostSingificantQubit = Tail.Apply<Qubit>(AsQubitArray.Apply(number));
#line 143 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            Assert.Apply((new QArray<Pauli>()
            {Pauli.PauliZ}, new QArray<Qubit>()
            {mostSingificantQubit}, value, $"Most significant bit expected to be {value}"));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Result,LittleEndian), QVoid> AdjointBody => Body;
        public override Func<(QArray<Qubit>,(Result,LittleEndian)), QVoid> ControlledBody => (__in) =>
        {
            var (ctrls,(value,number)) = __in;
#line 147 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            ((IUnitary)this).Apply((value, number));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Result,LittleEndian)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (ctrls,(value,number)) = __in;
#line 150 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            ((IUnitary)this).Controlled.Apply((ctrls, (value, number)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.AsQubitArray = this.Factory.Get<ICallable<QArray<Qubit>, QArray<Qubit>>>(typeof(Microsoft.Quantum.Canon.AsQubitArray));
            this.Assert = this.Factory.Get<IUnitary<(QArray<Pauli>,QArray<Qubit>,Result,String)>>(typeof(Microsoft.Quantum.Primitive.Assert));
            this.Tail = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Tail<>));
        }

        public override IApplyData __dataIn((Result,LittleEndian) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Result value, LittleEndian number)
        {
            return __m__.Run<AssertHighestBit, (Result,LittleEndian), QVoid>((value, number));
        }
    }

    public class AssertLessThanPhaseLE : Unitary<(Int64,PhaseLittleEndian)>, ICallable
    {
        public AssertLessThanPhaseLE(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,PhaseLittleEndian)>, IApplyData
        {
            public In((Int64,PhaseLittleEndian) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "AssertLessThanPhaseLE";
        String ICallable.FullName => "Microsoft.Quantum.Canon.AssertLessThanPhaseLE";
        protected IAdjointable<(IAdjointable,PhaseLittleEndian)> ApplyLEOperationOnPhaseLEA
        {
            get;
            set;
        }

        protected IUnitary<(Result,LittleEndian)> AssertHighestBit
        {
            get;
            set;
        }

        protected IUnitary<(Int64,PhaseLittleEndian)> IntegerIncrementPhaseLE
        {
            get;
            set;
        }

        protected IAdjointable WithA
        {
            get;
            set;
        }

        public override Func<(Int64,PhaseLittleEndian), QVoid> Body => (__in) =>
        {
            var (value,number) = __in;
#line 167 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            var inner = ApplyLEOperationOnPhaseLEA.Partial(new Func<PhaseLittleEndian, (IAdjointable,PhaseLittleEndian)>((_arg1) => (((IAdjointable)AssertHighestBit.Partial(new Func<LittleEndian, (Result,LittleEndian)>((_arg2) => (Result.One, _arg2)))), _arg1)));
#line 168 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            WithA.Apply((((IAdjointable)IntegerIncrementPhaseLE.Adjoint.Partial(new Func<PhaseLittleEndian, (Int64,PhaseLittleEndian)>((_arg3) => (value, _arg3)))), ((IAdjointable)inner), number));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Int64,PhaseLittleEndian), QVoid> AdjointBody => Body;
        public override Func<(QArray<Qubit>,(Int64,PhaseLittleEndian)), QVoid> ControlledBody => (__in) =>
        {
            var (ctrls,(value,number)) = __in;
#line 172 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            ((IUnitary)this).Apply((value, number));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Int64,PhaseLittleEndian)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (ctrls,(value,number)) = __in;
#line 175 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            ((IUnitary)this).Controlled.Apply((ctrls, (value, number)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.ApplyLEOperationOnPhaseLEA = this.Factory.Get<IAdjointable<(IAdjointable,PhaseLittleEndian)>>(typeof(Microsoft.Quantum.Canon.ApplyLEOperationOnPhaseLEA));
            this.AssertHighestBit = this.Factory.Get<IUnitary<(Result,LittleEndian)>>(typeof(Microsoft.Quantum.Canon.AssertHighestBit));
            this.IntegerIncrementPhaseLE = this.Factory.Get<IUnitary<(Int64,PhaseLittleEndian)>>(typeof(Microsoft.Quantum.Canon.IntegerIncrementPhaseLE));
            this.WithA = this.Factory.Get<IAdjointable>(typeof(Microsoft.Quantum.Canon.WithA<>));
        }

        public override IApplyData __dataIn((Int64,PhaseLittleEndian) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 value, PhaseLittleEndian number)
        {
            return __m__.Run<AssertLessThanPhaseLE, (Int64,PhaseLittleEndian), QVoid>((value, number));
        }
    }

    public class IntegerIncrementLE : Unitary<(Int64,LittleEndian)>, ICallable
    {
        public IntegerIncrementLE(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,LittleEndian)>, IApplyData
        {
            public In((Int64,LittleEndian) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "IntegerIncrementLE";
        String ICallable.FullName => "Microsoft.Quantum.Canon.IntegerIncrementLE";
        protected IUnitary<(IUnitary,LittleEndian)> ApplyPhaseLEOperationOnLECA
        {
            get;
            set;
        }

        protected IUnitary<(Int64,PhaseLittleEndian)> IntegerIncrementPhaseLE
        {
            get;
            set;
        }

        public override Func<(Int64,LittleEndian), QVoid> Body => (__in) =>
        {
            var (increment,target) = __in;
#line 197 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            var inner = IntegerIncrementPhaseLE.Partial(new Func<PhaseLittleEndian, (Int64,PhaseLittleEndian)>((_arg1) => (increment, _arg1)));
#line 198 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            ApplyPhaseLEOperationOnLECA.Apply((((IUnitary)inner), target));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Int64,LittleEndian), QVoid> AdjointBody => (__in) =>
        {
            var (increment,target) = __in;
#line 197 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            var inner = IntegerIncrementPhaseLE.Partial(new Func<PhaseLittleEndian, (Int64,PhaseLittleEndian)>((_arg1) => (increment, _arg1)));
            ApplyPhaseLEOperationOnLECA.Adjoint.Apply((((IUnitary)inner), target));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Int64,LittleEndian)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(increment,target)) = __in;
            var inner = IntegerIncrementPhaseLE.Partial(new Func<PhaseLittleEndian, (Int64,PhaseLittleEndian)>((_arg1) => (increment, _arg1)));
            ApplyPhaseLEOperationOnLECA.Controlled.Apply((controlQubits, (((IUnitary)inner), target)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Int64,LittleEndian)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,(increment,target)) = __in;
            var inner = IntegerIncrementPhaseLE.Partial(new Func<PhaseLittleEndian, (Int64,PhaseLittleEndian)>((_arg1) => (increment, _arg1)));
            ApplyPhaseLEOperationOnLECA.Adjoint.Controlled.Apply((controlQubits, (((IUnitary)inner), target)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.ApplyPhaseLEOperationOnLECA = this.Factory.Get<IUnitary<(IUnitary,LittleEndian)>>(typeof(Microsoft.Quantum.Canon.ApplyPhaseLEOperationOnLECA));
            this.IntegerIncrementPhaseLE = this.Factory.Get<IUnitary<(Int64,PhaseLittleEndian)>>(typeof(Microsoft.Quantum.Canon.IntegerIncrementPhaseLE));
        }

        public override IApplyData __dataIn((Int64,LittleEndian) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 increment, LittleEndian target)
        {
            return __m__.Run<IntegerIncrementLE, (Int64,LittleEndian), QVoid>((increment, target));
        }
    }

    public class ModularIncrementLE : Unitary<(Int64,Int64,LittleEndian)>, ICallable
    {
        public ModularIncrementLE(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64,LittleEndian)>, IApplyData
        {
            public In((Int64,Int64,LittleEndian) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item3)?.Qubits;
        }

        String ICallable.Name => "ModularIncrementLE";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ModularIncrementLE";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<(IUnitary,LittleEndian)> ApplyPhaseLEOperationOnLECA
        {
            get;
            set;
        }

        protected IUnitary<(Int64,Int64,PhaseLittleEndian)> ModularIncrementPhaseLE
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        public override Func<(Int64,Int64,LittleEndian), QVoid> Body => (__in) =>
        {
            var (increment,modulus,target) = __in;
#line 230 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            var inner = ModularIncrementPhaseLE.Partial(new Func<PhaseLittleEndian, (Int64,Int64,PhaseLittleEndian)>((_arg1) => (increment, modulus, _arg1)));
#line 231 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            var ancilla = Allocate.Apply(1L);
#line 232 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            var extraZeroBit = ancilla[0L];
#line 233 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            ApplyPhaseLEOperationOnLECA.Apply((((IUnitary)inner), new LittleEndian((target + new QArray<Qubit>()
            {extraZeroBit}))));
#line hidden
            Release.Apply(ancilla);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Int64,Int64,LittleEndian), QVoid> AdjointBody => (__in) =>
        {
            var (increment,modulus,target) = __in;
#line 230 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            var inner = ModularIncrementPhaseLE.Partial(new Func<PhaseLittleEndian, (Int64,Int64,PhaseLittleEndian)>((_arg1) => (increment, modulus, _arg1)));
            var ancilla = Allocate.Apply(1L);
#line 232 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            var extraZeroBit = ancilla[0L];
            ApplyPhaseLEOperationOnLECA.Adjoint.Apply((((IUnitary)inner), new LittleEndian((target + new QArray<Qubit>()
            {extraZeroBit}))));
#line hidden
            Release.Apply(ancilla);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Int64,Int64,LittleEndian)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(increment,modulus,target)) = __in;
            var inner = ModularIncrementPhaseLE.Partial(new Func<PhaseLittleEndian, (Int64,Int64,PhaseLittleEndian)>((_arg1) => (increment, modulus, _arg1)));
            var ancilla = Allocate.Apply(1L);
            var extraZeroBit = ancilla[0L];
            ApplyPhaseLEOperationOnLECA.Controlled.Apply((controlQubits, (((IUnitary)inner), new LittleEndian((target + new QArray<Qubit>()
            {extraZeroBit})))));
#line hidden
            Release.Apply(ancilla);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Int64,Int64,LittleEndian)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,(increment,modulus,target)) = __in;
            var inner = ModularIncrementPhaseLE.Partial(new Func<PhaseLittleEndian, (Int64,Int64,PhaseLittleEndian)>((_arg1) => (increment, modulus, _arg1)));
            var ancilla = Allocate.Apply(1L);
            var extraZeroBit = ancilla[0L];
            ApplyPhaseLEOperationOnLECA.Adjoint.Controlled.Apply((controlQubits, (((IUnitary)inner), new LittleEndian((target + new QArray<Qubit>()
            {extraZeroBit})))));
#line hidden
            Release.Apply(ancilla);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.ApplyPhaseLEOperationOnLECA = this.Factory.Get<IUnitary<(IUnitary,LittleEndian)>>(typeof(Microsoft.Quantum.Canon.ApplyPhaseLEOperationOnLECA));
            this.ModularIncrementPhaseLE = this.Factory.Get<IUnitary<(Int64,Int64,PhaseLittleEndian)>>(typeof(Microsoft.Quantum.Canon.ModularIncrementPhaseLE));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
        }

        public override IApplyData __dataIn((Int64,Int64,LittleEndian) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 increment, Int64 modulus, LittleEndian target)
        {
            return __m__.Run<ModularIncrementLE, (Int64,Int64,LittleEndian), QVoid>((increment, modulus, target));
        }
    }

    public class CopyMostSignificantBitLE : Adjointable<(LittleEndian,Qubit)>, ICallable
    {
        public CopyMostSignificantBitLE(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(LittleEndian,Qubit)>, IApplyData
        {
            public In((LittleEndian,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "CopyMostSignificantBitLE";
        String ICallable.FullName => "Microsoft.Quantum.Canon.CopyMostSignificantBitLE";
        protected ICallable<QArray<Qubit>, QArray<Qubit>> AsQubitArray
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveCNOT
        {
            get;
            set;
        }

        protected ICallable Tail
        {
            get;
            set;
        }

        public override Func<(LittleEndian,Qubit), QVoid> Body => (__in) =>
        {
            var (from,target) = __in;
#line 260 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            var mostSingificantQubit = Tail.Apply<Qubit>(AsQubitArray.Apply(from));
#line 261 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            MicrosoftQuantumPrimitiveCNOT.Apply((mostSingificantQubit, target));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(LittleEndian,Qubit), QVoid> AdjointBody => (__in) =>
        {
            var (from,target) = __in;
#line 260 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            var mostSingificantQubit = Tail.Apply<Qubit>(AsQubitArray.Apply(from));
            MicrosoftQuantumPrimitiveCNOT.Adjoint.Apply((mostSingificantQubit, target));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.AsQubitArray = this.Factory.Get<ICallable<QArray<Qubit>, QArray<Qubit>>>(typeof(Microsoft.Quantum.Canon.AsQubitArray));
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
            this.Tail = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Tail<>));
        }

        public override IApplyData __dataIn((LittleEndian,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, LittleEndian from, Qubit target)
        {
            return __m__.Run<CopyMostSignificantBitLE, (LittleEndian,Qubit), QVoid>((from, target));
        }
    }

    public class ModularIncrementPhaseLE : Unitary<(Int64,Int64,PhaseLittleEndian)>, ICallable
    {
        public ModularIncrementPhaseLE(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64,PhaseLittleEndian)>, IApplyData
        {
            public In((Int64,Int64,PhaseLittleEndian) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item3)?.Qubits;
        }

        String ICallable.Name => "ModularIncrementPhaseLE";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ModularIncrementPhaseLE";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IAdjointable<(IAdjointable,PhaseLittleEndian)> ApplyLEOperationOnPhaseLEA
        {
            get;
            set;
        }

        protected ICallable<(Boolean,Boolean,String), QVoid> AssertBoolEqual
        {
            get;
            set;
        }

        protected IUnitary<(Result,LittleEndian)> AssertHighestBit
        {
            get;
            set;
        }

        protected IUnitary<(Int64,PhaseLittleEndian)> AssertLessThanPhaseLE
        {
            get;
            set;
        }

        protected IAdjointable<(LittleEndian,Qubit)> CopyMostSignificantBitLE
        {
            get;
            set;
        }

        protected IUnitary<(Int64,PhaseLittleEndian)> IntegerIncrementPhaseLE
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

        protected ICallable<QVoid, Boolean> _EnableExtraAssertsForArithmetic
        {
            get;
            set;
        }

        public override Func<(Int64,Int64,PhaseLittleEndian), QVoid> Body => (__in) =>
        {
            var (increment,modulus,target) = __in;
#line 288 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            AssertBoolEqual.Apply(((modulus <= 2L.Pow((target.Count - 1L))), true, ("`multiplier` must be big enough to fit integers modulo `modulus`" + "with highest bit set to 0")));
#line 293 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            if (_EnableExtraAssertsForArithmetic.Apply(QVoid.Instance))
            {
                // assert that the highest bit is zero, by switching to computational basis
#line 295 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
                ApplyLEOperationOnPhaseLEA.Apply((((IAdjointable)AssertHighestBit.Partial(new Func<LittleEndian, (Result,LittleEndian)>((_arg1) => (Result.Zero, _arg1)))), target));
                // check that the input is less than modulus
#line 297 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
                AssertLessThanPhaseLE.Apply((modulus, target));
            }

#line 300 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            var ancilla = Allocate.Apply(1L);
#line 301 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            var lessThanModulusFlag = ancilla[0L];
#line 302 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            var copyMostSignificantBitPhaseLE = ApplyLEOperationOnPhaseLEA.Partial(new Func<PhaseLittleEndian, (IAdjointable,PhaseLittleEndian)>((_arg1) => (((IAdjointable)CopyMostSignificantBitLE.Partial(new Func<LittleEndian, (LittleEndian,Qubit)>((_arg2) => (_arg2, lessThanModulusFlag)))), _arg1)));
            // lets track the state of target register through the computation 
#line 305 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            IntegerIncrementPhaseLE.Apply((increment, target));
            // the state is |x+a⟩ in QFT basis 
#line 307 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            IntegerIncrementPhaseLE.Adjoint.Apply((modulus, target));
            // the state is |x+a-N⟩ in QFT basis
#line 309 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            copyMostSignificantBitPhaseLE.Apply(target);
            // lessThanModulusFlag is set to 1 if x+a < N 
#line 311 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            IntegerIncrementPhaseLE.Controlled.Apply((new QArray<Qubit>()
            {lessThanModulusFlag}, (modulus, target)));
            // the state is |x+a (mod N)⟩ in QFT basis
            // Now let us restore the lessThanModulusFlag qubit back to zero
#line 314 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            IntegerIncrementPhaseLE.Adjoint.Apply((increment, target));
#line 315 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            MicrosoftQuantumPrimitiveX.Apply(lessThanModulusFlag);
#line 316 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            copyMostSignificantBitPhaseLE.Apply(target);
#line 317 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            IntegerIncrementPhaseLE.Apply((increment, target));
#line hidden
            Release.Apply(ancilla);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Int64,Int64,PhaseLittleEndian), QVoid> AdjointBody => (__in) =>
        {
            var (increment,modulus,target) = __in;
            AssertBoolEqual.Apply(((modulus <= 2L.Pow((target.Count - 1L))), true, ("`multiplier` must be big enough to fit integers modulo `modulus`" + "with highest bit set to 0")));
            var ancilla = Allocate.Apply(1L);
#line 301 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            var lessThanModulusFlag = ancilla[0L];
#line 302 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            var copyMostSignificantBitPhaseLE = ApplyLEOperationOnPhaseLEA.Partial(new Func<PhaseLittleEndian, (IAdjointable,PhaseLittleEndian)>((_arg1) => (((IAdjointable)CopyMostSignificantBitLE.Partial(new Func<LittleEndian, (LittleEndian,Qubit)>((_arg2) => (_arg2, lessThanModulusFlag)))), _arg1)));
            // lets track the state of target register through the computation 
            // the state is |x+a⟩ in QFT basis 
            // the state is |x+a-N⟩ in QFT basis
            // lessThanModulusFlag is set to 1 if x+a < N 
            // the state is |x+a (mod N)⟩ in QFT basis
            // Now let us restore the lessThanModulusFlag qubit back to zero
            IntegerIncrementPhaseLE.Adjoint.Apply((increment, target));
            copyMostSignificantBitPhaseLE.Adjoint.Apply(target);
            MicrosoftQuantumPrimitiveX.Adjoint.Apply(lessThanModulusFlag);
            IntegerIncrementPhaseLE.Adjoint.Adjoint.Apply((increment, target));
            IntegerIncrementPhaseLE.Controlled.Adjoint.Apply((new QArray<Qubit>()
            {lessThanModulusFlag}, (modulus, target)));
            copyMostSignificantBitPhaseLE.Adjoint.Apply(target);
            IntegerIncrementPhaseLE.Adjoint.Adjoint.Apply((modulus, target));
            IntegerIncrementPhaseLE.Adjoint.Apply((increment, target));
#line hidden
            Release.Apply(ancilla);
            if (_EnableExtraAssertsForArithmetic.Apply(QVoid.Instance))
            {
                // assert that the highest bit is zero, by switching to computational basis
                // check that the input is less than modulus
                AssertLessThanPhaseLE.Adjoint.Apply((modulus, target));
                ApplyLEOperationOnPhaseLEA.Adjoint.Apply((((IAdjointable)AssertHighestBit.Partial(new Func<LittleEndian, (Result,LittleEndian)>((_arg1) => (Result.Zero, _arg1)))), target));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Int64,Int64,PhaseLittleEndian)), QVoid> ControlledBody => (__in) =>
        {
            var (controls,(increment,modulus,target)) = __in;
#line 323 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            AssertBoolEqual.Apply(((modulus <= 2L.Pow((target.Count - 1L))), true, ("`multiplier` must be big enough to fit integers modulo `modulus`" + "with highest bit set to 0")));
#line 328 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            if (_EnableExtraAssertsForArithmetic.Apply(QVoid.Instance))
            {
                // assert that the highest bit is zero, by switching to computational basis
#line 330 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
                ApplyLEOperationOnPhaseLEA.Apply((((IAdjointable)AssertHighestBit.Partial(new Func<LittleEndian, (Result,LittleEndian)>((_arg1) => (Result.Zero, _arg1)))), target));
                // check that the input is less than modulus
#line 332 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
                AssertLessThanPhaseLE.Apply((modulus, target));
            }

            // note that controlled version is correct only under the assumption 
            // that the value of target is less than modulus
#line 337 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            var ancilla = Allocate.Apply(1L);
#line 338 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            var lessThanModulusFlag = ancilla[0L];
#line 339 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            var copyMostSignificantBitPhaseLE = ApplyLEOperationOnPhaseLEA.Partial(new Func<PhaseLittleEndian, (IAdjointable,PhaseLittleEndian)>((_arg1) => (((IAdjointable)CopyMostSignificantBitLE.Partial(new Func<LittleEndian, (LittleEndian,Qubit)>((_arg2) => (_arg2, lessThanModulusFlag)))), _arg1)));
            // lets track the state of target register through the computation 
#line 342 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            IntegerIncrementPhaseLE.Controlled.Apply((controls, (increment, target)));
            // the state is |x+a⟩ in QFT basis 
#line 344 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            IntegerIncrementPhaseLE.Adjoint.Apply((modulus, target));
            // the state is |x+a-N⟩ in QFT basis 
#line 346 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            copyMostSignificantBitPhaseLE.Apply(target);
            // lessThanModulusFlag is set to 1 if x+a < N 
#line 348 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            IntegerIncrementPhaseLE.Controlled.Apply((new QArray<Qubit>()
            {lessThanModulusFlag}, (modulus, target)));
            // the state is |x+a (mod N)⟩ in QFT basis
            // Now let us restore the lessThanModulusFlag qubit back to zero
#line 351 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            IntegerIncrementPhaseLE.Adjoint.Controlled.Apply((controls, (increment, target)));
#line 352 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            MicrosoftQuantumPrimitiveX.Apply(lessThanModulusFlag);
#line 353 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            copyMostSignificantBitPhaseLE.Apply(target);
#line 354 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            IntegerIncrementPhaseLE.Controlled.Apply((controls, (increment, target)));
#line hidden
            Release.Apply(ancilla);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Int64,Int64,PhaseLittleEndian)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controls,(increment,modulus,target)) = __in;
            AssertBoolEqual.Apply(((modulus <= 2L.Pow((target.Count - 1L))), true, ("`multiplier` must be big enough to fit integers modulo `modulus`" + "with highest bit set to 0")));
            // note that controlled version is correct only under the assumption 
            // that the value of target is less than modulus
            var ancilla = Allocate.Apply(1L);
#line 338 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            var lessThanModulusFlag = ancilla[0L];
#line 339 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            var copyMostSignificantBitPhaseLE = ApplyLEOperationOnPhaseLEA.Partial(new Func<PhaseLittleEndian, (IAdjointable,PhaseLittleEndian)>((_arg1) => (((IAdjointable)CopyMostSignificantBitLE.Partial(new Func<LittleEndian, (LittleEndian,Qubit)>((_arg2) => (_arg2, lessThanModulusFlag)))), _arg1)));
            // lets track the state of target register through the computation 
            // the state is |x+a⟩ in QFT basis 
            // the state is |x+a-N⟩ in QFT basis 
            // lessThanModulusFlag is set to 1 if x+a < N 
            // the state is |x+a (mod N)⟩ in QFT basis
            // Now let us restore the lessThanModulusFlag qubit back to zero
            IntegerIncrementPhaseLE.Controlled.Adjoint.Apply((controls, (increment, target)));
            copyMostSignificantBitPhaseLE.Adjoint.Apply(target);
            MicrosoftQuantumPrimitiveX.Adjoint.Apply(lessThanModulusFlag);
            IntegerIncrementPhaseLE.Adjoint.Controlled.Adjoint.Apply((controls, (increment, target)));
            IntegerIncrementPhaseLE.Controlled.Adjoint.Apply((new QArray<Qubit>()
            {lessThanModulusFlag}, (modulus, target)));
            copyMostSignificantBitPhaseLE.Adjoint.Apply(target);
            IntegerIncrementPhaseLE.Adjoint.Adjoint.Apply((modulus, target));
            IntegerIncrementPhaseLE.Controlled.Adjoint.Apply((controls, (increment, target)));
#line hidden
            Release.Apply(ancilla);
            if (_EnableExtraAssertsForArithmetic.Apply(QVoid.Instance))
            {
                // assert that the highest bit is zero, by switching to computational basis
                // check that the input is less than modulus
                AssertLessThanPhaseLE.Adjoint.Apply((modulus, target));
                ApplyLEOperationOnPhaseLEA.Adjoint.Apply((((IAdjointable)AssertHighestBit.Partial(new Func<LittleEndian, (Result,LittleEndian)>((_arg1) => (Result.Zero, _arg1)))), target));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.ApplyLEOperationOnPhaseLEA = this.Factory.Get<IAdjointable<(IAdjointable,PhaseLittleEndian)>>(typeof(Microsoft.Quantum.Canon.ApplyLEOperationOnPhaseLEA));
            this.AssertBoolEqual = this.Factory.Get<ICallable<(Boolean,Boolean,String), QVoid>>(typeof(Microsoft.Quantum.Canon.AssertBoolEqual));
            this.AssertHighestBit = this.Factory.Get<IUnitary<(Result,LittleEndian)>>(typeof(Microsoft.Quantum.Canon.AssertHighestBit));
            this.AssertLessThanPhaseLE = this.Factory.Get<IUnitary<(Int64,PhaseLittleEndian)>>(typeof(Microsoft.Quantum.Canon.AssertLessThanPhaseLE));
            this.CopyMostSignificantBitLE = this.Factory.Get<IAdjointable<(LittleEndian,Qubit)>>(typeof(Microsoft.Quantum.Canon.CopyMostSignificantBitLE));
            this.IntegerIncrementPhaseLE = this.Factory.Get<IUnitary<(Int64,PhaseLittleEndian)>>(typeof(Microsoft.Quantum.Canon.IntegerIncrementPhaseLE));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
            this._EnableExtraAssertsForArithmetic = this.Factory.Get<ICallable<QVoid, Boolean>>(typeof(Microsoft.Quantum.Canon._EnableExtraAssertsForArithmetic));
        }

        public override IApplyData __dataIn((Int64,Int64,PhaseLittleEndian) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 increment, Int64 modulus, PhaseLittleEndian target)
        {
            return __m__.Run<ModularIncrementPhaseLE, (Int64,Int64,PhaseLittleEndian), QVoid>((increment, modulus, target));
        }
    }

    public class ModularAddProductLE : Unitary<(Int64,Int64,LittleEndian,LittleEndian)>, ICallable
    {
        public ModularAddProductLE(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64,LittleEndian,LittleEndian)>, IApplyData
        {
            public In((Int64,Int64,LittleEndian,LittleEndian) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item3)?.Qubits, ((IApplyData)Data.Item4)?.Qubits);
        }

        String ICallable.Name => "ModularAddProductLE";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ModularAddProductLE";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<(IUnitary,LittleEndian)> ApplyPhaseLEOperationOnLECA
        {
            get;
            set;
        }

        protected IUnitary<(Int64,Int64,LittleEndian,PhaseLittleEndian)> ModularAddProductPhaseLE
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        public override Func<(Int64,Int64,LittleEndian,LittleEndian), QVoid> Body => (__in) =>
        {
            var (constMultiplier,modulus,multiplier,summand) = __in;
#line 393 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            var inner = ModularAddProductPhaseLE.Partial(new Func<PhaseLittleEndian, (Int64,Int64,LittleEndian,PhaseLittleEndian)>((_arg1) => (constMultiplier, modulus, multiplier, _arg1)));
#line 394 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            var ancilla = Allocate.Apply(1L);
#line 395 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            var extraZeroBit = ancilla[0L];
#line 396 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            ApplyPhaseLEOperationOnLECA.Apply((((IUnitary)inner), new LittleEndian((summand + new QArray<Qubit>()
            {extraZeroBit}))));
#line hidden
            Release.Apply(ancilla);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Int64,Int64,LittleEndian,LittleEndian), QVoid> AdjointBody => (__in) =>
        {
            var (constMultiplier,modulus,multiplier,summand) = __in;
#line 393 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            var inner = ModularAddProductPhaseLE.Partial(new Func<PhaseLittleEndian, (Int64,Int64,LittleEndian,PhaseLittleEndian)>((_arg1) => (constMultiplier, modulus, multiplier, _arg1)));
            var ancilla = Allocate.Apply(1L);
#line 395 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            var extraZeroBit = ancilla[0L];
            ApplyPhaseLEOperationOnLECA.Adjoint.Apply((((IUnitary)inner), new LittleEndian((summand + new QArray<Qubit>()
            {extraZeroBit}))));
#line hidden
            Release.Apply(ancilla);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Int64,Int64,LittleEndian,LittleEndian)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(constMultiplier,modulus,multiplier,summand)) = __in;
            var inner = ModularAddProductPhaseLE.Partial(new Func<PhaseLittleEndian, (Int64,Int64,LittleEndian,PhaseLittleEndian)>((_arg1) => (constMultiplier, modulus, multiplier, _arg1)));
            var ancilla = Allocate.Apply(1L);
            var extraZeroBit = ancilla[0L];
            ApplyPhaseLEOperationOnLECA.Controlled.Apply((controlQubits, (((IUnitary)inner), new LittleEndian((summand + new QArray<Qubit>()
            {extraZeroBit})))));
#line hidden
            Release.Apply(ancilla);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Int64,Int64,LittleEndian,LittleEndian)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,(constMultiplier,modulus,multiplier,summand)) = __in;
            var inner = ModularAddProductPhaseLE.Partial(new Func<PhaseLittleEndian, (Int64,Int64,LittleEndian,PhaseLittleEndian)>((_arg1) => (constMultiplier, modulus, multiplier, _arg1)));
            var ancilla = Allocate.Apply(1L);
            var extraZeroBit = ancilla[0L];
            ApplyPhaseLEOperationOnLECA.Adjoint.Controlled.Apply((controlQubits, (((IUnitary)inner), new LittleEndian((summand + new QArray<Qubit>()
            {extraZeroBit})))));
#line hidden
            Release.Apply(ancilla);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.ApplyPhaseLEOperationOnLECA = this.Factory.Get<IUnitary<(IUnitary,LittleEndian)>>(typeof(Microsoft.Quantum.Canon.ApplyPhaseLEOperationOnLECA));
            this.ModularAddProductPhaseLE = this.Factory.Get<IUnitary<(Int64,Int64,LittleEndian,PhaseLittleEndian)>>(typeof(Microsoft.Quantum.Canon.ModularAddProductPhaseLE));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
        }

        public override IApplyData __dataIn((Int64,Int64,LittleEndian,LittleEndian) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 constMultiplier, Int64 modulus, LittleEndian multiplier, LittleEndian summand)
        {
            return __m__.Run<ModularAddProductLE, (Int64,Int64,LittleEndian,LittleEndian), QVoid>((constMultiplier, modulus, multiplier, summand));
        }
    }

    public class ModularAddProductPhaseLE : Unitary<(Int64,Int64,LittleEndian,PhaseLittleEndian)>, ICallable
    {
        public ModularAddProductPhaseLE(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64,LittleEndian,PhaseLittleEndian)>, IApplyData
        {
            public In((Int64,Int64,LittleEndian,PhaseLittleEndian) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item3)?.Qubits, ((IApplyData)Data.Item4)?.Qubits);
        }

        String ICallable.Name => "ModularAddProductPhaseLE";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ModularAddProductPhaseLE";
        protected IUnitary<(IUnitary,PhaseLittleEndian)> ApplyLEOperationOnPhaseLECA
        {
            get;
            set;
        }

        protected ICallable<(Boolean,Boolean,String), QVoid> AssertBoolEqual
        {
            get;
            set;
        }

        protected IUnitary<(Result,LittleEndian)> AssertHighestBit
        {
            get;
            set;
        }

        protected IUnitary<(Int64,PhaseLittleEndian)> AssertLessThanPhaseLE
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64,Int64), Int64> ExpMod
        {
            get;
            set;
        }

        protected IUnitary<(Int64,Int64,PhaseLittleEndian)> ModularIncrementPhaseLE
        {
            get;
            set;
        }

        protected ICallable<QVoid, Boolean> _EnableExtraAssertsForArithmetic
        {
            get;
            set;
        }

        public override Func<(Int64,Int64,LittleEndian,PhaseLittleEndian), QVoid> Body => (__in) =>
        {
            var (constMultiplier,modulus,multiplier,phaseSummand) = __in;
#line 421 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            AssertBoolEqual.Apply(((modulus <= 2L.Pow((phaseSummand.Count - 1L))), true, ("`multiplier` must be big enough to fit integers modulo `modulus`" + "with highest bit set to 0")));
#line 426 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            AssertBoolEqual.Apply((((constMultiplier >= 0L) && (constMultiplier < modulus)), true, "`constMultiplier` must be between 0 and `modulus`-1"));
#line 430 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            if (_EnableExtraAssertsForArithmetic.Apply(QVoid.Instance))
            {
                // assert that the highest bit is zero, by switching to computational basis
#line 432 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
                ApplyLEOperationOnPhaseLECA.Apply((((IUnitary)AssertHighestBit.Partial(new Func<LittleEndian, (Result,LittleEndian)>((_arg1) => (Result.Zero, _arg1)))), phaseSummand));
                // check that the input is less than modulus
#line 434 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
                AssertLessThanPhaseLE.Apply((modulus, phaseSummand));
            }

#line 437 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            foreach (var i in new Range(0L, (multiplier.Count - 1L)))
            {
#line 438 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
                var summand = ((ExpMod.Apply((2L, i, modulus)) * constMultiplier) % modulus);
#line 439 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
                ModularIncrementPhaseLE.Controlled.Apply((new QArray<Qubit>()
                {multiplier[i]}, (summand, modulus, phaseSummand)));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Int64,Int64,LittleEndian,PhaseLittleEndian), QVoid> AdjointBody => (__in) =>
        {
            var (constMultiplier,modulus,multiplier,phaseSummand) = __in;
            AssertBoolEqual.Apply(((modulus <= 2L.Pow((phaseSummand.Count - 1L))), true, ("`multiplier` must be big enough to fit integers modulo `modulus`" + "with highest bit set to 0")));
            AssertBoolEqual.Apply((((constMultiplier >= 0L) && (constMultiplier < modulus)), true, "`constMultiplier` must be between 0 and `modulus`-1"));
            foreach (var i in new Range((0L - ((((multiplier.Count - 1L) - 0L) / 1L) * -(1L))), -(1L), 0L))
            {
#line 438 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
                var summand = ((ExpMod.Apply((2L, i, modulus)) * constMultiplier) % modulus);
                ModularIncrementPhaseLE.Controlled.Adjoint.Apply((new QArray<Qubit>()
                {multiplier[i]}, (summand, modulus, phaseSummand)));
            }

            if (_EnableExtraAssertsForArithmetic.Apply(QVoid.Instance))
            {
                // assert that the highest bit is zero, by switching to computational basis
                // check that the input is less than modulus
                AssertLessThanPhaseLE.Adjoint.Apply((modulus, phaseSummand));
                ApplyLEOperationOnPhaseLECA.Adjoint.Apply((((IUnitary)AssertHighestBit.Partial(new Func<LittleEndian, (Result,LittleEndian)>((_arg1) => (Result.Zero, _arg1)))), phaseSummand));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Int64,Int64,LittleEndian,PhaseLittleEndian)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(constMultiplier,modulus,multiplier,phaseSummand)) = __in;
            AssertBoolEqual.Apply(((modulus <= 2L.Pow((phaseSummand.Count - 1L))), true, ("`multiplier` must be big enough to fit integers modulo `modulus`" + "with highest bit set to 0")));
            AssertBoolEqual.Apply((((constMultiplier >= 0L) && (constMultiplier < modulus)), true, "`constMultiplier` must be between 0 and `modulus`-1"));
            if (_EnableExtraAssertsForArithmetic.Apply(QVoid.Instance))
            {
                // assert that the highest bit is zero, by switching to computational basis
                ApplyLEOperationOnPhaseLECA.Controlled.Apply((controlQubits, (((IUnitary)AssertHighestBit.Partial(new Func<LittleEndian, (Result,LittleEndian)>((_arg1) => (Result.Zero, _arg1)))), phaseSummand)));
                // check that the input is less than modulus
                AssertLessThanPhaseLE.Controlled.Apply((controlQubits, (modulus, phaseSummand)));
            }

            foreach (var i in new Range(0L, (multiplier.Count - 1L)))
            {
                var summand = ((ExpMod.Apply((2L, i, modulus)) * constMultiplier) % modulus);
                ModularIncrementPhaseLE.Controlled.Controlled.Apply((controlQubits, (new QArray<Qubit>()
                {multiplier[i]}, (summand, modulus, phaseSummand))));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Int64,Int64,LittleEndian,PhaseLittleEndian)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,(constMultiplier,modulus,multiplier,phaseSummand)) = __in;
            AssertBoolEqual.Apply(((modulus <= 2L.Pow((phaseSummand.Count - 1L))), true, ("`multiplier` must be big enough to fit integers modulo `modulus`" + "with highest bit set to 0")));
            AssertBoolEqual.Apply((((constMultiplier >= 0L) && (constMultiplier < modulus)), true, "`constMultiplier` must be between 0 and `modulus`-1"));
            foreach (var i in new Range((0L - ((((multiplier.Count - 1L) - 0L) / 1L) * -(1L))), -(1L), 0L))
            {
                var summand = ((ExpMod.Apply((2L, i, modulus)) * constMultiplier) % modulus);
                ModularIncrementPhaseLE.Controlled.Adjoint.Controlled.Apply((controlQubits, (new QArray<Qubit>()
                {multiplier[i]}, (summand, modulus, phaseSummand))));
            }

            if (_EnableExtraAssertsForArithmetic.Apply(QVoid.Instance))
            {
                // assert that the highest bit is zero, by switching to computational basis
                // check that the input is less than modulus
                AssertLessThanPhaseLE.Adjoint.Controlled.Apply((controlQubits, (modulus, phaseSummand)));
                ApplyLEOperationOnPhaseLECA.Adjoint.Controlled.Apply((controlQubits, (((IUnitary)AssertHighestBit.Partial(new Func<LittleEndian, (Result,LittleEndian)>((_arg1) => (Result.Zero, _arg1)))), phaseSummand)));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.ApplyLEOperationOnPhaseLECA = this.Factory.Get<IUnitary<(IUnitary,PhaseLittleEndian)>>(typeof(Microsoft.Quantum.Canon.ApplyLEOperationOnPhaseLECA));
            this.AssertBoolEqual = this.Factory.Get<ICallable<(Boolean,Boolean,String), QVoid>>(typeof(Microsoft.Quantum.Canon.AssertBoolEqual));
            this.AssertHighestBit = this.Factory.Get<IUnitary<(Result,LittleEndian)>>(typeof(Microsoft.Quantum.Canon.AssertHighestBit));
            this.AssertLessThanPhaseLE = this.Factory.Get<IUnitary<(Int64,PhaseLittleEndian)>>(typeof(Microsoft.Quantum.Canon.AssertLessThanPhaseLE));
            this.ExpMod = this.Factory.Get<ICallable<(Int64,Int64,Int64), Int64>>(typeof(Microsoft.Quantum.Canon.ExpMod));
            this.ModularIncrementPhaseLE = this.Factory.Get<IUnitary<(Int64,Int64,PhaseLittleEndian)>>(typeof(Microsoft.Quantum.Canon.ModularIncrementPhaseLE));
            this._EnableExtraAssertsForArithmetic = this.Factory.Get<ICallable<QVoid, Boolean>>(typeof(Microsoft.Quantum.Canon._EnableExtraAssertsForArithmetic));
        }

        public override IApplyData __dataIn((Int64,Int64,LittleEndian,PhaseLittleEndian) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 constMultiplier, Int64 modulus, LittleEndian multiplier, PhaseLittleEndian phaseSummand)
        {
            return __m__.Run<ModularAddProductPhaseLE, (Int64,Int64,LittleEndian,PhaseLittleEndian), QVoid>((constMultiplier, modulus, multiplier, phaseSummand));
        }
    }

    public class ModularMultiplyByConstantLE : Unitary<(Int64,Int64,LittleEndian)>, ICallable
    {
        public ModularMultiplyByConstantLE(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64,LittleEndian)>, IApplyData
        {
            public In((Int64,Int64,LittleEndian) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item3)?.Qubits;
        }

        String ICallable.Name => "ModularMultiplyByConstantLE";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ModularMultiplyByConstantLE";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected ICallable<(Boolean,Boolean,String), QVoid> AssertBoolEqual
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64), Int64> InverseMod
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64), Boolean> IsCoprime
        {
            get;
            set;
        }

        protected IUnitary<(Int64,Int64,LittleEndian,LittleEndian)> ModularAddProductLE
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveSWAP
        {
            get;
            set;
        }

        public override Func<(Int64,Int64,LittleEndian), QVoid> Body => (__in) =>
        {
            var (constMultiplier,modulus,multiplier) = __in;
            // Check the preconditions using Microsoft.Quantum.Canon.AssertBoolEqual
#line 477 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            AssertBoolEqual.Apply((((constMultiplier >= 0L) && (constMultiplier < modulus)), true, "`constMultiplier` must be between 0 and `modulus`"));
#line 480 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            AssertBoolEqual.Apply(((modulus <= 2L.Pow(multiplier.Count)), true, "`multiplier` must be big enough to fit integers modulo `modulus`"));
#line 483 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            AssertBoolEqual.Apply((IsCoprime.Apply((constMultiplier, modulus)), true, "`constMultiplier` and `modulus` must be co-prime"));
#line 486 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            var summand = Allocate.Apply(multiplier.Count);
            // recall that newly allocated qubits are all in 0 state 
            // and therefore summandLE encodes 0.
#line 490 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            var summandLE = new LittleEndian(summand);
            // Let us look at what is the result of operations below assuming 
            // multiplier is in computational basis and encodes x 
            // Currently the joint state of multiplier and summandLE is 
            // |x⟩|0⟩
#line 496 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            ModularAddProductLE.Apply((constMultiplier, modulus, multiplier, summandLE));
            // now the joint state is |x⟩|x⋅a(mod N)⟩
#line 499 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            foreach (var i in new Range(0L, (summandLE.Count - 1L)))
            {
#line 500 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
                MicrosoftQuantumPrimitiveSWAP.Apply((summandLE[i], multiplier[i]));
            }

            // now the joint state is |x⋅a(mod N)⟩|x⟩
#line 504 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            var inverseMod = InverseMod.Apply((constMultiplier, modulus));
            // note that the operation below implements the following map:
            // |x⟩|y⟩ ↦ |x⟩|y - a⁻¹⋅x (mod N)⟩
#line 508 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            ModularAddProductLE.Adjoint.Apply((inverseMod, modulus, multiplier, summandLE));
            // now the joint state is |x⋅a(mod N)⟩|x - a⁻¹⋅x⋅a (mod N)⟩ = |x⋅a(mod N)⟩|0⟩
            ;
#line hidden
            Release.Apply(summand);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Int64,Int64,LittleEndian), QVoid> AdjointBody => (__in) =>
        {
            var (constMultiplier,modulus,multiplier) = __in;
            // Check the preconditions using Microsoft.Quantum.Canon.AssertBoolEqual
            AssertBoolEqual.Apply((((constMultiplier >= 0L) && (constMultiplier < modulus)), true, "`constMultiplier` must be between 0 and `modulus`"));
            AssertBoolEqual.Apply(((modulus <= 2L.Pow(multiplier.Count)), true, "`multiplier` must be big enough to fit integers modulo `modulus`"));
            AssertBoolEqual.Apply((IsCoprime.Apply((constMultiplier, modulus)), true, "`constMultiplier` and `modulus` must be co-prime"));
            var summand = Allocate.Apply(multiplier.Count);
            // recall that newly allocated qubits are all in 0 state 
            // and therefore summandLE encodes 0.
#line 490 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            var summandLE = new LittleEndian(summand);
            // Let us look at what is the result of operations below assuming 
            // multiplier is in computational basis and encodes x 
            // Currently the joint state of multiplier and summandLE is 
            // |x⟩|0⟩
            // now the joint state is |x⟩|x⋅a(mod N)⟩
            // now the joint state is |x⋅a(mod N)⟩|x⟩
#line 504 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arithmetic\\Arithmetic.qs"
            var inverseMod = InverseMod.Apply((constMultiplier, modulus));
            // note that the operation below implements the following map:
            // |x⟩|y⟩ ↦ |x⟩|y - a⁻¹⋅x (mod N)⟩
            // now the joint state is |x⋅a(mod N)⟩|x - a⁻¹⋅x⋅a (mod N)⟩ = |x⋅a(mod N)⟩|0⟩
            ModularAddProductLE.Adjoint.Adjoint.Apply((inverseMod, modulus, multiplier, summandLE));
            foreach (var i in new Range((0L - ((((summandLE.Count - 1L) - 0L) / 1L) * -(1L))), -(1L), 0L))
            {
                MicrosoftQuantumPrimitiveSWAP.Adjoint.Apply((summandLE[i], multiplier[i]));
            }

            ModularAddProductLE.Adjoint.Apply((constMultiplier, modulus, multiplier, summandLE));
#line hidden
            Release.Apply(summand);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Int64,Int64,LittleEndian)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(constMultiplier,modulus,multiplier)) = __in;
            // Check the preconditions using Microsoft.Quantum.Canon.AssertBoolEqual
            AssertBoolEqual.Apply((((constMultiplier >= 0L) && (constMultiplier < modulus)), true, "`constMultiplier` must be between 0 and `modulus`"));
            AssertBoolEqual.Apply(((modulus <= 2L.Pow(multiplier.Count)), true, "`multiplier` must be big enough to fit integers modulo `modulus`"));
            AssertBoolEqual.Apply((IsCoprime.Apply((constMultiplier, modulus)), true, "`constMultiplier` and `modulus` must be co-prime"));
            var summand = Allocate.Apply(multiplier.Count);
            // recall that newly allocated qubits are all in 0 state 
            // and therefore summandLE encodes 0.
            var summandLE = new LittleEndian(summand);
            // Let us look at what is the result of operations below assuming 
            // multiplier is in computational basis and encodes x 
            // Currently the joint state of multiplier and summandLE is 
            // |x⟩|0⟩
            ModularAddProductLE.Controlled.Apply((controlQubits, (constMultiplier, modulus, multiplier, summandLE)));
            // now the joint state is |x⟩|x⋅a(mod N)⟩
            foreach (var i in new Range(0L, (summandLE.Count - 1L)))
            {
                MicrosoftQuantumPrimitiveSWAP.Controlled.Apply((controlQubits, (summandLE[i], multiplier[i])));
            }

            // now the joint state is |x⋅a(mod N)⟩|x⟩
            var inverseMod = InverseMod.Apply((constMultiplier, modulus));
            // note that the operation below implements the following map:
            // |x⟩|y⟩ ↦ |x⟩|y - a⁻¹⋅x (mod N)⟩
            ModularAddProductLE.Adjoint.Controlled.Apply((controlQubits, (inverseMod, modulus, multiplier, summandLE)));
            // now the joint state is |x⋅a(mod N)⟩|x - a⁻¹⋅x⋅a (mod N)⟩ = |x⋅a(mod N)⟩|0⟩
            ;
#line hidden
            Release.Apply(summand);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Int64,Int64,LittleEndian)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,(constMultiplier,modulus,multiplier)) = __in;
            // Check the preconditions using Microsoft.Quantum.Canon.AssertBoolEqual
            AssertBoolEqual.Apply((((constMultiplier >= 0L) && (constMultiplier < modulus)), true, "`constMultiplier` must be between 0 and `modulus`"));
            AssertBoolEqual.Apply(((modulus <= 2L.Pow(multiplier.Count)), true, "`multiplier` must be big enough to fit integers modulo `modulus`"));
            AssertBoolEqual.Apply((IsCoprime.Apply((constMultiplier, modulus)), true, "`constMultiplier` and `modulus` must be co-prime"));
            var summand = Allocate.Apply(multiplier.Count);
            // recall that newly allocated qubits are all in 0 state 
            // and therefore summandLE encodes 0.
            var summandLE = new LittleEndian(summand);
            // Let us look at what is the result of operations below assuming 
            // multiplier is in computational basis and encodes x 
            // Currently the joint state of multiplier and summandLE is 
            // |x⟩|0⟩
            // now the joint state is |x⟩|x⋅a(mod N)⟩
            // now the joint state is |x⋅a(mod N)⟩|x⟩
            var inverseMod = InverseMod.Apply((constMultiplier, modulus));
            // note that the operation below implements the following map:
            // |x⟩|y⟩ ↦ |x⟩|y - a⁻¹⋅x (mod N)⟩
            // now the joint state is |x⋅a(mod N)⟩|x - a⁻¹⋅x⋅a (mod N)⟩ = |x⋅a(mod N)⟩|0⟩
            ModularAddProductLE.Adjoint.Adjoint.Controlled.Apply((controlQubits, (inverseMod, modulus, multiplier, summandLE)));
            foreach (var i in new Range((0L - ((((summandLE.Count - 1L) - 0L) / 1L) * -(1L))), -(1L), 0L))
            {
                MicrosoftQuantumPrimitiveSWAP.Adjoint.Controlled.Apply((controlQubits, (summandLE[i], multiplier[i])));
            }

            ModularAddProductLE.Adjoint.Controlled.Apply((controlQubits, (constMultiplier, modulus, multiplier, summandLE)));
#line hidden
            Release.Apply(summand);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.AssertBoolEqual = this.Factory.Get<ICallable<(Boolean,Boolean,String), QVoid>>(typeof(Microsoft.Quantum.Canon.AssertBoolEqual));
            this.InverseMod = this.Factory.Get<ICallable<(Int64,Int64), Int64>>(typeof(Microsoft.Quantum.Canon.InverseMod));
            this.IsCoprime = this.Factory.Get<ICallable<(Int64,Int64), Boolean>>(typeof(Microsoft.Quantum.Canon.IsCoprime));
            this.ModularAddProductLE = this.Factory.Get<IUnitary<(Int64,Int64,LittleEndian,LittleEndian)>>(typeof(Microsoft.Quantum.Canon.ModularAddProductLE));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.MicrosoftQuantumPrimitiveSWAP = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.SWAP));
        }

        public override IApplyData __dataIn((Int64,Int64,LittleEndian) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 constMultiplier, Int64 modulus, LittleEndian multiplier)
        {
            return __m__.Run<ModularMultiplyByConstantLE, (Int64,Int64,LittleEndian), QVoid>((constMultiplier, modulus, multiplier));
        }
    }
}