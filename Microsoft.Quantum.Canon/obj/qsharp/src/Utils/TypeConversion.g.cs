#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "BoolFromResult (input : Result) : Bool", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\TypeConversion.qs", 451L, 17L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "ResultFromBool (input : Bool) : Result", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\TypeConversion.qs", 936L, 37L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "BoolArrFromResultArr (input : Result[]) : Bool[]", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\TypeConversion.qs", 1429L, 57L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "ResultArrFromBoolArr (input : Bool[]) : Result[]", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\TypeConversion.qs", 2025L, 77L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "BoolArrFromPositiveInt (number : Int, bits : Int) : Bool[]", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\TypeConversion.qs", 2645L, 98L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "PositiveIntFromBoolArr (bits : Bool[]) : Int", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\TypeConversion.qs", 3470L, 126L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "PositiveIntFromResultArr (results : Result[]) : Int", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\TypeConversion.qs", 4116L, 149L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "AsQubitArray (arr : Qubit[]) : Qubit[]", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\TypeConversion.qs", 4434L, 157L, 14L)]
#line hidden
namespace Microsoft.Quantum.Canon
{
    public class BoolFromResult : Operation<Result, Boolean>, ICallable
    {
        public BoolFromResult(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "BoolFromResult";
        String ICallable.FullName => "Microsoft.Quantum.Canon.BoolFromResult";
        public override Func<Result, Boolean> Body => (__in) =>
        {
            var input = __in;
#line 19 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\TypeConversion.qs"
            if ((input == Result.Zero))
            {
#line 20 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\TypeConversion.qs"
                return false;
            }
            else
            {
#line 23 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\TypeConversion.qs"
                return true;
            }
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(Result data) => new QTuple<Result>(data);
        public override IApplyData __dataOut(Boolean data) => new QTuple<Boolean>(data);
        public static System.Threading.Tasks.Task<Boolean> Run(IOperationFactory __m__, Result input)
        {
            return __m__.Run<BoolFromResult, Result, Boolean>(input);
        }
    }

    public class ResultFromBool : Operation<Boolean, Result>, ICallable
    {
        public ResultFromBool(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ResultFromBool";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ResultFromBool";
        public override Func<Boolean, Result> Body => (__in) =>
        {
            var input = __in;
#line 39 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\TypeConversion.qs"
            if ((input == false))
            {
#line 40 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\TypeConversion.qs"
                return Result.Zero;
            }
            else
            {
#line 43 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\TypeConversion.qs"
                return Result.One;
            }
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(Boolean data) => new QTuple<Boolean>(data);
        public override IApplyData __dataOut(Result data) => new QTuple<Result>(data);
        public static System.Threading.Tasks.Task<Result> Run(IOperationFactory __m__, Boolean input)
        {
            return __m__.Run<ResultFromBool, Boolean, Result>(input);
        }
    }

    public class BoolArrFromResultArr : Operation<QArray<Result>, QArray<Boolean>>, ICallable
    {
        public BoolArrFromResultArr(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "BoolArrFromResultArr";
        String ICallable.FullName => "Microsoft.Quantum.Canon.BoolArrFromResultArr";
        protected ICallable<Result, Boolean> BoolFromResult
        {
            get;
            set;
        }

        public override Func<QArray<Result>, QArray<Boolean>> Body => (__in) =>
        {
            var input = __in;
#line 59 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\TypeConversion.qs"
            var nInput = input.Count;
#line 60 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\TypeConversion.qs"
            var output = new QArray<Boolean>(nInput);
#line 61 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\TypeConversion.qs"
            foreach (var idx in new Range(0L, (nInput - 1L)))
            {
#line 62 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\TypeConversion.qs"
                output[idx] = BoolFromResult.Apply(input[idx]);
            }

#line 64 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\TypeConversion.qs"
            return output;
        }

        ;
        public override void Init()
        {
            this.BoolFromResult = this.Factory.Get<ICallable<Result, Boolean>>(typeof(Microsoft.Quantum.Canon.BoolFromResult));
        }

        public override IApplyData __dataIn(QArray<Result> data) => data;
        public override IApplyData __dataOut(QArray<Boolean> data) => data;
        public static System.Threading.Tasks.Task<QArray<Boolean>> Run(IOperationFactory __m__, QArray<Result> input)
        {
            return __m__.Run<BoolArrFromResultArr, QArray<Result>, QArray<Boolean>>(input);
        }
    }

    public class ResultArrFromBoolArr : Operation<QArray<Boolean>, QArray<Result>>, ICallable
    {
        public ResultArrFromBoolArr(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ResultArrFromBoolArr";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ResultArrFromBoolArr";
        protected ICallable<Boolean, Result> ResultFromBool
        {
            get;
            set;
        }

        public override Func<QArray<Boolean>, QArray<Result>> Body => (__in) =>
        {
            var input = __in;
#line 79 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\TypeConversion.qs"
            var nInput = input.Count;
#line 80 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\TypeConversion.qs"
            var output = new QArray<Result>(nInput);
#line 81 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\TypeConversion.qs"
            foreach (var idx in new Range(0L, (nInput - 1L)))
            {
#line 82 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\TypeConversion.qs"
                output[idx] = ResultFromBool.Apply(input[idx]);
            }

#line 84 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\TypeConversion.qs"
            return output;
        }

        ;
        public override void Init()
        {
            this.ResultFromBool = this.Factory.Get<ICallable<Boolean, Result>>(typeof(Microsoft.Quantum.Canon.ResultFromBool));
        }

        public override IApplyData __dataIn(QArray<Boolean> data) => data;
        public override IApplyData __dataOut(QArray<Result> data) => data;
        public static System.Threading.Tasks.Task<QArray<Result>> Run(IOperationFactory __m__, QArray<Boolean> input)
        {
            return __m__.Run<ResultArrFromBoolArr, QArray<Boolean>, QArray<Result>>(input);
        }
    }

    public class BoolArrFromPositiveInt : Operation<(Int64,Int64), QArray<Boolean>>, ICallable
    {
        public BoolArrFromPositiveInt(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64)>, IApplyData
        {
            public In((Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "BoolArrFromPositiveInt";
        String ICallable.FullName => "Microsoft.Quantum.Canon.BoolArrFromPositiveInt";
        protected ICallable<(Boolean,Boolean,String), QVoid> AssertBoolEqual
        {
            get;
            set;
        }

        public override Func<(Int64,Int64), QArray<Boolean>> Body => (__in) =>
        {
            var (number,bits) = __in;
#line 100 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\TypeConversion.qs"
            AssertBoolEqual.Apply((((number >= 0L) && (number < 2L.Pow(bits))), true, "`number` must be between 0 and 2^`bits` - 1"));
#line 104 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\TypeConversion.qs"
            var outputBits = new QArray<Boolean>(bits);
#line 105 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\TypeConversion.qs"
            var tempInt = number;
#line 107 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\TypeConversion.qs"
            foreach (var idxBit in new Range(0L, (bits - 1L)))
            {
#line 108 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\TypeConversion.qs"
                if (((tempInt % 2L) == 0L))
                {
#line 109 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\TypeConversion.qs"
                    outputBits[idxBit] = false;
                }
                else
                {
#line 112 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\TypeConversion.qs"
                    outputBits[idxBit] = true;
                }

#line 114 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\TypeConversion.qs"
                tempInt = (tempInt / 2L);
            }

#line 117 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\TypeConversion.qs"
            return outputBits;
        }

        ;
        public override void Init()
        {
            this.AssertBoolEqual = this.Factory.Get<ICallable<(Boolean,Boolean,String), QVoid>>(typeof(Microsoft.Quantum.Canon.AssertBoolEqual));
        }

        public override IApplyData __dataIn((Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(QArray<Boolean> data) => data;
        public static System.Threading.Tasks.Task<QArray<Boolean>> Run(IOperationFactory __m__, Int64 number, Int64 bits)
        {
            return __m__.Run<BoolArrFromPositiveInt, (Int64,Int64), QArray<Boolean>>((number, bits));
        }
    }

    public class PositiveIntFromBoolArr : Operation<QArray<Boolean>, Int64>, ICallable
    {
        public PositiveIntFromBoolArr(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "PositiveIntFromBoolArr";
        String ICallable.FullName => "Microsoft.Quantum.Canon.PositiveIntFromBoolArr";
        protected ICallable<(Boolean,Boolean,String), QVoid> AssertBoolEqual
        {
            get;
            set;
        }

        public override Func<QArray<Boolean>, Int64> Body => (__in) =>
        {
            var bits = __in;
#line 128 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\TypeConversion.qs"
            AssertBoolEqual.Apply(((bits.Count < 64L), true, "`Length(bits)` must be less than 64"));
#line 132 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\TypeConversion.qs"
            var number = 0L;
#line 133 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\TypeConversion.qs"
            var nBits = bits.Count;
#line 135 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\TypeConversion.qs"
            foreach (var idxBit in new Range(0L, (nBits - 1L)))
            {
#line 136 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\TypeConversion.qs"
                if (bits[idxBit])
                {
#line 137 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\TypeConversion.qs"
                    number = (number + 2L.Pow(idxBit));
                }
            }

#line 140 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\TypeConversion.qs"
            return number;
        }

        ;
        public override void Init()
        {
            this.AssertBoolEqual = this.Factory.Get<ICallable<(Boolean,Boolean,String), QVoid>>(typeof(Microsoft.Quantum.Canon.AssertBoolEqual));
        }

        public override IApplyData __dataIn(QArray<Boolean> data) => data;
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, QArray<Boolean> bits)
        {
            return __m__.Run<PositiveIntFromBoolArr, QArray<Boolean>, Int64>(bits);
        }
    }

    public class PositiveIntFromResultArr : Operation<QArray<Result>, Int64>, ICallable
    {
        public PositiveIntFromResultArr(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "PositiveIntFromResultArr";
        String ICallable.FullName => "Microsoft.Quantum.Canon.PositiveIntFromResultArr";
        protected ICallable<QArray<Result>, QArray<Boolean>> BoolArrFromResultArr
        {
            get;
            set;
        }

        protected ICallable<QArray<Boolean>, Int64> PositiveIntFromBoolArr
        {
            get;
            set;
        }

        public override Func<QArray<Result>, Int64> Body => (__in) =>
        {
            var results = __in;
#line 151 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\TypeConversion.qs"
            return PositiveIntFromBoolArr.Apply(BoolArrFromResultArr.Apply(results));
        }

        ;
        public override void Init()
        {
            this.BoolArrFromResultArr = this.Factory.Get<ICallable<QArray<Result>, QArray<Boolean>>>(typeof(Microsoft.Quantum.Canon.BoolArrFromResultArr));
            this.PositiveIntFromBoolArr = this.Factory.Get<ICallable<QArray<Boolean>, Int64>>(typeof(Microsoft.Quantum.Canon.PositiveIntFromBoolArr));
        }

        public override IApplyData __dataIn(QArray<Result> data) => data;
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, QArray<Result> results)
        {
            return __m__.Run<PositiveIntFromResultArr, QArray<Result>, Int64>(results);
        }
    }

    public class AsQubitArray : Operation<QArray<Qubit>, QArray<Qubit>>, ICallable
    {
        public AsQubitArray(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "AsQubitArray";
        String ICallable.FullName => "Microsoft.Quantum.Canon.AsQubitArray";
        public override Func<QArray<Qubit>, QArray<Qubit>> Body => (__in) =>
        {
            var arr = __in;
#line 158 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Utils\\TypeConversion.qs"
            return arr;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QArray<Qubit> data) => data;
        public static System.Threading.Tasks.Task<QArray<Qubit>> Run(IOperationFactory __m__, QArray<Qubit> arr)
        {
            return __m__.Run<AsQubitArray, QArray<Qubit>, QArray<Qubit>>(arr);
        }
    }
}