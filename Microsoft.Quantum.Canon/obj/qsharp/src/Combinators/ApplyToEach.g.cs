#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "ApplyToEachCA<'T> (singleElementOperation : ('T => () : Adjoint, Controlled), register : 'T[]) : ()", new string[] { "Controlled", "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToEach.qs", 1040L, 34L, 5L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "ApplyToEachA<'T> (singleElementOperation : ('T => () : Adjoint), register : 'T[]) : ()", new string[] { "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToEach.qs", 2154L, 72L, 5L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "ApplyToEachC<'T> (singleElementOperation : ('T => () : Controlled), register : 'T[]) : ()", new string[] { "Controlled" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToEach.qs", 3214L, 108L, 5L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "ApplyToEach<'T> (singleElementOperation : ('T => ()), register : 'T[]) : ()", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToEach.qs", 4278L, 145L, 5L)]
#line hidden
namespace Microsoft.Quantum.Canon
{
    public class ApplyToEachCA<__T> : Unitary<(IUnitary,QArray<__T>)>, ICallable
    {
        public ApplyToEachCA(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IUnitary,QArray<__T>)>, IApplyData
        {
            public In((IUnitary,QArray<__T>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "ApplyToEachCA";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ApplyToEachCA";
        public override Func<(IUnitary,QArray<__T>), QVoid> Body => (__in) =>
        {
            var (singleElementOperation,register) = __in;
#line 36 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToEach.qs"
            foreach (var idxQubit in new Range(0L, (register.Count - 1L)))
            {
#line 37 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToEach.qs"
                singleElementOperation.Apply(register[idxQubit]);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IUnitary,QArray<__T>), QVoid> AdjointBody => (__in) =>
        {
            var (singleElementOperation,register) = __in;
            foreach (var idxQubit in new Range((0L - ((((register.Count - 1L) - 0L) / 1L) * -(1L))), -(1L), 0L))
            {
                singleElementOperation.Adjoint.Apply(register[idxQubit]);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(IUnitary,QArray<__T>)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(singleElementOperation,register)) = __in;
            foreach (var idxQubit in new Range(0L, (register.Count - 1L)))
            {
                singleElementOperation.Controlled.Apply((controlQubits, register[idxQubit]));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(IUnitary,QArray<__T>)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,(singleElementOperation,register)) = __in;
            foreach (var idxQubit in new Range((0L - ((((register.Count - 1L) - 0L) / 1L) * -(1L))), -(1L), 0L))
            {
                singleElementOperation.Adjoint.Controlled.Apply((controlQubits, register[idxQubit]));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((IUnitary,QArray<__T>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IUnitary singleElementOperation, QArray<__T> register)
        {
            return __m__.Run<ApplyToEachCA<__T>, (IUnitary,QArray<__T>), QVoid>((singleElementOperation, register));
        }
    }

    public class ApplyToEachA<__T> : Adjointable<(IAdjointable,QArray<__T>)>, ICallable
    {
        public ApplyToEachA(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IAdjointable,QArray<__T>)>, IApplyData
        {
            public In((IAdjointable,QArray<__T>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "ApplyToEachA";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ApplyToEachA";
        public override Func<(IAdjointable,QArray<__T>), QVoid> Body => (__in) =>
        {
            var (singleElementOperation,register) = __in;
#line 74 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToEach.qs"
            foreach (var idxQubit in new Range(0L, (register.Count - 1L)))
            {
#line 75 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToEach.qs"
                singleElementOperation.Apply(register[idxQubit]);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IAdjointable,QArray<__T>), QVoid> AdjointBody => (__in) =>
        {
            var (singleElementOperation,register) = __in;
            foreach (var idxQubit in new Range((0L - ((((register.Count - 1L) - 0L) / 1L) * -(1L))), -(1L), 0L))
            {
                singleElementOperation.Adjoint.Apply(register[idxQubit]);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((IAdjointable,QArray<__T>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IAdjointable singleElementOperation, QArray<__T> register)
        {
            return __m__.Run<ApplyToEachA<__T>, (IAdjointable,QArray<__T>), QVoid>((singleElementOperation, register));
        }
    }

    public class ApplyToEachC<__T> : Controllable<(IControllable,QArray<__T>)>, ICallable
    {
        public ApplyToEachC(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IControllable,QArray<__T>)>, IApplyData
        {
            public In((IControllable,QArray<__T>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "ApplyToEachC";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ApplyToEachC";
        public override Func<(IControllable,QArray<__T>), QVoid> Body => (__in) =>
        {
            var (singleElementOperation,register) = __in;
#line 110 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToEach.qs"
            foreach (var idxQubit in new Range(0L, (register.Count - 1L)))
            {
#line 111 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToEach.qs"
                singleElementOperation.Apply(register[idxQubit]);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(IControllable,QArray<__T>)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(singleElementOperation,register)) = __in;
            foreach (var idxQubit in new Range(0L, (register.Count - 1L)))
            {
                singleElementOperation.Controlled.Apply((controlQubits, register[idxQubit]));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((IControllable,QArray<__T>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IControllable singleElementOperation, QArray<__T> register)
        {
            return __m__.Run<ApplyToEachC<__T>, (IControllable,QArray<__T>), QVoid>((singleElementOperation, register));
        }
    }

    public class ApplyToEach<__T> : Operation<(ICallable,QArray<__T>), QVoid>, ICallable
    {
        public ApplyToEach(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(ICallable,QArray<__T>)>, IApplyData
        {
            public In((ICallable,QArray<__T>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "ApplyToEach";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ApplyToEach";
        public override Func<(ICallable,QArray<__T>), QVoid> Body => (__in) =>
        {
            var (singleElementOperation,register) = __in;
#line 147 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToEach.qs"
            foreach (var idxQubit in new Range(0L, (register.Count - 1L)))
            {
#line 148 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToEach.qs"
                singleElementOperation.Apply(register[idxQubit]);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((ICallable,QArray<__T>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, ICallable singleElementOperation, QArray<__T> register)
        {
            return __m__.Run<ApplyToEach<__T>, (ICallable,QArray<__T>), QVoid>((singleElementOperation, register));
        }
    }
}