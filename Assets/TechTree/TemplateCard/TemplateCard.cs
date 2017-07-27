using UnityEngine;
using UnityEngine.UI;

public class TemplateCard : MonoBehaviour
{
    public ElementChildContainer LeftContainer;
    public ElementChildContainer RightContainer;

    public Text NameText;
    public Text ChildrenText;
    public Text FixIdText;

    private TemplateBase _template;
    private int _childCount = 0;

    private RectTransform _rectTransform;
    public Rect Size
    {
        get { return _rectTransform.rect; }
    }

    public void Awake()
    {
        _rectTransform = GetComponent<RectTransform>();
    }

    public void Initialise(TemplateBase template)
    {
        _template = template;

        Reload();

        Debug.Log("Collider size is " + Size);

    }

    private void Reload()
    {
        NameText.text = _template.Name;
        FixIdText.text = _template.FixedId;

        _childCount = LeftContainer.Children + RightContainer.Children;

        ChildrenText.text = _childCount.ToString();
    }
}

public class TemplateBase
{
    public string Name { get; set; }
    public string FixedId { get; set; }
}
