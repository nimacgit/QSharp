#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "Map<'T, 'U> (mapper : ('T -> 'U), array : 'T[]) : 'U[]", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Enumeration\\Map.qs", 1070L, 30L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "MapIndex<'T, 'U> (mapper : ((Int, 'T) -> 'U), array : 'T[]) : 'U[]", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Enumeration\\Map.qs", 2610L, 73L, 14L)]
#line hidden
namespace Microsoft.Quantum.Canon
{
    public class Map<__T, __U> : Operation<(ICallable,QArray<__T>), QArray<__U>>, ICallable
    {
        public Map(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(ICallable,QArray<__T>)>, IApplyData
        {
            public In((ICallable,QArray<__T>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "Map";
        String ICallable.FullName => "Microsoft.Quantum.Canon.Map";
        public override Func<(ICallable,QArray<__T>), QArray<__U>> Body => (__in) =>
        {
            var (mapper,array) = __in;
#line 31 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Enumeration\\Map.qs"
            var resultArray = new QArray<__U>(array.Count);
#line 32 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Enumeration\\Map.qs"
            foreach (var idxElement in new Range(0L, (array.Count - 1L)))
            {
#line 33 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Enumeration\\Map.qs"
                resultArray[idxElement] = mapper.Apply<__U>(array[idxElement]);
            }

#line 35 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Enumeration\\Map.qs"
            return resultArray;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((ICallable,QArray<__T>) data) => new In(data);
        public override IApplyData __dataOut(QArray<__U> data) => data;
        public static System.Threading.Tasks.Task<QArray<__U>> Run(IOperationFactory __m__, ICallable mapper, QArray<__T> array)
        {
            return __m__.Run<Map<__T,__U>, (ICallable,QArray<__T>), QArray<__U>>((mapper, array));
        }
    }

    public class MapIndex<__T, __U> : Operation<(ICallable,QArray<__T>), QArray<__U>>, ICallable
    {
        public MapIndex(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(ICallable,QArray<__T>)>, IApplyData
        {
            public In((ICallable,QArray<__T>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "MapIndex";
        String ICallable.FullName => "Microsoft.Quantum.Canon.MapIndex";
        public override Func<(ICallable,QArray<__T>), QArray<__U>> Body => (__in) =>
        {
            var (mapper,array) = __in;
#line 74 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Enumeration\\Map.qs"
            var resultArray = new QArray<__U>(array.Count);
#line 75 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Enumeration\\Map.qs"
            foreach (var idxElement in new Range(0L, (array.Count - 1L)))
            {
#line 76 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Enumeration\\Map.qs"
                resultArray[idxElement] = mapper.Apply<__U>((idxElement, array[idxElement]));
            }

#line 78 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Enumeration\\Map.qs"
            return resultArray;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((ICallable,QArray<__T>) data) => new In(data);
        public override IApplyData __dataOut(QArray<__U> data) => data;
        public static System.Threading.Tasks.Task<QArray<__U>> Run(IOperationFactory __m__, ICallable mapper, QArray<__T> array)
        {
            return __m__.Run<MapIndex<__T,__U>, (ICallable,QArray<__T>), QArray<__U>>((mapper, array));
        }
    }
}