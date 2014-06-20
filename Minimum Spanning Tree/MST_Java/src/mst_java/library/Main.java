package mst_java.library;

import mst_java.Logic.Recorrido;


public class Main{
    static Graph grafo;
    
    public static void llenandoGrafo(){
        grafo = new Graph();
        
        grafo.addNode(new Node("A"));
        grafo.addNode(new Node("B"));      
        grafo.addNode(new Node("C"));
        grafo.addNode(new Node("D"));
        grafo.addNode(new Node("F"));
       
        grafo.createEdges("A","B");// de A hacia B
        grafo.createEdges("B","A");// de B hacia A
        /*
         * Lo anterior lo hacemos por ser un grafo no dirigido...
         * En caso de ser un grafo con peso esto no estaria muy bien que digamos
        */
        
        grafo.createEdges("A","C");
        grafo.createEdges("C","A");
        
        grafo.createEdges("A","F");
        grafo.createEdges("F","A");
        
//        grafo.crearEnlaces("B","A");//Esta enlace ya existe
//        grafo.crearEnlaces("A","B");//Esta enlace ya existe
        
        grafo.createEdges("B","F");
        grafo.createEdges("F","B");
        
//        grafo.crearEnlaces("C","A");//Esta enlace ya existe
//        grafo.crearEnlaces("A","C");//Esta enlace ya existe
        
        grafo.createEdges("C","D");
        grafo.createEdges("D","C");
        
//        grafo.crearEnlaces("D","C");//Esta enlace ya existe
//        grafo.crearEnlaces("C","D");//Esta enlace ya existe
        
//        grafo.crearEnlaces("F","A");//Esta enlace ya existe
//        grafo.crearEnlaces("A","F");//Esta enlace ya existe
        
//        grafo.crearEnlaces("F","B");//Esta enlace ya existe
//        grafo.crearEnlaces("B","F");//Esta enlace ya existe
 
    }
    
    
    public static void main(String []args){        
        
        llenandoGrafo();
        
        Recorrido recorrido = new Recorrido();
        System.out.println("----------------------------------------------");
        System.out.println("Recorrido en profundidad");   
        recorrido.recorrerProfundidadIterativo(grafo,grafo.searchNode("A"));
        System.out.println();
        
        llenandoGrafo();
        
        System.out.println("----------------------------------------------");
        System.out.println("Recorrido en Amplitud");        
        recorrido.recorrerAmplitud(grafo,grafo.searchNode("A"));
        System.out.println();
        System.out.println("----------------------------------------------");        
    }
}
