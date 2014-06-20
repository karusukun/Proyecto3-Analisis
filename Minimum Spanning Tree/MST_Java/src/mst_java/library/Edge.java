/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package mst_java.library;

/**
 *
 * @author Karusu
 */
public class Edge {
    
    private Node _node;
    private int _weight;

    public Edge(Node pNode, int pWeight) {
        this._node = _node;
        this._weight = pWeight;
    }
    
    

    public Node getNode() {
        return _node;
    }

    public int getWeight() {
        return _weight;
    }

    public void setNode(Node _node) {
        this._node = _node;
    }

    public void setWeight(int pWeight) {
        this._weight = pWeight;
    }
    
    
    
}
