class Mayor{
    public int numero1;
    public int numero2;
    public void IngresarNumero(){
        Console.WriteLine("Ingrese el primer número");
        numero1=Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo número");
        numero2=Convert.ToInt16(Console.ReadLine());
        
        if (numero1>numero2){
            Console.WriteLine("El número mayor es: "+numero1);
        }else{
            Console.WriteLine("El número mayor es: "+numero2);
        }
    } 
}