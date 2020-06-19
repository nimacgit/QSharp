#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "ForAll<'T> (predicate : ('T -> Bool), array : 'T[]) : Bool", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Enumeration\\ForAll.qs", 1005L, 28L, 14L)]
#line hidden
namespace Microsoft.Quantum.Canon
{
    public class ForAll<__T> : Operation<(ICallable,QArray<__T>), Boolean>, ICallable
    {
        public ForAll(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(ICallable,QArray<__T>)>, IApplyData
        {
            public In((ICallable,QArray<__T>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "ForAll";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ForAll";
        public override Func<(ICallable,QArray<__T>), Boolean> Body => (__in) =>
        {
            var (predicate,array) = __in;
#line 29 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Enumeration\\ForAll.qs"
            var result = true;
#line 30 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Enumeration\\ForAll.qs"
            foreach (var idxElement in new Range(0L, (array.Count - 1L)))
            {
#line 31 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Enumeration\\ForAll.qs"
                result = (result && predicate.Apply<Boolean>(array[idxElement]));
            }

#line 33 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Enumeration\\ForAll.qs"
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
            return __m__.Run<ForAll<__T>, (ICallable,QArray<__T>), Boolean>((predicate, array));
        }
    }
}