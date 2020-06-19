#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: UdtDeclaration("Microsoft.Quantum.Canon", "DiscreteOracle", "((Int, Qubit[]) => () : Adjoint, Controlled)", "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\PhaseEstimation\\Types.qs", 274L, 9L, 40L)]
[assembly: UdtDeclaration("Microsoft.Quantum.Canon", "ContinuousOracle", "((Double, Qubit[]) => () : Adjoint, Controlled)", "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\PhaseEstimation\\Types.qs", 609L, 16L, 54L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "OracleToDiscrete (blackBoxOracle : (Qubit[] => () : Adjoint, Controlled)) : Microsoft.Quantum.Canon.DiscreteOracle", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\PhaseEstimation\\Types.qs", 1339L, 33L, 5L)]
#line hidden
namespace Microsoft.Quantum.Canon
{
    public class DiscreteOracle : OperationUdt<(Int64,QArray<Qubit>),QVoid>, ICallable, IApplyData
    {
        public DiscreteOracle() : base(default(IUnitary))
        {
        }

        public DiscreteOracle(IUnitary data) : base(data)
        {
        }

        public DiscreteOracle(OperationUdt<(Int64,QArray<Qubit>),QVoid> b) : base(b.Data)
        {
        }

        String ICallable.Name => "DiscreteOracle";
        String ICallable.FullName => "Microsoft.Quantum.Canon.DiscreteOracle";
    }

    public class ContinuousOracle : OperationUdt<(Double,QArray<Qubit>),QVoid>, ICallable, IApplyData
    {
        public ContinuousOracle() : base(default(IUnitary))
        {
        }

        public ContinuousOracle(IUnitary data) : base(data)
        {
        }

        public ContinuousOracle(OperationUdt<(Double,QArray<Qubit>),QVoid> b) : base(b.Data)
        {
        }

        String ICallable.Name => "ContinuousOracle";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ContinuousOracle";
    }

    public class OracleToDiscrete : Operation<IUnitary, IUnitary>, ICallable
    {
        public OracleToDiscrete(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "OracleToDiscrete";
        String ICallable.FullName => "Microsoft.Quantum.Canon.OracleToDiscrete";
        protected IUnitary OperationPowImplCA
        {
            get;
            set;
        }

        public override Func<IUnitary, IUnitary> Body => (__in) =>
        {
            var blackBoxOracle = __in;
#line 35 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\PhaseEstimation\\Types.qs"
            var oracle = new DiscreteOracle(OperationPowImplCA.Partial((((IUnitary)blackBoxOracle), _, _)));
#line 36 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\PhaseEstimation\\Types.qs"
            return oracle;
        }

        ;
        public override void Init()
        {
            this.OperationPowImplCA = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.OperationPowImplCA<>));
        }

        public override IApplyData __dataIn(IUnitary data) => new QTuple<IUnitary>(data);
        public override IApplyData __dataOut(IUnitary data) => new QTuple<IUnitary>(data);
        public static System.Threading.Tasks.Task<IUnitary> Run(IOperationFactory __m__, IUnitary blackBoxOracle)
        {
            return __m__.Run<OracleToDiscrete, IUnitary, IUnitary>(blackBoxOracle);
        }
    }
}