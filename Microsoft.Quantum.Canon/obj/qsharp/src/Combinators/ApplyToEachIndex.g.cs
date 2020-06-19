#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "ApplyToEachIndex<'T> (singleElementOperation : ((Int, 'T) => ()), register : 'T[]) : ()", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToEachIndex.qs", 883L, 26L, 5L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "ApplyToEachIndexC<'T> (singleElementOperation : ((Int, 'T) => () : Controlled), register : 'T[]) : ()", new string[] { "Controlled" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToEachIndex.qs", 1751L, 51L, 5L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "ApplyToEachIndexA<'T> (singleElementOperation : ((Int, 'T) => () : Adjoint), register : 'T[]) : ()", new string[] { "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToEachIndex.qs", 2642L, 78L, 5L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "ApplyToEachIndexCA<'T> (singleElementOperation : ((Int, 'T) => () : Adjoint, Controlled), register : 'T[]) : ()", new string[] { "Controlled", "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToEachIndex.qs", 3569L, 106L, 5L)]
#line hidden
namespace Microsoft.Quantum.Canon
{
    public class ApplyToEachIndex<__T> : Operation<(ICallable,QArray<__T>), QVoid>, ICallable
    {
        public ApplyToEachIndex(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(ICallable,QArray<__T>)>, IApplyData
        {
            public In((ICallable,QArray<__T>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "ApplyToEachIndex";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ApplyToEachIndex";
        public override Func<(ICallable,QArray<__T>), QVoid> Body => (__in) =>
        {
            var (singleElementOperation,register) = __in;
#line 28 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToEachIndex.qs"
            foreach (var idxQubit in new Range(0L, (register.Count - 1L)))
            {
#line 29 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToEachIndex.qs"
                singleElementOperation.Apply((idxQubit, register[idxQubit]));
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
            return __m__.Run<ApplyToEachIndex<__T>, (ICallable,QArray<__T>), QVoid>((singleElementOperation, register));
        }
    }

    public class ApplyToEachIndexC<__T> : Controllable<(IControllable,QArray<__T>)>, ICallable
    {
        public ApplyToEachIndexC(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IControllable,QArray<__T>)>, IApplyData
        {
            public In((IControllable,QArray<__T>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "ApplyToEachIndexC";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ApplyToEachIndexC";
        public override Func<(IControllable,QArray<__T>), QVoid> Body => (__in) =>
        {
            var (singleElementOperation,register) = __in;
#line 53 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToEachIndex.qs"
            foreach (var idxQubit in new Range(0L, (register.Count - 1L)))
            {
#line 54 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToEachIndex.qs"
                singleElementOperation.Apply((idxQubit, register[idxQubit]));
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
                singleElementOperation.Controlled.Apply((controlQubits, (idxQubit, register[idxQubit])));
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
            return __m__.Run<ApplyToEachIndexC<__T>, (IControllable,QArray<__T>), QVoid>((singleElementOperation, register));
        }
    }

    public class ApplyToEachIndexA<__T> : Adjointable<(IAdjointable,QArray<__T>)>, ICallable
    {
        public ApplyToEachIndexA(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IAdjointable,QArray<__T>)>, IApplyData
        {
            public In((IAdjointable,QArray<__T>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "ApplyToEachIndexA";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ApplyToEachIndexA";
        public override Func<(IAdjointable,QArray<__T>), QVoid> Body => (__in) =>
        {
            var (singleElementOperation,register) = __in;
#line 80 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToEachIndex.qs"
            foreach (var idxQubit in new Range(0L, (register.Count - 1L)))
            {
#line 81 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToEachIndex.qs"
                singleElementOperation.Apply((idxQubit, register[idxQubit]));
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
                singleElementOperation.Adjoint.Apply((idxQubit, register[idxQubit]));
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
            return __m__.Run<ApplyToEachIndexA<__T>, (IAdjointable,QArray<__T>), QVoid>((singleElementOperation, register));
        }
    }

    public class ApplyToEachIndexCA<__T> : Unitary<(IUnitary,QArray<__T>)>, ICallable
    {
        public ApplyToEachIndexCA(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IUnitary,QArray<__T>)>, IApplyData
        {
            public In((IUnitary,QArray<__T>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "ApplyToEachIndexCA";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ApplyToEachIndexCA";
        public override Func<(IUnitary,QArray<__T>), QVoid> Body => (__in) =>
        {
            var (singleElementOperation,register) = __in;
#line 108 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToEachIndex.qs"
            foreach (var idxQubit in new Range(0L, (register.Count - 1L)))
            {
#line 109 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyToEachIndex.qs"
                singleElementOperation.Apply((idxQubit, register[idxQubit]));
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
                singleElementOperation.Adjoint.Apply((idxQubit, register[idxQubit]));
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
                singleElementOperation.Controlled.Apply((controlQubits, (idxQubit, register[idxQubit])));
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
                singleElementOperation.Adjoint.Controlled.Apply((controlQubits, (idxQubit, register[idxQubit])));
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
            return __m__.Run<ApplyToEachIndexCA<__T>, (IUnitary,QArray<__T>), QVoid>((singleElementOperation, register));
        }
    }
}