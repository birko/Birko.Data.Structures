﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Birko.Data.Structures.Trees
{
    public abstract class BinarySearchNode: BinaryNode
    {
        public override Node Insert(Node node)
        {
            if (node == null) 
            {
                return null;
            }
            if (node is not BinaryNode binaryNode)
            {
                throw new ArgumentException("Node is not derived from BinaryNode");
            }
            if (CompareTo(node) < 0)
            {
                if (Children?.Last() == null)
                {
                    return InsertChild(binaryNode, 1);
                }
                else
                {
                    return Children.Last().Insert(node);
                }
            }
            else
            {
                if (Children?.First() == null)
                {
                    return InsertChild(binaryNode, 0);
                }
                else
                {
                    return Children.First().Insert(node);
                }
            }
        }
    }
}
