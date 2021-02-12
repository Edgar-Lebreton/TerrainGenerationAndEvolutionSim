using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class TerrainData : UpdatableData
{
    public float uniformScale = 5f;

    public bool useFlatShading;

    public bool useFallOff;

    public float meshHeightMultiplier;
    public AnimationCurve meshHeightCurve;
}
