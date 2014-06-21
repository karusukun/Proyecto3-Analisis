
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
    public void createEdges(Node NodoPadre,Node NodoHijo){
        Node _father = searchNode(NodoPadre);      
        Node son = searchNode(NodoHijo);
        if(_father != null && son != null){
            _father.setNode(son, _random.nextInt(10) + 4 );
        }
    }
    public Node searchNode(Node nodeName){
        Node temp = null;
        for(int position = 0;position < _nodeList.size(); position++){
            if(nodeName.equals(_nodeList.get(position))){
                return _nodeList.get(position);
            }
        }
        return temp;
    }
    
    public void generateGraph(int pSize)
    {        
        if(pSize > 200 || pSize <= 0 )
            return;
        else
        {
            for(int nodeAmmount = 1; nodeAmmount <= pSize; nodeAmmount++)
            {
                Node newNode = new Node();
                addNode(newNode);
                int edgesNumber = _random.nextInt(3);
                
                for(int edgesAdded = 0; edgesAdded < edgesNumber; edgesAdded++)
                {
                    Node tempNode = _nodeList.get(_random.nextInt(_nodeList.size()));
                    
                    while(!newNode.containsNode(tempNode))
                    {
                        tempNode = _nodeList.get(_random.nextInt(_nodeList.size()));
                    }
                    
                    createEdges(newNode, tempNode);
                    
                }
              
            }            
        }
    }
}
