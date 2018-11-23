#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("test", "Solve (q : Qubit, sign : Int) : ()", new string[] { }, "C:\\Users\\nimac\\Q#Projects\\test1\\test\\test.qs", 153L, 7L, 5L)]
#line hidden
namespace test
{
    public class Solve : Operation<(Qubit,Int64), QVoid>, ICallable
    {
        public Solve(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,Int64)>, IApplyData
        {
            public In((Qubit,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item1;
                }
            }
        }

        String ICallable.Name => "Solve";
        String ICallable.FullName => "test.Solve";
        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get;
            set;
        }

        public override Func<(Qubit,Int64), QVoid> Body => (__in) =>
        {
            var (q,sign) = __in;
#line 10 "C:\\Users\\nimac\\Q#Projects\\test1\\test\\test.qs"
            if ((sign == 1L))
            {
#line 11 "C:\\Users\\nimac\\Q#Projects\\test1\\test\\test.qs"
                MicrosoftQuantumPrimitiveH.Apply(q);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
        }

        public override IApplyData __dataIn((Qubit,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit q, Int64 sign)
        {
            return __m__.Run<Solve, (Qubit,Int64), QVoid>((q, sign));
        }
    }
}