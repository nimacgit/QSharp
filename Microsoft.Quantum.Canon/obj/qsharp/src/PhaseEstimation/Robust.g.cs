#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "RobustPhaseEstimation (bitsPrecision : Int, oracle : Microsoft.Quantum.Canon.DiscreteOracle, targetState : Qubit[]) : Double", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\PhaseEstimation\\Robust.qs", 1663L, 35L, 5L)]
#line hidden
namespace Microsoft.Quantum.Canon
{
    public class RobustPhaseEstimation : Operation<(Int64,IUnitary,QArray<Qubit>), Double>, ICallable
    {
        public RobustPhaseEstimation(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,IUnitary,QArray<Qubit>)>, IApplyData
        {
            public In((Int64,IUnitary,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "RobustPhaseEstimation";
        String ICallable.FullName => "Microsoft.Quantum.Canon.RobustPhaseEstimation";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected ICallable<(Double,Double), Double> MicrosoftQuantumExtensionsMathArcTan2
        {
            get;
            set;
        }

        protected ICallable<Double, Int64> MicrosoftQuantumExtensionsMathCeiling
        {
            get;
            set;
        }

        protected IUnitary<(IUnitary,Int64,Double,QArray<Qubit>,Qubit)> DiscretePhaseEstimationIteration
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> M
        {
            get;
            set;
        }

        protected ICallable<QVoid, Double> MicrosoftQuantumExtensionsMathPI
        {
            get;
            set;
        }

        protected ICallable<(Double,Double,Double), Double> RealMod
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<Qubit, QVoid> Reset
        {
            get;
            set;
        }

        protected ICallable<Int64, Double> MicrosoftQuantumExtensionsConvertToDouble
        {
            get;
            set;
        }

        public override Func<(Int64,IUnitary,QArray<Qubit>), Double> Body => (__in) =>
        {
            var (bitsPrecision,oracle,targetState) = __in;
#line 37 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\PhaseEstimation\\Robust.qs"
            var alpha = 2.5D;
#line 38 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\PhaseEstimation\\Robust.qs"
            var beta = 0.5D;
#line 39 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\PhaseEstimation\\Robust.qs"
            var thetaEst = MicrosoftQuantumExtensionsConvertToDouble.Apply(0L);
#line 41 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\PhaseEstimation\\Robust.qs"
            var qubitAncilla = Allocate.Apply(1L);
#line 42 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\PhaseEstimation\\Robust.qs"
            var q = qubitAncilla[0L];
#line 44 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\PhaseEstimation\\Robust.qs"
            foreach (var exponent in new Range(0L, (bitsPrecision - 1L)))
            {
#line 46 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\PhaseEstimation\\Robust.qs"
                var power = 2L.Pow(exponent);
#line 47 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\PhaseEstimation\\Robust.qs"
                var nRepeats = MicrosoftQuantumExtensionsMathCeiling.Apply(((alpha * MicrosoftQuantumExtensionsConvertToDouble.Apply((bitsPrecision - exponent))) + beta));
#line 48 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\PhaseEstimation\\Robust.qs"
                if (((nRepeats % 2L) == 1L))
                {
                    // Ensures that nRepeats is even.
#line 50 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\PhaseEstimation\\Robust.qs"
                    nRepeats = (nRepeats + 1L);
                }

#line 53 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\PhaseEstimation\\Robust.qs"
                var pZero = MicrosoftQuantumExtensionsConvertToDouble.Apply(0L);
#line 54 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\PhaseEstimation\\Robust.qs"
                var pPlus = MicrosoftQuantumExtensionsConvertToDouble.Apply(0L);
#line 56 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\PhaseEstimation\\Robust.qs"
                foreach (var idxRep in new Range(0L, (nRepeats - 1L)))
                {
#line 57 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\PhaseEstimation\\Robust.qs"
                    foreach (var idxExperiment in new Range(0L, 1L))
                    {
                        // Divide rotation by power to cancel the multiplication by power in DiscretePhaseEstimationIteration
#line 59 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\PhaseEstimation\\Robust.qs"
                        var rotation = (((MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance) * MicrosoftQuantumExtensionsConvertToDouble.Apply(idxExperiment)) / 2D) / MicrosoftQuantumExtensionsConvertToDouble.Apply(power));
#line 60 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\PhaseEstimation\\Robust.qs"
                        DiscretePhaseEstimationIteration.Apply((oracle, power, rotation, targetState, q));
#line 61 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\PhaseEstimation\\Robust.qs"
                        var result = M.Apply(q);
#line 63 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\PhaseEstimation\\Robust.qs"
                        if ((result == Result.Zero))
                        {
#line 64 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\PhaseEstimation\\Robust.qs"
                            if ((idxExperiment == 0L))
                            {
#line 65 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\PhaseEstimation\\Robust.qs"
                                pZero = (pZero + 1D);
                            }
                            else if ((idxExperiment == 1L))
                            {
#line 68 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\PhaseEstimation\\Robust.qs"
                                pPlus = (pPlus + 1D);
                            }
                        }

#line 71 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\PhaseEstimation\\Robust.qs"
                        Reset.Apply(q);
                    }
                }

#line 74 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\PhaseEstimation\\Robust.qs"
                var deltaTheta = MicrosoftQuantumExtensionsMathArcTan2.Apply(((pPlus - (MicrosoftQuantumExtensionsConvertToDouble.Apply(nRepeats) / 2D)), (pZero - (MicrosoftQuantumExtensionsConvertToDouble.Apply(nRepeats) / 2D))));
#line 75 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\PhaseEstimation\\Robust.qs"
                var delta = RealMod.Apply(((deltaTheta - (thetaEst * MicrosoftQuantumExtensionsConvertToDouble.Apply(power))), (2D * MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance)), -(MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance))));
#line 76 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\PhaseEstimation\\Robust.qs"
                thetaEst = (thetaEst + (delta / MicrosoftQuantumExtensionsConvertToDouble.Apply(power)));
            }

#line 78 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\PhaseEstimation\\Robust.qs"
            Reset.Apply(q);
#line hidden
            Release.Apply(qubitAncilla);
#line 80 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\PhaseEstimation\\Robust.qs"
            return thetaEst;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumExtensionsMathArcTan2 = this.Factory.Get<ICallable<(Double,Double), Double>>(typeof(Microsoft.Quantum.Extensions.Math.ArcTan2));
            this.MicrosoftQuantumExtensionsMathCeiling = this.Factory.Get<ICallable<Double, Int64>>(typeof(Microsoft.Quantum.Extensions.Math.Ceiling));
            this.DiscretePhaseEstimationIteration = this.Factory.Get<IUnitary<(IUnitary,Int64,Double,QArray<Qubit>,Qubit)>>(typeof(Microsoft.Quantum.Canon.DiscretePhaseEstimationIteration));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.MicrosoftQuantumExtensionsMathPI = this.Factory.Get<ICallable<QVoid, Double>>(typeof(Microsoft.Quantum.Extensions.Math.PI));
            this.RealMod = this.Factory.Get<ICallable<(Double,Double,Double), Double>>(typeof(Microsoft.Quantum.Canon.RealMod));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.Reset = this.Factory.Get<ICallable<Qubit, QVoid>>(typeof(Microsoft.Quantum.Primitive.Reset));
            this.MicrosoftQuantumExtensionsConvertToDouble = this.Factory.Get<ICallable<Int64, Double>>(typeof(Microsoft.Quantum.Extensions.Convert.ToDouble));
        }

        public override IApplyData __dataIn((Int64,IUnitary,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(Double data) => new QTuple<Double>(data);
        public static System.Threading.Tasks.Task<Double> Run(IOperationFactory __m__, Int64 bitsPrecision, IUnitary oracle, QArray<Qubit> targetState)
        {
            return __m__.Run<RobustPhaseEstimation, (Int64,IUnitary,QArray<Qubit>), Double>((bitsPrecision, oracle, targetState));
        }
    }
}