#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: UdtDeclaration("Microsoft.Quantum.Canon", "ComplexPolar", "(Double, Double)", "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Complex.qs", 550L, 19L, 49L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "AbsSquaredComplex (input : Microsoft.Quantum.Extensions.Math.Complex) : Double", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Complex.qs", 885L, 32L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "AbsComplex (input : Microsoft.Quantum.Extensions.Math.Complex) : Double", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Complex.qs", 1308L, 47L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "ArgComplex (input : Microsoft.Quantum.Extensions.Math.Complex) : Double", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Complex.qs", 1688L, 61L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "AbsSquaredComplexPolar (input : Microsoft.Quantum.Canon.ComplexPolar) : Double", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Complex.qs", 2105L, 76L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "AbsComplexPolar (input : Microsoft.Quantum.Canon.ComplexPolar) : Double", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Complex.qs", 2497L, 91L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "ArgComplexPolar (input : Microsoft.Quantum.Canon.ComplexPolar) : Double", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Complex.qs", 2868L, 106L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "ComplexPolarToComplex (input : Microsoft.Quantum.Canon.ComplexPolar) : Microsoft.Quantum.Extensions.Math.Complex", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Complex.qs", 3270L, 121L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "ComplexToComplexPolar (input : Microsoft.Quantum.Extensions.Math.Complex) : Microsoft.Quantum.Canon.ComplexPolar", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Complex.qs", 3714L, 136L, 14L)]
#line hidden
namespace Microsoft.Quantum.Canon
{
    public class ComplexPolar : QTuple<(Double,Double)>, IApplyData
    {
        public ComplexPolar() : base(default((Double,Double)))
        {
        }

        public ComplexPolar((Double,Double) data) : base(data)
        {
        }

        public ComplexPolar(QTuple<(Double,Double)> b) : base(b.Data)
        {
        }

        public Double Item1 => Data.Item1;
        public Double Item2 => Data.Item2;
        System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        public void Deconstruct(out Double item1, out Double item2)
        {
            item1 = Data.Item1;
            item2 = Data.Item2;
        }
    }

    public class AbsSquaredComplex : Operation<Microsoft.Quantum.Extensions.Math.Complex, Double>, ICallable
    {
        public AbsSquaredComplex(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "AbsSquaredComplex";
        String ICallable.FullName => "Microsoft.Quantum.Canon.AbsSquaredComplex";
        public override Func<Microsoft.Quantum.Extensions.Math.Complex, Double> Body => (__in) =>
        {
            var input = __in;
#line 33 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Complex.qs"
            var (real,imaginary) = input;
#line 34 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Complex.qs"
            return ((real * real) + (imaginary * imaginary));
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(Microsoft.Quantum.Extensions.Math.Complex data) => data;
        public override IApplyData __dataOut(Double data) => new QTuple<Double>(data);
        public static System.Threading.Tasks.Task<Double> Run(IOperationFactory __m__, Microsoft.Quantum.Extensions.Math.Complex input)
        {
            return __m__.Run<AbsSquaredComplex, Microsoft.Quantum.Extensions.Math.Complex, Double>(input);
        }
    }

    public class AbsComplex : Operation<Microsoft.Quantum.Extensions.Math.Complex, Double>, ICallable
    {
        public AbsComplex(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "AbsComplex";
        String ICallable.FullName => "Microsoft.Quantum.Canon.AbsComplex";
        protected ICallable<Microsoft.Quantum.Extensions.Math.Complex, Double> AbsSquaredComplex
        {
            get;
            set;
        }

        protected ICallable<Double, Double> MicrosoftQuantumExtensionsMathSqrt
        {
            get;
            set;
        }

        public override Func<Microsoft.Quantum.Extensions.Math.Complex, Double> Body => (__in) =>
        {
            var input = __in;
#line 48 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Complex.qs"
            return MicrosoftQuantumExtensionsMathSqrt.Apply(AbsSquaredComplex.Apply(input));
        }

        ;
        public override void Init()
        {
            this.AbsSquaredComplex = this.Factory.Get<ICallable<Microsoft.Quantum.Extensions.Math.Complex, Double>>(typeof(Microsoft.Quantum.Canon.AbsSquaredComplex));
            this.MicrosoftQuantumExtensionsMathSqrt = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Extensions.Math.Sqrt));
        }

        public override IApplyData __dataIn(Microsoft.Quantum.Extensions.Math.Complex data) => data;
        public override IApplyData __dataOut(Double data) => new QTuple<Double>(data);
        public static System.Threading.Tasks.Task<Double> Run(IOperationFactory __m__, Microsoft.Quantum.Extensions.Math.Complex input)
        {
            return __m__.Run<AbsComplex, Microsoft.Quantum.Extensions.Math.Complex, Double>(input);
        }
    }

    public class ArgComplex : Operation<Microsoft.Quantum.Extensions.Math.Complex, Double>, ICallable
    {
        public ArgComplex(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ArgComplex";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ArgComplex";
        protected ICallable<(Double,Double), Double> MicrosoftQuantumExtensionsMathArcTan2
        {
            get;
            set;
        }

        public override Func<Microsoft.Quantum.Extensions.Math.Complex, Double> Body => (__in) =>
        {
            var input = __in;
#line 62 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Complex.qs"
            var (real,imaginary) = input;
#line 63 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Complex.qs"
            return MicrosoftQuantumExtensionsMathArcTan2.Apply((imaginary, real));
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumExtensionsMathArcTan2 = this.Factory.Get<ICallable<(Double,Double), Double>>(typeof(Microsoft.Quantum.Extensions.Math.ArcTan2));
        }

        public override IApplyData __dataIn(Microsoft.Quantum.Extensions.Math.Complex data) => data;
        public override IApplyData __dataOut(Double data) => new QTuple<Double>(data);
        public static System.Threading.Tasks.Task<Double> Run(IOperationFactory __m__, Microsoft.Quantum.Extensions.Math.Complex input)
        {
            return __m__.Run<ArgComplex, Microsoft.Quantum.Extensions.Math.Complex, Double>(input);
        }
    }

    public class AbsSquaredComplexPolar : Operation<ComplexPolar, Double>, ICallable
    {
        public AbsSquaredComplexPolar(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "AbsSquaredComplexPolar";
        String ICallable.FullName => "Microsoft.Quantum.Canon.AbsSquaredComplexPolar";
        public override Func<ComplexPolar, Double> Body => (__in) =>
        {
            var input = __in;
#line 77 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Complex.qs"
            var (abs,arg) = input;
#line 78 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Complex.qs"
            return (abs * abs);
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(ComplexPolar data) => data;
        public override IApplyData __dataOut(Double data) => new QTuple<Double>(data);
        public static System.Threading.Tasks.Task<Double> Run(IOperationFactory __m__, ComplexPolar input)
        {
            return __m__.Run<AbsSquaredComplexPolar, ComplexPolar, Double>(input);
        }
    }

    public class AbsComplexPolar : Operation<ComplexPolar, Double>, ICallable
    {
        public AbsComplexPolar(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "AbsComplexPolar";
        String ICallable.FullName => "Microsoft.Quantum.Canon.AbsComplexPolar";
        public override Func<ComplexPolar, Double> Body => (__in) =>
        {
            var input = __in;
#line 92 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Complex.qs"
            var (abs,arg) = input;
#line 93 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Complex.qs"
            return abs;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(ComplexPolar data) => data;
        public override IApplyData __dataOut(Double data) => new QTuple<Double>(data);
        public static System.Threading.Tasks.Task<Double> Run(IOperationFactory __m__, ComplexPolar input)
        {
            return __m__.Run<AbsComplexPolar, ComplexPolar, Double>(input);
        }
    }

    public class ArgComplexPolar : Operation<ComplexPolar, Double>, ICallable
    {
        public ArgComplexPolar(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ArgComplexPolar";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ArgComplexPolar";
        public override Func<ComplexPolar, Double> Body => (__in) =>
        {
            var input = __in;
#line 107 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Complex.qs"
            var (abs,arg) = input;
#line 108 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Complex.qs"
            return arg;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(ComplexPolar data) => data;
        public override IApplyData __dataOut(Double data) => new QTuple<Double>(data);
        public static System.Threading.Tasks.Task<Double> Run(IOperationFactory __m__, ComplexPolar input)
        {
            return __m__.Run<ArgComplexPolar, ComplexPolar, Double>(input);
        }
    }

    public class ComplexPolarToComplex : Operation<ComplexPolar, Microsoft.Quantum.Extensions.Math.Complex>, ICallable
    {
        public ComplexPolarToComplex(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ComplexPolarToComplex";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ComplexPolarToComplex";
        protected ICallable<Double, Double> MicrosoftQuantumExtensionsMathCos
        {
            get;
            set;
        }

        protected ICallable<Double, Double> MicrosoftQuantumExtensionsMathSin
        {
            get;
            set;
        }

        public override Func<ComplexPolar, Microsoft.Quantum.Extensions.Math.Complex> Body => (__in) =>
        {
            var input = __in;
#line 122 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Complex.qs"
            var (abs,arg) = input;
#line 123 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Complex.qs"
            return new Microsoft.Quantum.Extensions.Math.Complex(((abs * MicrosoftQuantumExtensionsMathCos.Apply(arg)), (abs * MicrosoftQuantumExtensionsMathSin.Apply(arg))));
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumExtensionsMathCos = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Extensions.Math.Cos));
            this.MicrosoftQuantumExtensionsMathSin = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Extensions.Math.Sin));
        }

        public override IApplyData __dataIn(ComplexPolar data) => data;
        public override IApplyData __dataOut(Microsoft.Quantum.Extensions.Math.Complex data) => data;
        public static System.Threading.Tasks.Task<Microsoft.Quantum.Extensions.Math.Complex> Run(IOperationFactory __m__, ComplexPolar input)
        {
            return __m__.Run<ComplexPolarToComplex, ComplexPolar, Microsoft.Quantum.Extensions.Math.Complex>(input);
        }
    }

    public class ComplexToComplexPolar : Operation<Microsoft.Quantum.Extensions.Math.Complex, ComplexPolar>, ICallable
    {
        public ComplexToComplexPolar(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ComplexToComplexPolar";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ComplexToComplexPolar";
        protected ICallable<Microsoft.Quantum.Extensions.Math.Complex, Double> AbsComplex
        {
            get;
            set;
        }

        protected ICallable<Microsoft.Quantum.Extensions.Math.Complex, Double> ArgComplex
        {
            get;
            set;
        }

        public override Func<Microsoft.Quantum.Extensions.Math.Complex, ComplexPolar> Body => (__in) =>
        {
            var input = __in;
#line 137 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Complex.qs"
            return new ComplexPolar((AbsComplex.Apply(input), ArgComplex.Apply(input)));
        }

        ;
        public override void Init()
        {
            this.AbsComplex = this.Factory.Get<ICallable<Microsoft.Quantum.Extensions.Math.Complex, Double>>(typeof(Microsoft.Quantum.Canon.AbsComplex));
            this.ArgComplex = this.Factory.Get<ICallable<Microsoft.Quantum.Extensions.Math.Complex, Double>>(typeof(Microsoft.Quantum.Canon.ArgComplex));
        }

        public override IApplyData __dataIn(Microsoft.Quantum.Extensions.Math.Complex data) => data;
        public override IApplyData __dataOut(ComplexPolar data) => data;
        public static System.Threading.Tasks.Task<ComplexPolar> Run(IOperationFactory __m__, Microsoft.Quantum.Extensions.Math.Complex input)
        {
            return __m__.Run<ComplexToComplexPolar, Microsoft.Quantum.Extensions.Math.Complex, ComplexPolar>(input);
        }
    }
}