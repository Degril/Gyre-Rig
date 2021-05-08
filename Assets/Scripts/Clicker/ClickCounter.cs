using UnityEngine;
using UnityEngine.UI;

namespace Clicker
{
    public class ClickCounter : MonoBehaviour
    {
        [SerializeField] private Button clickButton;
        [SerializeField] private ClickView clickView;

        private ClicksData clicksData;

        private void Start()
        {
            clicksData = new ClicksData(0);
            clickView.Init(clicksData);
            clickButton.onClick.AddListener(() => clicksData.OnClick());
        }
    }
}
