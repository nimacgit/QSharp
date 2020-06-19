#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "AssertAlmostEqualTol (actual : Double, expected : Double, tolerance : Double) : ()", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Asserts\\ClassicalAsserts.qs", 542L, 20L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "AssertAlmostEqual (actual : Double, expected : Double) : ()", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Asserts\\ClassicalAsserts.qs", 1277L, 41L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "AssertIntEqual (actual : Int, expected : Int, message : String) : ()", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Asserts\\ClassicalAsserts.qs", 1751L, 57L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "AssertBoolEqual (actual : Bool, expected : Bool, message : String) : ()", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Asserts\\ClassicalAsserts.qs", 2268L, 76L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "AssertResultEqual (actual : Result, expected : Result, message : String) : ()", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Asserts\\ClassicalAsserts.qs", 2780L, 94L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "AssertBoolArrayEqual (actual : Bool[], expected : Bool[], message : String) : ()", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Asserts\\ClassicalAsserts.qs", 3318L, 110L, 14L)]
#line hidden
namespace Microsoft.Quantum.Canon
{
    public class AssertAlmostEqualTol : Operation<(Double,Double,Double), QVoid>, ICallable
    {
        public AssertAlmostEqualTol(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Double,Double,Double)>, IApplyData
        {
            public In((Double,Double,Double) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "AssertAlmostEqualTol";
        String ICallable.FullName => "Microsoft.Quantum.Canon.AssertAlmostEqualTol";
        public override Func<(Double,Double,Double), QVoid> Body => (__in) =>
        {
            var (actual,expected,tolerance) = __in;
#line 21 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Asserts\\ClassicalAsserts.qs"
            var delta = (actual - expected);
#line 22 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Asserts\\ClassicalAsserts.qs"
            if (((delta > tolerance) || (delta < -(tolerance))))
            {
#line 23 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Asserts\\ClassicalAsserts.qs"
                throw new ExecutionFailException($"Assertion failed. Expected :  { expected } . Actual :  { actual } ");
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((Double,Double,Double) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Double actual, Double expected, Double tolerance)
        {
            return __m__.Run<AssertAlmostEqualTol, (Double,Double,Double), QVoid>((actual, expected, tolerance));
        }
    }

    public class AssertAlmostEqual : Operation<(Double,Double), QVoid>, ICallable
    {
        public AssertAlmostEqual(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Double,Double)>, IApplyData
        {
            public In((Double,Double) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "AssertAlmostEqual";
        String ICallable.FullName => "Microsoft.Quantum.Canon.AssertAlmostEqual";
        protected ICallable<(Double,Double,Double), QVoid> AssertAlmostEqualTol
        {
            get;
            set;
        }

        public override Func<(Double,Double), QVoid> Body => (__in) =>
        {
            var (actual,expected) = __in;
#line 42 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Asserts\\ClassicalAsserts.qs"
            AssertAlmostEqualTol.Apply((actual, expected, 1E-10D));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.AssertAlmostEqualTol = this.Factory.Get<ICallable<(Double,Double,Double), QVoid>>(typeof(Microsoft.Quantum.Canon.AssertAlmostEqualTol));
        }

        public override IApplyData __dataIn((Double,Double) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Double actual, Double expected)
        {
            return __m__.Run<AssertAlmostEqual, (Double,Double), QVoid>((actual, expected));
        }
    }

    public class AssertIntEqual : Operation<(Int64,Int64,String), QVoid>, ICallable
    {
        public AssertIntEqual(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64,String)>, IApplyData
        {
            public In((Int64,Int64,String) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "AssertIntEqual";
        String ICallable.FullName => "Microsoft.Quantum.Canon.AssertIntEqual";
        public override Func<(Int64,Int64,String), QVoid> Body => (__in) =>
        {
            var (actual,expected,message) = __in;
#line 58 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Asserts\\ClassicalAsserts.qs"
            if ((actual != expected))
            {
#line 60 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Asserts\\ClassicalAsserts.qs"
                throw new ExecutionFailException(message);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((Int64,Int64,String) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 actual, Int64 expected, String message)
        {
            return __m__.Run<AssertIntEqual, (Int64,Int64,String), QVoid>((actual, expected, message));
        }
    }

    public class AssertBoolEqual : Operation<(Boolean,Boolean,String), QVoid>, ICallable
    {
        public AssertBoolEqual(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Boolean,Boolean,String)>, IApplyData
        {
            public In((Boolean,Boolean,String) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "AssertBoolEqual";
        String ICallable.FullName => "Microsoft.Quantum.Canon.AssertBoolEqual";
        public override Func<(Boolean,Boolean,String), QVoid> Body => (__in) =>
        {
            var (actual,expected,message) = __in;
#line 77 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Asserts\\ClassicalAsserts.qs"
            if ((actual != expected))
            {
#line 78 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Asserts\\ClassicalAsserts.qs"
                throw new ExecutionFailException(message);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((Boolean,Boolean,String) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Boolean actual, Boolean expected, String message)
        {
            return __m__.Run<AssertBoolEqual, (Boolean,Boolean,String), QVoid>((actual, expected, message));
        }
    }

    public class AssertResultEqual : Operation<(Result,Result,String), QVoid>, ICallable
    {
        public AssertResultEqual(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Result,Result,String)>, IApplyData
        {
            public In((Result,Result,String) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "AssertResultEqual";
        String ICallable.FullName => "Microsoft.Quantum.Canon.AssertResultEqual";
        public override Func<(Result,Result,String), QVoid> Body => (__in) =>
        {
            var (actual,expected,message) = __in;
#line 95 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Asserts\\ClassicalAsserts.qs"
            if ((actual != expected))
            {
#line 96 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Asserts\\ClassicalAsserts.qs"
                throw new ExecutionFailException(message);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((Result,Result,String) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Result actual, Result expected, String message)
        {
            return __m__.Run<AssertResultEqual, (Result,Result,String), QVoid>((actual, expected, message));
        }
    }

    public class AssertBoolArrayEqual : Operation<(QArray<Boolean>,QArray<Boolean>,String), QVoid>, ICallable
    {
        public AssertBoolArrayEqual(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Boolean>,QArray<Boolean>,String)>, IApplyData
        {
            public In((QArray<Boolean>,QArray<Boolean>,String) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "AssertBoolArrayEqual";
        String ICallable.FullName => "Microsoft.Quantum.Canon.AssertBoolArrayEqual";
        public override Func<(QArray<Boolean>,QArray<Boolean>,String), QVoid> Body => (__in) =>
        {
            var (actual,expected,message) = __in;
#line 111 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Asserts\\ClassicalAsserts.qs"
            var n = actual.Count;
#line 112 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Asserts\\ClassicalAsserts.qs"
            if ((n != expected.Count))
            {
#line 113 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Asserts\\ClassicalAsserts.qs"
                throw new ExecutionFailException(message);
            }

#line 115 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Asserts\\ClassicalAsserts.qs"
            foreach (var idx in new Range(0L, (n - 1L)))
            {
#line 116 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Asserts\\ClassicalAsserts.qs"
                if ((actual[idx] != expected[idx]))
                {
#line 117 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Asserts\\ClassicalAsserts.qs"
                    throw new ExecutionFailException(message);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((QArray<Boolean>,QArray<Boolean>,String) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Boolean> actual, QArray<Boolean> expected, String message)
        {
            return __m__.Run<AssertBoolArrayEqual, (QArray<Boolean>,QArray<Boolean>,String), QVoid>((actual, expected, message));
        }
    }
}