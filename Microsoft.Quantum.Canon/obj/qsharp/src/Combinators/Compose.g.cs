#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "ComposeImpl<'T, 'U, 'V> (outer : ('U -> 'V), inner : ('T -> 'U), target : 'T) : 'V", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\Compose.qs", 152L, 6L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "Compose<'T, 'U, 'V> (outer : ('U -> 'V), inner : ('T -> 'U)) : ('T -> 'V)", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\Compose.qs", 1000L, 31L, 14L)]
#line hidden
namespace Microsoft.Quantum.Canon
{
    public class ComposeImpl<__T, __U, __V> : Operation<(ICallable,ICallable,__T), __V>, ICallable
    {
        public ComposeImpl(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(ICallable,ICallable,__T)>, IApplyData
        {
            public In((ICallable,ICallable,__T) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, Data.Item3?.GetQubits());
        }

        String ICallable.Name => "ComposeImpl";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ComposeImpl";
        public override Func<(ICallable,ICallable,__T), __V> Body => (__in) =>
        {
            var (outer,inner,target) = __in;
#line 7 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\Compose.qs"
            return outer.Apply<__V>(inner.Apply<__U>(target));
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((ICallable,ICallable,__T) data) => new In(data);
        public override IApplyData __dataOut(__V data) => new QTuple<__V>(data);
        public static System.Threading.Tasks.Task<__V> Run(IOperationFactory __m__, ICallable outer, ICallable inner, __T target)
        {
            return __m__.Run<ComposeImpl<__T,__U,__V>, (ICallable,ICallable,__T), __V>((outer, inner, target));
        }
    }

    public class Compose<__T, __U, __V> : Operation<(ICallable,ICallable), ICallable>, ICallable
    {
        public Compose(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(ICallable,ICallable)>, IApplyData
        {
            public In((ICallable,ICallable) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "Compose";
        String ICallable.FullName => "Microsoft.Quantum.Canon.Compose";
        protected ICallable ComposeImpl
        {
            get;
            set;
        }

        public override Func<(ICallable,ICallable), ICallable> Body => (__in) =>
        {
            var (outer,inner) = __in;
#line 32 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\Compose.qs"
            return ComposeImpl.Partial((((ICallable)outer), ((ICallable)inner), _));
        }

        ;
        public override void Init()
        {
            this.ComposeImpl = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ComposeImpl<,,>));
        }

        public override IApplyData __dataIn((ICallable,ICallable) data) => new In(data);
        public override IApplyData __dataOut(ICallable data) => new QTuple<ICallable>(data);
        public static System.Threading.Tasks.Task<ICallable> Run(IOperationFactory __m__, ICallable outer, ICallable inner)
        {
            return __m__.Run<Compose<__T,__U,__V>, (ICallable,ICallable), ICallable>((outer, inner));
        }
    }
}