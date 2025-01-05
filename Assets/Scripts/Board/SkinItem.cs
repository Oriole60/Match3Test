using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SkinItem", menuName = "Skin", order = 0)]

public class SkinItem : ScriptableObject
{
    [SerializeField] Sprite[] m_skin;

    public void SetSkin(int skinIndex, SpriteRenderer spriteItem)
    {
        if(spriteItem != null)
        {
            spriteItem.sprite = m_skin[skinIndex];
        }
    }

}
