#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "Reverse<'T> (array : 'T[]) : 'T[]", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arrays\\Arrays.qs", 639L, 22L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "Rest<'T> (array : 'T[]) : 'T[]", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arrays\\Arrays.qs", 1396L, 47L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "Most<'T> (array : 'T[]) : 'T[]", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arrays\\Arrays.qs", 1952L, 65L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "LookupImpl<'T> (array : 'T[], index : Int) : 'T", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arrays\\Arrays.qs", 2052L, 69L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "LookupFunction<'T> (array : 'T[]) : (Int -> 'T)", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arrays\\Arrays.qs", 2951L, 95L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "Zip<'T, 'U> (left : 'T[], right : 'U[]) : ('T, 'U)[]", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arrays\\Arrays.qs", 4002L, 126L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "Tail<'A> (array : 'A[]) : 'A", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arrays\\Arrays.qs", 4847L, 157L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "Head<'A> (array : 'A[]) : 'A", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arrays\\Arrays.qs", 5398L, 175L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "ConstantArray<'T> (length : Int, value : 'T) : 'T[]", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arrays\\Arrays.qs", 5948L, 191L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "Exclude<'T> (remove : Int[], array : 'T[]) : 'T[]", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arrays\\Arrays.qs", 7092L, 228L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "Pad<'T> (nElementsTotal : Int, defaultElement : 'T, inputArray : 'T[]) : 'T[]", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arrays\\Arrays.qs", 8826L, 286L, 14L)]
#line hidden
namespace Microsoft.Quantum.Canon
{
    public class Reverse<__T> : Operation<QArray<__T>, QArray<__T>>, ICallable
    {
        public Reverse(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "Reverse";
        String ICallable.FullName => "Microsoft.Quantum.Canon.Reverse";
        public override Func<QArray<__T>, QArray<__T>> Body => (__in) =>
        {
            var array = __in;
#line 23 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arrays\\Arrays.qs"
            var nElements = array.Count;
#line 24 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arrays\\Arrays.qs"
            var newArray = new QArray<__T>(nElements);
#line 26 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arrays\\Arrays.qs"
            foreach (var idxElement in new Range(0L, (nElements - 1L)))
            {
#line 27 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arrays\\Arrays.qs"
                newArray[((nElements - idxElement) - 1L)] = array[idxElement];
            }

#line 30 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arrays\\Arrays.qs"
            return newArray;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(QArray<__T> data) => data;
        public override IApplyData __dataOut(QArray<__T> data) => data;
        public static System.Threading.Tasks.Task<QArray<__T>> Run(IOperationFactory __m__, QArray<__T> array)
        {
            return __m__.Run<Reverse<__T>, QArray<__T>, QArray<__T>>(array);
        }
    }

    public class Rest<__T> : Operation<QArray<__T>, QArray<__T>>, ICallable
    {
        public Rest(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "Rest";
        String ICallable.FullName => "Microsoft.Quantum.Canon.Rest";
        public override Func<QArray<__T>, QArray<__T>> Body => (__in) =>
        {
            var array = __in;
#line 48 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arrays\\Arrays.qs"
            return array?.Slice(new Range(1L, (array.Count - 1L)));
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(QArray<__T> data) => data;
        public override IApplyData __dataOut(QArray<__T> data) => data;
        public static System.Threading.Tasks.Task<QArray<__T>> Run(IOperationFactory __m__, QArray<__T> array)
        {
            return __m__.Run<Rest<__T>, QArray<__T>, QArray<__T>>(array);
        }
    }

    public class Most<__T> : Operation<QArray<__T>, QArray<__T>>, ICallable
    {
        public Most(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "Most";
        String ICallable.FullName => "Microsoft.Quantum.Canon.Most";
        public override Func<QArray<__T>, QArray<__T>> Body => (__in) =>
        {
            var array = __in;
#line 66 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arrays\\Arrays.qs"
            return array?.Slice(new Range(0L, (array.Count - 2L)));
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(QArray<__T> data) => data;
        public override IApplyData __dataOut(QArray<__T> data) => data;
        public static System.Threading.Tasks.Task<QArray<__T>> Run(IOperationFactory __m__, QArray<__T> array)
        {
            return __m__.Run<Most<__T>, QArray<__T>, QArray<__T>>(array);
        }
    }

    public class LookupImpl<__T> : Operation<(QArray<__T>,Int64), __T>, ICallable
    {
        public LookupImpl(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<__T>,Int64)>, IApplyData
        {
            public In((QArray<__T>,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "LookupImpl";
        String ICallable.FullName => "Microsoft.Quantum.Canon.LookupImpl";
        public override Func<(QArray<__T>,Int64), __T> Body => (__in) =>
        {
            var (array,index) = __in;
#line 70 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arrays\\Arrays.qs"
            return array[index];
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((QArray<__T>,Int64) data) => new In(data);
        public override IApplyData __dataOut(__T data) => new QTuple<__T>(data);
        public static System.Threading.Tasks.Task<__T> Run(IOperationFactory __m__, QArray<__T> array, Int64 index)
        {
            return __m__.Run<LookupImpl<__T>, (QArray<__T>,Int64), __T>((array, index));
        }
    }

    public class LookupFunction<__T> : Operation<QArray<__T>, ICallable>, ICallable
    {
        public LookupFunction(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "LookupFunction";
        String ICallable.FullName => "Microsoft.Quantum.Canon.LookupFunction";
        protected ICallable LookupImpl
        {
            get;
            set;
        }

        public override Func<QArray<__T>, ICallable> Body => (__in) =>
        {
            var array = __in;
#line 96 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arrays\\Arrays.qs"
            return LookupImpl.Partial((array, _));
        }

        ;
        public override void Init()
        {
            this.LookupImpl = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.LookupImpl<>));
        }

        public override IApplyData __dataIn(QArray<__T> data) => data;
        public override IApplyData __dataOut(ICallable data) => new QTuple<ICallable>(data);
        public static System.Threading.Tasks.Task<ICallable> Run(IOperationFactory __m__, QArray<__T> array)
        {
            return __m__.Run<LookupFunction<__T>, QArray<__T>, ICallable>(array);
        }
    }

    public class Zip<__T, __U> : Operation<(QArray<__T>,QArray<__U>), QArray<(__T,__U)>>, ICallable
    {
        public Zip(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<__T>,QArray<__U>)>, IApplyData
        {
            public In((QArray<__T>,QArray<__U>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "Zip";
        String ICallable.FullName => "Microsoft.Quantum.Canon.Zip";
        public override Func<(QArray<__T>,QArray<__U>), QArray<(__T,__U)>> Body => (__in) =>
        {
            var (left,right) = __in;
#line 127 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arrays\\Arrays.qs"
            var nElements = 0L;
#line 128 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arrays\\Arrays.qs"
            if ((left.Count < right.Count))
            {
#line 129 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arrays\\Arrays.qs"
                nElements = left.Count;
            }
            else
            {
#line 131 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arrays\\Arrays.qs"
                nElements = right.Count;
            }

#line 134 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arrays\\Arrays.qs"
            var output = new QArray<(__T,__U)>(nElements);
#line 136 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arrays\\Arrays.qs"
            foreach (var idxElement in new Range(0L, (nElements - 1L)))
            {
#line 137 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arrays\\Arrays.qs"
                output[idxElement] = (left[idxElement], right[idxElement]);
            }

#line 140 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arrays\\Arrays.qs"
            return output;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((QArray<__T>,QArray<__U>) data) => new In(data);
        public override IApplyData __dataOut(QArray<(__T,__U)> data) => data;
        public static System.Threading.Tasks.Task<QArray<(__T,__U)>> Run(IOperationFactory __m__, QArray<__T> left, QArray<__U> right)
        {
            return __m__.Run<Zip<__T,__U>, (QArray<__T>,QArray<__U>), QArray<(__T,__U)>>((left, right));
        }
    }

    public class Tail<__A> : Operation<QArray<__A>, __A>, ICallable
    {
        public Tail(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "Tail";
        String ICallable.FullName => "Microsoft.Quantum.Canon.Tail";
        protected ICallable<(Boolean,Boolean,String), QVoid> AssertBoolEqual
        {
            get;
            set;
        }

        public override Func<QArray<__A>, __A> Body => (__in) =>
        {
            var array = __in;
#line 158 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arrays\\Arrays.qs"
            AssertBoolEqual.Apply(((array.Count > 0L), true, "Array must be of the length at least 1"));
#line 159 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arrays\\Arrays.qs"
            return array[(array.Count - 1L)];
        }

        ;
        public override void Init()
        {
            this.AssertBoolEqual = this.Factory.Get<ICallable<(Boolean,Boolean,String), QVoid>>(typeof(Microsoft.Quantum.Canon.AssertBoolEqual));
        }

        public override IApplyData __dataIn(QArray<__A> data) => data;
        public override IApplyData __dataOut(__A data) => new QTuple<__A>(data);
        public static System.Threading.Tasks.Task<__A> Run(IOperationFactory __m__, QArray<__A> array)
        {
            return __m__.Run<Tail<__A>, QArray<__A>, __A>(array);
        }
    }

    public class Head<__A> : Operation<QArray<__A>, __A>, ICallable
    {
        public Head(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "Head";
        String ICallable.FullName => "Microsoft.Quantum.Canon.Head";
        protected ICallable<(Boolean,Boolean,String), QVoid> AssertBoolEqual
        {
            get;
            set;
        }

        public override Func<QArray<__A>, __A> Body => (__in) =>
        {
            var array = __in;
#line 176 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arrays\\Arrays.qs"
            AssertBoolEqual.Apply(((array.Count > 0L), true, "Array must be of the length at least 1"));
#line 177 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arrays\\Arrays.qs"
            return array[0L];
        }

        ;
        public override void Init()
        {
            this.AssertBoolEqual = this.Factory.Get<ICallable<(Boolean,Boolean,String), QVoid>>(typeof(Microsoft.Quantum.Canon.AssertBoolEqual));
        }

        public override IApplyData __dataIn(QArray<__A> data) => data;
        public override IApplyData __dataOut(__A data) => new QTuple<__A>(data);
        public static System.Threading.Tasks.Task<__A> Run(IOperationFactory __m__, QArray<__A> array)
        {
            return __m__.Run<Head<__A>, QArray<__A>, __A>(array);
        }
    }

    public class ConstantArray<__T> : Operation<(Int64,__T), QArray<__T>>, ICallable
    {
        public ConstantArray(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,__T)>, IApplyData
        {
            public In((Int64,__T) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Data.Item2?.GetQubits();
        }

        String ICallable.Name => "ConstantArray";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ConstantArray";
        public override Func<(Int64,__T), QArray<__T>> Body => (__in) =>
        {
            var (length,value) = __in;
#line 193 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arrays\\Arrays.qs"
            var arr = new QArray<__T>(length);
#line 194 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arrays\\Arrays.qs"
            foreach (var i in new Range(0L, (length - 1L)))
            {
#line 196 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arrays\\Arrays.qs"
                arr[i] = value;
            }

#line 198 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arrays\\Arrays.qs"
            return arr;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((Int64,__T) data) => new In(data);
        public override IApplyData __dataOut(QArray<__T> data) => data;
        public static System.Threading.Tasks.Task<QArray<__T>> Run(IOperationFactory __m__, Int64 length, __T value)
        {
            return __m__.Run<ConstantArray<__T>, (Int64,__T), QArray<__T>>((length, value));
        }
    }

    public class Exclude<__T> : Operation<(QArray<Int64>,QArray<__T>), QArray<__T>>, ICallable
    {
        public Exclude(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Int64>,QArray<__T>)>, IApplyData
        {
            public In((QArray<Int64>,QArray<__T>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "Exclude";
        String ICallable.FullName => "Microsoft.Quantum.Canon.Exclude";
        public override Func<(QArray<Int64>,QArray<__T>), QArray<__T>> Body => (__in) =>
        {
            var (remove,array) = __in;
#line 231 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arrays\\Arrays.qs"
            var nSliced = remove.Count;
#line 232 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arrays\\Arrays.qs"
            var nElements = array.Count;
            //Would be better with sort function
            //Or way to add elements to array
#line 236 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arrays\\Arrays.qs"
            var arrayKeep = new QArray<Int64>(nElements);
#line 237 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arrays\\Arrays.qs"
            var sliced = new QArray<__T>((nElements - nSliced));
#line 238 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arrays\\Arrays.qs"
            var counter = 0L;
#line 240 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arrays\\Arrays.qs"
            foreach (var idx in new Range(0L, (nElements - 1L)))
            {
#line 241 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arrays\\Arrays.qs"
                arrayKeep[idx] = idx;
            }

#line 243 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arrays\\Arrays.qs"
            foreach (var idx in new Range(0L, (nSliced - 1L)))
            {
#line 244 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arrays\\Arrays.qs"
                arrayKeep[remove[idx]] = -(1L);
            }

#line 246 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arrays\\Arrays.qs"
            foreach (var idx in new Range(0L, (nElements - 1L)))
            {
#line 247 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arrays\\Arrays.qs"
                if ((arrayKeep[idx] >= 0L))
                {
#line 248 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arrays\\Arrays.qs"
                    sliced[counter] = array[arrayKeep[idx]];
#line 249 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arrays\\Arrays.qs"
                    counter = (counter + 1L);
                }
            }

#line 253 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arrays\\Arrays.qs"
            return sliced;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((QArray<Int64>,QArray<__T>) data) => new In(data);
        public override IApplyData __dataOut(QArray<__T> data) => data;
        public static System.Threading.Tasks.Task<QArray<__T>> Run(IOperationFactory __m__, QArray<Int64> remove, QArray<__T> array)
        {
            return __m__.Run<Exclude<__T>, (QArray<Int64>,QArray<__T>), QArray<__T>>((remove, array));
        }
    }

    public class Pad<__T> : Operation<(Int64,__T,QArray<__T>), QArray<__T>>, ICallable
    {
        public Pad(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,__T,QArray<__T>)>, IApplyData
        {
            public In((Int64,__T,QArray<__T>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(Data.Item2?.GetQubits(), ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "Pad";
        String ICallable.FullName => "Microsoft.Quantum.Canon.Pad";
        protected ICallable<Int64, Int64> MicrosoftQuantumExtensionsMathAbsI
        {
            get;
            set;
        }

        protected ICallable<(Boolean,Boolean,String), QVoid> AssertBoolEqual
        {
            get;
            set;
        }

        protected ICallable ConstantArray
        {
            get;
            set;
        }

        public override Func<(Int64,__T,QArray<__T>), QArray<__T>> Body => (__in) =>
        {
            var (nElementsTotal,defaultElement,inputArray) = __in;
#line 288 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arrays\\Arrays.qs"
            var nElementsInitial = inputArray.Count;
#line 289 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arrays\\Arrays.qs"
            var nAbsElementsTotal = MicrosoftQuantumExtensionsMathAbsI.Apply(nElementsTotal);
#line 290 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arrays\\Arrays.qs"
            AssertBoolEqual.Apply(((nAbsElementsTotal >= nElementsInitial), true, "Specified output array length must be longer than `inputArray` length."));
#line 291 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arrays\\Arrays.qs"
            var nElementsPad = (nAbsElementsTotal - nElementsInitial);
#line 292 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arrays\\Arrays.qs"
            var padArray = ConstantArray.Apply<QArray<__T>>((nElementsPad, defaultElement));
#line 293 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arrays\\Arrays.qs"
            if ((nElementsTotal >= 0L))
            {
                // Pad at head.
#line 295 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arrays\\Arrays.qs"
                return (padArray + inputArray);
            }
            else
            {
                // Pad at tail.
#line 299 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Arrays\\Arrays.qs"
                return (inputArray + padArray);
            }
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumExtensionsMathAbsI = this.Factory.Get<ICallable<Int64, Int64>>(typeof(Microsoft.Quantum.Extensions.Math.AbsI));
            this.AssertBoolEqual = this.Factory.Get<ICallable<(Boolean,Boolean,String), QVoid>>(typeof(Microsoft.Quantum.Canon.AssertBoolEqual));
            this.ConstantArray = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ConstantArray<>));
        }

        public override IApplyData __dataIn((Int64,__T,QArray<__T>) data) => new In(data);
        public override IApplyData __dataOut(QArray<__T> data) => data;
        public static System.Threading.Tasks.Task<QArray<__T>> Run(IOperationFactory __m__, Int64 nElementsTotal, __T defaultElement, QArray<__T> inputArray)
        {
            return __m__.Run<Pad<__T>, (Int64,__T,QArray<__T>), QArray<__T>>((nElementsTotal, defaultElement, inputArray));
        }
    }
}