using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum HeartStatus {
    Empty = 0,
    Half = 1,
    Full = 2,
}

public class HealthScript : MonoBehaviour
{
    public Sprite fullheart, halfHeart, emptyHeart;
    public Image heartImage;

    private void Awake() {
        heartImage = GetComponent<Image>();
    }

    public void SetHeartImage(HeartStatus status) {
        switch (status) {
            case HeartStatus.Empty:
                heartImage.sprite = emptyHeart;
                break;
            case HeartStatus.Half:
                heartImage.sprite = halfHeart;
                break;
            case HeartStatus.Full:
                heartImage.sprite = fullheart;
                break;

        }
    }


}


