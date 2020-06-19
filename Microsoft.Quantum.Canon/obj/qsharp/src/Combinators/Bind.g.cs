#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "BindImpl<'T> (operations : ('T => ())[], target : 'T) : ()", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\Bind.qs", 273L, 9L, 73L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "BindAImpl<'T> (operations : ('T => () : Adjoint)[], target : 'T) : ()", new string[] { "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\Bind.qs", 1597L, 54L, 84L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "BindCImpl<'T> (operations : ('T => () : Controlled)[], target : 'T) : ()", new string[] { "Controlled" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\Bind.qs", 3331L, 106L, 87L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "BindCAImpl<'T> (operations : ('T => () : Adjoint, Controlled)[], target : 'T) : ()", new string[] { "Controlled", "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\Bind.qs", 4927L, 157L, 97L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "Bind<'T> (operations : ('T => ())[]) : ('T => ())", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\Bind.qs", 1351L, 48L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "BindA<'T> (operations : ('T => () : Adjoint)[]) : ('T => () : Adjoint)", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\Bind.qs", 3060L, 100L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "BindC<'T> (operations : ('T => () : Controlled)[]) : ('T => () : Controlled)", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\Bind.qs", 4639L, 151L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "BindCA<'T> (operations : ('T => () : Adjoint, Controlled)[]) : ('T => () : Adjoint, Controlled)", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\Bind.qs", 6712L, 216L, 14L)]
#line hidden
namespace Microsoft.Quantum.Canon
{
    public class BindImpl<__T> : Operation<(QArray<ICallable>,__T), QVoid>, ICallable
    {
        public BindImpl(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<ICallable>,__T)>, IApplyData
        {
            public In((QArray<ICallable>,__T) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, Data.Item2?.GetQubits());
        }

        String ICallable.Name => "BindImpl";
        String ICallable.FullName => "Microsoft.Quantum.Canon.BindImpl";
        public override Func<(QArray<ICallable>,__T), QVoid> Body => (__in) =>
        {
            var (operations,target) = __in;
#line 11 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\Bind.qs"
            foreach (var idxOperation in new Range(0L, (operations.Count - 1L)))
            {
#line 12 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\Bind.qs"
                var op = operations[idxOperation];
#line 13 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\Bind.qs"
                op.Apply(target);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((QArray<ICallable>,__T) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<ICallable> operations, __T target)
        {
            return __m__.Run<BindImpl<__T>, (QArray<ICallable>,__T), QVoid>((operations, target));
        }
    }

    public class Bind<__T> : Operation<QArray<ICallable>, ICallable>, ICallable
    {
        public Bind(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "Bind";
        String ICallable.FullName => "Microsoft.Quantum.Canon.Bind";
        protected ICallable BindImpl
        {
            get;
            set;
        }

        public override Func<QArray<ICallable>, ICallable> Body => (__in) =>
        {
            var operations = __in;
#line 49 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\Bind.qs"
            return BindImpl.Partial((operations, _));
        }

        ;
        public override void Init()
        {
            this.BindImpl = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.BindImpl<>));
        }

        public override IApplyData __dataIn(QArray<ICallable> data) => data;
        public override IApplyData __dataOut(ICallable data) => new QTuple<ICallable>(data);
        public static System.Threading.Tasks.Task<ICallable> Run(IOperationFactory __m__, QArray<ICallable> operations)
        {
            return __m__.Run<Bind<__T>, QArray<ICallable>, ICallable>(operations);
        }
    }

    public class BindAImpl<__T> : Adjointable<(QArray<IAdjointable>,__T)>, ICallable
    {
        public BindAImpl(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<IAdjointable>,__T)>, IApplyData
        {
            public In((QArray<IAdjointable>,__T) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, Data.Item2?.GetQubits());
        }

        String ICallable.Name => "BindAImpl";
        String ICallable.FullName => "Microsoft.Quantum.Canon.BindAImpl";
        public override Func<(QArray<IAdjointable>,__T), QVoid> Body => (__in) =>
        {
            var (operations,target) = __in;
#line 56 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\Bind.qs"
            foreach (var idxOperation in new Range(0L, (operations.Count - 1L)))
            {
#line 57 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\Bind.qs"
                var op = operations[idxOperation];
#line 58 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\Bind.qs"
                op.Apply(target);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<IAdjointable>,__T), QVoid> AdjointBody => (__in) =>
        {
            var (operations,target) = __in;
            // TODO: replace with an implementation based on Reversed : 'T[] -> 'T[]
            //       and AdjointAll : ('T => () : Adjointable)[] -> ('T => () : Adjointable).
#line 64 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\Bind.qs"
            foreach (var idxOperation in new Range((operations.Count - 1L), -(1L), 0L))
            {
#line 65 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\Bind.qs"
                var op = operations[idxOperation].Adjoint;
#line 66 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\Bind.qs"
                op.Apply(target);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((QArray<IAdjointable>,__T) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<IAdjointable> operations, __T target)
        {
            return __m__.Run<BindAImpl<__T>, (QArray<IAdjointable>,__T), QVoid>((operations, target));
        }
    }

    public class BindA<__T> : Operation<QArray<IAdjointable>, IAdjointable>, ICallable
    {
        public BindA(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "BindA";
        String ICallable.FullName => "Microsoft.Quantum.Canon.BindA";
        protected IAdjointable BindAImpl
        {
            get;
            set;
        }

        public override Func<QArray<IAdjointable>, IAdjointable> Body => (__in) =>
        {
            var operations = __in;
#line 101 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\Bind.qs"
            return BindAImpl.Partial((operations, _));
        }

        ;
        public override void Init()
        {
            this.BindAImpl = this.Factory.Get<IAdjointable>(typeof(Microsoft.Quantum.Canon.BindAImpl<>));
        }

        public override IApplyData __dataIn(QArray<IAdjointable> data) => data;
        public override IApplyData __dataOut(IAdjointable data) => new QTuple<IAdjointable>(data);
        public static System.Threading.Tasks.Task<IAdjointable> Run(IOperationFactory __m__, QArray<IAdjointable> operations)
        {
            return __m__.Run<BindA<__T>, QArray<IAdjointable>, IAdjointable>(operations);
        }
    }

    public class BindCImpl<__T> : Controllable<(QArray<IControllable>,__T)>, ICallable
    {
        public BindCImpl(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<IControllable>,__T)>, IApplyData
        {
            public In((QArray<IControllable>,__T) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, Data.Item2?.GetQubits());
        }

        String ICallable.Name => "BindCImpl";
        String ICallable.FullName => "Microsoft.Quantum.Canon.BindCImpl";
        public override Func<(QArray<IControllable>,__T), QVoid> Body => (__in) =>
        {
            var (operations,target) = __in;
#line 108 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\Bind.qs"
            foreach (var idxOperation in new Range(0L, (operations.Count - 1L)))
            {
#line 109 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\Bind.qs"
                var op = operations[idxOperation];
#line 110 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\Bind.qs"
                op.Apply(target);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<IControllable>,__T)), QVoid> ControlledBody => (__in) =>
        {
            var (controls,(operations,target)) = __in;
#line 115 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\Bind.qs"
            foreach (var idxOperation in new Range(0L, (operations.Count - 1L)))
            {
#line 116 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\Bind.qs"
                var op = operations[idxOperation].Controlled;
#line 117 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\Bind.qs"
                op.Apply((controls, target));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((QArray<IControllable>,__T) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<IControllable> operations, __T target)
        {
            return __m__.Run<BindCImpl<__T>, (QArray<IControllable>,__T), QVoid>((operations, target));
        }
    }

    public class BindC<__T> : Operation<QArray<IControllable>, IControllable>, ICallable
    {
        public BindC(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "BindC";
        String ICallable.FullName => "Microsoft.Quantum.Canon.BindC";
        protected IControllable BindCImpl
        {
            get;
            set;
        }

        public override Func<QArray<IControllable>, IControllable> Body => (__in) =>
        {
            var operations = __in;
#line 152 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\Bind.qs"
            return BindCImpl.Partial((operations, _));
        }

        ;
        public override void Init()
        {
            this.BindCImpl = this.Factory.Get<IControllable>(typeof(Microsoft.Quantum.Canon.BindCImpl<>));
        }

        public override IApplyData __dataIn(QArray<IControllable> data) => data;
        public override IApplyData __dataOut(IControllable data) => new QTuple<IControllable>(data);
        public static System.Threading.Tasks.Task<IControllable> Run(IOperationFactory __m__, QArray<IControllable> operations)
        {
            return __m__.Run<BindC<__T>, QArray<IControllable>, IControllable>(operations);
        }
    }

    public class BindCAImpl<__T> : Unitary<(QArray<IUnitary>,__T)>, ICallable
    {
        public BindCAImpl(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<IUnitary>,__T)>, IApplyData
        {
            public In((QArray<IUnitary>,__T) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, Data.Item2?.GetQubits());
        }

        String ICallable.Name => "BindCAImpl";
        String ICallable.FullName => "Microsoft.Quantum.Canon.BindCAImpl";
        public override Func<(QArray<IUnitary>,__T), QVoid> Body => (__in) =>
        {
            var (operations,target) = __in;
#line 159 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\Bind.qs"
            foreach (var idxOperation in new Range(0L, (operations.Count - 1L)))
            {
#line 160 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\Bind.qs"
                var op = operations[idxOperation];
#line 161 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\Bind.qs"
                op.Apply(target);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<IUnitary>,__T), QVoid> AdjointBody => (__in) =>
        {
            var (operations,target) = __in;
#line 166 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\Bind.qs"
            foreach (var idxOperation in new Range((operations.Count - 1L), -(1L), 0L))
            {
#line 167 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\Bind.qs"
                var op = operations[idxOperation].Adjoint;
#line 168 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\Bind.qs"
                op.Apply(target);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<IUnitary>,__T)), QVoid> ControlledBody => (__in) =>
        {
            var (controls,(operations,target)) = __in;
#line 172 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\Bind.qs"
            foreach (var idxOperation in new Range(0L, (operations.Count - 1L)))
            {
#line 173 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\Bind.qs"
                var op = operations[idxOperation].Controlled;
#line 174 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\Bind.qs"
                op.Apply((controls, target));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<IUnitary>,__T)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controls,(operations,target)) = __in;
#line 179 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\Bind.qs"
            foreach (var idxOperation in new Range((operations.Count - 1L), -(1L), 0L))
            {
#line 180 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\Bind.qs"
                var op = operations[idxOperation].Adjoint.Controlled;
#line 181 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\Bind.qs"
                op.Apply((controls, target));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((QArray<IUnitary>,__T) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<IUnitary> operations, __T target)
        {
            return __m__.Run<BindCAImpl<__T>, (QArray<IUnitary>,__T), QVoid>((operations, target));
        }
    }

    public class BindCA<__T> : Operation<QArray<IUnitary>, IUnitary>, ICallable
    {
        public BindCA(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "BindCA";
        String ICallable.FullName => "Microsoft.Quantum.Canon.BindCA";
        protected IUnitary BindCAImpl
        {
            get;
            set;
        }

        public override Func<QArray<IUnitary>, IUnitary> Body => (__in) =>
        {
            var operations = __in;
#line 217 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\Bind.qs"
            return BindCAImpl.Partial((operations, _));
        }

        ;
        public override void Init()
        {
            this.BindCAImpl = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.BindCAImpl<>));
        }

        public override IApplyData __dataIn(QArray<IUnitary> data) => data;
        public override IApplyData __dataOut(IUnitary data) => new QTuple<IUnitary>(data);
        public static System.Threading.Tasks.Task<IUnitary> Run(IOperationFactory __m__, QArray<IUnitary> operations)
        {
            return __m__.Run<BindCA<__T>, QArray<IUnitary>, IUnitary>(operations);
        }
    }
}