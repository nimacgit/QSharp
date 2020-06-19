#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "Fst<'T, 'U> (pair : ('T, 'U)) : 'T", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\DataStructures\\Pairs.qs", 526L, 22L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "Snd<'T, 'U> (pair : ('T, 'U)) : 'U", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\DataStructures\\Pairs.qs", 1012L, 42L, 14L)]
#line hidden
namespace Microsoft.Quantum.Canon
{
    public class Fst<__T, __U> : Operation<(__T,__U), __T>, ICallable
    {
        public Fst(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(__T,__U)>, IApplyData
        {
            public In((__T,__U) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(Data.Item1?.GetQubits(), Data.Item2?.GetQubits());
        }

        String ICallable.Name => "Fst";
        String ICallable.FullName => "Microsoft.Quantum.Canon.Fst";
        public override Func<(__T,__U), __T> Body => (__in) =>
        {
            var pair = __in;
#line 23 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\DataStructures\\Pairs.qs"
            var (fst,snd) = pair;
#line 24 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\DataStructures\\Pairs.qs"
            return fst;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((__T,__U) data) => new In(data);
        public override IApplyData __dataOut(__T data) => new QTuple<__T>(data);
        public static System.Threading.Tasks.Task<__T> Run(IOperationFactory __m__, (__T,__U) pair)
        {
            return __m__.Run<Fst<__T,__U>, (__T,__U), __T>(pair);
        }
    }

    public class Snd<__T, __U> : Operation<(__T,__U), __U>, ICallable
    {
        public Snd(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(__T,__U)>, IApplyData
        {
            public In((__T,__U) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(Data.Item1?.GetQubits(), Data.Item2?.GetQubits());
        }

        String ICallable.Name => "Snd";
        String ICallable.FullName => "Microsoft.Quantum.Canon.Snd";
        public override Func<(__T,__U), __U> Body => (__in) =>
        {
            var pair = __in;
#line 43 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\DataStructures\\Pairs.qs"
            var (fst,snd) = pair;
#line 44 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\DataStructures\\Pairs.qs"
            return snd;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((__T,__U) data) => new In(data);
        public override IApplyData __dataOut(__U data) => new QTuple<__U>(data);
        public static System.Threading.Tasks.Task<__U> Run(IOperationFactory __m__, (__T,__U) pair)
        {
            return __m__.Run<Snd<__T,__U>, (__T,__U), __U>(pair);
        }
    }
}