#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: UdtDeclaration("Microsoft.Quantum.Canon", "CCNOTop", "((Qubit, Qubit, Qubit) => () : Adjoint)", "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyMultiControlled.qs", 484L, 12L, 42L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "ApplyMultiControlledC (singlyControlledOp : (Qubit[] => ()), ccnot : Microsoft.Quantum.Canon.CCNOTop, controls : Qubit[], targets : Qubit[]) : ()", new string[] { "Controlled" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyMultiControlled.qs", 2068L, 50L, 34L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "ApplyMultiControlledCA (singlyControlledOp : (Qubit[] => () : Adjoint), ccnot : Microsoft.Quantum.Canon.CCNOTop, controls : Qubit[], targets : Qubit[]) : ()", new string[] { "Controlled", "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyMultiControlled.qs", 4358L, 106L, 34L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Canon", "AndLadder (ccnot : Microsoft.Quantum.Canon.CCNOTop, controls : Qubit[], targets : Qubit[]) : ()", new string[] { "Adjoint" }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyMultiControlled.qs", 6881L, 163L, 89L)]
#line hidden
namespace Microsoft.Quantum.Canon
{
    public class CCNOTop : OperationUdt<(Qubit,Qubit,Qubit),QVoid>, ICallable, IApplyData
    {
        public CCNOTop() : base(default(IAdjointable))
        {
        }

        public CCNOTop(IAdjointable data) : base(data)
        {
        }

        public CCNOTop(OperationUdt<(Qubit,Qubit,Qubit),QVoid> b) : base(b.Data)
        {
        }

        String ICallable.Name => "CCNOTop";
        String ICallable.FullName => "Microsoft.Quantum.Canon.CCNOTop";
    }

    public class ApplyMultiControlledC : Controllable<(ICallable,IAdjointable,QArray<Qubit>,QArray<Qubit>)>, ICallable
    {
        public ApplyMultiControlledC(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(ICallable,IAdjointable,QArray<Qubit>,QArray<Qubit>)>, IApplyData
        {
            public In((ICallable,IAdjointable,QArray<Qubit>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits, ((IApplyData)Data.Item4)?.Qubits);
        }

        String ICallable.Name => "ApplyMultiControlledC";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ApplyMultiControlledC";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IAdjointable<(IAdjointable,QArray<Qubit>,QArray<Qubit>)> AndLadder
        {
            get;
            set;
        }

        protected ICallable<(Boolean,Boolean,String), QVoid> AssertBoolEqual
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable Tail
        {
            get;
            set;
        }

        public override Func<(ICallable,IAdjointable,QArray<Qubit>,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (singlyControlledOp,ccnot,controls,targets) = __in;
#line 52 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyMultiControlled.qs"
            AssertBoolEqual.Apply(((controls.Count >= 1L), true, "Length of controls must be at least 1"));
#line 55 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyMultiControlled.qs"
            if ((controls.Count == 1L))
            {
#line 56 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyMultiControlled.qs"
                singlyControlledOp.Apply((controls + targets));
            }
            else
            {
#line 58 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyMultiControlled.qs"
                var ancillas = Allocate.Apply((controls.Count - 1L));
#line 59 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyMultiControlled.qs"
                AndLadder.Apply((ccnot, controls, ancillas));
#line 60 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyMultiControlled.qs"
                singlyControlledOp.Apply((new QArray<Qubit>()
                {Tail.Apply<Qubit>(ancillas)} + targets));
#line 61 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyMultiControlled.qs"
                AndLadder.Adjoint.Apply((ccnot, controls, ancillas));
#line hidden
                Release.Apply(ancillas);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(ICallable,IAdjointable,QArray<Qubit>,QArray<Qubit>)), QVoid> ControlledBody => (__in) =>
        {
            var (extraControls,(singlyControlledOp,ccnot,controls,targets)) = __in;
#line 66 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyMultiControlled.qs"
            ((IControllable)this).Apply((((ICallable)singlyControlledOp), ccnot, (extraControls + controls), targets));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.AndLadder = this.Factory.Get<IAdjointable<(IAdjointable,QArray<Qubit>,QArray<Qubit>)>>(typeof(Microsoft.Quantum.Canon.AndLadder));
            this.AssertBoolEqual = this.Factory.Get<ICallable<(Boolean,Boolean,String), QVoid>>(typeof(Microsoft.Quantum.Canon.AssertBoolEqual));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.Tail = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Tail<>));
        }

        public override IApplyData __dataIn((ICallable,IAdjointable,QArray<Qubit>,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, ICallable singlyControlledOp, IAdjointable ccnot, QArray<Qubit> controls, QArray<Qubit> targets)
        {
            return __m__.Run<ApplyMultiControlledC, (ICallable,IAdjointable,QArray<Qubit>,QArray<Qubit>), QVoid>((singlyControlledOp, ccnot, controls, targets));
        }
    }

    public class ApplyMultiControlledCA : Unitary<(IAdjointable,IAdjointable,QArray<Qubit>,QArray<Qubit>)>, ICallable
    {
        public ApplyMultiControlledCA(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IAdjointable,IAdjointable,QArray<Qubit>,QArray<Qubit>)>, IApplyData
        {
            public In((IAdjointable,IAdjointable,QArray<Qubit>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits, ((IApplyData)Data.Item4)?.Qubits);
        }

        String ICallable.Name => "ApplyMultiControlledCA";
        String ICallable.FullName => "Microsoft.Quantum.Canon.ApplyMultiControlledCA";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IAdjointable<(IAdjointable,QArray<Qubit>,QArray<Qubit>)> AndLadder
        {
            get;
            set;
        }

        protected ICallable<(Boolean,Boolean,String), QVoid> AssertBoolEqual
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable Tail
        {
            get;
            set;
        }

        public override Func<(IAdjointable,IAdjointable,QArray<Qubit>,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (singlyControlledOp,ccnot,controls,targets) = __in;
#line 108 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyMultiControlled.qs"
            AssertBoolEqual.Apply(((controls.Count >= 1L), true, "Length of controls must be at least 1"));
#line 111 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyMultiControlled.qs"
            if ((controls.Count == 1L))
            {
#line 112 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyMultiControlled.qs"
                singlyControlledOp.Apply((controls + targets));
            }
            else
            {
#line 114 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyMultiControlled.qs"
                var ancillas = Allocate.Apply((controls.Count - 1L));
#line 115 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyMultiControlled.qs"
                AndLadder.Apply((ccnot, controls, ancillas));
#line 116 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyMultiControlled.qs"
                singlyControlledOp.Apply((new QArray<Qubit>()
                {Tail.Apply<Qubit>(ancillas)} + targets));
#line 117 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyMultiControlled.qs"
                AndLadder.Adjoint.Apply((ccnot, controls, ancillas));
#line hidden
                Release.Apply(ancillas);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IAdjointable,IAdjointable,QArray<Qubit>,QArray<Qubit>), QVoid> AdjointBody => (__in) =>
        {
            var (singlyControlledOp,ccnot,controls,targets) = __in;
            AssertBoolEqual.Apply(((controls.Count >= 1L), true, "Length of controls must be at least 1"));
            if ((controls.Count == 1L))
            {
                singlyControlledOp.Adjoint.Apply((controls + targets));
            }
            else
            {
                var ancillas = Allocate.Apply((controls.Count - 1L));
                AndLadder.Adjoint.Adjoint.Apply((ccnot, controls, ancillas));
                singlyControlledOp.Adjoint.Apply((new QArray<Qubit>()
                {Tail.Apply<Qubit>(ancillas)} + targets));
                AndLadder.Adjoint.Apply((ccnot, controls, ancillas));
#line hidden
                Release.Apply(ancillas);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(IAdjointable,IAdjointable,QArray<Qubit>,QArray<Qubit>)), QVoid> ControlledBody => (__in) =>
        {
            var (extraControls,(singlyControlledOp,ccnot,controls,targets)) = __in;
#line 123 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyMultiControlled.qs"
            ((IUnitary)this).Apply((((IAdjointable)singlyControlledOp), ccnot, (extraControls + controls), targets));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(IAdjointable,IAdjointable,QArray<Qubit>,QArray<Qubit>)), QVoid> ControlledAdjointBody => (__in) =>
        {
            var (extraControls,(singlyControlledOp,ccnot,controls,targets)) = __in;
            ((IUnitary)this).Adjoint.Apply((((IAdjointable)singlyControlledOp), ccnot, (extraControls + controls), targets));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.AndLadder = this.Factory.Get<IAdjointable<(IAdjointable,QArray<Qubit>,QArray<Qubit>)>>(typeof(Microsoft.Quantum.Canon.AndLadder));
            this.AssertBoolEqual = this.Factory.Get<ICallable<(Boolean,Boolean,String), QVoid>>(typeof(Microsoft.Quantum.Canon.AssertBoolEqual));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.Tail = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Tail<>));
        }

        public override IApplyData __dataIn((IAdjointable,IAdjointable,QArray<Qubit>,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IAdjointable singlyControlledOp, IAdjointable ccnot, QArray<Qubit> controls, QArray<Qubit> targets)
        {
            return __m__.Run<ApplyMultiControlledCA, (IAdjointable,IAdjointable,QArray<Qubit>,QArray<Qubit>), QVoid>((singlyControlledOp, ccnot, controls, targets));
        }
    }

    public class AndLadder : Adjointable<(IAdjointable,QArray<Qubit>,QArray<Qubit>)>, ICallable
    {
        public AndLadder(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IAdjointable,QArray<Qubit>,QArray<Qubit>)>, IApplyData
        {
            public In((IAdjointable,QArray<Qubit>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "AndLadder";
        String ICallable.FullName => "Microsoft.Quantum.Canon.AndLadder";
        protected ICallable<(Boolean,Boolean,String), QVoid> AssertBoolEqual
        {
            get;
            set;
        }

        public override Func<(IAdjointable,QArray<Qubit>,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (ccnot,controls,targets) = __in;
#line 165 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyMultiControlled.qs"
            AssertBoolEqual.Apply(((controls.Count == (targets.Count + 1L)), true, "Length(controls) must be equal to Length(target) + 1"));
#line 167 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyMultiControlled.qs"
            AssertBoolEqual.Apply(((controls.Count >= 2L), true, "The operation is not defined for less than 2 controls"));
#line 169 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyMultiControlled.qs"
            ccnot.Apply((controls[0L], controls[1L], targets[0L]));
#line 170 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyMultiControlled.qs"
            foreach (var k in new Range(1L, (targets.Count - 1L)))
            {
#line 171 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Microsoft.Quantum.Canon\\Combinators\\ApplyMultiControlled.qs"
                ccnot.Apply((controls[(k + 1L)], targets[(k - 1L)], targets[k]));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IAdjointable,QArray<Qubit>,QArray<Qubit>), QVoid> AdjointBody => (__in) =>
        {
            var (ccnot,controls,targets) = __in;
            AssertBoolEqual.Apply(((controls.Count == (targets.Count + 1L)), true, "Length(controls) must be equal to Length(target) + 1"));
            AssertBoolEqual.Apply(((controls.Count >= 2L), true, "The operation is not defined for less than 2 controls"));
            foreach (var k in new Range((1L - ((((targets.Count - 1L) - 1L) / 1L) * -(1L))), -(1L), 1L))
            {
                ccnot.Adjoint.Apply((controls[(k + 1L)], targets[(k - 1L)], targets[k]));
            }

            ccnot.Adjoint.Apply((controls[0L], controls[1L], targets[0L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.AssertBoolEqual = this.Factory.Get<ICallable<(Boolean,Boolean,String), QVoid>>(typeof(Microsoft.Quantum.Canon.AssertBoolEqual));
        }

        public override IApplyData __dataIn((IAdjointable,QArray<Qubit>,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IAdjointable ccnot, QArray<Qubit> controls, QArray<Qubit> targets)
        {
            return __m__.Run<AndLadder, (IAdjointable,QArray<Qubit>,QArray<Qubit>), QVoid>((ccnot, controls, targets));
        }
    }
}