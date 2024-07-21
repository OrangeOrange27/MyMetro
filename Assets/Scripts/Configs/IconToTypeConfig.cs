using System;
using Core;
using UnityEngine;
using Utils;

namespace Configs
{
    [Serializable]
    public class IconToTypeConfig : SerializableDictionary<TravelType,Sprite>
    {
    }
}