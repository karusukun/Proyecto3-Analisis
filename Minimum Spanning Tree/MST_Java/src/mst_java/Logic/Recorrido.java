
package mst_java.Logic;

import mst_java.library.Cola;
import mst_java.library.Graph;
import mst_java.library.Node;
import mst_java.library.Pila;


public class Recorrido{
    private Pila pila;
    private Cola cola;

    public Recorrido(){
        pila = new Pila();
        cola = new Cola();
    }
    private void llenarPilaNodosAdyacentes(Node nodo){
        for(int i = 0; i < nodo.getSons().size();i++){
            if(!nodo.getSons().contains(nodo)){                
                pila.addNodo(nodo.getSons().get(i).getNode());
            }
        }
    }
    private void llenarColaNodosAdyacentes(Node nodo){
        for(int i = 0; i < nodo.getSons().size();i++){
            if(!nodo.getSons().contains(nodo)){                
                cola.addNodo(nodo.getSons().get(i).getNode());
            }
        }
    }
    
    public void recorrerProfundidadIterativo(Graph grafo,Node nodoInicio){
        if(grafo != null && nodoInicio != null){
            pila.addNodo(nodoInicio);
            while(pila.size() > 0){
                Node nodoVisitado = pila.getNodo();
                if(nodoVisitado.isVisited() == false){
                    nodoVisitado.setVisited(true);
                    System.out.print(nodoVisitado.getDato()+",");                
                    llenarPilaNodosAdyacentes(nodoVisitado);
                }
            }
        }
    }
    public void recorrerAmplitud(Graph grafo,Node nodoInicio){
        if(grafo != null && nodoInicio != null){
            cola.addNodo(nodoInicio);
            while(cola.size() > 0){
                Node nodoVisitado = cola.getNodo();
                if(nodoVisitado.isVisited() == false){
                    nodoVisitado.setVisited(true);
                    System.out.print(nodoVisitado.getDato()+",");                
                    llenarColaNodosAdyacentes(nodoVisitado);
                }
            }           
        }        
    }
}
