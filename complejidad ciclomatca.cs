using System;
using System.Collections.Generic;
using System.Text;

namespace TallerComplejidad
{

    class Punto7
    {
        static void Main(string[] args)
        {
            int a = 20;
            int b = 25;
            if (a > b)
            {
                Console.WriteLine("A es mayor que B");
            }
            else if (a==b)
            {
                Console.WriteLine("A es igual a B");
            }
            else
            {
                Console.WriteLine("A es menor que B");
            }
        }
    }

    class Punto8
    {
        static void Main(string[] args)
        {
            Boolean a=true, b=true, c=true, d=true, e=true ;
            int x;
            if (a && b)
            {
                x = 0;
            }
            if(a && !b && c)
            {
                x = 1;
            }
            if(a && !b && !c)
            {
                x = 3;
            }
            if(!a)
            {
                x = 4;
            }
            if(!a && d && e)
            {
                x = 5;
            }
            if (!a && d && !e)
            {
                x = 6;
            }
            if(!a && !d)
            {
                x = 7;
            }

        }

    }

    class Punto9
    {
         static void Main(string[] args)
        {
        if ((y<a)^((a<b)^(b<c)))
        {
            x=0;
        }
        else
        {
            if((a<=y)^(y<b))
            {
                x=1;
            }
            else
            {
                if((b<=y)^(y<c))
                {
                    x=2;
                }
                else
                {
                    if((c<=y))
                    {
                        x=3;
                    }
                    else
                    {
                        x=4;
                    }
                }
            }
        }

        }
    }

    
    class Punto10
    {
        static void Main(string[] args)
        {
            int ni, est;
            String nom;
            float pat, pagmant=50000;

            Console.WriteLine("Introduzca el número de la inscripción: ");
            ni = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca su nombre: ");
            nom = Console.ReadLine();
            
            Console.WriteLine("Introduzca su patrimonio: ");
            pat = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca su estreato social: ");
            est = Convert.ToInt32(Console.ReadLine());

            if (pat>2000000)^(est>3)
            {      
                pagmant= pagmant+0.03*pat;
            }

            console.WriteLine("El estudiante con número de inscripción" + ni + "y nombre:" + nom + "debe pagar: $" + pagmant)
            
        }
    }

    
    class Punto11
    {

        static void main (string[] args)
        {
            int n1,n2,n3,mayor;

            Console.WriteLine("Introduzca el primer número: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca el segundo número: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca el tercer número: ");
            n3 = Convert.ToInt32(Console.ReadLine());

            if((n1>n2)^(n1>n3))
            {
                mayor=n1;
            }
            else
            {
                if(n2>n3)
                {
                    mayor=n2;
                }
                else
                {
                    mayor=n3;
                }
            }

            console.WriteLine("El valor mayor entre: " + n1 + n2 + "y " + n3 "es: " + mayor)
        
        }

    }

    class Punto12
    {
        static void Main(string[] args)
        {
        string nom;
        int nht, het, hee8;
        float vhn, salario;


        Console.WriteLine("Introduzca su nombre: ");
        nom = Console.ReadLine();


        Console.WriteLine("Introduzca el número de horas trabajadas: ");
        nht = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduzca el número de horas trabajadas: ");
        vhn = Convert.float(console.ReadLine());

        if(nht>40)
        {
            het=nht - 40;

            if(het>8)
            {
                hee8=het-8
                salario=40*vhn+16*vhn+hee8*3*vhn;
            }
            else
            {
                salario=40*vhn+het*2*vhn;
            }
        
        else
        {
            salario=nht*vhn;    
        }

        }

        console.WriteLine("El trabajador" + nom + "devengo: $ " + salario)
        }
    }

    class Punto13
    {
        static void main(string[] args)
        {

            fload valcomp, valpag, pdes;
            string color;

            Console.WriteLine("Introduzca el valor de la compra: ");
            valcomp = Convert.float(console.ReadLine());

            Console.WriteLine("Introduzca el color: ");
            color = Console.ReadLine();

            if(color="blanco")
            {
                pdes=0;
            }
            else
            {
                if(color="verde")
                {
                    pdes=10;
                }
                else
                {
                    if(color="amarillo")
                    {
                        pdes=25;
                    }
                    else
                    {
                        if(color="azul")
                        {
                            pdes=50;
                        }
                        else
                        {
                            pdes=100;
                        }
                    }
                }
            }

            valpag =valcomp - pdes*valcomp/100
            console.WriteLine("El cliente debe pagar: $ " + valpag)
        }
    }
}
