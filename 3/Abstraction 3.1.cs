using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_3._1
{
    abstract class AbstractHandler
    {
        public virtual void Open() { }

        public virtual void Create() { }

        public virtual void Change() { }

        public virtual void Save() { }

    }

    class XMLHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Open XML file.");
        }

        public override void Create()
        {
            Console.WriteLine("Create XML file.");
        }

        public override void Change()
        {
            Console.WriteLine("Change XML file.");
        }

        public override void Save()
        {
            Console.WriteLine("Save XML file.");
        }
    }

    class TXTHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Open TXT file.");
        }

        public override void Create()
        {
            Console.WriteLine("Create TXT file.");
        }

        public override void Change()
        {
            Console.WriteLine("Change TXT file.");
        }

        public override void Save()
        {
            Console.WriteLine("Save TXT file.");
        }
    }

    class DOCHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Open DOC file.");
        }

        public override void Create()
        {
            Console.WriteLine("Create DOC file.");
        }

        public override void Change()
        {
            Console.WriteLine("Change DOC file.");
        }

        public override void Save()
        {
            Console.WriteLine("Save DOC file.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string fileType;
            int finishProgram = 0;
            int finishWorkWithFile = 0;
            int checking = 0;

            while(finishProgram != 3)
            {
                Console.Write("Put the type of the file with which you want to work: ");
                fileType = Console.ReadLine();
                Console.WriteLine();

                finishWorkWithFile = 0;

                while(finishWorkWithFile != 2)
                {
                    switch (fileType)
                    {
                        case "XML":
                            AbstractHandler xmlFile = new XMLHandler();

                            int xmlKey = 0;

                            Console.Write("What do you want to do with file? Press:\n1 - Open\n2 - Create\n3 - Change\n4 - Save\n");
                            xmlKey = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();

                            switch (xmlKey)
                            {
                                case 1:
                                    xmlFile.Open();
                                    break;
                                case 2:
                                    xmlFile.Create();
                                    break;
                                case 3:
                                    xmlFile.Change();
                                    break;
                                case 4:
                                    xmlFile.Save();
                                    break;
                                default:
                                    Console.WriteLine("Do not have options for such value.");
                                    break;
                            }

                            break;
                        case "TXT":
                            AbstractHandler txtFile = new TXTHandler();

                            int txtKey = 0;

                            Console.Write("What do you want to do with file? Press:\n1 - Open\n2 - Create\n3 - Change\n4 - Save\n");
                            txtKey = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();

                            switch (txtKey)
                            {
                                case 1:
                                    txtFile.Open();
                                    break;
                                case 2:
                                    txtFile.Create();
                                    break;
                                case 3:
                                    txtFile.Change();
                                    break;
                                case 4:
                                    txtFile.Save();
                                    break;
                                default:
                                    Console.WriteLine("Do not have options for such value.");
                                    break;
                            }

                            break;
                        case "DOC":
                            AbstractHandler docFile = new DOCHandler();

                            int docKey = 0;

                            Console.Write("What do you want to do with file? Press:\n1 - Open\n2 - Create\n3 - Change\n4 - Save\n");
                            docKey = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();

                            switch (docKey)
                            {
                                case 1:
                                    docFile.Open();
                                    break;
                                case 2:
                                    docFile.Create();
                                    break;
                                case 3:
                                    docFile.Change();
                                    break;
                                case 4:
                                    docFile.Save();
                                    break;
                                default:
                                    Console.WriteLine("Do not have options for such value.");
                                    break;
                            }

                            break;
                        default:
                            Console.WriteLine("Error! Do not know that type of file. ");
                            checking = 2;
                            break;
                    }

                    if(checking != 2)
                    {
                        Console.Write("Do you want to do another option with this file? Press 2 if not: ");
                        finishWorkWithFile = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        checking = 0;
                        fileType = "";
                    }
                    else
                    {
                        break;
                    }
                }

                Console.Write("Do you want to work with another type of file? Press 3 if not: ");
                finishProgram = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }
        }
    }
}