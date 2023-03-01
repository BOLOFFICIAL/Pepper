﻿using System.Collections.Generic;
using System.Drawing;
using Yolov5Net.Scorer.Models.Abstract;

namespace Yolov5Net.Scorer.Models
{
    public class YoloCocoP6Model : YoloModel
    {
        public override int Width { get; set; } = 1280;
        public override int Height { get; set; } = 1280;
        public override int Depth { get; set; } = 3;

        public override int Dimensions { get; set; } = 10;

        public override int[] Strides { get; set; } = new int[] { 8, 16, 32, 64 };

        public override int[][][] Anchors { get; set; } = new int[][][]
        {
            new int[][] { new int[] { 019, 027 }, new int[] { 044, 040 }, new int[] { 038, 094 } },
            new int[][] { new int[] { 096, 068 }, new int[] { 086, 152 }, new int[] { 180, 137 } },
            new int[][] { new int[] { 140, 301 }, new int[] { 303, 264 }, new int[] { 238, 542 } },
            new int[][] { new int[] { 436, 615 }, new int[] { 739, 380 }, new int[] { 925, 792 } }
        };

        public override int[] Shapes { get; set; } = new int[] { 160, 80, 40, 20 };

        public override float Confidence { get; set; } = 0.20f;
        public override float MulConfidence { get; set; } = 0.25f;
        public override float Overlap { get; set; } = 0.45f;

        public override string[] Outputs { get; set; } = new[] { "output0" };

        public override List<YoloLabel> Labels { get; set; } = new List<YoloLabel>()
        {
            new YoloLabel { Id = 1, Name = "0", Color = Color.Black },
            new YoloLabel { Id = 1, Name = "alternariosis", Color = Color.Red },
            new YoloLabel { Id = 2, Name = "cracking to pulp", Color = Color.Blue },
            new YoloLabel { Id = 3, Name = "qualitative", Color = Color.Yellow },
            new YoloLabel { Id = 4, Name = "rot", Color = Color.Green  },
        };

        public override bool UseDetect { get; set; } = true;

        public YoloCocoP6Model()
        {

        }
    }
}
