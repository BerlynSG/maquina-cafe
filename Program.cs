Maquina maquina = new Maquina();
// See https://aka.ms/new-console-template for more information
bool exit = false;
while(!exit){
    Console.WriteLine("¿Qué tipo de vasos quieres?");
    Console.WriteLine("  1: Pequeño");
    Console.WriteLine("  2: Mediano");
    Console.WriteLine("  3: Grande");
    int tipo = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("¿Cuantos vasos quieres?");
    int vasos = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("¿Cuantos gramos de azucar quieres?");
    int azucar = Convert.ToInt32(Console.ReadLine());

    Dictionary<string, string> cafeServido = maquina.getVasoDeCafe(tipo, vasos, azucar);
    
    if (cafeServido.TryGetValue("error", out var error)){
        Console.WriteLine("Error: " + error);
    }else{
        Console.WriteLine("  Se ha completado con exito");
        Console.WriteLine("  Café total: " + cafeServido["cafe"] + " Oz");
        Console.WriteLine("  Catidad de Azúcar: " + cafeServido["azucar"] + " Oz");
        Console.WriteLine("  Cantidad de Vasos: " + cafeServido["vasos"]);
        Console.WriteLine("  -----------------------");
        Console.WriteLine("  Por Unidad:");
        switch (cafeServido["tipo"])
        {
            case "1":
                Console.WriteLine("    Tipo de vaso: Pequeño");
                break;
            case "2":
                Console.WriteLine("    Tipo de vaso: Mediano");
                break;
            case "3":
                Console.WriteLine("    Tipo de vaso: Grande");
                break;
        }
        Console.WriteLine("    Cantidad de Café: " + cafeServido["cafeUnidad"] + " Oz");
        Console.WriteLine("    Cantidad de Azúcar: " + cafeServido["azucarUnidad"] + " Oz");
    }


    Console.WriteLine("¿Quieres hacer otro pedido?");
    List<string> confList = new List<string>() {"1", "sí", "si", "s"};
    string? conf = Console.ReadLine();
    if (conf != null){
        exit = !confList.Contains(conf.ToLower());
    }
}
