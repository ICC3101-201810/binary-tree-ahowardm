using System;

namespace binary_tree{
  class Node<T>
  {
    Node<T> hijoIzquierdo;
    Node<T> hijoDerecho;
    Node<T> padre;
    T valor;

    // Crea un nodo con valor y nodos hijos. No se debiera usar nunca.
    public Node(T valor, Node<T> hijoIzquierdo, Node<T> hijoDerecho)
    {
      this.valor = valor;
      this.hijoIzquierdo = hijoIzquierdo;
      this.hijoDerecho = hijoDerecho;
      this.padre = null;
    }

    // Crea un nodo con un valor (se puede usar para declarar el primer nodo
    public Node(T valor){
      this.valor = valor;
      hijoIzquierdo = null;
      hijoDerecho = null;
    }

    // Crea un nodo hijo del actual con valor
    public Node(T valor, Node<T> padre)
    {
      this.valor = valor;
      hijoIzquierdo = null;
      hijoDerecho = null;
      this.padre = padre;
    }

    public Boolean AgregaInfo(T valor){
      if (hijoIzquierdo == null)
      {
        try{
          hijoIzquierdo = new Node<T>(valor, this);
          return true; 
        }
        catch (Exception){
          return false;
        }
      }
      else if (hijoDerecho == null)
      {
        try{
          hijoDerecho = new Node<T>(valor, this);
          return true;
        }
        catch(Exception){
          return false;
        }
      }
      else
        return false;
    }

    public T VerContenido(){
      return valor;
    }

    public T verContenidoIzquierdo(){
      return hijoIzquierdo.VerContenido();
    }

    public T verContenidoDerecho(){
      return hijoDerecho.VerContenido();
    }

    public T verContenidoPadre(){
      return padre.VerContenido();
    }
  }
}