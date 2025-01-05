using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using URandom = UnityEngine.Random;
using static NormalItem;

public class Utils
{
    public static NormalItem.eNormalType GetRandomNormalType()
    {
        Array values = Enum.GetValues(typeof(NormalItem.eNormalType));
        NormalItem.eNormalType result = (NormalItem.eNormalType)values.GetValue(URandom.Range(0, values.Length));

        return result;
    }

    public static NormalItem.eNormalType GetRandomNormalTypeExcept(NormalItem.eNormalType[] types)
    {
        List<NormalItem.eNormalType> list = Enum.GetValues(typeof(NormalItem.eNormalType)).Cast<NormalItem.eNormalType>().Except(types).ToList();

        int rnd = URandom.Range(0, list.Count);
        NormalItem.eNormalType result = list[rnd];

        return result;
    }

    public static eNormalType GetKeyWithSmallestValueExcludingNeighbours(eNormalType[] neighbourNormalTypes, Dictionary<eNormalType, int> normalItemDict)
    {
        var filteredDict = normalItemDict
            .Where(pair => !neighbourNormalTypes.Contains(pair.Key))
            .ToList();

        var smallestValuePair = filteredDict.OrderBy(pair => pair.Value).First();

        return smallestValuePair.Key;
    }
}
