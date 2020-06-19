#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "Fold<'State, 'T> (folder : (('State, 'T) -> 'State), state : 'State, array : 'T[]) : 'State", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Enumeration\\Fold.qs", 1094L, 36L, 14L)]
#line hidden
namespace Microsoft.Quantum.Canon
{
    public class Fold<__State, __T> : Operation<(ICallable,__State,QArray<__T>), __State>, ICallable
    {
        public Fold(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(ICallable,__State,QArray<__T>)>, IApplyData
        {
            public In((ICallable,__State,QArray<__T>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, Data.Item2?.GetQubits(), ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "Fold";
        String ICallable.FullName => "Microsoft.Quantum.Canon.Fold";
        public override Func<(ICallable,__State,QArray<__T>), __State> Body => (__in) =>
        {
            var (folder,state,array) = __in;
#line 37 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Enumeration\\Fold.qs"
            var current = state;
#line 38 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Enumeration\\Fold.qs"
            foreach (var idxElement in new Range(0L, (array.Count - 1L)))
            {
#line 39 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Enumeration\\Fold.qs"
                current = folder.Apply<__State>((current, array[idxElement]));
            }

#line 41 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Enumeration\\Fold.qs"
            return current;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((ICallable,__State,QArray<__T>) data) => new In(data);
        public override IApplyData __dataOut(__State data) => new QTuple<__State>(data);
        public static System.Threading.Tasks.Task<__State> Run(IOperationFactory __m__, ICallable folder, __State state, QArray<__T> array)
        {
            return __m__.Run<Fold<__State,__T>, (ICallable,__State,QArray<__T>), __State>((folder, state, array));
        }
    }
}