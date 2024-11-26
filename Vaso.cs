public class Vaso
{
    int cantidadVasos;
    int contenido;

    public void setCantidadVasos(int cantidadVasos){
        this.cantidadVasos = cantidadVasos;
    }

    public int getCantidadVasos(){
        return cantidadVasos;
    }

    public void setContenido(int contenido){
        this.contenido = contenido;
    }

    public int getContenido(){
        return contenido;
    }
    
    public bool hasVaso(int cantidadVasos){
        return this.cantidadVasos >= cantidadVasos;
    }

    public void giveVaso(int cantidad){
        cantidadVasos -= cantidad;
    }
}