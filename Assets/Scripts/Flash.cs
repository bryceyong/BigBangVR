using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flash : MonoBehaviour
{
    public void start(){
        FadeOut();
    }
    public CanvasGroup uiElement;
    // Start is called before the first frame update
    public void FadeOut()
    {
        StartCoroutine(FadeCanvasGroup(uiElement, uiElement.alpha, 0));
    }
    public IEnumerator FadeCanvasGroup(CanvasGroup cg, float start, float end, float lerpTime = 0.5f)
    {

        float _timeStartedLerping = Time.time;
        float _timeSinceStarted = Time.time -_timeStartedLerping;
        float percentageComplete = _timeSinceStarted / lerpTime;

        while(true)
        {
            _timeSinceStarted = Time.time - _timeStartedLerping;
            percentageComplete = _timeSinceStarted / lerpTime;
            float currentValue = Mathf.Lerp(start, end, percentageComplete);
            cg.alpha = currentValue;
            if(percentageComplete >= 1) break;
            yield return new WaitForEndOfFrame();
        }

        print("done");
    }
}
