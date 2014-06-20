
package mst_java.library;

import java.util.ArrayList;
public class Cola extends ArrayList{
    public Cola(){
        super();  
    }
    public void addNodo(Node nodo){
        if(!this.contains(nodo) && nodo.isVisited() != true){
            add(nodo);
            System.out.println();
            mostrarContenido();
        }
    }
    public Node getNodo(){
        Node nodoTemp = null;
        if(!this.isEmpty() && this != null){
            nodoTemp = (Node)this.get(0);
            this.remove(0);
        }
        return nodoTemp;
    }
    public void mostrarContenido(){
        System.out.print("[");
        for(int i = 0;i < this.size();i++){
            System.out.print(((Node)this.get(i)).getDato());
        }
        System.out.print("]");        
    }    
}
