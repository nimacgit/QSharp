#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "AmpAmpObliviousByReflectionPhasesImpl (phases : Microsoft.Quantum.Canon.AmpAmpReflectionPhases, ancillaReflection : Microsoft.Quantum.Canon.ReflectionOracle, targetStateReflection : Microsoft.Quantum.Canon.ReflectionOracle, signalOracle : Microsoft.Quantum.Canon.ObliviousOracle, ancillaRegister : Qubit[], systemRegister : Qubit[]) : ()", new string[] { "Controlled", "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs", 9836L, 227L, 5L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "AmpAmpRUSByOracle (statePrepOracle : Microsoft.Quantum.Canon.StateOracle, startQubits : Qubit[]) : ()", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs", 18527L, 418L, 5L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "AmpAmpRotationToReflectionPhases (rotPhases : Microsoft.Quantum.Canon.AmpAmpRotationPhases) : Microsoft.Quantum.Canon.AmpAmpReflectionPhases", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs", 3902L, 88L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "AmpAmpPhasesStandard (nIterations : Int) : Microsoft.Quantum.Canon.AmpAmpReflectionPhases", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs", 5538L, 129L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "AmpAmpPhasesFixedPoint (nQueries : Int, successMin : Double) : Microsoft.Quantum.Canon.AmpAmpReflectionPhases", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs", 7186L, 171L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "AmpAmpObliviousByReflectionPhases (phases : Microsoft.Quantum.Canon.AmpAmpReflectionPhases, ancillaReflection : Microsoft.Quantum.Canon.ReflectionOracle, targetStateReflection : Microsoft.Quantum.Canon.ReflectionOracle, signalOracle : Microsoft.Quantum.Canon.ObliviousOracle) : ((Qubit[], Qubit[]) => () : Adjoint, Controlled)", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs", 11239L, 265L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "AmpAmpObliviousByOraclePhases (phases : Microsoft.Quantum.Canon.AmpAmpReflectionPhases, ancillaOracle : Microsoft.Quantum.Canon.DeterministicStateOracle, signalOracle : Microsoft.Quantum.Canon.ObliviousOracle, idxFlagQubit : Int) : ((Qubit[], Qubit[]) => () : Adjoint, Controlled)", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs", 12920L, 295L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "AmpAmpByReflectionsPhases (phases : Microsoft.Quantum.Canon.AmpAmpReflectionPhases, startStateReflection : Microsoft.Quantum.Canon.ReflectionOracle, targetStateReflection : Microsoft.Quantum.Canon.ReflectionOracle) : (Qubit[] => () : Adjoint, Controlled)", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs", 14344L, 323L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "AmpAmpByOraclePhases (phases : Microsoft.Quantum.Canon.AmpAmpReflectionPhases, stateOracle : Microsoft.Quantum.Canon.StateOracle, idxFlagQubit : Int) : (Qubit[] => () : Adjoint, Controlled)", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs", 15887L, 359L, 14L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "AmpAmpByOracle (nIterations : Int, stateOracle : Microsoft.Quantum.Canon.StateOracle, idxFlagQubit : Int) : (Qubit[] => () : Adjoint, Controlled)", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs", 17680L, 399L, 14L)]
#line hidden
namespace Microsoft.Quantum.Canon
{
    public class AmpAmpRotationToReflectionPhases : Operation<AmpAmpRotationPhases, AmpAmpReflectionPhases>, ICallable
    {
        public AmpAmpRotationToReflectionPhases(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "AmpAmpRotationToReflectionPhases";
        String ICallable.FullName => "Microsoft.Quantum.Canon.AmpAmpRotationToReflectionPhases";
        protected ICallable<QVoid, Double> MicrosoftQuantumExtensionsMathPI
        {
            get;
            set;
        }

        public override Func<AmpAmpRotationPhases, AmpAmpReflectionPhases> Body => (__in) =>
        {
            var rotPhases = __in;
#line 90 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
            var nPhasesRot = rotPhases.Count;
#line 91 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
            var nPhasesRef = ((nPhasesRot + 1L) / 2L);
#line 93 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
            if (((nPhasesRot % 2L) == 0L))
            {
#line 94 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
                throw new ExecutionFailException("Number of rotations must be odd.");
            }

#line 97 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
            var phasesTarget = new QArray<Double>(nPhasesRef);
#line 98 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
            var phasesStart = new QArray<Double>(nPhasesRef);
#line 100 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
            phasesTarget[0L] = ((rotPhases[0L] - rotPhases[1L]) - MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance));
#line 101 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
            phasesStart[0L] = (-(rotPhases[0L]) + (0.5D * MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance)));
#line 103 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
            foreach (var idxPhases in new Range(1L, (nPhasesRef - 2L)))
            {
#line 104 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
                phasesTarget[idxPhases] = ((rotPhases[(2L * idxPhases)] - rotPhases[((2L * idxPhases) + 1L)]) - MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance));
#line 105 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
                phasesStart[idxPhases] = ((rotPhases[((2L * idxPhases) - 1L)] - rotPhases[(2L * idxPhases)]) + MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance));
            }

#line 108 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
            phasesTarget[(nPhasesRef - 1L)] = (rotPhases[((2L * nPhasesRef) - 2L)] - (0.5D * MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance)));
#line 109 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
            phasesStart[(nPhasesRef - 1L)] = ((rotPhases[((2L * nPhasesRef) - 3L)] - rotPhases[((2L * nPhasesRef) - 2L)]) + MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance));
#line 111 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
            return new AmpAmpReflectionPhases((phasesStart, phasesTarget));
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumExtensionsMathPI = this.Factory.Get<ICallable<QVoid, Double>>(typeof(Microsoft.Quantum.Extensions.Math.PI));
        }

        public override IApplyData __dataIn(AmpAmpRotationPhases data) => data;
        public override IApplyData __dataOut(AmpAmpReflectionPhases data) => data;
        public static System.Threading.Tasks.Task<AmpAmpReflectionPhases> Run(IOperationFactory __m__, AmpAmpRotationPhases rotPhases)
        {
            return __m__.Run<AmpAmpRotationToReflectionPhases, AmpAmpRotationPhases, AmpAmpReflectionPhases>(rotPhases);
        }
    }

    public class AmpAmpPhasesStandard : Operation<Int64, AmpAmpReflectionPhases>, ICallable
    {
        public AmpAmpPhasesStandard(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "AmpAmpPhasesStandard";
        String ICallable.FullName => "Microsoft.Quantum.Canon.AmpAmpPhasesStandard";
        protected ICallable<QVoid, Double> MicrosoftQuantumExtensionsMathPI
        {
            get;
            set;
        }

        public override Func<Int64, AmpAmpReflectionPhases> Body => (__in) =>
        {
            var nIterations = __in;
#line 130 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
            var phasesTarget = new QArray<Double>((nIterations + 1L));
#line 131 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
            var phasesStart = new QArray<Double>((nIterations + 1L));
#line 134 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
            foreach (var idxPhases in new Range(0L, nIterations))
            {
#line 135 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
                phasesTarget[idxPhases] = MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance);
#line 136 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
                phasesStart[idxPhases] = MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance);
            }

#line 138 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
            phasesTarget[nIterations] = 0D;
#line 139 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
            phasesStart[0L] = 0D;
#line 141 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
            return new AmpAmpReflectionPhases((phasesStart, phasesTarget));
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumExtensionsMathPI = this.Factory.Get<ICallable<QVoid, Double>>(typeof(Microsoft.Quantum.Extensions.Math.PI));
        }

        public override IApplyData __dataIn(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __dataOut(AmpAmpReflectionPhases data) => data;
        public static System.Threading.Tasks.Task<AmpAmpReflectionPhases> Run(IOperationFactory __m__, Int64 nIterations)
        {
            return __m__.Run<AmpAmpPhasesStandard, Int64, AmpAmpReflectionPhases>(nIterations);
        }
    }

    public class AmpAmpPhasesFixedPoint : Operation<(Int64,Double), AmpAmpReflectionPhases>, ICallable
    {
        public AmpAmpPhasesFixedPoint(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Double)>, IApplyData
        {
            public In((Int64,Double) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "AmpAmpPhasesFixedPoint";
        String ICallable.FullName => "Microsoft.Quantum.Canon.AmpAmpPhasesFixedPoint";
        protected ICallable<AmpAmpRotationPhases, AmpAmpReflectionPhases> AmpAmpRotationToReflectionPhases
        {
            get;
            set;
        }

        protected ICallable<Double, Double> ArcCosh
        {
            get;
            set;
        }

        protected ICallable<Double, Double> MicrosoftQuantumExtensionsMathArcTan
        {
            get;
            set;
        }

        protected ICallable<Double, Double> MicrosoftQuantumExtensionsMathCosh
        {
            get;
            set;
        }

        protected ICallable<QVoid, Double> MicrosoftQuantumExtensionsMathPI
        {
            get;
            set;
        }

        protected ICallable<Double, Double> MicrosoftQuantumExtensionsMathSqrt
        {
            get;
            set;
        }

        protected ICallable<Double, Double> MicrosoftQuantumExtensionsMathTan
        {
            get;
            set;
        }

        protected ICallable<Int64, Double> MicrosoftQuantumExtensionsConvertToDouble
        {
            get;
            set;
        }

        public override Func<(Int64,Double), AmpAmpReflectionPhases> Body => (__in) =>
        {
            var (nQueries,successMin) = __in;
#line 173 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
            var phasesRot = new QArray<Double>(nQueries);
#line 175 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
            var nQueriesDouble = MicrosoftQuantumExtensionsConvertToDouble.Apply(nQueries);
#line 176 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
            phasesRot[0L] = 0D;
#line 178 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
            var beta = MicrosoftQuantumExtensionsMathCosh.Apply(((1D / nQueriesDouble) * ArcCosh.Apply(MicrosoftQuantumExtensionsMathSqrt.Apply(successMin))));
#line 180 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
            foreach (var idxPhases in new Range(1L, (nQueries - 1L)))
            {
#line 181 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
                phasesRot[idxPhases] = (phasesRot[(idxPhases - 1L)] + (2D * MicrosoftQuantumExtensionsMathArcTan.Apply((MicrosoftQuantumExtensionsMathTan.Apply(((((2D * 1D) * MicrosoftQuantumExtensionsConvertToDouble.Apply(idxPhases)) * MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance)) / nQueriesDouble)) * MicrosoftQuantumExtensionsMathSqrt.Apply((1D - (beta * beta)))))));
            }

#line 184 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
            return AmpAmpRotationToReflectionPhases.Apply(new AmpAmpRotationPhases(phasesRot));
        }

        ;
        public override void Init()
        {
            this.AmpAmpRotationToReflectionPhases = this.Factory.Get<ICallable<AmpAmpRotationPhases, AmpAmpReflectionPhases>>(typeof(Microsoft.Quantum.Canon.AmpAmpRotationToReflectionPhases));
            this.ArcCosh = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Canon.ArcCosh));
            this.MicrosoftQuantumExtensionsMathArcTan = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Extensions.Math.ArcTan));
            this.MicrosoftQuantumExtensionsMathCosh = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Extensions.Math.Cosh));
            this.MicrosoftQuantumExtensionsMathPI = this.Factory.Get<ICallable<QVoid, Double>>(typeof(Microsoft.Quantum.Extensions.Math.PI));
            this.MicrosoftQuantumExtensionsMathSqrt = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Extensions.Math.Sqrt));
            this.MicrosoftQuantumExtensionsMathTan = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Extensions.Math.Tan));
            this.MicrosoftQuantumExtensionsConvertToDouble = this.Factory.Get<ICallable<Int64, Double>>(typeof(Microsoft.Quantum.Extensions.Convert.ToDouble));
        }

        public override IApplyData __dataIn((Int64,Double) data) => new In(data);
        public override IApplyData __dataOut(AmpAmpReflectionPhases data) => data;
        public static System.Threading.Tasks.Task<AmpAmpReflectionPhases> Run(IOperationFactory __m__, Int64 nQueries, Double successMin)
        {
            return __m__.Run<AmpAmpPhasesFixedPoint, (Int64,Double), AmpAmpReflectionPhases>((nQueries, successMin));
        }
    }

    public class AmpAmpObliviousByReflectionPhasesImpl : Unitary<(AmpAmpReflectionPhases,IUnitary,IUnitary,IUnitary,QArray<Qubit>,QArray<Qubit>)>, ICallable
    {
        public AmpAmpObliviousByReflectionPhasesImpl(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(AmpAmpReflectionPhases,IUnitary,IUnitary,IUnitary,QArray<Qubit>,QArray<Qubit>)>, IApplyData
        {
            public In((AmpAmpReflectionPhases,IUnitary,IUnitary,IUnitary,QArray<Qubit>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits, ((IApplyData)Data.Item4)?.Qubits, ((IApplyData)Data.Item5)?.Qubits, ((IApplyData)Data.Item6)?.Qubits);
        }

        String ICallable.Name => "AmpAmpObliviousByReflectionPhasesImpl";
        String ICallable.FullName => "Microsoft.Quantum.Canon.AmpAmpObliviousByReflectionPhasesImpl";
        public override Func<(AmpAmpReflectionPhases,IUnitary,IUnitary,IUnitary,QArray<Qubit>,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (phases,ancillaReflection,targetStateReflection,signalOracle,ancillaRegister,systemRegister) = __in;
#line 229 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
            var (phasesAncilla,phasesTarget) = phases;
#line 230 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
            var nphases = (2L * phasesTarget.Count);
            //FailOn(nphases != Length(phasesAncilla), "Phase array lengths not equal.")
#line 234 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
            if ((phasesAncilla[0L] != 0D))
            {
#line 235 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
                ancillaReflection.Apply((phasesAncilla[0L], ancillaRegister));
            }

#line 238 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
            foreach (var idxPhases in new Range(1L, (nphases - 1L)))
            {
#line 239 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
                var idxPhaseAncilla = (idxPhases / 2L);
#line 240 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
                var idxPhaseTarget = (idxPhases / 2L);
#line 242 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
                if (((idxPhases % 2L) == 1L))
                {
#line 243 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
                    signalOracle.Apply((ancillaRegister, systemRegister));
#line 244 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
                    if ((phasesTarget[idxPhaseTarget] != 0D))
                    {
#line 245 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
                        targetStateReflection.Apply((phasesTarget[idxPhaseTarget], ancillaRegister));
                    }
                }
                else
                {
#line 249 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
                    signalOracle.Adjoint.Apply((ancillaRegister, systemRegister));
#line 250 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
                    if ((phasesAncilla[idxPhaseAncilla] != 0D))
                    {
#line 251 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
                        ancillaReflection.Apply((phasesAncilla[idxPhaseAncilla], ancillaRegister));
                    }
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(AmpAmpReflectionPhases,IUnitary,IUnitary,IUnitary,QArray<Qubit>,QArray<Qubit>), QVoid> AdjointBody => (__in) =>
        {
            var (phases,ancillaReflection,targetStateReflection,signalOracle,ancillaRegister,systemRegister) = __in;
#line 229 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
            var (phasesAncilla,phasesTarget) = phases;
#line 230 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
            var nphases = (2L * phasesTarget.Count);
            //FailOn(nphases != Length(phasesAncilla), "Phase array lengths not equal.")
            foreach (var idxPhases in new Range((1L - ((((nphases - 1L) - 1L) / 1L) * -(1L))), -(1L), 1L))
            {
#line 239 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
                var idxPhaseAncilla = (idxPhases / 2L);
#line 240 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
                var idxPhaseTarget = (idxPhases / 2L);
                if (((idxPhases % 2L) == 1L))
                {
                    if ((phasesTarget[idxPhaseTarget] != 0D))
                    {
                        targetStateReflection.Adjoint.Apply((phasesTarget[idxPhaseTarget], ancillaRegister));
                    }

                    signalOracle.Adjoint.Apply((ancillaRegister, systemRegister));
                }
                else
                {
                    if ((phasesAncilla[idxPhaseAncilla] != 0D))
                    {
                        ancillaReflection.Adjoint.Apply((phasesAncilla[idxPhaseAncilla], ancillaRegister));
                    }

                    signalOracle.Adjoint.Adjoint.Apply((ancillaRegister, systemRegister));
                }
            }

            if ((phasesAncilla[0L] != 0D))
            {
                ancillaReflection.Adjoint.Apply((phasesAncilla[0L], ancillaRegister));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(AmpAmpReflectionPhases,IUnitary,IUnitary,IUnitary,QArray<Qubit>,QArray<Qubit>)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(phases,ancillaReflection,targetStateReflection,signalOracle,ancillaRegister,systemRegister)) = __in;
            var (phasesAncilla,phasesTarget) = phases;
            var nphases = (2L * phasesTarget.Count);
            //FailOn(nphases != Length(phasesAncilla), "Phase array lengths not equal.")
            if ((phasesAncilla[0L] != 0D))
            {
                ancillaReflection.Controlled.Apply((controlQubits, (phasesAncilla[0L], ancillaRegister)));
            }

            foreach (var idxPhases in new Range(1L, (nphases - 1L)))
            {
                var idxPhaseAncilla = (idxPhases / 2L);
                var idxPhaseTarget = (idxPhases / 2L);
                if (((idxPhases % 2L) == 1L))
                {
                    signalOracle.Controlled.Apply((controlQubits, (ancillaRegister, systemRegister)));
                    if ((phasesTarget[idxPhaseTarget] != 0D))
                    {
                        targetStateReflection.Controlled.Apply((controlQubits, (phasesTarget[idxPhaseTarget], ancillaRegister)));
                    }
                }
                else
                {
                    signalOracle.Adjoint.Controlled.Apply((controlQubits, (ancillaRegister, systemRegister)));
                    if ((phasesAncilla[idxPhaseAncilla] != 0D))
                    {
                        ancillaReflection.Controlled.Apply((controlQubits, (phasesAncilla[idxPhaseAncilla], ancillaRegister)));
                    }
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(AmpAmpReflectionPhases,IUnitary,IUnitary,IUnitary,QArray<Qubit>,QArray<Qubit>)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,(phases,ancillaReflection,targetStateReflection,signalOracle,ancillaRegister,systemRegister)) = __in;
            var (phasesAncilla,phasesTarget) = phases;
            var nphases = (2L * phasesTarget.Count);
            //FailOn(nphases != Length(phasesAncilla), "Phase array lengths not equal.")
            foreach (var idxPhases in new Range((1L - ((((nphases - 1L) - 1L) / 1L) * -(1L))), -(1L), 1L))
            {
                var idxPhaseAncilla = (idxPhases / 2L);
                var idxPhaseTarget = (idxPhases / 2L);
                if (((idxPhases % 2L) == 1L))
                {
                    if ((phasesTarget[idxPhaseTarget] != 0D))
                    {
                        targetStateReflection.Adjoint.Controlled.Apply((controlQubits, (phasesTarget[idxPhaseTarget], ancillaRegister)));
                    }

                    signalOracle.Adjoint.Controlled.Apply((controlQubits, (ancillaRegister, systemRegister)));
                }
                else
                {
                    if ((phasesAncilla[idxPhaseAncilla] != 0D))
                    {
                        ancillaReflection.Adjoint.Controlled.Apply((controlQubits, (phasesAncilla[idxPhaseAncilla], ancillaRegister)));
                    }

                    signalOracle.Adjoint.Adjoint.Controlled.Apply((controlQubits, (ancillaRegister, systemRegister)));
                }
            }

            if ((phasesAncilla[0L] != 0D))
            {
                ancillaReflection.Adjoint.Controlled.Apply((controlQubits, (phasesAncilla[0L], ancillaRegister)));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((AmpAmpReflectionPhases,IUnitary,IUnitary,IUnitary,QArray<Qubit>,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, AmpAmpReflectionPhases phases, IUnitary ancillaReflection, IUnitary targetStateReflection, IUnitary signalOracle, QArray<Qubit> ancillaRegister, QArray<Qubit> systemRegister)
        {
            return __m__.Run<AmpAmpObliviousByReflectionPhasesImpl, (AmpAmpReflectionPhases,IUnitary,IUnitary,IUnitary,QArray<Qubit>,QArray<Qubit>), QVoid>((phases, ancillaReflection, targetStateReflection, signalOracle, ancillaRegister, systemRegister));
        }
    }

    public class AmpAmpObliviousByReflectionPhases : Operation<(AmpAmpReflectionPhases,IUnitary,IUnitary,IUnitary), IUnitary>, ICallable
    {
        public AmpAmpObliviousByReflectionPhases(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(AmpAmpReflectionPhases,IUnitary,IUnitary,IUnitary)>, IApplyData
        {
            public In((AmpAmpReflectionPhases,IUnitary,IUnitary,IUnitary) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits, ((IApplyData)Data.Item4)?.Qubits);
        }

        String ICallable.Name => "AmpAmpObliviousByReflectionPhases";
        String ICallable.FullName => "Microsoft.Quantum.Canon.AmpAmpObliviousByReflectionPhases";
        protected IUnitary<(AmpAmpReflectionPhases,IUnitary,IUnitary,IUnitary,QArray<Qubit>,QArray<Qubit>)> AmpAmpObliviousByReflectionPhasesImpl
        {
            get;
            set;
        }

        public override Func<(AmpAmpReflectionPhases,IUnitary,IUnitary,IUnitary), IUnitary> Body => (__in) =>
        {
            var (phases,ancillaReflection,targetStateReflection,signalOracle) = __in;
#line 267 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
            return AmpAmpObliviousByReflectionPhasesImpl.Partial(new Func<(QArray<Qubit>,QArray<Qubit>), (AmpAmpReflectionPhases,IUnitary,IUnitary,IUnitary,QArray<Qubit>,QArray<Qubit>)>((_arg1) => (phases, ancillaReflection, targetStateReflection, signalOracle, _arg1.Item1, _arg1.Item2)));
        }

        ;
        public override void Init()
        {
            this.AmpAmpObliviousByReflectionPhasesImpl = this.Factory.Get<IUnitary<(AmpAmpReflectionPhases,IUnitary,IUnitary,IUnitary,QArray<Qubit>,QArray<Qubit>)>>(typeof(Microsoft.Quantum.Canon.AmpAmpObliviousByReflectionPhasesImpl));
        }

        public override IApplyData __dataIn((AmpAmpReflectionPhases,IUnitary,IUnitary,IUnitary) data) => new In(data);
        public override IApplyData __dataOut(IUnitary data) => new QTuple<IUnitary>(data);
        public static System.Threading.Tasks.Task<IUnitary> Run(IOperationFactory __m__, AmpAmpReflectionPhases phases, IUnitary ancillaReflection, IUnitary targetStateReflection, IUnitary signalOracle)
        {
            return __m__.Run<AmpAmpObliviousByReflectionPhases, (AmpAmpReflectionPhases,IUnitary,IUnitary,IUnitary), IUnitary>((phases, ancillaReflection, targetStateReflection, signalOracle));
        }
    }

    public class AmpAmpObliviousByOraclePhases : Operation<(AmpAmpReflectionPhases,IUnitary,IUnitary,Int64), IUnitary>, ICallable
    {
        public AmpAmpObliviousByOraclePhases(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(AmpAmpReflectionPhases,IUnitary,IUnitary,Int64)>, IApplyData
        {
            public In((AmpAmpReflectionPhases,IUnitary,IUnitary,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "AmpAmpObliviousByOraclePhases";
        String ICallable.FullName => "Microsoft.Quantum.Canon.AmpAmpObliviousByOraclePhases";
        protected ICallable<(AmpAmpReflectionPhases,IUnitary,IUnitary,IUnitary), IUnitary> AmpAmpObliviousByReflectionPhases
        {
            get;
            set;
        }

        protected ICallable<(IUnitary,IUnitary), IUnitary> ObliviousOracleFromDeterministicStateOracle
        {
            get;
            set;
        }

        protected ICallable<QVoid, IUnitary> ReflectionStart
        {
            get;
            set;
        }

        protected ICallable<Int64, IUnitary> TargetStateReflectionOracle
        {
            get;
            set;
        }

        public override Func<(AmpAmpReflectionPhases,IUnitary,IUnitary,Int64), IUnitary> Body => (__in) =>
        {
            var (phases,ancillaOracle,signalOracle,idxFlagQubit) = __in;
#line 297 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
            var ancillaReflection = ReflectionStart.Apply(QVoid.Instance);
#line 298 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
            var targetStateReflection = TargetStateReflectionOracle.Apply(idxFlagQubit);
#line 299 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
            var oracleObliviousNew = ObliviousOracleFromDeterministicStateOracle.Apply((ancillaOracle, signalOracle));
#line 301 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
            return AmpAmpObliviousByReflectionPhases.Apply((phases, ancillaReflection, targetStateReflection, oracleObliviousNew));
        }

        ;
        public override void Init()
        {
            this.AmpAmpObliviousByReflectionPhases = this.Factory.Get<ICallable<(AmpAmpReflectionPhases,IUnitary,IUnitary,IUnitary), IUnitary>>(typeof(Microsoft.Quantum.Canon.AmpAmpObliviousByReflectionPhases));
            this.ObliviousOracleFromDeterministicStateOracle = this.Factory.Get<ICallable<(IUnitary,IUnitary), IUnitary>>(typeof(Microsoft.Quantum.Canon.ObliviousOracleFromDeterministicStateOracle));
            this.ReflectionStart = this.Factory.Get<ICallable<QVoid, IUnitary>>(typeof(Microsoft.Quantum.Canon.ReflectionStart));
            this.TargetStateReflectionOracle = this.Factory.Get<ICallable<Int64, IUnitary>>(typeof(Microsoft.Quantum.Canon.TargetStateReflectionOracle));
        }

        public override IApplyData __dataIn((AmpAmpReflectionPhases,IUnitary,IUnitary,Int64) data) => new In(data);
        public override IApplyData __dataOut(IUnitary data) => new QTuple<IUnitary>(data);
        public static System.Threading.Tasks.Task<IUnitary> Run(IOperationFactory __m__, AmpAmpReflectionPhases phases, IUnitary ancillaOracle, IUnitary signalOracle, Int64 idxFlagQubit)
        {
            return __m__.Run<AmpAmpObliviousByOraclePhases, (AmpAmpReflectionPhases,IUnitary,IUnitary,Int64), IUnitary>((phases, ancillaOracle, signalOracle, idxFlagQubit));
        }
    }

    public class AmpAmpByReflectionsPhases : Operation<(AmpAmpReflectionPhases,IUnitary,IUnitary), IUnitary>, ICallable
    {
        public AmpAmpByReflectionsPhases(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(AmpAmpReflectionPhases,IUnitary,IUnitary)>, IApplyData
        {
            public In((AmpAmpReflectionPhases,IUnitary,IUnitary) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "AmpAmpByReflectionsPhases";
        String ICallable.FullName => "Microsoft.Quantum.Canon.AmpAmpByReflectionsPhases";
        protected ICallable<(AmpAmpReflectionPhases,IUnitary,IUnitary,IUnitary), IUnitary> AmpAmpObliviousByReflectionPhases
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Qubit>,QArray<Qubit>)> NoOp2
        {
            get;
            set;
        }

        public override Func<(AmpAmpReflectionPhases,IUnitary,IUnitary), IUnitary> Body => (__in) =>
        {
            var (phases,startStateReflection,targetStateReflection) = __in;
            //Pass empty qubit array using fact that NoOp2 does nothing
#line 327 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
            var qubitEmpty = new QArray<Qubit>(0L);
#line 329 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
            var signalOracle = new ObliviousOracle(NoOp2);
#line 331 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
            return AmpAmpObliviousByReflectionPhases.Apply((phases, startStateReflection, targetStateReflection, signalOracle)).Partial(new Func<QArray<Qubit>, (QArray<Qubit>,QArray<Qubit>)>((_arg1) => (_arg1, qubitEmpty)));
        }

        ;
        public override void Init()
        {
            this.AmpAmpObliviousByReflectionPhases = this.Factory.Get<ICallable<(AmpAmpReflectionPhases,IUnitary,IUnitary,IUnitary), IUnitary>>(typeof(Microsoft.Quantum.Canon.AmpAmpObliviousByReflectionPhases));
            this.NoOp2 = this.Factory.Get<IUnitary<(QArray<Qubit>,QArray<Qubit>)>>(typeof(Microsoft.Quantum.Canon.NoOp2));
        }

        public override IApplyData __dataIn((AmpAmpReflectionPhases,IUnitary,IUnitary) data) => new In(data);
        public override IApplyData __dataOut(IUnitary data) => new QTuple<IUnitary>(data);
        public static System.Threading.Tasks.Task<IUnitary> Run(IOperationFactory __m__, AmpAmpReflectionPhases phases, IUnitary startStateReflection, IUnitary targetStateReflection)
        {
            return __m__.Run<AmpAmpByReflectionsPhases, (AmpAmpReflectionPhases,IUnitary,IUnitary), IUnitary>((phases, startStateReflection, targetStateReflection));
        }
    }

    public class AmpAmpByOraclePhases : Operation<(AmpAmpReflectionPhases,IUnitary,Int64), IUnitary>, ICallable
    {
        public AmpAmpByOraclePhases(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(AmpAmpReflectionPhases,IUnitary,Int64)>, IApplyData
        {
            public In((AmpAmpReflectionPhases,IUnitary,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "AmpAmpByOraclePhases";
        String ICallable.FullName => "Microsoft.Quantum.Canon.AmpAmpByOraclePhases";
        protected ICallable<(AmpAmpReflectionPhases,IUnitary,IUnitary,Int64), IUnitary> AmpAmpObliviousByOraclePhases
        {
            get;
            set;
        }

        protected ICallable<(Int64,IUnitary), IUnitary> DeterministicStateOracleFromStateOracle
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Qubit>,QArray<Qubit>)> NoOp2
        {
            get;
            set;
        }

        public override Func<(AmpAmpReflectionPhases,IUnitary,Int64), IUnitary> Body => (__in) =>
        {
            var (phases,stateOracle,idxFlagQubit) = __in;
#line 362 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
            var qubitEmpty = new QArray<Qubit>(0L);
#line 363 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
            var signalOracle = new ObliviousOracle(NoOp2);
#line 364 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
            var ancillaOracle = DeterministicStateOracleFromStateOracle.Apply((idxFlagQubit, stateOracle));
#line 366 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
            return AmpAmpObliviousByOraclePhases.Apply((phases, ancillaOracle, signalOracle, idxFlagQubit)).Partial(new Func<QArray<Qubit>, (QArray<Qubit>,QArray<Qubit>)>((_arg1) => (_arg1, qubitEmpty)));
        }

        ;
        public override void Init()
        {
            this.AmpAmpObliviousByOraclePhases = this.Factory.Get<ICallable<(AmpAmpReflectionPhases,IUnitary,IUnitary,Int64), IUnitary>>(typeof(Microsoft.Quantum.Canon.AmpAmpObliviousByOraclePhases));
            this.DeterministicStateOracleFromStateOracle = this.Factory.Get<ICallable<(Int64,IUnitary), IUnitary>>(typeof(Microsoft.Quantum.Canon.DeterministicStateOracleFromStateOracle));
            this.NoOp2 = this.Factory.Get<IUnitary<(QArray<Qubit>,QArray<Qubit>)>>(typeof(Microsoft.Quantum.Canon.NoOp2));
        }

        public override IApplyData __dataIn((AmpAmpReflectionPhases,IUnitary,Int64) data) => new In(data);
        public override IApplyData __dataOut(IUnitary data) => new QTuple<IUnitary>(data);
        public static System.Threading.Tasks.Task<IUnitary> Run(IOperationFactory __m__, AmpAmpReflectionPhases phases, IUnitary stateOracle, Int64 idxFlagQubit)
        {
            return __m__.Run<AmpAmpByOraclePhases, (AmpAmpReflectionPhases,IUnitary,Int64), IUnitary>((phases, stateOracle, idxFlagQubit));
        }
    }

    public class AmpAmpByOracle : Operation<(Int64,IUnitary,Int64), IUnitary>, ICallable
    {
        public AmpAmpByOracle(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,IUnitary,Int64)>, IApplyData
        {
            public In((Int64,IUnitary,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "AmpAmpByOracle";
        String ICallable.FullName => "Microsoft.Quantum.Canon.AmpAmpByOracle";
        protected ICallable<(AmpAmpReflectionPhases,IUnitary,Int64), IUnitary> AmpAmpByOraclePhases
        {
            get;
            set;
        }

        protected ICallable<Int64, AmpAmpReflectionPhases> AmpAmpPhasesStandard
        {
            get;
            set;
        }

        public override Func<(Int64,IUnitary,Int64), IUnitary> Body => (__in) =>
        {
            var (nIterations,stateOracle,idxFlagQubit) = __in;
#line 401 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
            var phases = AmpAmpPhasesStandard.Apply(nIterations);
#line 402 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
            return AmpAmpByOraclePhases.Apply((phases, stateOracle, idxFlagQubit));
        }

        ;
        public override void Init()
        {
            this.AmpAmpByOraclePhases = this.Factory.Get<ICallable<(AmpAmpReflectionPhases,IUnitary,Int64), IUnitary>>(typeof(Microsoft.Quantum.Canon.AmpAmpByOraclePhases));
            this.AmpAmpPhasesStandard = this.Factory.Get<ICallable<Int64, AmpAmpReflectionPhases>>(typeof(Microsoft.Quantum.Canon.AmpAmpPhasesStandard));
        }

        public override IApplyData __dataIn((Int64,IUnitary,Int64) data) => new In(data);
        public override IApplyData __dataOut(IUnitary data) => new QTuple<IUnitary>(data);
        public static System.Threading.Tasks.Task<IUnitary> Run(IOperationFactory __m__, Int64 nIterations, IUnitary stateOracle, Int64 idxFlagQubit)
        {
            return __m__.Run<AmpAmpByOracle, (Int64,IUnitary,Int64), IUnitary>((nIterations, stateOracle, idxFlagQubit));
        }
    }

    public class AmpAmpRUSByOracle : Operation<(IUnitary,QArray<Qubit>), QVoid>, ICallable
    {
        public AmpAmpRUSByOracle(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IUnitary,QArray<Qubit>)>, IApplyData
        {
            public In((IUnitary,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "AmpAmpRUSByOracle";
        String ICallable.FullName => "Microsoft.Quantum.Canon.AmpAmpRUSByOracle";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected ICallable<(AmpAmpReflectionPhases,IUnitary,Int64), IUnitary> AmpAmpByOraclePhases
        {
            get;
            set;
        }

        protected ICallable<(Int64,Double), AmpAmpReflectionPhases> AmpAmpPhasesFixedPoint
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> M
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, QVoid> ResetAll
        {
            get;
            set;
        }

        public override Func<(IUnitary,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (statePrepOracle,startQubits) = __in;
#line 420 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
            var queriesMax = 999L;
            // Should be a power of 2
#line 421 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
            var successMin = 0.99D;
#line 422 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
            var finished = Result.Zero;
#line 423 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
            var exponentMax = 0L;
#line 424 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
            var exponentCurrent = 0L;
            //Complexity: Let \theta = \mathcal{O}(\sqrt{lambda}) 
            // Number of Measurements = O( Log^2(1/\theta) )
            // Number of Queries = O(1/\theta)
#line 430 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
            var flagQubit = Allocate.Apply(1L);
#line 431 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
            var qubits = (flagQubit + startQubits);
#line 432 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
            var idxFlagQubit = 0L;
#line 433 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
            while (true)
            {
#line 434 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
                if ((2L.Pow(exponentMax) > queriesMax))
                {
#line 435 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
                    throw new ExecutionFailException("Target state not found. Maximum number of queries exceeded.");
                }

#line 437 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
                while (true)
                {
#line 438 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
                    var queries = 2L.Pow(exponentCurrent);
#line 439 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
                    var phases = AmpAmpPhasesFixedPoint.Apply((queries, successMin));
#line 440 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
                    AmpAmpByOraclePhases.Apply((phases, statePrepOracle, idxFlagQubit)).Apply(qubits);
#line 442 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
                    finished = M.Apply(flagQubit[0L]);
#line 443 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
                    exponentCurrent = (exponentCurrent + 1L);
                    if (((finished == Result.One) || (exponentCurrent > exponentMax)))
                    {
                        break;
                    }
                    else
                    {
                        // flagQubit is already in Zero for fixup to apply
#line 448 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
                        ResetAll.Apply(startQubits);
                    }
                }

#line 451 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
                exponentCurrent = 0L;
#line 452 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
                exponentMax = (exponentMax + 1L);
                if ((finished == Result.One))
                {
                    break;
                }
                else
                {
#line 456 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\AmplitudeAmplification\\AmplitudeAmplification.qs"
                    ResetAll.Apply(startQubits);
                }
            }

#line hidden
            Release.Apply(flagQubit);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.AmpAmpByOraclePhases = this.Factory.Get<ICallable<(AmpAmpReflectionPhases,IUnitary,Int64), IUnitary>>(typeof(Microsoft.Quantum.Canon.AmpAmpByOraclePhases));
            this.AmpAmpPhasesFixedPoint = this.Factory.Get<ICallable<(Int64,Double), AmpAmpReflectionPhases>>(typeof(Microsoft.Quantum.Canon.AmpAmpPhasesFixedPoint));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
        }

        public override IApplyData __dataIn((IUnitary,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IUnitary statePrepOracle, QArray<Qubit> startQubits)
        {
            return __m__.Run<AmpAmpRUSByOracle, (IUnitary,QArray<Qubit>), QVoid>((statePrepOracle, startQubits));
        }
    }
}