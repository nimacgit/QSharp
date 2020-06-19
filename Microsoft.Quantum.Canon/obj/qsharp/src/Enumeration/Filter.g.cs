#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "Filter<'T> (predicate : ('T -> Bool), array : 'T[]) : 'T[]", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Enumeration\\Filter.qs", 927L, 27L, 14L)]
#line hidden
namespace Microsoft.Quantum.Canon
{
    public class Filter<__T> : Operation<(ICallable,QArray<__T>), QArray<__T>>, ICallable
    {
        public Filter(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(ICallable,QArray<__T>)>, IApplyData
        {
            public In((ICallable,QArray<__T>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "Filter";
        String ICallable.FullName => "Microsoft.Quantum.Canon.Filter";
        protected ICallable Subarray
        {
            get;
            set;
        }

        public override Func<(ICallable,QArray<__T>), QArray<__T>> Body => (__in) =>
        {
            var (predicate,array) = __in;
#line 28 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Enumeration\\Filter.qs"
            var totalFound = 0L;
#line 29 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Enumeration\\Filter.qs"
            var idxArray = new QArray<Int64>(array.Count);
#line 30 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Enumeration\\Filter.qs"
            foreach (var idxElement in new Range(0L, (array.Count - 1L)))
            {
#line 31 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Enumeration\\Filter.qs"
                if (predicate.Apply<Boolean>(array[idxElement]))
                {
#line 32 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Enumeration\\Filter.qs"
                    idxArray[totalFound] = idxElement;
#line 33 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Enumeration\\Filter.qs"
                    totalFound = (totalFound + 1L);
                }
            }

#line 36 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Enumeration\\Filter.qs"
            return Subarray.Apply<QArray<__T>>((idxArray?.Slice(new Range(0L, (totalFound - 1L))), array));
        }

        ;
        public override void Init()
        {
            this.Subarray = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Subarray<>));
        }

        public override IApplyData __dataIn((ICallable,QArray<__T>) data) => new In(data);
        public override IApplyData __dataOut(QArray<__T> data) => data;
        public static System.Threading.Tasks.Task<QArray<__T>> Run(IOperationFactory __m__, ICallable predicate, QArray<__T> array)
        {
            return __m__.Run<Filter<__T>, (ICallable,QArray<__T>), QArray<__T>>((predicate, array));
        }
    }
}