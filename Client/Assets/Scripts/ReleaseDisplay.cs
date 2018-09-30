using UnityEngine;
using StartBrace.Beholder.Common;

namespace StartBrace.Beholder.Client
{
    public class ReleaseDisplay : MonoBehaviour
    {
        private void OnGUI()
        {
            GUI.Label(new Rect(0, 0, Screen.width, Screen.height), BeholderConstants.ReleaseName);
        }
    }
}