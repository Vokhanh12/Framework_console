using System.Dynamic;
using System.Reflection.Metadata.Ecma335;
using Microsoft.VisualBasic;

class NodeChild<T>{

    private T _data;


    NodeChild(T data)
    {   
        _data = data;
    }


    public T get() => _data;



}