
package mst_java.library;


import java.util.ArrayList;
public class Node
{
    private Object dato;
    private ArrayList<Edge> _edges;
    private boolean _visited = false;

    public Node(){
        this(new Object());
    }
    public Node(Object dato){
        this.dato = dato;
        _edges = new ArrayList<Edge>();
    }
    public void setDato(Object dato){
        this.dato = dato;
    }
    public Object getDato(){
        return this.dato;
    }
    public void setNode(Node pNode, int pWeight){
        this._edges.add(new Edge(pNode, pWeight));
    }
    public ArrayList<Edge> getSons(){
        return _edges;
    }

    public boolean isVisited() {
        return _visited;
    }

    public void setVisited(boolean _visited) {
        this._visited = _visited;
    }
    
    
}