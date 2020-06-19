#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "LogOf2 () : Double", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Constants.qs", 345L, 13L, 11L)]
#line hidden
namespace Microsoft.Quantum.Canon
{
    public class LogOf2 : Operation<QVoid, Double>, ICallable
    {
        public LogOf2(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "LogOf2";
        String ICallable.FullName => "Microsoft.Quantum.Canon.LogOf2";
        public override Func<QVoid, Double> Body => (__in) =>
        {
#line 14 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Math\\Constants.qs"
            return 0.69314718055994529D;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(Double data) => new QTuple<Double>(data);
        public static System.Threading.Tasks.Task<Double> Run(IOperationFactory __m__)
        {
            return __m__.Run<LogOf2, QVoid, Double>(QVoid.Instance);
        }
    }
}