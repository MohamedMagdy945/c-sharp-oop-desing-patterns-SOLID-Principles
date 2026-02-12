using System.Collections.Generic;
namespace Architecture.DesignPatternPrinciple.StructuralDesignPatterns.FlyweightPattern
{
    public class TreeFactory
    {
        private Dictionary<string , TreeType> treeTypes = new Dictionary<string , TreeType>();
        public TreeType GetTreeType(string name , string color , string texture)
        {
            string key = name + color + texture;
            if(!treeTypes.ContainsKey(key))
            {
                treeTypes[key] = new TreeType(name, color, texture);
            }
            return treeTypes[key];
        }
    }
}
