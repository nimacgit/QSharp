#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "Subarray<'T> (indices : Int[], array : 'T[]) : 'T[]", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Enumeration\\Subarray.qs", 1473L, 38L, 14L)]
#line hidden
namespace Microsoft.Quantum.Canon
{
    public class Subarray<__T> : Operation<(QArray<Int64>,QArray<__T>), QArray<__T>>, ICallable
    {
        public Subarray(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Int64>,QArray<__T>)>, IApplyData
        {
            public In((QArray<Int64>,QArray<__T>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "Subarray";
        String ICallable.FullName => "Microsoft.Quantum.Canon.Subarray";
        public override Func<(QArray<Int64>,QArray<__T>), QArray<__T>> Body => (__in) =>
        {
            var (indices,array) = __in;
#line 39 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Enumeration\\Subarray.qs"
            var nSliced = indices.Count;
#line 40 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Enumeration\\Subarray.qs"
            var sliced = new QArray<__T>(nSliced);
#line 41 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Enumeration\\Subarray.qs"
            foreach (var idx in new Range(0L, (nSliced - 1L)))
            {
#line 42 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Enumeration\\Subarray.qs"
                sliced[idx] = array[indices[idx]];
            }

#line 44 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Enumeration\\Subarray.qs"
            return sliced;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((QArray<Int64>,QArray<__T>) data) => new In(data);
        public override IApplyData __dataOut(QArray<__T> data) => data;
        public static System.Threading.Tasks.Task<QArray<__T>> Run(IOperationFactory __m__, QArray<Int64> indices, QArray<__T> array)
        {
            return __m__.Run<Subarray<__T>, (QArray<Int64>,QArray<__T>), QArray<__T>>((indices, array));
        }
    }
}