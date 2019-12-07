using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_2._2
{
    class ClassRoom
    {
        public ClassRoom(Pupil A, Pupil B) { }
        public ClassRoom(Pupil A, Pupil B, Pupil C) { }
        public ClassRoom(Pupil A, Pupil B, Pupil C, Pupil D) { }

    }

    class Pupil
    {
        public virtual void Study() { }
        public virtual void Read() { }
        public virtual void Write() { }
        public virtual void Relax() { }
    }

    class ExelentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("I study a lot.");
        }

        public override void Read()
        {
            Console.WriteLine("I read a lot.");
        }

        public override void Write()
        {
            Console.WriteLine("I write a lot.");
        }

        public override void Relax()
        {
            Console.WriteLine("I almost do not relax.");
        }
    }

    class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("I study enough.");
        }

        public override void Read()
        {
            Console.WriteLine("I read enough.");
        }

        public override void Write()
        {
            Console.WriteLine("I write enough.");
        }

        public override void Relax()
        {
            Console.WriteLine("I relax enough.");
        }
    }

    class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("I almost do not study.");
        }

        public override void Read()
        {
            Console.WriteLine("I almost do not read.");
        }

        public override void Write()
        {
            Console.WriteLine("I almost do not write.");
        }

        public override void Relax()
        {
            Console.WriteLine("I relax a lot.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pupil A = new ExelentPupil(), B = new GoodPupil(), C = new ExelentPupil(), D = new BadPupil();

            ClassRoom classRoom = new ClassRoom(A, B, C, D);

            A.Study();
            A.Read();
            A.Write();
            A.Relax();
            Console.WriteLine();

            B.Study();
            B.Read();
            B.Write();
            B.Relax();
            Console.WriteLine();

            C.Study();
            C.Read();
            C.Write();
            C.Relax();
            Console.WriteLine();

            D.Study();
            D.Read();
            D.Write();
            D.Relax();
            Console.WriteLine();
        }
    }
}
