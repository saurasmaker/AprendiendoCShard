using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace AprendiendoCShard
{
    struct Estructura //Aqui se define una estructura básica
    {
        public int Entero;
        public string Cadena;
        public float Decimal; //Es SUPER IMPORTANTE que los atributos sean públicos si queremos acceder a ellos y modificarlos

        //Constructor de la estructura
        public Estructura(int Entero, string Cadena, float Decimal)
        {
            this.Entero = Entero;
            this.Cadena = Cadena;
            this.Decimal = Decimal;
        }

        //Método propio de la estructura
        public void Info() //VOID significa que no devuelve nada al llamar al método
        {
            Console.WriteLine("Entero:" + this.Entero);
            Console.WriteLine("Cadena:" + this.Cadena);
            Console.WriteLine("Decimal:" + this.Decimal); //No hace falta definir con el this. pero queda mas claro.
        }
    
    }
    //ESTRUCTURA para guardar un animal
    struct Animal
    {
        public string nombre;

        public Animal(string nombre)
        {
            this.nombre = nombre;
        }
        public void info()
        {
            Console.WriteLine("Nombre del animal ->" + nombre);
        }
    }
    //CLASE para guardar un animal
    class claseAnimal
    {
        public string nombre;

        public claseAnimal(string nombre)
        {
            this.nombre = nombre;
        }
        public void info()
        {
            Console.WriteLine("Nombre del animal ->" + nombre);
        }
    }

    class AnimalSonido
    {
        public string nombre; //public es que se puede acceder desde cualquier lado sin problemas
        private double peso;   //private es que solo se puede acceder desde la propia clase
        public double PESO
        {
            get { return peso; }
            set { 
                if (value > 0)
                {
                    peso = value;
                }
                else
                {
                    Console.WriteLine("El valor no puede ser 0 o menor");
                }
            }
        }
        protected string sonido; //protected es que solo se puede acceder desde la clase o sus hijos
        public string SONIDO
        {
            get { return sonido; }
            set { sonido = value; }
        }

        public AnimalSonido()
        {
            this.nombre = "";
            this.peso = 0;
            this.sonido = "";
        }
        public AnimalSonido(string nombre, double peso, string sonido)
        {
            this.nombre = nombre;
            this.PESO = peso;
            this.SONIDO = sonido;
        }
    }

    class Pajaro : AnimalSonido //Esto es una sublclase
    {
        public bool vuela;

        public Pajaro() : base()
        {
            this.vuela = true;
        }
        public Pajaro(string nombre, double peso, string sonido, bool vuela) : base(nombre, peso, sonido)
        {
            this.vuela = vuela;
        }
    }

    class Boss
    {
        private string type;
        public string TYPE
        {
            get { return type; }
            set { type = value; }
        }
        private string name;
        public string NAME
        {
            get { return name; }
            set { name = value; }
        }
        private int CR;
        public int ChallengeRate
        {
            get { return CR; }
            set
            {
                if (value > 0)
                {
                    CR = value;
                }
                else
                {

                }
            }
        }

        public void BossInfo()
        {
            Console.WriteLine("El Boss es {0}, se llama {1} y su CR es {2}",this.type,this.name,this.CR);
        }
    }

    
    
    class Program
    {
        static void Main(string[] args)
        {
            List<Boss> BossList = new List<Boss>();
            
            XmlDocument Lector = new XmlDocument();

            Lector.Load("d:\\xml\\Bosses.xml");
            int f = 0;

            //try
            //{
                for (int j = 0; j < Lector.DocumentElement.ChildNodes.Count; j++)
                {
                    XmlNode node = Lector.DocumentElement.ChildNodes[j];
                    if (node.HasChildNodes)
                    {
                        Boss boss = new Boss();
                        
                        for (int i = 0; i < node.ChildNodes.Count; i++)
                        {

                            boss.TYPE = node.Name;

                            if (node.ChildNodes[i].Name == "Nombre" && node.ChildNodes[i].InnerText != null)
                            {
                                boss.NAME = node.ChildNodes[i].InnerText;
                            }
                            else if (node.ChildNodes[i].Name == "CR" && node.ChildNodes[i].InnerText != null)
                            {
                                try
                                {
                                    boss.ChallengeRate = Convert.ToInt32(node.ChildNodes[i].InnerText);
                                }
                                catch (Exception) { Console.WriteLine("No se ha podido añadir"); }
                            }

                            Console.WriteLine("{0}", node.Name);
                            Console.WriteLine(node.ChildNodes[i].Name + ": " + node.ChildNodes[i].InnerText);


                        }
                        if (boss.ChallengeRate != 0) BossList.Add(boss);
                    }
                }

            //}
            //catch (Exception) { }
            
            int NumeroTotal = 0;
            foreach (Boss FB in BossList)
            {
                
                NumeroTotal++;
            }


            /*for(int depuradora = 0; depuradora < NumeroTotal; depuradora++)
            {
                if (BossList[depuradora].NAME == null)
                {
                    BossList.RemoveAt(depuradora);
                    NumeroTotal--;
                }
            }*/
            
            
            


            XmlDocument Bosses = new XmlDocument(); //Se crea un superelemento llamado Bosses
            XmlElement raiz = Bosses.CreateElement("Raiz"); //Creo un elemento raiz, hijo de Bosses que contendrá todos los demas elementos.
            Bosses.AppendChild(raiz);
            XmlElement Dinamax = Bosses.CreateElement("Dinamax"); //Creo el tipo Dinamax, y le hago hijo de raiz
            raiz.AppendChild(Dinamax);
            XmlElement Gigamax = Bosses.CreateElement("Gigamax"); //Creo el tipo Gigamax, y le hago hijo de raiz
            raiz.AppendChild(Gigamax);

            XmlElement NombreDina = Bosses.CreateElement("Nombre"); //Creo y declaro el Nombre de los Dinamax, debo hacerlo asi porque como va a ser hijo de Dinamax no valdría para los Gigamax.
            Dinamax.AppendChild(NombreDina);
            XmlElement CRdina = Bosses.CreateElement("CR"); //Igual que con nombre pero con CR
            Dinamax.AppendChild(CRdina);
            XmlElement NombreGiga = Bosses.CreateElement("Nombre"); //Creo y declaro el nombre de los Gigamax, porque no puedo usar la variable igual de los dinamax.
            Gigamax.AppendChild(NombreGiga);
            XmlElement CRgiga = Bosses.CreateElement("CR"); //Igual que antes
            Gigamax.AppendChild(CRgiga);

            int dina = 0; //estas variables estan para detectar si es la primera vez que se accede al tipo, es decir, para rellenar el espacio declarado arriba y que no se quede vacío.
            int giga = 0;
            Random ALEATORIO = new Random();



            while (true)
            {
                Console.WriteLine("\n\n¿Que quieres hacer?\n1) Crear una nueva lista de Bosses\n2) Actualizar la existente\n3) Convertir la lista existente en archivo\n4) Mostrar la lista\n5) Mostrar Boss aleatorio\nOtro) Salir");
                string Cosita = Console.ReadLine(); 
                string Condicion = "Si";
                Console.Clear();
                switch (Cosita)
                {
                    case "1":
                        while (Condicion == "Si") //He puesto por si acaso varias formas de escribir Si, para que a la gente no le den embolias
                        {
                            Console.WriteLine("¿Es Gigamax o Dinamax?");
                            Condicion = Console.ReadLine();
                            if (Condicion == "Gigamax" || Condicion == "gigamax" || Condicion == "giga" || Condicion == "Giga" || Condicion == "GIGA" || Condicion == "GIGAMAX") //Same here que con si
                            {
                                if (giga == 0) //Aqui mira si es la primera vez que se crea un Gigamax
                                {
                                    Console.WriteLine("\n\nIntroduce el nombre: ");
                                    NombreGiga.AppendChild(Bosses.CreateTextNode(Console.ReadLine()));
                                    Console.WriteLine("\nIntroduce su CR: ");
                                    CRgiga.AppendChild(Bosses.CreateTextNode(Console.ReadLine()));
                                    giga++;
                                }
                                else
                                {
                                    Gigamax = Bosses.CreateElement("Gigamax");
                                    raiz.AppendChild(Gigamax);
                                    Console.WriteLine("\n\nIntroduce el nombre: ");
                                    NombreGiga = Bosses.CreateElement("Nombre");
                                    Gigamax.AppendChild(NombreGiga);
                                    NombreGiga.AppendChild(Bosses.CreateTextNode(Console.ReadLine()));
                                    Console.WriteLine("\nIntroduce su CR: ");
                                    CRgiga = Bosses.CreateElement("CR");
                                    Gigamax.AppendChild(CRgiga);
                                    CRgiga.AppendChild(Bosses.CreateTextNode(Console.ReadLine()));
                                }

                            }
                            else if (Condicion == "Dinamax" || Condicion == "dinamax" || Condicion == "dina" || Condicion == "Dina" || Condicion == "DINA" || Condicion == "DINAMAX") //Same here que con si
                            {
                                if (dina == 0) //Aqui mira si es la primera vez que se crea un Dinamax
                                {
                                    Console.WriteLine("\n\nIntroduce el nombre: ");
                                    NombreDina.AppendChild(Bosses.CreateTextNode(Console.ReadLine()));
                                    Console.WriteLine("\nIntroduce su CR: ");
                                    CRdina.AppendChild(Bosses.CreateTextNode(Console.ReadLine()));
                                    dina++;
                                }
                                else
                                {
                                    Dinamax = Bosses.CreateElement("Dinamax");
                                    raiz.AppendChild(Dinamax);
                                    Console.WriteLine("\n\nIntroduce el nombre: ");
                                    NombreDina = Bosses.CreateElement("Nombre");
                                    Dinamax.AppendChild(NombreDina);
                                    NombreDina.AppendChild(Bosses.CreateTextNode(Console.ReadLine()));
                                    Console.WriteLine("\nIntroduce su CR: ");
                                    CRdina = Bosses.CreateElement("CR");
                                    Dinamax.AppendChild(CRdina);
                                    CRdina.AppendChild(Bosses.CreateTextNode(Console.ReadLine()));
                                }

                            }
                            else
                            {
                                Console.WriteLine("No has utilizado un tipo especificado");
                            }
                            Console.WriteLine("¿Quieres continuar o salir?\nIntroduce Si para empezar o cualquier botón para salir");
                            Condicion = Console.ReadLine();
                        }
                        Bosses.Save("d:\\xml\\Bosses.xml");
                        Console.WriteLine("{0}",NumeroTotal);
                        for (int a = 0; NumeroTotal > a; NumeroTotal--)
                        {
                            BossList.RemoveAt(a);
                        }
                        foreach (Boss FB in BossList)
                        {
                            NumeroTotal++;
                        }
                        for (int j = 0; j < Lector.DocumentElement.ChildNodes.Count; j++)
                        {
                            XmlNode node = Lector.DocumentElement.ChildNodes[j];
                            if (node.HasChildNodes)
                            {
                                Boss boss = new Boss();

                                for (int i = 0; i < node.ChildNodes.Count; i++)
                                {

                                    boss.TYPE = node.Name;

                                    if (node.ChildNodes[i].Name == "Nombre" && node.ChildNodes[i].InnerText != null)
                                    {
                                        boss.NAME = node.ChildNodes[i].InnerText;
                                    }
                                    else if (node.ChildNodes[i].Name == "CR" && node.ChildNodes[i].InnerText != null)
                                    {
                                        try
                                        {
                                            boss.ChallengeRate = Convert.ToInt32(node.ChildNodes[i].InnerText);
                                        }
                                        catch (Exception) { Console.WriteLine("No se ha podido añadir"); }
                                    }

                                    Console.WriteLine("{0}", node.Name);
                                    Console.WriteLine(node.ChildNodes[i].Name + ": " + node.ChildNodes[i].InnerText);


                                }
                                if (boss.ChallengeRate != 0) BossList.Add(boss);
                            }
                        }
                        break;
                    case "2":
                        f = 1;
                        while (f == 1 || f == 2 || f== 3)
                        {
                            Console.WriteLine("¿Quieres añadir, borrar o editar?\n1) Añadir\n2) Borrar\n3) Editar\nOtro) Nada");
                            f = Convert.ToInt32(Console.ReadLine());
                            if (f == 1)
                            {

                                BossList.Add(new Boss());
                                Console.WriteLine("Introduce el tipo [Debe ser Gigamax o Dinamax]");
                                BossList[NumeroTotal].TYPE = Console.ReadLine();
                                Console.WriteLine("Introduce el nombre");
                                BossList[NumeroTotal].NAME = Console.ReadLine();
                                Console.WriteLine("Introduce la CR");
                                BossList[NumeroTotal].ChallengeRate = Convert.ToInt32(Console.ReadLine());
                                NumeroTotal++;
                            }
                            else if (f == 2)
                            {
                                Console.WriteLine("Introduce el nombre del Boss: ");
                                Condicion = Console.ReadLine();
                                for (f = 0; f<NumeroTotal;f++)
                                {
                                    if (BossList[f].NAME == Condicion)
                                    {
                                        Console.WriteLine("El Boss {0} de tipo {1} y CR {2} ha sido borrado", BossList[f].NAME, BossList[f].TYPE, BossList[f].ChallengeRate);
                                        BossList.RemoveAt(f);
                                        NumeroTotal--;
                                    }
                                }
                                f = 2;
                            }
                            else if (f == 3)
                            {
                                Console.WriteLine("Introduce el nombre del Boss: ");
                                Condicion = Console.ReadLine();
                                for (f = 0; f < NumeroTotal; f++)
                                {
                                    if (BossList[f].NAME == Condicion)
                                    {
                                        Console.WriteLine("¿Quieres cambiar su tipo?\nSi[1] No[Otro]");
                                        if (Convert.ToInt32(Console.ReadLine()) == 1)
                                        {
                                            Console.WriteLine("Introduce el tipo [Debe ser Gigamax o Dinamax]");
                                            BossList[f].TYPE = Console.ReadLine();
                                        }
                                        Console.WriteLine("¿Quieres cambiar su Nombre?\nSi[1] No[Otro]");
                                        if (Convert.ToInt32(Console.ReadLine()) == 1)
                                        {
                                            Console.WriteLine("Introduce el nombre");
                                            BossList[f].NAME = Console.ReadLine();
                                        }
                                        Console.WriteLine("¿Quieres cambiar su CR?\nSi[1] No[Otro]");
                                        if (Convert.ToInt32(Console.ReadLine()) == 1)
                                        {
                                            Console.WriteLine("Introduce la CR");
                                            BossList[f].ChallengeRate = Convert.ToInt32(Console.ReadLine());
                                        }
                                    }
                                }
                                f = 3;
                            }
                            else
                            {

                            }
                        }
                        
                        break;
                    case "3":
                        
                        foreach(Boss Expulsar in BossList)
                        {
                            if(giga==0 && Expulsar.TYPE == "Gigamax")
                            {
                                NombreGiga.AppendChild(Bosses.CreateTextNode(Expulsar.NAME));
                                CRgiga.AppendChild(Bosses.CreateTextNode(Convert.ToString(Expulsar.ChallengeRate)));
                                giga++;
                            }
                            else if (dina == 0 && Expulsar.TYPE == "Dinamax")
                            {
                                NombreDina.AppendChild(Bosses.CreateTextNode(Expulsar.NAME));
                                CRdina.AppendChild(Bosses.CreateTextNode(Convert.ToString(Expulsar.ChallengeRate)));
                                dina++;
                            }
                            else if(giga>0 && Expulsar.TYPE == "Gigamax")
                            {
                                Gigamax = Bosses.CreateElement("Gigamax");
                                raiz.AppendChild(Gigamax);
                                
                                NombreGiga = Bosses.CreateElement("Nombre");
                                Gigamax.AppendChild(NombreGiga);
                                NombreGiga.AppendChild(Bosses.CreateTextNode(Expulsar.NAME));
                                
                                CRgiga = Bosses.CreateElement("CR");
                                Gigamax.AppendChild(CRgiga);
                                CRgiga.AppendChild(Bosses.CreateTextNode(Convert.ToString(Expulsar.ChallengeRate)));
                            }
                            else if(dina>0 && Expulsar.TYPE == "Dinamax")
                            {
                                Dinamax = Bosses.CreateElement("Dinamax");
                                raiz.AppendChild(Dinamax);
                                
                                NombreDina = Bosses.CreateElement("Nombre");
                                Dinamax.AppendChild(NombreDina);
                                NombreDina.AppendChild(Bosses.CreateTextNode(Expulsar.NAME));
                                
                                CRdina = Bosses.CreateElement("CR");
                                Dinamax.AppendChild(CRdina);
                                CRdina.AppendChild(Bosses.CreateTextNode(Convert.ToString(Expulsar.ChallengeRate)));
                            }

                        }
                        Bosses.Save("d:\\xml\\Bosses.xml");
                        break;
                    case "4":
                        foreach (Boss FB in BossList)
                        {
                            FB.BossInfo();
                        }
                        break;
                    case "5":
                        int aleatorio = ALEATORIO.Next(0, NumeroTotal+1);
                        BossList[aleatorio].BossInfo();
                        break;
                    default:
                        Environment.Exit(0); 
                        break;
                }
                
            }
             
            
            

            //Bosses.Save("d:\\xml\\Bosses.xml"); //Y aquí se guarda el archivo xml, es probable que tengas que editar esto para que funcione.
            

        }
    }
}
