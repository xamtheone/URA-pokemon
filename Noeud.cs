using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace URA_Pokemon
{
    public class Noeud
    {
        public string Nom;
        public Noeud ParentNode;
        public Stack<Noeud> ChildNodes = new Stack<Noeud>();

        public void AddChild(Noeud n)
        {
            ChildNodes.Push(n);
            n.ParentNode = this;
        }
    }

    
}
