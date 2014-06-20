
package mst_java.library;


import java.util.ArrayList;
import java.util.Random;

public class Graph{
    private ArrayList<Node> _nodeList;
    private Random _random;

    public Graph(){
        _nodeList = new ArrayList<Node>();
        _random = new Random();
    }
    public void addNode(Node pNode){
        _nodeList.add(pNode);
    }
    public void createEdges(Object nombreNodoPadre,Object nombreNodoHijo){
        Node _father = searchNode(nombreNodoPadre);      
        Node son = searchNode(nombreNodoHijo);
        if(_father != null && son != null){
            _father.setNode(son, _random.nextInt(10) + 4 );
        }
    }
    public Node searchNode(Object nodeName){
        Node temp = null;
        for(int i = 0;i < _nodeList.size(); i++){
            if(((String)nodeName).equals((String)_nodeList.get(i).getDato())){
                return _nodeList.get(i);
            }
        }
        return temp;
    }
}
