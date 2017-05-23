using BinaireRekenmachine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaireRekenmachine.Factory
{
    class NodeFactory
    {
        private Dictionary<string, Type> _types;
        public void AddNodeType(string name, Type type) {
            _types.[name] = type;
        }

        public Node CreateNode(string type) {
            Type t = _types[type];
            Node n = (Node)Activator.CreateInstance(t);
            return n;
        }
    }
}
