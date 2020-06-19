#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "With<'T> (outerOperation : ('T => () : Adjoint), innerOperation : ('T => ()), target : 'T) : ()", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\With.qs", 1368L, 37L, 5L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "WithA<'T> (outerOperation : ('T => () : Adjoint), innerOperation : ('T => () : Adjoint), target : 'T) : ()", new string[] { "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\With.qs", 2719L, 73L, 5L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "WithC<'T> (outerOperation : ('T => () : Adjoint), innerOperation : ('T => () : Controlled), target : 'T) : ()", new string[] { "Controlled" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\With.qs", 4098L, 111L, 5L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "WithCA<'T> (outerOperation : ('T => () : Adjoint), innerOperation : ('T => () : Adjoint, Controlled), target : 'T) : ()", new string[] { "Controlled", "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\With.qs", 5694L, 154L, 5L)]
#line hidden
namespace Microsoft.Quantum.Canon
{
    public class With<__T> : Operation<(IAdjointable,ICallable,__T), QVoid>, ICallable
    {
        public With(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IAdjointable,ICallable,__T)>, IApplyData
        {
            public In((IAdjointable,ICallable,__T) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, Data.Item3?.GetQubits());
        }

        String ICallable.Name => "With";
        String ICallable.FullName => "Microsoft.Quantum.Canon.With";
        public override Func<(IAdjointable,ICallable,__T), QVoid> Body => (__in) =>
        {
            var (outerOperation,innerOperation,target) = __in;
#line 39 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\With.qs"
            outerOperation.Apply(target);
#line 40 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\With.qs"
            innerOperation.Apply(target);
#line 41 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\With.qs"
            outerOperation.Adjoint.Apply(target);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((IAdjointable,ICallable,__T) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IAdjointable outerOperation, ICallable innerOperation, __T target)
        {
            return __m__.Run<With<__T>, (IAdjointable,ICallable,__T), QVoid>((outerOperation, innerOperation, target));
        }
    }

    public class WithA<__T> : Adjointable<(IAdjointable,IAdjointable,__T)>, ICallable
    {
        public WithA(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IAdjointable,IAdjointable,__T)>, IApplyData
        {
            public In((IAdjointable,IAdjointable,__T) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, Data.Item3?.GetQubits());
        }

        String ICallable.Name => "WithA";
        String ICallable.FullName => "Microsoft.Quantum.Canon.WithA";
        public override Func<(IAdjointable,IAdjointable,__T), QVoid> Body => (__in) =>
        {
            var (outerOperation,innerOperation,target) = __in;
#line 75 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\With.qs"
            outerOperation.Apply(target);
#line 76 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\With.qs"
            innerOperation.Apply(target);
#line 77 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\With.qs"
            outerOperation.Adjoint.Apply(target);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IAdjointable,IAdjointable,__T), QVoid> AdjointBody => (__in) =>
        {
            var (outerOperation,innerOperation,target) = __in;
            outerOperation.Adjoint.Adjoint.Apply(target);
            innerOperation.Adjoint.Apply(target);
            outerOperation.Adjoint.Apply(target);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((IAdjointable,IAdjointable,__T) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IAdjointable outerOperation, IAdjointable innerOperation, __T target)
        {
            return __m__.Run<WithA<__T>, (IAdjointable,IAdjointable,__T), QVoid>((outerOperation, innerOperation, target));
        }
    }

    public class WithC<__T> : Controllable<(IAdjointable,IControllable,__T)>, ICallable
    {
        public WithC(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IAdjointable,IControllable,__T)>, IApplyData
        {
            public In((IAdjointable,IControllable,__T) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, Data.Item3?.GetQubits());
        }

        String ICallable.Name => "WithC";
        String ICallable.FullName => "Microsoft.Quantum.Canon.WithC";
        public override Func<(IAdjointable,IControllable,__T), QVoid> Body => (__in) =>
        {
            var (outerOperation,innerOperation,target) = __in;
#line 113 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\With.qs"
            outerOperation.Apply(target);
#line 114 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\With.qs"
            innerOperation.Apply(target);
#line 115 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\With.qs"
            outerOperation.Adjoint.Apply(target);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(IAdjointable,IControllable,__T)), QVoid> ControlledBody => (__in) =>
        {
            var (controlRegister,(outerOperation,innerOperation,target)) = __in;
#line 119 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\With.qs"
            outerOperation.Apply(target);
#line 120 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\With.qs"
            innerOperation.Controlled.Apply((controlRegister, target));
#line 121 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\With.qs"
            outerOperation.Adjoint.Apply(target);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((IAdjointable,IControllable,__T) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IAdjointable outerOperation, IControllable innerOperation, __T target)
        {
            return __m__.Run<WithC<__T>, (IAdjointable,IControllable,__T), QVoid>((outerOperation, innerOperation, target));
        }
    }

    public class WithCA<__T> : Unitary<(IAdjointable,IUnitary,__T)>, ICallable
    {
        public WithCA(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IAdjointable,IUnitary,__T)>, IApplyData
        {
            public In((IAdjointable,IUnitary,__T) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, Data.Item3?.GetQubits());
        }

        String ICallable.Name => "WithCA";
        String ICallable.FullName => "Microsoft.Quantum.Canon.WithCA";
        public override Func<(IAdjointable,IUnitary,__T), QVoid> Body => (__in) =>
        {
            var (outerOperation,innerOperation,target) = __in;
#line 156 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\With.qs"
            outerOperation.Apply(target);
#line 157 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\With.qs"
            innerOperation.Apply(target);
#line 158 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\With.qs"
            outerOperation.Adjoint.Apply(target);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IAdjointable,IUnitary,__T), QVoid> AdjointBody => (__in) =>
        {
            var (outerOperation,innerOperation,target) = __in;
            outerOperation.Adjoint.Adjoint.Apply(target);
            innerOperation.Adjoint.Apply(target);
            outerOperation.Adjoint.Apply(target);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(IAdjointable,IUnitary,__T)), QVoid> ControlledBody => (__in) =>
        {
            var (controlRegister,(outerOperation,innerOperation,target)) = __in;
#line 163 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\With.qs"
            outerOperation.Apply(target);
#line 164 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\With.qs"
            innerOperation.Controlled.Apply((controlRegister, target));
#line 165 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\With.qs"
            outerOperation.Adjoint.Apply(target);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(IAdjointable,IUnitary,__T)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlRegister,(outerOperation,innerOperation,target)) = __in;
            outerOperation.Adjoint.Adjoint.Apply(target);
            innerOperation.Controlled.Adjoint.Apply((controlRegister, target));
            outerOperation.Adjoint.Apply(target);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((IAdjointable,IUnitary,__T) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IAdjointable outerOperation, IUnitary innerOperation, __T target)
        {
            return __m__.Run<WithCA<__T>, (IAdjointable,IUnitary,__T), QVoid>((outerOperation, innerOperation, target));
        }
    }
}