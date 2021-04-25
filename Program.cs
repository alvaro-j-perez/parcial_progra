using System;
// HECHO POR ALVARO JOSUE PEREZ GOMEZ
//CARNE 0907-20-22218

namespace Parcial
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario[] lista = new Usuario[15];
            Usuario usuario = new Usuario(null,null,0);
            Peliculas[] lista2 = new Peliculas[15];
            Peliculas peliculas = new Peliculas(null,null,null,null);
            registro registro = new registro(null,null,0);
            registro[] lista3 = new registro[30];
            string[] listaprueba = new string[10];
            int contador = 0;          
            int resultado = 0;
            int operacion = 0;
            int numero = 1 ;
            int valor = 0;
            int contar = 0;
            int num = 1;
            int sumatoria = 0;
            Console.WriteLine("=============================");
            Console.WriteLine("BIENVENIDOS A NECFLIS ");
            while(resultado!=3){
            Console.WriteLine("=============================");
            Console.WriteLine("Selecione una de las opciones");
            Console.WriteLine("[1]. clientes");
            Console.WriteLine("[2]. peliculas");
            Console.WriteLine("[3]. Salir");
            Console.WriteLine("=============================");

            resultado=Convert.ToInt32(Console.ReadLine());
            switch(resultado){
                case 1:
                    while(operacion!=4){
                        Console.WriteLine("=============================");
                        Console.WriteLine("          Usuarios");
                        Console.WriteLine("Escoja uno de los valores");
                        Console.WriteLine("[1]. ver listado");
                        Console.WriteLine("[2]. crear cliente");
                        Console.WriteLine("[3]. selecionar cliente");
                        Console.WriteLine("[4]. salir");
                        Console.WriteLine("=============================");

                        operacion=Convert.ToInt32(Console.ReadLine());
                        switch(operacion){
                            case 1:   
                                Console.WriteLine("=============================");
                                Console.WriteLine("      Lista de Usuarios");
                    
                                for (int i = 0; i < contador; i++)
                                {
                                    usuario = lista[i];
                                    Console.WriteLine("["+numero +"]. " + usuario.nombre);
                                    numero++;
                                }
                                numero= 1;
                                Console.WriteLine("=============================");

                            break;
                            case 2:
                                usuario = new Usuario();
                                lista[contador] = usuario;
                                contador++;                   
                            break;

                            case 3:
                                Console.WriteLine("================================");
                                Console.WriteLine("Ingresar el numero del cliente");
                                int valor1 = Int32.Parse(Console.ReadLine());
                                Usuario usuario1 = lista[valor1 -1];
                                Console.WriteLine("      Informacion general");
                                Console.WriteLine(" ");
                                Console.WriteLine("Nombre: "+ usuario1.nombre);
                                Console.WriteLine("Direccion: " + usuario1.direccion);
                                Console.WriteLine("Edad: " + usuario1.edad);
                                Console.WriteLine("=============================");

                                while(true){
                                Console.WriteLine("=============================");
                                Console.WriteLine("Escoja una de las opciones");
                                Console.WriteLine("[1]. Playlist");
                                Console.WriteLine("[2]. Agregar pelicula");
                                Console.WriteLine("[3]. Atras");
                                Console.WriteLine("=============================");
                                int indice = Int32.Parse(Console.ReadLine());
                                


                                if (indice ==1){
                                    for (int i = 0; i < sumatoria; i++)
                                    {
                                    string valores = registro.lista[i];
                                    Console.WriteLine( num +" " + valores);
                                    num++;
                                    }
                                    num = 1;
                                    
                                }
                                if (indice ==2){
                                    while(true){
                                    Console.WriteLine("=============================");
                                    Console.WriteLine("     Lista de Peliculas");
                                    for (int i = 0; i < contar; i++)
                                    {
                                        peliculas = lista2[i];
                                        Console.WriteLine( num +" " + peliculas.nombre);
                                        num++;
                                    }
                                    num = 1;
                                    Console.WriteLine("=============================");
    
                                    Console.WriteLine("Escoja la pelicula que desea agregar");
                                    int escojer = Int32.Parse(Console.ReadLine());
                                    if(escojer==0){

                                        registro = new registro(usuario1.nombre,listaprueba);
                                        break;
                                        
                                    }
                                    
                                    else{
                                        peliculas = lista2[escojer-1];
                                        string peli = peliculas.nombre; 
                                        registro =new registro(usuario1.nombre,peli,sumatoria);
                                        lista3[sumatoria] = registro;
                                        sumatoria++;

                                    }

                                    for (int i = 0; i < sumatoria; i++)
                                    {
                                        registro=lista3[i];
                                        listaprueba[i] = registro.peliculas_usuario;
                                    }

                                    }

                                }
                                if (indice ==3){
                                    break;
                                }
                                else{
                                    Console.WriteLine("Escoja uno de los valores");
                                }
                                }


                            break; 
                            case 4:
                               Console.WriteLine("Gracias por entrar");
                            break;                   
                            default:
                                Console.WriteLine("Escoja una de las opciones");
                            break;
                            }
                    }

                    break;
                case 2:
                    while(valor!=3){
                        Console.WriteLine("=============================");
                        Console.WriteLine("          Peliculas");
                        Console.WriteLine("Escoja una de las opciones");
                        Console.WriteLine("[1]. Ver peliculas");
                        Console.WriteLine("[2]. Agregar peliculas");
                        Console.WriteLine("[3]. Salir");
                        Console.WriteLine("=============================");

                        valor = Int32.Parse(Console.ReadLine());
                        switch(valor){
                            case 1: 
                           Console.WriteLine("=============================");
                           Console.WriteLine("      Lista de peliculas");
                                for (int i = 0; i < contar; i++)
                                {
                                    peliculas = lista2[i];
                                    Console.WriteLine( num +" " + peliculas.nombre);
                                    num++;
                                }
                                num = 1;
                            break;

                            case 2:
                                peliculas = new Peliculas();
                                lista2[contar] = peliculas;
                                contar++; 
                            break;

                            case 3:
                                Console.WriteLine("Gracias por entrar");
                            break;
                            default:
                                Console.WriteLine("Escoja una de las opciones");
                            break;
                        }
                    }
                    break;
                case 3:

                    Console.WriteLine("Gracias por usar el programa");

                    break;
                default:
                    Console.WriteLine("Escoja uno de los valores");

                    break;
                }
            }
        }
    }

    class Usuario{
        public string nombre;
        public string direccion;
        public int edad;

        public Usuario(string nombre, string direccion, int edad){
            this.nombre = nombre;
            this.direccion = direccion;
            this.edad = edad;
        }
        public Usuario(){
            Console.WriteLine("===============================");
            Console.WriteLine("Escriba el nombre del usuario");
            nombre = Console.ReadLine();
                                            
            Console.WriteLine("Escriba la direcion del cliente");
            direccion = Console.ReadLine();

            Console.WriteLine("Escriba la edad del cliente");
            edad=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("===============================");

        }
    }
    class Peliculas{
        public string nombre;
        public string tipo;
        public string genero;
        public string sinopsis;
        public Peliculas(string nombre, string tipo, string genero, string sinopsis){
            this.nombre = nombre;
            this.tipo = tipo;
            this.genero = genero;
            this.sinopsis = sinopsis;
        }

        public Peliculas(){
            Console.WriteLine("escriba el nombre de la pelicula");
            nombre = Console.ReadLine();
            Console.WriteLine("Escoja el tipo de pelicula");
            Console.WriteLine("Serie");
            Console.WriteLine("Pelicula");
            tipo = Console.ReadLine();
            Console.WriteLine("escoja el genero de la pelicula");
            Console.WriteLine("drama");
            Console.WriteLine("comedia");
            Console.WriteLine("terror");
            Console.WriteLine("suspenso");
            genero =Console.ReadLine();
            Console.WriteLine("escriba la sinopsis de la pelicula");
            sinopsis = Console.ReadLine();

        }
    }

    class registro{
        public string nombre_usuario;

        public string peliculas_usuario;

        public int cantidad;

        public string[] lista;
        public registro(string nombre_usuario, string peliculas_usuario, int cantidad){
            this.nombre_usuario = nombre_usuario;
            this.peliculas_usuario =  peliculas_usuario;       
            this.cantidad = cantidad;     
        }

        public registro(string nombre_usuario,string[] lista){
            this.nombre_usuario = nombre_usuario;
            this.lista = lista;
        }
        
    }
}

