﻿namespace tppubd
{
    class Program
    {
        static void Main(string[] args)
        {
            // ImageService.GetImages();

            AnalyticService.DetectFaceExtract().Wait();
        }
    }
}