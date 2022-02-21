using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DotWeenAnimation : MonoBehaviour
{
   
    void Start()
    {
        RunDotWeen();
    }

    private void RunDotWeen()
    {
        transform.DOScale(new Vector2(0.98f, 1.13f), 0.65f).OnComplete(() =>
          {
              transform.DOScale(new Vector2(1.13f, 0.98f), 0.65f).OnComplete(() =>
                {
                    RunDotWeen();
                });
          });
    }

   
}
