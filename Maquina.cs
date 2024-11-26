public class Maquina
{
    Cafetera cafe = new Cafetera();
    Vaso vasosPequenos = new Vaso();
    Vaso vasosMedianos = new Vaso();
    Vaso vasosGrandes = new Vaso();
    Azucarero azucar = new Azucarero();

    public Maquina() {
        cafe.setCantidadDeCafe(20);
        vasosPequenos.setCantidadVasos(10);
        vasosPequenos.setContenido(3);
        vasosMedianos.setCantidadVasos(10);
        vasosMedianos.setContenido(5);
        vasosGrandes.setCantidadVasos(10);
        vasosGrandes.setContenido(7);
        azucar.setCantidadDeAzucar(20);
    }

    public Vaso? getTipoVaso(int tipoDeVaso){
        if(tipoDeVaso == 1){
            return vasosPequenos;
        }
        else if(tipoDeVaso == 2){
            return vasosMedianos;
        }
        else if(tipoDeVaso == 3){
            return vasosGrandes;
        }
        else{
            return null;
        }
    }

    public Dictionary<string, string> getVasoDeCafe(int tipoDeVaso, int cantidadDeVasos, int cantidadDeAzucar){
        Vaso? vaso = getTipoVaso(tipoDeVaso);
        if (vaso == null)
            return new Dictionary<string, string>() {{"error", "No existe ese tipo de vaso"}};
        int cafeUnidad = vaso.getContenido();
        if (vaso.hasVaso(cantidadDeVasos)){
            if (cafe.hasCafe(cafeUnidad * cantidadDeVasos)){
                vaso.giveVaso(cantidadDeVasos);
                cafe.giveCafe(cafeUnidad * cantidadDeVasos);
            }
            else
                return new Dictionary<string, string>() {{"error", "No hay suficiente cafe"}};
        }
        else
            return new Dictionary<string, string>() {{"error", "No hay suficiente vasos"}};

        if (azucar.hasAzucar(cantidadDeAzucar)){
            azucar.giveAzucar(cantidadDeAzucar);
        }
        else
            return new Dictionary<string, string>() {{"error", "No hay suficiente azucar"}};
        
        return new Dictionary<string, string>() {
            {"cafe", (cafeUnidad * cantidadDeVasos).ToString()},
            {"cafeUnidad", cafeUnidad.ToString()},
            {"azucar", cantidadDeAzucar.ToString()},
            {"azucarUnidad", (cantidadDeAzucar / cantidadDeVasos).ToString()},
            {"vasos", cantidadDeVasos.ToString()},
            {"tipo", tipoDeVaso.ToString()}
        };
    }
}