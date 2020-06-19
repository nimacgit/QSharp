#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "Trotter1ImplCA<'T> ((nSteps : Int, op : ((Int, Double, 'T) => () : Adjoint, Controlled)), stepSize : Double, target : 'T) : ()", new string[] { "Controlled", "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Enumeration\\Trotter.qs", 1211L, 35L, 141L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "Trotter2ImplCA<'T> ((nSteps : Int, op : ((Int, Double, 'T) => () : Adjoint, Controlled)), stepSize : Double, target : 'T) : ()", new string[] { "Controlled", "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Enumeration\\Trotter.qs", 2586L, 76L, 141L)]
[assembly: FunctionDeclaration("Microsoft.Quantum.Canon", "DecomposeIntoTimeStepsCA<'T> ((nSteps : Int, op : ((Int, Double, 'T) => () : Adjoint, Controlled)), trotterOrder : Int) : ((Double, 'T) => () : Adjoint, Controlled)", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Enumeration\\Trotter.qs", 3844L, 113L, 14L)]
#line hidden
namespace Microsoft.Quantum.Canon
{
    public class Trotter1ImplCA<__T> : Unitary<((Int64,IUnitary),Double,__T)>, ICallable
    {
        public Trotter1ImplCA(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<((Int64,IUnitary),Double,__T)>, IApplyData
        {
            public In(((Int64,IUnitary),Double,__T) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1.Item2)?.Qubits, Data.Item3?.GetQubits());
        }

        String ICallable.Name => "Trotter1ImplCA";
        String ICallable.FullName => "Microsoft.Quantum.Canon.Trotter1ImplCA";
        public override Func<((Int64,IUnitary),Double,__T), QVoid> Body => (__in) =>
        {
            var ((nSteps,op),stepSize,target) = __in;
#line 37 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Enumeration\\Trotter.qs"
            foreach (var idx in new Range(0L, (nSteps - 1L)))
            {
#line 38 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Enumeration\\Trotter.qs"
                op.Apply((idx, stepSize, target));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<((Int64,IUnitary),Double,__T), QVoid> AdjointBody => (__in) =>
        {
            var ((nSteps,op),stepSize,target) = __in;
            foreach (var idx in new Range((0L - ((((nSteps - 1L) - 0L) / 1L) * -(1L))), -(1L), 0L))
            {
                op.Adjoint.Apply((idx, stepSize, target));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,((Int64,IUnitary),Double,__T)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,((nSteps,op),stepSize,target)) = __in;
            foreach (var idx in new Range(0L, (nSteps - 1L)))
            {
                op.Controlled.Apply((controlQubits, (idx, stepSize, target)));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,((Int64,IUnitary),Double,__T)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,((nSteps,op),stepSize,target)) = __in;
            foreach (var idx in new Range((0L - ((((nSteps - 1L) - 0L) / 1L) * -(1L))), -(1L), 0L))
            {
                op.Adjoint.Controlled.Apply((controlQubits, (idx, stepSize, target)));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(((Int64,IUnitary),Double,__T) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 nSteps, IUnitary op, Double stepSize, __T target)
        {
            return __m__.Run<Trotter1ImplCA<__T>, ((Int64,IUnitary),Double,__T), QVoid>(((nSteps, op), stepSize, target));
        }
    }

    public class Trotter2ImplCA<__T> : Unitary<((Int64,IUnitary),Double,__T)>, ICallable
    {
        public Trotter2ImplCA(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<((Int64,IUnitary),Double,__T)>, IApplyData
        {
            public In(((Int64,IUnitary),Double,__T) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1.Item2)?.Qubits, Data.Item3?.GetQubits());
        }

        String ICallable.Name => "Trotter2ImplCA";
        String ICallable.FullName => "Microsoft.Quantum.Canon.Trotter2ImplCA";
        public override Func<((Int64,IUnitary),Double,__T), QVoid> Body => (__in) =>
        {
            var ((nSteps,op),stepSize,target) = __in;
#line 78 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Enumeration\\Trotter.qs"
            foreach (var idx in new Range(0L, (nSteps - 1L)))
            {
#line 79 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Enumeration\\Trotter.qs"
                op.Apply((idx, (stepSize * 0.5D), target));
            }

#line 81 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Enumeration\\Trotter.qs"
            foreach (var idx in new Range((nSteps - 1L), -(1L), 0L))
            {
#line 82 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Enumeration\\Trotter.qs"
                op.Apply((idx, (stepSize * 0.5D), target));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<((Int64,IUnitary),Double,__T), QVoid> AdjointBody => (__in) =>
        {
            var ((nSteps,op),stepSize,target) = __in;
            foreach (var idx in new Range(((nSteps - 1L) - (((0L - (nSteps - 1L)) / -(1L)) * -(-(1L)))), -(-(1L)), (nSteps - 1L)))
            {
                op.Adjoint.Apply((idx, (stepSize * 0.5D), target));
            }

            foreach (var idx in new Range((0L - ((((nSteps - 1L) - 0L) / 1L) * -(1L))), -(1L), 0L))
            {
                op.Adjoint.Apply((idx, (stepSize * 0.5D), target));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,((Int64,IUnitary),Double,__T)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,((nSteps,op),stepSize,target)) = __in;
            foreach (var idx in new Range(0L, (nSteps - 1L)))
            {
                op.Controlled.Apply((controlQubits, (idx, (stepSize * 0.5D), target)));
            }

            foreach (var idx in new Range((nSteps - 1L), -(1L), 0L))
            {
                op.Controlled.Apply((controlQubits, (idx, (stepSize * 0.5D), target)));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,((Int64,IUnitary),Double,__T)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (controlQubits,((nSteps,op),stepSize,target)) = __in;
            foreach (var idx in new Range(((nSteps - 1L) - (((0L - (nSteps - 1L)) / -(1L)) * -(-(1L)))), -(-(1L)), (nSteps - 1L)))
            {
                op.Adjoint.Controlled.Apply((controlQubits, (idx, (stepSize * 0.5D), target)));
            }

            foreach (var idx in new Range((0L - ((((nSteps - 1L) - 0L) / 1L) * -(1L))), -(1L), 0L))
            {
                op.Adjoint.Controlled.Apply((controlQubits, (idx, (stepSize * 0.5D), target)));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(((Int64,IUnitary),Double,__T) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 nSteps, IUnitary op, Double stepSize, __T target)
        {
            return __m__.Run<Trotter2ImplCA<__T>, ((Int64,IUnitary),Double,__T), QVoid>(((nSteps, op), stepSize, target));
        }
    }

    public class DecomposeIntoTimeStepsCA<__T> : Operation<((Int64,IUnitary),Int64), IUnitary>, ICallable
    {
        public DecomposeIntoTimeStepsCA(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<((Int64,IUnitary),Int64)>, IApplyData
        {
            public In(((Int64,IUnitary),Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1.Item2)?.Qubits;
        }

        String ICallable.Name => "DecomposeIntoTimeStepsCA";
        String ICallable.FullName => "Microsoft.Quantum.Canon.DecomposeIntoTimeStepsCA";
        protected IUnitary Trotter1ImplCA
        {
            get;
            set;
        }

        protected IUnitary Trotter2ImplCA
        {
            get;
            set;
        }

        public override Func<((Int64,IUnitary),Int64), IUnitary> Body => (__in) =>
        {
            var ((nSteps,op),trotterOrder) = __in;
#line 114 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Enumeration\\Trotter.qs"
            if ((trotterOrder == 1L))
            {
#line 115 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Enumeration\\Trotter.qs"
                return Trotter1ImplCA.Partial(((nSteps, ((IUnitary)op)), _, _));
            }
            else if ((trotterOrder == 2L))
            {
#line 117 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Enumeration\\Trotter.qs"
                return Trotter2ImplCA.Partial(((nSteps, ((IUnitary)op)), _, _));
            }
            else
            {
#line 119 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Enumeration\\Trotter.qs"
                throw new ExecutionFailException("Order $order not yet supported.");
            }

            // Needed so we have a return value of the right type in all cases, but
            //        this line is unreachable.
#line 124 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Enumeration\\Trotter.qs"
            return Trotter1ImplCA.Partial(((nSteps, ((IUnitary)op)), _, _));
        }

        ;
        public override void Init()
        {
            this.Trotter1ImplCA = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.Trotter1ImplCA<>));
            this.Trotter2ImplCA = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.Trotter2ImplCA<>));
        }

        public override IApplyData __dataIn(((Int64,IUnitary),Int64) data) => new In(data);
        public override IApplyData __dataOut(IUnitary data) => new QTuple<IUnitary>(data);
        public static System.Threading.Tasks.Task<IUnitary> Run(IOperationFactory __m__, Int64 nSteps, IUnitary op, Int64 trotterOrder)
        {
            return __m__.Run<DecomposeIntoTimeStepsCA<__T>, ((Int64,IUnitary),Int64), IUnitary>(((nSteps, op), trotterOrder));
        }
    }
}