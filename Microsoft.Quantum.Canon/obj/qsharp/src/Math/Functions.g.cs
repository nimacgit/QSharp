#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: UdtDeclaration("Microsoft.Quantum.Canon", "Fraction", "(Int, Int)", "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs", 8127L, 240L, 22L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "Lg (input : Double) : Double", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs", 475L, 18L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "Max (values : Int[]) : Int", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs", 930L, 33L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "Min (value : Int[]) : Int", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs", 1473L, 55L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "RealMod (value : Double, modulo : Double, minValue : Double) : Double", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs", 2739L, 94L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "ArcCosh (x : Double) : Double", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs", 3488L, 114L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "ArcSinh (x : Double) : Double", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs", 3951L, 129L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "ArcTanh (x : Double) : Double", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs", 4401L, 144L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "Modulus (value : Int, modulus : Int) : Int", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs", 5178L, 163L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "ExpMod (expBase : Int, power : Int, modulus : Int) : Int", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs", 5788L, 181L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "ExtendedGCD (a : Int, b : Int) : (Int, Int)", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs", 7390L, 220L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "GCD (a : Int, b : Int) : Int", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs", 8578L, 254L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "ContinuedFractionConvergent (fraction : Microsoft.Quantum.Canon.Fraction, denominatorBound : Int) : Microsoft.Quantum.Canon.Fraction", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs", 9042L, 269L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "IsCoprime (a : Int, b : Int) : Bool", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs", 10401L, 308L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "InverseMod (a : Int, modulus : Int) : Int", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs", 10850L, 324L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "BitSize (a : Int) : Int", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs", 11410L, 343L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "PNorm (p : Double, array : Double[]) : Double", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs", 12041L, 366L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "PNormalize (p : Double, array : Double[]) : Double[]", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs", 12801L, 391L, 14L)]
#line hidden
namespace Microsoft.Quantum.Canon
{
    public class Lg : Operation<Double, Double>, ICallable
    {
        public Lg(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "Lg";
        String ICallable.FullName => "Microsoft.Quantum.Canon.Lg";
        protected ICallable<Double, Double> MicrosoftQuantumExtensionsMathLog
        {
            get;
            set;
        }

        protected ICallable<QVoid, Double> LogOf2
        {
            get;
            set;
        }

        public override Func<Double, Double> Body => (__in) =>
        {
            var input = __in;
            // Fully-qualified name is required because Log also appears in Primitives
#line 21 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
            return (MicrosoftQuantumExtensionsMathLog.Apply(input) / LogOf2.Apply(QVoid.Instance));
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumExtensionsMathLog = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Extensions.Math.Log));
            this.LogOf2 = this.Factory.Get<ICallable<QVoid, Double>>(typeof(Microsoft.Quantum.Canon.LogOf2));
        }

        public override IApplyData __dataIn(Double data) => new QTuple<Double>(data);
        public override IApplyData __dataOut(Double data) => new QTuple<Double>(data);
        public static System.Threading.Tasks.Task<Double> Run(IOperationFactory __m__, Double input)
        {
            return __m__.Run<Lg, Double, Double>(input);
        }
    }

    public class Max : Operation<QArray<Int64>, Int64>, ICallable
    {
        public Max(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "Max";
        String ICallable.FullName => "Microsoft.Quantum.Canon.Max";
        public override Func<QArray<Int64>, Int64> Body => (__in) =>
        {
            var values = __in;
#line 35 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
            var max = values[0L];
#line 36 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
            var nTerms = values.Count;
#line 37 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
            foreach (var idx in new Range(0L, (nTerms - 1L)))
            {
#line 39 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
                if ((values[idx] > max))
                {
#line 40 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
                    max = values[idx];
                }
            }

#line 43 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
            return max;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(QArray<Int64> data) => data;
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, QArray<Int64> values)
        {
            return __m__.Run<Max, QArray<Int64>, Int64>(values);
        }
    }

    public class Min : Operation<QArray<Int64>, Int64>, ICallable
    {
        public Min(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "Min";
        String ICallable.FullName => "Microsoft.Quantum.Canon.Min";
        public override Func<QArray<Int64>, Int64> Body => (__in) =>
        {
            var value = __in;
#line 57 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
            var min = value[0L];
#line 58 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
            var nTerms = value.Count;
#line 59 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
            foreach (var idx in new Range(0L, (nTerms - 1L)))
            {
#line 61 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
                if ((value[idx] < min))
                {
#line 62 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
                    min = value[idx];
                }
            }

#line 65 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
            return min;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(QArray<Int64> data) => data;
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, QArray<Int64> value)
        {
            return __m__.Run<Min, QArray<Int64>, Int64>(value);
        }
    }

    public class RealMod : Operation<(Double,Double,Double), Double>, ICallable
    {
        public RealMod(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Double,Double,Double)>, IApplyData
        {
            public In((Double,Double,Double) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "RealMod";
        String ICallable.FullName => "Microsoft.Quantum.Canon.RealMod";
        protected ICallable<(Double,Double), Double> MicrosoftQuantumExtensionsMathArcTan2
        {
            get;
            set;
        }

        protected ICallable<Double, Double> MicrosoftQuantumExtensionsMathCos
        {
            get;
            set;
        }

        protected ICallable<QVoid, Double> MicrosoftQuantumExtensionsMathPI
        {
            get;
            set;
        }

        protected ICallable<Double, Double> MicrosoftQuantumExtensionsMathSin
        {
            get;
            set;
        }

        public override Func<(Double,Double,Double), Double> Body => (__in) =>
        {
            var (value,modulo,minValue) = __in;
#line 95 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
            var fractionalValue = ((2D * MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance)) * (((value - minValue) / modulo) - 0.5D));
#line 96 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
            var cosFracValue = MicrosoftQuantumExtensionsMathCos.Apply(fractionalValue);
#line 97 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
            var sinFracValue = MicrosoftQuantumExtensionsMathSin.Apply(fractionalValue);
#line 98 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
            var moduloValue = (0.5D + (MicrosoftQuantumExtensionsMathArcTan2.Apply((sinFracValue, cosFracValue)) / (2D * MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance))));
#line 99 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
            var output = ((moduloValue * modulo) + minValue);
#line 100 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
            return output;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumExtensionsMathArcTan2 = this.Factory.Get<ICallable<(Double,Double), Double>>(typeof(Microsoft.Quantum.Extensions.Math.ArcTan2));
            this.MicrosoftQuantumExtensionsMathCos = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Extensions.Math.Cos));
            this.MicrosoftQuantumExtensionsMathPI = this.Factory.Get<ICallable<QVoid, Double>>(typeof(Microsoft.Quantum.Extensions.Math.PI));
            this.MicrosoftQuantumExtensionsMathSin = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Extensions.Math.Sin));
        }

        public override IApplyData __dataIn((Double,Double,Double) data) => new In(data);
        public override IApplyData __dataOut(Double data) => new QTuple<Double>(data);
        public static System.Threading.Tasks.Task<Double> Run(IOperationFactory __m__, Double value, Double modulo, Double minValue)
        {
            return __m__.Run<RealMod, (Double,Double,Double), Double>((value, modulo, minValue));
        }
    }

    public class ArcCosh : Operation<Double, Double>, ICallable
    {
        public ArcCosh(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ArcCosh";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ArcCosh";
        protected ICallable<Double, Double> MicrosoftQuantumExtensionsMathLog
        {
            get;
            set;
        }

        protected ICallable<Double, Double> MicrosoftQuantumExtensionsMathSqrt
        {
            get;
            set;
        }

        public override Func<Double, Double> Body => (__in) =>
        {
            var x = __in;
            // Fully-qualified name is required because Log also appears in Primitives
#line 117 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
            return MicrosoftQuantumExtensionsMathLog.Apply((x + MicrosoftQuantumExtensionsMathSqrt.Apply(((x * x) - 1D))));
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumExtensionsMathLog = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Extensions.Math.Log));
            this.MicrosoftQuantumExtensionsMathSqrt = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Extensions.Math.Sqrt));
        }

        public override IApplyData __dataIn(Double data) => new QTuple<Double>(data);
        public override IApplyData __dataOut(Double data) => new QTuple<Double>(data);
        public static System.Threading.Tasks.Task<Double> Run(IOperationFactory __m__, Double x)
        {
            return __m__.Run<ArcCosh, Double, Double>(x);
        }
    }

    public class ArcSinh : Operation<Double, Double>, ICallable
    {
        public ArcSinh(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ArcSinh";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ArcSinh";
        protected ICallable<Double, Double> MicrosoftQuantumExtensionsMathLog
        {
            get;
            set;
        }

        protected ICallable<Double, Double> MicrosoftQuantumExtensionsMathSqrt
        {
            get;
            set;
        }

        public override Func<Double, Double> Body => (__in) =>
        {
            var x = __in;
            // Fully-qualified name is required because Log also appears in Primitives
#line 132 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
            return MicrosoftQuantumExtensionsMathLog.Apply((x + MicrosoftQuantumExtensionsMathSqrt.Apply(((x * x) + 1D))));
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumExtensionsMathLog = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Extensions.Math.Log));
            this.MicrosoftQuantumExtensionsMathSqrt = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Extensions.Math.Sqrt));
        }

        public override IApplyData __dataIn(Double data) => new QTuple<Double>(data);
        public override IApplyData __dataOut(Double data) => new QTuple<Double>(data);
        public static System.Threading.Tasks.Task<Double> Run(IOperationFactory __m__, Double x)
        {
            return __m__.Run<ArcSinh, Double, Double>(x);
        }
    }

    public class ArcTanh : Operation<Double, Double>, ICallable
    {
        public ArcTanh(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ArcTanh";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ArcTanh";
        protected ICallable<Double, Double> MicrosoftQuantumExtensionsMathLog
        {
            get;
            set;
        }

        public override Func<Double, Double> Body => (__in) =>
        {
            var x = __in;
            // Fully-qualified name is required because Log also appears in Primitives
#line 147 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
            return (MicrosoftQuantumExtensionsMathLog.Apply(((1D + x) / (1D - x))) * 0.5D);
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumExtensionsMathLog = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Extensions.Math.Log));
        }

        public override IApplyData __dataIn(Double data) => new QTuple<Double>(data);
        public override IApplyData __dataOut(Double data) => new QTuple<Double>(data);
        public static System.Threading.Tasks.Task<Double> Run(IOperationFactory __m__, Double x)
        {
            return __m__.Run<ArcTanh, Double, Double>(x);
        }
    }

    public class Modulus : Operation<(Int64,Int64), Int64>, ICallable
    {
        public Modulus(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64)>, IApplyData
        {
            public In((Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "Modulus";
        String ICallable.FullName => "Microsoft.Quantum.Canon.Modulus";
        protected ICallable<(Boolean,Boolean,String), QVoid> AssertBoolEqual
        {
            get;
            set;
        }

        public override Func<(Int64,Int64), Int64> Body => (__in) =>
        {
            var (value,modulus) = __in;
#line 165 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
            AssertBoolEqual.Apply(((modulus > 0L), true, "`modulus` must be positive"));
#line 166 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
            var r = (value % modulus);
#line 167 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
            if ((r < 0L))
            {
#line 168 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
                return (r + modulus);
            }
            else
            {
#line 170 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
                return r;
            }
        }

        ;
        public override void Init()
        {
            this.AssertBoolEqual = this.Factory.Get<ICallable<(Boolean,Boolean,String), QVoid>>(typeof(Microsoft.Quantum.Canon.AssertBoolEqual));
        }

        public override IApplyData __dataIn((Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Int64 value, Int64 modulus)
        {
            return __m__.Run<Modulus, (Int64,Int64), Int64>((value, modulus));
        }
    }

    public class ExpMod : Operation<(Int64,Int64,Int64), Int64>, ICallable
    {
        public ExpMod(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64,Int64)>, IApplyData
        {
            public In((Int64,Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "ExpMod";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ExpMod";
        protected ICallable<(Boolean,Boolean,String), QVoid> AssertBoolEqual
        {
            get;
            set;
        }

        protected ICallable<Int64, Int64> BitSize
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64), QArray<Boolean>> BoolArrFromPositiveInt
        {
            get;
            set;
        }

        public override Func<(Int64,Int64,Int64), Int64> Body => (__in) =>
        {
            var (expBase,power,modulus) = __in;
#line 183 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
            AssertBoolEqual.Apply(((power >= 0L), true, "`power` must be non-negative"));
#line 184 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
            AssertBoolEqual.Apply(((modulus > 0L), true, "`modulus` must be positive"));
#line 185 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
            AssertBoolEqual.Apply(((expBase > 0L), true, "`expBase` must be positive"));
#line 187 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
            var res = 1L;
#line 188 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
            var expPow2mod = expBase;
            // express p as bit-string pₙ … p₀ 
#line 190 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
            var powerBitExpansion = BoolArrFromPositiveInt.Apply((power, BitSize.Apply(power)));
#line 191 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
            var expBaseMod = (expBase % modulus);
#line 193 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
            foreach (var k in new Range(0L, (powerBitExpansion.Count - 1L)))
            {
#line 195 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
                if (powerBitExpansion[k])
                {
                    // if bit pₖ is 1, multiply res by expBase^(2ᵏ) (mod `modulus`)
#line 197 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
                    res = ((res * expPow2mod) % modulus);
                }

                // update value of expBase^(2ᵏ) (mod `modulus`)
#line 200 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
                expPow2mod = ((expPow2mod * expPow2mod) % modulus);
            }

#line 202 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
            return res;
        }

        ;
        public override void Init()
        {
            this.AssertBoolEqual = this.Factory.Get<ICallable<(Boolean,Boolean,String), QVoid>>(typeof(Microsoft.Quantum.Canon.AssertBoolEqual));
            this.BitSize = this.Factory.Get<ICallable<Int64, Int64>>(typeof(Microsoft.Quantum.Canon.BitSize));
            this.BoolArrFromPositiveInt = this.Factory.Get<ICallable<(Int64,Int64), QArray<Boolean>>>(typeof(Microsoft.Quantum.Canon.BoolArrFromPositiveInt));
        }

        public override IApplyData __dataIn((Int64,Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Int64 expBase, Int64 power, Int64 modulus)
        {
            return __m__.Run<ExpMod, (Int64,Int64,Int64), Int64>((expBase, power, modulus));
        }
    }

    public class ExtendedGCD : Operation<(Int64,Int64), (Int64,Int64)>, ICallable
    {
        public ExtendedGCD(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64)>, IApplyData
        {
            public In((Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        public class Out : QTuple<(Int64,Int64)>, IApplyData
        {
            public Out((Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "ExtendedGCD";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ExtendedGCD";
        protected ICallable Fst
        {
            get;
            set;
        }

        protected ICallable<Int64, Int64> MicrosoftQuantumExtensionsMathSignI
        {
            get;
            set;
        }

        protected ICallable Snd
        {
            get;
            set;
        }

        public override Func<(Int64,Int64), (Int64,Int64)> Body => (__in) =>
        {
            var (a,b) = __in;
#line 221 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
            var signA = MicrosoftQuantumExtensionsMathSignI.Apply(a);
#line 222 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
            var signB = MicrosoftQuantumExtensionsMathSignI.Apply(b);
#line 223 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
            var s = (1L, 0L);
#line 224 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
            var t = (0L, 1L);
#line 225 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
            var r = ((a * signA), (b * signB));
#line 226 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
            while (true)
            {
                if ((Snd.Apply<Int64>(r) == 0L))
                {
                    break;
                }
                else
                {
#line 229 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
                    var quotient = (Fst.Apply<Int64>(r) / Snd.Apply<Int64>(r));
#line 230 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
                    r = (Snd.Apply<Int64>(r), (Fst.Apply<Int64>(r) - (quotient * Snd.Apply<Int64>(r))));
#line 231 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
                    s = (Snd.Apply<Int64>(s), (Fst.Apply<Int64>(s) - (quotient * Snd.Apply<Int64>(s))));
#line 232 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
                    t = (Snd.Apply<Int64>(t), (Fst.Apply<Int64>(t) - (quotient * Snd.Apply<Int64>(t))));
                }
            }

#line 234 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
            return ((Fst.Apply<Int64>(s) * signA), (Fst.Apply<Int64>(t) * signB));
        }

        ;
        public override void Init()
        {
            this.Fst = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Fst<,>));
            this.MicrosoftQuantumExtensionsMathSignI = this.Factory.Get<ICallable<Int64, Int64>>(typeof(Microsoft.Quantum.Extensions.Math.SignI));
            this.Snd = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Snd<,>));
        }

        public override IApplyData __dataIn((Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut((Int64,Int64) data) => new Out(data);
        public static System.Threading.Tasks.Task<(Int64,Int64)> Run(IOperationFactory __m__, Int64 a, Int64 b)
        {
            return __m__.Run<ExtendedGCD, (Int64,Int64), (Int64,Int64)>((a, b));
        }
    }

    public class Fraction : QTuple<(Int64,Int64)>, IApplyData
    {
        public Fraction() : base(default((Int64,Int64)))
        {
        }

        public Fraction((Int64,Int64) data) : base(data)
        {
        }

        public Fraction(QTuple<(Int64,Int64)> b) : base(b.Data)
        {
        }

        public Int64 Item1 => Data.Item1;
        public Int64 Item2 => Data.Item2;
        System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        public void Deconstruct(out Int64 item1, out Int64 item2)
        {
            item1 = Data.Item1;
            item2 = Data.Item2;
        }
    }

    public class GCD : Operation<(Int64,Int64), Int64>, ICallable
    {
        public GCD(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64)>, IApplyData
        {
            public In((Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "GCD";
        String ICallable.FullName => "Microsoft.Quantum.Canon.GCD";
        protected ICallable<(Int64,Int64), (Int64,Int64)> ExtendedGCD
        {
            get;
            set;
        }

        public override Func<(Int64,Int64), Int64> Body => (__in) =>
        {
            var (a,b) = __in;
#line 255 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
            var (u,v) = ExtendedGCD.Apply((a, b));
#line 256 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
            return ((u * a) + (v * b));
        }

        ;
        public override void Init()
        {
            this.ExtendedGCD = this.Factory.Get<ICallable<(Int64,Int64), (Int64,Int64)>>(typeof(Microsoft.Quantum.Canon.ExtendedGCD));
        }

        public override IApplyData __dataIn((Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Int64 a, Int64 b)
        {
            return __m__.Run<GCD, (Int64,Int64), Int64>((a, b));
        }
    }

    public class ContinuedFractionConvergent : Operation<(Fraction,Int64), Fraction>, ICallable
    {
        public ContinuedFractionConvergent(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Fraction,Int64)>, IApplyData
        {
            public In((Fraction,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "ContinuedFractionConvergent";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ContinuedFractionConvergent";
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

        protected ICallable Fst
        {
            get;
            set;
        }

        protected ICallable<Int64, Int64> MicrosoftQuantumExtensionsMathSignI
        {
            get;
            set;
        }

        protected ICallable Snd
        {
            get;
            set;
        }

        public override Func<(Fraction,Int64), Fraction> Body => (__in) =>
        {
            var (fraction,denominatorBound) = __in;
#line 272 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
            AssertBoolEqual.Apply(((denominatorBound > 0L), true, "Denominator bound must be positive"));
#line 274 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
            var (a,b) = fraction;
#line 275 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
            var signA = MicrosoftQuantumExtensionsMathSignI.Apply(a);
#line 276 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
            var signB = MicrosoftQuantumExtensionsMathSignI.Apply(b);
#line 277 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
            var s = (1L, 0L);
#line 278 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
            var t = (0L, 1L);
#line 279 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
            var r = ((a * signA), (b * signB));
#line 280 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
            while (true)
            {
                if (((Snd.Apply<Int64>(r) == 0L) || (MicrosoftQuantumExtensionsMathAbsI.Apply(Snd.Apply<Int64>(s)) > denominatorBound)))
                {
                    break;
                }
                else
                {
#line 283 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
                    var quotient = (Fst.Apply<Int64>(r) / Snd.Apply<Int64>(r));
#line 284 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
                    r = (Snd.Apply<Int64>(r), (Fst.Apply<Int64>(r) - (quotient * Snd.Apply<Int64>(r))));
#line 285 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
                    s = (Snd.Apply<Int64>(s), (Fst.Apply<Int64>(s) - (quotient * Snd.Apply<Int64>(s))));
#line 286 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
                    t = (Snd.Apply<Int64>(t), (Fst.Apply<Int64>(t) - (quotient * Snd.Apply<Int64>(t))));
                }
            }

#line 289 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
            if (((Snd.Apply<Int64>(r) == 0L) && (MicrosoftQuantumExtensionsMathAbsI.Apply(Snd.Apply<Int64>(s)) <= denominatorBound)))
            {
#line 290 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
                return new Fraction(((-(Snd.Apply<Int64>(t)) * signB), (Snd.Apply<Int64>(s) * signA)));
            }

#line 293 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
            return new Fraction(((-(Fst.Apply<Int64>(t)) * signB), (Fst.Apply<Int64>(s) * signA)));
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumExtensionsMathAbsI = this.Factory.Get<ICallable<Int64, Int64>>(typeof(Microsoft.Quantum.Extensions.Math.AbsI));
            this.AssertBoolEqual = this.Factory.Get<ICallable<(Boolean,Boolean,String), QVoid>>(typeof(Microsoft.Quantum.Canon.AssertBoolEqual));
            this.Fst = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Fst<,>));
            this.MicrosoftQuantumExtensionsMathSignI = this.Factory.Get<ICallable<Int64, Int64>>(typeof(Microsoft.Quantum.Extensions.Math.SignI));
            this.Snd = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Snd<,>));
        }

        public override IApplyData __dataIn((Fraction,Int64) data) => new In(data);
        public override IApplyData __dataOut(Fraction data) => data;
        public static System.Threading.Tasks.Task<Fraction> Run(IOperationFactory __m__, Fraction fraction, Int64 denominatorBound)
        {
            return __m__.Run<ContinuedFractionConvergent, (Fraction,Int64), Fraction>((fraction, denominatorBound));
        }
    }

    public class IsCoprime : Operation<(Int64,Int64), Boolean>, ICallable
    {
        public IsCoprime(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64)>, IApplyData
        {
            public In((Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "IsCoprime";
        String ICallable.FullName => "Microsoft.Quantum.Canon.IsCoprime";
        protected ICallable<(Int64,Int64), (Int64,Int64)> ExtendedGCD
        {
            get;
            set;
        }

        public override Func<(Int64,Int64), Boolean> Body => (__in) =>
        {
            var (a,b) = __in;
#line 309 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
            var (u,v) = ExtendedGCD.Apply((a, b));
#line 310 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
            return (((u * a) + (v * b)) == 1L);
        }

        ;
        public override void Init()
        {
            this.ExtendedGCD = this.Factory.Get<ICallable<(Int64,Int64), (Int64,Int64)>>(typeof(Microsoft.Quantum.Canon.ExtendedGCD));
        }

        public override IApplyData __dataIn((Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(Boolean data) => new QTuple<Boolean>(data);
        public static System.Threading.Tasks.Task<Boolean> Run(IOperationFactory __m__, Int64 a, Int64 b)
        {
            return __m__.Run<IsCoprime, (Int64,Int64), Boolean>((a, b));
        }
    }

    public class InverseMod : Operation<(Int64,Int64), Int64>, ICallable
    {
        public InverseMod(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64)>, IApplyData
        {
            public In((Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "InverseMod";
        String ICallable.FullName => "Microsoft.Quantum.Canon.InverseMod";
        protected ICallable<(Boolean,Boolean,String), QVoid> AssertBoolEqual
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64), (Int64,Int64)> ExtendedGCD
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64), Int64> Modulus
        {
            get;
            set;
        }

        public override Func<(Int64,Int64), Int64> Body => (__in) =>
        {
            var (a,modulus) = __in;
#line 325 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
            var (u,v) = ExtendedGCD.Apply((a, modulus));
#line 326 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
            var gcd = ((u * a) + (v * modulus));
#line 327 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
            AssertBoolEqual.Apply(((gcd == 1L), true, "`a` and `modulus` must be co-prime"));
#line 330 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
            return Modulus.Apply((u, modulus));
        }

        ;
        public override void Init()
        {
            this.AssertBoolEqual = this.Factory.Get<ICallable<(Boolean,Boolean,String), QVoid>>(typeof(Microsoft.Quantum.Canon.AssertBoolEqual));
            this.ExtendedGCD = this.Factory.Get<ICallable<(Int64,Int64), (Int64,Int64)>>(typeof(Microsoft.Quantum.Canon.ExtendedGCD));
            this.Modulus = this.Factory.Get<ICallable<(Int64,Int64), Int64>>(typeof(Microsoft.Quantum.Canon.Modulus));
        }

        public override IApplyData __dataIn((Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Int64 a, Int64 modulus)
        {
            return __m__.Run<InverseMod, (Int64,Int64), Int64>((a, modulus));
        }
    }

    public class BitSize : Operation<Int64, Int64>, ICallable
    {
        public BitSize(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "BitSize";
        String ICallable.FullName => "Microsoft.Quantum.Canon.BitSize";
        protected ICallable<(Boolean,Boolean,String), QVoid> AssertBoolEqual
        {
            get;
            set;
        }

        public override Func<Int64, Int64> Body => (__in) =>
        {
            var a = __in;
#line 344 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
            AssertBoolEqual.Apply(((a >= 0L), true, "`a` must be non-negative"));
#line 345 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
            var bitsize = 0L;
#line 346 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
            var val = a;
#line 347 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
            while (true)
            {
                if ((val == 0L))
                {
                    break;
                }
                else
                {
#line 350 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
                    bitsize = (bitsize + 1L);
#line 351 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
                    val = (val / 2L);
                }
            }

#line 353 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
            return bitsize;
        }

        ;
        public override void Init()
        {
            this.AssertBoolEqual = this.Factory.Get<ICallable<(Boolean,Boolean,String), QVoid>>(typeof(Microsoft.Quantum.Canon.AssertBoolEqual));
        }

        public override IApplyData __dataIn(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Int64 a)
        {
            return __m__.Run<BitSize, Int64, Int64>(a);
        }
    }

    public class PNorm : Operation<(Double,QArray<Double>), Double>, ICallable
    {
        public PNorm(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Double,QArray<Double>)>, IApplyData
        {
            public In((Double,QArray<Double>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "PNorm";
        String ICallable.FullName => "Microsoft.Quantum.Canon.PNorm";
        protected ICallable<Double, Double> MicrosoftQuantumExtensionsMathAbsD
        {
            get;
            set;
        }

        protected ICallable<(Double,Double), Double> MicrosoftQuantumExtensionsMathPowD
        {
            get;
            set;
        }

        public override Func<(Double,QArray<Double>), Double> Body => (__in) =>
        {
            var (p,array) = __in;
#line 367 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
            if ((p < 1D))
            {
#line 368 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
                throw new ExecutionFailException("PNorm failed. `p` must be >= 1.0");
            }

#line 370 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
            var nElements = array.Count;
#line 371 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
            var norm = 0D;
#line 372 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
            foreach (var idx in new Range(0L, (nElements - 1L)))
            {
#line 373 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
                norm = (norm + MicrosoftQuantumExtensionsMathPowD.Apply((MicrosoftQuantumExtensionsMathAbsD.Apply(array[idx]), p)));
            }

#line 375 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
            return MicrosoftQuantumExtensionsMathPowD.Apply((norm, (1D / p)));
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumExtensionsMathAbsD = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Extensions.Math.AbsD));
            this.MicrosoftQuantumExtensionsMathPowD = this.Factory.Get<ICallable<(Double,Double), Double>>(typeof(Microsoft.Quantum.Extensions.Math.PowD));
        }

        public override IApplyData __dataIn((Double,QArray<Double>) data) => new In(data);
        public override IApplyData __dataOut(Double data) => new QTuple<Double>(data);
        public static System.Threading.Tasks.Task<Double> Run(IOperationFactory __m__, Double p, QArray<Double> array)
        {
            return __m__.Run<PNorm, (Double,QArray<Double>), Double>((p, array));
        }
    }

    public class PNormalize : Operation<(Double,QArray<Double>), QArray<Double>>, ICallable
    {
        public PNormalize(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Double,QArray<Double>)>, IApplyData
        {
            public In((Double,QArray<Double>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "PNormalize";
        String ICallable.FullName => "Microsoft.Quantum.Canon.PNormalize";
        protected ICallable<(Double,QArray<Double>), Double> PNorm
        {
            get;
            set;
        }

        public override Func<(Double,QArray<Double>), QArray<Double>> Body => (__in) =>
        {
            var (p,array) = __in;
#line 392 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
            var nElements = array.Count;
#line 393 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
            var norm = PNorm.Apply((p, array));
#line 394 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
            if ((norm == 0D))
            {
#line 395 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
                return array;
            }
            else
            {
#line 398 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
                var output = new QArray<Double>(nElements);
#line 399 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
                foreach (var idx in new Range(0L, (nElements - 1L)))
                {
#line 400 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
                    output[idx] = (array[idx] / norm);
                }

#line 402 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Functions.qs"
                return output;
            }
        }

        ;
        public override void Init()
        {
            this.PNorm = this.Factory.Get<ICallable<(Double,QArray<Double>), Double>>(typeof(Microsoft.Quantum.Canon.PNorm));
        }

        public override IApplyData __dataIn((Double,QArray<Double>) data) => new In(data);
        public override IApplyData __dataOut(QArray<Double> data) => data;
        public static System.Threading.Tasks.Task<QArray<Double>> Run(IOperationFactory __m__, Double p, QArray<Double> array)
        {
            return __m__.Run<PNormalize, (Double,QArray<Double>), QArray<Double>>((p, array));
        }
    }
}