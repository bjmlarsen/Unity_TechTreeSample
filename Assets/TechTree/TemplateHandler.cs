using System.Collections.Generic;
using UnityEngine;

namespace Assets.TechTree
{
    public class TemplateHandler : MonoBehaviour
    {
        public IEnumerable<TemplateBase> Templates { get; set; }

        public void Awake()
        {
            var list = new List<TemplateBase>();

            list.Add(CreateTemplate("LO01", "Temp1"));
            list.Add(CreateTemplate("LO02", "Temp2"));
            list.Add(CreateTemplate("LO03", "Temp3"));
            list.Add(CreateTemplate("LO04", "Temp4"));
            list.Add(CreateTemplate("LO05", "Temp5"));


            Templates = list;
        }

        private static TemplateBase CreateTemplate(string fixedId, string name)
        {
            return new TemplateBase { FixedId = fixedId, Name = name };
        }
    }
}