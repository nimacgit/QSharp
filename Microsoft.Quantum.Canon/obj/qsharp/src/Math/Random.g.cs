#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "RandomIntPow2 (maxBits : Int) : Int", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Random.qs", 1285L, 33L, 2L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "RandomInt (maxInt : Int) : Int", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Random.qs", 2336L, 67L, 2L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "RandomReal (bitsRandom : Int) : Double", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Random.qs", 3222L, 98L, 51L)]
#line hidden
namespace Microsoft.Quantum.Canon
{
    public class RandomIntPow2 : Operation<Int64, Int64>, ICallable
    {
        public RandomIntPow2(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "RandomIntPow2";
        String ICallable.FullName => "Microsoft.Quantum.Canon.RandomIntPow2";
        protected ICallable<QArray<Double>, Int64> Random
        {
            get;
            set;
        }

        public override Func<Int64, Int64> Body => (__in) =>
        {
            var maxBits = __in;
#line 35 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Random.qs"
            var number = 0L;
#line 36 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Random.qs"
            foreach (var idxBit in new Range(0L, (maxBits - 1L)))
            {
#line 37 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Random.qs"
                var bit = Random.Apply(new QArray<Double>(0.5D, 0.5D));
#line 38 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Random.qs"
                number = (number + (bit * 2L.Pow(idxBit)));
            }

#line 40 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Random.qs"
            return number;
        }

        ;
        public override void Init()
        {
            this.Random = this.Factory.Get<ICallable<QArray<Double>, Int64>>(typeof(Microsoft.Quantum.Primitive.Random));
        }

        public override IApplyData __dataIn(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Int64 maxBits)
        {
            return __m__.Run<RandomIntPow2, Int64, Int64>(maxBits);
        }
    }

    public class RandomInt : Operation<Int64, Int64>, ICallable
    {
        public RandomInt(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "RandomInt";
        String ICallable.FullName => "Microsoft.Quantum.Canon.RandomInt";
        protected ICallable<Double, Int64> MicrosoftQuantumExtensionsMathCeiling
        {
            get;
            set;
        }

        protected ICallable<Double, Double> Lg
        {
            get;
            set;
        }

        protected ICallable<Int64, Int64> RandomIntPow2
        {
            get;
            set;
        }

        protected ICallable<Int64, Double> MicrosoftQuantumExtensionsConvertToDouble
        {
            get;
            set;
        }

        public override Func<Int64, Int64> Body => (__in) =>
        {
            var maxInt = __in;
#line 69 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Random.qs"
            var nBits = 0L;
#line 70 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Random.qs"
            var output = 0L;
#line 71 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Random.qs"
            nBits = MicrosoftQuantumExtensionsMathCeiling.Apply(Lg.Apply(MicrosoftQuantumExtensionsConvertToDouble.Apply(maxInt)));
#line 73 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Random.qs"
            while (true)
            {
#line 74 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Random.qs"
                output = RandomIntPow2.Apply(nBits);
                if ((output < maxInt))
                {
                    break;
                }
                else
                {
                }
            }

#line 77 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Random.qs"
            return output;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumExtensionsMathCeiling = this.Factory.Get<ICallable<Double, Int64>>(typeof(Microsoft.Quantum.Extensions.Math.Ceiling));
            this.Lg = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Canon.Lg));
            this.RandomIntPow2 = this.Factory.Get<ICallable<Int64, Int64>>(typeof(Microsoft.Quantum.Canon.RandomIntPow2));
            this.MicrosoftQuantumExtensionsConvertToDouble = this.Factory.Get<ICallable<Int64, Double>>(typeof(Microsoft.Quantum.Extensions.Convert.ToDouble));
        }

        public override IApplyData __dataIn(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Int64 maxInt)
        {
            return __m__.Run<RandomInt, Int64, Int64>(maxInt);
        }
    }

    public class RandomReal : Operation<Int64, Double>, ICallable
    {
        public RandomReal(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "RandomReal";
        String ICallable.FullName => "Microsoft.Quantum.Canon.RandomReal";
        protected ICallable<Int64, Int64> RandomIntPow2
        {
            get;
            set;
        }

        protected ICallable<Int64, Double> MicrosoftQuantumExtensionsConvertToDouble
        {
            get;
            set;
        }

        public override Func<Int64, Double> Body => (__in) =>
        {
            var bitsRandom = __in;
#line 100 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Random.qs"
            if ((bitsRandom < 1L))
            {
#line 101 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Random.qs"
                throw new ExecutionFailException("Number of random bits must be greater than 0.");
            }

#line 103 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Random.qs"
            return (MicrosoftQuantumExtensionsConvertToDouble.Apply(RandomIntPow2.Apply(bitsRandom)) / MicrosoftQuantumExtensionsConvertToDouble.Apply(2L.Pow((bitsRandom - 1L))));
        }

        ;
        public override void Init()
        {
            this.RandomIntPow2 = this.Factory.Get<ICallable<Int64, Int64>>(typeof(Microsoft.Quantum.Canon.RandomIntPow2));
            this.MicrosoftQuantumExtensionsConvertToDouble = this.Factory.Get<ICallable<Int64, Double>>(typeof(Microsoft.Quantum.Extensions.Convert.ToDouble));
        }

        public override IApplyData __dataIn(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __dataOut(Double data) => new QTuple<Double>(data);
        public static System.Threading.Tasks.Task<Double> Run(IOperationFactory __m__, Int64 bitsRandom)
        {
            return __m__.Run<RandomReal, Int64, Double>(bitsRandom);
        }
    }
}