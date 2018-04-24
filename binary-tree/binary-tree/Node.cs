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
      padre = null;
    }

    // Crea un nodo hijo del nodo especificado
    public Node(T valor, Node<T> padre)
    {
      this.valor = valor;
      hijoIzquierdo = null;
      hijoDerecho = null;
      this.padre = padre;
    }

    // Recibe un valor, y si alguno de los nodos hijos esta libre crea un nuevo nodo hijo con el valor y 
    // retorna true. Si ambos nodos estan ocupados retorna false
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

    // Retorna el contenido del nodo actual.
    // Para ver el contenido de los nodos relacionados podemos anidar llamadas a esta funcion, 
    // o si necesitamos el de alguno de los hijos o padre (movernos solo un nivel) podemos usar
    // los accesos directos definidos abajo
    public T VerContenido(){
      return valor;
    }

    // Acceso directo a contenido hijo izquierdo
    public T VerContenidoIzquierdo(){
      return hijoIzquierdo.VerContenido();
    }

    // Acceso directo a contenido hijo derecho
    public T VerContenidoDerecho(){
      return hijoDerecho.VerContenido();
    }

    // Acceso directo a contenido padre
    public T VerContenidoPadre(){
      return padre.VerContenido();
    }

    // Recibe un valor y si el valor de alguno de los nodos hijos es igual, lo elimina (define como null) y retorna
    // true. Si ninguno de los hijos tiene ese valor retorna false.
    public Boolean EliminaNodo(T valor){
      if (this.VerContenidoIzquierdo().Equals(valor))
      {
        hijoIzquierdo = null;
        return true;
      }
      else if (this.VerContenidoDerecho().Equals(valor)){
        hijoDerecho = null;
        return true;
      }
      return false;
    }
  }
}