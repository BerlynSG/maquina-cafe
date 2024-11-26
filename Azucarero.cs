public class Azucarero
{
    int cantidadAzucar;

    public void setCantidadDeAzucar(int cantidadAzucar){
        this.cantidadAzucar = cantidadAzucar;
    }

    public int getCantidadDeAzucar(){
        return this.cantidadAzucar;
    }

    public bool hasAzucar(int cantidadAzucar){
        return this.cantidadAzucar >= cantidadAzucar;
    }

    public void giveAzucar(int cantidadAzucar){
        this.cantidadAzucar -= cantidadAzucar;
    }
}