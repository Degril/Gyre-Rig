using UnityEngine.Events;

namespace Clicker
{
    public class ClicksData
    {
        private int clicksCount;

        public int ClicksCount => clicksCount;

        public UnityEvent<int> OnChanged { get; } = new UnityEvent<int>();

        public ClicksData(int clicksCount)
        {
            this.clicksCount = clicksCount;
        }

        public void OnClick()
        {
            clicksCount++;
            OnChanged.Invoke(clicksCount);
        }
        
    }
}