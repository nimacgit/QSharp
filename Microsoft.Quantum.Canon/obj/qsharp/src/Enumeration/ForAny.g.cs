#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "ForAny<'T> (predicate : ('T -> Bool), array : 'T[]) : Bool", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Enumeration\\ForAny.qs", 1017L, 28L, 14L)]
#line hidden
namespace Microsoft.Quantum.Canon
{
    public class ForAny<__T> : Operation<(ICallable,QArray<__T>), Boolean>, ICallable
    {
        public ForAny(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(ICallable,QArray<__T>)>, IApplyData
        {
            public In((ICallable,QArray<__T>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "ForAny";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ForAny";
        public override Func<(ICallable,QArray<__T>), Boolean> Body => (__in) =>
        {
            var (predicate,array) = __in;
#line 29 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Enumeration\\ForAny.qs"
            var result = false;
#line 30 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Enumeration\\ForAny.qs"
            foreach (var idxElement in new Range(0L, (array.Count - 1L)))
            {
#line 31 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Enumeration\\ForAny.qs"
                result = (result || predicate.Apply<Boolean>(array[idxElement]));
            }

#line 33 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Enumeration\\ForAny.qs"
            return result;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((ICallable,QArray<__T>) data) => new In(data);
        public override IApplyData __dataOut(Boolean data) => new QTuple<Boolean>(data);
        public static System.Threading.Tasks.Task<Boolean> Run(IOperationFactory __m__, ICallable predicate, QArray<__T> array)
        {
            return __m__.Run<ForAny<__T>, (ICallable,QArray<__T>), Boolean>((predicate, array));
        }
    }
}