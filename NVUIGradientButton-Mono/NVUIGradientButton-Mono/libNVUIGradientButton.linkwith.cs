using System;
using ObjCRuntime;

[assembly: LinkWith ("libNVUIGradientButton.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Arm64 | LinkTarget.Simulator, ForceLoad = true)]
