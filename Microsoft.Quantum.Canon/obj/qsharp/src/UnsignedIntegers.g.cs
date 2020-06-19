#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: UdtDeclaration("Microsoft.Quantum.Canon", "LittleEndian", "Qubit[]", "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs", 731L, 18L, 67L)]
[assembly: UdtDeclaration("Microsoft.Quantum.Canon", "BigEndian", "Qubit[]", "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs", 1035L, 26L, 64L)]
[assembly: UdtDeclaration("Microsoft.Quantum.Canon", "PhaseLittleEndian", "Qubit[]", "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs", 1501L, 39L, 40L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "ApplyReversedOpLittleEndian (op : (Microsoft.Quantum.Canon.LittleEndian => ()), register : Microsoft.Quantum.Canon.BigEndian) : ()", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs", 2230L, 59L, 5L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "ApplyReversedOpLittleEndianA (op : (Microsoft.Quantum.Canon.LittleEndian => () : Adjoint), register : Microsoft.Quantum.Canon.BigEndian) : ()", new string[] { "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs", 2865L, 77L, 5L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "ApplyReversedOpLittleEndianC (op : (Microsoft.Quantum.Canon.LittleEndian => () : Controlled), register : Microsoft.Quantum.Canon.BigEndian) : ()", new string[] { "Controlled" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs", 3526L, 96L, 5L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "ApplyReversedOpLittleEndianCA (op : (Microsoft.Quantum.Canon.LittleEndian => () : Controlled, Adjoint), register : Microsoft.Quantum.Canon.BigEndian) : ()", new string[] { "Controlled", "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs", 4214L, 115L, 5L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "ApplyReversedOpBigEndian (op : (Microsoft.Quantum.Canon.BigEndian => ()), register : Microsoft.Quantum.Canon.LittleEndian) : ()", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs", 5154L, 143L, 5L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "ApplyReversedOpBigEndianA (op : (Microsoft.Quantum.Canon.BigEndian => () : Adjoint), register : Microsoft.Quantum.Canon.LittleEndian) : ()", new string[] { "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs", 5562L, 156L, 5L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "ApplyReversedOpBigEndianC (op : (Microsoft.Quantum.Canon.BigEndian => () : Controlled), register : Microsoft.Quantum.Canon.LittleEndian) : ()", new string[] { "Controlled" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs", 5996L, 170L, 5L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "ApplyReversedOpBigEndianCA (op : (Microsoft.Quantum.Canon.BigEndian => () : Controlled, Adjoint), register : Microsoft.Quantum.Canon.LittleEndian) : ()", new string[] { "Controlled", "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs", 6443L, 184L, 5L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "SwapReverseRegister (register : Qubit[]) : ()", new string[] { "Controlled", "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs", 6993L, 203L, 5L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "ApplyPhaseLEOperationOnLE (op : (Microsoft.Quantum.Canon.PhaseLittleEndian => ()), target : Microsoft.Quantum.Canon.LittleEndian) : ()", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs", 8266L, 236L, 103L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "ApplyPhaseLEOperationOnLEA (op : (Microsoft.Quantum.Canon.PhaseLittleEndian => () : Adjoint), target : Microsoft.Quantum.Canon.LittleEndian) : ()", new string[] { "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs", 8652L, 247L, 114L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "ApplyPhaseLEOperationOnLEC (op : (Microsoft.Quantum.Canon.PhaseLittleEndian => () : Controlled), target : Microsoft.Quantum.Canon.LittleEndian) : ()", new string[] { "Controlled" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs", 9060L, 259L, 117L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "ApplyPhaseLEOperationOnLECA (op : (Microsoft.Quantum.Canon.PhaseLittleEndian => () : Controlled, Adjoint), target : Microsoft.Quantum.Canon.LittleEndian) : ()", new string[] { "Controlled", "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs", 9670L, 276L, 127L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "ApplyLEOperationOnPhaseLE (op : (Microsoft.Quantum.Canon.LittleEndian => ()), target : Microsoft.Quantum.Canon.PhaseLittleEndian) : ()", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs", 11049L, 313L, 103L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "ApplyLEOperationOnPhaseLEA (op : (Microsoft.Quantum.Canon.LittleEndian => () : Adjoint), target : Microsoft.Quantum.Canon.PhaseLittleEndian) : ()", new string[] { "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs", 11379L, 322L, 114L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "ApplyLEOperationOnPhaseLEC (op : (Microsoft.Quantum.Canon.LittleEndian => () : Controlled), target : Microsoft.Quantum.Canon.PhaseLittleEndian) : ()", new string[] { "Controlled" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs", 11735L, 332L, 117L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "ApplyLEOperationOnPhaseLECA (op : (Microsoft.Quantum.Canon.LittleEndian => () : Controlled, Adjoint), target : Microsoft.Quantum.Canon.PhaseLittleEndian) : ()", new string[] { "Controlled", "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs", 12105L, 342L, 128L)]
#line hidden
namespace Microsoft.Quantum.Canon
{
    public class LittleEndian : QArray<Qubit>, IApplyData
    {
        public LittleEndian()
        {
        }

        public LittleEndian(QArray<Qubit> data) : base(data)
        {
        }

        public void Deconstruct()
        {
        }
    }

    public class BigEndian : QArray<Qubit>, IApplyData
    {
        public BigEndian()
        {
        }

        public BigEndian(QArray<Qubit> data) : base(data)
        {
        }

        public void Deconstruct()
        {
        }
    }

    public class PhaseLittleEndian : QArray<Qubit>, IApplyData
    {
        public PhaseLittleEndian()
        {
        }

        public PhaseLittleEndian(QArray<Qubit> data) : base(data)
        {
        }

        public void Deconstruct()
        {
        }
    }

    public class ApplyReversedOpLittleEndian : Operation<(ICallable,BigEndian), QVoid>, ICallable
    {
        public ApplyReversedOpLittleEndian(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(ICallable,BigEndian)>, IApplyData
        {
            public In((ICallable,BigEndian) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "ApplyReversedOpLittleEndian";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ApplyReversedOpLittleEndian";
        protected ICallable<QArray<Qubit>, QArray<Qubit>> AsQubitArray
        {
            get;
            set;
        }

        protected ICallable Reverse
        {
            get;
            set;
        }

        public override Func<(ICallable,BigEndian), QVoid> Body => (__in) =>
        {
            var (op,register) = __in;
#line 61 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            var bareReversed = Reverse.Apply<QArray<Qubit>>(AsQubitArray.Apply(register));
#line 62 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            var reversed = new LittleEndian(bareReversed);
#line 63 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            op.Apply(reversed);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.AsQubitArray = this.Factory.Get<ICallable<QArray<Qubit>, QArray<Qubit>>>(typeof(Microsoft.Quantum.Canon.AsQubitArray));
            this.Reverse = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Reverse<>));
        }

        public override IApplyData __dataIn((ICallable,BigEndian) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, ICallable op, BigEndian register)
        {
            return __m__.Run<ApplyReversedOpLittleEndian, (ICallable,BigEndian), QVoid>((op, register));
        }
    }

    public class ApplyReversedOpLittleEndianA : Adjointable<(IAdjointable,BigEndian)>, ICallable
    {
        public ApplyReversedOpLittleEndianA(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IAdjointable,BigEndian)>, IApplyData
        {
            public In((IAdjointable,BigEndian) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "ApplyReversedOpLittleEndianA";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ApplyReversedOpLittleEndianA";
        protected ICallable<QArray<Qubit>, QArray<Qubit>> AsQubitArray
        {
            get;
            set;
        }

        protected ICallable Reverse
        {
            get;
            set;
        }

        public override Func<(IAdjointable,BigEndian), QVoid> Body => (__in) =>
        {
            var (op,register) = __in;
#line 79 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            var bareReversed = Reverse.Apply<QArray<Qubit>>(AsQubitArray.Apply(register));
#line 80 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            var reversed = new LittleEndian(bareReversed);
#line 81 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            op.Apply(reversed);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IAdjointable,BigEndian), QVoid> AdjointBody => (__in) =>
        {
            var (op,register) = __in;
#line 79 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            var bareReversed = Reverse.Apply<QArray<Qubit>>(AsQubitArray.Apply(register));
#line 80 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            var reversed = new LittleEndian(bareReversed);
            op.Adjoint.Apply(reversed);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.AsQubitArray = this.Factory.Get<ICallable<QArray<Qubit>, QArray<Qubit>>>(typeof(Microsoft.Quantum.Canon.AsQubitArray));
            this.Reverse = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Reverse<>));
        }

        public override IApplyData __dataIn((IAdjointable,BigEndian) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IAdjointable op, BigEndian register)
        {
            return __m__.Run<ApplyReversedOpLittleEndianA, (IAdjointable,BigEndian), QVoid>((op, register));
        }
    }

    public class ApplyReversedOpLittleEndianC : Controllable<(IControllable,BigEndian)>, ICallable
    {
        public ApplyReversedOpLittleEndianC(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IControllable,BigEndian)>, IApplyData
        {
            public In((IControllable,BigEndian) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "ApplyReversedOpLittleEndianC";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ApplyReversedOpLittleEndianC";
        protected ICallable<QArray<Qubit>, QArray<Qubit>> AsQubitArray
        {
            get;
            set;
        }

        protected ICallable Reverse
        {
            get;
            set;
        }

        public override Func<(IControllable,BigEndian), QVoid> Body => (__in) =>
        {
            var (op,register) = __in;
#line 98 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            var bareReversed = Reverse.Apply<QArray<Qubit>>(AsQubitArray.Apply(register));
#line 99 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            var reversed = new LittleEndian(bareReversed);
#line 100 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            op.Apply(reversed);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(IControllable,BigEndian)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(op,register)) = __in;
            var bareReversed = Reverse.Apply<QArray<Qubit>>(AsQubitArray.Apply(register));
            var reversed = new LittleEndian(bareReversed);
            op.Controlled.Apply((controlQubits, reversed));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.AsQubitArray = this.Factory.Get<ICallable<QArray<Qubit>, QArray<Qubit>>>(typeof(Microsoft.Quantum.Canon.AsQubitArray));
            this.Reverse = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Reverse<>));
        }

        public override IApplyData __dataIn((IControllable,BigEndian) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IControllable op, BigEndian register)
        {
            return __m__.Run<ApplyReversedOpLittleEndianC, (IControllable,BigEndian), QVoid>((op, register));
        }
    }

    public class ApplyReversedOpLittleEndianCA : Unitary<(IUnitary,BigEndian)>, ICallable
    {
        public ApplyReversedOpLittleEndianCA(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IUnitary,BigEndian)>, IApplyData
        {
            public In((IUnitary,BigEndian) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "ApplyReversedOpLittleEndianCA";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ApplyReversedOpLittleEndianCA";
        protected ICallable<QArray<Qubit>, QArray<Qubit>> AsQubitArray
        {
            get;
            set;
        }

        protected ICallable Reverse
        {
            get;
            set;
        }

        public override Func<(IUnitary,BigEndian), QVoid> Body => (__in) =>
        {
            var (op,register) = __in;
#line 117 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            var bareReversed = Reverse.Apply<QArray<Qubit>>(AsQubitArray.Apply(register));
#line 118 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            var reversed = new LittleEndian(bareReversed);
#line 119 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            op.Apply(reversed);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IUnitary,BigEndian), QVoid> AdjointBody => (__in) =>
        {
            var (op,register) = __in;
#line 117 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            var bareReversed = Reverse.Apply<QArray<Qubit>>(AsQubitArray.Apply(register));
#line 118 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            var reversed = new LittleEndian(bareReversed);
            op.Adjoint.Apply(reversed);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(IUnitary,BigEndian)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(op,register)) = __in;
            var bareReversed = Reverse.Apply<QArray<Qubit>>(AsQubitArray.Apply(register));
            var reversed = new LittleEndian(bareReversed);
            op.Controlled.Apply((controlQubits, reversed));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(IUnitary,BigEndian)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,(op,register)) = __in;
            var bareReversed = Reverse.Apply<QArray<Qubit>>(AsQubitArray.Apply(register));
            var reversed = new LittleEndian(bareReversed);
            op.Adjoint.Controlled.Apply((controlQubits, reversed));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.AsQubitArray = this.Factory.Get<ICallable<QArray<Qubit>, QArray<Qubit>>>(typeof(Microsoft.Quantum.Canon.AsQubitArray));
            this.Reverse = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Reverse<>));
        }

        public override IApplyData __dataIn((IUnitary,BigEndian) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IUnitary op, BigEndian register)
        {
            return __m__.Run<ApplyReversedOpLittleEndianCA, (IUnitary,BigEndian), QVoid>((op, register));
        }
    }

    public class ApplyReversedOpBigEndian : Operation<(ICallable,LittleEndian), QVoid>, ICallable
    {
        public ApplyReversedOpBigEndian(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(ICallable,LittleEndian)>, IApplyData
        {
            public In((ICallable,LittleEndian) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "ApplyReversedOpBigEndian";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ApplyReversedOpBigEndian";
        protected ICallable<QArray<Qubit>, QArray<Qubit>> AsQubitArray
        {
            get;
            set;
        }

        protected ICallable Reverse
        {
            get;
            set;
        }

        public override Func<(ICallable,LittleEndian), QVoid> Body => (__in) =>
        {
            var (op,register) = __in;
#line 145 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            var bareReversed = Reverse.Apply<QArray<Qubit>>(AsQubitArray.Apply(register));
#line 146 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            var reversed = new BigEndian(bareReversed);
#line 147 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            op.Apply(reversed);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.AsQubitArray = this.Factory.Get<ICallable<QArray<Qubit>, QArray<Qubit>>>(typeof(Microsoft.Quantum.Canon.AsQubitArray));
            this.Reverse = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Reverse<>));
        }

        public override IApplyData __dataIn((ICallable,LittleEndian) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, ICallable op, LittleEndian register)
        {
            return __m__.Run<ApplyReversedOpBigEndian, (ICallable,LittleEndian), QVoid>((op, register));
        }
    }

    public class ApplyReversedOpBigEndianA : Adjointable<(IAdjointable,LittleEndian)>, ICallable
    {
        public ApplyReversedOpBigEndianA(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IAdjointable,LittleEndian)>, IApplyData
        {
            public In((IAdjointable,LittleEndian) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "ApplyReversedOpBigEndianA";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ApplyReversedOpBigEndianA";
        protected ICallable<QArray<Qubit>, QArray<Qubit>> AsQubitArray
        {
            get;
            set;
        }

        protected ICallable Reverse
        {
            get;
            set;
        }

        public override Func<(IAdjointable,LittleEndian), QVoid> Body => (__in) =>
        {
            var (op,register) = __in;
#line 158 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            var bareReversed = Reverse.Apply<QArray<Qubit>>(AsQubitArray.Apply(register));
#line 159 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            var reversed = new BigEndian(bareReversed);
#line 160 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            op.Apply(reversed);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IAdjointable,LittleEndian), QVoid> AdjointBody => (__in) =>
        {
            var (op,register) = __in;
#line 158 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            var bareReversed = Reverse.Apply<QArray<Qubit>>(AsQubitArray.Apply(register));
#line 159 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            var reversed = new BigEndian(bareReversed);
            op.Adjoint.Apply(reversed);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.AsQubitArray = this.Factory.Get<ICallable<QArray<Qubit>, QArray<Qubit>>>(typeof(Microsoft.Quantum.Canon.AsQubitArray));
            this.Reverse = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Reverse<>));
        }

        public override IApplyData __dataIn((IAdjointable,LittleEndian) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IAdjointable op, LittleEndian register)
        {
            return __m__.Run<ApplyReversedOpBigEndianA, (IAdjointable,LittleEndian), QVoid>((op, register));
        }
    }

    public class ApplyReversedOpBigEndianC : Controllable<(IControllable,LittleEndian)>, ICallable
    {
        public ApplyReversedOpBigEndianC(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IControllable,LittleEndian)>, IApplyData
        {
            public In((IControllable,LittleEndian) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "ApplyReversedOpBigEndianC";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ApplyReversedOpBigEndianC";
        protected ICallable<QArray<Qubit>, QArray<Qubit>> AsQubitArray
        {
            get;
            set;
        }

        protected ICallable Reverse
        {
            get;
            set;
        }

        public override Func<(IControllable,LittleEndian), QVoid> Body => (__in) =>
        {
            var (op,register) = __in;
#line 172 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            var bareReversed = Reverse.Apply<QArray<Qubit>>(AsQubitArray.Apply(register));
#line 173 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            var reversed = new BigEndian(bareReversed);
#line 174 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            op.Apply(reversed);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(IControllable,LittleEndian)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(op,register)) = __in;
            var bareReversed = Reverse.Apply<QArray<Qubit>>(AsQubitArray.Apply(register));
            var reversed = new BigEndian(bareReversed);
            op.Controlled.Apply((controlQubits, reversed));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.AsQubitArray = this.Factory.Get<ICallable<QArray<Qubit>, QArray<Qubit>>>(typeof(Microsoft.Quantum.Canon.AsQubitArray));
            this.Reverse = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Reverse<>));
        }

        public override IApplyData __dataIn((IControllable,LittleEndian) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IControllable op, LittleEndian register)
        {
            return __m__.Run<ApplyReversedOpBigEndianC, (IControllable,LittleEndian), QVoid>((op, register));
        }
    }

    public class ApplyReversedOpBigEndianCA : Unitary<(IUnitary,LittleEndian)>, ICallable
    {
        public ApplyReversedOpBigEndianCA(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IUnitary,LittleEndian)>, IApplyData
        {
            public In((IUnitary,LittleEndian) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "ApplyReversedOpBigEndianCA";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ApplyReversedOpBigEndianCA";
        protected ICallable<QArray<Qubit>, QArray<Qubit>> AsQubitArray
        {
            get;
            set;
        }

        protected ICallable Reverse
        {
            get;
            set;
        }

        public override Func<(IUnitary,LittleEndian), QVoid> Body => (__in) =>
        {
            var (op,register) = __in;
#line 186 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            var bareReversed = Reverse.Apply<QArray<Qubit>>(AsQubitArray.Apply(register));
#line 187 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            var reversed = new BigEndian(bareReversed);
#line 188 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            op.Apply(reversed);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IUnitary,LittleEndian), QVoid> AdjointBody => (__in) =>
        {
            var (op,register) = __in;
#line 186 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            var bareReversed = Reverse.Apply<QArray<Qubit>>(AsQubitArray.Apply(register));
#line 187 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            var reversed = new BigEndian(bareReversed);
            op.Adjoint.Apply(reversed);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(IUnitary,LittleEndian)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(op,register)) = __in;
            var bareReversed = Reverse.Apply<QArray<Qubit>>(AsQubitArray.Apply(register));
            var reversed = new BigEndian(bareReversed);
            op.Controlled.Apply((controlQubits, reversed));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(IUnitary,LittleEndian)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,(op,register)) = __in;
            var bareReversed = Reverse.Apply<QArray<Qubit>>(AsQubitArray.Apply(register));
            var reversed = new BigEndian(bareReversed);
            op.Adjoint.Controlled.Apply((controlQubits, reversed));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.AsQubitArray = this.Factory.Get<ICallable<QArray<Qubit>, QArray<Qubit>>>(typeof(Microsoft.Quantum.Canon.AsQubitArray));
            this.Reverse = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Reverse<>));
        }

        public override IApplyData __dataIn((IUnitary,LittleEndian) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IUnitary op, LittleEndian register)
        {
            return __m__.Run<ApplyReversedOpBigEndianCA, (IUnitary,LittleEndian), QVoid>((op, register));
        }
    }

    public class SwapReverseRegister : Unitary<QArray<Qubit>>, ICallable
    {
        public SwapReverseRegister(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "SwapReverseRegister";
        String ICallable.FullName => "Microsoft.Quantum.Canon.SwapReverseRegister";
        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveSWAP
        {
            get;
            set;
        }

        public override Func<QArray<Qubit>, QVoid> Body => (__in) =>
        {
            var register = __in;
#line 205 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            var totalQubits = register.Count;
#line 206 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            var halfTotal = (totalQubits / 2L);
#line 207 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            foreach (var i in new Range(0L, (halfTotal - 1L)))
            {
#line 208 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
                MicrosoftQuantumPrimitiveSWAP.Apply((register[i], register[((totalQubits - i) - 1L)]));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<QArray<Qubit>, QVoid> AdjointBody => Body;
        public override Func<(QArray<Qubit>,QArray<Qubit>), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,register) = __in;
            var totalQubits = register.Count;
            var halfTotal = (totalQubits / 2L);
            foreach (var i in new Range(0L, (halfTotal - 1L)))
            {
                MicrosoftQuantumPrimitiveSWAP.Controlled.Apply((controlQubits, (register[i], register[((totalQubits - i) - 1L)])));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,QArray<Qubit>), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,register) = __in;
            var totalQubits = register.Count;
            var halfTotal = (totalQubits / 2L);
            foreach (var i in new Range(0L, (halfTotal - 1L)))
            {
                MicrosoftQuantumPrimitiveSWAP.Controlled.Apply((controlQubits, (register[i], register[((totalQubits - i) - 1L)])));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveSWAP = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.SWAP));
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> register)
        {
            return __m__.Run<SwapReverseRegister, QArray<Qubit>, QVoid>(register);
        }
    }

    public class ApplyPhaseLEOperationOnLE : Operation<(ICallable,LittleEndian), QVoid>, ICallable
    {
        public ApplyPhaseLEOperationOnLE(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(ICallable,LittleEndian)>, IApplyData
        {
            public In((ICallable,LittleEndian) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "ApplyPhaseLEOperationOnLE";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ApplyPhaseLEOperationOnLE";
        protected IUnitary<LittleEndian> QFTLE
        {
            get;
            set;
        }

        public override Func<(ICallable,LittleEndian), QVoid> Body => (__in) =>
        {
            var (op,target) = __in;
#line 238 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            QFTLE.Apply(target);
#line 239 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            var phaseLE = new PhaseLittleEndian(target);
#line 240 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            op.Apply(phaseLE);
#line 241 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            QFTLE.Adjoint.Apply(target);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.QFTLE = this.Factory.Get<IUnitary<LittleEndian>>(typeof(Microsoft.Quantum.Canon.QFTLE));
        }

        public override IApplyData __dataIn((ICallable,LittleEndian) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, ICallable op, LittleEndian target)
        {
            return __m__.Run<ApplyPhaseLEOperationOnLE, (ICallable,LittleEndian), QVoid>((op, target));
        }
    }

    public class ApplyPhaseLEOperationOnLEA : Adjointable<(IAdjointable,LittleEndian)>, ICallable
    {
        public ApplyPhaseLEOperationOnLEA(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IAdjointable,LittleEndian)>, IApplyData
        {
            public In((IAdjointable,LittleEndian) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "ApplyPhaseLEOperationOnLEA";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ApplyPhaseLEOperationOnLEA";
        protected IUnitary<LittleEndian> QFTLE
        {
            get;
            set;
        }

        public override Func<(IAdjointable,LittleEndian), QVoid> Body => (__in) =>
        {
            var (op,target) = __in;
#line 249 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            QFTLE.Apply(target);
#line 250 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            var phaseLE = new PhaseLittleEndian(target);
#line 251 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            op.Apply(phaseLE);
#line 252 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            QFTLE.Adjoint.Apply(target);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IAdjointable,LittleEndian), QVoid> AdjointBody => (__in) =>
        {
            var (op,target) = __in;
#line 250 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            var phaseLE = new PhaseLittleEndian(target);
            QFTLE.Adjoint.Adjoint.Apply(target);
            op.Adjoint.Apply(phaseLE);
            QFTLE.Adjoint.Apply(target);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.QFTLE = this.Factory.Get<IUnitary<LittleEndian>>(typeof(Microsoft.Quantum.Canon.QFTLE));
        }

        public override IApplyData __dataIn((IAdjointable,LittleEndian) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IAdjointable op, LittleEndian target)
        {
            return __m__.Run<ApplyPhaseLEOperationOnLEA, (IAdjointable,LittleEndian), QVoid>((op, target));
        }
    }

    public class ApplyPhaseLEOperationOnLEC : Controllable<(IControllable,LittleEndian)>, ICallable
    {
        public ApplyPhaseLEOperationOnLEC(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IControllable,LittleEndian)>, IApplyData
        {
            public In((IControllable,LittleEndian) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "ApplyPhaseLEOperationOnLEC";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ApplyPhaseLEOperationOnLEC";
        protected IUnitary<LittleEndian> QFTLE
        {
            get;
            set;
        }

        public override Func<(IControllable,LittleEndian), QVoid> Body => (__in) =>
        {
            var (op,target) = __in;
#line 261 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            QFTLE.Apply(target);
#line 262 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            var phaseLE = new PhaseLittleEndian(target);
#line 263 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            op.Apply(phaseLE);
#line 264 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            QFTLE.Adjoint.Apply(target);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(IControllable,LittleEndian)), QVoid> ControlledBody => (__in) =>
        {
            var (controls,(op,target)) = __in;
#line 267 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            QFTLE.Apply(target);
#line 268 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            var phaseLE = new PhaseLittleEndian(target);
#line 269 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            op.Controlled.Apply((controls, phaseLE));
#line 270 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            QFTLE.Adjoint.Apply(target);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.QFTLE = this.Factory.Get<IUnitary<LittleEndian>>(typeof(Microsoft.Quantum.Canon.QFTLE));
        }

        public override IApplyData __dataIn((IControllable,LittleEndian) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IControllable op, LittleEndian target)
        {
            return __m__.Run<ApplyPhaseLEOperationOnLEC, (IControllable,LittleEndian), QVoid>((op, target));
        }
    }

    public class ApplyPhaseLEOperationOnLECA : Unitary<(IUnitary,LittleEndian)>, ICallable
    {
        public ApplyPhaseLEOperationOnLECA(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IUnitary,LittleEndian)>, IApplyData
        {
            public In((IUnitary,LittleEndian) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "ApplyPhaseLEOperationOnLECA";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ApplyPhaseLEOperationOnLECA";
        protected IUnitary<LittleEndian> QFTLE
        {
            get;
            set;
        }

        public override Func<(IUnitary,LittleEndian), QVoid> Body => (__in) =>
        {
            var (op,target) = __in;
#line 278 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            QFTLE.Apply(target);
#line 279 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            var phaseLE = new PhaseLittleEndian(target);
#line 280 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            op.Apply(phaseLE);
#line 281 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            QFTLE.Adjoint.Apply(target);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IUnitary,LittleEndian), QVoid> AdjointBody => (__in) =>
        {
            var (op,target) = __in;
#line 279 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            var phaseLE = new PhaseLittleEndian(target);
            QFTLE.Adjoint.Adjoint.Apply(target);
            op.Adjoint.Apply(phaseLE);
            QFTLE.Adjoint.Apply(target);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(IUnitary,LittleEndian)), QVoid> ControlledBody => (__in) =>
        {
            var (controls,(op,target)) = __in;
#line 285 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            QFTLE.Apply(target);
#line 286 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            var phaseLE = new PhaseLittleEndian(target);
#line 287 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            op.Controlled.Apply((controls, phaseLE));
#line 288 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            QFTLE.Adjoint.Apply(target);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(IUnitary,LittleEndian)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controls,(op,target)) = __in;
#line 286 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            var phaseLE = new PhaseLittleEndian(target);
            QFTLE.Adjoint.Adjoint.Apply(target);
            op.Controlled.Adjoint.Apply((controls, phaseLE));
            QFTLE.Adjoint.Apply(target);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.QFTLE = this.Factory.Get<IUnitary<LittleEndian>>(typeof(Microsoft.Quantum.Canon.QFTLE));
        }

        public override IApplyData __dataIn((IUnitary,LittleEndian) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IUnitary op, LittleEndian target)
        {
            return __m__.Run<ApplyPhaseLEOperationOnLECA, (IUnitary,LittleEndian), QVoid>((op, target));
        }
    }

    public class ApplyLEOperationOnPhaseLE : Operation<(ICallable,PhaseLittleEndian), QVoid>, ICallable
    {
        public ApplyLEOperationOnPhaseLE(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(ICallable,PhaseLittleEndian)>, IApplyData
        {
            public In((ICallable,PhaseLittleEndian) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "ApplyLEOperationOnPhaseLE";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ApplyLEOperationOnPhaseLE";
        protected IUnitary<LittleEndian> QFTLE
        {
            get;
            set;
        }

        protected ICallable With
        {
            get;
            set;
        }

        public override Func<(ICallable,PhaseLittleEndian), QVoid> Body => (__in) =>
        {
            var (op,target) = __in;
#line 315 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            var targetLE = new LittleEndian(target);
#line 316 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            With.Apply((((IAdjointable)QFTLE.Adjoint), ((ICallable)op), targetLE));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.QFTLE = this.Factory.Get<IUnitary<LittleEndian>>(typeof(Microsoft.Quantum.Canon.QFTLE));
            this.With = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.With<>));
        }

        public override IApplyData __dataIn((ICallable,PhaseLittleEndian) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, ICallable op, PhaseLittleEndian target)
        {
            return __m__.Run<ApplyLEOperationOnPhaseLE, (ICallable,PhaseLittleEndian), QVoid>((op, target));
        }
    }

    public class ApplyLEOperationOnPhaseLEA : Adjointable<(IAdjointable,PhaseLittleEndian)>, ICallable
    {
        public ApplyLEOperationOnPhaseLEA(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IAdjointable,PhaseLittleEndian)>, IApplyData
        {
            public In((IAdjointable,PhaseLittleEndian) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "ApplyLEOperationOnPhaseLEA";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ApplyLEOperationOnPhaseLEA";
        protected IUnitary<LittleEndian> QFTLE
        {
            get;
            set;
        }

        protected IAdjointable WithA
        {
            get;
            set;
        }

        public override Func<(IAdjointable,PhaseLittleEndian), QVoid> Body => (__in) =>
        {
            var (op,target) = __in;
#line 324 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            var targetLE = new LittleEndian(target);
#line 325 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            WithA.Apply((((IAdjointable)QFTLE.Adjoint), ((IAdjointable)op), targetLE));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IAdjointable,PhaseLittleEndian), QVoid> AdjointBody => (__in) =>
        {
            var (op,target) = __in;
#line 324 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            var targetLE = new LittleEndian(target);
            WithA.Adjoint.Apply((((IAdjointable)QFTLE.Adjoint), ((IAdjointable)op), targetLE));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.QFTLE = this.Factory.Get<IUnitary<LittleEndian>>(typeof(Microsoft.Quantum.Canon.QFTLE));
            this.WithA = this.Factory.Get<IAdjointable>(typeof(Microsoft.Quantum.Canon.WithA<>));
        }

        public override IApplyData __dataIn((IAdjointable,PhaseLittleEndian) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IAdjointable op, PhaseLittleEndian target)
        {
            return __m__.Run<ApplyLEOperationOnPhaseLEA, (IAdjointable,PhaseLittleEndian), QVoid>((op, target));
        }
    }

    public class ApplyLEOperationOnPhaseLEC : Controllable<(IControllable,PhaseLittleEndian)>, ICallable
    {
        public ApplyLEOperationOnPhaseLEC(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IControllable,PhaseLittleEndian)>, IApplyData
        {
            public In((IControllable,PhaseLittleEndian) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "ApplyLEOperationOnPhaseLEC";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ApplyLEOperationOnPhaseLEC";
        protected IUnitary<LittleEndian> QFTLE
        {
            get;
            set;
        }

        protected IControllable WithC
        {
            get;
            set;
        }

        public override Func<(IControllable,PhaseLittleEndian), QVoid> Body => (__in) =>
        {
            var (op,target) = __in;
#line 334 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            var targetLE = new LittleEndian(target);
#line 335 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            WithC.Apply((((IAdjointable)QFTLE.Adjoint), ((IControllable)op), targetLE));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(IControllable,PhaseLittleEndian)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(op,target)) = __in;
            var targetLE = new LittleEndian(target);
            WithC.Controlled.Apply((controlQubits, (((IAdjointable)QFTLE.Adjoint), ((IControllable)op), targetLE)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.QFTLE = this.Factory.Get<IUnitary<LittleEndian>>(typeof(Microsoft.Quantum.Canon.QFTLE));
            this.WithC = this.Factory.Get<IControllable>(typeof(Microsoft.Quantum.Canon.WithC<>));
        }

        public override IApplyData __dataIn((IControllable,PhaseLittleEndian) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IControllable op, PhaseLittleEndian target)
        {
            return __m__.Run<ApplyLEOperationOnPhaseLEC, (IControllable,PhaseLittleEndian), QVoid>((op, target));
        }
    }

    public class ApplyLEOperationOnPhaseLECA : Unitary<(IUnitary,PhaseLittleEndian)>, ICallable
    {
        public ApplyLEOperationOnPhaseLECA(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IUnitary,PhaseLittleEndian)>, IApplyData
        {
            public In((IUnitary,PhaseLittleEndian) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "ApplyLEOperationOnPhaseLECA";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ApplyLEOperationOnPhaseLECA";
        protected IUnitary<LittleEndian> QFTLE
        {
            get;
            set;
        }

        protected IUnitary WithCA
        {
            get;
            set;
        }

        public override Func<(IUnitary,PhaseLittleEndian), QVoid> Body => (__in) =>
        {
            var (op,target) = __in;
#line 344 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            var targetLE = new LittleEndian(target);
#line 345 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            WithCA.Apply((((IAdjointable)QFTLE.Adjoint), ((IUnitary)op), targetLE));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IUnitary,PhaseLittleEndian), QVoid> AdjointBody => (__in) =>
        {
            var (op,target) = __in;
#line 344 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\UnsignedIntegers.qs"
            var targetLE = new LittleEndian(target);
            WithCA.Adjoint.Apply((((IAdjointable)QFTLE.Adjoint), ((IUnitary)op), targetLE));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(IUnitary,PhaseLittleEndian)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(op,target)) = __in;
            var targetLE = new LittleEndian(target);
            WithCA.Controlled.Apply((controlQubits, (((IAdjointable)QFTLE.Adjoint), ((IUnitary)op), targetLE)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(IUnitary,PhaseLittleEndian)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,(op,target)) = __in;
            var targetLE = new LittleEndian(target);
            WithCA.Adjoint.Controlled.Apply((controlQubits, (((IAdjointable)QFTLE.Adjoint), ((IUnitary)op), targetLE)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.QFTLE = this.Factory.Get<IUnitary<LittleEndian>>(typeof(Microsoft.Quantum.Canon.QFTLE));
            this.WithCA = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.WithCA<>));
        }

        public override IApplyData __dataIn((IUnitary,PhaseLittleEndian) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IUnitary op, PhaseLittleEndian target)
        {
            return __m__.Run<ApplyLEOperationOnPhaseLECA, (IUnitary,PhaseLittleEndian), QVoid>((op, target));
        }
    }
}