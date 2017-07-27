using UnityEngine;

namespace Assets.TechTree
{
    public class TechTree : MonoBehaviour
    {
        public TemplateHandler TemplateHandler;

        public GameObject TemplateCardPrefab;

        public Transform TechTreeContainer;
        // Use this for initialization
        void Start()
        {
            foreach (var entry in TemplateHandler.Templates)
            {
                var obj = Instantiate(TemplateCardPrefab, TechTreeContainer);
                var script = obj.GetComponent<TemplateCard>();
                script.Initialise(entry);
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
