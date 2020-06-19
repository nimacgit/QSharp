#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "ControlledOnBitStringImpl<'T> (bits : Bool[], oracle : ('T => () : Adjoint, Controlled), controlRegister : Qubit[], targetRegister : 'T) : ()", new string[] { "Controlled", "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\ControlledOnBitString.qs", 1023L, 25L, 5L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "ControlledOnIntImpl<'T> (numberState : Int, oracle : ('T => () : Adjoint, Controlled), controlRegister : Qubit[], targetRegister : 'T) : ()", new string[] { "Controlled", "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\ControlledOnBitString.qs", 2758L, 68L, 5L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "ControlledOnBitString<'T> (bits : Bool[], oracle : ('T => () : Adjoint, Controlled)) : ((Qubit[], 'T) => () : Adjoint, Controlled)", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\ControlledOnBitString.qs", 1709L, 46L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "ControlledOnInt<'T> (numberState : Int, oracle : ('T => () : Adjoint, Controlled)) : ((Qubit[], 'T) => () : Adjoint, Controlled)", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\ControlledOnBitString.qs", 3518L, 93L, 14L)]
#line hidden
namespace Microsoft.Quantum.Canon
{
    public class ControlledOnBitStringImpl<__T> : Unitary<(QArray<Boolean>,IUnitary,QArray<Qubit>,__T)>, ICallable
    {
        public ControlledOnBitStringImpl(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Boolean>,IUnitary,QArray<Qubit>,__T)>, IApplyData
        {
            public In((QArray<Boolean>,IUnitary,QArray<Qubit>,__T) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits, Data.Item4?.GetQubits());
        }

        String ICallable.Name => "ControlledOnBitStringImpl";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ControlledOnBitStringImpl";
        protected IUnitary<(Pauli,Boolean,QArray<Boolean>,QArray<Qubit>)> ApplyPauliFromBitString
        {
            get;
            set;
        }

        protected IUnitary WithCA
        {
            get;
            set;
        }

        public override Func<(QArray<Boolean>,IUnitary,QArray<Qubit>,__T), QVoid> Body => (__in) =>
        {
            var (bits,oracle,controlRegister,targetRegister) = __in;
#line 27 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\ControlledOnBitString.qs"
            WithCA.Apply((((IAdjointable)ApplyPauliFromBitString.Partial(new Func<QArray<Qubit>, (Pauli,Boolean,QArray<Boolean>,QArray<Qubit>)>((_arg1) => (Pauli.PauliX, false, bits, _arg1)))), ((IUnitary)oracle.Controlled.Partial((_, targetRegister))), controlRegister));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Boolean>,IUnitary,QArray<Qubit>,__T), QVoid> AdjointBody => (__in) =>
        {
            var (bits,oracle,controlRegister,targetRegister) = __in;
            WithCA.Adjoint.Apply((((IAdjointable)ApplyPauliFromBitString.Partial(new Func<QArray<Qubit>, (Pauli,Boolean,QArray<Boolean>,QArray<Qubit>)>((_arg1) => (Pauli.PauliX, false, bits, _arg1)))), ((IUnitary)oracle.Controlled.Partial((_, targetRegister))), controlRegister));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Boolean>,IUnitary,QArray<Qubit>,__T)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(bits,oracle,controlRegister,targetRegister)) = __in;
            WithCA.Controlled.Apply((controlQubits, (((IAdjointable)ApplyPauliFromBitString.Partial(new Func<QArray<Qubit>, (Pauli,Boolean,QArray<Boolean>,QArray<Qubit>)>((_arg1) => (Pauli.PauliX, false, bits, _arg1)))), ((IUnitary)oracle.Controlled.Partial((_, targetRegister))), controlRegister)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Boolean>,IUnitary,QArray<Qubit>,__T)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,(bits,oracle,controlRegister,targetRegister)) = __in;
            WithCA.Adjoint.Controlled.Apply((controlQubits, (((IAdjointable)ApplyPauliFromBitString.Partial(new Func<QArray<Qubit>, (Pauli,Boolean,QArray<Boolean>,QArray<Qubit>)>((_arg1) => (Pauli.PauliX, false, bits, _arg1)))), ((IUnitary)oracle.Controlled.Partial((_, targetRegister))), controlRegister)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.ApplyPauliFromBitString = this.Factory.Get<IUnitary<(Pauli,Boolean,QArray<Boolean>,QArray<Qubit>)>>(typeof(Microsoft.Quantum.Canon.ApplyPauliFromBitString));
            this.WithCA = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.WithCA<>));
        }

        public override IApplyData __dataIn((QArray<Boolean>,IUnitary,QArray<Qubit>,__T) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Boolean> bits, IUnitary oracle, QArray<Qubit> controlRegister, __T targetRegister)
        {
            return __m__.Run<ControlledOnBitStringImpl<__T>, (QArray<Boolean>,IUnitary,QArray<Qubit>,__T), QVoid>((bits, oracle, controlRegister, targetRegister));
        }
    }

    public class ControlledOnBitString<__T> : Operation<(QArray<Boolean>,IUnitary), IUnitary>, ICallable
    {
        public ControlledOnBitString(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Boolean>,IUnitary)>, IApplyData
        {
            public In((QArray<Boolean>,IUnitary) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "ControlledOnBitString";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ControlledOnBitString";
        protected IUnitary ControlledOnBitStringImpl
        {
            get;
            set;
        }

        public override Func<(QArray<Boolean>,IUnitary), IUnitary> Body => (__in) =>
        {
            var (bits,oracle) = __in;
#line 48 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\ControlledOnBitString.qs"
            return ControlledOnBitStringImpl.Partial((bits, ((IUnitary)oracle), _, _));
        }

        ;
        public override void Init()
        {
            this.ControlledOnBitStringImpl = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.ControlledOnBitStringImpl<>));
        }

        public override IApplyData __dataIn((QArray<Boolean>,IUnitary) data) => new In(data);
        public override IApplyData __dataOut(IUnitary data) => new QTuple<IUnitary>(data);
        public static System.Threading.Tasks.Task<IUnitary> Run(IOperationFactory __m__, QArray<Boolean> bits, IUnitary oracle)
        {
            return __m__.Run<ControlledOnBitString<__T>, (QArray<Boolean>,IUnitary), IUnitary>((bits, oracle));
        }
    }

    public class ControlledOnIntImpl<__T> : Unitary<(Int64,IUnitary,QArray<Qubit>,__T)>, ICallable
    {
        public ControlledOnIntImpl(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,IUnitary,QArray<Qubit>,__T)>, IApplyData
        {
            public In((Int64,IUnitary,QArray<Qubit>,__T) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits, Data.Item4?.GetQubits());
        }

        String ICallable.Name => "ControlledOnIntImpl";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ControlledOnIntImpl";
        protected ICallable<(Int64,Int64), QArray<Boolean>> BoolArrFromPositiveInt
        {
            get;
            set;
        }

        protected ICallable ControlledOnBitString
        {
            get;
            set;
        }

        public override Func<(Int64,IUnitary,QArray<Qubit>,__T), QVoid> Body => (__in) =>
        {
            var (numberState,oracle,controlRegister,targetRegister) = __in;
#line 71 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\ControlledOnBitString.qs"
            var bits = BoolArrFromPositiveInt.Apply((numberState, controlRegister.Count));
#line 73 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\ControlledOnBitString.qs"
            ControlledOnBitString.Apply<IUnitary>((bits, ((IUnitary)oracle))).Apply((controlRegister, targetRegister));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Int64,IUnitary,QArray<Qubit>,__T), QVoid> AdjointBody => (__in) =>
        {
            var (numberState,oracle,controlRegister,targetRegister) = __in;
#line 71 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\ControlledOnBitString.qs"
            var bits = BoolArrFromPositiveInt.Apply((numberState, controlRegister.Count));
            ControlledOnBitString.Apply<IUnitary>((bits, ((IUnitary)oracle))).Adjoint.Apply((controlRegister, targetRegister));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Int64,IUnitary,QArray<Qubit>,__T)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(numberState,oracle,controlRegister,targetRegister)) = __in;
            var bits = BoolArrFromPositiveInt.Apply((numberState, controlRegister.Count));
            ControlledOnBitString.Apply<IUnitary>((bits, ((IUnitary)oracle))).Controlled.Apply((controlQubits, (controlRegister, targetRegister)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Int64,IUnitary,QArray<Qubit>,__T)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,(numberState,oracle,controlRegister,targetRegister)) = __in;
            var bits = BoolArrFromPositiveInt.Apply((numberState, controlRegister.Count));
            ControlledOnBitString.Apply<IUnitary>((bits, ((IUnitary)oracle))).Adjoint.Controlled.Apply((controlQubits, (controlRegister, targetRegister)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.BoolArrFromPositiveInt = this.Factory.Get<ICallable<(Int64,Int64), QArray<Boolean>>>(typeof(Microsoft.Quantum.Canon.BoolArrFromPositiveInt));
            this.ControlledOnBitString = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ControlledOnBitString<>));
        }

        public override IApplyData __dataIn((Int64,IUnitary,QArray<Qubit>,__T) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 numberState, IUnitary oracle, QArray<Qubit> controlRegister, __T targetRegister)
        {
            return __m__.Run<ControlledOnIntImpl<__T>, (Int64,IUnitary,QArray<Qubit>,__T), QVoid>((numberState, oracle, controlRegister, targetRegister));
        }
    }

    public class ControlledOnInt<__T> : Operation<(Int64,IUnitary), IUnitary>, ICallable
    {
        public ControlledOnInt(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,IUnitary)>, IApplyData
        {
            public In((Int64,IUnitary) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "ControlledOnInt";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ControlledOnInt";
        protected IUnitary ControlledOnIntImpl
        {
            get;
            set;
        }

        public override Func<(Int64,IUnitary), IUnitary> Body => (__in) =>
        {
            var (numberState,oracle) = __in;
#line 95 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\ControlledOnBitString.qs"
            return ControlledOnIntImpl.Partial((numberState, ((IUnitary)oracle), _, _));
        }

        ;
        public override void Init()
        {
            this.ControlledOnIntImpl = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.ControlledOnIntImpl<>));
        }

        public override IApplyData __dataIn((Int64,IUnitary) data) => new In(data);
        public override IApplyData __dataOut(IUnitary data) => new QTuple<IUnitary>(data);
        public static System.Threading.Tasks.Task<IUnitary> Run(IOperationFactory __m__, Int64 numberState, IUnitary oracle)
        {
            return __m__.Run<ControlledOnInt<__T>, (Int64,IUnitary), IUnitary>((numberState, oracle));
        }
    }
}