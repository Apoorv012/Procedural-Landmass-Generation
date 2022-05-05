using UnityEngine;

public static class Noise
{
    public static float[,] GenerateNoiseMap(int MapWidth, int MapHeight, float scale)
    {
        float[,] noiseMap = new float[MapWidth, MapHeight];

        if (scale <= 0) scale = 0.0001f;

        for (int y = 0; y < MapHeight; y++)
        {
            for (int x = 0; x < MapWidth; x++)
            {
                float sampleX = x / scale;
                float sampleY = y / scale;

                float perlineValue = Mathf.PerlinNoise(sampleX, sampleY);
                noiseMap[x, y] = perlineValue;
            }
        }

        return noiseMap;
    }
}
