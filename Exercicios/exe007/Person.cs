using System;
using System.Collections.Generic;

namespace exe007
{
    // Definição da classe Person
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }

        public Person() { }

        public Person(int id, string name, string role)
        {
            Id = id;
            Name = name;
            Role = role;
        }
    }

    // Definição básica de uma árvore genérica
    public class Tree<T>
    {
        public TreeNode<T> Root { get; set; }
    }

    // Definição básica de um nó de árvore genérica
    public class TreeNode<T>
    {
        public T Data { get; set; }
        public TreeNode<T> Parent { get; set; }
        public List<TreeNode<T>> Children { get; set; } = new List<TreeNode<T>>();
    }
}
