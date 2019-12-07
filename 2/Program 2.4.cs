using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_2._4
{
    class DocumentWorker
    {
        public void OpenDocument()
        {
            Console.WriteLine("Документ открыт.");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("Редактирование документа доступно в версии Про.");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("Сохранение документа доступно в версии Про.");
        }
    }

    class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Документ отредактирован.");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт.");
        }
    }

    class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в новом формате.");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            int k = 1;
            while (k != 0)
            {
                string keyPro = "pro";
                string keyExp = "exp";
                string keyUser;
                DocumentWorker document;

                Console.Write("Если хотите воспользоваться версией Про или версией Эксперт введите соответствующий ключ(pro или exp): ");
                keyUser = Console.ReadLine();
                Console.WriteLine();

                if (keyUser.Equals(keyPro))
                {
                    document = new ProDocumentWorker();
                }
                else if (keyUser.Equals(keyExp))
                {
                    document = new ExpertDocumentWorker();
                }
                else
                {
                    document = new DocumentWorker();
                }

                document.OpenDocument();
                document.EditDocument();
                document.SaveDocument();

                Console.Write("Чтобы закончить нажмите 0: ");
                k = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }
        }
    }
}
