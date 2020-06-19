#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "IntAbs (input : Int) : Int", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Ranges.qs", 375L, 16L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "IntMax (a : Int, b : Int) : Int", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Ranges.qs", 889L, 38L, 14L)]
#line hidden
namespace Microsoft.Quantum.Canon
{
    public class IntAbs : Operation<Int64, Int64>, ICallable
    {
        public IntAbs(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "IntAbs";
        String ICallable.FullName => "Microsoft.Quantum.Canon.IntAbs";
        public override Func<Int64, Int64> Body => (__in) =>
        {
            var input = __in;
#line 17 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Ranges.qs"
            var tmp = 0L;
#line 18 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Ranges.qs"
            if ((input < 0L))
            {
#line 19 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Ranges.qs"
                tmp = -(input);
            }
            else
            {
#line 22 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Ranges.qs"
                tmp = input;
            }

#line 24 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Ranges.qs"
            return tmp;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Int64 input)
        {
            return __m__.Run<IntAbs, Int64, Int64>(input);
        }
    }

    public class IntMax : Operation<(Int64,Int64), Int64>, ICallable
    {
        public IntMax(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64)>, IApplyData
        {
            public In((Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "IntMax";
        String ICallable.FullName => "Microsoft.Quantum.Canon.IntMax";
        public override Func<(Int64,Int64), Int64> Body => (__in) =>
        {
            var (a,b) = __in;
#line 39 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Ranges.qs"
            var tmp = 0L;
#line 40 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Ranges.qs"
            if ((a < b))
            {
#line 41 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Ranges.qs"
                tmp = b;
            }
            else
            {
#line 44 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Ranges.qs"
                tmp = a;
            }

#line 46 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Ranges.qs"
            return tmp;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Int64 a, Int64 b)
        {
            return __m__.Run<IntMax, (Int64,Int64), Int64>((a, b));
        }
    }
}