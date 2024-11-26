public class Cafetera
{
    int cantidadCafe;

    public void setCantidadDeCafe(int cantidadCafe){
        this.cantidadCafe = cantidadCafe;
    }

    public int getCantidadDeCafe(){
        return this.cantidadCafe;
    }

    public bool hasCafe(int cantidadCafe){
        return this.cantidadCafe >= cantidadCafe;
    }

    public void giveCafe(int cantidadCafe){
        this.cantidadCafe -= cantidadCafe;
    }
}