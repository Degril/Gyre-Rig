using UnityEngine;
using UnityEngine.UI;

namespace Clicker
{
    public class ClickView : MonoBehaviour
    {
        [SerializeField] private Text text;
        public void Init(ClicksData clicksData)
        {
            clicksData.OnChanged.AddListener(UpdateClick);
            UpdateClick(clicksData.ClicksCount);
        }

        private void UpdateClick(int clicksCount)
        {
            text.text = clicksCount.ToString();
        }
    }
}