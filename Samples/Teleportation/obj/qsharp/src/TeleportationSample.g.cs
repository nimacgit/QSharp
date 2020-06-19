#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Microsoft.Quantum.Examples.Teleportation", "Teleport (msg : Qubit, there : Qubit) : ()", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Samples\\Teleportation\\TeleportationSample.qs", 2025L, 44L, 57L)]
[assembly: OperationDeclaration("Microsoft.Quantum.Examples.Teleportation", "TeleportClassicalMessage (message : Bool) : Bool", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\Quantum\\Samples\\Teleportation\\TeleportationSample.qs", 3538L, 88L, 63L)]
#line hidden
namespace Microsoft.Quantum.Examples.Teleportation
{
    public class Teleport : Operation<(Qubit,Qubit), QVoid>, ICallable
    {
        public Teleport(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,Qubit)>, IApplyData
        {
            public In((Qubit,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item1;
                    yield return Data.Item2;
                }
            }
        }

        String ICallable.Name => "Teleport";
        String ICallable.FullName => "Microsoft.Quantum.Examples.Teleportation.Teleport";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveCNOT
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
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

        protected ICallable<Qubit, QVoid> Reset
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveZ
        {
            get;
            set;
        }

        public override Func<(Qubit,Qubit), QVoid> Body => (__in) =>
        {
            var (msg,there) = __in;
#line 47 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Samples\\Teleportation\\TeleportationSample.qs"
            var register = Allocate.Apply(1L);
            // Ask for an auxillary qubit that we can use to prepare
            // for teleportation.
#line 50 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Samples\\Teleportation\\TeleportationSample.qs"
            var here = register[0L];
            // Create some entanglement that we can use to send our message.
#line 53 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Samples\\Teleportation\\TeleportationSample.qs"
            MicrosoftQuantumPrimitiveH.Apply(here);
#line 54 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Samples\\Teleportation\\TeleportationSample.qs"
            MicrosoftQuantumPrimitiveCNOT.Apply((here, there));
            // Move our message into the entangled pair.
#line 57 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Samples\\Teleportation\\TeleportationSample.qs"
            MicrosoftQuantumPrimitiveCNOT.Apply((msg, here));
#line 58 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Samples\\Teleportation\\TeleportationSample.qs"
            MicrosoftQuantumPrimitiveH.Apply(msg);
            // Measure out the entanglement.
#line 61 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Samples\\Teleportation\\TeleportationSample.qs"
            if ((M.Apply(msg) == Result.One))
            {
#line 61 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Samples\\Teleportation\\TeleportationSample.qs"
                MicrosoftQuantumPrimitiveZ.Apply(there);
            }

#line 62 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Samples\\Teleportation\\TeleportationSample.qs"
            if ((M.Apply(here) == Result.One))
            {
#line 62 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Samples\\Teleportation\\TeleportationSample.qs"
                MicrosoftQuantumPrimitiveX.Apply(there);
            }

            // Reset our "here" qubit before releasing it.
#line 65 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Samples\\Teleportation\\TeleportationSample.qs"
            Reset.Apply(here);
#line hidden
            Release.Apply(register);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.Reset = this.Factory.Get<ICallable<Qubit, QVoid>>(typeof(Microsoft.Quantum.Primitive.Reset));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
            this.MicrosoftQuantumPrimitiveZ = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.Z));
        }

        public override IApplyData __dataIn((Qubit,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit msg, Qubit there)
        {
            return __m__.Run<Teleport, (Qubit,Qubit), QVoid>((msg, there));
        }
    }

    public class TeleportClassicalMessage : Operation<Boolean, Boolean>, ICallable
    {
        public TeleportClassicalMessage(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "TeleportClassicalMessage";
        String ICallable.FullName => "Microsoft.Quantum.Examples.Teleportation.TeleportClassicalMessage";
        protected Allocate Allocate
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

        protected ICallable<(Qubit,Qubit), QVoid> Teleport
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<Boolean, Boolean> Body => (__in) =>
        {
            var message = __in;
#line 90 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Samples\\Teleportation\\TeleportationSample.qs"
            var measurement = false;
#line 92 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Samples\\Teleportation\\TeleportationSample.qs"
            var register = Allocate.Apply(2L);
            // Ask for some qubits that we can use to teleport.
#line 94 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Samples\\Teleportation\\TeleportationSample.qs"
            var msg = register[0L];
#line 95 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Samples\\Teleportation\\TeleportationSample.qs"
            var there = register[1L];
            // Encode the message we want to send.
#line 98 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Samples\\Teleportation\\TeleportationSample.qs"
            if (message)
            {
#line 98 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Samples\\Teleportation\\TeleportationSample.qs"
                MicrosoftQuantumPrimitiveX.Apply(msg);
            }

            // Use the operation we defined above.
#line 101 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Samples\\Teleportation\\TeleportationSample.qs"
            Teleport.Apply((msg, there));
            // Check what message was sent.
#line 104 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Samples\\Teleportation\\TeleportationSample.qs"
            if ((M.Apply(there) == Result.One))
            {
#line 104 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Samples\\Teleportation\\TeleportationSample.qs"
                measurement = true;
            }

            // Reset all of the qubits that we used before releasing
            // them.
#line 108 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Samples\\Teleportation\\TeleportationSample.qs"
            ResetAll.Apply(register);
#line hidden
            Release.Apply(register);
#line 111 "C:\\Users\\nimac\\Q#Projects\\Quantum\\Samples\\Teleportation\\TeleportationSample.qs"
            return measurement;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.Teleport = this.Factory.Get<ICallable<(Qubit,Qubit), QVoid>>(typeof(Microsoft.Quantum.Examples.Teleportation.Teleport));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn(Boolean data) => new QTuple<Boolean>(data);
        public override IApplyData __dataOut(Boolean data) => new QTuple<Boolean>(data);
        public static System.Threading.Tasks.Task<Boolean> Run(IOperationFactory __m__, Boolean message)
        {
            return __m__.Run<TeleportClassicalMessage, Boolean, Boolean>(message);
        }
    }
}