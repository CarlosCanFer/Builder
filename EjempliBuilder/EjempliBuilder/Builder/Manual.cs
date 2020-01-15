using System.Collections.Generic;

namespace EjempliBuilder.Builder
{
    public class Manual
    {
        private List<object> _parts = new List<object>();

        public void Add(string parts)
        {
            this._parts.Add(parts);
        }

        public string ListParts()
        {
            string str = string.Empty;
            for (int i = 0; i < this._parts.Count; i++)
            {
                str += this._parts[i] + ", ";
            }

           return "Parte del producto: " + str + "\n";
        }
    }
}
