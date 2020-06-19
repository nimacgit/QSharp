#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: UdtDeclaration("Microsoft.Quantum.Canon", "ResultStack", "(Int, Int, Result[])", "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\DataStructures\\Stack.qs", 306L, 9L, 89L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "StackCapacity (stack : Microsoft.Quantum.Canon.ResultStack) : Int", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\DataStructures\\Stack.qs", 655L, 21L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "StackLength (stack : Microsoft.Quantum.Canon.ResultStack) : Int", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\DataStructures\\Stack.qs", 1079L, 36L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "StackPop (stack : Microsoft.Quantum.Canon.ResultStack) : Microsoft.Quantum.Canon.ResultStack", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\DataStructures\\Stack.qs", 1561L, 51L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "StackPush (stack : Microsoft.Quantum.Canon.ResultStack, datum : Result) : Microsoft.Quantum.Canon.ResultStack", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\DataStructures\\Stack.qs", 2199L, 71L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "StackPeek (stack : Microsoft.Quantum.Canon.ResultStack) : Result", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\DataStructures\\Stack.qs", 3048L, 96L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "StackNew (size : Int) : Microsoft.Quantum.Canon.ResultStack", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\DataStructures\\Stack.qs", 3562L, 113L, 14L)]
#line hidden
namespace Microsoft.Quantum.Canon
{
    public class ResultStack : QTuple<(Int64,Int64,QArray<Result>)>, IApplyData
    {
        public ResultStack() : base(default((Int64,Int64,QArray<Result>)))
        {
        }

        public ResultStack((Int64,Int64,QArray<Result>) data) : base(data)
        {
        }

        public ResultStack(QTuple<(Int64,Int64,QArray<Result>)> b) : base(b.Data)
        {
        }

        public Int64 Item1 => Data.Item1;
        public Int64 Item2 => Data.Item2;
        public QArray<Result> Item3 => Data.Item3;
        System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        public void Deconstruct(out Int64 item1, out Int64 item2, out QArray<Result> item3)
        {
            item1 = Data.Item1;
            item2 = Data.Item2;
            item3 = Data.Item3;
        }
    }

    public class StackCapacity : Operation<ResultStack, Int64>, ICallable
    {
        public StackCapacity(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "StackCapacity";
        String ICallable.FullName => "Microsoft.Quantum.Canon.StackCapacity";
        public override Func<ResultStack, Int64> Body => (__in) =>
        {
            var stack = __in;
#line 22 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\DataStructures\\Stack.qs"
            var (size,pos,data) = stack;
#line 23 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\DataStructures\\Stack.qs"
            return size;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(ResultStack data) => data;
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, ResultStack stack)
        {
            return __m__.Run<StackCapacity, ResultStack, Int64>(stack);
        }
    }

    public class StackLength : Operation<ResultStack, Int64>, ICallable
    {
        public StackLength(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "StackLength";
        String ICallable.FullName => "Microsoft.Quantum.Canon.StackLength";
        public override Func<ResultStack, Int64> Body => (__in) =>
        {
            var stack = __in;
#line 37 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\DataStructures\\Stack.qs"
            var (size,pos,data) = stack;
#line 38 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\DataStructures\\Stack.qs"
            return pos;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(ResultStack data) => data;
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, ResultStack stack)
        {
            return __m__.Run<StackLength, ResultStack, Int64>(stack);
        }
    }

    public class StackPop : Operation<ResultStack, ResultStack>, ICallable
    {
        public StackPop(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "StackPop";
        String ICallable.FullName => "Microsoft.Quantum.Canon.StackPop";
        public override Func<ResultStack, ResultStack> Body => (__in) =>
        {
            var stack = __in;
#line 52 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\DataStructures\\Stack.qs"
            var (size,pos,data) = stack;
#line 53 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\DataStructures\\Stack.qs"
            if ((pos == 0L))
            {
#line 54 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\DataStructures\\Stack.qs"
                throw new ExecutionFailException("Cannot pop an empty stack.");
            }

#line 56 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\DataStructures\\Stack.qs"
            return new ResultStack((size, (pos - 1L), data));
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(ResultStack data) => data;
        public override IApplyData __dataOut(ResultStack data) => data;
        public static System.Threading.Tasks.Task<ResultStack> Run(IOperationFactory __m__, ResultStack stack)
        {
            return __m__.Run<StackPop, ResultStack, ResultStack>(stack);
        }
    }

    public class StackPush : Operation<(ResultStack,Result), ResultStack>, ICallable
    {
        public StackPush(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(ResultStack,Result)>, IApplyData
        {
            public In((ResultStack,Result) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "StackPush";
        String ICallable.FullName => "Microsoft.Quantum.Canon.StackPush";
        public override Func<(ResultStack,Result), ResultStack> Body => (__in) =>
        {
            var (stack,datum) = __in;
#line 72 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\DataStructures\\Stack.qs"
            var (size,pos,data) = stack;
#line 73 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\DataStructures\\Stack.qs"
            if ((pos == size))
            {
#line 74 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\DataStructures\\Stack.qs"
                throw new ExecutionFailException("Stack is full.");
            }

            // FIXME: implies an O(n) copy!
            //        This could be fixed by using a native C# operation to
            //        wrap ImmutableStack<T>.
            // See also: https://msdn.microsoft.com/en-us/library/dn467197(v=vs.111).aspx
#line 81 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\DataStructures\\Stack.qs"
            var newData = data;
#line 82 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\DataStructures\\Stack.qs"
            newData[pos] = datum;
#line 84 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\DataStructures\\Stack.qs"
            return new ResultStack((size, (pos + 1L), newData));
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((ResultStack,Result) data) => new In(data);
        public override IApplyData __dataOut(ResultStack data) => data;
        public static System.Threading.Tasks.Task<ResultStack> Run(IOperationFactory __m__, ResultStack stack, Result datum)
        {
            return __m__.Run<StackPush, (ResultStack,Result), ResultStack>((stack, datum));
        }
    }

    public class StackPeek : Operation<ResultStack, Result>, ICallable
    {
        public StackPeek(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "StackPeek";
        String ICallable.FullName => "Microsoft.Quantum.Canon.StackPeek";
        public override Func<ResultStack, Result> Body => (__in) =>
        {
            var stack = __in;
#line 97 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\DataStructures\\Stack.qs"
            var (size,pos,data) = stack;
#line 98 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\DataStructures\\Stack.qs"
            if ((pos == 0L))
            {
#line 99 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\DataStructures\\Stack.qs"
                throw new ExecutionFailException("Cannot peek at an empty stack.");
            }

#line 101 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\DataStructures\\Stack.qs"
            return data[(pos - 1L)];
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(ResultStack data) => data;
        public override IApplyData __dataOut(Result data) => new QTuple<Result>(data);
        public static System.Threading.Tasks.Task<Result> Run(IOperationFactory __m__, ResultStack stack)
        {
            return __m__.Run<StackPeek, ResultStack, Result>(stack);
        }
    }

    public class StackNew : Operation<Int64, ResultStack>, ICallable
    {
        public StackNew(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "StackNew";
        String ICallable.FullName => "Microsoft.Quantum.Canon.StackNew";
        public override Func<Int64, ResultStack> Body => (__in) =>
        {
            var size = __in;
#line 114 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\DataStructures\\Stack.qs"
            return new ResultStack((size, 0L, new QArray<Result>(size)));
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __dataOut(ResultStack data) => data;
        public static System.Threading.Tasks.Task<ResultStack> Run(IOperationFactory __m__, Int64 size)
        {
            return __m__.Run<StackNew, Int64, ResultStack>(size);
        }
    }
}