#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "IsResultZero (input : Result) : Bool", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Predicates.qs", 418L, 14L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "IsResultOne (input : Result) : Bool", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Predicates.qs", 771L, 26L, 14L)]
#line hidden
namespace Microsoft.Quantum.Canon
{
    public class IsResultZero : Operation<Result, Boolean>, ICallable
    {
        public IsResultZero(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "IsResultZero";
        String ICallable.FullName => "Microsoft.Quantum.Canon.IsResultZero";
        public override Func<Result, Boolean> Body => (__in) =>
        {
            var input = __in;
#line 15 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Predicates.qs"
            return (input == Result.Zero);
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(Result data) => new QTuple<Result>(data);
        public override IApplyData __dataOut(Boolean data) => new QTuple<Boolean>(data);
        public static System.Threading.Tasks.Task<Boolean> Run(IOperationFactory __m__, Result input)
        {
            return __m__.Run<IsResultZero, Result, Boolean>(input);
        }
    }

    public class IsResultOne : Operation<Result, Boolean>, ICallable
    {
        public IsResultOne(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "IsResultOne";
        String ICallable.FullName => "Microsoft.Quantum.Canon.IsResultOne";
        public override Func<Result, Boolean> Body => (__in) =>
        {
            var input = __in;
#line 27 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\Predicates.qs"
            return (input == Result.One);
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(Result data) => new QTuple<Result>(data);
        public override IApplyData __dataOut(Boolean data) => new QTuple<Boolean>(data);
        public static System.Threading.Tasks.Task<Boolean> Run(IOperationFactory __m__, Result input)
        {
            return __m__.Run<IsResultOne, Result, Boolean>(input);
        }
    }
}