using System;
using System.Collections.Generic;

namespace MoviesDotNetCore.Model
{
    public class EChartsGraph
    {
        public IEnumerable<EChartsNode> Nodes { get; set; }
        public IEnumerable<EChartsLink> Links { get; set; }
        public IEnumerable<EChartsCategory> Categories { get; set; }

        public EChartsGraph(IEnumerable<EChartsNode> nodes, IEnumerable<EChartsLink> links, IEnumerable<EChartsCategory> categories)
        {
            Nodes = nodes;
            Links = links;
            Categories = categories;
        }
    }

    public class EChartsNode
    {
        public string Name { get; set; }

        public int Value { get; set; }
        public int Category { get; set; }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;

            return Equals((EChartsNode) obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name);
        }

        protected bool Equals(EChartsNode other)
        {
            return Name == other.Name;
        } 
    }

    public class EChartsLink
    {
        public int Source { get; set; }
        public int Target { get; set; }

        public dynamic Label { get; set; }
    }

    public class EChartsCategory
    {
        public string Name { get; set; }
    }
}