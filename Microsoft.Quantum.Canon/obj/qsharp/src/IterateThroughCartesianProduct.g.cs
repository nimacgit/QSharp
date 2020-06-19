#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "IterateThroughCartesianProduct (bounds : Int[], op : (Int[] => ())) : ()", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\IterateThroughCartesianProduct.qs", 479L, 12L, 5L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "IterateThroughCartesianPower (power : Int, bound : Int, op : (Int[] => ())) : ()", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\IterateThroughCartesianProduct.qs", 1705L, 50L, 5L)]
#line hidden
namespace Microsoft.Quantum.Canon
{
    public class IterateThroughCartesianProduct : Operation<(QArray<Int64>,ICallable), QVoid>, ICallable
    {
        public IterateThroughCartesianProduct(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Int64>,ICallable)>, IApplyData
        {
            public In((QArray<Int64>,ICallable) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "IterateThroughCartesianProduct";
        String ICallable.FullName => "Microsoft.Quantum.Canon.IterateThroughCartesianProduct";
        public override Func<(QArray<Int64>,ICallable), QVoid> Body => (__in) =>
        {
            var (bounds,op) = __in;
#line 15 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\IterateThroughCartesianProduct.qs"
            var arr = new QArray<Int64>(bounds.Count);
#line 16 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\IterateThroughCartesianProduct.qs"
            var finished = false;
#line 17 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\IterateThroughCartesianProduct.qs"
            while (true)
            {
#line 19 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\IterateThroughCartesianProduct.qs"
                if (!(finished))
                {
#line 21 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\IterateThroughCartesianProduct.qs"
                    op.Apply(arr);
                }

                if (finished)
                {
                    break;
                }
                else
                {
                    //computes the next element in the Cartesian product
#line 28 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\IterateThroughCartesianProduct.qs"
                    arr[0L] = (arr[0L] + 1L);
#line 29 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\IterateThroughCartesianProduct.qs"
                    foreach (var i in new Range(0L, (arr.Count - 2L)))
                    {
#line 31 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\IterateThroughCartesianProduct.qs"
                        if ((arr[i] == bounds[i]))
                        {
#line 33 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\IterateThroughCartesianProduct.qs"
                            arr[(i + 1L)] = (arr[(i + 1L)] + 1L);
#line 34 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\IterateThroughCartesianProduct.qs"
                            arr[i] = 0L;
                        }
                    }

#line 37 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\IterateThroughCartesianProduct.qs"
                    if ((arr[(arr.Count - 1L)] == bounds[(arr.Count - 1L)]))
                    {
#line 39 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\IterateThroughCartesianProduct.qs"
                        finished = true;
                    }
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((QArray<Int64>,ICallable) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Int64> bounds, ICallable op)
        {
            return __m__.Run<IterateThroughCartesianProduct, (QArray<Int64>,ICallable), QVoid>((bounds, op));
        }
    }

    public class IterateThroughCartesianPower : Operation<(Int64,Int64,ICallable), QVoid>, ICallable
    {
        public IterateThroughCartesianPower(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64,ICallable)>, IApplyData
        {
            public In((Int64,Int64,ICallable) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item3)?.Qubits;
        }

        String ICallable.Name => "IterateThroughCartesianPower";
        String ICallable.FullName => "Microsoft.Quantum.Canon.IterateThroughCartesianPower";
        protected ICallable ConstantArray
        {
            get;
            set;
        }

        protected ICallable<(QArray<Int64>,ICallable), QVoid> IterateThroughCartesianProduct
        {
            get;
            set;
        }

        public override Func<(Int64,Int64,ICallable), QVoid> Body => (__in) =>
        {
            var (power,bound,op) = __in;
#line 53 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\IterateThroughCartesianProduct.qs"
            IterateThroughCartesianProduct.Apply((ConstantArray.Apply<QArray<Int64>>((power, bound)), ((ICallable)op)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.ConstantArray = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ConstantArray<>));
            this.IterateThroughCartesianProduct = this.Factory.Get<ICallable<(QArray<Int64>,ICallable), QVoid>>(typeof(Microsoft.Quantum.Canon.IterateThroughCartesianProduct));
        }

        public override IApplyData __dataIn((Int64,Int64,ICallable) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 power, Int64 bound, ICallable op)
        {
            return __m__.Run<IterateThroughCartesianPower, (Int64,Int64,ICallable), QVoid>((power, bound, op));
        }
    }
}